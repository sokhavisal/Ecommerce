Public Class frmInventory
    Dim cls As New ComSQL

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnTabGeneral.Click
        Panel5.Visible = True
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnTabOption.Click
        Panel5.Visible = False
        Panel6.Visible = True
        Panel7.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnTabHtml.Click
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = True
        Panel8.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnTabBarcode.Click
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel8.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dt1 As New DataTable
        'dt.Clear()
        Dim sql As String = cls.SELECTDATAITEMS()
        dt1 = SQLQuery(sql)

        DataGridView1.DataSource = dt1
        NumberAllRows()
    End Sub
    Private Sub NumberAllRows()
        ' Add row headers.
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).HeaderCell.Value = i + 1.ToString()
            DataGridView1.Rows(i).Cells(0).Value = i + 1.ToString()
            'DataGridView1.Rows(i).Cells(0).Style.BackColor = Color.Silver
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If

        Next i
    End Sub

    Private Sub ClearData()
        txtItemImgePath.Text = ""
        txtItemNo.Text = ""
        txtItemName.Text = ""
        txtItemDescription.Text = ""
        cboCatagory.SelectedIndex = -1
        cboItemUnit.SelectedIndex = -1
        txtItemPrice.Text = 0
        cboCostType.SelectedIndex = -1
        txtItemCost.Text = 0
        txtItemOrder.Value = 0
        txtItemOnhand.Text = 0
        txtBarcodeNo1.Text = ""
        txtBarcodeNo2.Text = ""
        txtBarcodeNo3.Text = ""
        txtBarcodeNo4.Text = ""
        txtItemNameHtml.Text = ""
        txtItemDescriptionHtml.Text = ""
        txtItemDetail.Text = ""
        txtItemDetailHtml.Text = ""
        txtItemPriceHtml.Text = ""

    End Sub
   
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String = cls.INSERTDATAITEMS()
        SQLExecute(sql)
    End Sub
End Class