﻿Imports System.Xml
Public Class MainForm
    Dim Doc As XmlDocument
    'todo
    '1) aggiungere contatore dei turni + incremento ad ogni nuovo turno
    '2) aggiungere bottone per generare iniziativa per enemies

    Private Sub Init() Handles Me.Shown
        dgv.Columns(0).ReadOnly = True

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If (e.ColumnIndex >= 0) Then
            Select Case dgv.Columns(e.ColumnIndex).Name
                Case tookAction_string 'Took Action clicked
                    If e.RowIndex >= 0 Then
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Color.LightGreen, tookAction_string, 2)
                    End If
            End Select
        End If

    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Try
            Select Case dgv.Columns(e.ColumnIndex).Name
                Case hasProblems_string 'Has Problems clicked
                    If dgv.Rows(e.RowIndex).Cells(hasProblems_string).Value = True Then
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Color.Yellow, tookAction_string, 3)
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Color.Yellow, notes_string, 1)
                    Else
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Nothing, tookAction_string, 3)
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Nothing, notes_string, 1)
                    End If

                Case isPlayer_string 'Is player clicked
                    If dgv.Rows(e.RowIndex).Cells(isPlayer_string).Value = True Then
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Color.LightBlue, isPlayer_string, 0)
                    Else
                        SetBackgroundColor(dgv.Rows(e.RowIndex), Nothing, isPlayer_string, 0)
                    End If

            End Select

        Catch ex As Exception

        End Try
    End Sub
    Private Sub NextTurn_Click(sender As Object, e As EventArgs) Handles NextTurn.Click
        TurnCounterTextBox.Text = CInt(TurnCounterTextBox.Text) + 1
        ResetTurnAction()
    End Sub
    Private Sub NextEncounter_Click(sender As Object, e As EventArgs) Handles NewEncounter.Click
        TurnCounterTextBox.Text = 1

        ResetTurnAction()

        For i As Integer = dgv.RowCount - 2 To 0 Step -1
            If dgv.Rows(i).Cells(isPlayer_string).Value = Nothing OrElse dgv.Rows(i).Cells(isPlayer_string).Value.ToString = "" OrElse dgv.Rows(i).Cells(isPlayer_string).Value = False Then
                dgv.Rows.RemoveAt(i)
                Continue For

            Else
                If dgv.Rows(i).Cells(hasProblems_string).Value <> Nothing OrElse dgv.Rows(i).Cells(hasProblems_string).Value = True Then
                    dgv.Rows(i).Cells(hasProblems_string).Value = False
                    SetBackgroundColor(dgv.Rows(i), Nothing, notes_string, 1)
                End If
            End If
        Next

    End Sub
    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        sfd.FileName = ""
        sfd.Filter = "XML Files|*.xml"
        If sfd.ShowDialog() = DialogResult.OK Then
            Doc = New XmlDocument

            Dim dec As XmlDeclaration = Doc.CreateXmlDeclaration("1.0", Nothing, Nothing)
            Doc.AppendChild(dec)

            Dim DocRoot As XmlElement = Doc.CreateElement(rootName_string)
            Doc.AppendChild(DocRoot)

            For x As Integer = 0 To dgv.RowCount - 2
                Dim newRow As XmlNode = Doc.CreateElement(characterRow_string)

                For y As Integer = 0 To dgv.ColumnCount - 1
                    CreateSingleXmlAttribute("Col" & y, x, y, newRow)
                Next

                DocRoot.AppendChild(newRow)
            Next

            Doc.Save(sfd.FileName)

        End If
    End Sub
    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        ofd.FileName = ""
        ofd.Filter = "XML Files|*.xml"

        If ofd.ShowDialog() = DialogResult.OK Then
            If ofd.FileName <> "" AndAlso Strings.Right(ofd.FileName, 4).ToLower = ".xml" Then
                Doc = New XmlDocument
                Doc.Load(ofd.FileName)
            Else
                MsgBox("incorrect format or broken file path")
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        dgv.Rows.Clear()
        Dim index As Integer = 0
        For Each onode As XmlNode In Doc.SelectNodes("//" & characterRow_string)
            index = dgv.Rows.Add()
            Dim innerIndex As Integer = 0
            For Each innernode As XmlNode In onode.ChildNodes

                If TypeOf dgv.Columns(innerIndex) Is DataGridViewCheckBoxColumn Then
                    dgv.Rows(index).Cells(innerIndex).Value = IIf(innernode.InnerText = "True", True, False)
                Else
                    dgv.Rows(index).Cells(innerIndex).Value = innernode.InnerText
                End If

                innerIndex += 1
            Next
        Next

        For i As Integer = 0 To dgv.RowCount - 2
            If dgv.Rows(i).Cells(hasProblems_string).Value.ToString = "True" Then
                SetBackgroundColor(dgv.Rows(i), Color.Yellow, notes_string, 1)
            End If

            If dgv.Rows(i).Cells(isPlayer_string).Value.ToString = "True" Then
                SetBackgroundColor(dgv.Rows(i), Color.LightBlue, isPlayer_string, 0)
            End If
        Next

    End Sub

#Region "utilities"
    Private Sub SetBackgroundColor(ByRef row As DataGridViewRow, color As Color, startColumnName As String, colorThisManyCellsAfterward As Integer)

        Dim startColumnIndex As String
        Try
            startColumnIndex = dgv.Columns(startColumnName).Index

        Catch ex As Exception
            MsgBox($"Error while setting background: {vbNewLine}Color column {startColumnName} does not exist")
            Exit Sub

        End Try

        If startColumnIndex + colorThisManyCellsAfterward > dgv.ColumnCount - 1 Then
            colorThisManyCellsAfterward = dgv.ColumnCount - 1 - startColumnIndex
        End If

        For i As Integer = startColumnIndex To startColumnIndex + colorThisManyCellsAfterward
            row.Cells(i).Style.BackColor = color
        Next
    End Sub

    Private Sub ReorderInitiative_Click(sender As Object, e As EventArgs) Handles ReorderInitiative.Click
        Dim intParser As Integer = 0

        For Each row As DataGridViewRow In dgv.Rows

            If row.Cells(initiative_string).Value <> Nothing Then
                Integer.TryParse(row.Cells(initiative_string).Value.ToString(), intParser)
                row.Cells(initiative_string).Value = intParser
            End If

        Next

        dgv.Sort(dgv.Columns(initiative_string), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub ResetTurnAction()
        For i As Integer = 0 To dgv.RowCount - 1
            If dgv.Rows(i).Cells(tookAction_string).Style.BackColor = Color.LightGreen Then
                If dgv.Rows(i).Cells(hasProblems_string).Style.BackColor = Color.Yellow Then
                    SetBackgroundColor(dgv.Rows(i), Color.Yellow, tookAction_string, 2)

                Else
                    SetBackgroundColor(dgv.Rows(i), Nothing, tookAction_string, 2)

                End If
            End If
        Next
    End Sub
    Private Sub CreateSingleXmlAttribute(attributeName As String, dgvRowIndex As Integer, dgvColumnIndex As Integer, ByRef xmlRowNode As XmlNode)
        Dim tempNode As XmlNode = Doc.CreateElement(attributeName)
        tempNode.InnerText = dgv.Rows(dgvRowIndex).Cells(dgvColumnIndex).Value
        xmlRowNode.AppendChild(tempNode)
    End Sub

    Private Sub RollInitiativeButton_Click(sender As Object, e As EventArgs) Handles RollInitiativeButton.Click
        Dim rand As New Random()
        Dim row As DataGridViewRow
        For i As Integer = 0 To dgv.Rows.Count - 2
            row = dgv.Rows(i)
            If CheckIfEmptyCell(row.Cells(initiative_string).Value) = True Then
                row.Cells(initiative_string).Value = rand.Next(1, 20)
            End If
        Next
    End Sub

    Private Sub ClearInitiativeButton_Click(sender As Object, e As EventArgs) Handles ClearInitiativeButton.Click
        Dim questionForm As New InitiativeClearQuestionForm
        Dim row As DataGridViewRow
        questionForm.StartPosition() = FormStartPosition.CenterParent
        questionForm.ShowDialog()

        Dim clearAllInitiative As Boolean = IIf(questionForm.Answer = InitiativeClearQuestionForm.Response.ALL, True, False)

        For i As Integer = 0 To dgv.Rows.Count - 2
            row = dgv.Rows(i)

            If clearAllInitiative Then
                row.Cells(initiative_string).Value = ""

            ElseIf CheckIfEmptyCell(row.Cells(isPlayer_string).Value) = False OrElse row.Cells(isPlayer_string).Value = False Then
                row.Cells(initiative_string).Value = ""

            End If

        Next

        'Select Case questionForm.Answer
        '    Case InitiativeClearQuestionForm.Response.ALL

        '    Case InitiativeClearQuestionForm.Response.ENEMY

        'End Select

        questionForm.Dispose()
    End Sub

    Private Function CheckIfEmptyCell(value As String) As Boolean
        If IsNumeric(value) Then
            Dim myInt As Integer = CInt(value)
            Return CInt(value) > 20 Or myInt <= 0

        End If
        Return True

    End Function

    Private Function CheckIfEmptyCell(value) As Boolean
        If value Is Nothing Then
            Return True
        Else
            Return CheckIfEmptyCell(value.ToString)
        End If
    End Function

    Private Sub TurnCounterTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TurnCounterTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

End Class
