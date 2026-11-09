Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Reader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim Query As String
            Query = "insert into rene_days(idnumber,name) values ('" & TextBox1.Text & "','" & TextBox2.Text & "' ) "
            command = New MySqlCommand(Query, con)
            Reader = command.ExecuteReader
            MsgBox("Successfully Added!", MsgBoxStyle.Information, "Save!")
            TextBox1.Clear()
            TextBox2.Clear()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        Form3.Show()
        Me.Hide()
    End Sub
End Class