Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

        If RadioButton1.Checked = True Then
            Me.Hide()
            Form1.Show()
        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        Form2.Close()
    End Sub
End Class