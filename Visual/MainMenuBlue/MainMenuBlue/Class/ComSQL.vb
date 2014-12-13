Public Class ComSQL
    Function SELECTDATAITEMS(Optional WHERE As String = "")
        Dim SQL As String = ""
        If WHERE <> "" Then WHERE = " WHERE " & WHERE
        SQL = "SELECT ItemNoAuto, ItemNo, ItemName, ItemDescription, ItemDetail, ItemImagePath,"
        SQL &= "CatNoAuto, CatName, BarcodeNo1, BarcodeNo2, BarcodeNo3, BarcodeNo4, ItemUnitAuto,"
        SQL &= "ItemUnitName, ItemPrice, ItemCost, ItemOrder, ItemOnhand, ItemCostType, ItemNameHtml,"
        SQL &= "ItemDescriptionHtml, ItemDetailHtml, ItemImagePathHtml, ItemPriceHtml, ItemIsStock,"
        SQL &= "ItemIsNew, ItemIsDisplayWeb FROM " & T_Item
        SQL &= WHERE
        Return SQL
    End Function
    Function INSERTDATAITEMS(Optional WHERE As String = "")
        Dim SQL As String = ""
        If WHERE <> "" Then WHERE = " WHERE " & WHERE
        SQL = "INSERT INTO " & T_Item & " SET (ItemNoAuto, ItemNo, ItemName, ItemDescription, ItemDetail, ItemImagePath,"
        SQL &= "CatNoAuto, CatName, BarcodeNo1, BarcodeNo2, BarcodeNo3, BarcodeNo4, ItemUnitAuto,"
        SQL &= "ItemUnitName, ItemPrice, ItemCost, ItemOrder, ItemOnhand, ItemCostType, ItemNameHtml,"
        SQL &= "ItemDescriptionHtml, ItemDetailHtml, ItemImagePathHtml, ItemPriceHtml, ItemIsStock,"
        SQL &= "ItemIsNew, ItemIsDisplayWeb) VALUES (ItemNoAuto, ItemNo, ItemName, ItemDescription, ItemDetail, ItemImagePath,"
        SQL &= "CatNoAuto, CatName, BarcodeNo1, BarcodeNo2, BarcodeNo3, BarcodeNo4, ItemUnitAuto,"
        SQL &= "ItemUnitName, ItemPrice, ItemCost, ItemOrder, ItemOnhand, ItemCostType, ItemNameHtml,"
        SQL &= "ItemDescriptionHtml, ItemDetailHtml, ItemImagePathHtml, ItemPriceHtml, ItemIsStock,"
        SQL &= "ItemIsNew, ItemIsDisplayWeb)"
        SQL &= WHERE
        Return SQL
    End Function
End Class
