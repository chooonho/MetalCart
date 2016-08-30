<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.metalcart = New System.Windows.Forms.PictureBox()
        Me.Direction = New System.Windows.Forms.Timer(Me.components)
        Me.jmp = New System.Windows.Forms.Timer(Me.components)
        Me.medicine = New System.Windows.Forms.Timer(Me.components)
        Me.heal = New System.Windows.Forms.Timer(Me.components)
        Me.box = New System.Windows.Forms.Timer(Me.components)
        Me.boom = New System.Windows.Forms.Timer(Me.components)
        Me.lifebar = New System.Windows.Forms.ProgressBar()
        Me.journeybar = New System.Windows.Forms.ProgressBar()
        Me.medic = New System.Windows.Forms.PictureBox()
        Me.enemy = New System.Windows.Forms.Timer(Me.components)
        Me.background = New System.Windows.Forms.PictureBox()
        Me.fly = New System.Windows.Forms.PictureBox()
        Me.cannon = New System.Windows.Forms.PictureBox()
        Me.shot = New System.Windows.Forms.Timer(Me.components)
        Me.nuclear = New System.Windows.Forms.Timer(Me.components)
        Me.robot = New System.Windows.Forms.PictureBox()
        Me.robotlife = New System.Windows.Forms.ProgressBar()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer5 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer6 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.alienlife = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextStageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.metalcart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.medic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cannon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.robot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'metalcart
        '
        Me.metalcart.BackColor = System.Drawing.Color.Transparent
        Me.metalcart.InitialImage = Nothing
        Me.metalcart.Location = New System.Drawing.Point(76, 308)
        Me.metalcart.Name = "metalcart"
        Me.metalcart.Size = New System.Drawing.Size(100, 76)
        Me.metalcart.TabIndex = 0
        Me.metalcart.TabStop = False
        '
        'Direction
        '
        Me.Direction.Interval = 10
        '
        'jmp
        '
        Me.jmp.Interval = 5
        '
        'medicine
        '
        Me.medicine.Interval = 3500
        '
        'heal
        '
        Me.heal.Interval = 1
        '
        'box
        '
        Me.box.Interval = 1
        '
        'boom
        '
        Me.boom.Interval = 10
        '
        'lifebar
        '
        Me.lifebar.Location = New System.Drawing.Point(12, 27)
        Me.lifebar.Name = "lifebar"
        Me.lifebar.Size = New System.Drawing.Size(100, 15)
        Me.lifebar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.lifebar.TabIndex = 3
        '
        'journeybar
        '
        Me.journeybar.Location = New System.Drawing.Point(-1, 460)
        Me.journeybar.Name = "journeybar"
        Me.journeybar.Size = New System.Drawing.Size(948, 10)
        Me.journeybar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.journeybar.TabIndex = 4
        '
        'medic
        '
        Me.medic.BackColor = System.Drawing.Color.Transparent
        Me.medic.Location = New System.Drawing.Point(658, 157)
        Me.medic.Name = "medic"
        Me.medic.Size = New System.Drawing.Size(30, 30)
        Me.medic.TabIndex = 5
        Me.medic.TabStop = False
        '
        'enemy
        '
        Me.enemy.Interval = 10
        '
        'background
        '
        Me.background.BackColor = System.Drawing.SystemColors.Control
        Me.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.background.InitialImage = Nothing
        Me.background.Location = New System.Drawing.Point(-1, -4)
        Me.background.MaximumSize = New System.Drawing.Size(970, 504)
        Me.background.MinimumSize = New System.Drawing.Size(970, 504)
        Me.background.Name = "background"
        Me.background.Size = New System.Drawing.Size(970, 504)
        Me.background.TabIndex = 8
        Me.background.TabStop = False
        '
        'fly
        '
        Me.fly.BackColor = System.Drawing.Color.Transparent
        Me.fly.Location = New System.Drawing.Point(830, 50)
        Me.fly.Name = "fly"
        Me.fly.Size = New System.Drawing.Size(80, 40)
        Me.fly.TabIndex = 10
        Me.fly.TabStop = False
        '
        'cannon
        '
        Me.cannon.BackColor = System.Drawing.Color.Transparent
        Me.cannon.Image = CType(resources.GetObject("cannon.Image"), System.Drawing.Image)
        Me.cannon.Location = New System.Drawing.Point(111, 340)
        Me.cannon.Name = "cannon"
        Me.cannon.Size = New System.Drawing.Size(49, 19)
        Me.cannon.TabIndex = 11
        Me.cannon.TabStop = False
        '
        'shot
        '
        Me.shot.Interval = 1
        '
        'nuclear
        '
        Me.nuclear.Interval = 1
        '
        'robot
        '
        Me.robot.BackColor = System.Drawing.Color.Transparent
        Me.robot.Location = New System.Drawing.Point(628, 308)
        Me.robot.Name = "robot"
        Me.robot.Size = New System.Drawing.Size(258, 162)
        Me.robot.TabIndex = 9
        Me.robot.TabStop = False
        '
        'robotlife
        '
        Me.robotlife.Location = New System.Drawing.Point(628, 321)
        Me.robotlife.Name = "robotlife"
        Me.robotlife.Size = New System.Drawing.Size(100, 5)
        Me.robotlife.TabIndex = 12
        Me.robotlife.Visible = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(220, 417)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer1.TabIndex = 13
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(276, 417)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer2.TabIndex = 14
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(329, 417)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer3.TabIndex = 15
        Me.AxWindowsMediaPlayer3.Visible = False
        '
        'AxWindowsMediaPlayer4
        '
        Me.AxWindowsMediaPlayer4.Enabled = True
        Me.AxWindowsMediaPlayer4.Location = New System.Drawing.Point(382, 417)
        Me.AxWindowsMediaPlayer4.Name = "AxWindowsMediaPlayer4"
        Me.AxWindowsMediaPlayer4.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer4.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer4.TabIndex = 16
        Me.AxWindowsMediaPlayer4.Visible = False
        '
        'AxWindowsMediaPlayer5
        '
        Me.AxWindowsMediaPlayer5.Enabled = True
        Me.AxWindowsMediaPlayer5.Location = New System.Drawing.Point(437, 417)
        Me.AxWindowsMediaPlayer5.Name = "AxWindowsMediaPlayer5"
        Me.AxWindowsMediaPlayer5.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer5.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer5.TabIndex = 17
        Me.AxWindowsMediaPlayer5.Visible = False
        '
        'AxWindowsMediaPlayer6
        '
        Me.AxWindowsMediaPlayer6.Enabled = True
        Me.AxWindowsMediaPlayer6.Location = New System.Drawing.Point(489, 417)
        Me.AxWindowsMediaPlayer6.Name = "AxWindowsMediaPlayer6"
        Me.AxWindowsMediaPlayer6.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer6.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer6.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer6.TabIndex = 18
        Me.AxWindowsMediaPlayer6.Visible = False
        '
        'alienlife
        '
        Me.alienlife.Location = New System.Drawing.Point(1500, 200)
        Me.alienlife.Name = "alienlife"
        Me.alienlife.Size = New System.Drawing.Size(100, 5)
        Me.alienlife.TabIndex = 19
        Me.alienlife.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem, Me.NextStageToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'NextStageToolStripMenuItem
        '
        Me.NextStageToolStripMenuItem.Name = "NextStageToolStripMenuItem"
        Me.NextStageToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NextStageToolStripMenuItem.Text = "Next Stage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Score:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(946, 469)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.alienlife)
        Me.Controls.Add(Me.AxWindowsMediaPlayer6)
        Me.Controls.Add(Me.AxWindowsMediaPlayer5)
        Me.Controls.Add(Me.AxWindowsMediaPlayer4)
        Me.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.robotlife)
        Me.Controls.Add(Me.cannon)
        Me.Controls.Add(Me.metalcart)
        Me.Controls.Add(Me.journeybar)
        Me.Controls.Add(Me.medic)
        Me.Controls.Add(Me.lifebar)
        Me.Controls.Add(Me.robot)
        Me.Controls.Add(Me.fly)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(952, 498)
        Me.MinimumSize = New System.Drawing.Size(952, 498)
        Me.Name = "Form1"
        Me.Text = "Metal"
        CType(Me.metalcart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.medic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cannon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.robot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents metalcart As System.Windows.Forms.PictureBox
    Friend WithEvents Direction As System.Windows.Forms.Timer
    Friend WithEvents jmp As System.Windows.Forms.Timer
    Friend WithEvents medicine As System.Windows.Forms.Timer
    Friend WithEvents heal As System.Windows.Forms.Timer
    Friend WithEvents box As System.Windows.Forms.Timer
    Friend WithEvents boom As System.Windows.Forms.Timer
    Friend WithEvents lifebar As System.Windows.Forms.ProgressBar
    Friend WithEvents journeybar As System.Windows.Forms.ProgressBar
    Friend WithEvents medic As System.Windows.Forms.PictureBox
    Friend WithEvents enemy As System.Windows.Forms.Timer
    Friend WithEvents background As System.Windows.Forms.PictureBox
    Friend WithEvents fly As System.Windows.Forms.PictureBox
    Friend WithEvents cannon As System.Windows.Forms.PictureBox
    Friend WithEvents shot As System.Windows.Forms.Timer
    Friend WithEvents nuclear As System.Windows.Forms.Timer
    Friend WithEvents robot As System.Windows.Forms.PictureBox
    Friend WithEvents robotlife As System.Windows.Forms.ProgressBar
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer5 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer6 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents alienlife As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextStageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
