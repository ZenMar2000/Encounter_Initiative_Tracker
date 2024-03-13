Public Class InitiativeClearQuestionForm
    Private _answer As Response = Response.NONE
    Public Property Answer As Response
        Get
            Return _answer
        End Get
        Private Set(value As Response)
            _answer = value
        End Set
    End Property

    Private Sub ClearEveryoneInitiativeButton_Click(sender As Object, e As EventArgs) Handles ClearEveryoneInitiativeButton.Click
        Answer = Response.ALL
        Hide()

    End Sub

    Private Sub ClearEnemiesInitiativeButton_Click(sender As Object, e As EventArgs) Handles ClearEnemiesInitiativeButton.Click
        Answer = Response.ENEMY
        Hide()

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Answer = Response.NONE
        Hide()

    End Sub

    Public Enum Response
        ALL
        ENEMY
        NONE
    End Enum
End Class