Imports System.Data.SqlClient
Public Class clasesofertadas
    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        End
    End Sub

    Sub llenarideusuario()
        Dim conex As New SqlConnection(My.Settings.Linq_CRUD)
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("select COD_CARRERA as [#CODIGO], NOMBRE_CARRERA, TOTAL_CLASES, TELEFONO_ENC_CARRERA, TIEMPO_ESTUDIOS  from CARRERA", conex)
            da.Fill(dt)
            dataclases.DataSource = dt


        Catch ex As Exception

        End Try


    End Sub

    Private Sub btmenu_Click(sender As Object, e As EventArgs) Handles btmenu.Click
        frmmenu.Show()
        Me.Dispose()
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        limpiarcontroles()

    End Sub
    Sub limpiarcontroles()
        tbid.Clear()
        tbcarrera.Clear()
        tbclases.Clear()
        tbtelefono.Clear()
        tbtiempo.Clear()
        tbid.Focus()

    End Sub

    Private Sub tbguardar_Click(sender As Object, e As EventArgs) Handles tbguardar.Click
        Dim con As New SqlConnection(My.Settings.Linq_CRUD)
        Dim cmd As SqlCommand = New SqlCommand("insert into CARRERA(COD_CARRERA,NOMBRE_CARRERA,TOTAL_CLASES,TELEFONO_ENC_CARRERA,TIEMPO_ESTUDIOS)
                                                Values(@COD_CARRERA,@NOMBRE_CARRERA, @TOTAL_CLASES,@TELEFONO_ENC_CARRERA,@TIEMPO_ESTUDIOS)", con)

        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@COD_CARRERA", tbid.Text)
        cmd.Parameters.AddWithValue("@NOMBRE_CARRERA", tbcarrera.Text)
        cmd.Parameters.AddWithValue("@TOTAL_CLASES", tbclases.Text)
        cmd.Parameters.AddWithValue("@TELEFONO_ENC_CARRERA", tbtelefono.Text)
        cmd.Parameters.AddWithValue("@TIEMPO_ESTUDIOS", tbtiempo.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Carrera Ingresada Exitosamente")
        limpiarcontroles()
    End Sub

    Private Sub clasesofertadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarideusuario()
    End Sub

    Private Sub tbid_KeyDown(sender As Object, e As KeyEventArgs) Handles tbid.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbcarrera.Focus()
        End If
    End Sub

    Private Sub tbclases_KeyDown(sender As Object, e As KeyEventArgs) Handles tbclases.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbtelefono.Focus()
        End If
    End Sub

    Private Sub tbcarrera_KeyDown(sender As Object, e As KeyEventArgs) Handles tbcarrera.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbclases.Focus()
        End If
    End Sub

    Private Sub tbtelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles tbtelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbtiempo.Focus()
        End If
    End Sub

    Private Sub tbtiempo_KeyDown(sender As Object, e As KeyEventArgs) Handles tbtiempo.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbguardar.PerformClick()
        End If
    End Sub
End Class
'("select *
' from [Linq_CRUD].[dbo].CARRERRA
'WHERE COD_CARRERA = '" & tbid.Text & "' and NOMBRE_CARRERA = '" & tbcarrera.Text & "' and TOTAL_CLASES = '" & tbclases.Text & "' and TELEFONO_ENC_CARRERA = '" & tbtelefono.Text & "'and TIEMPO_ESTUDIOS = '" & tbtiempo.Text & "'", con)