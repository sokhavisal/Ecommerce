Public Class frmMainMenuBlue

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmInventory
        frm.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Dim frm As New Form1
        'frm.Show()
        'TestConn()
        'SQLExecute("INSERT INTO tbl_Catagory (CatNo,CatName,CatDescription) VALUES ('SS','Samsung','Made in japan')")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form2.Show()
    End Sub
End Class
