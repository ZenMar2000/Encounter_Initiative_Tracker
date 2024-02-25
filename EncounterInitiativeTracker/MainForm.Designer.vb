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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.TookAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Initiative = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharacterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArmorClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthPoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HasProblems = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsPlayer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReorderInitiative = New System.Windows.Forms.Button()
        Me.NextTurn = New System.Windows.Forms.Button()
        Me.NewEncounter = New System.Windows.Forms.Button()
        Me.NextEncounterTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.RollInitiativeButton = New System.Windows.Forms.Button()
        Me.ClearInitiativeButton = New System.Windows.Forms.Button()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TookAction, Me.Initiative, Me.CharacterName, Me.ArmorClass, Me.HealthPoints, Me.Notes, Me.HasProblems, Me.IsPlayer})
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ArmorClass.DefaultCellStyle = DataGridViewCellStyle1
        Me.ArmorClass.HeaderText = "Armor Class"
        Me.ArmorClass.Name = "ArmorClass"
        Me.ArmorClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ArmorClass.Width = 61
        '
        'HealthPoints
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HealthPoints.DefaultCellStyle = DataGridViewCellStyle2
        Me.HealthPoints.HeaderText = "Health Points"
        Me.HealthPoints.Name = "HealthPoints"
        Me.HealthPoints.Width = 88
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
        'IsPlayer
        '
        Me.IsPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IsPlayer.HeaderText = "Is Player"
        Me.IsPlayer.Name = "IsPlayer"
        Me.IsPlayer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsPlayer.Width = 48
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
        'NextTurn
        '
        Me.NextTurn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NextTurn.Location = New System.Drawing.Point(13, 400)
        Me.NextTurn.Name = "NextTurn"
        Me.NextTurn.Size = New System.Drawing.Size(147, 23)
        Me.NextTurn.TabIndex = 1
        Me.NextTurn.Text = "Next Turn"
        Me.NextTurn.UseVisualStyleBackColor = True
        '
        'NewEncounter
        '
        Me.NewEncounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewEncounter.Location = New System.Drawing.Point(450, 400)
        Me.NewEncounter.Name = "NewEncounter"
        Me.NewEncounter.Size = New System.Drawing.Size(147, 23)
        Me.NewEncounter.TabIndex = 4
        Me.NewEncounter.Text = "New Encounter"
        Me.NextEncounterTooltip.SetToolTip(Me.NewEncounter, "Remove all enemies and reset 'initiative', 'notes' and 'Has Problems' columns")
        Me.NewEncounter.UseVisualStyleBackColor = True
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
        'RollInitiativeButton
        '
        Me.RollInitiativeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RollInitiativeButton.Location = New System.Drawing.Point(356, 400)
        Me.RollInitiativeButton.Name = "RollInitiativeButton"
        Me.RollInitiativeButton.Size = New System.Drawing.Size(88, 23)
        Me.RollInitiativeButton.TabIndex = 7
        Me.RollInitiativeButton.Text = "Roll Initiative"
        Me.RollInitiativeButton.UseVisualStyleBackColor = True
        '
        'ClearInitiativeButton
        '
        Me.ClearInitiativeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearInitiativeButton.Location = New System.Drawing.Point(356, 429)
        Me.ClearInitiativeButton.Name = "ClearInitiativeButton"
        Me.ClearInitiativeButton.Size = New System.Drawing.Size(88, 23)
        Me.ClearInitiativeButton.TabIndex = 8
        Me.ClearInitiativeButton.Text = "Clear Initiative"
        Me.ClearInitiativeButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 463)
        Me.Controls.Add(Me.ClearInitiativeButton)
        Me.Controls.Add(Me.RollInitiativeButton)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.NewEncounter)
        Me.Controls.Add(Me.ReorderInitiative)
        Me.Controls.Add(Me.NextTurn)
        Me.Controls.Add(Me.dgv)
        Me.Name = "MainForm"
        Me.Text = "Encounter Initiative Tracker"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents ReorderInitiative As Button
    Friend WithEvents NextTurn As Button
    Friend WithEvents NewEncounter As Button
    Friend WithEvents NextEncounterTooltip As ToolTip
    Friend WithEvents ExportButton As Button
    Friend WithEvents ImportButton As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents TookAction As DataGridViewTextBoxColumn
    Friend WithEvents Initiative As DataGridViewTextBoxColumn
    Friend WithEvents CharacterName As DataGridViewTextBoxColumn
    Friend WithEvents ArmorClass As DataGridViewTextBoxColumn
    Friend WithEvents HealthPoints As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents HasProblems As DataGridViewCheckBoxColumn
    Friend WithEvents IsPlayer As DataGridViewCheckBoxColumn
    Friend WithEvents RollInitiativeButton As Button
    Friend WithEvents ClearInitiativeButton As Button
End Class
