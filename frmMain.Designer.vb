<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbShutdown = New System.Windows.Forms.RadioButton()
        Me.rdbRestart = New System.Windows.Forms.RadioButton()
        Me.rdbLogOff = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboMinutes = New System.Windows.Forms.ComboBox()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrDisplayTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckActionTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCurrentTime)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Minutes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hours"
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Font = New System.Drawing.Font("DS-Digital", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTime.Location = New System.Drawing.Point(19, 40)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(284, 47)
        Me.lblCurrentTime.TabIndex = 5
        Me.lblCurrentTime.Text = "Current Time"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbShutdown)
        Me.GroupBox2.Controls.Add(Me.rdbRestart)
        Me.GroupBox2.Controls.Add(Me.rdbLogOff)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "What do you want to do?"
        '
        'rdbShutdown
        '
        Me.rdbShutdown.AutoSize = True
        Me.rdbShutdown.Location = New System.Drawing.Point(337, 45)
        Me.rdbShutdown.Name = "rdbShutdown"
        Me.rdbShutdown.Size = New System.Drawing.Size(106, 24)
        Me.rdbShutdown.TabIndex = 7
        Me.rdbShutdown.TabStop = True
        Me.rdbShutdown.Text = "Shutdown"
        Me.rdbShutdown.UseVisualStyleBackColor = True
        '
        'rdbRestart
        '
        Me.rdbRestart.AutoSize = True
        Me.rdbRestart.Location = New System.Drawing.Point(180, 45)
        Me.rdbRestart.Name = "rdbRestart"
        Me.rdbRestart.Size = New System.Drawing.Size(87, 24)
        Me.rdbRestart.TabIndex = 6
        Me.rdbRestart.TabStop = True
        Me.rdbRestart.Text = "Restart"
        Me.rdbRestart.UseVisualStyleBackColor = True
        '
        'rdbLogOff
        '
        Me.rdbLogOff.AutoSize = True
        Me.rdbLogOff.Location = New System.Drawing.Point(23, 45)
        Me.rdbLogOff.Name = "rdbLogOff"
        Me.rdbLogOff.Size = New System.Drawing.Size(87, 24)
        Me.rdbLogOff.TabIndex = 5
        Me.rdbLogOff.TabStop = True
        Me.rdbLogOff.Text = "Log Off"
        Me.rdbLogOff.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboMinutes)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cboHours)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "When to do it?"
        '
        'cboMinutes
        '
        Me.cboMinutes.FormattingEnabled = True
        Me.cboMinutes.Location = New System.Drawing.Point(281, 49)
        Me.cboMinutes.Name = "cboMinutes"
        Me.cboMinutes.Size = New System.Drawing.Size(62, 28)
        Me.cboMinutes.TabIndex = 1
        Me.cboMinutes.Text = "0"
        '
        'cboHours
        '
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Location = New System.Drawing.Point(83, 50)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(64, 28)
        Me.cboHours.TabIndex = 0
        Me.cboHours.Text = "0"
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSet.ForeColor = System.Drawing.Color.Black
        Me.btnSet.Location = New System.Drawing.Point(51, 389)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(138, 35)
        Me.btnSet.TabIndex = 0
        Me.btnSet.Text = "&Set"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(208, 389)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(138, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(365, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tmrDisplayTime
        '
        Me.tmrDisplayTime.Enabled = True
        '
        'tmrCheckActionTime
        '
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(552, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows Shutdown Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSet As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdbShutdown As RadioButton
    Friend WithEvents rdbRestart As RadioButton
    Friend WithEvents rdbLogOff As RadioButton
    Friend WithEvents cboMinutes As ComboBox
    Friend WithEvents cboHours As ComboBox
    Friend WithEvents tmrDisplayTime As Timer
    Friend WithEvents tmrCheckActionTime As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents Label1 As Label
End Class
