<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InternetradiostationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPORadio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPORadio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPORadio2SoulJazzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPO3FMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPORadio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NPORadio5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QmusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Radio538ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkyRadioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Radio10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeronicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecibelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SLAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AangepasteURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.NetCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DirListBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FileListBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(750, 190)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'DirListBox1
        '
        Me.DirListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DirListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(3, 3)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(369, 184)
        Me.DirListBox1.TabIndex = 0
        '
        'FileListBox1
        '
        Me.FileListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileListBox1.FormattingEnabled = True
        Me.FileListBox1.Location = New System.Drawing.Point(378, 3)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = resources.GetString("FileListBox1.Pattern")
        Me.FileListBox1.ReadOnly = False
        Me.FileListBox1.Size = New System.Drawing.Size(369, 184)
        Me.FileListBox1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DriveListBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 474)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(756, 221)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'DriveListBox1
        '
        Me.DriveListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(3, 3)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(750, 21)
        Me.DriveListBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InternetradiostationsToolStripMenuItem, Me.AangepasteURLToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowConsoleToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'ShowConsoleToolStripMenuItem
        '
        Me.ShowConsoleToolStripMenuItem.Name = "ShowConsoleToolStripMenuItem"
        Me.ShowConsoleToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ShowConsoleToolStripMenuItem.Text = "Console"
        '
        'InternetradiostationsToolStripMenuItem
        '
        Me.InternetradiostationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NPORadio1ToolStripMenuItem, Me.NPORadio2ToolStripMenuItem, Me.NPO3FMToolStripMenuItem, Me.NPORadio4ToolStripMenuItem, Me.NPORadio5ToolStripMenuItem, Me.ToolStripMenuItem2, Me.QmusicToolStripMenuItem, Me.Radio538ToolStripMenuItem, Me.SkyRadioToolStripMenuItem, Me.Radio10ToolStripMenuItem, Me.VeronicaToolStripMenuItem, Me.DecibelToolStripMenuItem, Me.SLAMToolStripMenuItem})
        Me.InternetradiostationsToolStripMenuItem.Name = "InternetradiostationsToolStripMenuItem"
        Me.InternetradiostationsToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.InternetradiostationsToolStripMenuItem.Text = "Internetradiostations"
        '
        'NPORadio1ToolStripMenuItem
        '
        Me.NPORadio1ToolStripMenuItem.Name = "NPORadio1ToolStripMenuItem"
        Me.NPORadio1ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NPORadio1ToolStripMenuItem.Text = "NPO Radio 1"
        '
        'NPORadio2ToolStripMenuItem
        '
        Me.NPORadio2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NPORadio2SoulJazzToolStripMenuItem})
        Me.NPORadio2ToolStripMenuItem.Name = "NPORadio2ToolStripMenuItem"
        Me.NPORadio2ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NPORadio2ToolStripMenuItem.Text = "NPO Radio 2"
        '
        'NPORadio2SoulJazzToolStripMenuItem
        '
        Me.NPORadio2SoulJazzToolStripMenuItem.Name = "NPORadio2SoulJazzToolStripMenuItem"
        Me.NPORadio2SoulJazzToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.NPORadio2SoulJazzToolStripMenuItem.Text = "NPO Radio 2 Soul & Jazz"
        '
        'NPO3FMToolStripMenuItem
        '
        Me.NPO3FMToolStripMenuItem.Name = "NPO3FMToolStripMenuItem"
        Me.NPO3FMToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NPO3FMToolStripMenuItem.Text = "NPO 3FM"
        '
        'NPORadio4ToolStripMenuItem
        '
        Me.NPORadio4ToolStripMenuItem.Name = "NPORadio4ToolStripMenuItem"
        Me.NPORadio4ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NPORadio4ToolStripMenuItem.Text = "NPO Radio 4"
        '
        'NPORadio5ToolStripMenuItem
        '
        Me.NPORadio5ToolStripMenuItem.Name = "NPORadio5ToolStripMenuItem"
        Me.NPORadio5ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NPORadio5ToolStripMenuItem.Text = "NPO Radio 5"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Enabled = False
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "----------------------"
        '
        'QmusicToolStripMenuItem
        '
        Me.QmusicToolStripMenuItem.Name = "QmusicToolStripMenuItem"
        Me.QmusicToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.QmusicToolStripMenuItem.Text = "Qmusic"
        '
        'Radio538ToolStripMenuItem
        '
        Me.Radio538ToolStripMenuItem.Name = "Radio538ToolStripMenuItem"
        Me.Radio538ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.Radio538ToolStripMenuItem.Text = "Radio 538"
        '
        'SkyRadioToolStripMenuItem
        '
        Me.SkyRadioToolStripMenuItem.Name = "SkyRadioToolStripMenuItem"
        Me.SkyRadioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SkyRadioToolStripMenuItem.Text = "Sky Radio"
        '
        'Radio10ToolStripMenuItem
        '
        Me.Radio10ToolStripMenuItem.Name = "Radio10ToolStripMenuItem"
        Me.Radio10ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.Radio10ToolStripMenuItem.Text = "Radio 10"
        '
        'VeronicaToolStripMenuItem
        '
        Me.VeronicaToolStripMenuItem.Name = "VeronicaToolStripMenuItem"
        Me.VeronicaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.VeronicaToolStripMenuItem.Text = "Veronica"
        '
        'DecibelToolStripMenuItem
        '
        Me.DecibelToolStripMenuItem.Name = "DecibelToolStripMenuItem"
        Me.DecibelToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DecibelToolStripMenuItem.Text = "Decibel"
        '
        'SLAMToolStripMenuItem
        '
        Me.SLAMToolStripMenuItem.Name = "SLAMToolStripMenuItem"
        Me.SLAMToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SLAMToolStripMenuItem.Text = "SLAM!"
        '
        'AangepasteURLToolStripMenuItem
        '
        Me.AangepasteURLToolStripMenuItem.Name = "AangepasteURLToolStripMenuItem"
        Me.AangepasteURLToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AangepasteURLToolStripMenuItem.Text = "Aangepaste URL"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.OverToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        Me.HelpToolStripMenuItem1.Visible = False
        '
        'OverToolStripMenuItem
        '
        Me.OverToolStripMenuItem.Name = "OverToolStripMenuItem"
        Me.OverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OverToolStripMenuItem.Text = "Over Simplayer"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(756, 450)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'NetCheckTimer
        '
        Me.NetCheckTimer.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 695)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Simplayer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DirListBox1 As Compatibility.VB6.DirListBox
    Friend WithEvents FileListBox1 As Compatibility.VB6.FileListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DriveListBox1 As Compatibility.VB6.DriveListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InternetradiostationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPORadio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPORadio2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPORadio2SoulJazzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPO3FMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPORadio4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NPORadio5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents QmusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Radio538ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AangepasteURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SkyRadioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Radio10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VeronicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecibelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SLAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetCheckTimer As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OverToolStripMenuItem As ToolStripMenuItem
End Class
