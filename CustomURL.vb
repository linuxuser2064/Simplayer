Imports System.Windows.Forms

Public Class CustomURL

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Me.Text = "Simplayer: " + TextBox1.Text
            Form1.AxWindowsMediaPlayer1.URL = TextBox1.Text
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If String.IsNullOrEmpty(TextBox1.Text) Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub
End Class
