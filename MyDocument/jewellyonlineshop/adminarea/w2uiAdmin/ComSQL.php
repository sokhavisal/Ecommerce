<?php
    function func_getdataItems($MainCate){
	$sql="";
//	$sql.=" SELECT M.mmenu_id AS MainCatID, S.id AS SubCatID , M.mmenu_name, S.smenu_name, M.ItemCatMainStatus, S.smenu_link ";
//		$sql.= " , I.prodname, I.path, I.category, I.price , I.descr, I.type, I.noviews, I.topsell  ";
//		$sql.= " FROM main_menu  M ";
//		$sql.= " RIGHT JOIN ";
//		$sql.= " sub_menu S ON ";
//		$sql.= " M.mmenu_id= S.id ";
//		$sql.= " LEFT JOIN jewellery ON S.id= I.category ";
	$sql.=" SELECT ";
	    $sql.=" I.id, ";
	    $sql.=" I.itemCode, ";
	    $sql.=" S.mmenu_id AS MainCategory, ";
	    $sql.=" I.category, ";
	    $sql.=" M.mmenu_name AS MainCategory, ";
	    $sql.=" S.smenu_name AS SubCategory, ";
	    $sql.=" I.prodname AS ItemName , ";
	     $sql.=" I.price, ";
	     $sql.=" I.descr AS Description, ";
	    $sql.=" I.path, ";
	    $sql.=" I.type, ";
	    $sql.=" I.noviews, ";
	    $sql.=" I.topsell ";
	    
	 $sql.=" FROM sub_menu S  ";
	     $sql.=" inner JOIN jewellery I ON ";
	     $sql.=" I.category = S.id ";
	     $sql.=" LEFT JOIN main_menu M ON ";
	      $sql.=" M.mmenu_id= S.mmenu_id ";
	      
	      if($MainCate > 0  ){
		   if(getSQLWhereTermsRanking()==""){
		       $sql.="WHERE  M.mmenu_id = " . $MainCate.getSQLOrderBy('');
		   }  else {
		        $sql.=getSQLWhereTermsRanking("").getSQLOrderBy('');
		   }
		  
	
	      } else {
		   // $sql.=" Order by M.mmenu_id ";
		    $sql.=getSQLWhereTermsRanking("").getSQLOrderBy('');
	      } 
	    
	    
	return $sql;
	
    }

function getSQLWhereTermsRanking($DefaultWhere = '')
{
//	$lget=$_GET;
        $lget = (array_key_exists('search', $_GET)) ? $_GET : $_POST;
	$Where="";
//	if ($lget['search']!=null){
	if (array_key_exists('search',$lget)){
		$Where=" WHERE ";
		$AddFlg=0;
		if(mb_strlen($DefaultWhere)>0){ 
			$Where.= $DefaultWhere." AND ";
		}
		for($i = 0; $i <count($lget['search']);$i++){
			if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: $lget['search-logic'])." ";//search for kakaku com
			//if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: array_key_exists('search-logic',$lget) ? $lget['search-logic'] : '').' ';
			if(mb_strlen($lget['search'][$i]['field'])>0){
				switch ($lget['search'][$i]['type']){
				case 'text':
					$Val=$lget['search'][$i]['value'];
					break;
				case 'date':
					if(count($lget['search'][$i]['value'])==1) {
						if (preg_match('/($^)|(^\d{4}(-|\/)\d{2}(-|\/)\d{2}$)/', $lget['search'][$i]['value']) == 1) {
							$Val=$lget['search'][$i]['value'];
						} else {
							$Val=date("Y-m-d",($lget['search'][$i]['value']/1000)+25569);
						}
					} else {
						if (preg_match('/($^)|(^\d{4}(-|\/)\d{2}(-|\/)\d{2}$)/', $lget['search'][$i]['value'][0]) == 1) {
							$Val1=$lget['search'][$i]['value'][0];
						} else {
							$Val1=date("Y-m-d",($lget['search'][$i]['value'][0]/1000)+25569);
						}
						if (preg_match('/($^)|(^\d{4}(-|\/)\d{2}(-|\/)\d{2}$)/', $lget['search'][$i]['value'][1]) == 1) {
							$Val2=$lget['search'][$i]['value'][1];
						} else {
							$Val2=date("Y-m-d",($lget['search'][$i]['value'][1]/1000)+25569);
						}
//						$Val1=date("Y-m-d",($lget['search'][$i]['value'][0]/1000)+25569);
//						$Val2=date("Y-m-d",($lget['search'][$i]['value'][1]/1000)+25569);
					}
					break;
				case 'int':
					if (is_array($lget['search'][$i]['value'])) {
						if(count($lget['search'][$i]['value'])==1) {
							$Val=$lget['search'][$i]['value'][0];
						} else {
							$Val1=$lget['search'][$i]['value'][0];
							$Val2=$lget['search'][$i]['value'][1];
						}
					} else {
						$Val=$lget['search'][$i]['value'];
					}
					break;
				default :
					$Val=$lget['search'][$i]['value'];
					break;				
				}
				switch ($lget['search'][$i]['operator']){
					//前方一致
					case 'begins':
						$Where.= $lget['search'][$i]['field']." LIKE '".$Val."%'";
						$AddFlg++;
						break;
					//後方一致
					case 'ends with':
						$Where.= $lget['search'][$i]['field']." LIKE '%".$Val."'";
						$AddFlg++;
						break;
					//含む
					case 'contains':
						$Where.= $lget['search'][$i]['field']." LIKE '%".$Val."%'";
						$AddFlg++;
						break;
					//完全一致
					case 'is':
						$Where.= $lget['search'][$i]['field']." = '".$Val."'";
						$AddFlg++;
						break;
					//間
//					case 'between':
//						if ($Val1 !== '' && $Val2 !== '') {
//							$Where.= "(".$lget['search'][$i]['field']." >= '".$Val1."' AND ".$lget['search'][$i]['field']." <= '".$Val2."')";
//						} else if ($Val1 !== '') {
//							$Where.= $lget['search'][$i]['field']." >= '".$Val1."'";
//						} else if ($Val2 !== '') {
//							$Where.= $lget['search'][$i]['field']." <= '".$Val2."'"; 
//						}
//						$AddFlg++;
//						break;
//					case 'in':
//						$Where.= $lget['search'][$i]['field']." LIKE '%".$Val."%'";
//						$AddFlg++;
//						break;
					}
			}
		}

	} else if($DefaultWhere){
		$Where=" WHERE ".$DefaultWhere;
	}
	return $Where;
}
function getSQLOrderBy($DefaultOrder = ''){
    
        $Order = '';
        $lget = (array_key_exists('sort',$_GET)) ? $_GET : $_POST;
        if (array_key_exists('sort', $lget)) {
            if (is_array($lget['sort'])) {
		$count = count($lget['sort']);
                for ($i = 0; $i <$count; $i++) {
		    switch ($lget['sort'][$i]['field']) {
			case 'LowestPrice':
			case 'AveragePrice':
			case 'SaleRanking':
			case 'SellingPrice':
			case 'ShippingCost':
			case 'Point':			    
			    $Order .= 'CAST('.$lget['sort'][$i]['field'].' AS UNSIGNED) '.$lget['sort'][$i]['direction'].',';
			    break;
			case 'Point':			    
			    $Order .= 'CAST('.$lget['sort'][$i]['field'].' AS ​DECIMAL(9,1)) '.$lget['sort'][$i]['direction'].',';
			    break;
			default:
			    $Order .= $lget['sort'][$i]['field'].' '.$lget['sort'][$i]['direction'].',';
			    break;
		    }                    
                }
		
            }
        }
        if (trim($DefaultOrder) !== '') {
            $Order .= (trim($DefaultOrder)).',';
        }

        return (($Order !== '') ? rtrim($Order,',') : ' Order by I.price DESC ');
}

?>
