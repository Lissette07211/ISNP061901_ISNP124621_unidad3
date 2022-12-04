<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.grpCodigo.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.txtCodigo)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(8, 12)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(780, 89)
        Me.grpCodigo.TabIndex = 3
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Codigo Alumno"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(17, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(258, 24)
        Me.txtCodigo.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(294, 36)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(140, 30)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Codigo"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.btnSalir)
        Me.grpDatos.Controls.Add(Me.btnAgregar)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.txtGenero)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Controls.Add(Me.lblApellido)
        Me.grpDatos.Controls.Add(Me.lblGenero)
        Me.grpDatos.Controls.Add(Me.lblDireccion)
        Me.grpDatos.Controls.Add(Me.lblNombre)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(8, 117)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(758, 307)
        Me.grpDatos.TabIndex = 21
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos Alumno"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(645, 260)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 32)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(507, 260)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 32)
        Me.btnAgregar.TabIndex = 28
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(163, 91)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(311, 24)
        Me.txtApellido.TabIndex = 27
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(163, 205)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(311, 24)
        Me.txtDireccion.TabIndex = 26
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(163, 149)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(88, 24)
        Me.txtGenero.TabIndex = 25
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(163, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(311, 24)
        Me.txtNombre.TabIndex = 24
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(85, 94)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(59, 18)
        Me.lblApellido.TabIndex = 23
        Me.lblApellido.Text = "Apellido"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(87, 152)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(58, 18)
        Me.lblGenero.TabIndex = 22
        Me.lblGenero.Text = "Genero"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(85, 208)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 18)
        Me.lblDireccion.TabIndex = 21
        Me.lblDireccion.Text = "Direccion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 18)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
End Class
