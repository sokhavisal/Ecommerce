<?php
    include ("../includes/mysqli_connection.php");
    $ArrCat=array ();
    $sql='SELECT mmenu_id, mmenu_name FROM main_menu WHERE ItemCatMainStatus = 1 ';
    $query=  mysqli_query($db_conx,$sql);
$i=0;
    while($row = mysqli_fetch_array($query, MYSQLI_ASSOC))
    {
//	$json['records'][]=(array(
//	    'id'=>$row['mmenu_id'],
//	    'MainCat'=>$row['mmenu_name'] 
//		));
	
	$json['records']['id'][$i]=$row['mmenu_id'];
	$json['records']['MainCat'][$i]=$row['mmenu_name'];
	    $i++;
	
    }
    //$ArrCat=[$id,$MainCat];
  echo json_encode($json);
?>
