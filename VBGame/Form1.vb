'===============================================
' ■ Form1
'-----------------------------------------------
'   程序主窗口
'===============================================
Public Class Form1
    '------------------------------------------
    ' ● 共用部分
    '------------------------------------------
    Private S(,) As Button
    Private B(,) As Label  '格子背景
    Private Score As Integer = 0
    Private Highscore As String
    Dim Path As String = Application.StartupPath
    Dim BestSqu As String
    Dim NowSqu As String
    Dim InGame As Boolean = False

    '------------------------------------------
    ' ● 窗体完成后加载
    '------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Initalize()
        InGame = True
        Path = Path.Substring(0, Path.Length - 10) + "\data"
        GetHighScore()

    End Sub

    '------------------------------------------
    ' ● 游戏初始化
    '------------------------------------------
    Private Sub Initalize()
        S = New Button(3, 3) {}
        B = New Label(3, 3) {}
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                '活动块
                S(x, y) = New Button()
                Panel1.Controls.Add(S(x, y))
                S(x, y).Left = 10 + x * 100
                S(x, y).Top = 10 + y * 100
                S(x, y).Width = 90
                S(x, y).Height = 90
                S(x, y).Font = New Font("微软雅黑", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
                S(x, y).Name = "S" & (x + y * 4).ToString()
                S(x, y).BackColor = Color.FromArgb(204, 192, 180)
                S(x, y).ForeColor = Color.FromArgb(187, 173, 160)
                S(x, y).FlatStyle = FlatStyle.Flat
                S(x, y).Enabled = False
                '背景块
                B(x, y) = New Label()
                Panel1.Controls.Add(B(x, y))
                B(x, y).Left = 10 + x * 100
                B(x, y).Top = 10 + y * 100
                B(x, y).Width = 90
                B(x, y).Height = 90
                B(x, y).Name = "B" & (x + y * 4).ToString()
                B(x, y).BackColor = Color.FromArgb(204, 192, 180)
                B(x, y).ForeColor = Color.FromArgb(187, 173, 160)
                B(x, y).FlatStyle = FlatStyle.Flat
                B(x, y).Enabled = False
            Next
        Next
        For i As Integer = 0 To 3
            AddNewSqu()
        Next
        UpdateColor()
    End Sub

    '------------------------------------------
    ' ● 添加新方块
    '------------------------------------------
    Private Sub AddNewSqu()
        Randomize()
        Dim i As Integer
        Dim j As Integer
        Dim a As Integer = 0
        Dim r As New Random
        While a < 1
            If IsFull() Then
                Exit While
            End If
            i = r.Next(4)
            j = r.Next(4)
            If S(i, j).Text = "" Then
                S(i, j).Width = 0
                S(i, j).Height = 0
                S(i, j).Left = 55 + i * 100
                S(i, j).Top = 55 + j * 100
                Dim b As Integer
                b = r.Next(6)
                If b = 1 Then
                    S(i, j).Text = "4"
                Else
                    S(i, j).Text = "2"
                End If
                a += 1
            End If
        End While
    End Sub

    '------------------------------------------
    ' ● 更新方块颜色
    '------------------------------------------
    Private Sub UpdateColor()
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                Select Case S(x, y).Text
                    Case ""
                        S(x, y).BackColor = Color.FromArgb(204, 192, 180)
                    Case "2"
                        S(x, y).BackColor = Color.FromArgb(241, 229, 220)
                    Case "4"
                        S(x, y).BackColor = Color.FromArgb(237, 224, 200)
                    Case "8"
                        S(x, y).BackColor = Color.FromArgb(245, 177, 121)
                    Case "16"
                        S(x, y).BackColor = Color.FromArgb(249, 149, 99)
                    Case "32"
                        S(x, y).BackColor = Color.FromArgb(249, 123, 94)
                    Case "64"
                        S(x, y).BackColor = Color.FromArgb(249, 93, 57)
                    Case "128"
                        S(x, y).BackColor = Color.FromArgb(241, 208, 113)
                    Case "256"
                        S(x, y).BackColor = Color.FromArgb(241, 205, 97)
                    Case "512"
                        S(x, y).BackColor = Color.FromArgb(241, 201, 78)
                    Case "1024"
                        S(x, y).BackColor = Color.FromArgb(241, 198, 61)
                    Case "2048"
                        S(x, y).BackColor = Color.FromArgb(241, 195, 43)
                    Case "4096"
                        S(x, y).BackColor = Color.FromArgb(255, 58, 57)
                    Case "8192"
                        S(x, y).BackColor = Color.FromArgb(255, 28, 26)
                    Case "16384"
                        S(x, y).BackColor = Color.FromArgb(255, 28, 26)
                    Case "32768"
                        S(x, y).BackColor = Color.FromArgb(255, 28, 26)
                    Case "65536"
                        S(x, y).BackColor = Color.FromArgb(255, 28, 26)
                    Case Else
                        S(x, y).BackColor = Color.FromArgb(255, 28, 26)
                End Select
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 更新分数
    '------------------------------------------
    Private Sub ScoreUpdate()
        ScoreShow.Text = Score.ToString()
    End Sub

    '------------------------------------------
    ' ● 按键判断
    '------------------------------------------
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '先挪再加再挪
        If IsLeagalKeyPress(e) And InGame Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
                Move_up()
                Add_up()
                Move_up()
            ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
                Move_down()
                Add_down()
                Move_down()
            ElseIf e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
                Move_left()
                Add_left()
                Move_left()
            ElseIf e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
                Move_right()
                Add_right()
                Move_right()
            End If
            AddNewSqu()
            UpdateColor()
            ScoreUpdate()
            If IsGameOver() Then
                GameOver()
            End If
        End If
    End Sub

    '------------------------------------------
    ' ● 向上滑动
    '------------------------------------------
    Private Sub Move_up()
        For y As Integer = 1 To 3
            For x As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    Dim t As Integer = y
                    While S(x, t - 1).Text = ""
                        S(x, t - 1).Text = S(x, t).Text
                        S(x, t).Text = ""
                        t -= 1
                        If t <= 0 Then
                            Exit While
                        End If
                    End While
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向下滑动
    '------------------------------------------
    Private Sub Move_down()
        Dim y As Integer
        For a As Integer = 0 To 2
            y = 2 - a
            For x As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    Dim t As Integer = y
                    While S(x, t + 1).Text = ""
                        S(x, t + 1).Text = S(x, t).Text
                        S(x, t).Text = ""
                        t += 1
                        If t >= 3 Then
                            Exit While
                        End If
                    End While
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向左滑动
    '------------------------------------------
    Private Sub Move_left()
        For x As Integer = 1 To 3
            For y As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    Dim t As Integer = x
                    While S(t - 1, y).Text = ""
                        S(t - 1, y).Text = S(t, y).Text
                        S(t, y).Text = ""
                        t -= 1
                        If t <= 0 Then
                            Exit While
                        End If
                    End While
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向右滑动
    '------------------------------------------
    Private Sub Move_right()
        Dim x As Integer
        For a As Integer = 0 To 2
            x = 2 - a
            For y As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    Dim t As Integer = x
                    While S(t + 1, y).Text = ""
                        S(t + 1, y).Text = S(t, y).Text
                        S(t, y).Text = ""
                        t += 1
                        If t >= 3 Then
                            Exit While
                        End If
                    End While
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向上加和
    '------------------------------------------
    Private Sub Add_up()
        For y As Integer = 1 To 3
            For x As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    If S(x, y).Text = S(x, y - 1).Text Then
                        Score += Integer.Parse(S(x, y).Text)
                        S(x, y - 1).Text = (Integer.Parse(S(x, y).Text) * 2).ToString()
                        S(x, y).Text = ""
                        SoundPlay()
                    End If
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向下加和
    '------------------------------------------
    Private Sub Add_down()
        Dim y As Integer
        For a As Integer = 0 To 2
            y = 2 - a
            For x As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    If S(x, y).Text = S(x, y + 1).Text Then
                        Score += Integer.Parse(S(x, y).Text)
                        S(x, y + 1).Text = (Integer.Parse(S(x, y).Text) * 2).ToString()
                        S(x, y).Text = ""
                        SoundPlay()
                    End If
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向左加和
    '------------------------------------------
    Private Sub Add_left()
        For x As Integer = 1 To 3
            For y As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    If S(x, y).Text = S(x - 1, y).Text Then
                        Score += Integer.Parse(S(x, y).Text)
                        S(x - 1, y).Text = (Integer.Parse(S(x, y).Text) * 2).ToString()
                        S(x, y).Text = ""
                        SoundPlay()
                    End If
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 向右加和
    '------------------------------------------
    Private Sub Add_right()
        Dim x As Integer
        For a As Integer = 0 To 2
            x = 2 - a
            For y As Integer = 0 To 3
                If S(x, y).Text <> "" Then
                    'x是列，y是行
                    If S(x, y).Text = S(x + 1, y).Text Then
                        Score += Integer.Parse(S(x, y).Text)
                        S(x + 1, y).Text = (Integer.Parse(S(x, y).Text) * 2).ToString()
                        S(x, y).Text = ""
                        SoundPlay()
                    End If
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 重新开始游戏
    '------------------------------------------
    Private Sub Restart()
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                S(x, y).Text = ""
            Next
        Next
        Score = 0
        For i As Integer = 0 To 3
            AddNewSqu()
        Next
        ScoreUpdate()
        UpdateColor()
    End Sub

    '------------------------------------------
    ' ● 判断所有格子是否已满
    '------------------------------------------
    Private Function IsFull() As Boolean
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                If S(x, y).Text = "" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    '------------------------------------------
    ' ● 游戏结束判定
    '------------------------------------------
    Private Function IsGameOver() As Boolean
        If IsFull() Then
            For x As Integer = 0 To 3
                For y As Integer = 0 To 3
                    If x - 1 >= 0 Then
                        If S(x, y).Text = S(x - 1, y).Text Then
                            Return False
                        End If
                    End If
                    If x + 1 <= 3 Then
                        If S(x, y).Text = S(x + 1, y).Text Then
                            Return False
                        End If
                    End If
                    If y - 1 >= 0 Then
                        If S(x, y).Text = S(x, y - 1).Text Then
                            Return False
                        End If
                    End If
                    If y + 1 <= 3 Then
                        If S(x, y).Text = S(x, y + 1).Text Then
                            Return False
                        End If
                    End If
                Next
            Next
            Return True
        End If
        Return False
    End Function

    '------------------------------------------
    ' ● 游戏结束处理
    '------------------------------------------
    Private Sub GameOver()
        MessageBox.Show("Score: " + Score.ToString(), "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information)
        WriteHighScore()
        GetHighScore()
        Restart()
    End Sub

    '------------------------------------------
    ' ● 获取最高分
    '------------------------------------------
    Private Sub GetHighScore()
        If Not Integer.TryParse(System.IO.File.ReadAllText(Path + "\HighScore.txt"), Highscore) Then
            Highscore = 0
            Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(Path + "\HighScore.txt", False)
            t.Write("0")
            t.Close() '对异常文件进行重写处理
        End If
        MaxScore.Text = Highscore.ToString()
    End Sub

    '------------------------------------------
    ' ● 获取最高分的情景
    '------------------------------------------
    Private Sub GetHighScoreScene()
        Dim str As String
        Dim tmp As Integer
        Dim cnt As Integer = 0
        str = System.IO.File.ReadAllText(Path + "\SquSave.txt")
        For t As Integer = 0 To str.Length() - 1
            If str.Chars(t) = "," Then
                cnt += 1
            End If
        Next
        If cnt < 15 Then  '异常数据的处理：方块不足
            cnt = 0
            str = ""
            While cnt < 15
                str += " ,"
                cnt += 1
            End While
            str.Substring(0, str.Length() - 1)
        End If
        Dim a
        Dim i As Integer = 0
        a = Split(str, ",")
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                If Not Integer.TryParse(a(i), tmp) Then
                    a(i) = "" '异常数据的处理
                End If
                S(x, y).Text = a(i)
                i += 1
            Next
        Next
        UpdateColor()
    End Sub

    '------------------------------------------
    ' ● 写入最高分
    '------------------------------------------
    Private Sub WriteHighScore()
        If Score > Highscore Then
            Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(Path + "\HighScore.txt", False)
            t.Write(Score.ToString)
            t.Close()
            WriteHighScoreScene()
        End If
    End Sub

    '------------------------------------------
    ' ● 写入最高分的情景
    '------------------------------------------
    Private Sub WriteHighScoreScene()
        Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(Path + "\SquSave.txt", False)
        Dim str As String = ""
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                str += S(x, y).Text + ","
            Next
        Next
        str.Substring(0, str.Length() - 1) '去除最后逗号
        t.Write(str)
        t.Close()
    End Sub

    '------------------------------------------
    ' ● 存储目前的情景
    '------------------------------------------
    Private Sub SaveNowScene()
        NowSqu = ""
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                NowSqu += S(x, y).Text + ","
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 按键合法性判定
    '------------------------------------------
    Private Function IsLeagalKeyPress(ByVal e As KeyEventArgs) As Boolean
        If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right) Then
            Return True
        ElseIf (e.KeyCode = Keys.W Or e.KeyCode = Keys.S Or e.KeyCode = Keys.A Or e.KeyCode = Keys.D) Then
            Return True
        End If
        Return False
    End Function

    '------------------------------------------
    ' ● 动画计时器
    '------------------------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                If S(x, y).Width < 90 Then
                    S(x, y).Left -= 5
                    S(x, y).Top -= 5
                    S(x, y).Width += 10
                    S(x, y).Height += 10
                End If
            Next
        Next
    End Sub

    '------------------------------------------
    ' ● 重新开始按钮及特效
    '------------------------------------------
    Private Sub RestartButton_MouseDown(sender As Object, e As MouseEventArgs) Handles RestartButton.MouseDown
        If e.Button = MouseButtons.Left Then
            RestartButton.ForeColor = Color.DarkRed
            RestartButton.Text = "Restart"
        End If
    End Sub
    Private Sub RestartButton_Click(sender As Object, e As MouseEventArgs) Handles RestartButton.Click
        If e.Button = MouseButtons.Left Then
            WriteHighScore()
            GetHighScore()
            Restart()
        End If
    End Sub
    Private Sub RestartButton_MouseUp(sender As Object, e As MouseEventArgs) Handles RestartButton.MouseUp
        If e.Button = MouseButtons.Left Then
            RestartButton.ForeColor = Color.Red
            RestartButton.Text = "Restart?"
        End If
    End Sub
    Private Sub RestartButton_MouseEnter(sender As Object, e As EventArgs) Handles RestartButton.MouseEnter
        RestartButton.ForeColor = Color.Red
        RestartButton.Text = "Restart?"
    End Sub
    Private Sub RestartButton_MouseLeave(sender As Object, e As EventArgs) Handles RestartButton.MouseLeave
        RestartButton.ForeColor = Color.DarkOrange
        RestartButton.Text = "Restart"
    End Sub

    '------------------------------------------
    ' ● 鼠标移到最高分时
    '------------------------------------------
    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, Label4.MouseEnter, MaxScore.MouseEnter
        InGame = False
        SaveNowScene()
        GetHighScoreScene()
    End Sub

    '------------------------------------------
    ' ● 鼠标移开最高分时
    '------------------------------------------
    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave, Label4.MouseLeave, MaxScore.MouseLeave
        Dim a
        a = Split(NowSqu, ",")
        Dim i As Integer = 0
        For x As Integer = 0 To 3
            For y As Integer = 0 To 3
                S(x, y).Text = a(i)
                i += 1
            Next
        Next
        UpdateColor()
        InGame = True
    End Sub

    '------------------------------------------
    ' ● 播放音效
    '------------------------------------------
    Private Sub SoundPlay()
        AxWindowsMediaPlayer1.URL = Path + "\Join.mp3"
    End Sub
End Class
