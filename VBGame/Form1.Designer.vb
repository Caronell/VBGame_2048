<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ScoreShow = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RestartButton = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaxScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(10, 138)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 518)
        Me.Panel1.TabIndex = 0
        '
        'ScoreShow
        '
        Me.ScoreShow.BackColor = System.Drawing.Color.Transparent
        Me.ScoreShow.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.ScoreShow.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ScoreShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScoreShow.Location = New System.Drawing.Point(0, 31)
        Me.ScoreShow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreShow.Name = "ScoreShow"
        Me.ScoreShow.Size = New System.Drawing.Size(134, 35)
        Me.ScoreShow.TabIndex = 1
        Me.ScoreShow.Text = "0"
        Me.ScoreShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'RestartButton
        '
        Me.RestartButton.AutoSize = True
        Me.RestartButton.BackColor = System.Drawing.Color.Transparent
        Me.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestartButton.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold)
        Me.RestartButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.RestartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RestartButton.Location = New System.Drawing.Point(397, 88)
        Me.RestartButton.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(124, 40)
        Me.RestartButton.TabIndex = 2
        Me.RestartButton.Text = "Restart"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 38.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(10, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 77)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "2048"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ScoreShow)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(257, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(134, 68)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SCORE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MaxScore)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Panel3.Location = New System.Drawing.Point(395, 10)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(134, 68)
        Me.Panel3.TabIndex = 6
        '
        'MaxScore
        '
        Me.MaxScore.BackColor = System.Drawing.Color.Transparent
        Me.MaxScore.Font = New System.Drawing.Font("微软雅黑", 16.0!, System.Drawing.FontStyle.Bold)
        Me.MaxScore.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MaxScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaxScore.Location = New System.Drawing.Point(0, 31)
        Me.MaxScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaxScore.Name = "MaxScore"
        Me.MaxScore.Size = New System.Drawing.Size(134, 35)
        Me.MaxScore.TabIndex = 1
        Me.MaxScore.Text = "0"
        Me.MaxScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 35)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "BEST"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Join the numbers and get to the"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(285, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "2048 tile!"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 5)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(33, 33)
        Me.AxWindowsMediaPlayer1.TabIndex = 9
        Me.AxWindowsMediaPlayer1.TabStop = False
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(538, 667)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2048"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ScoreShow As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RestartButton As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaxScore As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
