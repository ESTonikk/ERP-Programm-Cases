<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainwindow
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CaseList = New System.Windows.Forms.ListBox()
        Me.NewBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CaseList
        '
        Me.CaseList.FormattingEnabled = True
        Me.CaseList.Location = New System.Drawing.Point(12, 12)
        Me.CaseList.Name = "CaseList"
        Me.CaseList.Size = New System.Drawing.Size(527, 290)
        Me.CaseList.TabIndex = 0
        '
        'NewBtn
        '
        Me.NewBtn.Location = New System.Drawing.Point(557, 12)
        Me.NewBtn.Name = "NewBtn"
        Me.NewBtn.Size = New System.Drawing.Size(189, 23)
        Me.NewBtn.TabIndex = 1
        Me.NewBtn.Text = "New"
        Me.NewBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(557, 42)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(189, 23)
        Me.EditBtn.TabIndex = 2
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(557, 71)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(189, 23)
        Me.DeleteBtn.TabIndex = 3
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Location = New System.Drawing.Point(557, 249)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(189, 23)
        Me.LogoutBtn.TabIndex = 4
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'QuitBtn
        '
        Me.QuitBtn.Location = New System.Drawing.Point(557, 278)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(189, 23)
        Me.QuitBtn.TabIndex = 5
        Me.QuitBtn.Text = "Quit"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(557, 100)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(189, 23)
        Me.RefreshBtn.TabIndex = 6
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'Mainwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 313)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.NewBtn)
        Me.Controls.Add(Me.CaseList)
        Me.Name = "Mainwindow"
        Me.Text = "ERP Projekt Cases"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CaseList As ListBox
    Friend WithEvents NewBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents QuitBtn As Button
    Friend WithEvents RefreshBtn As Button
End Class
