Public Class YaChan2
    Implements Characters.Characters
    Private tempSize As Size
    Private tempSpeed As Integer
    Public useSkillTimes As Integer

    Public ReadOnly Property directions As String Implements Characters.Characters.directions
        Get
            directions = "屬性：" & vbCrLf & "  Size:(70,70)" & vbCrLf & "  Speed:" & speed & vbCrLf &
                         "技能：" & vbCrLf & "  長寬各減3、速度+3、    吃點獲得的分數增加" & vbCrLf &
                         "得分倍率：" & vbCrLf & "  1+2*放技能次數"
        End Get
    End Property

    Public Property size As Size Implements Characters.Characters.size
        Get
            Return tempSize
        End Get
        Set(value As Size)
            tempSize = value
        End Set
    End Property

    Public Property speed As Integer Implements Characters.Characters.speed
        Get
            Return tempSpeed
        End Get
        Set(value As Integer)
            tempSpeed = value
        End Set
    End Property

    Sub skill() Implements Characters.Characters.skill
        tempSize = New Size(tempSize.Width - 3, tempSize.Height - 3)
        tempSpeed -= 3
        useSkillTimes += 1
        If Game.player(0) = 1 Then
            Game.Player1Character.Size = New Size(tempSize)
            Game.player1_speed.Interval = tempSpeed
        Else
            Game.Player2Character.Size = New Size(tempSize)
            Game.player2_speed.Interval = tempSpeed
        End If
    End Sub

    Sub reset() Implements Characters.Characters.reset
        tempSize = New Size(70, 70)
        tempSpeed = 50
        useSkillTimes = 0
    End Sub

End Class
