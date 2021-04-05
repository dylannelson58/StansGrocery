Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265 
'Spring 2021
'Math Contest
'https://github.com/dylannelson58/StansGrocery


Public Class StansGrocery

    Dim food(256, 2) As String
    Dim filter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ReadFile()
        Dim fileNumber As Integer = FreeFile()
        Dim fileName As String = "grocery.txt"
        Dim currentRecord As String

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord)
                Console.WriteLine(currentRecord)
                Console.ReadLine()
            Loop
        Catch ex As Exception
            OpenFileDialog.ShowDialog()
            fileName = OpenFileDialog.FileName

        End Try
    End Sub

    'Sub LoadDataFile()
    '    Dim temp() As String
    '    Dim secondArray As String
    '    Dim thirdArray As String

    '    temp = Split(My.Resources.crocery, vbNewLine)
    '    For i = LBound(temp)

    'End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ReadFile()
        TestTextBox.Text = OpenFileDialog.FileName

    End Sub
End Class
