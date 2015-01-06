<?php
    require_once __DIR__ .'/app/sys_const.php';
    require_once __DIR__ .'/common/com.php';
	mb_http_output('UTF-8');
	mysqli_query("set names utf8");
    $TableName=array(
	    
	        0 => 'cart',
		1 => 'jewellery',
		2 => 'main_menu',
		3 => 'sub_menu',
		4 => 'users',
		5 => 'webcontent'
    );
	$TableNo=filter_input(INPUT_GET, 'tbl', FILTER_SANITIZE_STRING);
	if($TableNo >=0 && $TableNo<=count($TableName)){
	    if(filter_input(INPUT_GET,'T',FILTER_SANITIZE_STRING)=='save'){
		if(isset($_POST['rows']) && isset($_POST['rows'][0]['fSubCat'])&&  isset($_POST['rows'][0]['itemcode']) ){
		    $records=$_POST['rows'][0];
			if($records['fSubCat']==" " || $records['fSubCat']=='undefined'){
			    echo 'Please select Category Item First.';
			}else {
			    $sql=" SELECT id FROM sub_menu where  smenu_name =  '".$records['fSubCat']."' AND mmenu_id = "  .$records['fMainCat'];
			    $subCatId=SQLQuery($sql);
			    
			    $sql=" INSERT INTO jewellery SET itemCode='".$records['itemcode']."', prodname='".$records['itemname']."',path='".$records['itemimageurl']."',category='".$subCatId[0]['id']."',price='".$records['itemprice']."',descr='".$records['itemdescription']."',type='".$records['itemtype']."'";
			     $subCatId=SQLQuery($sql);
			     echo $sql;
			}
		    
		}  else {
		   echo "Please Input All Your Information Product.";
		}
		
	    }
	}
?>
