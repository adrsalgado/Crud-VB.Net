<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLectores))
        Me.panelTitulo = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelBusqueda = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.MaskedTextBox()
        Me.btnAgregar = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.dataLectores = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelTitulo.SuspendLayout()
        Me.panelBusqueda.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLateral.SuspendLayout()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenido.SuspendLayout()
        Me.panelDatos.SuspendLayout()
        CType(Me.dataLectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblTitulo)
        Me.panelTitulo.Controls.Add(Me.btnCerrar)
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(1024, 66)
        Me.panelTitulo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(125, 33)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Lectores"
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(134, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCerrar.Size = New System.Drawing.Size(45, 54)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'panelBusqueda
        '
        Me.panelBusqueda.BackColor = System.Drawing.Color.White
        Me.panelBusqueda.Controls.Add(Me.Panel1)
        Me.panelBusqueda.Controls.Add(Me.txtBuscar)
        Me.panelBusqueda.Controls.Add(Me.PictureBox1)
        Me.panelBusqueda.Location = New System.Drawing.Point(0, 63)
        Me.panelBusqueda.Name = "panelBusqueda"
        Me.panelBusqueda.Size = New System.Drawing.Size(1024, 73)
        Me.panelBusqueda.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 487)
        Me.Panel1.TabIndex = 3
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(111, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtBuscar.Size = New System.Drawing.Size(763, 35)
        Me.txtBuscar.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'panelLateral
        '
        Me.panelLateral.BackColor = System.Drawing.Color.White
        Me.panelLateral.Controls.Add(Me.txtId)
        Me.panelLateral.Controls.Add(Me.btnAgregar)
        Me.panelLateral.Location = New System.Drawing.Point(877, 135)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(147, 497)
        Me.panelLateral.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(7, 19)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(137, 26)
        Me.txtId.TabIndex = 15
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(3, 87)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(144, 151)
        Me.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.White
        Me.panelContenido.Controls.Add(Me.panelDatos)
        Me.panelContenido.Controls.Add(Me.dataLectores)
        Me.panelContenido.Location = New System.Drawing.Point(0, 135)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(878, 521)
        Me.panelContenido.TabIndex = 4
        '
        'panelDatos
        '
        Me.panelDatos.AutoScroll = True
        Me.panelDatos.BackColor = System.Drawing.Color.White
        Me.panelDatos.Controls.Add(Me.btnCancelar)
        Me.panelDatos.Controls.Add(Me.btnModificar)
        Me.panelDatos.Controls.Add(Me.btnGuardar)
        Me.panelDatos.Controls.Add(Me.txtObservaciones)
        Me.panelDatos.Controls.Add(Me.txtDireccion)
        Me.panelDatos.Controls.Add(Me.lblDireccion)
        Me.panelDatos.Controls.Add(Me.lblObservaciones)
        Me.panelDatos.Controls.Add(Me.lblTelefono)
        Me.panelDatos.Controls.Add(Me.txtTelefono)
        Me.panelDatos.Controls.Add(Me.txtNombre)
        Me.panelDatos.Controls.Add(Me.lblNombre)
        Me.panelDatos.Controls.Add(Me.txtIdentidad)
        Me.panelDatos.Controls.Add(Me.lblIdentidad)
        Me.panelDatos.Location = New System.Drawing.Point(3, 3)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(878, 508)
        Me.panelDatos.TabIndex = 2
        Me.panelDatos.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(597, 414)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(178, 47)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(356, 414)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(186, 47)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(131, 414)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(170, 47)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(286, 317)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(521, 68)
        Me.txtObservaciones.TabIndex = 10
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(286, 224)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(521, 66)
        Me.txtDireccion.TabIndex = 9
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(68, 242)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(115, 29)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Dirección"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(68, 329)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(175, 29)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(68, 165)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(142, 29)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "N° Télefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(286, 159)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(521, 35)
        Me.txtTelefono.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(286, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(521, 35)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(60, 92)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(212, 29)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre Completo"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(286, 26)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(521, 35)
        Me.txtIdentidad.TabIndex = 1
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentidad.Location = New System.Drawing.Point(68, 32)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(145, 29)
        Me.lblIdentidad.TabIndex = 0
        Me.lblIdentidad.Text = "N° Identidad"
        '
        'dataLectores
        '
        Me.dataLectores.AllowUserToAddRows = False
        Me.dataLectores.AllowUserToDeleteRows = False
        Me.dataLectores.AllowUserToResizeColumns = False
        Me.dataLectores.BackgroundColor = System.Drawing.Color.White
        Me.dataLectores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataLectores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataLectores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dataLectores.Location = New System.Drawing.Point(3, 0)
        Me.dataLectores.Name = "dataLectores"
        Me.dataLectores.RowHeadersVisible = False
        Me.dataLectores.RowHeadersWidth = 62
        Me.dataLectores.RowTemplate.Height = 28
        Me.dataLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataLectores.Size = New System.Drawing.Size(878, 561)
        Me.dataLectores.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eliminar.MinimumWidth = 8
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 150
        '
        'frmLectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 634)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.panelTitulo)
        Me.Controls.Add(Me.panelBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLectores"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelTitulo.PerformLayout()
        Me.panelBusqueda.ResumeLayout(False)
        Me.panelBusqueda.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLateral.ResumeLayout(False)
        Me.panelLateral.PerformLayout()
        CType(Me.btnAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenido.ResumeLayout(False)
        Me.panelDatos.ResumeLayout(False)
        Me.panelDatos.PerformLayout()
        CType(Me.dataLectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitulo As FlowLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelBusqueda As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelLateral As Panel
    Friend WithEvents btnAgregar As PictureBox
    Friend WithEvents panelContenido As Panel
    Friend WithEvents dataLectores As DataGridView
    Friend WithEvents panelDatos As Panel
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblObservaciones As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtId As MaskedTextBox
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
