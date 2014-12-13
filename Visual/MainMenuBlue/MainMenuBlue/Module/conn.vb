Imports MySql.Data.MySqlClient
Module conn
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable

    Dim SQL As String
    Dim Server As String = "localhost"
    Dim UserID As String = "root"
    Dim Password As String = "123456"
    Dim Database As String = "POS_DW"

    Public T_Catagory As String = "tbl_Catagory"
    Public T_Item As String = "tbl_Items"
    Public T_Unit As String = "tbl_Unit"

    Sub TestConn()
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & Server & ";" _
        & "user id=" & UserID & ";" _
        & "password=" & Password & ";"
        Try

            conn.Open()

            MessageBox.Show("Connection to Database has been opened.")

            conn.Close()

        Catch myerror As MySqlException

            MessageBox.Show("Cannot connect to database: " & myerror.Message)

        Finally

            conn.Dispose()

        End Try
    End Sub

    Function SQLExecute(sql As String)
        Dim retValue As Boolean = True
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & Server & ";" _
        & "user id=" & UserID & ";" _
        & "password=" & Password & ";" _
        & "database=" & Database & ""
        Try
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Execute to Database has succesful.")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
            retValue = False
        Finally
            conn.Dispose()
        End Try

        Return retValue
    End Function

    Function SQLQuery(sql As String)
        Dim retValue As Boolean = True
        conn = New MySqlConnection()
        conn.ConnectionString = "server=" & Server & ";" _
        & "user id=" & UserID & ";" _
        & "password=" & Password & ";" _
        & "database=" & Database & ""
        Try
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
            MessageBox.Show("Execute to Database has succesful.")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
            retValue = False
        Finally
            conn.Dispose()
        End Try

        Return retValue
    End Function

End Module
