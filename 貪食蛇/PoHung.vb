Public Class PoHung
    Implements Characters.Characters
    Private tempSize As Size
    Private tempSpeed As Integer
    Dim giddyTimer As New Timer

    Public ReadOnly Property directions As String Implements Characters.Characters.directions
        Get
            directions = "屬性：" & vbCrLf & "  Size:(100,100)" & vbCrLf & "  Speed:" & speed & vbCrLf &
                         "技能：" & vbCrLf & "  3秒內暈眩對手且        Size*2，對手技能點     +10"
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
        tempSize = New Size(200, 200)
        giddyTimer.Interval = 3000
        giddyTimer.Enabled = True
        AddHandler giddyTimer.Tick, AddressOf giddyTimer_Tick
        If Game.player(0) = 3 Then
            Game.Player1Character.Size = New Size(tempSize)
            Game.player2_speed.Enabled = False
            Game.add_skillPoint(1, 10)
        Else
            Game.Player2Character.Size = New Size(tempSize)
            Game.player1_speed.Enabled = False
            Game.add_skillPoint(0, 10)
        End If
    End Sub

    Sub reset() Implements Characters.Characters.reset
        tempSize = New Size(100, 100)
        tempSpeed = 70
    End Sub

    Private Sub giddyTimer_Tick()
        giddyTimer.Enabled = False
        tempSize = New Size(100, 100)
        If Game.isEnd() = False Then
            If Game.player(0) = 3 Then
                Game.Player1Character.Size = New Size(tempSize)
                Game.player2_speed.Enabled = True
            Else
                Game.Player2Character.Size = New Size(tempSize)
                Game.player1_speed.Enabled = True
            End If
        End If
    End Sub
End Class
