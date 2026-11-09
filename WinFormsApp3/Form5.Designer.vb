<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        TB_username = New TextBox()
        TB_password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TB_username
        ' 
        TB_username.Location = New Point(319, 88)
        TB_username.Name = "TB_username"
        TB_username.Size = New Size(374, 31)
        TB_username.TabIndex = 1
        ' 
        ' TB_password
        ' 
        TB_password.Location = New Point(319, 174)
        TB_password.Name = "TB_password"
        TB_password.Size = New Size(374, 31)
        TB_password.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(135, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 45)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(141, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 45)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(723, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 88)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1013, 450)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TB_password)
        Controls.Add(TB_username)
        Name = "Form2"
        Text = "LoginDemo"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TB_username As TextBox
    Friend WithEvents TB_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
