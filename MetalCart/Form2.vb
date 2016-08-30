Public Class Form2
    Dim mwidth As Integer
    Dim mheight As Integer
    Dim pressup As Boolean
    Dim flying As Boolean
    Dim pressleft As Boolean
    Dim pressright As Boolean
    Dim shot As Boolean
    Dim shotback As Boolean
    Dim reverse As Boolean = False
    Dim moveback As Boolean = False
    Dim back As Boolean = False
    Dim launcher(5) As PictureBox
    Dim launcherdown As PictureBox

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        AxWindowsMediaPlayer1.URL = "metal slug 6.mp3"
        mwidth = Me.Width
        mheight = Me.Height

        map.Image = Image.FromFile("map1.gif")                  'background image
        map.SizeMode = PictureBoxSizeMode.CenterImage

        kraken.Image = Image.FromFile("kraken.gif")             'enemy1
        kraken.SizeMode = PictureBoxSizeMode.CenterImage
        kraken.Parent = map

        guardian.Image = Image.FromFile("guardian.gif")             'enemy2 and 3
        guardian.SizeMode = PictureBoxSizeMode.CenterImage
        guardian.Parent = map
        boss.Image = Image.FromFile("boss.gif")
        boss.SizeMode = PictureBoxSizeMode.CenterImage
        boss.Parent = map

        gundam.SizeMode = PictureBoxSizeMode.CenterImage                'gundam
        gundam.Parent = map


        cannon3.Image = Image.FromFile("missileleft.gif")               'missiles
        cannon3.SizeMode = PictureBoxSizeMode.CenterImage
        cannon3.Parent = map

        cannon2.Image = Image.FromFile("missileleft.gif")
        cannon2.SizeMode = PictureBoxSizeMode.CenterImage
        cannon2.Parent = map

        missile.Image = Image.FromFile("minimissile.gif")
        missile.SizeMode = PictureBoxSizeMode.CenterImage
        missile.Parent = map

        missile1.Image = Image.FromFile("minimissile.gif")
        missile1.SizeMode = PictureBoxSizeMode.CenterImage
        missile1.Parent = map

        missile2.Image = Image.FromFile("minimissile.gif")
        missile2.SizeMode = PictureBoxSizeMode.CenterImage
        missile2.Parent = map

        flame.Image = Image.FromFile("bullet.gif")                      'gundam's missile
        flame.SizeMode = PictureBoxSizeMode.CenterImage
        flame.Parent = map

        For m = 1 To 5                                          ' enemies' missile 
            Dim c As Integer = CInt((mheight + 100) * Rnd())
            launcher(m) = New PictureBox
            launcher(m).SizeMode = PictureBoxSizeMode.CenterImage
            launcher(m).Image = Image.FromFile("minimissile.gif")
            launcher(m).SetBounds(1000, c, 65, 20)
            Me.Controls.Add(launcher(m))
            launcher(m).BringToFront()
            launcher(m).BackColor = Color.Transparent
            launcher(m).Parent = map
        Next

        For m = 1 To 1                                            ' enemies' missile 
            Dim c As Integer = (kraken.Left + 100)
            launcherdown = New PictureBox
            launcherdown.SizeMode = PictureBoxSizeMode.CenterImage
            launcherdown.Image = Image.FromFile("topmissile.gif")
            launcherdown.SetBounds(c, 0, 61, 77)
            Me.Controls.Add(launcherdown)
            launcherdown.BringToFront()
            launcherdown.BackColor = Color.Transparent
            launcherdown.Parent = map
        Next

        movement.Start()
        krakenfly.Start()
        cannon23.Start()
        missile12.Start()
        fire.Start()
        crawler.Start()
        missiless.Start()

        guardianbar.Maximum = 600
        guardianbar.Value = 600
        krakenbar.Maximum = 500
        krakenbar.Value = 500
        bossbar.Maximum = 1000
        bossbar.Value = 1000
        gundambar.Maximum = 400
        gundambar.Value = 400

    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            pressup = True
            flying = False
        End If
        If e.KeyCode = Keys.Left Then
            pressleft = True
        ElseIf e.KeyCode = Keys.Right Then
            pressright = True
        ElseIf e.KeyCode = Keys.Space Then
            shot = True
        End If

    End Sub

    Private Sub Form2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            pressup = False
            flying = True
            If flying = True Then
                pressup = False
            End If
        ElseIf e.KeyCode = Keys.Left Then
            pressleft = False
        ElseIf e.KeyCode = Keys.Right Then
            pressright = False
        ElseIf e.KeyCode = Keys.Space Then
            shot = False
        End If

    End Sub

    Private Sub movement1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movement.Tick
        If pressleft = True Then
            gundam.Image = Image.FromFile("flyingleft.gif")
            If Not gundam.Left < 15 Then
                gundam.Left -= 10
            Else                                                                      'movement of gundam
                gundam.Image = Image.FromFile("gundamleft.gif")
            End If
        ElseIf pressright = True Then
            gundam.Image = Image.FromFile("flying.gif")
            If Not gundam.Left > mwidth - 50 Then
                gundam.Left += 10
            End If
        ElseIf pressleft = False Then
            gundam.Image = Image.FromFile("gundam.gif")
        End If

        If pressup = True Then
            If Not gundam.Top < 0 Then
                gundam.Top -= 7
            Else
                gundam.Top += 400
            End If
        ElseIf pressup = False Then
            If Not gundam.Top > Me.Height - 150 Then
                gundam.Top += 5
            End If
        End If
    End Sub
    Private Sub krakenfly_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles krakenfly.Tick

        If kraken.Location.X < 0 Then                                               'enemy1 
            kraken.Image = Image.FromFile("krakenleft.gif")
            reverse = True
        ElseIf kraken.Location.X > mwidth - 248 Then
            kraken.Image = Image.FromFile("kraken.gif")
            reverse = False
        End If

        If reverse = True Then
            krakenbar.Left += 2
            kraken.Left += 2
        Else
            krakenbar.Left -= 2
            kraken.Left -= 2
        End If

        If flame.Bounds.IntersectsWith(kraken.Bounds) Then
            krakenbar.Visible = True
            flame.SetBounds(-100, -100, 75, 25)
            If Not krakenbar.Value = 0 Then
                krakenbar.Value -= 5
            ElseIf krakenbar.Value = 0 Then
                AxWindowsMediaPlayer2.URL = "bigbomb.mp3"
                kraken.Left -= 1000
                krakenbar.Left -= 1000
                krakenfly.Stop()
            End If
        Else
            krakenbar.Visible = False
        End If

        If gundam.Bounds.IntersectsWith(kraken.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            End If
        End If

    End Sub

    Private Sub cannon23_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cannon23.Tick
        cannon3.Left -= 10
        cannon2.Left -= 10
        missile.Left -= 10                                                  'missiles
        If cannon2.Left = -100 Then
            cannon2.SetBounds(630, 329, 49, 19)
        ElseIf cannon3.Left = -200 Then
            cannon3.SetBounds(630, 304, 49, 19)
        ElseIf missile.Left = -300 Then
            missile.SetBounds(630, 392, 70, 31)
        End If

        If flame.Bounds.IntersectsWith(cannon3.Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            cannon3.SetBounds(630, 304, 49, 19)
        ElseIf flame.Bounds.IntersectsWith(cannon2.Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            cannon2.SetBounds(630, 329, 49, 19)
        ElseIf flame.Bounds.IntersectsWith(missile.Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            missile.SetBounds(630, 392, 70, 31)
        End If

        If gundam.Bounds.IntersectsWith(cannon3.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
            cannon3.SetBounds(630, 304, 49, 19)
        ElseIf gundam.Bounds.IntersectsWith(cannon2.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
            cannon2.SetBounds(630, 329, 49, 19)
        ElseIf gundam.Bounds.IntersectsWith(missile.Bounds) Then
            AxWindowsMediaPlayer2.URL = "bigbomb.mp3"
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
            missile.SetBounds(630, 392, 70, 31)
        End If

    End Sub
    Sub gundams(ByVal a As Integer)
        gundam.Left -= 10000
        If MessageBox.Show("Game Over", "You Failed.", MessageBoxButtons.RetryCancel) =
        DialogResult.Retry Then
            Me.Hide()
            Form3.Show()
        ElseIf DialogResult.Cancel Then
            Me.Close()
        End If
    End Sub

    Private Sub missile12_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles missile12.Tick
        missile1.Left -= 10
        missile2.Left -= 20                                                     'missiles
        If missile1.Left = -200 Then
            missile1.SetBounds(860, 439, 49, 19)
        ElseIf missile2.Left = -300 Then
            missile2.SetBounds(780, (504 * Rnd()), 49, 19)
        End If

        If flame.Bounds.IntersectsWith(missile1.Bounds) Then
            missile1.SetBounds(860, 439, 49, 19)
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
        ElseIf flame.Bounds.IntersectsWith(missile2.Bounds) Then
            missile2.SetBounds(780, (504 * Rnd()), 49, 19)
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
        End If

        If gundam.Bounds.IntersectsWith(missile1.Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
            missile1.SetBounds(860, 439, 49, 19)
        ElseIf gundam.Bounds.IntersectsWith(missile2.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
            missile2.SetBounds(780, (504 * Rnd()), 49, 19)
        End If

    End Sub

    Private Sub fireout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fire.Tick
        Dim x As Integer = gundam.Left
        Dim y As Integer = gundam.Top

        If shot = True Then                                         'gundam's missle
            flame.Image = Image.FromFile("bullet.gif")
            flame.Left += 70
            If Not flame.Left >= x Then
                flame.SetBounds(x, y + 20, 75, 25)
            End If
            If Not flame.Left > x + 700 Then
                flame.Left += 70
            End If
            If flame.Left > x + 700 Then
                flame.SetBounds(x, y + 20, 75, 25)
            End If
        Else
            flame.SetBounds(-100, -100, 75, 25)
        End If
    End Sub

    Private Sub crawler_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crawler.Tick

        If guardian.Location.X < 400 Then
            moveback = True                                                     'enemy2
        ElseIf guardian.Location.X > 549 Then
            moveback = False
        End If

        If moveback = True Then
            guardianbar.Left += 2
            guardian.Left += 2
        Else
            guardianbar.Left -= 2
            guardian.Left -= 2
        End If

        If flame.Bounds.IntersectsWith(guardian.Bounds) Then
            guardianbar.Visible = True
            flame.SetBounds(-100, -100, 75, 25)
            If Not guardianbar.Value = 0 Then
                guardianbar.Value -= 5
            ElseIf guardianbar.Value = 0 Then
                AxWindowsMediaPlayer2.URL = "bigbomb.mp3"
                guardian.Left -= 1000
                guardianbar.Left -= 1000
                crawler.Stop()
                missile12.Stop()
                cannon23.Stop()
                daboss.Start()
                missiles.Start()
                missile.SetBounds(-10000, -1000, 10, 10)
                missile1.SetBounds(-10000, -1000, 10, 10)
                missile2.SetBounds(-10000, -1000, 10, 10)
                cannon2.SetBounds(-10000, -1000, 10, 10)
                cannon3.SetBounds(-10000, -1000, 10, 10)

            End If
        Else
            guardianbar.Visible = False
        End If

        If gundam.Bounds.IntersectsWith(guardian.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
        End If
    End Sub

    Private Sub daboss_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles daboss.Tick

        If boss.Location.X < 0 Then
            back = True
        ElseIf boss.Location.X > mwidth - 100 Then              'enemy3
            back = False
        End If

        If back = True Then
            boss.Left += 2
            bossbar.Left += 2
        Else
            boss.Left -= 2
            bossbar.Left -= 2
        End If

        If flame.Bounds.IntersectsWith(boss.Bounds) Then
            bossbar.Visible = True
            flame.SetBounds(-100, -100, 75, 25)
            If Not bossbar.Value = 0 Then
                bossbar.Value -= 5
            ElseIf bossbar.Value = 0 Then
                AxWindowsMediaPlayer2.URL = "bigbomb.mp3"
                boss.Left -= 10000
                bossbar.Left -= 10000
                daboss.Stop()
                krakenfly.Stop()
                If MessageBox.Show("CONGRATULATIONS!", "VICTORY!", MessageBoxButtons.OK) =
                    DialogResult.OK Then
                    Me.Close()

                End If
            End If
        Else
            bossbar.Visible = False
        End If

        If gundam.Bounds.IntersectsWith(boss.Bounds) Then
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
        End If
    End Sub

    Private Sub missiles_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles missiles.Tick
        Dim b As Integer = CInt((mheight + 100) * Rnd())
        For m = 1 To 5
            launch(m)
        Next
        For m = 1 To 5                              'movements of enemy missiles
            launcher(m).Left -= 20
            If launcher(m).Left = -500 Then
                launcher(m).SetBounds(1000, b, 65, 20)
            End If
        Next
    End Sub
    Private Sub missiless_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles missiless.Tick
        Dim b As Integer = (kraken.Left + 100)

        If launcherdown.Bounds.IntersectsWith(gundam.Bounds) Then                   'kraken's cannon
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            launcherdown.SetBounds(b, 0, 61, 77)
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5
            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
        End If

        'movements of enemy missiles
        launcherdown.Top += 15
        If launcherdown.Top = 1050 Then
            launcherdown.SetBounds(b, 0, 61, 77)
        End If

    End Sub

    Sub launch(ByVal l As Integer)
        Dim b As Integer = ((mheight + 100) * Rnd())                'missile launched
        If flame.Bounds.IntersectsWith(launcher(l).Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            launcher(l).SetBounds(1000, b, 65, 20)

        ElseIf launcher(l).Bounds.IntersectsWith(gundam.Bounds) Then
            AxWindowsMediaPlayer3.URL = "grenade.mp3"
            launcher(l).SetBounds(1000, b, 65, 20)
            If Not gundambar.Value = 0 Then
                gundambar.Value -= 5

            Else
                For d = 1 To 1
                    gundams(d)
                Next
            End If
        End If
    End Sub
End Class