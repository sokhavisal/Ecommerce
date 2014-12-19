<?php
$db_username = 'root';
$db_password = '123456';
$db_name = 'bbjewels';
$db_host = '';
$item_per_page = 8;

$db_conx = mysqli_connect($db_host, $db_username, $db_password,$db_name)or die('could not connect to database');
?>