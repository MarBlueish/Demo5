Imports System.Media
Imports MySql.Data.MySqlClient

Public Class LoginForm1
    Dim soundPlayer As New SoundPlayer()
    Dim connectionString As String = "server=127.0.0.1;userid=root;password='';database=test;"
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        soundPlayer.SoundLocation = "C:\Users\Marco\Desktop\Curso programação\UFCD VISUAL STUDIO\Demo5\music.wav"
        soundPlayer.Play()
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        conn = New MySqlConnection(connectionString)
        conn.Open()

        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password;"
        command = New MySqlCommand(query, conn)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)

        Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

        If result > 0 Then
            MessageBox.Show("Login bem-sucedido!", "Credenciais Corretas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Nome de usuário ou senha incorretos.", "Credenciais Incorretas", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        conn.Close()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
