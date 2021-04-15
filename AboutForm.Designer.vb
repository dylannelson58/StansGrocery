<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CreditsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReturnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.CreatedByLabel = New System.Windows.Forms.Label()
        Me.RCETLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UniLabel = New System.Windows.Forms.Label()
        Me.StansGroceryLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CreditsGroupBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.InfoGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CreditsGroupBox
        '
        Me.CreditsGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CreditsGroupBox.Controls.Add(Me.OptionsGroupBox)
        Me.CreditsGroupBox.Controls.Add(Me.InfoGroupBox)
        Me.CreditsGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.CreditsGroupBox.Name = "CreditsGroupBox"
        Me.CreditsGroupBox.Size = New System.Drawing.Size(684, 300)
        Me.CreditsGroupBox.TabIndex = 0
        Me.CreditsGroupBox.TabStop = False
        Me.CreditsGroupBox.Text = "Credits"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'ReturnToolStripMenuItem1
        '
        Me.ReturnToolStripMenuItem1.Name = "ReturnToolStripMenuItem1"
        Me.ReturnToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ReturnToolStripMenuItem1.Text = "Return"
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.OptionsGroupBox.Controls.Add(Me.ExitButton)
        Me.OptionsGroupBox.Controls.Add(Me.ReturnButton)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(6, 158)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Size = New System.Drawing.Size(203, 136)
        Me.OptionsGroupBox.TabIndex = 3
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "Options"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(9, 83)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(105, 47)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit the program.")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(9, 30)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(105, 47)
        Me.ReturnButton.TabIndex = 1
        Me.ReturnButton.Text = "&Return"
        Me.ToolTip1.SetToolTip(Me.ReturnButton, "Return to Stan's Grocery")
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.InfoGroupBox.Controls.Add(Me.CreatedByLabel)
        Me.InfoGroupBox.Controls.Add(Me.RCETLabel)
        Me.InfoGroupBox.Controls.Add(Me.Label2)
        Me.InfoGroupBox.Controls.Add(Me.UniLabel)
        Me.InfoGroupBox.Controls.Add(Me.StansGroceryLabel)
        Me.InfoGroupBox.Location = New System.Drawing.Point(6, 19)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(203, 133)
        Me.InfoGroupBox.TabIndex = 2
        Me.InfoGroupBox.TabStop = False
        '
        'CreatedByLabel
        '
        Me.CreatedByLabel.AutoSize = True
        Me.CreatedByLabel.Location = New System.Drawing.Point(6, 16)
        Me.CreatedByLabel.Name = "CreatedByLabel"
        Me.CreatedByLabel.Size = New System.Drawing.Size(128, 13)
        Me.CreatedByLabel.TabIndex = 0
        Me.CreatedByLabel.Text = "Created By: Dylan Nelson"
        '
        'RCETLabel
        '
        Me.RCETLabel.AutoSize = True
        Me.RCETLabel.Location = New System.Drawing.Point(6, 38)
        Me.RCETLabel.Name = "RCETLabel"
        Me.RCETLabel.Size = New System.Drawing.Size(63, 13)
        Me.RCETLabel.TabIndex = 0
        Me.RCETLabel.Text = "RCET 0265"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Spring 2021"
        '
        'UniLabel
        '
        Me.UniLabel.AutoSize = True
        Me.UniLabel.Location = New System.Drawing.Point(6, 105)
        Me.UniLabel.Name = "UniLabel"
        Me.UniLabel.Size = New System.Drawing.Size(111, 13)
        Me.UniLabel.TabIndex = 0
        Me.UniLabel.Text = "Idaho State University"
        '
        'StansGroceryLabel
        '
        Me.StansGroceryLabel.AutoSize = True
        Me.StansGroceryLabel.Location = New System.Drawing.Point(6, 83)
        Me.StansGroceryLabel.Name = "StansGroceryLabel"
        Me.StansGroceryLabel.Size = New System.Drawing.Size(76, 13)
        Me.StansGroceryLabel.TabIndex = 0
        Me.StansGroceryLabel.Text = "Stan's Grocery"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 339)
        Me.Controls.Add(Me.CreditsGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.CreditsGroupBox.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreditsGroupBox As GroupBox
    Friend WithEvents StansGroceryLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RCETLabel As Label
    Friend WithEvents CreatedByLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ReturnToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UniLabel As Label
    Friend WithEvents InfoGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents OptionsGroupBox As GroupBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
