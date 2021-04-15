Option Strict On
Option Explicit On
Option Compare Text

'Dylan Nelson
'RCET0265 
'Spring 2021
'Stan's Grocery
'https://github.com/dylannelson58/StansGrocery


Public Class StansGrocery

    Dim foodArray(256, 2) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialArray() As String = Split(My.Resources.grocery_txt, vbNewLine)

        For i = 0 To (initialArray.GetUpperBound(0))

            'Splits the items into an array using a comma as a delimiter
            Dim splitArray() As String = Split(initialArray(i), ",")

            'Sets the food array to each property
            Dim nameArray() As String = Split(splitArray(0), "ITM")
            Dim locArray() As String = Split(splitArray(1), "LOC")
            Dim catArray() As String = Split(splitArray(2), "CAT")

            'Further places just the desired value into more arrays trimming off additional characters
            foodArray(i, 0) = nameArray(1).Trim(Chr(34))
            foodArray(i, 1) = locArray(1).Trim(Chr(34))
            foodArray(i, 2) = catArray(1).Trim(Chr(34))

            'Aisle 1 is missing this assigns the missing aisle number
            If foodArray(i, 1) = "" Then
                foodArray(i, 1) = "1"
            End If
        Next

        'load the items from the array to the displaybox
        LoadAllItemsToDisplayBoxCat("")

        'Sorts the items alphebetically
        DisplayListBox.Sorted = True
    End Sub


    Sub LoadAllItemsToDisplayBoxLoc(ByVal locName As String)
        DisplayListBox.Items.Clear()
        'Looks at the whole food array
        For i = 0 To 255
            If foodArray(i, 0).ToString = "" Then
            Else
                If DisplayListBox.Items.Contains(foodArray(i, 0).ToString) Then
                Else
                    'removes the blank values for item names
                    If foodArray(i, 1).ToString = locName Then
                        DisplayListBox.Items.Add(foodArray(i, 0).ToString)
                    ElseIf locName = "" Then
                        DisplayListBox.Items.Add(foodArray(i, 0).ToString)
                    End If
                End If
            End If
        Next
    End Sub

    Sub LoadAllItemsToDisplayBoxCat(ByVal catName As String)
        DisplayListBox.Items.Clear()
        'Looks at the whole food array
        For i = 0 To 255
            'if the item is blank it does not get added
            If foodArray(i, 0).ToString = "" Then
            Else
                'only add distinct values
                If DisplayListBox.Items.Contains(foodArray(i, 0).ToString) Then
                Else
                    'removes the blank values for catagories
                    If foodArray(i, 2).ToString = catName Then
                        DisplayListBox.Items.Add(foodArray(i, 0).ToString)
                    ElseIf catName = "" Then
                        DisplayListBox.Items.Add(foodArray(i, 0).ToString)
                    End If
                End If
            End If
        Next
    End Sub

    'find the indexvalue from groceryArray from an itemName
    Function FindItemFromName(ByVal itemName As String) As Integer
        Dim indexValue As Integer = -1

        'check all values to see if itemname matches one in array
        For i = 0 To 255
            If itemName = (foodArray(i, 0).ToString) Then
                Return i
            End If
        Next

        'if no values equal itemName return -1
        Return -1
    End Function

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

        'takes the value of the name, location, and catagory and allows them to be interpreted to the display label
        Dim selectedItemName As String = DisplayListBox.SelectedItem.ToString
        Dim selectedItemLoc As String = foodArray(FindItemFromName(selectedItemName), 1)
        Dim selectedItemCat As String = foodArray(FindItemFromName(selectedItemName), 2)

        'display the item selected in the displaylistbox
        DisplayLabel.Text = selectedItemName & " can be found on aisle " & selectedItemLoc & " with " & selectedItemCat & "."

    End Sub

    Sub DisplayAllFromString(ByVal itemName As String)
        'clear the display listbox
        DisplayListBox.Items.Clear()

        'make sure the itemName is not blank
        If itemName = "" Then
        Else

            For i = 0 To 255
                'add items that contain the itemName text
                If foodArray(i, 0).Contains(itemName) Then
                    'add only distinct items
                    If DisplayListBox.Items.Contains(foodArray(i, 0).ToString) Then
                    Else
                        'add the item to the displaybox
                        DisplayListBox.Items.Add(foodArray(i, 0))
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchToolStripMenuItem1.Click
        'display the items that match the string
        DisplayAllFromString(SearchTextBox.Text)

        'if there is no items added, prompt user and reset textbox
        If DisplayListBox.Items.Count = 0 Then
            DisplayLabel.Text = ($"Sorry no matches for ""{SearchTextBox.Text}""")
            SearchTextBox.Text = ""
            DisplayListBox.Items.Clear()
            '

            FilterByAisleRadioButton.Checked = True
            'LoadAllItemsToDisplayBoxLoc("")

        End If

        FilterComboBox.SelectedItem = "Show All"

        'Resets the filter radio button to aisle by default
        FilterByAisleRadioButton.Checked = True


    End Sub

    Private Sub FilterByAisleRadioButton_CheckChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.Click, FilterByCategoryRadioButton.Click
        FilterComboBox.Items.Clear()

        If FilterByAisleRadioButton.Checked = True Then

            'Change combo box to have all aisles from groceryArray
            For i = 0 To 255

                'No aisles added if blank
                If foodArray(i, 1) = "" Then
                Else
                    'Add only distinct items
                    If FilterComboBox.Items.Contains(foodArray(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((foodArray(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next

            'Sort the items numerically 
            FilterComboBox.Sorted = True
            'Because the items are sorted already unsorting them allows for show all to be placed at top of list
            FilterComboBox.Sorted = False

            'Insert the "Show All" option and sets it to the top of the list
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0
        End If

        If FilterByCategoryRadioButton.Checked = True Then
            For i = 0 To 255

                If foodArray(i, 2) = "" Then
                Else
                    'Add only distinct items
                    If FilterComboBox.Items.Contains(foodArray(i, 2)) Then
                    Else
                        FilterComboBox.Items.Add(foodArray(i, 2))
                    End If
                End If
            Next

            'This code accomplishes the same as above sorts the combobox alphbetically and allows for show all to be top spot
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False

            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0
        End If

    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        If FilterComboBox.Items.Count > 0 Then
            'Sort by category and load those items to the displayListBox
            If FilterByCategoryRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then
                    'Load all items if show all is selected
                    LoadAllItemsToDisplayBoxCat("")
                Else
                    'Loads the items based on the catagory
                    LoadAllItemsToDisplayBoxCat(FilterComboBox.SelectedItem.ToString)
                End If
            ElseIf FilterByAisleRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then

                    LoadAllItemsToDisplayBoxLoc("")
                Else
                    'Load items based on the location
                    LoadAllItemsToDisplayBoxLoc(FilterComboBox.SelectedItem.ToString.Trim)
                End If
            End If
        End If


    End Sub

    Sub ExitProgram() Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click, ExitButton.Click

        'Closes the program when any of the exit commands are clicked
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'Hides the StansGroceryForm and shows the AboutForm
        AboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        'Exit program if user enters zzz into searchtextbox
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

End Class
