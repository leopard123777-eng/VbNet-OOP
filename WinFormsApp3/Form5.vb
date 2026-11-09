Imports MySql.Data.MySqlClient

Public Class Form5

    Dim Reader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If TB_username.Text = "" Or TB_password.Text = "" Then
                MessageBox.Show("Please Fill Empty Textbox!")
            Else
            End If
            con.Open()
            Dim query As String
            query = "Select username,password from rene_gone where username='" & TB_username.Text & "' AND password='" & TB_password.Text & "'"
            command = New MySqlCommand(query, con)
            Reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                Dim username = Reader.GetString("username")
                MessageBox.Show("Welcome " & username.ToString & " !")
                con.Close()
                For j = 0 To 500
                Next
                Form4.Show()
                Me.Hide()

            Else
                MessageBox.Show("Try Again!")
                TB_username.Text = ""
                TB_password.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TB_username.Text = ""
            TB_password.Text = ""
            con.Close()
        End Try
        Form6.Show()
        Me.Hide()
    End Sub
End Class

