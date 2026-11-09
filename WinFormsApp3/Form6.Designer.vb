<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        DeleteAllRecordsToolStripMenuItem = New MenuStrip()
        FileToolStripMenuItem1 = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteAllRecodsToolStripMenuItem = New ToolStripMenuItem()
        TextBox3 = New TextBox()
        FileToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        DeleteAllRecordsToolStripMenuItem.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 30)
        Label1.TabIndex = 0
        Label1.Text = "Customer Information:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 30)
        Label2.TabIndex = 1
        Label2.Text = "Customer ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 30)
        Label3.TabIndex = 2
        Label3.Text = "Customer Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(208, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 31)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(208, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(295, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 30)
        Label4.TabIndex = 5
        Label4.Text = "Gender:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(208, 155)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(89, 34)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(303, 155)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(111, 34)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 247)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1462, 375)
        DataGridView1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(1208, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 30)
        Label5.TabIndex = 10
        Label5.Text = "Search:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 34)
        Button1.TabIndex = 12
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(166, 207)
        Button2.Name = "Button2"
        Button2.Size = New Size(212, 34)
        Button2.TabIndex = 13
        Button2.Text = "Load Records"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(384, 207)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 34)
        Button3.TabIndex = 14
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(538, 207)
        Button4.Name = "Button4"
        Button4.Size = New Size(148, 34)
        Button4.TabIndex = 15
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(585, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 30)
        Label6.TabIndex = 16
        Label6.Text = "Year:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(585, 100)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 30)
        Label7.TabIndex = 17
        Label7.Text = "Course:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ComboBox1.Location = New Point(675, 38)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(197, 33)
        ComboBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"BSIT", "BSCS", "BSHM", "BSCRIM", "BSED"})
        ComboBox2.Location = New Point(675, 99)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(295, 33)
        ComboBox2.TabIndex = 19
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(1302, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(163, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' DeleteAllRecordsToolStripMenuItem
        ' 
        DeleteAllRecordsToolStripMenuItem.ImageScalingSize = New Size(24, 24)
        DeleteAllRecordsToolStripMenuItem.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem1, EditToolStripMenuItem})
        DeleteAllRecordsToolStripMenuItem.Location = New Point(0, 0)
        DeleteAllRecordsToolStripMenuItem.Name = "DeleteAllRecordsToolStripMenuItem"
        DeleteAllRecordsToolStripMenuItem.Size = New Size(1477, 33)
        DeleteAllRecordsToolStripMenuItem.TabIndex = 21
        DeleteAllRecordsToolStripMenuItem.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem1
        ' 
        FileToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, CloseToolStripMenuItem})
        FileToolStripMenuItem1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        FileToolStripMenuItem1.Size = New Size(57, 29)
        FileToolStripMenuItem1.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(159, 34)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(159, 34)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DeleteAllRecodsToolStripMenuItem})
        EditToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(61, 29)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' DeleteAllRecodsToolStripMenuItem
        ' 
        DeleteAllRecodsToolStripMenuItem.Name = "DeleteAllRecodsToolStripMenuItem"
        DeleteAllRecodsToolStripMenuItem.Size = New Size(270, 34)
        DeleteAllRecodsToolStripMenuItem.Text = "Delete All Recods"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1302, 207)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(163, 31)
        TextBox3.TabIndex = 22
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(140, 34)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1477, 643)
        Controls.Add(TextBox3)
        Controls.Add(DeleteAllRecordsToolStripMenuItem)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MainMenuStrip = DeleteAllRecordsToolStripMenuItem
        Name = "Form6"
        Text = "Registration_Form"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        DeleteAllRecordsToolStripMenuItem.ResumeLayout(False)
        DeleteAllRecordsToolStripMenuItem.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DeleteAllRecordsToolStripMenuItem As MenuStrip
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllRecodsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
