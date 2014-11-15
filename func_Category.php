
<!-- <head>
        <meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="css/css.css">
	<script src="js/js.js"></script>
	<link rel="stylesheet" href="css/styles.css">
	<script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
	<script src="js/script.js"></script>
        <title>Mywebsite</title>
    </head>-->
<?php
include ("Cofig_Connection/mysqli_connection.php");

    $sql="SELECT productLine  FROM productlines ";
	$main_menu_result = mysqli_query($con,$sql);
	
	

	$htmlCateogry='';
	$htmlCateogry.='';
	
$htmlCateogry.="<div id='cssmenu'>";
$htmlCateogry.="<ul>";
$htmlCateogry.="<li class='active'><a href='#'><span>Category Product</span></a></li>";
while($r = mysqli_fetch_array($main_menu_result))
	     {
	//echo $r['']
 $htmlCateogry.="<li class='has-sub'><a href='#'><span>".$r['productLine']."</span></a>";
	     }
//$htmlCateogry.="<ul>";
//$htmlCateogry.="<li><a href='#'><span>Product 1</span></a></li>";
//$htmlCateogry.="<li><a href='#'><span>Product 2</span></a></li>";
//$htmlCateogry.="<li class='last'><a href='#'><span>Product 3</span></a></li>";
//$htmlCateogry.="</ul>";
$htmlCateogry.="</li>";
$htmlCateogry.="</ul>";
$htmlCateogry.=" </div>";
//echo $htmlCateogry;




