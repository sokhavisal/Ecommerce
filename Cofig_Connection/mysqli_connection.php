<?php
$db_username = 'root';
$db_password = '123456';
$db_name = 'classicmodels';
$db_host = 'localhost';


$con = mysqli_connect($db_host, $db_username, $db_password,$db_name)or die('could not connect to database');
?>