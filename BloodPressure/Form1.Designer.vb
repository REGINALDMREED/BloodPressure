<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBloodPressure
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplayNum = New System.Windows.Forms.Label()
        Me.lblDisplayAvg = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuclear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Blood Presure Report"
        '
        'lblDisplayNum
        '
        Me.lblDisplayNum.AutoSize = True
        Me.lblDisplayNum.Location = New System.Drawing.Point(111, 191)
        Me.lblDisplayNum.Name = "lblDisplayNum"
        Me.lblDisplayNum.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayNum.TabIndex = 1
        Me.lblDisplayNum.Text = "Label2"
        '
        'lblDisplayAvg
        '
        Me.lblDisplayAvg.AutoSize = True
        Me.lblDisplayAvg.Location = New System.Drawing.Point(111, 244)
        Me.lblDisplayAvg.Name = "lblDisplayAvg"
        Me.lblDisplayAvg.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayAvg.TabIndex = 2
        Me.lblDisplayAvg.Text = "Label3"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(174, 124)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuclear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(218, 22)
        Me.mnuDisplay.Text = "Display Patient Information"
        '
        'mnuclear
        '
        Me.mnuclear.Name = "mnuclear"
        Me.mnuclear.Size = New System.Drawing.Size(218, 22)
        Me.mnuclear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(218, 22)
        Me.mnuExit.Text = "Exit"
        '
        'frmBloodPressure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 347)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblDisplayAvg)
        Me.Controls.Add(Me.lblDisplayNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBloodPressure"
        Me.Text = "Patient Blood Pressur Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDisplayNum As Label
    Friend WithEvents lblDisplayAvg As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuclear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
End Class
