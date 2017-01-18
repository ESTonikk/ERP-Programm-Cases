Imports WindowsApplication1._Case

Public Class Mainwindow
    Private sap_proxy As _Case.Z_HH_CASEClient
    Private newEditWindow As NewEdit
    Private LoginWindow As Login
    Private currCaseObj As CaseClass
    Public Sub New(sap_proxy As _Case.Z_HH_CASEClient)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.sap_proxy = sap_proxy
    End Sub
    Private Sub edit(sender As Object, e As EventArgs) Handles EditBtn.Click
        newEditWindow = New NewEdit(currCaseObj, Me)
        newEditWindow.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Hier irgendwie das selektierte objekt reinschreiben, aber wie :D
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'Hier ListBox befüllen
    End Sub

    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        Application.Exit()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        LoginWindow = New Login

        Me.Close()
        Me.LoginWindow.Show()
    End Sub

    Private Sub create(sender As Object, e As EventArgs) Handles NewBtn.Click
        newEditWindow = New NewEdit(Nothing, Me)
        newEditWindow.Show()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        'ListBox von neuem Befüllen
        Me.refreshList()
    End Sub

    Public Function refreshList()
        On Error GoTo errtrap



exitfunction:
        Exit Function
errtrap:
        Print(Err.Erl & " " & Err.Description)
        Resume exitfunction
    End Function

    Private Sub Delete(sender As Object, e As EventArgs) Handles DeleteBtn.Click

        Me.currCaseObj = Nothing
    End Sub

    Private Sub Mainwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Error GoTo errtrap
        'Dim note As New Bapinote
        'Dim noteGet As New CaseGetNotes
        'Dim noteRequest As New CaseGetNotesRequest
        Dim noteResponse As New CaseGetNotesResponse
        Dim recordResponse As New CaseGetRecordResponse
        Dim attributeResponse As New CaseGetAttributesResponse


        If sap_proxy Is Nothing Then
            sap_proxy = New Z_HH_CASEClient
            sap_proxy.ClientCredentials.UserName.UserName = "wsuser"
            sap_proxy.ClientCredentials.UserName.Password = "123456"
        End If
        noteResponse = sap_proxy.CaseGetNotes(New CaseGetNotes())
        recordResponse = sap_proxy.CaseGetRecord(New CaseGetRecord())
        attributeResponse = sap_proxy.CaseGetAttributes(New CaseGetAttributes())

    End Sub

    Private Sub CaseList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CaseList.SelectedIndexChanged

    End Sub
End Class