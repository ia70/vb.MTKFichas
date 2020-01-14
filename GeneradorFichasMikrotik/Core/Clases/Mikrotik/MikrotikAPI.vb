Public Class MikrotikAPI
    Private IP As String = ""                   'Dirección IP del Mikrotik
    Private Puerto As Integer = 0               'Puerto a la escucha
    Private Usuario As String = ""              'Nombre de usuario
    Private Password As String = ""             'Contraseña de usuario
    Private EstadoConexion As Boolean = False   'Estado de la conexiòn True -> Abierta

    Dim TCP_Stream As IO.Stream
    Dim TCP_pCon As New Net.Sockets.TcpClient

    Public Property Estado As Boolean
        Get
            Return EstadoConexion
        End Get
        Set(value As Boolean)
            EstadoConexion = value
        End Set
    End Property

    ''' <summary>
    ''' Establece parámetros conexión con el dispositivo Mikrotik
    ''' </summary>
    ''' <param name="_ip">Dirección IP</param>
    ''' <param name="_usuario">Nombre de Usuario</param>
    ''' <param name="_pass">Contraseña</param>
    ''' <param name="_puerto">Puerto</param>
    Public Sub New(Optional ByVal _ip As String = "", Optional ByVal _usuario As String = "", Optional ByVal _pass As String = "", Optional ByVal _puerto As Integer = 8728)
        If Not _ip = "" And Not _usuario = "" And Not _pass = "" Then
            IP = _ip
            Usuario = _usuario
            Password = _pass
            If _puerto = -1 Or _puerto = 0 Then
                Puerto = 8728
            Else
                Puerto = _puerto
            End If
        End If
    End Sub

    ''' <summary>
    ''' Abre conexión con el dispositivo Mikrotik
    ''' </summary>
    ''' <param name="_ip">Dirección IP</param>
    ''' <param name="_usuario">Nombre de Usuario</param>
    ''' <param name="_pass">Contraseña</param>
    ''' <param name="_puerto">Puerto</param>
    ''' <returns>
    ''' True - Si se realizo la conexión correctamente
    ''' False - Si se generó algun error
    ''' </returns>
    Public Function Open(Optional ByVal _ip As String = "", Optional ByVal _usuario As String = "", Optional ByVal _pass As String = "", Optional ByVal _puerto As Integer = 8728) As Boolean
        If Not _ip = "" And Not _usuario = "" And Not _pass = "" Then
            IP = _ip
            Usuario = _usuario
            Password = _pass
        ElseIf IP = "" Or Usuario = "" Or Password = "" Then
            Return False
        End If

        If _puerto = -1 Or _puerto = 0 Then
            Puerto = 8728
        Else
            Puerto = _puerto
        End If

        'Try
        On Error Resume Next
        Dim ips = Net.Dns.GetHostEntry(IP)
        On Error Resume Next
        TCP_pCon.Connect(ips.AddressList(0), Puerto)
        On Error Resume Next
        TCP_Stream = TCP_pCon.GetStream()

        Return Login()
        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> Open")
        'End If
        'Return False
        'End Try

    End Function

    Public Sub Close()
        'Try
        On Error Resume Next
        TCP_Stream.Close()
        On Error Resume Next
        TCP_pCon.Close()
        On Error Resume Next
        TCP_Stream = Nothing
        On Error Resume Next
        TCP_pCon = Nothing
        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> Close")
        'End If
        'End Try

    End Sub

    Public Function Login() As Boolean
        'Try

        Send("/login", True)
        Dim hash = Read()(0).Split(New String() {"ret="}, StringSplitOptions.None)(1)
        Send("/login")
        Send("=name=" + Usuario)
        Send("=response=00" + EncodePassword(Password, hash), True)
        Dim res = Read()
        If (res(0) = "!done") Then
            Return True
        Else
            Return False
        End If

        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> Login")
        'End If
        'Return False
        'End Try
    End Function

    Public Sub Send(ByVal command As String, Optional ByVal EndSentence As Boolean = False)
        'Try
        On Error Resume Next
        Dim bytes = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray())
        On Error Resume Next
        Dim size = EncodeLength(bytes.Length)

        On Error Resume Next
        TCP_Stream.Write(size, 0, size.Length)
        On Error Resume Next
        TCP_Stream.Write(bytes, 0, bytes.Length)
        If EndSentence Then
            On Error Resume Next
            TCP_Stream.WriteByte(0)
        End If
        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> Send")
        'End If
        'End Try

    End Sub

#Region "Tecnico"

    Public Function Read() As List(Of String)
        Dim output As New List(Of String)
        Dim o = ""
        Dim tmp(4) As Byte
        Dim count As Long

        'Try
        While True
            On Error Resume Next
            tmp(3) = TCP_Stream.ReadByte()
                Select Case tmp(3)
                    Case 0
                        output.Add(o)
                        If o.Substring(0, 5) = "!done" Then
                            Exit While
                        Else
                            o = ""
                            Continue While
                        End If
                    Case Is < &H80
                        count = tmp(3)
                Case Is < &HC0
                    On Error Resume Next
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(3), 0, 0}, 0) ^ &H8000
                    Case Is < &HE0
                    tmp(2) = TCP_Stream.ReadByte()
                    On Error Resume Next
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(2), tmp(3), 0}, 0) ^ &HC00000
                    Case Is < &HF0
                        tmp(2) = TCP_Stream.ReadByte()
                    tmp(1) = TCP_Stream.ReadByte()
                    On Error Resume Next
                    count = BitConverter.ToInt32(New Byte() {TCP_Stream.ReadByte(), tmp(1), tmp(2), tmp(3)}, 0) ^ &HE0000000
                    Case &HF0
                        tmp(3) = TCP_Stream.ReadByte()
                        tmp(2) = TCP_Stream.ReadByte()
                        tmp(1) = TCP_Stream.ReadByte()
                    tmp(0) = TCP_Stream.ReadByte()
                    On Error Resume Next
                    count = BitConverter.ToInt32(tmp, 0)
                    Case Else
                        Exit While   'err
                End Select

            For i = 0 To count - 1
                On Error Resume Next
                o += ChrW(TCP_Stream.ReadByte())
            Next
        End While
        'Catch ex As Exception
        'If Config_MostrarError Then
        '     MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> Read")
        '  End If
        '   Return Nothing
        'End Try

        Return output
    End Function

    Private Function EncodeLength(ByVal l As Integer) As Byte()
        'Try
        If l < &H80 Then
            On Error Resume Next
            Dim tmp = BitConverter.GetBytes(l)
            Return New Byte() {tmp(0)}
        ElseIf l < &H4000 Then
            On Error Resume Next
            Dim tmp = BitConverter.GetBytes(l Or &H8000)
            Return New Byte() {tmp(1), tmp(0)}
        ElseIf l < &H200000 Then
            On Error Resume Next
            Dim tmp = BitConverter.GetBytes(l Or &HC00000)
            Return New Byte() {tmp(2), tmp(1), tmp(0)}
        ElseIf l < &H10000000 Then
            On Error Resume Next
            Dim tmp = BitConverter.GetBytes(l Or &HE0000000)
            Return New Byte() {tmp(3), tmp(2), tmp(1), tmp(0)}
        Else
            On Error Resume Next
            Dim tmp = BitConverter.GetBytes(l)
            Return New Byte() {&HF0, tmp(3), tmp(2), tmp(1), tmp(0)}
        End If
        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> EncodeLenght")
        'End If
        'Return Nothing
        'End Try
    End Function

    Private Function EncodePassword(ByVal pass As String, ByVal challange As String) As String
        'Try
        On Error Resume Next
        Dim hash_byte(challange.Length / 2 - 1) As Byte

        For i = 0 To challange.Length - 2 Step 2
            On Error Resume Next
            hash_byte(i / 2) = Byte.Parse(challange.Substring(i, 2), Globalization.NumberStyles.HexNumber)
        Next
        On Error Resume Next
        Dim response(pass.Length + hash_byte.Length) As Byte
        response(0) = 0
        On Error Resume Next
        Text.Encoding.ASCII.GetBytes(pass.ToCharArray()).CopyTo(response, 1)
        On Error Resume Next
        hash_byte.CopyTo(response, 1 + pass.Length)

        On Error Resume Next
        Dim md5 = New System.Security.Cryptography.MD5CryptoServiceProvider()

        On Error Resume Next
        Dim hash = md5.ComputeHash(response)

        Dim hashStr As New Text.StringBuilder()
        For Each h In hash
            On Error Resume Next
            hashStr.Append(h.ToString("x2"))
        Next
        Return hashStr.ToString()
        'Catch ex As Exception
        'If Config_MostrarError Then
        'MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "MikrotikAPI -> EncodePassword")
        'End If
        'Return ""
        'End Try
    End Function


#End Region
End Class
