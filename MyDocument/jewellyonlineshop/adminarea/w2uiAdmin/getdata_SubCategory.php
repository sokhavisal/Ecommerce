<?php
    include ("../includes/mysqli_connection.php");
    if (isset($_POST['rows'])){
    $MainCat = $_POST['rows'][0];
    }
    $sql='SELECT id, mmenu_id, smenu_name FROM sub_menu WHERE mmenu_id = '.$MainCat ;
    $query=  mysqli_query($db_conx,$sql);
$i=0;
    while($row = mysqli_fetch_array($query, MYSQLI_ASSOC))
    {
	$json['records']['id'][$i]=$row['id'];
	$json['records']['MainCatId'][$i]=$row['mmenu_id'];
	$json['records']['SubCatName'][$i]=$row['smenu_name'];
	    $i++;
	
    }
    //$ArrCat=[$id,$MainCat];
  echo json_encode($json);
?>
