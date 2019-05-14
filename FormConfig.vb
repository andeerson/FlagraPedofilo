Imports Microsoft.Win32

Public Class FormConfig

    Private Sub btIniciarWindows_Click(sender As Object, e As EventArgs) Handles btIniciarWindows.Click


        Dim RegKey As Microsoft.Win32.RegistryKey
        'aqui tenho  o caminho do registro
        Dim Keyname As String = "Software\Microsoft\Windows\Currentversion\Run"
        Dim Valuename As String = Form1.Text
        Dim Value As String = Application.ExecutablePath
        RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Keyname, True)
        RegKey.SetValue(Valuename, Value, RegistryValueKind.String)

        'Desabilitando btiniciarWindows
        btIniciarWindows.Enabled = False

        'Abilitando btnãoiniciar
        btNaoIniciarWindows.Enabled = True

        MsgBox("Configurado com Sucesso! O aplicativo ira iniciar com Windows!")



    End Sub

  

    Private Sub btNaoIniciarWindows_Click(sender As Object, e As EventArgs) Handles btNaoIniciarWindows.Click
        Dim RegKey As Microsoft.Win32.RegistryKey
        'aqui tenho  o caminho do registro
        Dim Keyname As String = "Software\Microsoft\Windows\Currentversion\Run"
        Dim Valuename As String = Form1.Text
        Dim Value As String = Application.ExecutablePath
        RegKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Keyname, True)
        RegKey.SetValue(Valuename, "", RegistryValueKind.String)

        'Abilitando btIniciarWindows
        btIniciarWindows.Enabled = True

        'Desabilitando btnãoIniciar
        btNaoIniciarWindows.Enabled = False

        MsgBox("Aplicativo desabilitado!")
    End Sub
End Class