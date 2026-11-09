Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form6

    Dim Reader As MySqlDataReader

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnsureDataGridViewColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowTemplate.Height = 35
        DataGridView1.AllowUserToAddRows = False
        Loadrecords()
    End Sub

    Private Sub EnsureDataGridViewColumns()
        If DataGridView1.Columns.Count > 0 Then Return

        DataGridView1.Columns.Add("customerid", "Customer ID")
        DataGridView1.Columns.Add("customername", "Customer Name")
        DataGridView1.Columns.Add("gender", "Gender")
        DataGridView1.Columns.Add("year", "Year")
        DataGridView1.Columns.Add("course", "Course")

        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.Name = "image"
        imgColumn.HeaderText = "Image"
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridView1.Columns.Add(imgColumn)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveData()
    End Sub
    Public Sub SaveData()
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please select an image before saving.", "Missing Image",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim gendervalue As String = ""
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            gendervalue = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            RadioButton1.Checked = False
            gendervalue = RadioButton2.Text
        End If
        Try
            con.Open()
            Dim cm = New MySqlCommand("Insert into student_records(customerid,customername,gender,year,course,image) values (@ci,@cn,@g,@y,@c,@i)", con)
            With cm
                .Parameters.AddWithValue("@ci", TextBox1.Text)
                .Parameters.AddWithValue("@cn", TextBox2.Text)
                .Parameters.AddWithValue("@g", gendervalue)
                .Parameters.AddWithValue("@y", ComboBox1.Text)
                .Parameters.AddWithValue("@c", ComboBox2.Text)
                .Parameters.AddWithValue("@i", ImageToBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png))
                .ExecuteNonQuery()
            End With
            con.Close()
            MessageBox.Show("Successfully Added!", "Save!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            Loadrecords()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Dim i As Integer
            DataGridView1.Rows.Clear()
            con.Open()
            Dim cm = New MySqlCommand("Select * from student_records order by customername ", con)
            Reader = cm.ExecuteReader
            While Reader.Read
                i += 1
                DataGridView1.Rows.Add(Reader.Item("customerid").ToString, Reader.Item("customername").ToString, Reader.Item("gender").ToString, Reader.Item("year").ToString, Reader.Item("course").ToString.ToUpper, Base64ToImageLoad(Reader.Item("image").ToString))
            End While
            Reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please select an image before updating.",
                            "Missing Image",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
        End If

        Try
            If MsgBox("Update this Record?, Click Yes To Confirm.", vbYesNo + vbQuestion, "Update Record") = vbYes Then
                con.Open()
                Dim cm = New MySqlCommand("update student_records set customername=@cn,gender=@g,year=@yr,course=@cr, image=@i where customerid=@id", con)
                With cm
                    .Parameters.AddWithValue("@cn", TextBox2.Text)
                    Dim gender As String = ""
                    If RadioButton1.Checked = True Then
                        RadioButton2.Checked = False
                        gender = RadioButton1.Text

                    ElseIf RadioButton2.Checked = True Then
                        RadioButton1.Checked = False
                        gender = RadioButton2.Text
                    End If

                    .Parameters.AddWithValue("@g", gender)
                    .Parameters.AddWithValue("@yr", ComboBox1.Text)
                    .Parameters.AddWithValue("@cr", ComboBox2.Text)
                    .Parameters.AddWithValue("@i", ImageToBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png))
                    .Parameters.AddWithValue("@id", TextBox1.Text)
                    .ExecuteNonQuery()
                End With

                con.Close()
                MessageBox.Show("Updated!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Loadrecords()
                TextBox1.Clear()
                TextBox1.Focus()
                TextBox2.Clear()
                TextBox3.Clear()
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                ComboBox1.Text = Nothing
                ComboBox2.Text = Nothing
                PictureBox1.Image = Nothing
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical, "Update Record")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Delete Record") = vbYes Then
            con.Open()
            Dim cm = New MySqlCommand("delete from student_records where customerid=@id", con)
            cm.Parameters.AddWithValue("@id", TextBox1.Text)
            cm.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Record Deleted!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            Loadrecords()
        Else
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            Loadrecords()
            MessageBox.Show("Delete Record Cancelled!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub DeleteAllRecodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllRecodsToolStripMenuItem.Click
        If MsgBox("Are you sure you want to delete all records?", vbYesNo + vbQuestion, "Delete All Record") = vbYes Then
            con.Open()
            Dim cm = New MySqlCommand("truncate student_records ", con)
            cm.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("All Record Deleted!", "Delete All Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            Loadrecords()
        Else
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            ComboBox1.Text = Nothing
            ComboBox2.Text = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Focus()
            Loadrecords()
            MessageBox.Show("Delete Record Cancelled!", "Delete All Record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        If DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString = "Male" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString = "Female" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        Loadimage()
        TextBox1.Enabled = False
        Button1.Enabled = False
    End Sub

    Public Sub SearchRecords()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        con.Open()
        Dim cm = New MySqlCommand("Select * from student_records where customerid like '" & TextBox3.Text & "%' or course like '" & TextBox3.Text & "%' or year like '" & TextBox3.Text & "%'   order by customername", con)
        Reader = cm.ExecuteReader
        While Reader.Read
            i += 1
            DataGridView1.Rows.Add(Reader.Item("customerid").ToString, Reader.Item("customername").ToString,
                            Reader.Item("gender").ToString, Reader.Item("year").ToString, Reader.Item("course").ToString, Base64ToImageLoad(Reader.Item("image").ToString))
        End While
        Reader.Close()
        con.Close()
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'RetrieveRecord()
            SearchRecords()
        End If
    End Sub


    Public Shared Function ImageToBase64(ByVal image As Image, ByVal Format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, Format)
        Dim imagebyte() As Byte = ms.ToArray
        Dim base64string As String = Convert.ToBase64String(imagebyte)
        Return base64string
    End Function


    Public Shared Function Base64ToImageLoad(ByVal base64String As String) As Image
        Try
            Dim imagebyte() As Byte = Convert.FromBase64String(base64String)
            Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
            ms.Write(imagebyte, 0, imagebyte.Length)
            Dim image As Image = Image.FromStream(ms, True)
            Return image
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub Loadimage()
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(i)
            con.Open()
            command = New MySqlCommand("Select * from student_records WHERE customerid like'" & selectedRow.Cells(0).Value.ToString & "'", con)
            Reader = command.ExecuteReader()
            While Reader.Read
                PictureBox1.Image = Base64ToImageLoad(Reader.Item("image").ToString)
            End While
            con.Close()
        Catch ex As Exception
            Reader.Close()
            con.Close()
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

        OpenFileDialog1.Filter =
        "Image Files (*.PNG;*.JPG;*.GIF;*.JFIF)|*.PNG;*.JPG;*.GIF;*.JFIF|All Files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            Using tempImage = Image.FromFile(OpenFileDialog1.FileName)
                If PictureBox1.Image IsNot Nothing Then
                    PictureBox1.Image.Dispose()
                End If
                PictureBox1.Image = New Bitmap(tempImage)
            End Using
        End If
    End Sub
End Class





