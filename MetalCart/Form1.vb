Public Class Form1
    Dim flyright As Image = Image.FromFile("metalplane1.gif")
    Dim explosion As Image = Image.FromFile("explode.gif")
    Dim treasure(10) As PictureBox
    Dim dynamite(5) As PictureBox
    Dim missile(7) As PictureBox
    Dim alien As PictureBox
    Dim mheight As Integer
    Dim mwidth As Integer
    Dim shoot As Boolean
    Dim pressright As Boolean
    Dim pressleft As Boolean
    Dim jump As Boolean
    Dim fall As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.Close()
        mheight = Me.Height - 200
        mwidth = Me.Width - 150
        background.Image = Image.FromFile("sky1.gif")
        metalcart.Image = flyright                                  'our plane
        metalcart.SizeMode = PictureBoxSizeMode.CenterImage
        metalcart.BringToFront()
        metalcart.Parent = background

        cannon.Parent = background                                  'cannon
        cannon.SizeMode = PictureBoxSizeMode.CenterImage

        medic.Image = Image.FromFile("medicine.gif")                'healing kit
        medic.SizeMode = PictureBoxSizeMode.CenterImage
        medic.BackColor = Color.Transparent
        medic.Parent = background

        robot.Image = Image.FromFile("machineleft.gif")             'enemies
        robot.Parent = background
        fly.Image = Image.FromFile("plane.gif")
        fly.SizeMode = PictureBoxSizeMode.CenterImage
        fly.Parent = background
        alien = New PictureBox
        alien.Image = Image.FromFile("spaceship.gif")
        alien.SetBounds(1500, 200, 163, 121)
        Me.Controls.Add(alien)
        alien.BackColor = Color.Transparent
        alien.Parent = background
        alien.SizeMode = PictureBoxSizeMode.CenterImage

        For z = 1 To 10                                             'treasure box
            Dim a As Integer = CInt((mwidth + 200) * Rnd())
            Dim b As Integer = CInt((mheight + 100) * Rnd())
            treasure(z) = New PictureBox
            treasure(z).Image = Image.FromFile("treasurebox.gif")
            treasure(z).SizeMode = PictureBoxSizeMode.CenterImage
            treasure(z).SetBounds(a, b, 24, 29)
            Me.Controls.Add(treasure(z))
            treasure(z).BringToFront()
            treasure(z).BackColor = Color.Transparent
            treasure(z).Parent = background
            Me.Refresh()
        Next

        For w = 1 To 5                                              'dynamite
            Dim a As Integer = CInt((mwidth + 200) * Rnd())
            Dim b As Integer = CInt((mheight + 100) * Rnd())
            dynamite(w) = New PictureBox
            dynamite(w).Image = Image.FromFile("bomb.gif")
            dynamite(w).SizeMode = PictureBoxSizeMode.CenterImage
            dynamite(w).SetBounds(a, b, 25, 29)
            Me.Controls.Add(dynamite(w))
            dynamite(w).BringToFront()
            dynamite(w).BackColor = Color.Transparent
            dynamite(w).Parent = background
            Me.Refresh()
        Next

        For m = 1 To 7                                              ' enemies' missile 
            Dim c As Integer = CInt((mheight + 100) * Rnd())
            missile(m) = New PictureBox
            missile(m).SizeMode = PictureBoxSizeMode.CenterImage
            missile(m).Image = Image.FromFile("minimissile.gif")
            missile(m).SetBounds(1000, c, 65, 20)
            Me.Controls.Add(missile(5))
            missile(m).BringToFront()
            missile(m).BackColor = Color.Transparent
            missile(m).Parent = background
        Next

        lifebar.BringToFront()                                  'progress bar
        lifebar.Maximum = 200
        lifebar.Value = 200
        journeybar.Maximum = 1000
        robotlife.Maximum = 100
        robotlife.Value = 100
        alienlife.Maximum = 100
        alienlife.Value = 100

        Direction.Start()                                       'timer
        jmp.Start()
        medicine.Start()
        heal.Start()
        box.Start()
        boom.Start()
        enemy.Start()
        nuclear.Start()
        shot.Start()

        AxWindowsMediaPlayer1.URL = "hmg.mp3"
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then                      'keys pressed
            metalcart.Image = flyright
            pressright = True
        ElseIf e.KeyCode = Keys.Left Then
            'metalcart.Image = flyleft
            pressleft = True
        ElseIf e.KeyCode = Keys.Up Then
            jump = True
        ElseIf e.KeyCode = Keys.Down Then
            fall = True
        ElseIf e.KeyCode = Keys.Space Then
            shoot = True
            Direction.Start()                                       'timer
            jmp.Start()
            medicine.Start()
            heal.Start()
            box.Start()
            boom.Start()
            enemy.Start()
            nuclear.Start()
            shot.Start()
        End If
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Right Then                      'keys released
            pressright = False
        ElseIf e.KeyCode = Keys.Left Then
            pressleft = False
        ElseIf e.KeyCode = Keys.Up Then
            jump = False
        ElseIf e.KeyCode = Keys.Down Then
            fall = False
        ElseIf e.KeyCode = Keys.Space Then
            shoot = False
        End If
    End Sub

    Private Sub Direction_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Direction.Tick
        If Not metalcart.Left <= 0 Then                 'our direction
            metalcart.Left -= 2
        End If

        If pressright = True Then
            If Not metalcart.Left > mwidth Then
                metalcart.Left += 22
            End If
        ElseIf pressleft = True Then
                If Not metalcart.Left < 0 Then
                    metalcart.Left -= 20
                End If
            End If
    End Sub

    Private Sub jmp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jmp.Tick
        If jump = True Then                                 'flying/falling
            If Not metalcart.Top < 0 Then
                metalcart.Top -= 15
            End If
        ElseIf fall = True Then
            If Not metalcart.Top > mheight + 70 Then
                metalcart.Top += 15
            End If
        End If
    End Sub

    Private Sub medicine_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medicine.Tick
        Dim a As Integer = CInt((mwidth + 650) * Rnd())             'position of healing kit
        Dim b As Integer = CInt((mheight + 100) * Rnd())
        medic.SetBounds(a, b, 30, 30)

    End Sub

    Private Sub heal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles heal.Tick
        If metalcart.Bounds.IntersectsWith(medic.Bounds) Then           ' what happens after getting healing kit
            AxWindowsMediaPlayer6.URL = "heal.mp3"
            medic.SetBounds(-1000, -1000, 30, 30)
            If lifebar.Value = 200 Then
                lifebar.Value += 0
            ElseIf lifebar.Value = 195 Then
                lifebar.Value += 5
            ElseIf lifebar.Value = 190 Then
                lifebar.Value += 10
            ElseIf lifebar.Value = 185 Then
                lifebar.Value += 15
            ElseIf lifebar.Value = 180 Then
                lifebar.Value += 20
            ElseIf lifebar.Value = 175 Then
                lifebar.Value += 25
            ElseIf lifebar.Value = 100 Then
                lifebar.Value += 50
            Else
                lifebar.Value += 30
            End If

        End If
    End Sub

    Private Sub box_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box.Tick
        Dim a As Integer = CInt((mwidth - 100) * Rnd())
        Dim b As Integer = CInt((mheight) * Rnd())
        For t = 1 To 10                                              'collecting treasure
            collect(t)
        Next
        For z = 1 To 10                                             'movements of treasure
            treasure(z).Left -= 4
            If Not treasure(z).Left >= 0 Then
                treasure(z).SetBounds(a, b, 25, 29)
            End If
        Next



    End Sub

    Sub collect(ByVal c As Integer)
        Dim a As Integer = CInt((mwidth + 200) * Rnd())
        Dim b As Integer = CInt((mheight + 100) * Rnd())
        If fly.Bounds.IntersectsWith(treasure(c).Bounds) Or robot.Bounds.IntersectsWith(treasure(c).Bounds) _
            Or alien.Bounds.IntersectsWith(treasure(c).Bounds) Then
            treasure(c).SetBounds(a, b, 25, 29)
        End If
        If metalcart.Bounds.IntersectsWith(treasure(c).Bounds) Then     'what happens after collecting treasure
            AxWindowsMediaPlayer5.URL = "coin.mp3"
            treasure(c).SetBounds(a, b, 25, 29)
            score(a)
            If journeybar.Value < 1000 Then
                journeybar.Value += 10
            End If
            If journeybar.Value = 1000 Then                                      'if you won
                robot.SetBounds(-1000, 0, 0, 0)
                metalcart.Image = Image.FromFile("victory.gif")
                metalcart.BackColor = Color.Transparent
                metalcart.Parent = background
                metalcart.SetBounds(480, 340, 80, 90)
                Direction.Stop()
                jmp.Stop()
                heal.Stop()
                box.Stop()
                boom.Stop()
                enemy.Stop()
                shot.Stop()
                nuclear.Stop()
                If MessageBox.Show("CONGRATULATIONS!", "VICTORY!", MessageBoxButtons.OK) =
                    DialogResult.OK Then
                    Me.Hide()
                    Form2.Show()

                End If
            End If
        End If
    End Sub

    Private Sub boom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boom.Tick
        Dim a As Integer = CInt((mwidth + 200) * Rnd())
        Dim b As Integer = CInt((mheight + 100) * Rnd())
        For d = 1 To 5                                              'getting hit by bombs
            hit(d)
        Next

        For w = 1 To 5                                              'movements of bombs
            dynamite(w).Left -= 5
            If Not dynamite(w).Left >= 0 Then
                dynamite(w).SetBounds(a, b, 25, 29)
            End If
        Next
    End Sub

    Sub hit(ByVal h As Integer)
        Dim a As Integer = CInt(mwidth + 200 * Rnd())               'what happens if hit dynamite
        Dim b As Integer = CInt(mheight * Rnd())

        If fly.Bounds.IntersectsWith(dynamite(h).Bounds) Or robot.Bounds.IntersectsWith(dynamite(h).Bounds) Or _
            alien.Bounds.IntersectsWith(dynamite(h).Bounds) Then
            dynamite(h).SetBounds(a, b, 25, 29)
        End If
        If metalcart.Bounds.IntersectsWith(dynamite(h).Bounds) Or cannon.Bounds.IntersectsWith(dynamite(h).Bounds) Then
            score(a)
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            dynamite(h).SetBounds(a, b, 25, 29)
            If Not lifebar.Value = 0 Then
                lifebar.Value -= 5
            End If
            If lifebar.Value = 0 Then                                                   'if you lost
                For d = 1 To 1
                    metal(d)
                Next
            End If
        End If
        
    End Sub

    Private Sub enemy_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy.Tick
        Dim b As Integer = CInt((mheight - 187) * Rnd())
        Dim y As Integer = alien.Top

        alien.Left -= 2
        alienlife.Left -= 2
        If alien.Left = -500 Then                       'flying path for alien
            alien.SetBounds(1700, b, 163, 121)
        End If
        If alien.Left = 1000 Then                                           'reviving alien
            alienlife.Value = (alienlife.Value - alienlife.Value) + 100
        End If
        If alienlife.Left = -500 Then                                   'make lifebar follows alien
            alienlife.SetBounds(1700, y, 163, 121)
        End If

        robot.Left -= 2
        robotlife.Left -= 2
        If robot.Left = -500 Then                           'the walking path for robot
            robot.SetBounds(1300, 308, 258, 162)
        End If
        If robot.Left = 1000 Then                                           'reviving robot
            robotlife.Value = (robotlife.Value - robotlife.Value) + 100
        End If
        If robotlife.Left = -500 Then                           'make lifebar follows robot
            robotlife.SetBounds(1500, y, 100, 5)
        End If

        fly.Left -= 10                                          'the flying path for enemy plane
        If fly.Left = -500 Then
            fly.Image = Image.FromFile("plane.gif")
            fly.SetBounds(1300, 54, 102, 59)
        End If
        If cannon.Bounds.IntersectsWith(fly.Bounds) Then        'when cannon hit enemy plane
            fly.Image = Image.FromFile("explode.gif")
            score(y)
        End If
        If metalcart.Bounds.IntersectsWith(fly.Bounds) Then     'when we hit enemy plane
            If Not journeybar.Value = 0 Then
                journeybar.Value -= 10
            End If
        End If

        If cannon.Bounds.IntersectsWith(robot.Bounds) Then          'when cannon hit robot
            score(b)
            cannon.SetBounds(-100, -100, 77, 24)

            If Not robotlife.Value = 0 Then
                robotlife.Value -= 2
            Else
                AxWindowsMediaPlayer4.URL = "bigbomb.mp3"
                robot.SetBounds(1500, 308, 258, 162)
                robotlife.SetBounds(1500, 308, 100, 5)
            End If
            robotlife.Visible = True
        Else
            robotlife.Visible = False
        End If

        If cannon.Bounds.IntersectsWith(alien.Bounds) Then      'when cannon hit alien
            score(b)
            cannon.SetBounds(-100, -100, 77, 24)

            If Not alienlife.Value = 0 Then
                alienlife.Value -= 2
            Else
                AxWindowsMediaPlayer4.URL = "bigbomb.mp3"
                alien.SetBounds(1700, 160, 163, 121)
                alienlife.SetBounds(1700, 160, 100, 5)
            End If
            alienlife.Visible = True
        Else
            alienlife.Visible = False
        End If

        If metalcart.Bounds.IntersectsWith(robot.Bounds) Or metalcart.Bounds.IntersectsWith(alien.Bounds) Then

            If Not lifebar.Value = 0 Then
                lifebar.Value -= 5
            End If
            If lifebar.Value = 0 Then               'if you lost
                For d = 1 To 1
                    metal(d)
                Next
            End If
        End If

    End Sub


    Private Sub shot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shot.Tick
        Dim x As Integer = metalcart.Left
        Dim y As Integer = metalcart.Top

        If shoot = True Then
            cannon.Left += 70
            If Not cannon.Left >= x Then
                cannon.SetBounds(x, y + 45, 77, 24)
            End If
            'If Not PictureBox1.Bounds.IntersectsWith(metalcart.Bounds) Then
            '    PictureBox1.SetBounds(x, y, 77, 24)
            'End If
            ' PictureBox1.SetBounds(x, y, 77, 24)
            If Not cannon.Left > x + 700 Then
                cannon.Left += 70
            End If
            If cannon.Left > x + 700 Then
                cannon.SetBounds(x, y + 45, 77, 24)
            End If
        Else
            cannon.SetBounds(-100, -100, 77, 24)
        End If
    End Sub

    Private Sub nuclear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuclear.Tick
        Dim b As Integer = CInt((mheight + 100) * Rnd())
        For m = 1 To 7
            launch(m)
        Next
        For m = 1 To 7                              'movements of enemy missiles
            missile(m).Left -= 20
            If missile(m).Left = -500 Then
                missile(m).SetBounds(1000, b, 65, 20)
            End If
        Next
    End Sub

    Sub launch(ByVal l As Integer)
        Dim b As Integer = ((mheight + 100) * Rnd())                'missile launched
        If cannon.Bounds.IntersectsWith(missile(l).Bounds) Then
            missile(l).SetBounds(1000, b, 65, 20)
            AxWindowsMediaPlayer2.URL = "bigbomb.mp3"
        End If
        If missile(l).Bounds.IntersectsWith(metalcart.Bounds) Then
            AxWindowsMediaPlayer4.URL = "bigbomb.mp3"
            missile(l).SetBounds(1000, b, 65, 20)
            If Not lifebar.Value = 0 Then
                lifebar.Value -= 5
            Else
                For d = 1 To 1
                    metal(d)
                Next  
            End If

        End If
    End Sub
    Sub metal(ByVal a As Integer)
        metalcart.Left -= 10000                     'if you failed
        If MessageBox.Show("Game Over", "You Failed.", MessageBoxButtons.RetryCancel) =
        DialogResult.Retry Then
            Me.Hide()
            Form3.Show()
        ElseIf DialogResult.Cancel Then
            Me.Close()
        End If
    End Sub

    Private Sub ControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlsToolStripMenuItem.Click
        MessageBox.Show("Arrow Keys to Move , Spacebar to Shoot, GAME PAUSED! Press Spacebar to Continue!", "Controls", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Direction.Stop()                                       'timers
        jmp.Stop()
        medicine.Stop()
        heal.Stop()
        box.Stop()
        boom.Stop()
        enemy.Stop()
        nuclear.Stop()
        shot.Stop()
    End Sub

    Private Sub NextStageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextStageToolStripMenuItem.Click
        If MessageBox.Show("Are you sure?", "Stage 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
            DialogResult.Yes Then                                       'tool strip
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Function score(ByVal s As Integer) As String
        Dim a As Integer                                                'function for counting the scores
        a = Val(Label1.Text)
        Label1.Text = CStr(a + 100)
        Return CStr(a)
    End Function
End Class




