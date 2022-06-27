Public Class YaChan1
    Implements Characters.Characters
    Private tempSize As Size
    Private tempSpeed As Integer
    Dim skillTimer As New Timer
    Public isUsingSkill As Boolean

    Public ReadOnly Property directions As String Implements Characters.Characters.directions
        Get
            directions = "屬性：" & vbCrLf & "  Size:(80,80)" & vbCrLf & "  Speed:" & speed & vbCrLf &
                         "技能：" & vbCrLf & "  3秒內Size*3/4、速度    -30、得分*5"
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
        isUsingSkill = True
        tempSize = New Size(60, 60)
        tempSpeed += 30
        skillTimer.Interval = 3000
        skillTimer.Enabled = True
        AddHandler skillTimer.Tick, AddressOf skillTimer_Tick
        If Game.player(0) = 0 Then
            Game.Player1Character.Size = New Size(tempSize)
            Game.player1_speed.Interval = tempSpeed
        Else
            Game.Player2Character.Size = New Size(tempSize)
            Game.player2_speed.Interval = tempSpeed
        End If
    End Sub

    Sub reset() Implements Characters.Characters.reset
        tempSize = New Size(80, 80)
        tempSpeed = 55
        isUsingSkill = False
    End Sub

    Sub skillTimer_Tick()
        isUsingSkill = False
        skillTimer.Enabled = False
        tempSize = New Size(80, 80)
        tempSpeed = 55
        If Game.isEnd() = False Then
            If Game.player(0) = 0 Then
                Game.Player1Character.Size = New Size(tempSize)
                Game.player1_speed.Interval = tempSpeed
            Else
                Game.Player2Character.Size = New Size(tempSize)
                Game.player2_speed.Interval = tempSpeed
            End If
        End If
    End Sub
End Class
