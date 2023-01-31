<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDHT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnEnviarDatosTcp = New System.Windows.Forms.Button()
        Me.txtParaEnviar = New System.Windows.Forms.TextBox()
        Me.txtVisor = New System.Windows.Forms.TextBox()
        Me.btnConectarTcp = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPuertoServer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIpServer = New System.Windows.Forms.TextBox()
        Me.pnlRB = New System.Windows.Forms.Panel()
        Me.rbtServidor = New System.Windows.Forms.RadioButton()
        Me.rbtCliente = New System.Windows.Forms.RadioButton()
        Me.pnlDHT = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTazaTrans = New System.Windows.Forms.ComboBox()
        Me.btnBuscarPuertos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxPuertosCOM = New System.Windows.Forms.ComboBox()
        Me.btnDesconectarDHT = New System.Windows.Forms.Button()
        Me.btnConectarDHT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHumerdad = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTMax = New System.Windows.Forms.TextBox()
        Me.txtTMin = New System.Windows.Forms.TextBox()
        Me.pbxImgRojo = New System.Windows.Forms.PictureBox()
        Me.pbxImgAmarillo = New System.Windows.Forms.PictureBox()
        Me.pbxImgVerde = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDesconectarTcp = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnOcultar = New System.Windows.Forms.Button()
        Me.pnlRB.SuspendLayout()
        Me.pnlDHT.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxImgRojo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImgAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImgVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviarDatosTcp
        '
        Me.btnEnviarDatosTcp.Location = New System.Drawing.Point(556, 422)
        Me.btnEnviarDatosTcp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEnviarDatosTcp.Name = "btnEnviarDatosTcp"
        Me.btnEnviarDatosTcp.Size = New System.Drawing.Size(121, 36)
        Me.btnEnviarDatosTcp.TabIndex = 26
        Me.btnEnviarDatosTcp.Text = "Enviar"
        Me.btnEnviarDatosTcp.UseVisualStyleBackColor = True
        '
        'txtParaEnviar
        '
        Me.txtParaEnviar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParaEnviar.Location = New System.Drawing.Point(12, 422)
        Me.txtParaEnviar.MaxLength = 1000
        Me.txtParaEnviar.Multiline = True
        Me.txtParaEnviar.Name = "txtParaEnviar"
        Me.txtParaEnviar.Size = New System.Drawing.Size(537, 76)
        Me.txtParaEnviar.TabIndex = 25
        '
        'txtVisor
        '
        Me.txtVisor.Location = New System.Drawing.Point(12, 254)
        Me.txtVisor.Multiline = True
        Me.txtVisor.Name = "txtVisor"
        Me.txtVisor.ReadOnly = True
        Me.txtVisor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVisor.Size = New System.Drawing.Size(665, 162)
        Me.txtVisor.TabIndex = 24
        '
        'btnConectarTcp
        '
        Me.btnConectarTcp.Location = New System.Drawing.Point(219, 209)
        Me.btnConectarTcp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConectarTcp.Name = "btnConectarTcp"
        Me.btnConectarTcp.Size = New System.Drawing.Size(110, 40)
        Me.btnConectarTcp.TabIndex = 23
        Me.btnConectarTcp.Text = "Iniciar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conexion"
        Me.btnConectarTcp.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Puerto"
        '
        'txtPuertoServer
        '
        Me.txtPuertoServer.Location = New System.Drawing.Point(154, 227)
        Me.txtPuertoServer.MaxLength = 8
        Me.txtPuertoServer.Name = "txtPuertoServer"
        Me.txtPuertoServer.Size = New System.Drawing.Size(58, 21)
        Me.txtPuertoServer.TabIndex = 21
        Me.txtPuertoServer.Text = "80"
        Me.txtPuertoServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "IP Servidor"
        '
        'txtIpServer
        '
        Me.txtIpServer.Location = New System.Drawing.Point(12, 227)
        Me.txtIpServer.MaxLength = 15
        Me.txtIpServer.Name = "txtIpServer"
        Me.txtIpServer.Size = New System.Drawing.Size(137, 21)
        Me.txtIpServer.TabIndex = 19
        Me.txtIpServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlRB
        '
        Me.pnlRB.BackColor = System.Drawing.Color.Bisque
        Me.pnlRB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRB.Controls.Add(Me.rbtServidor)
        Me.pnlRB.Controls.Add(Me.rbtCliente)
        Me.pnlRB.Location = New System.Drawing.Point(12, 12)
        Me.pnlRB.Name = "pnlRB"
        Me.pnlRB.Size = New System.Drawing.Size(96, 51)
        Me.pnlRB.TabIndex = 18
        '
        'rbtServidor
        '
        Me.rbtServidor.AutoSize = True
        Me.rbtServidor.Location = New System.Drawing.Point(8, 22)
        Me.rbtServidor.Name = "rbtServidor"
        Me.rbtServidor.Size = New System.Drawing.Size(78, 19)
        Me.rbtServidor.TabIndex = 1
        Me.rbtServidor.TabStop = True
        Me.rbtServidor.Text = "Servidor"
        Me.rbtServidor.UseVisualStyleBackColor = True
        '
        'rbtCliente
        '
        Me.rbtCliente.AutoSize = True
        Me.rbtCliente.Location = New System.Drawing.Point(8, 3)
        Me.rbtCliente.Name = "rbtCliente"
        Me.rbtCliente.Size = New System.Drawing.Size(70, 19)
        Me.rbtCliente.TabIndex = 0
        Me.rbtCliente.TabStop = True
        Me.rbtCliente.Text = "Cliente"
        Me.rbtCliente.UseVisualStyleBackColor = True
        '
        'pnlDHT
        '
        Me.pnlDHT.BackColor = System.Drawing.Color.White
        Me.pnlDHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDHT.Controls.Add(Me.Label2)
        Me.pnlDHT.Controls.Add(Me.cbxTazaTrans)
        Me.pnlDHT.Controls.Add(Me.btnBuscarPuertos)
        Me.pnlDHT.Controls.Add(Me.Label1)
        Me.pnlDHT.Controls.Add(Me.cbxPuertosCOM)
        Me.pnlDHT.Controls.Add(Me.btnDesconectarDHT)
        Me.pnlDHT.Controls.Add(Me.btnConectarDHT)
        Me.pnlDHT.Location = New System.Drawing.Point(114, 12)
        Me.pnlDHT.Name = "pnlDHT"
        Me.pnlDHT.Size = New System.Drawing.Size(563, 51)
        Me.pnlDHT.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Puerto"
        '
        'cbxTazaTrans
        '
        Me.cbxTazaTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTazaTrans.FormattingEnabled = True
        Me.cbxTazaTrans.Items.AddRange(New Object() {"9600"})
        Me.cbxTazaTrans.Location = New System.Drawing.Point(218, 20)
        Me.cbxTazaTrans.Name = "cbxTazaTrans"
        Me.cbxTazaTrans.Size = New System.Drawing.Size(76, 23)
        Me.cbxTazaTrans.TabIndex = 8
        '
        'btnBuscarPuertos
        '
        Me.btnBuscarPuertos.Location = New System.Drawing.Point(6, 5)
        Me.btnBuscarPuertos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBuscarPuertos.Name = "btnBuscarPuertos"
        Me.btnBuscarPuertos.Size = New System.Drawing.Size(121, 40)
        Me.btnBuscarPuertos.TabIndex = 0
        Me.btnBuscarPuertos.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puertos"
        Me.btnBuscarPuertos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Taza Transf"
        '
        'cbxPuertosCOM
        '
        Me.cbxPuertosCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPuertosCOM.Enabled = False
        Me.cbxPuertosCOM.FormattingEnabled = True
        Me.cbxPuertosCOM.Location = New System.Drawing.Point(137, 20)
        Me.cbxPuertosCOM.Name = "cbxPuertosCOM"
        Me.cbxPuertosCOM.Size = New System.Drawing.Size(73, 23)
        Me.cbxPuertosCOM.TabIndex = 3
        '
        'btnDesconectarDHT
        '
        Me.btnDesconectarDHT.Enabled = False
        Me.btnDesconectarDHT.Location = New System.Drawing.Point(433, 4)
        Me.btnDesconectarDHT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDesconectarDHT.Name = "btnDesconectarDHT"
        Me.btnDesconectarDHT.Size = New System.Drawing.Size(121, 41)
        Me.btnDesconectarDHT.TabIndex = 5
        Me.btnDesconectarDHT.Text = "Desconectar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DHT"
        Me.btnDesconectarDHT.UseVisualStyleBackColor = True
        '
        'btnConectarDHT
        '
        Me.btnConectarDHT.Enabled = False
        Me.btnConectarDHT.Location = New System.Drawing.Point(304, 5)
        Me.btnConectarDHT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConectarDHT.Name = "btnConectarDHT"
        Me.btnConectarDHT.Size = New System.Drawing.Size(121, 40)
        Me.btnConectarDHT.TabIndex = 4
        Me.btnConectarDHT.Text = "Conectar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DHT"
        Me.btnConectarDHT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblHumerdad)
        Me.Panel1.Controls.Add(Me.lblTemperatura)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTMax)
        Me.Panel1.Controls.Add(Me.txtTMin)
        Me.Panel1.Controls.Add(Me.pbxImgRojo)
        Me.Panel1.Controls.Add(Me.pbxImgAmarillo)
        Me.Panel1.Controls.Add(Me.pbxImgVerde)
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 137)
        Me.Panel1.TabIndex = 16
        '
        'lblHumerdad
        '
        Me.lblHumerdad.AutoSize = True
        Me.lblHumerdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumerdad.ForeColor = System.Drawing.Color.Red
        Me.lblHumerdad.Location = New System.Drawing.Point(407, 59)
        Me.lblHumerdad.Name = "lblHumerdad"
        Me.lblHumerdad.Size = New System.Drawing.Size(204, 29)
        Me.lblHumerdad.TabIndex = 24
        Me.lblHumerdad.Text = "0.00% Humedad"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.ForeColor = System.Drawing.Color.Red
        Me.lblTemperatura.Location = New System.Drawing.Point(407, 93)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(228, 29)
        Me.lblTemperatura.TabIndex = 23
        Me.lblTemperatura.Text = "0.00° Temperatura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "T° Max"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(466, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "T° Min"
        '
        'txtTMax
        '
        Me.txtTMax.Location = New System.Drawing.Point(543, 30)
        Me.txtTMax.MaxLength = 3
        Me.txtTMax.Name = "txtTMax"
        Me.txtTMax.Size = New System.Drawing.Size(49, 21)
        Me.txtTMax.TabIndex = 10
        Me.txtTMax.Text = "21"
        Me.txtTMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTMin
        '
        Me.txtTMin.Location = New System.Drawing.Point(469, 30)
        Me.txtTMin.MaxLength = 3
        Me.txtTMin.Name = "txtTMin"
        Me.txtTMin.Size = New System.Drawing.Size(49, 21)
        Me.txtTMin.TabIndex = 9
        Me.txtTMin.Text = "17"
        Me.txtTMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbxImgRojo
        '
        Me.pbxImgRojo.Image = Global.DHT.My.Resources.Resources.Blanco
        Me.pbxImgRojo.Location = New System.Drawing.Point(269, 3)
        Me.pbxImgRojo.Name = "pbxImgRojo"
        Me.pbxImgRojo.Size = New System.Drawing.Size(127, 127)
        Me.pbxImgRojo.TabIndex = 8
        Me.pbxImgRojo.TabStop = False
        '
        'pbxImgAmarillo
        '
        Me.pbxImgAmarillo.Image = Global.DHT.My.Resources.Resources.Blanco
        Me.pbxImgAmarillo.Location = New System.Drawing.Point(136, 3)
        Me.pbxImgAmarillo.Name = "pbxImgAmarillo"
        Me.pbxImgAmarillo.Size = New System.Drawing.Size(127, 127)
        Me.pbxImgAmarillo.TabIndex = 7
        Me.pbxImgAmarillo.TabStop = False
        '
        'pbxImgVerde
        '
        Me.pbxImgVerde.Image = Global.DHT.My.Resources.Resources.Blanco
        Me.pbxImgVerde.Location = New System.Drawing.Point(3, 3)
        Me.pbxImgVerde.Name = "pbxImgVerde"
        Me.pbxImgVerde.Size = New System.Drawing.Size(127, 127)
        Me.pbxImgVerde.TabIndex = 6
        Me.pbxImgVerde.TabStop = False
        '
        'Timer1
        '
        '
        'btnDesconectarTcp
        '
        Me.btnDesconectarTcp.Enabled = False
        Me.btnDesconectarTcp.Location = New System.Drawing.Point(333, 209)
        Me.btnDesconectarTcp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDesconectarTcp.Name = "btnDesconectarTcp"
        Me.btnDesconectarTcp.Size = New System.Drawing.Size(110, 40)
        Me.btnDesconectarTcp.TabIndex = 28
        Me.btnDesconectarTcp.Text = "Terminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conexion"
        Me.btnDesconectarTcp.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(556, 462)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(121, 36)
        Me.btnLimpiar.TabIndex = 29
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(567, 209)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(110, 40)
        Me.btnExportar.TabIndex = 30
        Me.btnExportar.Text = "Exportar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datos"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnOcultar
        '
        Me.btnOcultar.Enabled = False
        Me.btnOcultar.Location = New System.Drawing.Point(449, 209)
        Me.btnOcultar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(110, 40)
        Me.btnOcultar.TabIndex = 31
        Me.btnOcultar.Text = "Ocultar"
        Me.btnOcultar.UseVisualStyleBackColor = True
        '
        'frmDHT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(690, 513)
        Me.Controls.Add(Me.btnOcultar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnDesconectarTcp)
        Me.Controls.Add(Me.btnEnviarDatosTcp)
        Me.Controls.Add(Me.txtParaEnviar)
        Me.Controls.Add(Me.txtVisor)
        Me.Controls.Add(Me.btnConectarTcp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPuertoServer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIpServer)
        Me.Controls.Add(Me.pnlRB)
        Me.Controls.Add(Me.pnlDHT)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(706, 552)
        Me.MinimumSize = New System.Drawing.Size(706, 552)
        Me.Name = "frmDHT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDHT"
        Me.pnlRB.ResumeLayout(False)
        Me.pnlRB.PerformLayout()
        Me.pnlDHT.ResumeLayout(False)
        Me.pnlDHT.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxImgRojo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImgAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImgVerde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnviarDatosTcp As Button
    Friend WithEvents txtParaEnviar As TextBox
    Friend WithEvents txtVisor As TextBox
    Friend WithEvents btnConectarTcp As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPuertoServer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIpServer As TextBox
    Friend WithEvents pnlRB As Panel
    Friend WithEvents rbtServidor As RadioButton
    Friend WithEvents rbtCliente As RadioButton
    Friend WithEvents pnlDHT As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTazaTrans As ComboBox
    Friend WithEvents btnBuscarPuertos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxPuertosCOM As ComboBox
    Friend WithEvents btnDesconectarDHT As Button
    Friend WithEvents btnConectarDHT As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbxImgRojo As PictureBox
    Friend WithEvents pbxImgAmarillo As PictureBox
    Friend WithEvents pbxImgVerde As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTMax As TextBox
    Friend WithEvents txtTMin As TextBox
    Friend WithEvents lblHumerdad As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents btnDesconectarTcp As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnOcultar As Button
End Class
