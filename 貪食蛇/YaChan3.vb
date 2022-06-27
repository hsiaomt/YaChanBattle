Public Class YaChan3
    Implements Characters.Characters
    Private tempSize As Size
    Private tempSpeed As Integer
    Dim skillTimer As New Timer
    Public isUsingSkill As Boolean

    Public ReadOnly Property directions As String Implements Characters.Characters.directions
        Get
            directions = "屬性：" & vbCrLf & "  Size:(90,90)" & vbCrLf & "  Speed:" & speed & vbCrLf &
                         "技能：" & vbCrLf & "  偷取對手15%分數，對    手技能點+10" & vbCrLf &
                         "  4秒內得分*3"
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
        skillTimer.Interval = 4000
        skillTimer.Enabled = True
        AddHandler skillTimer.Tick, AddressOf skillTimer_Tick
        If Game.player(0) = 2 Then
            Game.add_score(0, Fix(Game.score(1) * 0.15))
            Game.add_score(1, -Fix(Game.score(1) * 0.15))
            Game.add_skillPoint(1, 10)
        Else
            Game.add_score(1, Fix(Game.score(0) * 0.15))
            Game.add_score(0, -Fix(Game.score(0) * 0.15))
            Game.add_skillPoint(0, 10)
        End If
    End Sub

    Sub reset() Implements Characters.Characters.reset
        tempSize = New Size(90, 90)
        tempSpeed = 60
        isUsingSkill = False
    End Sub

    Sub skillTimer_Tick()
        isUsingSkill = False
        skillTimer.Enabled = False
    End Sub
End Class
