Imports WindowsApplication1

Public Class NewEdit
    Private aCaseObj As CaseClass
    Private isNewObj As Boolean
    Private fieldContent As String
    Private mainwindow As Mainwindow

    Public Sub New(caseObj As CaseClass)
        On Error GoTo errtrap

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        If Not caseObj Is Nothing Then
            isNewObj = False
            Me.aCaseObj = caseObj
        Else
            Me.aCaseObj = New CaseClass()
            isNewObj = True
        End If
exitsub:
        Exit Sub
errtrap:
        Print(Err.Erl & ": " & Err.Description)
        Resume exitsub
    End Sub

    Public Sub New(caseObj As CaseClass, mainwindow As Mainwindow)
        Me.New(caseObj)
        Me.mainwindow = mainwindow
    End Sub

    Private Sub Cancel(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub Confirm(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        fieldContent = AttributeInput.Text + "~~" + RecordInput.Text + "~~" + Join(Split(Replace(NotesBox.Text, Chr(10), ""), Chr(13)), "~~")

        If isNewObj Then
            aCaseObj.create(fieldContent)
        Else
            aCaseObj.save(fieldContent)
        End If
        Me.mainwindow.refreshList()
    End Sub

    Private Sub NewEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.isNewObj Then
            Me.AttributeInput.Text = Me.aCaseObj.Attributes1
            Me.RecordInput.Text = Me.aCaseObj.Record1
            Me.NotesBox.Text = Join(Me.aCaseObj.Notes1, Chr(10))
        End If
    End Sub

    Private Sub NotesBox_TextChanged(sender As Object, e As EventArgs) Handles NotesBox.TextChanged

    End Sub
End Class