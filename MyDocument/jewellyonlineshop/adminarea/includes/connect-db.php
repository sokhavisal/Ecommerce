<?php
 // Database Variables (edit with your own server information)
 $server = 'localhost';
 $user = 'root';
 $pass = '123456';
 $db = 'bbjewels';
 
 // Connect to Database
 $connection = mysql_connect($server, $user, $pass) 
 //or die ("Could not connect to server ... \n" . mysql_error ());
 or die ("Could not connect to server ... \n");
 mysql_select_db($db) 
 or die ("Could not connect to database ... \n");

?>