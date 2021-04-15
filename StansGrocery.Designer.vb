<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGrocery
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
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.RadioFilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchAndExitGroupBox = New System.Windows.Forms.GroupBox()
        Me.AllControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.RadioFilterGroupBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SearchAndExitGroupBox.SuspendLayout()
        Me.AllControlsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(6, 57)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(104, 48)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "&Search"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Searches the index of items for a match to what is typed.")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(7, 111)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(103, 48)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FileToolStripMenuItem.Text = "Menu"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(253, 36)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(356, 264)
        Me.DisplayListBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DisplayListBox, "List of items with filters applied.")
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Items.AddRange(New Object() {"Show All"})
        Me.FilterComboBox.Location = New System.Drawing.Point(6, 76)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(104, 21)
        Me.FilterComboBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.FilterComboBox, "Shows the Aisle or Category depending upon the filter selected.")
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(7, 32)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SearchTextBox.TabIndex = 0
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(6, 16)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(41, 13)
        Me.SearchLabel.TabIndex = 8
        Me.SearchLabel.Text = "Search"
        '
        'RadioFilterGroupBox
        '
        Me.RadioFilterGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RadioFilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.RadioFilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.RadioFilterGroupBox.Controls.Add(Me.FilterComboBox)
        Me.RadioFilterGroupBox.Location = New System.Drawing.Point(9, 189)
        Me.RadioFilterGroupBox.Name = "RadioFilterGroupBox"
        Me.RadioFilterGroupBox.Size = New System.Drawing.Size(238, 111)
        Me.RadioFilterGroupBox.TabIndex = 9
        Me.RadioFilterGroupBox.TabStop = False
        Me.RadioFilterGroupBox.Text = "Filters"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 48)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(6, 30)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.FilterByAisleRadioButton.TabIndex = 1
        Me.FilterByAisleRadioButton.TabStop = True
        Me.FilterByAisleRadioButton.Text = "Filter By Aisle"
        Me.ToolTip1.SetToolTip(Me.FilterByAisleRadioButton, "Sorts items by aisle.")
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(6, 53)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.FilterByCategoryRadioButton.TabIndex = 0
        Me.FilterByCategoryRadioButton.TabStop = True
        Me.FilterByCategoryRadioButton.Text = "Filter By Category"
        Me.ToolTip1.SetToolTip(Me.FilterByCategoryRadioButton, "Sorts items by category.")
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(250, 20)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(41, 13)
        Me.DisplayLabel.TabIndex = 10
        Me.DisplayLabel.Text = "Display"
        '
        'SearchAndExitGroupBox
        '
        Me.SearchAndExitGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SearchAndExitGroupBox.Controls.Add(Me.ExitButton)
        Me.SearchAndExitGroupBox.Controls.Add(Me.SearchButton)
        Me.SearchAndExitGroupBox.Controls.Add(Me.SearchTextBox)
        Me.SearchAndExitGroupBox.Controls.Add(Me.SearchLabel)
        Me.SearchAndExitGroupBox.Location = New System.Drawing.Point(9, 18)
        Me.SearchAndExitGroupBox.Name = "SearchAndExitGroupBox"
        Me.SearchAndExitGroupBox.Size = New System.Drawing.Size(238, 165)
        Me.SearchAndExitGroupBox.TabIndex = 11
        Me.SearchAndExitGroupBox.TabStop = False
        Me.SearchAndExitGroupBox.Text = "Search and Exit"
        '
        'AllControlsGroupBox
        '
        Me.AllControlsGroupBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AllControlsGroupBox.Controls.Add(Me.DisplayListBox)
        Me.AllControlsGroupBox.Controls.Add(Me.RadioFilterGroupBox)
        Me.AllControlsGroupBox.Controls.Add(Me.SearchAndExitGroupBox)
        Me.AllControlsGroupBox.Controls.Add(Me.DisplayLabel)
        Me.AllControlsGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.AllControlsGroupBox.Name = "AllControlsGroupBox"
        Me.AllControlsGroupBox.Size = New System.Drawing.Size(615, 308)
        Me.AllControlsGroupBox.TabIndex = 12
        Me.AllControlsGroupBox.TabStop = False
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 339)
        Me.Controls.Add(Me.AllControlsGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StansGrocery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stan's Grocery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.RadioFilterGroupBox.ResumeLayout(False)
        Me.RadioFilterGroupBox.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SearchAndExitGroupBox.ResumeLayout(False)
        Me.SearchAndExitGroupBox.PerformLayout()
        Me.AllControlsGroupBox.ResumeLayout(False)
        Me.AllControlsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents RadioFilterGroupBox As GroupBox
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SearchAndExitGroupBox As GroupBox
    Friend WithEvents AllControlsGroupBox As GroupBox
End Class
