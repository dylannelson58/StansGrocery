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
        Me.TestTextBox = New System.Windows.Forms.TextBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SuspendLayout()
        '
        'TestTextBox
        '
        Me.TestTextBox.Location = New System.Drawing.Point(359, 12)
        Me.TestTextBox.Multiline = True
        Me.TestTextBox.Name = "TestTextBox"
        Me.TestTextBox.Size = New System.Drawing.Size(429, 426)
        Me.TestTextBox.TabIndex = 0
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(249, 12)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(104, 48)
        Me.LoadButton.TabIndex = 1
        Me.LoadButton.Text = "&Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(249, 66)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(104, 48)
        Me.Search.TabIndex = 2
        Me.Search.Text = "&Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(249, 120)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(104, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.TestTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StansGrocery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestTextBox As TextBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents Search As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
