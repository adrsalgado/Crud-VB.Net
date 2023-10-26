Imports MySql.Data.MySqlClient

Public Class frmLectores

    'Private Sub frmLectores_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Try
    '        MySqlConnection.Open()
    '        MySqlConnection.Close()
    '    Catch ex As Exception
    '        MsgBox("Ha ocurrido un error: " & ex.Message)
    '    End Try
    '    Abrir_Conexion()
    '    MsgBox("Conexión creada con exito", vbOKOnly + vbInformation, "Sistema Lector")
    'End Sub




    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()


    End Sub

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub panelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(frmLectores.MousePosition.X - Me.Location.X - ex, frmLectores.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        panelDatos.Visible = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        txtIdentidad.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        panelDatos.Visible = False
    End Sub

    Private Sub Limpiar()
        txtId.Clear()
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtDireccion.Clear()
        txtObservaciones.Clear()
        txtIdentidad.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text <> "" AndAlso txtIdentidad.Text <> "" AndAlso txtTelefono.Text <> "" AndAlso txtDireccion.Text <> "" AndAlso txtObservaciones.Text <> "" Then
            Try
                Using conexion As MySqlConnection = New MySqlConnection(connectionString)
                    conexion.Open()

                    Using cmd As New MySqlCommand("Ingresar_Lector", conexion)
                        cmd.CommandType = CommandType.StoredProcedure


                        cmd.Parameters.AddWithValue("@Id_Lectores", txtIdentidad.Text)
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                panelDatos.Visible = False
                Limpiar()
                Mostrar()

            Catch ex As Exception
                MsgBox("Error al guardar el lector: " & ex.Message, vbExclamation + vbOKOnly, "Sistema Lectores")
            End Try
        Else
            MsgBox("Todos los campos son obligatorios", vbInformation + vbOKOnly, "Sistema Lectores")
        End If
    End Sub

    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter

        Try
            Using conexion As MySqlConnection = New MySqlConnection(connectionString)
                conexion.Open()

                da = New MySqlDataAdapter("Mostrar_Lector", conexion)
                da.Fill(dt)
                dataLectores.DataSource = dt
                Cerrar_Conexion()

                'ANCHO DE LAS COLUMNAS (ENCABEZADO)'

                dataLectores.Columns(0).Width = 35
                dataLectores.Columns(1).Width = 120
                dataLectores.Columns(2).Width = 200
                dataLectores.Columns(3).Width = 100
                dataLectores.Columns(4).Width = 200
                dataLectores.Columns(5).Width = 200

                'CAMBIAR LA APARIENCIA DE LOS ENCABEZADOS'
                dataLectores.EnableHeadersVisualStyles = False
                Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
                estilo.BackColor = Color.MediumPurple
                estilo.ForeColor = Color.Black
                estilo.Font = New Font("segoe UI", 10, FontStyle.Regular Or FontStyle.Bold)
                dataLectores.ColumnHeadersDefaultCellStyle = estilo
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Sub Buscar()
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter

        Try
            Using conexion As MySqlConnection = New MySqlConnection(connectionString)
                conexion.Open()

                da = New MySqlDataAdapter("Buscar_Lector", conexion)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.AddWithValue("@Busqueda", txtBuscar.Text)
                da.Fill(dt)
                dataLectores.DataSource = dt
                Cerrar_Conexion()

                'ANCHO DE LAS COLUMNAS (ENCABEZADO)'

                dataLectores.Columns(0).Width = 35
                dataLectores.Columns(1).Width = 120
                dataLectores.Columns(2).Width = 200
                dataLectores.Columns(3).Width = 100
                dataLectores.Columns(4).Width = 200
                dataLectores.Columns(5).Width = 200

                'CAMBIAR LA APARIENCIA DE LOS ENCABEZADOS'
                dataLectores.EnableHeadersVisualStyles = False
                Dim estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
                estilo.BackColor = Color.MediumPurple
                estilo.ForeColor = Color.Black
                estilo.Font = New Font("segoe UI", 10, FontStyle.Regular Or FontStyle.Bold)
                dataLectores.ColumnHeadersDefaultCellStyle = estilo
            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub panelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseUp
        Arrastre = true
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
        panelDatos.Visible = False
    End Sub

    Private Sub frmLectores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mostrar()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtNombre.Text <> "" AndAlso txtIdentidad.Text <> "" AndAlso txtTelefono.Text <> "" AndAlso txtDireccion.Text <> "" AndAlso txtObservaciones.Text <> "" Then
            Try
                Using conexion As MySqlConnection = New MySqlConnection(connectionString)
                    conexion.Open()

                    Using cmd As New MySqlCommand("Editar_Lector", conexion)
                        cmd.CommandType = CommandType.StoredProcedure


                        cmd.Parameters.AddWithValue("@id_L", txtId.Text)
                        cmd.Parameters.AddWithValue("@Id_Lectores", txtIdentidad.Text)
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text)

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                panelDatos.Visible = False
                Limpiar()
                Mostrar()

            Catch ex As Exception
                MsgBox("Error al guardar el lector: " & ex.Message, vbExclamation + vbOKOnly, "Sistema Lectores")
            End Try
        Else
            MsgBox("Todos los campos son obligatorios", vbInformation + vbOKOnly, "Sistema Lectores")
        End If
    End Sub

    Private Sub dataLectores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellContentClick
        'verificar si se dio clic sobre la columna de eliminar'
        If e.ColumnIndex = dataLectores.Columns.Item("Eliminar").Index Then
            Dim result As DialogResult
            result = MsgBox("El registro sera eliminado permanentemente del sistema y ya no podrá acceder a los datos de este lector. ¿Realmente desea eliminar este resgistro?", vbQuestion + vbOKCancel, "Sistema lectores")
            If result = DialogResult.OK Then

                Try
                    Using conexion As MySqlConnection = New MySqlConnection(connectionString)
                        conexion.Open()

                        Using cmd As New MySqlCommand("Eliminar_Lector", conexion)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@id_L", dataLectores.SelectedCells.Item(1).Value)
                            cmd.ExecuteNonQuery()
                            Cerrar_Conexion()
                            Mostrar()
                        End Using
                    End Using
                Catch ex As Exception
                End Try
            Else
                MsgBox("Eiminación cancelada, el registro no será eliminado", vbInformation + vbOKOnly, "Sistema Lectores")
            End If
        End If
    End Sub

    Private Sub dataLectores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataLectores.CellContentDoubleClick
        panelDatos.Visible = True
        Try
            txtId.Text = dataLectores.SelectedCells.Item(1).Value
            txtIdentidad.Text = dataLectores.SelectedCells.Item(2).Value
            txtNombre.Text = dataLectores.SelectedCells.Item(3).Value
            txtTelefono.Text = dataLectores.SelectedCells.Item(4).Value
            txtDireccion.Text = dataLectores.SelectedCells.Item(5).Value
            txtObservaciones.Text = dataLectores.SelectedCells.Item(6).Value

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

End Class
