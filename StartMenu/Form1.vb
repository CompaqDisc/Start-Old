Public Class StartMenuMain

    Private Sub StartMenuMain_LostFocus(sender As Object, e As EventArgs) Handles MyBase.LostFocus
        'Me.Close()
    End Sub

    Private Sub StartMenuMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.Focus()
        Dim ScreenSize = Screen.PrimaryScreen.WorkingArea
        Dim X As Integer = 0
        Dim Y As Integer = ScreenSize.Height - Me.Size.Height
        Me.Location = New Point(X, Y)
        UsernameLabel.Text = My.User.CurrentPrincipal.Identity.Name.ToString
        Me.BackgroundImage = Image.FromFile(".\Themes\Default\Background.png")
    End Sub
End Class
