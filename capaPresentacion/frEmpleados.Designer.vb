<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtId = New NumericUpDown()
        picFoto = New PictureBox()
        linkFoto = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnNombre = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        openFoto = New OpenFileDialog()
        gridDatos = New DataGridView()
        CType(txtId, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(gridDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(127, 52)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(181, 23)
        txtNombre.TabIndex = 0
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(127, 81)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(181, 23)
        txtApellido.TabIndex = 1
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(127, 23)
        txtId.Name = "txtId"
        txtId.Size = New Size(50, 23)
        txtId.TabIndex = 2
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = SystemColors.ControlDark
        picFoto.Location = New Point(127, 110)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(100, 100)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 3
        picFoto.TabStop = False
        ' 
        ' linkFoto
        ' 
        linkFoto.AutoSize = True
        linkFoto.Location = New Point(127, 213)
        linkFoto.Name = "linkFoto"
        linkFoto.Size = New Size(67, 15)
        linkFoto.TabIndex = 4
        linkFoto.TabStop = True
        linkFoto.Text = "Seleccionar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 5
        Label1.Text = "Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 7
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "Foto"
        ' 
        ' btnNombre
        ' 
        btnNombre.Location = New Point(27, 239)
        btnNombre.Name = "btnNombre"
        btnNombre.Size = New Size(73, 27)
        btnNombre.TabIndex = 9
        btnNombre.Text = "Nuevo"
        btnNombre.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(156, 239)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(73, 27)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(235, 239)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(73, 27)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' gridDatos
        ' 
        gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridDatos.Location = New Point(338, 23)
        gridDatos.Name = "gridDatos"
        gridDatos.Size = New Size(497, 243)
        gridDatos.TabIndex = 12
        ' 
        ' frEmpleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 366)
        Controls.Add(gridDatos)
        Controls.Add(btnGuardar)
        Controls.Add(btnEliminar)
        Controls.Add(btnNombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(linkFoto)
        Controls.Add(picFoto)
        Controls.Add(txtId)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Name = "frEmpleados"
        Text = "Form1"
        CType(txtId, ComponentModel.ISupportInitialize).EndInit()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(gridDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents linkFoto As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNombre As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents openFoto As OpenFileDialog
    Friend WithEvents gridDatos As DataGridView

End Class
