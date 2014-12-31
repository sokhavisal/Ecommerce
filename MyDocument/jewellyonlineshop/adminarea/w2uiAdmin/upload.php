<?php
define ('SITE_ROOT', realpath(dirname(__FILE__)));
    require_once __DIR__ .'/app/sys_const.php';
  require_once __DIR__ .'/common/com.php';
//$FileName=filter_input(INPUT_GET, 'f', FILTER_SANITIZE_STRING);
$FileName=X(filter_input(INPUT_GET, 'f', FILTER_SANITIZE_STRING));
$target_dir = "ProductImages/";
$target_file = $target_dir . basename($_FILES["SelectedFile"]["name"]); 
$imageFileType = pathinfo($target_file,PATHINFO_EXTENSION);


// Output JSON
function outputJSON($msg, $status = 'error'){
    header('Content-Type: application/json');
    die(json_encode(array(
        'data' => $msg,
        'status' => $status
    )));
}


// Check for errors
if($_FILES['SelectedFile']['error'] > 0){
    outputJSON('An error ocurred when uploading.');
}

if(!getimagesize($_FILES['SelectedFile']['tmp_name'])){
    outputJSON('Please ensure you are uploading an image.');
}

// Check filetype

if($_FILES['SelectedFile']['type'] != 'image/jpg' && $_FILES['SelectedFile']['type'] != 'image/jpeg' 
	&& $_FILES['SelectedFile']['type'] != 'image/png' && $_FILES['SelectedFile']['type'] != 'image/gif'){
    outputJSON('Unsupported filetype uploaded.');
}

// Check filesize
if($_FILES['SelectedFile']['size'] > 500000){
    outputJSON('File uploaded exceeds maximum upload size.');
}

// Check if the file exists
//if(file_exists($target_dir .$FileName.'.'.$imageFileType)){
//    outputJSON('File with that name already exists.');
//}

// Upload file
if(!move_uploaded_file($_FILES['SelectedFile']['tmp_name'], $target_dir .$FileName.'.'.$imageFileType )){//$_FILES['SelectedFile']['name']
    outputJSON('Error uploading file - check destination is writeable.');
}
// Success!
outputJSON($target_dir .$FileName.'.'.$imageFileType, 'success');