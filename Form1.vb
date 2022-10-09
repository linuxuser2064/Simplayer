Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsoleWindow.RichTextBox1.Text = "[Bootstrapper] Console initalized."

        DirListBox1.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        FileListBox1.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
        Try
            If My.Computer.Network.Ping("www.google.com") Then
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[NetworkMonitor] Network found, enabling network components."
            End If
        Catch ex As Exception
            '' else ''
            ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[NetworkMonitor] No network found, disabling network components."
            MsgBox("Er is geen internetverbinding gevonden, netwerkonderdelen werkt niet.", MsgBoxStyle.Exclamation, "Waarschuwing")
            InternetradiostationsToolStripMenuItem.Enabled = False
            AangepasteURLToolStripMenuItem.Enabled = False
        End Try
    End Sub

    Private Sub DirListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles DirListBox1.SelectedValueChanged
        ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[FileManager] Changing paths..."
        FileListBox1.Path = DirListBox1.Path
    End Sub

    Private Sub FileListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles FileListBox1.SelectedValueChanged
        If Not String.IsNullOrEmpty(FileListBox1.FileName) Then
            Me.Text = "Simplayer: " + FileListBox1.FileName
            AxWindowsMediaPlayer1.URL = FileListBox1.Path + "\" + FileListBox1.FileName
        End If
    End Sub

    Private Sub DriveListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles DriveListBox1.SelectedValueChanged
        ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[FileManager] Changing drives..."
        DirListBox1.Path = DriveListBox1.Drive
        FileListBox1.Path = DriveListBox1.Drive
    End Sub

    Private Sub NPORadio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPORadio1ToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO Radio 1"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/radio1-bb-mp3"
    End Sub

    Private Sub NPORadio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPORadio2ToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO Radio 2"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/radio2-bb-mp3"
        InternetradiostationsToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub NPORadio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPO3FMToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO 3FM"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/3fm-bb-mp3"
    End Sub

    Private Sub NPORadio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPORadio4ToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO Radio 4"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/radio4-bb-mp3"
    End Sub

    Private Sub NPORadio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPORadio5ToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO Radio 5"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/radio5-bb-mp3"
    End Sub

    Private Sub NPORadio2SoulJazzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NPORadio2SoulJazzToolStripMenuItem.Click
        Me.Text = "Simplayer: NPO Radio 2 Soul & Jazz"
        AxWindowsMediaPlayer1.URL = "https://icecast.omroep.nl/radio6-bb-mp3"
    End Sub

    Private Sub QmusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QmusicToolStripMenuItem.Click
        Me.Text = "Simplayer: Qmusic"
        AxWindowsMediaPlayer1.URL = "https://stream.qmusic.nl/qmusic/mp3"
    End Sub

    Private Sub Radio538ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Radio538ToolStripMenuItem.Click
        Me.Text = "Simplayer: Radio 538"
        AxWindowsMediaPlayer1.URL = "https://21253.live.streamtheworld.com/RADIO538.mp3"
    End Sub

    Private Sub SkyRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SkyRadioToolStripMenuItem.Click
        Me.Text = "Simplayer: Sky Radio"
        AxWindowsMediaPlayer1.URL = "https://19993.live.streamtheworld.com/SKYRADIO.mp3"
    End Sub

    Private Sub Radio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Radio10ToolStripMenuItem.Click
        Me.Text = "Simplayer: Radio 10"
        AxWindowsMediaPlayer1.URL = "http://19993.live.streamtheworld.com/RADIO10.mp3"
    End Sub

    Private Sub RadioVeronicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VeronicaToolStripMenuItem.Click
        Me.Text = "Simplayer: Veronica"
        AxWindowsMediaPlayer1.URL = "https://20723.live.streamtheworld.com/VERONICA.mp3"
    End Sub

    Private Sub DECIBELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecibelToolStripMenuItem.Click
        Me.Text = "Simplayer: DECIBEL"
        AxWindowsMediaPlayer1.URL = "https://stream.decibel.nl/decibel.mp3"
    End Sub

    Private Sub SLAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLAMToolStripMenuItem.Click
        Me.Text = "Simplayer: SLAM!"
        AxWindowsMediaPlayer1.URL = "https://stream.slam.nl/slam_mp3"
    End Sub

    Private Sub WebURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AangepasteURLToolStripMenuItem.Click
        ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Application] Loading Custom URL dialog..."
        CustomURL.ShowDialog()
    End Sub

    Private Sub AxWindowsMediaPlayer1_CurrentItemChange(sender As Object, e As AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent) Handles AxWindowsMediaPlayer1.CurrentItemChange
        ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Loading item: " & Me.AxWindowsMediaPlayer1.currentMedia.name
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        Select Case e.newState
            Case 1 ' Stopped
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Stopped"
                Me.Text = "Simplayer"

            Case 2 ' Paused
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Paused"

            Case 3 ' Playing
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Playing"

            Case 4 ' ScanForward
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Scan Forward"

            Case 5 ' ScanReverse
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Scan Reverse"

            Case 6 ' Buffering
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Buffering"

            Case 7 ' Waiting
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Waiting"

            Case 8 ' MediaEnded
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Media Ended"

            Case 9 ' Transitioning
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Transitioning"

            Case 10 ' Ready
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Ready"

            Case 11 ' Reconnecting
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Reconnecting"

            Case 12 ' Last
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Last"

            Case Else
                ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Player] Unknown status: " & e.newState

        End Select
    End Sub

    Private Declare Function GetActiveWindow Lib "user32" () As Long
    Private Sub NetCheckTimer_Tick(sender As Object, e As EventArgs) Handles NetCheckTimer.Tick

        If GetActiveWindow <> 0 Then
            If My.Computer.Keyboard.AltKeyDown = True Then
                ConsoleWindow.Show()
            End If
        Else
            'Application not in focus
        End If
    End Sub

    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    Button1.Location = New Point(Me.Size.Width - 102, Button1.Location.Y)
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Application] Launching console window..."
    '    ConsoleWindow.Show()
    'End Sub

    Private Sub ShowConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowConsoleToolStripMenuItem.Click
        ConsoleWindow.RichTextBox1.Text = ConsoleWindow.RichTextBox1.Text + Environment.NewLine + "[Application] Launching console window..."
        ConsoleWindow.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("Coming soon!")
    End Sub

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        MsgBox("Simplayer 1.0.0.0" + vbNewLine + "Gemaakt door MarkPCExpert", MsgBoxStyle.Information, "Over Simplayer")
    End Sub
End Class