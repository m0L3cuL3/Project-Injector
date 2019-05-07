<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ThirteenForm1 = New Project_Injector.ThirteenForm()
        Me.ThirteenTabControl1 = New Project_Injector.ThirteenTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New Project_Injector.ThirteenTextBox()
        Me.DLLs = New System.Windows.Forms.ListBox()
        Me.ProgramCombo = New Project_Injector.ThirteenComboBox()
        Me.BrowseButton = New Project_Injector.ThirteenButton()
        Me.ExitButton = New Project_Injector.ThirteenButton()
        Me.RemoveButton = New Project_Injector.ThirteenButton()
        Me.InjectButton = New Project_Injector.ThirteenButton()
        Me.ClearButton = New Project_Injector.ThirteenButton()
        Me.ThirteenControlBox1 = New Project_Injector.ThirteenControlBox()
        Me.ThirteenForm1.SuspendLayout()
        Me.ThirteenTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = Project_Injector.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.ThirteenTabControl1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenControlBox1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Margin = New System.Windows.Forms.Padding(2)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(742, 505)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "Project Injector"
        '
        'ThirteenTabControl1
        '
        Me.ThirteenTabControl1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenTabControl1.ColorScheme = Project_Injector.ThirteenTabControl.ColorSchemes.Dark
        Me.ThirteenTabControl1.Controls.Add(Me.TabPage1)
        Me.ThirteenTabControl1.ForeColor = System.Drawing.Color.White
        Me.ThirteenTabControl1.Location = New System.Drawing.Point(9, 35)
        Me.ThirteenTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.ThirteenTabControl1.Name = "ThirteenTabControl1"
        Me.ThirteenTabControl1.SelectedIndex = 0
        Me.ThirteenTabControl1.Size = New System.Drawing.Size(724, 461)
        Me.ThirteenTabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.DLLs)
        Me.TabPage1.Controls.Add(Me.ProgramCombo)
        Me.TabPage1.Controls.Add(Me.BrowseButton)
        Me.TabPage1.Controls.Add(Me.ExitButton)
        Me.TabPage1.Controls.Add(Me.RemoveButton)
        Me.TabPage1.Controls.Add(Me.InjectButton)
        Me.TabPage1.Controls.Add(Me.ClearButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(716, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Injector"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 394)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Internet Connection:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 413)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "ConnectionStatus"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(487, 184)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(157, 132)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Functions"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 40)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 21)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manual Injection"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 93)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 21)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Close After Injection"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 67)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 21)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Automatic Injection"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Waiting for program to start..."
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ColorScheme = Project_Injector.ThirteenTextBox.ColorSchemes.Dark
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(93, 124)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(390, 25)
        Me.TextBox1.TabIndex = 22
        '
        'DLLs
        '
        Me.DLLs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DLLs.FormattingEnabled = True
        Me.DLLs.ItemHeight = 17
        Me.DLLs.Location = New System.Drawing.Point(232, 152)
        Me.DLLs.Margin = New System.Windows.Forms.Padding(2)
        Me.DLLs.Name = "DLLs"
        Me.DLLs.Size = New System.Drawing.Size(252, 157)
        Me.DLLs.TabIndex = 21
        '
        'ProgramCombo
        '
        Me.ProgramCombo.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ProgramCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgramCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgramCombo.ColorScheme = Project_Injector.ThirteenComboBox.ColorSchemes.Dark
        Me.ProgramCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ProgramCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramCombo.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ProgramCombo.ForeColor = System.Drawing.Color.White
        Me.ProgramCombo.FormattingEnabled = True
        Me.ProgramCombo.Location = New System.Drawing.Point(487, 152)
        Me.ProgramCombo.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgramCombo.Name = "ProgramCombo"
        Me.ProgramCombo.Size = New System.Drawing.Size(158, 26)
        Me.ProgramCombo.TabIndex = 23
        '
        'BrowseButton
        '
        Me.BrowseButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.BrowseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BrowseButton.ColorScheme = Project_Injector.ThirteenButton.ColorSchemes.Dark
        Me.BrowseButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.BrowseButton.ForeColor = System.Drawing.Color.White
        Me.BrowseButton.Location = New System.Drawing.Point(93, 152)
        Me.BrowseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(134, 37)
        Me.BrowseButton.TabIndex = 13
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExitButton.ColorScheme = Project_Injector.ThirteenButton.ColorSchemes.Dark
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(93, 279)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(134, 37)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'RemoveButton
        '
        Me.RemoveButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.RemoveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RemoveButton.ColorScheme = Project_Injector.ThirteenButton.ColorSchemes.Dark
        Me.RemoveButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.RemoveButton.ForeColor = System.Drawing.Color.White
        Me.RemoveButton.Location = New System.Drawing.Point(93, 194)
        Me.RemoveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(134, 37)
        Me.RemoveButton.TabIndex = 14
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = False
        '
        'InjectButton
        '
        Me.InjectButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.InjectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InjectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.InjectButton.ColorScheme = Project_Injector.ThirteenButton.ColorSchemes.Dark
        Me.InjectButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.InjectButton.ForeColor = System.Drawing.Color.White
        Me.InjectButton.Location = New System.Drawing.Point(487, 124)
        Me.InjectButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InjectButton.Name = "InjectButton"
        Me.InjectButton.Size = New System.Drawing.Size(157, 24)
        Me.InjectButton.TabIndex = 16
        Me.InjectButton.Text = "Inject"
        Me.InjectButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClearButton.ColorScheme = Project_Injector.ThirteenButton.ColorSchemes.Dark
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(93, 236)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(134, 37)
        Me.ClearButton.TabIndex = 15
        Me.ClearButton.Text = "Clear List"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ThirteenControlBox1
        '
        Me.ThirteenControlBox1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThirteenControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenControlBox1.ColorScheme = Project_Injector.ThirteenControlBox.ColorSchemes.Dark
        Me.ThirteenControlBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenControlBox1.Location = New System.Drawing.Point(640, 2)
        Me.ThirteenControlBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ThirteenControlBox1.Name = "ThirteenControlBox1"
        Me.ThirteenControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.ThirteenControlBox1.TabIndex = 11
        Me.ThirteenControlBox1.Text = "ThirteenControlBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 505)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThirteenForm1 As ThirteenForm
    Friend WithEvents ThirteenControlBox1 As ThirteenControlBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ThirteenTabControl1 As ThirteenTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As ThirteenTextBox
    Friend WithEvents DLLs As ListBox
    Friend WithEvents ProgramCombo As ThirteenComboBox
    Friend WithEvents BrowseButton As ThirteenButton
    Friend WithEvents ExitButton As ThirteenButton
    Friend WithEvents RemoveButton As ThirteenButton
    Friend WithEvents InjectButton As ThirteenButton
    Friend WithEvents ClearButton As ThirteenButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
