<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEdit
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AttributeInput = New System.Windows.Forms.TextBox()
        Me.RecordInput = New System.Windows.Forms.TextBox()
        Me.NotesBox = New System.Windows.Forms.TextBox()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(197, 226)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Attribute"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Record"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Notes"
        '
        'AttributeInput
        '
        Me.AttributeInput.Location = New System.Drawing.Point(65, 6)
        Me.AttributeInput.Name = "AttributeInput"
        Me.AttributeInput.Size = New System.Drawing.Size(207, 20)
        Me.AttributeInput.TabIndex = 5
        '
        'RecordInput
        '
        Me.RecordInput.Location = New System.Drawing.Point(65, 41)
        Me.RecordInput.Name = "RecordInput"
        Me.RecordInput.Size = New System.Drawing.Size(207, 20)
        Me.RecordInput.TabIndex = 6
        '
        'NotesBox
        '
        Me.NotesBox.Location = New System.Drawing.Point(65, 84)
        Me.NotesBox.Multiline = True
        Me.NotesBox.Name = "NotesBox"
        Me.NotesBox.Size = New System.Drawing.Size(207, 136)
        Me.NotesBox.TabIndex = 7
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.Location = New System.Drawing.Point(116, 226)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmBtn.TabIndex = 8
        Me.ConfirmBtn.Text = "Confirm"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'NewEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.NotesBox)
        Me.Controls.Add(Me.RecordInput)
        Me.Controls.Add(Me.AttributeInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Name = "NewEdit"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AttributeInput As TextBox
    Friend WithEvents RecordInput As TextBox
    Friend WithEvents NotesBox As TextBox
    Friend WithEvents ConfirmBtn As Button
End Class
