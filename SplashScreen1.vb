Imports System.Media

Public Class SplashScreen1
    Dim soundPlayer As New SoundPlayer()
    Dim timer As New Timer()

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        soundPlayer.SoundLocation = "C:\Users\Marco\Desktop\Curso programação\UFCD VISUAL STUDIO\Demo5\music.wav"
        soundPlayer.Play()

        timer.Interval = 3000
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Stop the timer
        timer.Stop()

        ' Close the splash screen form
        Me.Hide()
        LoginForm1.Show()


    End Sub

    
End Class
