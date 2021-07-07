Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = TimeOfDay()
        Label2.Text = Format(Now().Date(), "dd / MM / yy")
        Label3.Text = Format(Now().Date(), "MMMM")
    End Sub

End Class