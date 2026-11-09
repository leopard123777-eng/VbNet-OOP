Imports MySql.Data.MySqlClient
Imports Windows.Win32.System
Module connection
    Public con As New MySqlConnection("server=localhost;user=root;password=patrickbateman123;database=reniggan")
    Public command As New MySql.Data.MySqlClient.MySqlCommand
End Module

Public Class Form4

    Dim Reader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            con.Open()
            Dim Query As String
            Query = "insert into rene_gone(firstname,lastname,birthdate,gender,username,password) 	values ('" & TB_firstname.Text & "','" & TB_lastname.Text & "','" & DateTimePicker1.Text.ToString & "','" & ComboBox1.Text & "','" & TB_username.Text & "','" & TB_password.Text & "' ) "
            command = New MySqlCommand(Query, con)
            Reader = command.ExecuteReader
            MsgBox("Successfully Added!", MsgBoxStyle.Information, "Save!")
            TB_firstname.Clear()
            TB_lastname.Clear()
            TB_username.Clear()
            TB_password.Clear()
            DateTimePicker1.ResetText()
            ComboBox1.SelectedItem = Nothing
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
        Form5.Show()
        Me.Hide()


    End Sub
End Class
