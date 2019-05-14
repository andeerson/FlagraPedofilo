Public Class Form1

    Private Property Form1 As Object

    Private Sub btgravar_Click(sender As Object, e As EventArgs) Handles btgravar.Click
        'On Error Resume Next

        'If btgravar.Text = "Gravar" Then
        '    For Each Str As String In IO.Directory.EnumerateFiles(Application.StartupPath & "\Bibliotecas\Imagens\", "*.png", IO.SearchOption.TopDirectoryOnly)
        '        Kill(Str)
        '    Next

        '    BackgroundWorker1.RunWorkerAsync()
        '    btgravar.Text = "Parar"
        'Else
        BackgroundWorker1.CancelAsync()
        btgravar.Text = "Gravar"

        MessageBox.Show("A gravação foi interompida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
        btgravar.Enabled = False
        btAssistir.Enabled = True



    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        On Error Resume Next

        Dim Count_images As Integer = 0

        For i = 0 To 1 Step 0

            If BackgroundWorker1.CancellationPending = True Then
                Exit For

            Else

                Dim Path As String = Application.StartupPath & "\Bibliotecas\Imagens\"
                Dim Bmp As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                Dim Gra As Graphics = Graphics.FromImage(Bmp)
                Gra.CopyFromScreen(New Point(0, 0), New Point(0, 0), Bmp.Size)
                Bmp.Tag = Count_images
                If IO.Directory.Exists(Path) = False Then
                    IO.Directory.CreateDirectory(Path)
                End If

                Kill(Path & Bmp.Tag & ".png")
                Bmp.Save(Path & Bmp.Tag & ".png", Drawing.Imaging.ImageFormat.Png) 'Aqui é o momento que escolhemos a extensão
                Count_images += 1                                                  'da imagem.


            End If



        Next

    End Sub

    Private Sub btAssistir_Click(sender As Object, e As EventArgs) Handles btAssistir.Click
        Form2.ShowDialog()



    End Sub

    Private Sub QUEMSOMOSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Formquemsomos.ShowDialog()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub AJUDAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormConfig.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'deixar o form invisivel
        Me.Hide()
        'Não mostra na barra de tarefa
        Me.ShowInTaskbar = False
        'Mensagem balão!
        'NotifyIcon1.ShowBalloonTip(1)
        'NotifyIcon1.BalloonTipTitle = "Ola"
        'NotifyIcon1.BalloonTipText = "Ocuntar"


        'o form load ja inicia e começa gravando a desktop
        On Error Resume Next

        If btgravar.Text = "Gravar" Then
            For Each Str As String In IO.Directory.EnumerateFiles(Application.StartupPath & "\Bibliotecas\Imagens\", "*.png", IO.SearchOption.TopDirectoryOnly)
                Kill(Str)

            Next

            BackgroundWorker1.RunWorkerAsync()
            btgravar.Text = "Parar"

        Else
            BackgroundWorker1.CancelAsync()
            btgravar.Text = "Gravar"


        End If




    End Sub

    Private Sub AbrirProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirProgramaToolStripMenuItem.Click
        FormLogin.ShowDialog()


        'CHAMA form1
        'Me.Visible = True



    End Sub

    Private Sub DesligarFecharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesligarFecharToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked




    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub QUEMSOMOSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QUEMSOMOSToolStripMenuItem.Click
        Formquemsomos.ShowDialog()

    End Sub

    Private Sub CONFIGURAÇÃOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONFIGURAÇÃOToolStripMenuItem.Click
        FormConfig.ShowDialog()

    End Sub

    Private Sub btIniciargravacao_Click(sender As Object, e As EventArgs)
        'deixar o form invisivel
        Me.Hide()
        'Não mostra na barra de tarefa
        Me.ShowInTaskbar = False
        'Mensagem balão!
        'NotifyIcon1.ShowBalloonTip(1)
        'NotifyIcon1.BalloonTipTitle = "Ola"
        'NotifyIcon1.BalloonTipText = "Ocuntar"

        'Desabilitar botão tbiniciargravação

        btgravar.Enabled = True

        'o form load ja inicia e começa gravando a desktop
        On Error Resume Next

        If btgravar.Text = "Gravar" Then
            For Each Str As String In IO.Directory.EnumerateFiles(Application.StartupPath & "\Bibliotecas\Imagens\", "*.png", IO.SearchOption.TopDirectoryOnly)
                Kill(Str)

            Next

            BackgroundWorker1.RunWorkerAsync()
            btgravar.Text = "Parar"

        Else
            BackgroundWorker1.CancelAsync()
            btgravar.Text = "Gravar"


        End If

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()



    End Sub

    Private Sub SOBREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOBREToolStripMenuItem.Click
        FormSobre.ShowDialog()

    End Sub
End Class
