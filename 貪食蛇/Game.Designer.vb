<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.player1_speed = New System.Windows.Forms.Timer(Me.components)
        Me.player2_speed = New System.Windows.Forms.Timer(Me.components)
        Me.Game_Panel = New System.Windows.Forms.Panel()
        Me.SkillPoint_Label2 = New System.Windows.Forms.Label()
        Me.SkillPoint_Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Skill_Label2 = New System.Windows.Forms.Label()
        Me.Skill_Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Restart = New System.Windows.Forms.Button()
        Me.Player2Character = New System.Windows.Forms.PictureBox()
        Me.Player1Character = New System.Windows.Forms.PictureBox()
        Me.player2Score = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.player1Score = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectCharacter_Panel = New System.Windows.Forms.Panel()
        Me.SelectBackToMenu_Button = New System.Windows.Forms.Button()
        Me.Directions2 = New System.Windows.Forms.Label()
        Me.Directions1 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Select4 = New System.Windows.Forms.PictureBox()
        Me.Select3 = New System.Windows.Forms.PictureBox()
        Me.Select2 = New System.Windows.Forms.PictureBox()
        Me.Select1 = New System.Windows.Forms.PictureBox()
        Me.Selected2 = New System.Windows.Forms.PictureBox()
        Me.Selected1 = New System.Windows.Forms.PictureBox()
        Me.GameMenu_Panel = New System.Windows.Forms.Panel()
        Me.Setting_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.EnterGame_Button = New System.Windows.Forms.Button()
        Me.Help_Button = New System.Windows.Forms.Button()
        Me.Help_Panel = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HelpBackToMenu_Button = New System.Windows.Forms.Button()
        Me.Setting_Panel = New System.Windows.Forms.Panel()
        Me.BackMusic = New AxWMPLib.AxWindowsMediaPlayer()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SettingBackToMenu_Button = New System.Windows.Forms.Button()
        Me.Game_Panel.SuspendLayout()
        CType(Me.Player2Character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1Character, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectCharacter_Panel.SuspendLayout()
        CType(Me.Select4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Selected2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Selected1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GameMenu_Panel.SuspendLayout()
        Me.Help_Panel.SuspendLayout()
        Me.Setting_Panel.SuspendLayout()
        CType(Me.BackMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player1_speed
        '
        Me.player1_speed.Interval = 200
        '
        'player2_speed
        '
        Me.player2_speed.Interval = 200
        '
        'Game_Panel
        '
        Me.Game_Panel.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.Game_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Game_Panel.Controls.Add(Me.SkillPoint_Label2)
        Me.Game_Panel.Controls.Add(Me.SkillPoint_Label1)
        Me.Game_Panel.Controls.Add(Me.Label7)
        Me.Game_Panel.Controls.Add(Me.Label6)
        Me.Game_Panel.Controls.Add(Me.Skill_Label2)
        Me.Game_Panel.Controls.Add(Me.Skill_Label1)
        Me.Game_Panel.Controls.Add(Me.Label5)
        Me.Game_Panel.Controls.Add(Me.Label4)
        Me.Game_Panel.Controls.Add(Me.Restart)
        Me.Game_Panel.Controls.Add(Me.Player2Character)
        Me.Game_Panel.Controls.Add(Me.Player1Character)
        Me.Game_Panel.Controls.Add(Me.player2Score)
        Me.Game_Panel.Controls.Add(Me.Label2)
        Me.Game_Panel.Controls.Add(Me.player1Score)
        Me.Game_Panel.Controls.Add(Me.Label1)
        Me.Game_Panel.Location = New System.Drawing.Point(2, 2)
        Me.Game_Panel.Name = "Game_Panel"
        Me.Game_Panel.Size = New System.Drawing.Size(1200, 800)
        Me.Game_Panel.TabIndex = 177
        Me.Game_Panel.Visible = False
        '
        'SkillPoint_Label2
        '
        Me.SkillPoint_Label2.AutoSize = True
        Me.SkillPoint_Label2.BackColor = System.Drawing.Color.Transparent
        Me.SkillPoint_Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SkillPoint_Label2.Location = New System.Drawing.Point(1158, 43)
        Me.SkillPoint_Label2.Name = "SkillPoint_Label2"
        Me.SkillPoint_Label2.Size = New System.Drawing.Size(18, 20)
        Me.SkillPoint_Label2.TabIndex = 220
        Me.SkillPoint_Label2.Text = "0"
        '
        'SkillPoint_Label1
        '
        Me.SkillPoint_Label1.AutoSize = True
        Me.SkillPoint_Label1.BackColor = System.Drawing.Color.Transparent
        Me.SkillPoint_Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SkillPoint_Label1.Location = New System.Drawing.Point(90, 44)
        Me.SkillPoint_Label1.Name = "SkillPoint_Label1"
        Me.SkillPoint_Label1.Size = New System.Drawing.Size(18, 20)
        Me.SkillPoint_Label1.TabIndex = 219
        Me.SkillPoint_Label1.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(1081, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 218
        Me.Label7.Text = "SkillPoint:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 217
        Me.Label6.Text = "SkillPoint:"
        '
        'Skill_Label2
        '
        Me.Skill_Label2.AutoSize = True
        Me.Skill_Label2.BackColor = System.Drawing.Color.Transparent
        Me.Skill_Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Skill_Label2.Location = New System.Drawing.Point(1121, 64)
        Me.Skill_Label2.Name = "Skill_Label2"
        Me.Skill_Label2.Size = New System.Drawing.Size(22, 20)
        Me.Skill_Label2.TabIndex = 216
        Me.Skill_Label2.Text = "N"
        '
        'Skill_Label1
        '
        Me.Skill_Label1.AutoSize = True
        Me.Skill_Label1.BackColor = System.Drawing.Color.Transparent
        Me.Skill_Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Skill_Label1.Location = New System.Drawing.Point(52, 64)
        Me.Skill_Label1.Name = "Skill_Label1"
        Me.Skill_Label1.Size = New System.Drawing.Size(22, 20)
        Me.Skill_Label1.TabIndex = 215
        Me.Skill_Label1.Text = "N"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(1081, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Skill:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Skill:"
        '
        'Restart
        '
        Me.Restart.BackColor = System.Drawing.Color.Transparent
        Me.Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Restart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Restart.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Restart.Location = New System.Drawing.Point(565, 21)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(75, 42)
        Me.Restart.TabIndex = 212
        Me.Restart.Text = "重來"
        Me.Restart.UseVisualStyleBackColor = False
        '
        'Player2Character
        '
        Me.Player2Character.BackColor = System.Drawing.Color.Transparent
        Me.Player2Character.Location = New System.Drawing.Point(960, 0)
        Me.Player2Character.Name = "Player2Character"
        Me.Player2Character.Size = New System.Drawing.Size(80, 85)
        Me.Player2Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2Character.TabIndex = 211
        Me.Player2Character.TabStop = False
        '
        'Player1Character
        '
        Me.Player1Character.BackColor = System.Drawing.Color.Transparent
        Me.Player1Character.Location = New System.Drawing.Point(140, 0)
        Me.Player1Character.Name = "Player1Character"
        Me.Player1Character.Size = New System.Drawing.Size(80, 85)
        Me.Player1Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1Character.TabIndex = 210
        Me.Player1Character.TabStop = False
        '
        'player2Score
        '
        Me.player2Score.AutoSize = True
        Me.player2Score.BackColor = System.Drawing.Color.Transparent
        Me.player2Score.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.player2Score.Location = New System.Drawing.Point(1145, 21)
        Me.player2Score.Name = "player2Score"
        Me.player2Score.Size = New System.Drawing.Size(18, 20)
        Me.player2Score.TabIndex = 194
        Me.player2Score.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(1081, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "Player2:"
        '
        'player1Score
        '
        Me.player1Score.AutoSize = True
        Me.player1Score.BackColor = System.Drawing.Color.Transparent
        Me.player1Score.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.player1Score.Location = New System.Drawing.Point(77, 21)
        Me.player1Score.Name = "player1Score"
        Me.player1Score.Size = New System.Drawing.Size(18, 20)
        Me.player1Score.TabIndex = 192
        Me.player1Score.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Player1:"
        '
        'SelectCharacter_Panel
        '
        Me.SelectCharacter_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.SelectCharacter_Panel.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.SelectCharacter_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SelectCharacter_Panel.Controls.Add(Me.SelectBackToMenu_Button)
        Me.SelectCharacter_Panel.Controls.Add(Me.Directions2)
        Me.SelectCharacter_Panel.Controls.Add(Me.Directions1)
        Me.SelectCharacter_Panel.Controls.Add(Me.Start)
        Me.SelectCharacter_Panel.Controls.Add(Me.Button2)
        Me.SelectCharacter_Panel.Controls.Add(Me.Button1)
        Me.SelectCharacter_Panel.Controls.Add(Me.Label3)
        Me.SelectCharacter_Panel.Controls.Add(Me.Select4)
        Me.SelectCharacter_Panel.Controls.Add(Me.Select3)
        Me.SelectCharacter_Panel.Controls.Add(Me.Select2)
        Me.SelectCharacter_Panel.Controls.Add(Me.Select1)
        Me.SelectCharacter_Panel.Controls.Add(Me.Selected2)
        Me.SelectCharacter_Panel.Controls.Add(Me.Selected1)
        Me.SelectCharacter_Panel.Location = New System.Drawing.Point(2, 2)
        Me.SelectCharacter_Panel.Name = "SelectCharacter_Panel"
        Me.SelectCharacter_Panel.Size = New System.Drawing.Size(1200, 800)
        Me.SelectCharacter_Panel.TabIndex = 176
        '
        'SelectBackToMenu_Button
        '
        Me.SelectBackToMenu_Button.BackColor = System.Drawing.Color.Transparent
        Me.SelectBackToMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectBackToMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SelectBackToMenu_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SelectBackToMenu_Button.Location = New System.Drawing.Point(20, 25)
        Me.SelectBackToMenu_Button.Name = "SelectBackToMenu_Button"
        Me.SelectBackToMenu_Button.Size = New System.Drawing.Size(135, 54)
        Me.SelectBackToMenu_Button.TabIndex = 201
        Me.SelectBackToMenu_Button.Text = "返回"
        Me.SelectBackToMenu_Button.UseVisualStyleBackColor = False
        '
        'Directions2
        '
        Me.Directions2.BackColor = System.Drawing.Color.Transparent
        Me.Directions2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Directions2.Location = New System.Drawing.Point(776, 415)
        Me.Directions2.Name = "Directions2"
        Me.Directions2.Size = New System.Drawing.Size(281, 198)
        Me.Directions2.TabIndex = 200
        '
        'Directions1
        '
        Me.Directions1.BackColor = System.Drawing.Color.Transparent
        Me.Directions1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Directions1.Location = New System.Drawing.Point(93, 415)
        Me.Directions1.Name = "Directions1"
        Me.Directions1.Size = New System.Drawing.Size(281, 198)
        Me.Directions1.TabIndex = 199
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start.Enabled = False
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Start.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Start.Location = New System.Drawing.Point(477, 606)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(203, 55)
        Me.Start.TabIndex = 198
        Me.Start.Text = "開始"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(784, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 197
        Me.Button2.Text = "選擇"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(294, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 196
        Me.Button1.Text = "選擇"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(490, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 36)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Player1選擇"
        '
        'Select4
        '
        Me.Select4.Image = Global.YaChanBattle.My.Resources.Resources.柏宏
        Me.Select4.Location = New System.Drawing.Point(600, 470)
        Me.Select4.Name = "Select4"
        Me.Select4.Size = New System.Drawing.Size(80, 85)
        Me.Select4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Select4.TabIndex = 194
        Me.Select4.TabStop = False
        '
        'Select3
        '
        Me.Select3.Image = Global.YaChanBattle.My.Resources.Resources.亞戰3
        Me.Select3.Location = New System.Drawing.Point(477, 470)
        Me.Select3.Name = "Select3"
        Me.Select3.Size = New System.Drawing.Size(80, 85)
        Me.Select3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Select3.TabIndex = 193
        Me.Select3.TabStop = False
        '
        'Select2
        '
        Me.Select2.Image = Global.YaChanBattle.My.Resources.Resources.亞戰2
        Me.Select2.Location = New System.Drawing.Point(600, 348)
        Me.Select2.Name = "Select2"
        Me.Select2.Size = New System.Drawing.Size(80, 85)
        Me.Select2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Select2.TabIndex = 192
        Me.Select2.TabStop = False
        '
        'Select1
        '
        Me.Select1.Image = Global.YaChanBattle.My.Resources.Resources.亞戰1
        Me.Select1.Location = New System.Drawing.Point(477, 348)
        Me.Select1.Name = "Select1"
        Me.Select1.Size = New System.Drawing.Size(80, 85)
        Me.Select1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Select1.TabIndex = 191
        Me.Select1.TabStop = False
        '
        'Selected2
        '
        Me.Selected2.BackColor = System.Drawing.Color.Transparent
        Me.Selected2.Location = New System.Drawing.Point(784, 196)
        Me.Selected2.Name = "Selected2"
        Me.Selected2.Size = New System.Drawing.Size(80, 85)
        Me.Selected2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Selected2.TabIndex = 190
        Me.Selected2.TabStop = False
        '
        'Selected1
        '
        Me.Selected1.BackColor = System.Drawing.Color.Transparent
        Me.Selected1.Location = New System.Drawing.Point(294, 196)
        Me.Selected1.Name = "Selected1"
        Me.Selected1.Size = New System.Drawing.Size(80, 85)
        Me.Selected1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Selected1.TabIndex = 189
        Me.Selected1.TabStop = False
        '
        'GameMenu_Panel
        '
        Me.GameMenu_Panel.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.GameMenu_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameMenu_Panel.Controls.Add(Me.Setting_Button)
        Me.GameMenu_Panel.Controls.Add(Me.Exit_Button)
        Me.GameMenu_Panel.Controls.Add(Me.EnterGame_Button)
        Me.GameMenu_Panel.Controls.Add(Me.Help_Button)
        Me.GameMenu_Panel.Location = New System.Drawing.Point(0, 0)
        Me.GameMenu_Panel.Name = "GameMenu_Panel"
        Me.GameMenu_Panel.Size = New System.Drawing.Size(1200, 800)
        Me.GameMenu_Panel.TabIndex = 221
        '
        'Setting_Button
        '
        Me.Setting_Button.BackColor = System.Drawing.Color.Transparent
        Me.Setting_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setting_Button.FlatAppearance.BorderSize = 0
        Me.Setting_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Setting_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Setting_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Setting_Button.Location = New System.Drawing.Point(505, 503)
        Me.Setting_Button.Name = "Setting_Button"
        Me.Setting_Button.Size = New System.Drawing.Size(135, 54)
        Me.Setting_Button.TabIndex = 3
        Me.Setting_Button.Text = "設定"
        Me.Setting_Button.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Transparent
        Me.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exit_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(505, 589)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(135, 54)
        Me.Exit_Button.TabIndex = 2
        Me.Exit_Button.Text = "離開"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'EnterGame_Button
        '
        Me.EnterGame_Button.BackColor = System.Drawing.Color.Transparent
        Me.EnterGame_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnterGame_Button.FlatAppearance.BorderSize = 0
        Me.EnterGame_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EnterGame_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EnterGame_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EnterGame_Button.Location = New System.Drawing.Point(505, 330)
        Me.EnterGame_Button.Name = "EnterGame_Button"
        Me.EnterGame_Button.Size = New System.Drawing.Size(135, 54)
        Me.EnterGame_Button.TabIndex = 1
        Me.EnterGame_Button.Text = "進入遊戲"
        Me.EnterGame_Button.UseVisualStyleBackColor = False
        '
        'Help_Button
        '
        Me.Help_Button.BackColor = System.Drawing.Color.Transparent
        Me.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Help_Button.FlatAppearance.BorderSize = 0
        Me.Help_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Help_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Help_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Help_Button.Location = New System.Drawing.Point(505, 417)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(135, 54)
        Me.Help_Button.TabIndex = 0
        Me.Help_Button.Text = "幫助"
        Me.Help_Button.UseVisualStyleBackColor = False
        '
        'Help_Panel
        '
        Me.Help_Panel.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.Help_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Help_Panel.Controls.Add(Me.Label18)
        Me.Help_Panel.Controls.Add(Me.Label17)
        Me.Help_Panel.Controls.Add(Me.Label16)
        Me.Help_Panel.Controls.Add(Me.Label15)
        Me.Help_Panel.Controls.Add(Me.Label14)
        Me.Help_Panel.Controls.Add(Me.Label13)
        Me.Help_Panel.Controls.Add(Me.Label12)
        Me.Help_Panel.Controls.Add(Me.Label11)
        Me.Help_Panel.Controls.Add(Me.Label10)
        Me.Help_Panel.Controls.Add(Me.Label9)
        Me.Help_Panel.Controls.Add(Me.HelpBackToMenu_Button)
        Me.Help_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Help_Panel.Name = "Help_Panel"
        Me.Help_Panel.Size = New System.Drawing.Size(1200, 800)
        Me.Help_Panel.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.Location = New System.Drawing.Point(179, 446)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 47)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "獲勝條件:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(284, 511)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 70)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "先得100分者獲勝或對手碰到紅線" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(729, 571)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 47)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Player2:Enter"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(619, 446)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 47)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "技能施放:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(729, 511)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 47)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Player1:Space"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(729, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(292, 77)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "吃一個點+1，上限20，20點時可放技能"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(619, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 58)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "技能點:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(284, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(255, 34)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Player1: W  A   S   D"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(284, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 34)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Player2: ↑ ←  ↓   →"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(179, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 30)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "操控方法:"
        '
        'HelpBackToMenu_Button
        '
        Me.HelpBackToMenu_Button.BackColor = System.Drawing.Color.Transparent
        Me.HelpBackToMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpBackToMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HelpBackToMenu_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.HelpBackToMenu_Button.Location = New System.Drawing.Point(20, 25)
        Me.HelpBackToMenu_Button.Name = "HelpBackToMenu_Button"
        Me.HelpBackToMenu_Button.Size = New System.Drawing.Size(135, 54)
        Me.HelpBackToMenu_Button.TabIndex = 2
        Me.HelpBackToMenu_Button.Text = "返回"
        Me.HelpBackToMenu_Button.UseVisualStyleBackColor = False
        '
        'Setting_Panel
        '
        Me.Setting_Panel.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.Setting_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Setting_Panel.Controls.Add(Me.BackMusic)
        Me.Setting_Panel.Controls.Add(Me.RadioButton1)
        Me.Setting_Panel.Controls.Add(Me.Label8)
        Me.Setting_Panel.Controls.Add(Me.SettingBackToMenu_Button)
        Me.Setting_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Setting_Panel.Name = "Setting_Panel"
        Me.Setting_Panel.Size = New System.Drawing.Size(1200, 800)
        Me.Setting_Panel.TabIndex = 4
        '
        'BackMusic
        '
        Me.BackMusic.Enabled = True
        Me.BackMusic.Location = New System.Drawing.Point(459, 743)
        Me.BackMusic.Name = "BackMusic"
        Me.BackMusic.OcxState = CType(resources.GetObject("BackMusic.OcxState"), System.Windows.Forms.AxHost.State)
        Me.BackMusic.Size = New System.Drawing.Size(223, 45)
        Me.BackMusic.TabIndex = 8
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(25, 150)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(300, 30)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "無"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 34)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "背景音樂"
        '
        'SettingBackToMenu_Button
        '
        Me.SettingBackToMenu_Button.BackColor = System.Drawing.Color.Transparent
        Me.SettingBackToMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingBackToMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SettingBackToMenu_Button.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SettingBackToMenu_Button.Location = New System.Drawing.Point(20, 25)
        Me.SettingBackToMenu_Button.Name = "SettingBackToMenu_Button"
        Me.SettingBackToMenu_Button.Size = New System.Drawing.Size(135, 54)
        Me.SettingBackToMenu_Button.TabIndex = 3
        Me.SettingBackToMenu_Button.Text = "返回"
        Me.SettingBackToMenu_Button.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.YaChanBattle.My.Resources.Resources.背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Help_Panel)
        Me.Controls.Add(Me.SelectCharacter_Panel)
        Me.Controls.Add(Me.Setting_Panel)
        Me.Controls.Add(Me.GameMenu_Panel)
        Me.Controls.Add(Me.Game_Panel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Game"
        Me.Text = "Game"
        Me.Game_Panel.ResumeLayout(False)
        Me.Game_Panel.PerformLayout()
        CType(Me.Player2Character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1Character, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectCharacter_Panel.ResumeLayout(False)
        Me.SelectCharacter_Panel.PerformLayout()
        CType(Me.Select4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Selected2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Selected1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GameMenu_Panel.ResumeLayout(False)
        Me.Help_Panel.ResumeLayout(False)
        Me.Setting_Panel.ResumeLayout(False)
        Me.Setting_Panel.PerformLayout()
        CType(Me.BackMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Game_Panel As Panel
    Friend WithEvents Player2Character As PictureBox
    Friend WithEvents Player1Character As PictureBox
    Friend WithEvents player2Score As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents player1Score As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectCharacter_Panel As Panel
    Friend WithEvents Directions2 As Label
    Friend WithEvents Directions1 As Label
    Friend WithEvents Start As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Select4 As PictureBox
    Friend WithEvents Select3 As PictureBox
    Friend WithEvents Select2 As PictureBox
    Friend WithEvents Select1 As PictureBox
    Friend WithEvents Selected2 As PictureBox
    Friend WithEvents Selected1 As PictureBox
    Friend WithEvents player1_speed As Timer
    Friend WithEvents player2_speed As Timer
    Friend WithEvents Restart As Button
    Friend WithEvents Skill_Label2 As Label
    Friend WithEvents Skill_Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SkillPoint_Label2 As Label
    Friend WithEvents SkillPoint_Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GameMenu_Panel As Panel
    Friend WithEvents EnterGame_Button As Button
    Friend WithEvents Help_Button As Button
    Friend WithEvents Help_Panel As Panel
    Friend WithEvents HelpBackToMenu_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Setting_Button As Button
    Friend WithEvents Setting_Panel As Panel
    Friend WithEvents SettingBackToMenu_Button As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents BackMusic As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SelectBackToMenu_Button As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
