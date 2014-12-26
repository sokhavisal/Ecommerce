<?php
    require_once __DIR__ .'/app/sys_const.php';
  require_once __DIR__ .'/common/com.php';
    if (isset($_POST['rows'])){
    $MainCat = $_POST['rows'][0];
    }
    $sql='SELECT id, mmenu_id, smenu_name FROM sub_menu WHERE mmenu_id = '.$MainCat ;
    $query= SQLQuery($sql);
$RowPos=0;
 for  ($i=0;$i<count($query);$i++) 
	
{
		$RowPos = $RowPos + 1;
                $row=$query[$i];
		    $json['records']['id'][$i]=$row['id'];
		    $json['records']['MainCatId'][$i]=$row['mmenu_id'];
		    $json['records']['SubCatName'][$i]=$row['smenu_name'];
	
	
}
    //$ArrCat=[$id,$MainCat];
  echo json_encode($json);
?>
