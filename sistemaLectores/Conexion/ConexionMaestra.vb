Imports MySql.Data.MySqlClient

Module ConexionMaestra
    Public connectionString As String = "Server=localhost;Database=bd_crud;Uid=root;Pwd=root2023;"
    Public MySqlConnection As New MySqlConnection(connectionString)

    Sub Abrir_Conexion()
        If MySqlConnection.State = 0 Then
            MySqlConnection.Open()
        End If

    End Sub

    Sub Cerrar_Conexion()
        If MySqlConnection.State = 0 Then
            MySqlConnection.Close()
        End If

    End Sub


End Module
