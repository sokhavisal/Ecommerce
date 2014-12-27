<?php
     require_once __DIR__ .'/app/sys_const.php';
  require_once __DIR__ .'/common/com.php';
    $ArrCat=array ();
    $sql='SELECT mmenu_id, mmenu_name FROM main_menu WHERE ItemCatMainStatus = 1 ';
    $query= SQLQuery($sql);
$RowPos=0;
    for  ($i=0;$i<count($query);$i++) 
	
		 {
	$RowPos = $RowPos + 1;
                $row=$query[$i];
//	$json['records']['id'][$i]=$row['mmenu_id'];
//	$json['records']['MainCat'][$i]=$row['mmenu_id'];
	 $json['records'][]=(array(
		'id'=>$row["mmenu_id"],
		'MainCat'=>$row["mmenu_name"]
	    )
	    );
	
    }
    //$ArrCat=[$id,$MainCat];
  echo json_encode($json);
?>
