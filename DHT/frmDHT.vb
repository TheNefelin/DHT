Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class frmDHT

    Private PC01 As String
    Private PC02 As String
    Private Fecha As DateTime

    Private Sub frmDHT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Network
        Me.Text = "Monitor de Temperatura y Humedad"

        CheckForIllegalCrossThreadCalls = False

        rbtCliente.Checked = True
        cbxTazaTrans.SelectedIndex = 0
    End Sub

    Private Sub txtTMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTMin.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back) Then
            'Permite que el evento continue
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And Asc(e.KeyChar) = Keys.V) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTMax.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back) Then
            'Permite que el evento continue
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And Asc(e.KeyChar) = Keys.V) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIpServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIpServer.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or e.KeyChar = ".") Then
            'Permite que el evento continue
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And Asc(e.KeyChar) = Keys.V) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPuertoServer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPuertoServer.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back) Then
            'Permite que el evento continue
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And Asc(e.KeyChar) = Keys.V) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtParaEnviar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParaEnviar.KeyPress
        If (Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = Keys.Space Or Asc(e.KeyChar) = Keys.Back) Then
            'Permite que el evento continue
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And Asc(e.KeyChar) = Keys.V) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BloquearRB()
        If SerialPort1.IsOpen Or btnConectarTcp.Enabled = False Then
            pnlRB.Enabled = False
            txtTMin.Enabled = False
            txtTMax.Enabled = False
        Else
            pnlRB.Enabled = True
            txtTMin.Enabled = True
            txtTMax.Enabled = True
        End If
    End Sub
    Private Sub rbtCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCliente.CheckedChanged
        If rbtCliente.Checked Then
            pnlDHT.Enabled = False
            txtIpServer.Text = ""
            txtIpServer.Enabled = True
            txtIpServer.TabIndex = 0
            txtPuertoServer.Enabled = True
            btnConectarTcp.Text = "Conectar a" & vbCrLf & "Servidor"
            btnOcultar.Enabled = False

            PC01 = "(Cliente):"
            PC02 = "(Servidor):"
        End If
    End Sub

    Private Sub rbtServidor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtServidor.CheckedChanged
        If rbtServidor.Checked Then
            pnlDHT.Enabled = True
            txtIpServer.Enabled = False
            IpServer()
            txtPuertoServer.Enabled = False
            btnConectarTcp.Text = "Iniciar" & vbCrLf & "Servidor"
            btnOcultar.Enabled = True

            PC01 = "(Servidor):"
            PC02 = "(Cliente):"
        End If
    End Sub

    Private Sub btnBuscarPuertos_Click(sender As Object, e As EventArgs) Handles btnBuscarPuertos.Click
        cbxPuertosCOM.Items.Clear()
        cbxPuertosCOM.Items.AddRange(Ports.SerialPort.GetPortNames())

        If cbxPuertosCOM.Items.Count > 0 Then
            cbxPuertosCOM.SelectedIndex = 0
            btnConectarDHT.Enabled = True
            cbxPuertosCOM.Enabled = True
        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectarDHT.Click
        Try
            btnBuscarPuertos.Enabled = False
            cbxPuertosCOM.Enabled = False
            cbxTazaTrans.Enabled = False
            btnConectarDHT.Enabled = False
            btnDesconectarDHT.Enabled = True

            SerialPort1.PortName = cbxPuertosCOM.SelectedItem
            SerialPort1.BaudRate = cbxTazaTrans.SelectedItem
            SerialPort1.Open()

            Timer1.Interval = 125
            Timer1.Start()

            txtVisor.AppendText("-- " & PC01 & " Sensor DHT Conectado al Puerto " & cbxPuertosCOM.Text & Environment.NewLine)
            BloquearRB()
        Catch ex As Exception
            txtVisor.AppendText("-- " & PC01 & " ERROR btnConectar: " & ex.Message.ToString & Environment.NewLine)
        End Try
    End Sub

    Private Sub btnDesconectarDHT_Click(sender As Object, e As EventArgs) Handles btnDesconectarDHT.Click
        SerialPort1.Close()
        Timer1.Stop()

        TransmitirDatos("0,00", "0,00")
        Semaforo("0,00", "0,00")

        btnBuscarPuertos.Enabled = True
        cbxPuertosCOM.Enabled = True
        cbxTazaTrans.Enabled = True
        btnConectarDHT.Enabled = True
        btnDesconectarDHT.Enabled = False

        BloquearRB()

        txtVisor.AppendText("-- " & PC01 & " Sensor DHT Desconectado " & Environment.NewLine)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If SerialPort1.BytesToRead > 0 Then
                Dim i As String = SerialPort1.ReadLine.Replace(".", ",")

                If CDec(i.Substring(0, i.IndexOf("-"))) Or (i.Substring(i.IndexOf("-") + 1, i.Length - i.IndexOf("-") - 2)) Then
                    Dim h As Decimal = i.Substring(0, i.IndexOf("-"))
                    Dim t As Decimal = i.Substring(i.IndexOf("-") + 1, i.Length - i.IndexOf("-") - 2)

                    TransmitirDatos(h, t)
                    Semaforo(h, t)
                End If
            Else
                txtVisor.AppendText("-- " & PC01 & " No se Esta Recibido Datos del Puerto " & cbxPuertosCOM.Text & Environment.NewLine)
                btnDesconectarDHT.PerformClick()
            End If
        Catch ex As Exception
            btnDesconectarDHT.PerformClick()
            txtVisor.AppendText("-- " & PC01 & " ERROR Timer1: " & ex.Message.ToString & Environment.NewLine)
        End Try
    End Sub

    Private Sub Semaforo(h As Decimal, t As Decimal)
        lblHumerdad.Text = h & "% Humedad"
        lblTemperatura.Text = t & "° Temperatura"

        If CInt(txtTMin.Text) = CInt(txtTMax.Text) Then
            pbxImgVerde.Image = My.Resources.Blanco
            pbxImgAmarillo.Image = My.Resources.Blanco
            pbxImgRojo.Image = My.Resources.Blanco
        ElseIf CInt(t) >= CInt(txtTMin.Text) And CInt(t) <= CInt(txtTMax.Text) Then
            pbxImgVerde.Image = My.Resources.Blanco
            pbxImgAmarillo.Image = My.Resources.Amarillo
            pbxImgRojo.Image = My.Resources.Blanco
        ElseIf CInt(t) < CInt(txtTMin.Text) Then
            pbxImgVerde.Image = My.Resources.Verde
            pbxImgAmarillo.Image = My.Resources.Blanco
            pbxImgRojo.Image = My.Resources.Blanco
        ElseIf CInt(t) > CInt(txtTMax.Text) Then
            pbxImgVerde.Image = My.Resources.Blanco
            pbxImgAmarillo.Image = My.Resources.Blanco
            pbxImgRojo.Image = My.Resources.Rojo
        End If
    End Sub

    Private Sub IpServer()
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName())

        For Each direccion As IPAddress In localIP
            If direccion.AddressFamily = AddressFamily.InterNetwork Then
                txtIpServer.Text = direccion.ToString
            End If
        Next
    End Sub

    Private Sub TransmitirDatos(h As String, t As String)
        If rbtServidor.Checked Then
            If lblHumerdad.Text <> h & "% Humedad" Or lblTemperatura.Text <> t & "° Temperatura" Then
                Fecha = DateTime.Now
                txtVisor.AppendText("-- " & PC01 & " " & h & "% Humedad - " & t & "° Temperatura (" & Fecha & ")" & Environment.NewLine)

                For Each cli As TcpClient In listaCliente
                    STW = New StreamWriter(cli.GetStream)
                    STW.AutoFlush = True
                    STW.WriteLine(h & "%|||||" & t & "°|||||" & Fecha)
                Next
            End If
        End If
    End Sub

    Private Sub btnsConexion(Conectado As Boolean)
        If Conectado Then
            btnDesconectarTcp.Enabled = True
            btnConectarTcp.Enabled = False

            If rbtCliente.Checked Then
                txtIpServer.Enabled = False
                txtPuertoServer.Enabled = False
            End If

            txtParaEnviar.Focus()
        Else
            btnDesconectarTcp.Enabled = False
            btnConectarTcp.Enabled = True

            If rbtCliente.Checked Then
                txtIpServer.Enabled = True
                txtPuertoServer.Enabled = True
            End If

            txtIpServer.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtVisor.Text = ""
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If txtVisor.Text.Trim <> "" Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Archivo .txt (*.txt*)|*.txt*"
            SaveFileDialog1.FileName = DateTime.Today & " - RegistroDHT.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                File.WriteAllText(SaveFileDialog1.FileName(), txtVisor.Text)
                Process.Start(SaveFileDialog1.FileName)
            End If
        Else
            txtVisor.AppendText("-- " & PC01 & "No Hay Datos para Exportar" & Environment.NewLine)
        End If
    End Sub

    Private Sub frmDHT_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        btnDesconectarDHT.PerformClick()
        btnDesconectarTcp.PerformClick()
    End Sub

    Private servidor As TcpListener
    Private cliente As TcpClient
    Private listaCliente As New List(Of TcpClient)
    Private STR As StreamReader
    Private STW As StreamWriter
    Private msgeRecibido As String
    Private msgeAEnviar As String

    Private Sub IniciarServidor()
        Dim nuevoCliente As TcpClient

        Try
            nuevoCliente = servidor.AcceptTcpClient
            listaCliente.Add(nuevoCliente)
            Threading.ThreadPool.QueueUserWorkItem(AddressOf IniciarServidor)

            Do
                STR = New StreamReader(nuevoCliente.GetStream)
                msgeRecibido = ""
                msgeRecibido = STR.ReadLine

                If msgeRecibido = "||||Cliente Conectado||||" Then
                    txtVisor.AppendText("-- " & PC01 & " Cliente Nuevo Conectado: " & listaCliente.Count & Environment.NewLine)
                ElseIf msgeRecibido = "||||Cliente Desconectado||||" Then
                    If listaCliente.Contains(nuevoCliente) Then
                        listaCliente.Remove(nuevoCliente)
                    End If

                    txtVisor.AppendText("-- " & PC01 & " Cliente: " & listaCliente.Count & " Desconectado" & Environment.NewLine)
                    Exit Do
                ElseIf msgeRecibido <> "" Then
                    For Each cli As TcpClient In listaCliente
                        STW = New StreamWriter(cli.GetStream)
                        STW.AutoFlush = True
                        STW.WriteLine(msgeRecibido)
                    Next
                    txtVisor.AppendText(msgeRecibido & Environment.NewLine)
                End If
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DetenerServidor()
        btnsConexion(False)
        BloquearRB()

        For i = listaCliente.Count - 1 To 0 Step -1
            STW = New StreamWriter(listaCliente.Item(i).GetStream())
            STW.AutoFlush = True
            STW.WriteLine("||||Cliente Desconectado Desde el Servidor||||")
            Thread.Sleep(100)
        Next

        txtVisor.AppendText("-- " & PC01 & " Servidor Desconectado" & Environment.NewLine)
        servidor.Stop()
        listaCliente.Clear()
    End Sub

    Private Sub IniciarCliente()
        Try
            STW = New StreamWriter(cliente.GetStream)
            STW.AutoFlush = True
            STW.WriteLine("||||Cliente Conectado||||")
            Do
                STR = New StreamReader(cliente.GetStream)
                msgeRecibido = ""
                msgeRecibido = STR.ReadLine

                If msgeRecibido = "||||Cliente Desconectado Desde el Servidor||||" Then
                    txtVisor.AppendText("-- " & PC01 & " Cliende Desconectado Desde el Servidor" & Environment.NewLine)
                    DetenerCliente()
                    Exit Do
                ElseIf msgeRecibido <> "" Then
                    If (msgeRecibido.IndexOf("%")) <> -1 Then
                        Dim h As Decimal = msgeRecibido.Substring(0, msgeRecibido.IndexOf("%"))
                        msgeRecibido = msgeRecibido.Substring(msgeRecibido.IndexOf("|||||") + 5, msgeRecibido.Length - (msgeRecibido.IndexOf("|||||") + 5))
                        Dim t As Decimal = msgeRecibido.Substring(0, msgeRecibido.IndexOf("°"))
                        Fecha = msgeRecibido.Substring(msgeRecibido.IndexOf("|||||") + 5, msgeRecibido.Length - (msgeRecibido.IndexOf("|||||") + 5))

                        txtVisor.AppendText("-- " & PC02 & " " & h & "% Humedad - " & t & "s° Temperatura (" & Fecha.ToString & ")" & Environment.NewLine)
                        Semaforo(h, t)
                    Else
                        txtVisor.AppendText(msgeRecibido & Environment.NewLine)
                    End If
                End If
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DetenerCliente()
        btnsConexion(False)
        BloquearRB()

        If cliente.Connected Then
            STW = New StreamWriter(cliente.GetStream)
            STW.AutoFlush = True
            STW.WriteLine("||||Cliente Desconectado||||")
            txtVisor.AppendText("-- " & PC01 & " Cliente Desconectado" & Environment.NewLine)

            Thread.Sleep(100)

            cliente.Client.Disconnect(False)
            cliente.Close()
        Else
            txtVisor.AppendText("-- " & PC01 & " Cliente No Esta Conectado" & Environment.NewLine)
        End If
    End Sub

    Private Sub btnEnviarDatosTcp_Click(sender As Object, e As EventArgs) Handles btnEnviarDatosTcp.Click
        Try
            If txtParaEnviar.Text.Trim <> "" Then
                msgeAEnviar = txtParaEnviar.Text
                msgeAEnviar = "-- " & PC01 & " " & msgeAEnviar
                txtParaEnviar.Text = ""

                If rbtCliente.Checked Then
                    If cliente IsNot Nothing Then
                        If cliente.Connected Then
                            Dim STW = New StreamWriter(cliente.GetStream)
                            STW.AutoFlush = True
                            STW.WriteLine(msgeAEnviar)
                        Else
                            txtVisor.AppendText("-- " & PC01 & " El Cliente no Esta Conetado al Servidor" & Environment.NewLine)
                        End If
                    Else
                        txtVisor.AppendText("-- " & PC01 & " El Cliente no Esta Conetado al Servidor" & Environment.NewLine)
                    End If
                ElseIf rbtServidor.Checked Then
                    For Each cli As TcpClient In listaCliente
                        STW = New StreamWriter(cli.GetStream)
                        STW.AutoFlush = True
                        STW.WriteLine(msgeAEnviar)
                    Next

                    txtVisor.AppendText(msgeAEnviar & Environment.NewLine)
                End If
            Else
                txtVisor.AppendText("-- " & PC01 & " No Hay texto par Enviar" & Environment.NewLine)
            End If
        Catch ex As Exception
            txtVisor.AppendText("-- " & PC01 & " ERROR Enviar Datos: " & ex.Message.ToString & Environment.NewLine)
        End Try
    End Sub

    Private Sub btnConectarTcp_Click(sender As Object, e As EventArgs) Handles btnConectarTcp.Click
        btnsConexion(True)

        Try
            If IPAddress.TryParse(txtIpServer.Text.Trim, IPAddress.Any) And IsNumeric(txtPuertoServer.Text.Trim) Then
                If rbtServidor.Checked Then
                    servidor = New TcpListener(IPAddress.Any, Integer.Parse(txtPuertoServer.Text))
                    servidor.Start()
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf IniciarServidor)
                    txtVisor.AppendText("-- " & PC01 & " Servidor Inciciado, Esperando Cliente Nuevo" & Environment.NewLine)
                ElseIf rbtCliente.Checked Then
                    cliente = New TcpClient(txtIpServer.Text, Integer.Parse(txtPuertoServer.Text))
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf IniciarCliente)
                    txtVisor.AppendText("-- " & PC01 & " Cliente Conectado" & Environment.NewLine)
                End If
            Else
                txtVisor.AppendText("-- " & PC01 & " La IP es Incorrecta" & Environment.NewLine)
                btnsConexion(False)
            End If
        Catch ex As Exception
            txtVisor.AppendText("-- " & PC01 & " ERROR btnConectarTcp: " & ex.Message.ToString & Environment.NewLine)
            btnsConexion(False)
        End Try

        BloquearRB()
    End Sub

    Private Sub btnDesconectarTcp_Click(sender As Object, e As EventArgs) Handles btnDesconectarTcp.Click
        If rbtServidor.Checked Then
            DetenerServidor()
        ElseIf rbtCliente.Checked Then
            DetenerCliente()
        End If
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        Me.Hide()
    End Sub
End Class
