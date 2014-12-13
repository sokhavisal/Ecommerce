Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection 
    Dim ContactsCommand As New MySqlCommand
    Dim ContactsAdapter As New MySqlDataAdapter
    Dim ContactsData As New DataTable
    Dim SQL As String


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=" & txtServer.Text & ";" _
        & "user id=" & txtUsername.Text & ";" _
        & "password=" & txtPassword.Text & ";" _
        & "database=test"
        Try

            MysqlConn.Open()

            MessageBox.Show("Connection to Database has been opened.")

            MysqlConn.Close()

        Catch myerror As MySqlException

            MessageBox.Show("Cannot connect to database: " & myerror.Message)

        Finally

            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub View_Click(sender As Object, e As EventArgs) Handles View.Click
        ' MysqlConn = New MySqlConnection()



        ' ' Define the SQL to grab data from table.

        ' Sql = "SELECT * FROM " & txtTable.Text & ""



        ' 'Connection String

        'MysqlConn = New MySqlConnection()
        ' MysqlConn.ConnectionString = "server=" & txtServer.Text & ";" _
        ' & "user id=" & txtUsername.Text & ";" _
        ' & "password=" & txtPassword.Text & ";" _
        ' & "database=" & txtDatabase.Text & ""



        ' ' Try, Catch, Finally

        ' Try

        '     MysqlConn.Open()



        '     ContactsCommand.Connection = MysqlConn

        '     ContactsCommand.CommandText = Sql



        '     ContactsAdapter.SelectCommand = ContactsCommand

        '     ContactsAdapter.Fill(ContactsData)



        '     DataGridView1.DataSource = ContactsData



        ' Catch myerror As MySqlException

        '     MessageBox.Show("Cannot connect to database: " & myerror.Message)

        ' Finally

        '     MysqlConn.Close()

        '     MysqlConn.Dispose()

        ' End Try
        Dim dt As New DataTable
        dt = SQLQuery("SELECT * FROM tbl_Catagory")
        DataGridView1.DataSource = dt
    End Sub
End Class
