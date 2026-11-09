Imports MySql.Data.MySqlClient

Public Class Form3
    Dim Reader As MySqlDataReader
    Dim dbDataSet As New DataTable
    Dim dbSource As New BindingSource


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Load_Table()
    End Sub

    Private Sub Load_Table()
        Dim Reader As New MySqlDataAdapter
        Try
            con.Open()
            Dim Query As String
            Query = "Select idnumber,name,year,address,course,`contact#`,gender,status from rene_days Order by idnumber"
            command = New MySqlCommand(Query, con)
            Reader.SelectCommand = command
            Reader.Fill(dbDataSet)
            dbSource.DataSource = dbDataSet
            DataGridView1.DataSource = dbSource
            DataGridView1.AutoGenerateColumns = False
            'idnumber
            DataGridView1.Columns(0).HeaderText = "Idnumber"
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(0).Resizable = False
            'fullname
            DataGridView1.Columns(1).HeaderText = "Name"
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(1).Resizable = False
            'year
            DataGridView1.Columns(2).HeaderText = "Year"
            DataGridView1.Columns(2).Width = 90
            DataGridView1.Columns(2).Resizable = False
            'address
            DataGridView1.Columns(3).HeaderText = "Address"
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(3).Resizable = False
            'course
            DataGridView1.Columns(4).HeaderText = "Course"
            DataGridView1.Columns(4).Width = 90
            DataGridView1.Columns(4).Resizable = False
            '`contact#`
            DataGridView1.Columns(5).HeaderText = "`Contact#`"
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(5).Resizable = False
            'gender
            DataGridView1.Columns(6).HeaderText = "Gender"
            DataGridView1.Columns(6).Width = 150
            DataGridView1.Columns(6).Resizable = False
            'status
            DataGridView1.Columns(7).HeaderText = "Status"
            DataGridView1.Columns(7).Width = 150
            DataGridView1.Columns(7).Resizable = False
            Reader.Update(dbDataSet)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim Query As String
            Query = "insert into rene_days(idnumber,name,year,address,course,`contact#`,gender,status) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "' ,'" & TextBox4.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "' ) "
            command = New MySqlCommand(Query, con)
            Reader = command.ExecuteReader
            MsgBox("Successfully Added!", MsgBoxStyle.Information, "Save!")
            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.SelectedIndex = 0
            TextBox3.Clear()
            ComboBox2.SelectedIndex = 0
            TextBox4.Clear()
            ComboBox3.SelectedIndex = 0
            ComboBox4.SelectedIndex = 0
            con.Close()
            Load_Table()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateTable()
    End Sub

    Private Sub UpdateTable()
        Dim Reader As New MySqlDataAdapter
        Dim ds As New DataSet
        Dim Query As String = "select * from rene_days order by name"
        command = New MySqlCommand(Query, con)
        Reader.SelectCommand = command
        Reader.Fill(ds)
        con.Close()
        DataGridView1.DataSource = ds.Tables(0)
        Form4.Show()
        Me.Hide()
    End Sub
End Class


