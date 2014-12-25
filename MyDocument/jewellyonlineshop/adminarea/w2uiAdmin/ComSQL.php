<?php
    function func_getdataItems(){
	$sql="";
//	$sql.=" SELECT M.mmenu_id AS MainCatID, S.id AS SubCatID , M.mmenu_name, S.smenu_name, M.ItemCatMainStatus, S.smenu_link ";
//		$sql.= " , I.prodname, I.path, I.category, I.price , I.descr, I.type, I.noviews, I.topsell  ";
//		$sql.= " FROM main_menu  M ";
//		$sql.= " RIGHT JOIN ";
//		$sql.= " sub_menu S ON ";
//		$sql.= " M.mmenu_id= S.id ";
//		$sql.= " LEFT JOIN jewellery ON S.id= I.category ";
	$sql.=" SELECT ";
	    $sql.=" I.id, ";
	    $sql.=" S.mmenu_id AS MainCategory, ";
	    $sql.=" I.category, ";
	    $sql.=" M.mmenu_name AS MainCategory, ";
	    $sql.=" S.smenu_name AS SubCategory, ";
	    $sql.=" I.prodname AS ItemName , ";
	     $sql.=" I.price, ";
	     $sql.=" I.descr AS Description, ";
	    $sql.=" I.path, ";
	    $sql.=" I.type, ";
	    $sql.=" I.noviews, ";
	    $sql.=" I.topsell ";
	    
	 $sql.=" FROM sub_menu S  ";
	     $sql.=" inner JOIN jewellery I ON ";
	     $sql.=" I.category = S.id ";
	     $sql.=" LEFT JOIN main_menu M ON ";
	      $sql.=" M.mmenu_id= S.mmenu_id  ";
	return $sql;
	
    }



?>
