Public Class Form2
    Dim Current_image As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next

        If IO.File.Exists(Application.StartupPath & "\Bibliotecas\Imagens\" & Current_image & ".png") = True Then
            Dim Bmp As New Bitmap(Application.StartupPath & "\Bibliotecas\Imagens\" & Current_image & ".png")
            PictureBox1.BackgroundImage = Bmp

        Else
            Me.Dispose()

            MessageBox.Show("O seu filme terminou, se for necessário assista novamente!", "Video", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Form1.Close()
            Exit Sub


        End If

        Current_image += 1

    End Sub

   
    Private Sub btAssistir_Click(sender As Object, e As EventArgs) Handles btAssistir.Click
        On Error Resume Next

        If btAssistir.Text = "Assistir" Then
            Current_image = 0
            Timer1.Start()
            btAssistir.Text = "Parar"
        Else
            Timer1.Stop()
            btAssistir.Text = "Assistir"


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class