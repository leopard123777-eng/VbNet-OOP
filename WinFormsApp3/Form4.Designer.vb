<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TB_firstname = New MaskedTextBox()
        TB_username = New MaskedTextBox()
        TB_password = New MaskedTextBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        TB_lastname = New MaskedTextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 45)
        Label1.TabIndex = 0
        Label1.Text = "Firstname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 45)
        Label2.TabIndex = 1
        Label2.Text = "Birthdate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 149)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 45)
        Label3.TabIndex = 2
        Label3.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(28, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(172, 45)
        Label4.TabIndex = 3
        Label4.Text = "Password:"
        ' 
        ' TB_firstname
        ' 
        TB_firstname.Location = New Point(199, 38)
        TB_firstname.Name = "TB_firstname"
        TB_firstname.Size = New Size(333, 31)
        TB_firstname.TabIndex = 4
        ' 
        ' TB_username
        ' 
        TB_username.Location = New Point(199, 162)
        TB_username.Name = "TB_username"
        TB_username.Size = New Size(333, 31)
        TB_username.TabIndex = 5
        ' 
        ' TB_password
        ' 
        TB_password.Location = New Point(199, 222)
        TB_password.Name = "TB_password"
        TB_password.Size = New Size(333, 31)
        TB_password.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(199, 100)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(333, 31)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(684, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 45)
        Label5.TabIndex = 8
        Label5.Text = "Lastname:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(715, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 45)
        Label6.TabIndex = 9
        Label6.Text = "Gender:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "LGBTQ+"})
        ComboBox1.Location = New Point(860, 98)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(155, 33)
        ComboBox1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(860, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(333, 166)
        Button1.TabIndex = 12
        Button1.Text = "Sign-UP"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TB_lastname
        ' 
        TB_lastname.Location = New Point(860, 37)
        TB_lastname.Name = "TB_lastname"
        TB_lastname.Size = New Size(333, 31)
        TB_lastname.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(199, 259)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 206)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1357, 586)
        Controls.Add(PictureBox1)
        Controls.Add(TB_lastname)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(TB_password)
        Controls.Add(TB_username)
        Controls.Add(TB_firstname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SignUP"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_firstname As MaskedTextBox
    Friend WithEvents TB_username As MaskedTextBox
    Friend WithEvents TB_password As MaskedTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_lastname As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
