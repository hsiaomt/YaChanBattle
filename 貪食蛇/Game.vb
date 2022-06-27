Imports AxWMPLib

Public Class Game

#Region "欄位"
    Dim dotPB, chaPB As New List(Of PictureBox)
    Dim rnd As New Random
    Dim keyCode(,) As Integer = {{87, 83, 65, 68, 32}, {38, 40, 37, 39, 13}} '{W, S, A, D, Space},{Up, Down, Left, Right, Enter}
    Dim lastCode(1) As Integer
    Public player(1), score(1) As Integer
    Dim canUseSkill(1) As Boolean
    Dim skillPoint(1) As Integer

    Dim score_label(1) As Label
    Dim skill_label(1) As Label
    Dim skillPoint_label(1) As Label

    Dim Rect(1) As Rectangle
    Dim myRect(49) As Rectangle
    Dim lineRect(3) As Rectangle

    Dim characters As New List(Of Object)
    Dim YC1 As New YaChan1
    Dim YC2 As New YaChan2
    Dim YC3 As New YaChan3
    Dim PH As New PoHung

    Dim SelectCharacter_Panel_g As Graphics
    Dim GameMenu_Panel_g As Graphics
    Dim Game_Panel_g As Graphics

    Dim music_path As String = Application.StartupPath & "\音樂\"
    Dim music_path_ary As New List(Of String)
    Dim RB As New List(Of RadioButton)
#End Region

#Region "Load"
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        SelectCharacter_Panel_g = SelectCharacter_Panel.CreateGraphics
        GameMenu_Panel_g = GameMenu_Panel.CreateGraphics
        Game_Panel_g = Game_Panel.CreateGraphics
        chaPB.Add(Select1) : chaPB.Add(Select2) : chaPB.Add(Select3) : chaPB.Add(Select4)
        characters.Add(YC1) : characters.Add(YC2) : characters.Add(YC3) : characters.Add(PH)
        BackMusic.settings.autoStart = True
        BackMusic.uiMode = "Invisible"
        BackMusic.settings.volume = 100
        add_music("星爆模擬器-道具欄BGM.mp3")
        add_music("神魔之塔-BattleBGM.mp3")
        score_label(0) = player1Score
        score_label(1) = player2Score
        skill_label(0) = Skill_Label1
        skill_label(1) = Skill_Label2
        skillPoint_label(0) = SkillPoint_Label1
        skillPoint_label(1) = SkillPoint_Label2
        Rect(0) = New Rectangle
        Rect(1) = New Rectangle
#Region "lineRect()初始化"
        lineRect(0) = New Rectangle
        lineRect(1) = New Rectangle
        lineRect(2) = New Rectangle
        lineRect(3) = New Rectangle
        lineRect(0).Location = New Point(0, 85)
        lineRect(1).Location = New Point(0, Game_Panel.Height - 2)
        lineRect(2).Location = New Point(0, 85)
        lineRect(3).Location = New Point(Game_Panel.Width - 2, 85)
        lineRect(0).Size = New Size(Game_Panel.Width, 2)
        lineRect(1).Size = New Size(Game_Panel.Width, 2)
        lineRect(2).Size = New Size(2, Game_Panel.Height - 85)
        lineRect(3).Size = New Size(2, Game_Panel.Height - 85)
#End Region
        For i As Integer = 0 To myRect.Length - 1
            myRect(i) = New Rectangle
        Next
        startingSet()
        RadioButton1.Checked = True
#Region "Panel初始化位置"
        SelectCharacter_Panel.Location = New Point(0, 0)
        Game_Panel.Location = New Point(0, 0)
        Help_Panel.Location = New Point(0, 0)
        Setting_Panel.Location = New Point(0, 0)
        GameMenu_Panel.Location = New Point(0, 0)
#End Region
        setDot(50)
    End Sub
#End Region

#Region "Select_Picturebox事件_方法"
    Private Sub Select1_Click(sender As Object, e As EventArgs) Handles Select1.Click
        selectCharacter(0)
    End Sub

    Private Sub Select2_Click(sender As Object, e As EventArgs) Handles Select2.Click
        selectCharacter(1)
    End Sub

    Private Sub Select3_Click(sender As Object, e As EventArgs) Handles Select3.Click
        selectCharacter(2)
    End Sub

    Private Sub Select4_Click(sender As Object, e As EventArgs) Handles Select4.Click
        selectCharacter(3)
    End Sub

    Sub selectCharacter(ByVal character As Integer)
        If Selected1.Image Is Nothing Then
            Button1.Enabled = True
        ElseIf Not (Selected1.Image Is Nothing) AndAlso Button1.Enabled = False AndAlso Start.Enabled = False Then
            Button2.Enabled = True
        End If
        If Button1.Enabled Then
            Selected1.Image = chaPB(character).Image
            Directions1.Text = characters(character).directions
            player(0) = character
        ElseIf Button2.Enabled Then
            Selected2.Image = chaPB(character).Image
            Directions2.Text = characters(character).directions
            player(1) = character
        End If
    End Sub
#End Region

#Region "BackMusic事件_方法"
    Private Sub RB_CheckedChanged()
        For i As Integer = 0 To RB.Count - 1
            If RB(i).Checked Then
                BackMusic.URL = music_path_ary(i)
                BackMusic.Ctlcontrols.play()
                Exit For
            End If
        Next
        If RadioButton1.Checked Then
            BackMusic.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub BackMusic_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles BackMusic.PlayStateChange
        If RadioButton1.Checked = False Then
            Try
                BackMusic.Ctlcontrols.play()
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        End If
    End Sub

    Sub add_music(ByVal s As String)
        music_path_ary.Add(music_path & s)
        RB.Add(New RadioButton)
        With RB(RB.Count - 1)
            .AutoSize = False
            .Size = New Size(300, 30)
            .Location = New Point(25, 150 + RB.Count * 25)
            .Text = s.Substring(0, s.Length - 4)
            .BackColor = Color.Transparent
            .Font = New Font("微軟正黑體", 12.0!, FontStyle.Regular)
        End With
        Setting_Panel.Controls.Add(RB(RB.Count - 1))
        AddHandler RB(RB.Count - 1).CheckedChanged, AddressOf RB_CheckedChanged
    End Sub
#End Region

#Region "Button_Click事件"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Label3.Text = "Player2選擇"
        chaPB(player(0)).Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Start.Enabled = True
    End Sub

    Private Sub EnterGame_Button_Click(sender As Object, e As EventArgs) Handles EnterGame_Button.Click
        SelectCharacter_Panel.Visible = True
        GameMenu_Panel.Visible = False
    End Sub

    Private Sub Help_Button_Click(sender As Object, e As EventArgs) Handles Help_Button.Click
        Help_Panel.Visible = True
        GameMenu_Panel.Visible = False
    End Sub

    Private Sub Setting_Button_Click(sender As Object, e As EventArgs) Handles Setting_Button.Click
        Setting_Panel.Visible = True
        GameMenu_Panel.Visible = False
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Close()
    End Sub

    Private Sub HelpBackToMenu_Button_Click(sender As Object, e As EventArgs) Handles HelpBackToMenu_Button.Click
        GameMenu_Panel.Visible = True
        Help_Panel.Visible = False
    End Sub

    Private Sub SettingBackToMenu_Button_Click(sender As Object, e As EventArgs) Handles SettingBackToMenu_Button.Click
        GameMenu_Panel.Visible = True
        Setting_Panel.Visible = False
    End Sub

    Private Sub SelectBackToMenu_Button_Click(sender As Object, e As EventArgs) Handles SelectBackToMenu_Button.Click
        GameMenu_Panel.Visible = True
        SelectCharacter_Panel.Visible = False
        startingSet()
        Start.Enabled = False
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        SelectBackToMenu_Button.Enabled = False
        Start.Enabled = False
        Game_Panel.Visible = True
        SelectCharacter_Panel.Visible = False
        Player1Character.Image = Selected1.Image
        Player2Character.Image = Selected2.Image
        setPlayerStartingSize()
        player1_speed.Interval = characters(player(0)).speed
        player2_speed.Interval = characters(player(1)).speed
        player1_speed.Enabled = True
        player2_speed.Enabled = True
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        player1_speed.Enabled = False
        player2_speed.Enabled = False
        startingSet()
    End Sub
#End Region

#Region "Timer_Tick事件"
    Private Sub player1_speed_Tick(sender As Object, e As EventArgs) Handles player1_speed.Tick
        Select Case lastCode(0)
            Case keyCode(0, 0)
                Player1Character.Top -= 18
            Case keyCode(0, 1)
                Player1Character.Top += 18
            Case keyCode(0, 2)
                Player1Character.Left -= 18
            Case keyCode(0, 3)
                Player1Character.Left += 18
        End Select
    End Sub

    Private Sub player2_speed_Tick(sender As Object, e As EventArgs) Handles player2_speed.Tick
        Select Case lastCode(1)
            Case keyCode(1, 0)
                Player2Character.Top -= 18
            Case keyCode(1, 1)
                Player2Character.Top += 18
            Case keyCode(1, 2)
                Player2Character.Left -= 18
            Case keyCode(1, 3)
                Player2Character.Left += 18
        End Select
    End Sub
#End Region

#Region "Paint事件"
    Private Sub SelectCharacter_Panel_Paint(sender As Object, e As PaintEventArgs) Handles SelectCharacter_Panel.Paint
        SelectCharacter_Panel_g.DrawImage(My.Resources.漢堡, 985, 165, 150, 150)
        SelectCharacter_Panel_g.DrawImage(My.Resources.漢堡, 785, 665, 120, 120)
        SelectCharacter_Panel_g.DrawImage(My.Resources.漢堡, 230, 625, 130, 130)
        SelectCharacter_Panel_g.DrawImage(My.Resources.漢堡, 100, 260, 100, 100)
        SelectCharacter_Panel_g.DrawImage(My.Resources.亞戰大冒險, 235, 20, 695, 175)
    End Sub

    Private Sub GameMenu_Panel_Paint(sender As Object, e As PaintEventArgs) Handles GameMenu_Panel.Paint
        GameMenu_Panel_g.DrawImage(My.Resources.漢堡, 985, 165, 150, 150)
        GameMenu_Panel_g.DrawImage(My.Resources.漢堡, 785, 665, 120, 120)
        GameMenu_Panel_g.DrawImage(My.Resources.漢堡, 230, 625, 130, 130)
        GameMenu_Panel_g.DrawImage(My.Resources.漢堡, 100, 260, 100, 100)
        GameMenu_Panel_g.DrawImage(My.Resources.亞戰大冒險, 235, 20, 695, 175)
    End Sub

    Private Sub Game_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Game_Panel.Paint
        Game_Panel_g.FillRectangle(Brushes.Red, lineRect(0))
        Game_Panel_g.FillRectangle(Brushes.Red, lineRect(1))
        Game_Panel_g.FillRectangle(Brushes.Red, lineRect(2))
        Game_Panel_g.FillRectangle(Brushes.Red, lineRect(3))
    End Sub
#End Region

#Region "Location_Size_Changed事件"
    Private Sub Player1Character_LocationChanged(sender As Object, e As EventArgs) Handles Player1Character.LocationChanged
        Rect(0).Location = New Point(Player1Character.Location)
        ifPlayerIntersectsWithLine(0)
        Select Case player(0)
            Case 0
                Try
                    If characters(0).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(0, 5)
                    Else
                        ifPlayerIntersectsWithDot(0, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 1
                ifPlayerIntersectsWithDot(0, 1 + 2 * characters(1).useSkillTimes)
            Case 2
                Try
                    If characters(2).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(0, 3)
                    Else
                        ifPlayerIntersectsWithDot(0, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 3
                ifPlayerIntersectsWithDot(0, 1)
        End Select
    End Sub

    Private Sub Player2Character_LocationChanged(sender As Object, e As EventArgs) Handles Player2Character.LocationChanged
        Rect(1).Location = New Point(Player2Character.Location)
        ifPlayerIntersectsWithLine(1)
        Select Case player(1)
            Case 0
                Try
                    If characters(0).isUsingSkill Then
                        ifPlayerIntersectsWithDot(1, 5)
                    Else
                        ifPlayerIntersectsWithDot(1, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 1
                ifPlayerIntersectsWithDot(1, 1 + 2 * characters(1).useSkillTimes)
            Case 2
                Try
                    If characters(2).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(1, 3)
                    Else
                        ifPlayerIntersectsWithDot(1, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 3
                ifPlayerIntersectsWithDot(1, 1)
        End Select
    End Sub

    Private Sub Player1Character_SizeChanged(sender As Object, e As EventArgs) Handles Player1Character.SizeChanged
        Rect(0).Size = New Size(Player1Character.Size)
        ifPlayerIntersectsWithLine(0)
        Select Case player(0)
            Case 0
                Try
                    If characters(0).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(0, 5)
                    Else
                        ifPlayerIntersectsWithDot(0, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 1
                ifPlayerIntersectsWithDot(0, 1 + 2 * characters(1).useSkillTimes)
            Case 2
                Try
                    If characters(2).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(0, 3)
                    Else
                        ifPlayerIntersectsWithDot(0, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 3
                ifPlayerIntersectsWithDot(0, 1)
        End Select
    End Sub

    Private Sub Player2Character_SizeChanged(sender As Object, e As EventArgs) Handles Player2Character.SizeChanged
        Rect(1).Size = New Size(Player2Character.Size)
        ifPlayerIntersectsWithLine(1)
        Select Case player(1)
            Case 0
                Try
                    If characters(0).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(1, 5)
                    Else
                        ifPlayerIntersectsWithDot(1, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 1
                ifPlayerIntersectsWithDot(1, 1 + 2 * characters(1).useSkillTimes)
            Case 2
                Try
                    If characters(2).isUsingSkill = True Then
                        ifPlayerIntersectsWithDot(1, 3)
                    Else
                        ifPlayerIntersectsWithDot(1, 1)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Case 3
                ifPlayerIntersectsWithDot(1, 1)
        End Select
    End Sub
#End Region

#Region "Sub_Function"
    Private Sub Game_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.W, Keys.S, Keys.A, Keys.D
                lastCode(0) = e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Left, Keys.Right
                lastCode(1) = e.KeyCode
            Case Keys.Space
                If canUseSkill(0) Then
                    canUseSkill(0) = False
                    add_skillPoint(0, -skillPoint(0))
                    characters(player(0)).skill()
                End If
            Case Keys.Enter
                If canUseSkill(1) Then
                    canUseSkill(1) = False
                    add_skillPoint(1, -skillPoint(1))
                    characters(player(1)).skill()
                End If
        End Select
    End Sub

    Sub setDot(ByVal amount As Integer)
        For i As Integer = 0 To amount - 1
            Dim Rect As New Rectangle
            dotPB.Add(New PictureBox)
            With dotPB(i)
                .Location = randomPoint()
                .Size = New Size(4, 4)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .Image = My.Resources.點
                .Visible = True
            End With
            Game_Panel.Controls.Add(dotPB(i))
            myRect(i).Location = New Point(dotPB(i).Location)
            myRect(i).Size = New Size(dotPB(i).Size)
        Next
    End Sub

    Sub setPlayerStartingSize()
        Select Case player(0)
            Case 0
                Player1Character.Size = YC1.size
            Case 1
                Player1Character.Size = YC2.size
            Case 2
                Player1Character.Size = YC3.size
            Case 3
                Player1Character.Size = PH.size
        End Select
        Select Case player(1)
            Case 0
                Player2Character.Size = YC1.size
            Case 1
                Player2Character.Size = YC2.size
            Case 2
                Player2Character.Size = YC3.size
            Case 3
                Player2Character.Size = PH.size
        End Select
    End Sub

    Sub startingSet()
        For i As Integer = 0 To 1
            score(i) = 0
            score_label(i).Text = score(i)
            lastCode(i) = keyCode(i, 1)
            canUseSkill(i) = False
            skillPoint(i) = 0
            add_skillPoint(i, -skillPoint(i))
        Next
        Label3.Text = "Player1選擇"
        GameMenu_Panel.Parent = Me
        Help_Panel.Parent = Me
        SelectCharacter_Panel.Parent = Me
        Game_Panel.Parent = Me
        Setting_Panel.Parent = Me
        GameMenu_Panel.Visible = True
        Help_Panel.Visible = False
        SelectCharacter_Panel.Visible = False
        Game_Panel.Visible = False
        Setting_Panel.Visible = False
        SelectBackToMenu_Button.Enabled = True
        Player1Character.Location = New Point(140, 88)
        Player2Character.Location = New Point(960, 88)
        Selected1.Image = Nothing
        Selected2.Image = Nothing
        Directions1.Text = ""
        Directions2.Text = ""
        For i As Integer = 0 To chaPB.Count - 1
            chaPB(i).Enabled = True
            characters(i).reset()
        Next
    End Sub

    Sub ifPlayerIntersectsWithDot(ByVal player As Integer, ByVal addScore As Integer)
        For i As Integer = 0 To myRect.Count - 1
            If Rect(player).IntersectsWith(myRect(i)) Then
                add_score(player, addScore)
                add_skillPoint(player, 1)
                dotPB(i).Location = randomPoint()
                myRect(i).Location = New Point(dotPB(i).Location)
            End If
        Next
    End Sub

    Sub ifPlayerIntersectsWithLine(ByVal player As Integer)
        For i As Integer = 0 To lineRect.Length - 1
            If Rect(player).IntersectsWith(lineRect(i)) Then
                player1_speed.Enabled = False
                player2_speed.Enabled = False
                If player = 0 Then
                    MsgBox("player2 Win")
                Else
                    MsgBox("player1 Win")
                End If
                startingSet()
            End If
        Next
    End Sub

    Sub add_score(ByVal player As Integer, ByVal score As Integer)
        Me.score(player) += score
        score_label(player).Text = Me.score(player)
        ifEnd()
    End Sub

    Sub add_skillPoint(ByVal player As Integer, ByVal point As Integer)
        skillPoint(player) += point
        If skillPoint(player) >= 20 Then
            skillPoint_label(player).Text = 20
            canUseSkill(player) = True
        Else
            skillPoint_label(player).Text = skillPoint(player)
        End If
        Skill_Label_Text_Color(player)
    End Sub

    Sub Skill_Label_Text_Color(ByVal player As Integer)
        If canUseSkill(player) = False Then
            skill_label(player).Text = "N"
            skill_label(player).ForeColor = Color.FromArgb(230, 30, 30)
        Else
            skill_label(player).Text = "Y"
            skill_label(player).ForeColor = Color.FromArgb(30, 230, 30)
        End If
    End Sub

    Sub ifEnd()
        For i As Integer = 0 To player.Length - 1
            If score(i) >= 100 Then
                player1_speed.Enabled = False
                player2_speed.Enabled = False
                MsgBox("player" & i + 1 & " Win")
                startingSet()
                Exit For
            End If
        Next
    End Sub

    Function isEnd()
        Dim boo As Boolean = False
        For i As Integer = 0 To player.Length - 1
            If score(i) >= 100 Then
                boo = True
                Exit For
            End If
        Next
        Return boo
    End Function

    Function randomPoint()
        Dim x, y As Integer
        Dim p As Point
        x = rnd.Next(0, Game_Panel.Width + 1 - 4 - 2)
        y = rnd.Next(88, Game_Panel.Height + 1 - 4 - 2)
        p = New Point(x, y)
        Return p
    End Function
#End Region

End Class
