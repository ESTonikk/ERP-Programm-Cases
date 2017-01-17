Public Class Login
    Public sap_proxy As _Case.Z_HH_CASEClient
    Public Window As Mainwindow


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo errtrap

        Window = New Mainwindow(sap_proxy)
        sap_proxy = New _Case.Z_HH_CASEClient()
        sap_proxy.ClientCredentials.UserName.UserName = txtUser.Text
        sap_proxy.ClientCredentials.UserName.Password = txtPassword.Text

        Me.Hide()
        Window.Show()
exitsub:
        Exit Sub
errtrap:
        Print(Err.Erl & " " & Err.Description)
        Resume exitsub
    End Sub

    Private Sub Abbrechen_Click(sender As Object, e As EventArgs) Handles Abbrechen.Click
        Me.Close()
    End Sub
End Class
