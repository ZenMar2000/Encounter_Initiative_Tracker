<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitiativeClearQuestionForm
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
        Me.ClearEveryoneInitiativeButton = New System.Windows.Forms.Button()
        Me.ClearEnemiesInitiativeButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ClearEveryoneInitiativeButton
        '
        Me.ClearEveryoneInitiativeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearEveryoneInitiativeButton.Location = New System.Drawing.Point(12, 53)
        Me.ClearEveryoneInitiativeButton.Name = "ClearEveryoneInitiativeButton"
        Me.ClearEveryoneInitiativeButton.Size = New System.Drawing.Size(134, 34)
        Me.ClearEveryoneInitiativeButton.TabIndex = 0
        Me.ClearEveryoneInitiativeButton.Text = "Everyone"
        Me.ClearEveryoneInitiativeButton.UseVisualStyleBackColor = True
        '
        'ClearEnemiesInitiativeButton
        '
        Me.ClearEnemiesInitiativeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearEnemiesInitiativeButton.Location = New System.Drawing.Point(152, 53)
        Me.ClearEnemiesInitiativeButton.Name = "ClearEnemiesInitiativeButton"
        Me.ClearEnemiesInitiativeButton.Size = New System.Drawing.Size(133, 34)
        Me.ClearEnemiesInitiativeButton.TabIndex = 1
        Me.ClearEnemiesInitiativeButton.Text = "Enemy only"
        Me.ClearEnemiesInitiativeButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(291, 53)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(133, 34)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Clear initiative for everyone or enemy only?"
        '
        'InitiativeClearQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 99)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ClearEnemiesInitiativeButton)
        Me.Controls.Add(Me.ClearEveryoneInitiativeButton)
        Me.Name = "InitiativeClearQuestionForm"
        Me.Text = "InitiativeClearQuestionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClearEveryoneInitiativeButton As Button
    Friend WithEvents ClearEnemiesInitiativeButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label1 As Label
End Class
