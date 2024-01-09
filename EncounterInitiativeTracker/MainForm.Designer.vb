<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TookAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Initiative = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharacterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArmorClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HasProblems = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsEnemy = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReorderInitiative = New System.Windows.Forms.Button()
        Me.ResetTurnActions = New System.Windows.Forms.Button()
        Me.NextEncounter = New System.Windows.Forms.Button()
        Me.NextEncounterTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TookAction, Me.Initiative, Me.CharacterName, Me.ArmorClass, Me.Notes, Me.HasProblems, Me.IsEnemy})
        Me.dgv.Location = New System.Drawing.Point(13, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(584, 380)
        Me.dgv.TabIndex = 0
        '
        'TookAction
        '
        Me.TookAction.HeaderText = "Took Action"
        Me.TookAction.Name = "TookAction"
        Me.TookAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TookAction.Width = 64
        '
        'Initiative
        '
        Me.Initiative.HeaderText = "Initiative"
        Me.Initiative.Name = "Initiative"
        Me.Initiative.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Initiative.Width = 52
        '
        'CharacterName
        '
        Me.CharacterName.HeaderText = "Character Name"
        Me.CharacterName.Name = "CharacterName"
        Me.CharacterName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CharacterName.Width = 81
        '
        'ArmorClass
        '
        Me.ArmorClass.HeaderText = "Armor Class"
        Me.ArmorClass.Name = "ArmorClass"
        Me.ArmorClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ArmorClass.Width = 61
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Notes.Width = 41
        '
        'HasProblems
        '
        Me.HasProblems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HasProblems.HeaderText = "Has Problems"
        Me.HasProblems.Name = "HasProblems"
        Me.HasProblems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.HasProblems.Width = 89
        '
        'IsEnemy
        '
        Me.IsEnemy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IsEnemy.HeaderText = "Is Enemy"
        Me.IsEnemy.Name = "IsEnemy"
        Me.IsEnemy.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsEnemy.Width = 51
        '
        'ReorderInitiative
        '
        Me.ReorderInitiative.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ReorderInitiative.Location = New System.Drawing.Point(13, 428)
        Me.ReorderInitiative.Name = "ReorderInitiative"
        Me.ReorderInitiative.Size = New System.Drawing.Size(147, 23)
        Me.ReorderInitiative.TabIndex = 2
        Me.ReorderInitiative.Text = "Reorder Initiative"
        Me.ReorderInitiative.UseVisualStyleBackColor = True
        '
        'ResetTurnActions
        '
        Me.ResetTurnActions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResetTurnActions.Location = New System.Drawing.Point(13, 400)
        Me.ResetTurnActions.Name = "ResetTurnActions"
        Me.ResetTurnActions.Size = New System.Drawing.Size(147, 23)
        Me.ResetTurnActions.TabIndex = 1
        Me.ResetTurnActions.Text = "Reset Turn Actions"
        Me.ResetTurnActions.UseVisualStyleBackColor = True
        '
        'NextEncounter
        '
        Me.NextEncounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextEncounter.Location = New System.Drawing.Point(450, 400)
        Me.NextEncounter.Name = "NextEncounter"
        Me.NextEncounter.Size = New System.Drawing.Size(147, 23)
        Me.NextEncounter.TabIndex = 4
        Me.NextEncounter.Text = "Next Encounter"
        Me.NextEncounterTooltip.SetToolTip(Me.NextEncounter, "Remove all enemies and reset 'initiative', 'notes' and 'Has Problems' columns")
        Me.NextEncounter.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportButton.Location = New System.Drawing.Point(450, 429)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(72, 23)
        Me.ExportButton.TabIndex = 5
        Me.ExportButton.Text = "Export"
        Me.NextEncounterTooltip.SetToolTip(Me.ExportButton, "Remove all enemies and reset 'initiative', 'notes' and 'Has Problems' columns")
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportButton.Location = New System.Drawing.Point(525, 428)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(72, 23)
        Me.ImportButton.TabIndex = 6
        Me.ImportButton.Text = "Import"
        Me.NextEncounterTooltip.SetToolTip(Me.ImportButton, "Remove all enemies and reset 'initiative', 'notes' and 'Has Problems' columns")
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 463)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.NextEncounter)
        Me.Controls.Add(Me.ReorderInitiative)
        Me.Controls.Add(Me.ResetTurnActions)
        Me.Controls.Add(Me.dgv)
        Me.Name = "MainForm"
        Me.Text = "Encounter Initiative Tracker"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents ReorderInitiative As Button
    Friend WithEvents ResetTurnActions As Button
    Friend WithEvents NextEncounter As Button
    Friend WithEvents TookAction As DataGridViewTextBoxColumn
    Friend WithEvents Initiative As DataGridViewTextBoxColumn
    Friend WithEvents CharacterName As DataGridViewTextBoxColumn
    Friend WithEvents ArmorClass As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents HasProblems As DataGridViewCheckBoxColumn
    Friend WithEvents IsEnemy As DataGridViewCheckBoxColumn
    Friend WithEvents NextEncounterTooltip As ToolTip
    Friend WithEvents ExportButton As Button
    Friend WithEvents ImportButton As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
End Class
