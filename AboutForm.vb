Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265 
'Spring 2021
'Stan's Grocery
'https://github.com/dylannelson58/StansGrocery

Public Class AboutForm

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click, ReturnToolStripMenuItem1.Click, ReturnButton.Click
        StansGrocery.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class