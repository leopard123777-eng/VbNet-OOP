<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 30)
        Label1.TabIndex = 0
        Label1.Text = "Idnumber:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(161, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 30)
        Label2.TabIndex = 2
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 30)
        Label3.TabIndex = 3
        Label3.Text = "Year:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 30)
        Label4.TabIndex = 4
        Label4.Text = "Address:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(504, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 30)
        Label5.TabIndex = 5
        Label5.Text = "Course:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(504, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 30)
        Label6.TabIndex = 6
        Label6.Text = "Contact#:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(504, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 30)
        Label7.TabIndex = 7
        Label7.Text = "Gender:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(915, 55)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 30)
        Label8.TabIndex = 8
        Label8.Text = "Status:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(161, 125)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 31)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 261)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 31)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(623, 125)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 31)
        TextBox3.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1st year", "2nd year", "3rd year", "4th year"})
        ComboBox1.Location = New Point(161, 190)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 13
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox2.Location = New Point(623, 190)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 14
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"BSBA", "BSIT", "BSCS", "BSCRIM", "BSHM", "BSED"})
        ComboBox3.Location = New Point(623, 55)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(182, 33)
        ComboBox3.TabIndex = 15
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Single since Birth", "Married"})
        ComboBox4.Location = New Point(1004, 53)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(182, 33)
        ComboBox4.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1218, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 113)
        Button1.TabIndex = 17
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1218, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(196, 113)
        Button2.TabIndex = 18
        Button2.Text = "REFRESH"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(2, 323)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1439, 359)
        DataGridView1.TabIndex = 19
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 685)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
