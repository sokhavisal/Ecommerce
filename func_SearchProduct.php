<?php
   include ("Cofig_Connection/mysqli_connection.php");
   $search_sql=" SELECT * FROM products where productname like  '%".$_POST['txtsearch']."%'";
   $search_query=mysqli_query($con, $search_sql);
   if (mysqli_num_rows($search_query)!=0){
       
   $rs= mysqli_fetch_assoc($search_query);
   
   }
   $list='';
   //$src="images/";
?>

<p>Search result</p>
	<?php if (mysqli_num_rows($search_query)!=0){
	    do{
		
		?>
		
		
<?php	}while ($rs=  mysqli_fetch_assoc($search_query));
	} else {
	    echo $_POST['txtsearch'];
	}

	?>

