Imports System.Xml
Public Class MainForm
    Dim Doc As XmlDocument

    Private Sub Init() Handles Me.Shown
        dgv.Columns(0).ReadOnly = True

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Select Case e.ColumnIndex
            Case 0 'Took Action clicked
                If e.RowIndex >= 0 Then
                    SetBackgroundColor(dgv.Rows(e.RowIndex), Color.LightGreen, 0, 3)
                End If
        End Select
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        Select Case e.ColumnIndex
            Case 5 'Has Problems clicked
                If dgv.Rows(e.RowIndex).Cells(5).Value = True Then
                    SetBackgroundColor(dgv.Rows(e.RowIndex), Color.Yellow, 4, 5)
                Else
                    SetBackgroundColor(dgv.Rows(e.RowIndex), Nothing, 4, 5)
                End If

            Case 6 'Is Enemy clicked
                If dgv.Rows(e.RowIndex).Cells(6).Value = True Then
                    SetBackgroundColor(dgv.Rows(e.RowIndex), Color.LightSalmon, 6, 6)
                Else
                    SetBackgroundColor(dgv.Rows(e.RowIndex), Nothing, 6, 6)
                End If

        End Select

    End Sub
    Private Sub ResetTurnActions_Click(sender As Object, e As EventArgs) Handles ResetTurnActions.Click
        ResetTurnAction()
    End Sub
    Private Sub NextEncounter_Click(sender As Object, e As EventArgs) Handles NextEncounter.Click
        ResetTurnAction()

        For i As Integer = dgv.RowCount - 2 To 0 Step -1
            If (dgv.Rows(i).Cells(6).Value <> Nothing Or dgv.Rows(i).Cells(6).Value.ToString <> "") AndAlso dgv.Rows(i).Cells(6).Value = True Then
                dgv.Rows.RemoveAt(i)
                Continue For

            Else
                If dgv.Rows(i).Cells(5).Value <> "" AndAlso dgv.Rows(i).Cells(5).Value = True Then
                    dgv.Rows(i).Cells(5).Value = False
                    SetBackgroundColor(dgv.Rows(i), Nothing, 4, 5)
                End If

                dgv.Rows(i).Cells(4).Value = ""

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

                CreateSingleXmlAttribute(initiative_string, x, 1, newRow)
                CreateSingleXmlAttribute(name_string, x, 2, newRow)
                CreateSingleXmlAttribute(armorClass_string, x, 3, newRow)
                CreateSingleXmlAttribute(notes_string, x, 4, newRow)
                CreateSingleXmlAttribute(hasProblems_string, x, 5, newRow)
                CreateSingleXmlAttribute(isEnemy_string, x, 6, newRow)

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
                innerIndex += 1
                dgv.Rows(index).Cells(innerIndex).Value = innernode.InnerText
            Next
        Next

        For i As Integer = 0 To dgv.RowCount - 2
            If dgv.Rows(i).Cells(5).Value <> "" AndAlso dgv.Rows(i).Cells(5).Value = True Then
                SetBackgroundColor(dgv.Rows(i), Color.Yellow, 4, 5)
            End If

            If dgv.Rows(i).Cells(6).Value <> "" AndAlso dgv.Rows(i).Cells(6).Value = True Then
                SetBackgroundColor(dgv.Rows(i), Color.LightSalmon, 6, 6)
            End If
        Next

    End Sub

    Private Sub dataerror() Handles dgv.DataError

    End Sub

#Region "utilities"
    Private Sub SetBackgroundColor(ByRef row As DataGridViewRow, color As Color, startColumnIndex As Integer, endColumnIndex As Integer)
        For i As Integer = startColumnIndex To endColumnIndex
            row.Cells(i).Style.BackColor = color
        Next
    End Sub
    Private Sub ReorderInitiative_Click(sender As Object, e As EventArgs) Handles ReorderInitiative.Click
        Dim intParser As Integer = 0

        For Each row As DataGridViewRow In dgv.Rows

            If row.Cells("Initiative").Value <> Nothing Then
                Integer.TryParse(row.Cells("Initiative").Value.ToString(), intParser)
                row.Cells("Initiative").Value = intParser
            End If

        Next

        dgv.Sort(dgv.Columns("Initiative"), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Private Sub ResetTurnAction()
        For i As Integer = 0 To dgv.RowCount - 1
            If dgv.Rows(i).Cells(0).Style.BackColor = Color.LightGreen Then
                SetBackgroundColor(dgv.Rows(i), Nothing, 0, 3)
            End If
        Next
    End Sub
    Private Sub CreateSingleXmlAttribute(attributeName As String, dgvRowIndex As Integer, dgvColumnIndex As Integer, ByRef xmlRowNode As XmlNode)
        Dim tempNode As XmlNode = Doc.CreateElement(attributeName)
        tempNode.InnerText = dgv.Rows(dgvRowIndex).Cells(dgvColumnIndex).Value
        xmlRowNode.AppendChild(tempNode)
    End Sub

#End Region

End Class
