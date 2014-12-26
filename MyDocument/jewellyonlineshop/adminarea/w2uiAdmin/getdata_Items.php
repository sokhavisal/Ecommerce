<?php
  require_once __DIR__ .'/app/sys_const.php';
  require_once __DIR__ .'/common/com.php';
 require_once 'ComSQL.php';
 

$MainCat=X(filter_input(INPUT_GET, 'MainCat', FILTER_SANITIZE_STRING));
	
	  $sql=  func_getdataItems($MainCat);
	  $query = SQLQuery($sql);
	  $Json['total']= count($query);
	  $Json['page']=0;
//
	 $Json['searches'][]= (array('field' => 'itemCode',            'caption' => 'itemCode',      'type'=> 'text'));
	 $Json['searches'][]= (array('field' => 'ItemName',      'caption' => 'ItemName','type'=> 'text'));
	
	$Json['columns'][]= (array('field' => 'recid',			'caption' => 'NO',                 'size' => '40px',                        'style'=>  'text-align: left'));
	$Json['columns'][]= (array('field' => 'itemCode',		'caption' => 'Code',               'size' => '80px',    'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'MainCategory',           'caption' => 'MainCategory',       'size' => '200px',   'sortable' => true, 'style'=> ' text-align:center'));
	$Json['columns'][]= (array('field' => 'SubCategory',		'caption' => 'SubCategory',        'size' => '150px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'ItemName',		'caption' => 'ItemName',           'size' => '200px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'price',			'caption' => 'price',		   'size' => '150px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'Description',            'caption' => 'Description',        'size' => '250px',   'sortable' => true, 'style'=> ' text-align:center'));
	$Json['columns'][]= (array('field' => 'Image',			'caption' => 'Image',		   'size' => '100px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'type',			'caption' => 'type',		   'size' => '100px',   'sortable' => true, 'style'=>  'text-align: left '));	
	$Json['columns'][]= (array('field' => 'topsell',		'caption' => 'topsell',            'size' => '70px',    'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'noviews',		'caption' => 'noviews',		   'size' => '70px',    'sortable' => true, 'style'=>  'text-align: left '));
	//$Json['columns'][]= (array('field' => 'Description',           'caption' => 'Description',         'size' => '250px',   'sortable' => true, 'style'=> ' text-align:center'));

	$RowPos=0;
         for  ($i=0;$i<count($query);$i++) 
	
		 {
		$RowPos = $RowPos + 1;
                $row=$query[$i];
		$Json['records'][]=
		(
			array
			(
				'recid' => $RowPos,
				'itemCode' => $row["itemCode"],
				'SubCategory' => $row["SubCategory"],
				'MainCategory' => $row["MainCategory"],
				'ItemName' => $row["ItemName"],
				'price' => $row["price"],
				'Description' => $row["Description"],
				'type' => $row["type"],
				'topsell' => $row["topsell"],
				'noviews' => $row["noviews"],
				'Image' => linkImage('http://localhost/SaleProduct/MyDocument/jewellyonlineshop/Photos/Diamond/Bangles/1.jpg ') ,
				'nullRow' => ''

			)
		);
	}
	  
echo json_encode($Json);

 function linkImage($linkImage)
    {
	if ($linkImage==""){
	    $linkImage='image/no_image.jpg';
	}
	$imagebox= '<div>';
	$imagebox.= '<a href="' .$linkImage. '" target="_blank">';
	$imagebox.= '<img  src="'.$linkImage.'"  width="100px"  alt = " " ></a>';
	$imagebox.='</div> ';
	
	return $imagebox;
    }

?>

