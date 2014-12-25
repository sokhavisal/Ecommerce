<?php
  require_once __DIR__ .'/app/sys_const.php';
  require_once __DIR__ .'/common/com.php';
 require_once 'ComSQL.php';
 

//$FileName = X(filter_input(INPUT_GET, 'filename', FILTER_SANITIZE_STRING));
	
	  $sql=  func_getdataItems();
	  $query = SQLQuery($sql);
	  $Json['total']= count($result);
	 $Json['page']=0;

	 $Json['searches'][]= (array('field' => 'ItemNo1',            'caption' => 'Item No1',      'type'=> 'text'));
	 $Json['searches'][]= (array('field' => 'PageViewCount',      'caption' => 'PageView Count','type'=> 'text'));
	
	$Json['columns'][]= (array('field' => 'recid',                'caption' => 'NO',                 'size' => '40px',                        'style'=>  'text-align: left'));
	$Json['columns'][]= (array('field' => 'Code',              'caption' => 'ItemNo1',            'size' => '200px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'PageViewCount',        'caption' => 'PageView',		 'size' => '150px',   'sortable' => true, 'style'=>  'text-align: left '));
	$Json['columns'][]= (array('field' => 'LastUpdate',           'caption' => 'LastUpdate',         'size' => '160px',   'sortable' => true, 'style'=> ' text-align:center'));

	$RowPos=0;
         for  ($i=0;$i<count($result);$i++) 
	
		 {
		$RowPos = $RowPos + 1;
                $row=$result[$i];
		$Json['records'][]=
		(
			array
			(
				'recid' => $RowPos,
				'ItemNo1' => $row["ItemNo1"],
				'PageViewCount' => $row["PageViewCount"],
				'LastUpdate' => $row["LastUpdate"],
				'nullRow' => ''

			)
		);
	}
	  
		echo json_encode($Json);
//	if($FileName) {
//		//SQLExecute($sql);
//    SaveExcelEX('ItemsRanking'.$FileName,$Json);
//	 }else {
//		echo json_encode($Json);
//	}

?>

