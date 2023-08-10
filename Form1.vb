Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub cmdTeste_Click(sender As Object, e As EventArgs) Handles cmdTeste.Click
        conn = New MySqlConnection
        'conn.ConnectionString ="server =localhost;userid;root;password=root;database=test"
        conn.ConnectionString = "server= 127.0.0.1; userid=root; password=''; database= test"
        Try
            conn.Open()
            MessageBox.Show("Ligação à BD com sucesso", "Teste de acesso à BD")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "SELECT Nome, Idade, Clube, Posicao FROM jogadores_franca;"

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            command = New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "SELECT Nome, Idade, Clube, Posicao FROM jogadores_espanha;"

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            command = New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As String = "SELECT Nome, Idade, Clube, Posicao FROM jogadores_portugal;"

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            command = New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "SELECT Nome, Idade, Clube, Posicao FROM jogadores_brasil;"

        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            command = New MySqlCommand(query, conn)

            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class