<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayPatientInfo
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
        Me.lstDisplayInfo = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDisplayInfo
        '
        Me.lstDisplayInfo.FormattingEnabled = True
        Me.lstDisplayInfo.Location = New System.Drawing.Point(185, 121)
        Me.lstDisplayInfo.Name = "lstDisplayInfo"
        Me.lstDisplayInfo.Size = New System.Drawing.Size(120, 95)
        Me.lstDisplayInfo.TabIndex = 0
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(207, 266)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return to Main Form"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmDisplayPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 327)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstDisplayInfo)
        Me.Name = "frmDisplayPatientInfo"
        Me.Text = "frmDisplayPatientInfo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstDisplayInfo As ListBox
    Friend WithEvents btnReturn As Button
End Class
