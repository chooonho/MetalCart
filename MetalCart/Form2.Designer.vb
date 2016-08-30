<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.boss = New System.Windows.Forms.PictureBox()
        Me.kraken = New System.Windows.Forms.PictureBox()
        Me.guardian = New System.Windows.Forms.PictureBox()
        Me.gundam = New System.Windows.Forms.PictureBox()
        Me.map = New System.Windows.Forms.PictureBox()
        Me.movement = New System.Windows.Forms.Timer(Me.components)
        Me.krakenfly = New System.Windows.Forms.Timer(Me.components)
        Me.cannon3 = New System.Windows.Forms.PictureBox()
        Me.missile = New System.Windows.Forms.PictureBox()
        Me.cannon2 = New System.Windows.Forms.PictureBox()
        Me.cannon23 = New System.Windows.Forms.Timer(Me.components)
        Me.missile1 = New System.Windows.Forms.PictureBox()
        Me.missile2 = New System.Windows.Forms.PictureBox()
        Me.missile12 = New System.Windows.Forms.Timer(Me.components)
        Me.flame = New System.Windows.Forms.PictureBox()
        Me.fire = New System.Windows.Forms.Timer(Me.components)
        Me.crawler = New System.Windows.Forms.Timer(Me.components)
        Me.krakenbar = New System.Windows.Forms.ProgressBar()
        Me.guardianbar = New System.Windows.Forms.ProgressBar()
        Me.bossbar = New System.Windows.Forms.ProgressBar()
        Me.daboss = New System.Windows.Forms.Timer(Me.components)
        Me.missiles = New System.Windows.Forms.Timer(Me.components)
        Me.gundambar = New System.Windows.Forms.ProgressBar()
        Me.missiless = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.AxWindowsMediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kraken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guardian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gundam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.map, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cannon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cannon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boss
        '
        Me.boss.BackColor = System.Drawing.Color.Transparent
        Me.boss.Location = New System.Drawing.Point(815, 368)
        Me.boss.Name = "boss"
        Me.boss.Size = New System.Drawing.Size(149, 167)
        Me.boss.TabIndex = 0
        Me.boss.TabStop = False
        '
        'kraken
        '
        Me.kraken.BackColor = System.Drawing.Color.Transparent
        Me.kraken.Location = New System.Drawing.Point(693, 12)
        Me.kraken.Name = "kraken"
        Me.kraken.Size = New System.Drawing.Size(251, 221)
        Me.kraken.TabIndex = 1
        Me.kraken.TabStop = False
        '
        'guardian
        '
        Me.guardian.BackColor = System.Drawing.Color.Transparent
        Me.guardian.Location = New System.Drawing.Point(549, 229)
        Me.guardian.Name = "guardian"
        Me.guardian.Size = New System.Drawing.Size(215, 317)
        Me.guardian.TabIndex = 2
        Me.guardian.TabStop = False
        '
        'gundam
        '
        Me.gundam.BackColor = System.Drawing.Color.Transparent
        Me.gundam.Image = CType(resources.GetObject("gundam.Image"), System.Drawing.Image)
        Me.gundam.Location = New System.Drawing.Point(61, 304)
        Me.gundam.Name = "gundam"
        Me.gundam.Size = New System.Drawing.Size(105, 119)
        Me.gundam.TabIndex = 3
        Me.gundam.TabStop = False
        '
        'map
        '
        Me.map.Location = New System.Drawing.Point(-27, -10)
        Me.map.Name = "map"
        Me.map.Size = New System.Drawing.Size(1029, 556)
        Me.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.map.TabIndex = 4
        Me.map.TabStop = False
        '
        'movement
        '
        Me.movement.Interval = 1
        '
        'krakenfly
        '
        Me.krakenfly.Interval = 1
        '
        'cannon3
        '
        Me.cannon3.BackColor = System.Drawing.Color.Transparent
        Me.cannon3.Location = New System.Drawing.Point(630, 304)
        Me.cannon3.Name = "cannon3"
        Me.cannon3.Size = New System.Drawing.Size(49, 19)
        Me.cannon3.TabIndex = 5
        Me.cannon3.TabStop = False
        '
        'missile
        '
        Me.missile.BackColor = System.Drawing.Color.Transparent
        Me.missile.Location = New System.Drawing.Point(630, 392)
        Me.missile.Name = "missile"
        Me.missile.Size = New System.Drawing.Size(70, 31)
        Me.missile.TabIndex = 6
        Me.missile.TabStop = False
        '
        'cannon2
        '
        Me.cannon2.BackColor = System.Drawing.Color.Transparent
        Me.cannon2.Location = New System.Drawing.Point(630, 329)
        Me.cannon2.Name = "cannon2"
        Me.cannon2.Size = New System.Drawing.Size(49, 19)
        Me.cannon2.TabIndex = 7
        Me.cannon2.TabStop = False
        '
        'cannon23
        '
        Me.cannon23.Interval = 1
        '
        'missile1
        '
        Me.missile1.BackColor = System.Drawing.Color.Transparent
        Me.missile1.Location = New System.Drawing.Point(860, 439)
        Me.missile1.Name = "missile1"
        Me.missile1.Size = New System.Drawing.Size(70, 31)
        Me.missile1.TabIndex = 8
        Me.missile1.TabStop = False
        '
        'missile2
        '
        Me.missile2.BackColor = System.Drawing.Color.Transparent
        Me.missile2.Location = New System.Drawing.Point(780, 504)
        Me.missile2.Name = "missile2"
        Me.missile2.Size = New System.Drawing.Size(70, 31)
        Me.missile2.TabIndex = 9
        Me.missile2.TabStop = False
        '
        'missile12
        '
        Me.missile12.Interval = 1
        '
        'flame
        '
        Me.flame.BackColor = System.Drawing.Color.Transparent
        Me.flame.Location = New System.Drawing.Point(79, 318)
        Me.flame.Name = "flame"
        Me.flame.Size = New System.Drawing.Size(75, 25)
        Me.flame.TabIndex = 10
        Me.flame.TabStop = False
        '
        'fire
        '
        Me.fire.Interval = 1
        '
        'crawler
        '
        Me.crawler.Interval = 1
        '
        'krakenbar
        '
        Me.krakenbar.Location = New System.Drawing.Point(693, 24)
        Me.krakenbar.Name = "krakenbar"
        Me.krakenbar.Size = New System.Drawing.Size(200, 5)
        Me.krakenbar.TabIndex = 11
        Me.krakenbar.Visible = False
        '
        'guardianbar
        '
        Me.guardianbar.Location = New System.Drawing.Point(549, 239)
        Me.guardianbar.Name = "guardianbar"
        Me.guardianbar.Size = New System.Drawing.Size(200, 5)
        Me.guardianbar.TabIndex = 12
        Me.guardianbar.Visible = False
        '
        'bossbar
        '
        Me.bossbar.Location = New System.Drawing.Point(780, 342)
        Me.bossbar.Name = "bossbar"
        Me.bossbar.Size = New System.Drawing.Size(200, 5)
        Me.bossbar.TabIndex = 13
        Me.bossbar.Visible = False
        '
        'daboss
        '
        Me.daboss.Interval = 1
        '
        'missiles
        '
        Me.missiles.Interval = 1
        '
        'gundambar
        '
        Me.gundambar.Location = New System.Drawing.Point(21, 504)
        Me.gundambar.Name = "gundambar"
        Me.gundambar.Size = New System.Drawing.Size(200, 10)
        Me.gundambar.TabIndex = 14
        '
        'missiless
        '
        Me.missiless.Interval = 1
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(263, 498)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer1.TabIndex = 15
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(329, 498)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer2.TabIndex = 16
        Me.AxWindowsMediaPlayer2.Visible = False
        '
        'AxWindowsMediaPlayer3
        '
        Me.AxWindowsMediaPlayer3.Enabled = True
        Me.AxWindowsMediaPlayer3.Location = New System.Drawing.Point(395, 498)
        Me.AxWindowsMediaPlayer3.Name = "AxWindowsMediaPlayer3"
        Me.AxWindowsMediaPlayer3.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer3.Size = New System.Drawing.Size(60, 37)
        Me.AxWindowsMediaPlayer3.TabIndex = 17
        Me.AxWindowsMediaPlayer3.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 538)
        Me.Controls.Add(Me.AxWindowsMediaPlayer3)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.gundambar)
        Me.Controls.Add(Me.bossbar)
        Me.Controls.Add(Me.guardianbar)
        Me.Controls.Add(Me.krakenbar)
        Me.Controls.Add(Me.flame)
        Me.Controls.Add(Me.missile2)
        Me.Controls.Add(Me.missile1)
        Me.Controls.Add(Me.cannon2)
        Me.Controls.Add(Me.cannon3)
        Me.Controls.Add(Me.missile)
        Me.Controls.Add(Me.gundam)
        Me.Controls.Add(Me.guardian)
        Me.Controls.Add(Me.kraken)
        Me.Controls.Add(Me.boss)
        Me.Controls.Add(Me.map)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.Text = "Metal_2"
        CType(Me.boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kraken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guardian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gundam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.map, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cannon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cannon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents boss As System.Windows.Forms.PictureBox
    Friend WithEvents kraken As System.Windows.Forms.PictureBox
    Friend WithEvents guardian As System.Windows.Forms.PictureBox
    Friend WithEvents gundam As System.Windows.Forms.PictureBox
    Friend WithEvents map As System.Windows.Forms.PictureBox
    Friend WithEvents movement As System.Windows.Forms.Timer
    Friend WithEvents krakenfly As System.Windows.Forms.Timer
    Friend WithEvents cannon As System.Windows.Forms.PictureBox
    Friend WithEvents missile As System.Windows.Forms.PictureBox
    Friend WithEvents cannon2 As System.Windows.Forms.PictureBox
    Friend WithEvents cannon1 As System.Windows.Forms.PictureBox
    Friend WithEvents cannon3 As System.Windows.Forms.PictureBox
    Friend WithEvents cannon23 As System.Windows.Forms.Timer
    Friend WithEvents missile1 As System.Windows.Forms.PictureBox
    Friend WithEvents missile2 As System.Windows.Forms.PictureBox
    Friend WithEvents missile12 As System.Windows.Forms.Timer
    Friend WithEvents flame As System.Windows.Forms.PictureBox
    Friend WithEvents fire As System.Windows.Forms.Timer
    Friend WithEvents crawler As System.Windows.Forms.Timer
    Friend WithEvents krakenbar As System.Windows.Forms.ProgressBar
    Friend WithEvents guardianbar As System.Windows.Forms.ProgressBar
    Friend WithEvents bossbar As System.Windows.Forms.ProgressBar
    Friend WithEvents daboss As System.Windows.Forms.Timer
    Friend WithEvents missiles As System.Windows.Forms.Timer
    Friend WithEvents gundambar As System.Windows.Forms.ProgressBar
    Friend WithEvents missiless As System.Windows.Forms.Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AxWindowsMediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
End Class
