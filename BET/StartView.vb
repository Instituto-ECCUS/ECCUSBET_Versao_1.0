Public Class StartView
    Private Sub BtnStatr_Click(sender As Object, e As EventArgs) Handles BtnStatr.Click
        SizingView.Show()
        Me.Close()
    End Sub

    Private Sub BtnMinimized_Click(sender As Object, e As EventArgs) Handles BtnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnClosed_Click(sender As Object, e As EventArgs) Handles BtnClosed.Click
        Me.Close()
    End Sub
End Class