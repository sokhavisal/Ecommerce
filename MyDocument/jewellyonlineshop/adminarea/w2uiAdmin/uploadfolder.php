<?php
  require_once __DIR__ .'/common/com.php';
$MainCategoryfolder=X(filter_input(INPUT_GET, 'MainCategory', FILTER_SANITIZE_STRING));
$subCategory=X(filter_input(INPUT_GET, 'SubCategory', FILTER_SANITIZE_STRING));
if($MainCategoryfolder =='undefined' && $subCategory == 'undefined' || $subCategory==" " || $MainCategoryfolder== ' ' ){
    echo 'plase select Category and SubCategory';
}else{
	$fullDir="ProductImages/".$MainCategoryfolder."/".$subCategory; 
 //exec("mkdir -p ".$fullDir); 
	$dirs=explode("/",$fullDir); 
    	$currentFolder=''; 
    for ($x=0; $x<count($dirs); $x++){ 
	$currentFolder.=$dirs[$x].'/'; 
	if(!is_dir($currentFolder)){
    
	    if(!mkdir($currentFolder)){
		die("Could not make ".$currentFolder);
	    } 
	} 
    }  
}

 
?>

