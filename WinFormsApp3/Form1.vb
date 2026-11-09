Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            MessageBox.Show("Connection Successful!")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        Form2.Show()
        Me.Hide()
    End Sub
End Class