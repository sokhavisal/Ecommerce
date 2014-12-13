<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemNoAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemImagePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCatNoAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBarcodeNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBarcodeNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBarcodeNo3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBarcodeNo4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemUnitAuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemUnitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemCostType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemNameHtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDescriptionHtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDetailHtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemImagePathHtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemPriceHtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemIsStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemIsNew = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemIsDisplayWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.txtItemCodeSearch = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboCatagorySearch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtItemNameSearch = New System.Windows.Forms.TextBox()
        Me.chkItemIsStock = New System.Windows.Forms.CheckBox()
        Me.chkItemIsDisplayWeb = New System.Windows.Forms.CheckBox()
        Me.chkItemIsNew = New System.Windows.Forms.CheckBox()
        Me.txtItemOnhand = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItemOrder = New System.Windows.Forms.NumericUpDown()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboCostType = New System.Windows.Forms.ComboBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTabGeneral = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTabBarcode = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnTabHtml = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnTabOption = New System.Windows.Forms.Button()
        Me.btnWebCam = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemImgePath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.cboCatagory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddCatagory = New System.Windows.Forms.Button()
        Me.cboItemUnit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddUnit = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtBarcodeNo4 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtBarcodeNo3 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtBarcodeNo2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtBarcodeNo1 = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtItemDetailHtml = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtItemDetail = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtItemPriceHtml = New System.Windows.Forms.TextBox()
        Me.txtItemNameHtml = New System.Windows.Forms.TextBox()
        Me.txtItemDescriptionHtml = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colItemNoAuto, Me.colItemNo, Me.colItemName, Me.colItemDescription, Me.colItemDetail, Me.colItemImagePath, Me.colCatNoAuto, Me.colCategory, Me.colBarcodeNo1, Me.colBarcodeNo2, Me.colBarcodeNo3, Me.colBarcodeNo4, Me.colItemUnitAuto, Me.colItemUnitName, Me.colItemPrice, Me.colItemCost, Me.colItemOnHand, Me.colItemOrder, Me.colItemCostType, Me.colItemNameHtml, Me.colItemDescriptionHtml, Me.colItemDetailHtml, Me.colItemImagePathHtml, Me.colItemPriceHtml, Me.colItemIsStock, Me.colItemIsNew, Me.colItemIsDisplayWeb})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.Location = New System.Drawing.Point(3, 156)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(697, 503)
        Me.DataGridView1.TabIndex = 1
        '
        'colNo
        '
        Me.colNo.DataPropertyName = "row_number"
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 25
        '
        'colItemNoAuto
        '
        Me.colItemNoAuto.DataPropertyName = "ItemNoAuto"
        Me.colItemNoAuto.HeaderText = "ItemNoAuto"
        Me.colItemNoAuto.Name = "colItemNoAuto"
        Me.colItemNoAuto.ReadOnly = True
        '
        'colItemNo
        '
        Me.colItemNo.DataPropertyName = "ItemNo"
        Me.colItemNo.HeaderText = "Item No"
        Me.colItemNo.Name = "colItemNo"
        Me.colItemNo.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.DataPropertyName = "ItemName"
        Me.colItemName.HeaderText = "Item Name"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.ReadOnly = True
        '
        'colItemDescription
        '
        Me.colItemDescription.DataPropertyName = "ItemDescription"
        Me.colItemDescription.HeaderText = "Description"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.ReadOnly = True
        Me.colItemDescription.Width = 120
        '
        'colItemDetail
        '
        Me.colItemDetail.DataPropertyName = "ItemDetail"
        Me.colItemDetail.HeaderText = "ItemDetail"
        Me.colItemDetail.Name = "colItemDetail"
        Me.colItemDetail.ReadOnly = True
        '
        'colItemImagePath
        '
        Me.colItemImagePath.DataPropertyName = "ItemImagePath"
        Me.colItemImagePath.HeaderText = "ItemImagePath"
        Me.colItemImagePath.Name = "colItemImagePath"
        Me.colItemImagePath.ReadOnly = True
        '
        'colCatNoAuto
        '
        Me.colCatNoAuto.DataPropertyName = "CatNoAuto"
        Me.colCatNoAuto.HeaderText = "CatNoAuto"
        Me.colCatNoAuto.Name = "colCatNoAuto"
        Me.colCatNoAuto.ReadOnly = True
        '
        'colCategory
        '
        Me.colCategory.DataPropertyName = "CatName"
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.ReadOnly = True
        Me.colCategory.Width = 80
        '
        'colBarcodeNo1
        '
        Me.colBarcodeNo1.DataPropertyName = "BarcodeNo1"
        Me.colBarcodeNo1.HeaderText = "BarcodeNo1"
        Me.colBarcodeNo1.Name = "colBarcodeNo1"
        Me.colBarcodeNo1.ReadOnly = True
        '
        'colBarcodeNo2
        '
        Me.colBarcodeNo2.DataPropertyName = "BarcodeNo2"
        Me.colBarcodeNo2.HeaderText = "BarcodeNo2"
        Me.colBarcodeNo2.Name = "colBarcodeNo2"
        Me.colBarcodeNo2.ReadOnly = True
        '
        'colBarcodeNo3
        '
        Me.colBarcodeNo3.DataPropertyName = "BarcodeNo3"
        Me.colBarcodeNo3.HeaderText = "BarcodeNo3"
        Me.colBarcodeNo3.Name = "colBarcodeNo3"
        Me.colBarcodeNo3.ReadOnly = True
        '
        'colBarcodeNo4
        '
        Me.colBarcodeNo4.DataPropertyName = "BarcodeNo4"
        Me.colBarcodeNo4.HeaderText = "BarcodeNo4"
        Me.colBarcodeNo4.Name = "colBarcodeNo4"
        Me.colBarcodeNo4.ReadOnly = True
        '
        'colItemUnitAuto
        '
        Me.colItemUnitAuto.DataPropertyName = "ItemUnitAuto"
        Me.colItemUnitAuto.HeaderText = "ItemUnitAuto"
        Me.colItemUnitAuto.Name = "colItemUnitAuto"
        Me.colItemUnitAuto.ReadOnly = True
        '
        'colItemUnitName
        '
        Me.colItemUnitName.DataPropertyName = "ItemUnitName"
        Me.colItemUnitName.HeaderText = "ItemUnitName"
        Me.colItemUnitName.Name = "colItemUnitName"
        Me.colItemUnitName.ReadOnly = True
        '
        'colItemPrice
        '
        Me.colItemPrice.DataPropertyName = "ItemPrice"
        Me.colItemPrice.HeaderText = "Price"
        Me.colItemPrice.Name = "colItemPrice"
        Me.colItemPrice.ReadOnly = True
        Me.colItemPrice.Width = 50
        '
        'colItemCost
        '
        Me.colItemCost.DataPropertyName = "ItemCost"
        Me.colItemCost.HeaderText = "Cost"
        Me.colItemCost.Name = "colItemCost"
        Me.colItemCost.ReadOnly = True
        Me.colItemCost.Width = 50
        '
        'colItemOnHand
        '
        Me.colItemOnHand.DataPropertyName = "ItemOnhand"
        Me.colItemOnHand.HeaderText = "On hand"
        Me.colItemOnHand.Name = "colItemOnHand"
        Me.colItemOnHand.ReadOnly = True
        Me.colItemOnHand.Width = 80
        '
        'colItemOrder
        '
        Me.colItemOrder.DataPropertyName = "ItemOrder"
        Me.colItemOrder.HeaderText = "Order"
        Me.colItemOrder.Name = "colItemOrder"
        Me.colItemOrder.ReadOnly = True
        Me.colItemOrder.Width = 50
        '
        'colItemCostType
        '
        Me.colItemCostType.DataPropertyName = "ItemCostType"
        Me.colItemCostType.HeaderText = "ItemCostType"
        Me.colItemCostType.Name = "colItemCostType"
        Me.colItemCostType.ReadOnly = True
        '
        'colItemNameHtml
        '
        Me.colItemNameHtml.DataPropertyName = "ItemNameHtml"
        Me.colItemNameHtml.HeaderText = "ItemNameHtml"
        Me.colItemNameHtml.Name = "colItemNameHtml"
        Me.colItemNameHtml.ReadOnly = True
        '
        'colItemDescriptionHtml
        '
        Me.colItemDescriptionHtml.DataPropertyName = "ItemDescriptionHtml"
        Me.colItemDescriptionHtml.HeaderText = "ItemDescriptionHtml"
        Me.colItemDescriptionHtml.Name = "colItemDescriptionHtml"
        Me.colItemDescriptionHtml.ReadOnly = True
        '
        'colItemDetailHtml
        '
        Me.colItemDetailHtml.DataPropertyName = "ItemDetailHtml"
        Me.colItemDetailHtml.HeaderText = "ItemDetailHtml"
        Me.colItemDetailHtml.Name = "colItemDetailHtml"
        Me.colItemDetailHtml.ReadOnly = True
        '
        'colItemImagePathHtml
        '
        Me.colItemImagePathHtml.DataPropertyName = "ItemImagePathHtml"
        Me.colItemImagePathHtml.HeaderText = "ItemImagePathHtml"
        Me.colItemImagePathHtml.Name = "colItemImagePathHtml"
        Me.colItemImagePathHtml.ReadOnly = True
        '
        'colItemPriceHtml
        '
        Me.colItemPriceHtml.DataPropertyName = "ItemPriceHtml"
        Me.colItemPriceHtml.HeaderText = "ItemPriceHtml"
        Me.colItemPriceHtml.Name = "colItemPriceHtml"
        Me.colItemPriceHtml.ReadOnly = True
        '
        'colItemIsStock
        '
        Me.colItemIsStock.DataPropertyName = "ItemIsStock"
        Me.colItemIsStock.HeaderText = "ItemIsStock"
        Me.colItemIsStock.Name = "colItemIsStock"
        Me.colItemIsStock.ReadOnly = True
        '
        'colItemIsNew
        '
        Me.colItemIsNew.DataPropertyName = "ItemIsNew"
        Me.colItemIsNew.HeaderText = "ItemIsNew"
        Me.colItemIsNew.Name = "colItemIsNew"
        Me.colItemIsNew.ReadOnly = True
        '
        'colItemIsDisplayWeb
        '
        Me.colItemIsDisplayWeb.DataPropertyName = "ItemIsDisplayweb"
        Me.colItemIsDisplayWeb.HeaderText = "ItemIsDisplayWeb"
        Me.colItemIsDisplayWeb.Name = "colItemIsDisplayWeb"
        Me.colItemIsDisplayWeb.ReadOnly = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Image = Global.MainMenuBlue.My.Resources.Resources.close32x32
        Me.btnClose.Location = New System.Drawing.Point(628, 89)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 58)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImport.Image = Global.MainMenuBlue.My.Resources.Resources.Import32x32
        Me.btnImport.Location = New System.Drawing.Point(484, 89)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(72, 58)
        Me.btnImport.TabIndex = 35
        Me.btnImport.Text = "Import"
        Me.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 118)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 22)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Category"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExport.Image = Global.MainMenuBlue.My.Resources.Resources.Export32x32
        Me.btnExport.Location = New System.Drawing.Point(412, 89)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(72, 58)
        Me.btnExport.TabIndex = 34
        Me.btnExport.Text = "Export"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'txtItemCodeSearch
        '
        Me.txtItemCodeSearch.Location = New System.Drawing.Point(70, 48)
        Me.txtItemCodeSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCodeSearch.Name = "txtItemCodeSearch"
        Me.txtItemCodeSearch.Size = New System.Drawing.Size(179, 30)
        Me.txtItemCodeSearch.TabIndex = 29
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Image = Global.MainMenuBlue.My.Resources.Resources.Printer32x32
        Me.btnPrint.Location = New System.Drawing.Point(556, 89)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 58)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearch.Image = Global.MainMenuBlue.My.Resources.Resources.search32x323
        Me.btnSearch.Location = New System.Drawing.Point(340, 89)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 58)
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboCatagorySearch
        '
        Me.cboCatagorySearch.FormattingEnabled = True
        Me.cboCatagorySearch.Items.AddRange(New Object() {"Samsung", "Iphone", "HTC", "Sony", "LG", "Blackberry"})
        Me.cboCatagorySearch.Location = New System.Drawing.Point(70, 115)
        Me.cboCatagorySearch.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCatagorySearch.Name = "cboCatagorySearch"
        Me.cboCatagorySearch.Size = New System.Drawing.Size(179, 30)
        Me.cboCatagorySearch.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 50)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 22)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Item Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 84)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 22)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Item Name"
        '
        'txtItemNameSearch
        '
        Me.txtItemNameSearch.Location = New System.Drawing.Point(70, 81)
        Me.txtItemNameSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemNameSearch.Name = "txtItemNameSearch"
        Me.txtItemNameSearch.Size = New System.Drawing.Size(179, 30)
        Me.txtItemNameSearch.TabIndex = 27
        '
        'chkItemIsStock
        '
        Me.chkItemIsStock.AutoSize = True
        Me.chkItemIsStock.Location = New System.Drawing.Point(9, 14)
        Me.chkItemIsStock.Margin = New System.Windows.Forms.Padding(2)
        Me.chkItemIsStock.Name = "chkItemIsStock"
        Me.chkItemIsStock.Size = New System.Drawing.Size(80, 26)
        Me.chkItemIsStock.TabIndex = 27
        Me.chkItemIsStock.Text = "Stock Item"
        Me.chkItemIsStock.UseVisualStyleBackColor = True
        '
        'chkItemIsDisplayWeb
        '
        Me.chkItemIsDisplayWeb.AutoSize = True
        Me.chkItemIsDisplayWeb.Location = New System.Drawing.Point(108, 38)
        Me.chkItemIsDisplayWeb.Margin = New System.Windows.Forms.Padding(2)
        Me.chkItemIsDisplayWeb.Name = "chkItemIsDisplayWeb"
        Me.chkItemIsDisplayWeb.Size = New System.Drawing.Size(122, 26)
        Me.chkItemIsDisplayWeb.TabIndex = 22
        Me.chkItemIsDisplayWeb.Text = "Display On Website"
        Me.chkItemIsDisplayWeb.UseVisualStyleBackColor = True
        '
        'chkItemIsNew
        '
        Me.chkItemIsNew.AutoSize = True
        Me.chkItemIsNew.Location = New System.Drawing.Point(9, 38)
        Me.chkItemIsNew.Margin = New System.Windows.Forms.Padding(2)
        Me.chkItemIsNew.Name = "chkItemIsNew"
        Me.chkItemIsNew.Size = New System.Drawing.Size(74, 26)
        Me.chkItemIsNew.TabIndex = 1
        Me.chkItemIsNew.Text = "New Item"
        Me.chkItemIsNew.UseVisualStyleBackColor = True
        '
        'txtItemOnhand
        '
        Me.txtItemOnhand.Location = New System.Drawing.Point(80, 355)
        Me.txtItemOnhand.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemOnhand.Name = "txtItemOnhand"
        Me.txtItemOnhand.Size = New System.Drawing.Size(163, 30)
        Me.txtItemOnhand.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 359)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "On Hand"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 324)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Order"
        '
        'txtItemOrder
        '
        Me.txtItemOrder.Location = New System.Drawing.Point(80, 322)
        Me.txtItemOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemOrder.Name = "txtItemOrder"
        Me.txtItemOrder.Size = New System.Drawing.Size(83, 30)
        Me.txtItemOrder.TabIndex = 1
        '
        'txtItemCost
        '
        Me.txtItemCost.Location = New System.Drawing.Point(80, 289)
        Me.txtItemCost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(163, 30)
        Me.txtItemCost.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 293)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 260)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 22)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cost Type"
        '
        'cboCostType
        '
        Me.cboCostType.FormattingEnabled = True
        Me.cboCostType.Items.AddRange(New Object() {"Fix Cost", "FIFO", "LIFO", "AVG"})
        Me.cboCostType.Location = New System.Drawing.Point(80, 256)
        Me.cboCostType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCostType.Name = "cboCostType"
        Me.cboCostType.Size = New System.Drawing.Size(163, 30)
        Me.cboCostType.TabIndex = 15
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(80, 223)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(163, 30)
        Me.txtItemPrice.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 227)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Price"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.btnTabGeneral)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnTabBarcode)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnTabHtml)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnTabOption)
        Me.Panel1.Controls.Add(Me.btnWebCam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 661)
        Me.Panel1.TabIndex = 3
        '
        'btnTabGeneral
        '
        Me.btnTabGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTabGeneral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTabGeneral.Image = Global.MainMenuBlue.My.Resources.Resources.Printer32x32
        Me.btnTabGeneral.Location = New System.Drawing.Point(3, 543)
        Me.btnTabGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTabGeneral.Name = "btnTabGeneral"
        Me.btnTabGeneral.Size = New System.Drawing.Size(72, 58)
        Me.btnTabGeneral.TabIndex = 37
        Me.btnTabGeneral.Text = "General"
        Me.btnTabGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTabGeneral.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 37)
        Me.Panel4.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(4, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 16)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Inventory info"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Image = Global.MainMenuBlue.My.Resources.Resources.save32x32
        Me.btnSave.Location = New System.Drawing.Point(219, 602)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 58)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnTabBarcode
        '
        Me.btnTabBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTabBarcode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTabBarcode.Image = Global.MainMenuBlue.My.Resources.Resources.Barcode32x32
        Me.btnTabBarcode.Location = New System.Drawing.Point(219, 543)
        Me.btnTabBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTabBarcode.Name = "btnTabBarcode"
        Me.btnTabBarcode.Size = New System.Drawing.Size(72, 58)
        Me.btnTabBarcode.TabIndex = 30
        Me.btnTabBarcode.Text = "Barcode"
        Me.btnTabBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTabBarcode.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Image = Global.MainMenuBlue.My.Resources.Resources.delete32x323
        Me.btnDelete.Location = New System.Drawing.Point(147, 602)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 58)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnTabHtml
        '
        Me.btnTabHtml.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTabHtml.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTabHtml.Image = Global.MainMenuBlue.My.Resources.Resources.details32x32
        Me.btnTabHtml.Location = New System.Drawing.Point(75, 543)
        Me.btnTabHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTabHtml.Name = "btnTabHtml"
        Me.btnTabHtml.Size = New System.Drawing.Size(72, 58)
        Me.btnTabHtml.TabIndex = 28
        Me.btnTabHtml.Text = "Html"
        Me.btnTabHtml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTabHtml.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEdit.Image = Global.MainMenuBlue.My.Resources.Resources.Edit32x32
        Me.btnEdit.Location = New System.Drawing.Point(75, 602)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 58)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNew.Image = Global.MainMenuBlue.My.Resources.Resources.Add32x322
        Me.btnNew.Location = New System.Drawing.Point(3, 602)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(72, 58)
        Me.btnNew.TabIndex = 23
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnTabOption
        '
        Me.btnTabOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTabOption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTabOption.Image = Global.MainMenuBlue.My.Resources.Resources.option32x32
        Me.btnTabOption.Location = New System.Drawing.Point(147, 543)
        Me.btnTabOption.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTabOption.Name = "btnTabOption"
        Me.btnTabOption.Size = New System.Drawing.Size(72, 58)
        Me.btnTabOption.TabIndex = 27
        Me.btnTabOption.Text = "Option"
        Me.btnTabOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTabOption.UseVisualStyleBackColor = True
        '
        'btnWebCam
        '
        Me.btnWebCam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWebCam.Image = Global.MainMenuBlue.My.Resources.Resources.cinema
        Me.btnWebCam.Location = New System.Drawing.Point(6, 89)
        Me.btnWebCam.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWebCam.Name = "btnWebCam"
        Me.btnWebCam.Size = New System.Drawing.Size(72, 58)
        Me.btnWebCam.TabIndex = 0
        Me.btnWebCam.Text = "Web Cam"
        Me.btnWebCam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnWebCam.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Image (150px * 150px)"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MainMenuBlue.My.Resources.Resources._62786_1
        Me.PictureBox1.Location = New System.Drawing.Point(168, 36)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnBrowse)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtItemImgePath)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtItemName)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtItemDescription)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtItemOnhand)
        Me.Panel5.Controls.Add(Me.txtItemNo)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.cboCatagory)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtItemOrder)
        Me.Panel5.Controls.Add(Me.btnAddCatagory)
        Me.Panel5.Controls.Add(Me.txtItemCost)
        Me.Panel5.Controls.Add(Me.cboItemUnit)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.btnAddUnit)
        Me.Panel5.Controls.Add(Me.cboCostType)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtItemPrice)
        Me.Panel5.Location = New System.Drawing.Point(0, 151)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 390)
        Me.Panel5.TabIndex = 37
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(230, 6)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(54, 27)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Image Path"
        '
        'txtItemImgePath
        '
        Me.txtItemImgePath.Location = New System.Drawing.Point(80, 5)
        Me.txtItemImgePath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemImgePath.Name = "txtItemImgePath"
        Me.txtItemImgePath.Size = New System.Drawing.Size(146, 30)
        Me.txtItemImgePath.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item Name"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(80, 71)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(210, 30)
        Me.txtItemName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(80, 104)
        Me.txtItemDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(210, 50)
        Me.txtItemDescription.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 41)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Item Code"
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(80, 38)
        Me.txtItemNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(146, 30)
        Me.txtItemNo.TabIndex = 6
        '
        'cboCatagory
        '
        Me.cboCatagory.FormattingEnabled = True
        Me.cboCatagory.Items.AddRange(New Object() {"Samsung", "Iphone", "HTC", "Sony", "LG", "Blackberry"})
        Me.cboCatagory.Location = New System.Drawing.Point(80, 157)
        Me.cboCatagory.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCatagory.Name = "cboCatagory"
        Me.cboCatagory.Size = New System.Drawing.Size(163, 30)
        Me.cboCatagory.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 161)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Category"
        '
        'btnAddCatagory
        '
        Me.btnAddCatagory.Location = New System.Drawing.Point(252, 158)
        Me.btnAddCatagory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddCatagory.Name = "btnAddCatagory"
        Me.btnAddCatagory.Size = New System.Drawing.Size(39, 28)
        Me.btnAddCatagory.TabIndex = 9
        Me.btnAddCatagory.Text = "Add"
        Me.btnAddCatagory.UseVisualStyleBackColor = True
        '
        'cboItemUnit
        '
        Me.cboItemUnit.FormattingEnabled = True
        Me.cboItemUnit.Items.AddRange(New Object() {"pcs", "set", "box"})
        Me.cboItemUnit.Location = New System.Drawing.Point(80, 190)
        Me.cboItemUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.cboItemUnit.Name = "cboItemUnit"
        Me.cboItemUnit.Size = New System.Drawing.Size(163, 30)
        Me.cboItemUnit.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Unit"
        '
        'btnAddUnit
        '
        Me.btnAddUnit.Location = New System.Drawing.Point(252, 191)
        Me.btnAddUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddUnit.Name = "btnAddUnit"
        Me.btnAddUnit.Size = New System.Drawing.Size(39, 28)
        Me.btnAddUnit.TabIndex = 12
        Me.btnAddUnit.Text = "Add"
        Me.btnAddUnit.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.chkItemIsDisplayWeb)
        Me.Panel6.Controls.Add(Me.chkItemIsNew)
        Me.Panel6.Controls.Add(Me.chkItemIsStock)
        Me.Panel6.Location = New System.Drawing.Point(0, 151)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(296, 390)
        Me.Panel6.TabIndex = 37
        Me.Panel6.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label26)
        Me.Panel8.Controls.Add(Me.txtBarcodeNo4)
        Me.Panel8.Controls.Add(Me.Label25)
        Me.Panel8.Controls.Add(Me.txtBarcodeNo3)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Controls.Add(Me.txtBarcodeNo2)
        Me.Panel8.Controls.Add(Me.Label23)
        Me.Panel8.Controls.Add(Me.txtBarcodeNo1)
        Me.Panel8.Location = New System.Drawing.Point(0, 151)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(296, 390)
        Me.Panel8.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 109)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 22)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Barcode No4"
        '
        'txtBarcodeNo4
        '
        Me.txtBarcodeNo4.Location = New System.Drawing.Point(91, 106)
        Me.txtBarcodeNo4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcodeNo4.Name = "txtBarcodeNo4"
        Me.txtBarcodeNo4.Size = New System.Drawing.Size(200, 30)
        Me.txtBarcodeNo4.TabIndex = 36
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 76)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 22)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Barcode No3"
        '
        'txtBarcodeNo3
        '
        Me.txtBarcodeNo3.Location = New System.Drawing.Point(91, 73)
        Me.txtBarcodeNo3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcodeNo3.Name = "txtBarcodeNo3"
        Me.txtBarcodeNo3.Size = New System.Drawing.Size(200, 30)
        Me.txtBarcodeNo3.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 42)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 22)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "Barcode No2"
        '
        'txtBarcodeNo2
        '
        Me.txtBarcodeNo2.Location = New System.Drawing.Point(91, 39)
        Me.txtBarcodeNo2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcodeNo2.Name = "txtBarcodeNo2"
        Me.txtBarcodeNo2.Size = New System.Drawing.Size(200, 30)
        Me.txtBarcodeNo2.TabIndex = 32
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 8)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 22)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Barcode No1"
        '
        'txtBarcodeNo1
        '
        Me.txtBarcodeNo1.Location = New System.Drawing.Point(91, 5)
        Me.txtBarcodeNo1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcodeNo1.Name = "txtBarcodeNo1"
        Me.txtBarcodeNo1.Size = New System.Drawing.Size(200, 30)
        Me.txtBarcodeNo1.TabIndex = 30
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtItemDetailHtml)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.txtItemDetail)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.txtItemPriceHtml)
        Me.Panel7.Controls.Add(Me.txtItemNameHtml)
        Me.Panel7.Controls.Add(Me.txtItemDescriptionHtml)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Location = New System.Drawing.Point(0, 151)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(296, 390)
        Me.Panel7.TabIndex = 37
        Me.Panel7.Visible = False
        '
        'txtItemDetailHtml
        '
        Me.txtItemDetailHtml.Location = New System.Drawing.Point(91, 165)
        Me.txtItemDetailHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemDetailHtml.Multiline = True
        Me.txtItemDetailHtml.Name = "txtItemDetailHtml"
        Me.txtItemDetailHtml.Size = New System.Drawing.Size(199, 72)
        Me.txtItemDetailHtml.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 168)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 22)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Detail html"
        '
        'txtItemDetail
        '
        Me.txtItemDetail.Location = New System.Drawing.Point(91, 91)
        Me.txtItemDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemDetail.Multiline = True
        Me.txtItemDetail.Name = "txtItemDetail"
        Me.txtItemDetail.Size = New System.Drawing.Size(199, 72)
        Me.txtItemDetail.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 93)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 22)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Detail"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 242)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 22)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Price html"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 8)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 22)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Item Name html"
        '
        'txtItemPriceHtml
        '
        Me.txtItemPriceHtml.Location = New System.Drawing.Point(91, 239)
        Me.txtItemPriceHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemPriceHtml.Name = "txtItemPriceHtml"
        Me.txtItemPriceHtml.Size = New System.Drawing.Size(135, 30)
        Me.txtItemPriceHtml.TabIndex = 22
        '
        'txtItemNameHtml
        '
        Me.txtItemNameHtml.Location = New System.Drawing.Point(91, 5)
        Me.txtItemNameHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemNameHtml.Name = "txtItemNameHtml"
        Me.txtItemNameHtml.Size = New System.Drawing.Size(199, 30)
        Me.txtItemNameHtml.TabIndex = 22
        '
        'txtItemDescriptionHtml
        '
        Me.txtItemDescriptionHtml.Location = New System.Drawing.Point(91, 38)
        Me.txtItemDescriptionHtml.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItemDescriptionHtml.Multiline = True
        Me.txtItemDescriptionHtml.Name = "txtItemDescriptionHtml"
        Me.txtItemDescriptionHtml.Size = New System.Drawing.Size(199, 50)
        Me.txtItemDescriptionHtml.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 41)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 22)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Description html"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btnImport)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.btnExport)
        Me.Panel2.Controls.Add(Me.txtItemNameSearch)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtItemCodeSearch)
        Me.Panel2.Controls.Add(Me.cboCatagorySearch)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Location = New System.Drawing.Point(302, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 661)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(702, 37)
        Me.Panel3.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(4, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 16)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Search"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1008, 665)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.MinimumSize = New System.Drawing.Size(1024, 703)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTabBarcode As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnTabHtml As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents txtItemCodeSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboCatagorySearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtItemNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnTabOption As System.Windows.Forms.Button
    Friend WithEvents chkItemIsStock As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents chkItemIsDisplayWeb As System.Windows.Forms.CheckBox
    Friend WithEvents chkItemIsNew As System.Windows.Forms.CheckBox
    Friend WithEvents txtItemOnhand As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtItemOrder As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtItemCost As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboCostType As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAddUnit As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboItemUnit As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddCatagory As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCatagory As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtItemImgePath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnWebCam As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnTabGeneral As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtItemDetailHtml As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtItemDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtItemPriceHtml As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNameHtml As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDescriptionHtml As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeNo4 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeNo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeNo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtBarcodeNo1 As System.Windows.Forms.TextBox
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemNoAuto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemImagePath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCatNoAuto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarcodeNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarcodeNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarcodeNo3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarcodeNo4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemUnitAuto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemUnitName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemOnHand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemCostType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemNameHtml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDescriptionHtml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDetailHtml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemImagePathHtml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemPriceHtml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemIsStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemIsNew As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemIsDisplayWeb As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
