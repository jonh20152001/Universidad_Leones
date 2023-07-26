Imports System.Data.SqlClient
Public Class login
    Private Sub btingresar_Click(sender As Object, e As EventArgs) Handles btingresar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.Linq_CRUD)
        con.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("select *
                                            from [Linq_CRUD].[dbo].EMPLEADOS
                                            WHERE ID_EMPLEADO = '" & tbusu.Text & "' and CONTRASENA = '" & tbcontrasena.Text & "'", con)
        reader = cmd.ExecuteReader
        If reader.Read Then
            ModuloVariablesPublicas.ID_EMPLEADO = reader.Item("ID_EMPLEADO")
            ModuloVariablesPublicas.NIVEL_ACCESO = reader.Item("NIVEL_ACCESO")
            MessageBox.Show("Bienvenido, usuairo '" & tbusu.Text & "'")

            frmmenu.ShowDialog()
            Me.Dispose()
        Else
            MessageBox.Show("Datos incorrectos")
        End If
    End Sub

    Private Sub tbcontrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles tbcontrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            btingresar.PerformClick()
        End If
    End Sub

    Private Sub tbusu_KeyDown(sender As Object, e As KeyEventArgs) Handles tbusu.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbcontrasena.Focus()
        End If
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        limpiarcontroles()
    End Sub


    Sub limpiarcontroles()
        tbusu.Clear()
        tbcontrasena.Clear()
        tbusu.Focus()


    End Sub

End Class