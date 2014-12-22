<?php
function SaveExcelEX ($FileName,$Data) {

	#日本語が読み込まれない場合に記述
	setlocale(LC_ALL,'ja_JP.UTF-8');
	//HTTP出力文字コードの設定
	mb_http_output('UTF-8');

	$FileName = convertEncoding(str_replace('^.*[. ]|.*[\p{Cntrl}\\/:*?"<>|]','',$FileName), 'SJIS');

	$DataList['header'] = array();
	$DataList['records'] = array();
	$DataList['footer'] = array();
	$DataPos = array();
	
	
	//W2UIJSONデータから、出力用に変換する
	foreach ($Data as $key => $value){
		$RowData = array();
		if ($key == 'columns') {
			for($i=0;count($value) > $i;$i++) {
				$RowData[] = $value[$i]['caption'];
				$DataPos[] = $value[$i]['field'];
			}
			$DataList['header'][] = $RowData;
		} else if ($key == 'records') {
			for($i=0;count($value) > $i;$i++) {
				$RowData = array();
				for($ii=0;count($DataPos) > $ii;$ii++) {
					$RowData[] = (array_key_exists($DataPos[$ii],$value[$i]))?$value[$i][$DataPos[$ii]]:'';
				}
				if(array_key_exists('summary',$value[$i])){
					$DataList['footer'][] = $RowData;
				} else {
					$DataList['records'][] = $RowData;
				}
			}			
		}
	}

	if(preg_match('/.csv/',$FileName)) {
		$csv = "";
		$HColCnt = count($DataList['header'][0]);
		$HRowCnt = count($DataList['header']);
		$RRowCnt = count($DataList['records']);
		$FRowCnt = count($DataList['footer']);

		//CSVデータ作成
		$csv  = csv($HRowCnt, $HColCnt, $DataList['header']);
		$csv .= csv($RRowCnt, $HColCnt, $DataList['records']);
		$csv .= csv($FRowCnt, $HColCnt, $DataList['footer']);
		
		//ファイルを追記モードで開く
		$fp = fopen($FileName, 'w');
		flock($fp, LOCK_EX);
		fputs($fp,mb_convert_encoding($csv,'sjis-win','UTF-8'));
		fclose($fp);

		header('Content-Type: application/octet-stream');
		header('Content-Disposition: attachment; filename=' . $FileName);
		readfile($FileName);
		//ファイル削除
		unlink($FileName);
	} else {
		require_once('PHPExcel.php');
		require_once('PHPExcel/IOFactory.php');
		require_once('PHPExcel/Cell.php');

		if(strpos($FileName,'.xlsx') > 0) {
			$Type='Excel2007';
		} else if(strpos($FileName,'.xls') > 0) {
			$Type='Excel5';
		} else {
			exit(0);
		}

		$cell_style = array(
			'numberformat' => array('code' => PHPExcel_Style_NumberFormat::FORMAT_TEXT),
			'borders' => array(
				'top'     => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'bottom'  => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'left'    => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'right'   => array('style' => PHPExcel_Style_Border::BORDER_THIN)
			)
		);

		//オブジェクトの生成
		$xl = new PHPExcel();

		//シートの設定
		$xl->setActiveSheetIndex(0);
		$sheet = $xl->getActiveSheet();
		$sheet->setTitle('Sheet1');
		//スタイルの設定(標準フォント)
//		$sheet->getDefaultStyle()->getFont()->setName('ＭＳ Ｐゴシック');
//		$sheet->getDefaultStyle()->getFont()->setSize(11);

		$HColCnt = count($DataList['header'][0]);
		$HRowCnt = count($DataList['header']);
		$RRowCnt = count($DataList['records']) + $HRowCnt;
		$FRowCnt = count($DataList['footer']) + $RRowCnt;

		//ヘッダー部の書き出し
		$pos = 0;
		for($row = 1; $row <= $HRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['header'][$pos][$col]);
				$sheet->getStyleByColumnAndRow($col, $row)->getAlignment()->setWrapText(true);
			}
			$pos = $pos+1;
		}
		//データ部の書き出し
		$pos = 0;
		for($row = $HRowCnt+1; $row <= $RRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['records'][$pos][$col]);
			}
			$pos = $pos+1;
		}
		//フッタ部の書き出し
		$pos=0;
		for($row = $RRowCnt+1; $row <= $FRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['footer'][$pos][$col]);
				$sheet->getStyleByColumnAndRow($col, $row)->getAlignment()->setWrapText(true);
			}
			$pos = $pos+1;
		}

		//ヘッダー部スタイル設定
		for($row = 1; $row <= $HRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->getStyleByColumnAndRow($col, $row)->applyFromArray($cell_style);
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->getStartColor()->setARGB('FFeeeeee');
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->setFillType(PHPExcel_Style_Fill::FILL_SOLID);
			}
		}
		//データ部スタイル設定
		$LeftTop = 1+$HRowCnt;
		$v_range = 'A'.$LeftTop.':'.PHPExcel_Cell::stringFromColumnIndex($HColCnt-1).$RRowCnt;
		$sheet->getStyle($v_range)->getBorders()->getAllBorders()->setBorderStyle(PHPExcel_Style_Border::BORDER_THIN);
		$sheet->getStyle($v_range)->getAlignment()->setWrapText(true);
		//フッタ部スタイル設定
		for($row = $RRowCnt+1; $row <= $FRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->getStyleByColumnAndRow($col, $row)->applyFromArray($cell_style);
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->getStartColor()->setARGB('FFeeeeee');
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->setFillType(PHPExcel_Style_Fill::FILL_SOLID);
			}
		}

		//範囲選択の解除(※A1セルを選択)
		$sheet->getStyleByColumnAndRow(0, 1);

		//ブラウザへ出力をリダイレクト
		header('Content-Type: application/vnd.ms-excel');
		header('Content-Disposition: attachment;filename="'.$FileName.'"');
		header('Cache-Control: max-age=0');
		$writer = PHPExcel_IOFactory::createWriter($xl,$Type);
		$writer->save('php://output');

		//$xl->excel->disconnectWorksheets();  
		unset($xl->excel);
	}
	exit;

}


//タグの削除
function deleteTag($text)
{
	//テキスト内のタグ文字を全て削除する。
	return strip_tags($text);
}
//HTML出力前変換
function X($target) {
	return htmlspecialchars($target, ENT_QUOTES, "UTF-8");
}
//HTML出力前変換　配列ごと
function myhtmlspecialchars($obj) {
    if (is_array($obj)) {
        return array_map("myhtmlspecialchars", $obj);
    } else {
        return X($obj);
    }
}

//指定した名前のPOSTデータをXSS対策を施した状態で取得する。
function getPostData($name)
{
	if(isset($_POST[$name]))
	{
		return myhtmlspecialchars($_POST[$name]);
	}
}

//指定した名前のGETデータをXSS対策を施した状態で取得する。
function getGetData($name)
{
	if(isset($_GET[$name]))
	{
		return myhtmlspecialchars($_GET[$name]);
	}
}
//改行を<br>に変換
function convertBr($text)
{
	//改行コードの後に<br/>をつける
	$text = nl2br($text);
	//改行コード(\n)を削除
	return str_replace("\n","",$text);
}
function TrimAll($text)
{
	return str_replace(hex2bin('31'),"",str_replace(hex2bin('f1'),"",str_replace("\r","",str_replace("\n","",$text))));
}
//URLチェック
function is_url($url) {
	if (preg_match('/\Ahttp:\/\//', $url) || preg_match('/\Ahttps:\/\//', $url)) {
		return true;
	} else {
		return false;
	}
}

//変換
//全角英数字→半角英数字変換
//全角スペース→半角スペース
function convertHalfCharactor($str)
{
	//文字コードはUTF-8固定
	return mb_convert_kana($str, "as", "UTF-8");
}

//大文字変換
function toUpper($str)
{
	return strtoupper($str);
}

//小文字変換
function toLower($str)
{
	return strtolower($str);
}

/*
*文字列関数 他の共通関数から移動
*/
function right($str,$n){
	//文字コードUTF-8で、right関数。$strの右から$n文字取得
	return mb_substr($str,($n)*(-1),$n,"UTF-8");
}

function left($str,$n){
	//文字コードUTF-8で、left関数。$strの左から$n文字取得
	return mb_substr($str,0,$n,"UTF-8");
}
function rightB($str,$n){
	//文字コードUTF-8で、right関数。$strの右から$nバイト取得
	return substr($str,($n)*(-1),$n);
}

function leftB($str,$n){
	//文字コードUTF-8で、left関数。$strの左から$nバイト取得
	return substr($str,0,$n);
}
/*
カンマを空文字に変換する。
*/
function replaceCommaString($str){
	return mysql_real_escape_string(str_replace(",","",$str));
}


/*
---------------------------------------------
#FTPアップロード処理
---------------------------------------------
*/	
function FtpUpload($ftp, $dir, $remote_file,$file)
{
	//接続を確立する
	$conn_id = ftp_connect($ftp['ftp_server']);
	
	//ログイン
	$result = ftp_login($conn_id, $ftp['ftp_user_name'], $ftp['ftp_user_pass']);
	
	//ftp_pasv($conn_id, true);
	if(!empty($dir)){
		ftp_chdir($conn_id, $dir); // アップロード先のディレクトリに移動
	}
	
	//アップロード
	if (!ftp_put($conn_id, $remote_file, $file, FTP_BINARY))
	{
		//アップロードに失敗
		exit;
	}
	
	//接続を閉じる
	ftp_close($conn_id);
}

/**
 * FTPディレクトリの作成
 * @param type $ftp FTPユーザ
 * @param type $dir 作成するディレクトリ
 * @return string   TRUE:ディレクトリ作成に成功,FALSE:ディレクトリ作成に失敗
 */
function FtpMkdir($ftp, $dir)
{
	//接続を確立する
	$conn_id = ftp_connect($ftp['ftp_server']);
	
	//ログイン
	ftp_login($conn_id, $ftp['ftp_user_name'], $ftp['ftp_user_pass']);
	
	try
	{
		//FTPディレクトリの作成
		//作成できたときはtrue
		$result = ftp_mkdir($conn_id, $dir);
	}
	catch(Exception $e)
	{
		//エラーの場合
		//FTPディレクトリが作成できなかったときはfalse
		$result = false;
	}
	
	//接続を閉じる
	ftp_close($conn_id);
	
	return $result;
}

function FtpExists($ftp, $dir, $remote_file)
{
	//接続を確立する
	$conn_id = ftp_connect($ftp['ftp_server']);

	//ログイン
	ftp_login($conn_id, $ftp['ftp_user_name'], $ftp['ftp_user_pass']);

	if(!empty($dir)){
		ftp_chdir($conn_id, $dir); // アップロード先のディレクトリに移動
	}

	$res = ftp_size($conn_id, $remote_file);

	//接続を閉じる
	ftp_close($conn_id);

	return $res;
}

/*ファイル操作*/
/*
---------------------------------------------
#フォルダサイズ計算
---------------------------------------------
*/
function dir_size($dir){
  $handle = opendir($dir);
  $mas =0;
  while ($file = readdir($handle)) {
    if ($file != '..' && $file != '.' && !is_dir($dir.'/'.$file)) {
      $mas += filesize($dir.'/'.$file);
    } else if (is_dir($dir.'/'.$file) && $file != '..' && $file != '.') {
      $mas += dir_size($dir.'/'.$file);
    }
  }
  return $mas;
}

/*
---------------------------------------------
#ディレクトリ削除
---------------------------------------------
*/
function deleteDir($rootPath){
    $strDir = opendir($rootPath);
    while($strFile = readdir($strDir)){
        if($strFile != '.' && $strFile != '..'){  //ディレクトリでない場合のみ
            unlink($rootPath.'/'.$strFile);
        }
    }
    rmdir($rootPath);
}

/**
 * FTPディレクトリの作成
 * @param type $dir 圧縮するディレクトリ
 * @param type $zipPath zipファイルを作成すパス
 */
function archiveZipDir($dir,$zipPath)
{
	
	$tempDir = $dir;
	//ここにzipファイルを作ります
	//このコマンドを
	$command = "cd " . $tempDir . "; zip -r " . $zipPath . " .";
	//実行します
	exec($command);
}

/*
---------------------------------------------
#URL上ファイル存在チェック
---------------------------------------------
*/
function checkURLFileExists($url)
{
	$x=get_headers($url);
	
	if(preg_match("/OK$/",$x[0]))
	{
		return true;
	}

	return false;
}

/*
---------------------------------------------
#ファイルのリサイズ
引数:: $file1:コピー元ファイル名、$file2:リサイズファイル名（画像保存先)
$resizeWidth:リサイズ後横幅、$file2:リサイズ後高さ
---------------------------------------------
*/
function fileResize($file1, $file2, $resizeWidth, $resizeHeight)
{
    //$file1 = "../../sample/img/img.jpg";                  //　元画像ファイル
    //$file2 = "./imgs.jpg";                                //　画像保存先
    
    $in = ImageCreateFromJPEG($file1);                      //　元画像ファイル読み込み
    $size = GetImageSize($file1);                           //　元画像サイズ取得
    
    //　画像生成
    $out = ImageCreateTrueColor($resizeWidth, $resizeHeight);
    //　サイズ変更・コピー
    ImageCopyResampled($out, $in, 0, 0, 0, 0, $resizeWidth, $resizeHeight, $size[0], $size[1]);
    
    //　画像保存 
    //TODO:jpeg以外の場合はどうする?
    ImageJPEG($out, $file2);
    
    ImageDestroy($in);
    ImageDestroy($out);
}


//csvファイルを読み込んで連想配列として返す。
function csvToArray($filename)
{
	//ファイル
	$list = fopen($filename,'r'); 
	$h = 0;

	while ($array = fgetcsv($list, 1000,",")) 
	{
		for ($i = 0; $i < count($array); $i++)
		{
			$newarray[$h][$i] = $array[$i];
		}
		$h++;
	}
	return $newarray;
}

//連想配列から、csvファイルとして保存
function arrayToCSV($array, $filename)
{
	// CSVデータの初期化
	$csv_data = "";
	
	// CSVデータの作成
	foreach($array as $key => $value )
	{
		$csv_data .= $key. ",";
		$csv_data .= $value[0]. ",";
		$csv_data .= $value[1];
		
		if(count($array) !== intval($key)+1){
			
			$csv_data .= "\n";
		}
	}
	
	// ファイルを追記モードで開く
	$fp = fopen($filename, 'ab');
	
	// ファイルを排他ロックする
	flock($fp, LOCK_EX);

	// ファイルの中身を空にする
	ftruncate($fp, 0);

	// データをファイルに書き込む
	fwrite($fp, $csv_data);

	// ファイルを閉じる
	fclose($fp);

}

//スマホ判定関数
function is_mobile () {
	$useragents = array(
	'iPhone', // Apple iPhone
	'iPod', // Apple iPod touch
	'Android', // 1.5+ Android
	'dream', // Pre 1.5 Android
	'CUPCAKE', // 1.5+ Android
	'blackberry9500', // Storm
	'blackberry9530', // Storm
	'blackberry9520', // Storm v2
	'blackberry9550', // Storm v2
	'blackberry9800', // Torch
	'webOS', // Palm Pre Experimental
	'incognito', // Other iPhone browser
	'webmate' // Other iPhone browser
	);
	$pattern = '/'.implode('|', $useragents).'/i';
	return preg_match($pattern, $_SERVER['HTTP_USER_AGENT']);
}

//JSONファイル作成クラス
class Json {
	public $data;
	private $filename;
	private $path = "./";

	public function __construct($name) {
		$this->filename = $this->path . $name;
		if (file_exists($this->filename)) {
			$this->data = json_decode(file_get_contents($this->filename), true);
		} else {
			$this->data = array();
		}
	}

	public function save() {
		file_put_contents($this->filename, json_encode($this->data));
	}
}
/**
* ファイル出力（csv,Excel,Excel2007）
* [備考]
* 
* @param string $FileName ファイル名
* @param string $Data 出力データ
*/
function SaveExcel ($FileName,$Data) {

	#日本語が読み込まれない場合に記述
	setlocale(LC_ALL,'ja_JP.UTF-8');
	//HTTP出力文字コードの設定
	mb_http_output('UTF-8');

	$FileName = convertEncoding(str_replace('^.*[. ]|.*[\p{Cntrl}\\/:*?"<>|]','',$FileName), 'SJIS');

	$DataList['header'] = array();
	$DataList['records'] = array();
	$DataList['footer'] = array();
	foreach ($Data as $key => $value){
		if ($key == 'header') {
			$DataList['header'] = $value;
		} else if ($key == 'records') {
			$DataList['records'] = $value;
		} else if ($key == 'footer') {
			$DataList['footer'] = $value;
		}
	}

	if(preg_match('/.csv/',$FileName)) {
		$csv = "";
		$HColCnt = count($DataList['header'][0]);
		$HRowCnt = count($DataList['header']);
		$RRowCnt = count($DataList['records']);
		$FRowCnt = count($DataList['footer']);

		//CSVデータ作成
		$csv  = csv($HRowCnt, $HColCnt, $DataList['header']);
		$csv .= csv($RRowCnt, $HColCnt, $DataList['records']);
		$csv .= csv($FRowCnt, $HColCnt, $DataList['footer']);
		
		//ファイルを追記モードで開く
		$fp = fopen($FileName, 'w');
		flock($fp, LOCK_EX);
		fputs($fp,mb_convert_encoding($csv,'sjis-win','UTF-8'));
		fclose($fp);

		header('Content-Type: application/octet-stream');
		header('Content-Disposition: attachment; filename=' . $FileName);
		readfile($FileName);
		//ファイル削除
		unlink($FileName);

/*
文字と数値を分ける場合には、下記参考ソースから行う

$outputFile = 'data.csv';
$csv_data = array (
array('aaa', 'bbb', 'ccc', 'dddd'),
array('123', '456', '789')
);
//fputcsvでCSVファイル書き込み
$fp = fopen($outputFile,'w');
foreach($csv_data as $line){
	fputcsv($fp,$line);
}
rewind($fp);

$buf = str_replace("\n", "\r\n", stream_get_contents($fp));
fclose($fp);

$fp = fopen($outputFile, 'w');
fwrite($fp, $buf);
fclose($fp);
*/
	} else {
		require_once('PHPExcel.php');
		require_once('PHPExcel/IOFactory.php');
		require_once('PHPExcel/Cell.php');

		if(strpos($FileName,'.xlsx') > 0) {
			$Type='Excel2007';
		} else if(strpos($FileName,'.xls') > 0) {
			$Type='Excel5';
		} else {
			exit(0);
		}

		$cell_style = array(
			'numberformat' => array('code' => PHPExcel_Style_NumberFormat::FORMAT_TEXT),
			'borders' => array(
				'top'     => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'bottom'  => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'left'    => array('style' => PHPExcel_Style_Border::BORDER_THIN),
				'right'   => array('style' => PHPExcel_Style_Border::BORDER_THIN)
			)
		);

		//オブジェクトの生成
		$xl = new PHPExcel();

		//シートの設定
		$xl->setActiveSheetIndex(0);
		$sheet = $xl->getActiveSheet();
		$sheet->setTitle('Sheet1');
		//スタイルの設定(標準フォント)
//		$sheet->getDefaultStyle()->getFont()->setName('ＭＳ Ｐゴシック');
//		$sheet->getDefaultStyle()->getFont()->setSize(11);

		$HColCnt = count($DataList['header'][0]);
		$HRowCnt = count($DataList['header']);
		$RRowCnt = count($DataList['records']) + $HRowCnt;
		$FRowCnt = count($DataList['footer']) + $RRowCnt;

		//ヘッダー部の書き出し
		$pos = 0;
		for($row = 1; $row <= $HRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['header'][$pos][$col]);
				$sheet->getStyleByColumnAndRow($col, $row)->getAlignment()->setWrapText(true);
			}
			$pos = $pos+1;
		}
		//データ部の書き出し
		$pos = 0;
		for($row = $HRowCnt+1; $row <= $RRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['records'][$pos][$col]);
			}
			$pos = $pos+1;
		}
		//フッタ部の書き出し
		$pos=0;
		for($row = $RRowCnt+1; $row <= $FRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->setCellValueByColumnAndRow( $col, $row, $DataList['footer'][$pos][$col]);
				$sheet->getStyleByColumnAndRow($col, $row)->getAlignment()->setWrapText(true);
			}
			$pos = $pos+1;
		}

		//ヘッダー部スタイル設定
		for($row = 1; $row <= $HRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->getStyleByColumnAndRow($col, $row)->applyFromArray($cell_style);
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->getStartColor()->setARGB('FFeeeeee');
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->setFillType(PHPExcel_Style_Fill::FILL_SOLID);
			}
		}
		//データ部スタイル設定
		$LeftTop = 1+$HRowCnt;
		$v_range = 'A'.$LeftTop.':'.PHPExcel_Cell::stringFromColumnIndex($HColCnt-1).$RRowCnt;
		$sheet->getStyle($v_range)->getBorders()->getAllBorders()->setBorderStyle(PHPExcel_Style_Border::BORDER_THIN);
		$sheet->getStyle($v_range)->getAlignment()->setWrapText(true);
		//フッタ部スタイル設定
		for($row = $RRowCnt+1; $row <= $FRowCnt; $row++) {
			for($col = 0; $col < $HColCnt; $col++) {
				$sheet->getStyleByColumnAndRow($col, $row)->applyFromArray($cell_style);
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->getStartColor()->setARGB('FFeeeeee');
				$sheet->getStyleByColumnAndRow($col, $row)->getFill()->setFillType(PHPExcel_Style_Fill::FILL_SOLID);
			}
		}

		//範囲選択の解除(※A1セルを選択)
		$sheet->getStyleByColumnAndRow(0, 1);

		//ブラウザへ出力をリダイレクト
		header('Content-Type: application/vnd.ms-excel');
		header('Content-Disposition: attachment;filename="'.$FileName.'"');
		header('Cache-Control: max-age=0');
		$writer = PHPExcel_IOFactory::createWriter($xl,$Type);
		$writer->save('php://output');

		$xl->excel->disconnectWorksheets();  
		unset($xl->excel);
	}
	exit;

}
/**
* csv出力カンマ編集
* [備考]
* 
* @param int $RowCnt 編集行数
* @param int $ColCnt 編集列数
* @param array $Data 編集元データ
* @return csv出力カンマ編集後データ
*/
function csv($RowCnt, $ColCnt, $Data)
{
	$csv = '';
	for($row = 0; $row < $RowCnt ; $row++) {
		for($col = 0; $col < $ColCnt; $col++) {
			$csv .= '"'.str_replace('"','""',$Data[$row][$col]).'"';
			$csv .= ",";
		}
		$csv = rtrim($csv,',');
		$csv.= "\n";
	}
	return $csv;
}
/**
* 文字コード変換
* [備考]
* 
* @param string $val 対象文字列
* @param string $type 変換したいエンコード
* @return 文字コード変換後の文字列
*/
function convertEncoding($val, $type)
{
    $encoding = array();
    $encoding[0] = "ASCII";
    $encoding[1] = "iso-2022-jp";
    $encoding[2] = "EUC-JP";
    $encoding[3] = "JIS";
    $encoding[4] = "UTF-8";
    $encoding[5] = "eucjp-win";
    $encoding[6] = "sjis-win";
    $encoding[7] = "SJIS";
    $enc_result = mb_detect_encoding($val, $encoding, true);

    return mb_convert_encoding($val, $type, $enc_result);
}

//金額を日本表記に変換
function toYen($amount) {

	$oku = floor($amount / 100000000);
	$man = floor(($amount % 100000000) / 10000);
	$nokori = ($amount % 100000000) % 10000;

	$result = '';

	if ($oku) $result = number_format($oku) . '億';
	if ($man) $result .= number_format($man) . '万';
	if ($nokori) $result .= number_format($nokori);

	return $result . '円';

}

//デバッグ用　配列表示関数
function table($val){
    if(!$val) echo 'table error';
    if(is_array($val)){
        echo '<table border="1" cellspacing="0" bordercolor="#333333" >';
        _table($val);
        echo '</table>';
    }else{
        echo var_dump($val);
    }
}
function _table($val){
    echo '<tr align="left" valign="top">'.chr(10);
    echo ' <td align="left" valign="top" bgcolor="#33EE33">key</td>'.chr(10);
    echo ' <td align="left" valign="top" bgcolor="#33EE33">value</td>'.chr(10);
    echo '</tr>'.chr(10);
    foreach($val as $key => $_val){
        echo '<tr align="left" valign="top">'.chr(10);
        echo ' <td align="left" valign="top" bgcolor="#FFFFFF">'.$key.'</td>'.chr(10);
        echo ' <td align="left" valign="top" bgcolor="#FFFFFF">'.chr(10);
        if(is_array($_val)) table($_val);
        else echo $_val.'</td>'.chr(10).'</tr>'.chr(10);
    }
}
/**
* 対象機能有効チェック
* [備考]
* 
* @param string $FunctionName PHPファイル名
* @param string $link MySQLコネクション
* @return int 0:無効　1:有効
*/
function getFunctionFlg($FunctionName,$link)
{
	$sql="SELECT FunctionFlg FROM A_Setting WHERE FunctionName='".S($FunctionName)."'";
	$result = mysql_query($sql, $link);
	$FunctionFlg=0;
	//一行目のみ取得
	if ($row = mysql_fetch_array($result))
	{
		$FunctionFlg = $row["FunctionFlg"];
	} else if(mb_strlen($FunctionName)>0){
		
		//自社内からのアクセスでは無い場合
		if(gethostbyname("atomicgolf.info") != $_SERVER['REMOTE_ADDR']){
			//レコードの作成
			$sql="INSERT INTO A_Setting (FunctionName) VALUES ('".S($FunctionName)."')";
		} else {
			//レコードの作成
			$sql="INSERT INTO A_Setting (FunctionName,FunctionFlg) VALUES ('".S($FunctionName)."',1)";	
			$FunctionFlg=1;
		}
		mysql_query($sql, $link);
		
	}
	mysql_free_result($result);
	
	//現行はフルオープンのため、全て使えるフラグを返す。
	$FunctionFlg=1;
				
	return $FunctionFlg;
}

/**
* W2UI連携用　WHERE作成
* [備考]
* GETパラメータから検索条件を取得し、WHEREのみ作成。
* @param string $DefaultWhere 基準抽出条件　例：項目名=1
* @return string SQL文
*/
//function getSQLWhereTerms($DefaultWhere)
function getSQLWhereTerms($DefaultWhere = '')
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
//fldr			if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: $lget['search-logic'])." ";
			if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: array_key_exists('search-logic',$lget) ? $lget['search-logic'] : '').' ';
			if(mb_strlen($lget['search'][$i]['field'])>0){
				switch ($lget['search'][$i]['type']){
				case 'text':
					$Val=$lget['search'][$i]['value'];
					break;
				case 'date':
					if(count($lget['search'][$i]['value'])==1) {
						$Val=date("Y-m-d",($lget['search'][$i]['value']/1000)+25569);
					} else {
						$Val1=date("Y-m-d",($lget['search'][$i]['value'][0]/1000)+25569);
						$Val2=date("Y-m-d",($lget['search'][$i]['value'][1]/1000)+25569);						
					}
					break;
				case 'int':
					$Val=$lget['search'][$i]['value'][0];
					break;
				default :
					$Val=$lget['search'][$i]['value'];
					break;				
				}
				switch ($lget['search'][$i]['operator']){
					//前方一致
					case 'begins with':
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
					case 'between':
						$Where.= "DATE(".$lget['search'][$i]['field'].") >= '".$Val1."' AND DATE(".$lget['search'][$i]['field'].") <= '".$Val2."'";				
						$AddFlg++;
						break;					
					case 'in':
						$Where.= $lget['search'][$i]['field']." LIKE '%".$Val."%'";				
						$AddFlg++;						
						break;					
					}
			}
		}

	} else if($DefaultWhere){
		$Where=" WHERE ".$DefaultWhere;
	}
	return $Where;
}

/**
* W2UI連携用　ORDER　BY作成
* [備考]
* GETパラメータからソート情報を取得し、ORDERBYのみ作成。
* @param string $DefaultOrder 基準並び順　例：項目名　ASC
* @return string SQL文
*/
//function getSQLOrderTerms($DefaultAND)
function getSQLANDTerms($DefaultWhere = '')
{
//	$lget=$_GET;
        $lget = (array_key_exists('search', $_GET)) ? $_GET : $_POST;
	$Where="";
//	if ($lget['search']!=null){
	if (array_key_exists('search',$lget)){
		$Where=" AND ( ";
		$AddFlg=0;
//		$AddFlgF=1;
//		$RF=TRUE;
		if(mb_strlen($DefaultWhere)>0){ 
			$Where.= $DefaultWhere." AND ";
		}
		for($i = 0; $i <count($lget['search']);$i++){
//fldr			if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: $lget['search-logic'])." ";
			if($AddFlg) $Where.= " ".(array_key_exists('searchLogic',$lget) ? $lget['searchLogic']: array_key_exists('search-logic',$lget) ? $lget['search-logic'] : '').' ';
			if(mb_strlen($lget['search'][$i]['field'])>0){
				switch ($lget['search'][$i]['type']){
				case 'text':
					$Val=$lget['search'][$i]['value'];
					break;
				case 'date':
					if(count($lget['search'][$i]['value'])==1) {
						$Val=date("Y-m-d",($lget['search'][$i]['value']/1000)+25569);
					} else {
						$Val1=date("Y-m-d",($lget['search'][$i]['value'][0]/1000)+25569);
						$Val2=date("Y-m-d",($lget['search'][$i]['value'][1]/1000)+25569);						
					}
					break;
				case 'int':
					$Val=$lget['search'][$i]['value'][0];
					break;
				default :
					$Val=$lget['search'][$i]['value'];
					break;				
				}
				switch ($lget['search'][$i]['operator']){
					//前方一致
					case 'begins with':
						$Where.= $lget['search'][$i]['field']." LIKE '".$Val."%'";
						$AddFlg++;
						 $Where.=')';
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
						if ($AddFlg==3){
						    $Where.=')';
						}
						if (count($lget['search'])==1) {
						     $Where.=')';
						    }
						break;
					//完全一致
					case 'is':
						$Where.= $lget['search'][$i]['field']." = '".$Val."'";				
						$AddFlg++;
						break;
					//間
					case 'between':
						$Where.= "DATE(".$lget['search'][$i]['field'].") >= '".$Val1."' AND DATE(".$lget['search'][$i]['field'].") <= '".$Val2."'";				
						$AddFlg++;
						break;					
					case 'in':
						$Where.= $lget['search'][$i]['field']." LIKE '%".$Val."%'";				
						$AddFlg++;						
						break;					
					}
			}
		}

	} else if($DefaultWhere){
		$Where=" WHERE ".$DefaultWhere;
	}
	return $Where;
}
//function getSQLOrderTerms($DefaultOrder)
function getSQLOrderTerms($DefaultOrder = '')
{
//	$Order="";
//	$lget=$_GET;
//	if (array_key_exists('sort',$lget)) {
//		if(is_array($lget['sort'])){
//			for($i = 0; $i <count($lget['sort']);$i++){
//				$Order.= $lget['sort'][$i]['field']." ".$lget['sort'][$i]['direction'].",";
//			}
//		}
//		//デフォルトの並び替えは末尾にする
//		if(mb_strlen($DefaultOrder)>0){ 
//			$Order.= ",".$DefaultOrder;
//		}
//		if(mb_strlen($Order)>0){ 
//			$Order = " ORDER BY ".rtrim($Order,',');
//		}
//	} else if($DefaultOrder){
//		$Order=" ORDER BY ".$DefaultOrder;
//	}
//	return $Order;
//        

        $Order = '';
//        if (array_key_exists('sort',$_GET)) {
//            $lget=$_GET;
        $lget = (array_key_exists('sort',$_GET)) ? $_GET : $_POST;
        if (array_key_exists('sort', $lget)) {
            if (is_array($lget['sort'])) {
                for ($i = 0; $i <count($lget['sort']);$i++) {
                    $Order .= $lget['sort'][$i]['field'].' '.$lget['sort'][$i]['direction'].',';
                }
            }
        }
        if (trim($DefaultOrder) !== '') {
            $Order .= (trim($DefaultOrder)).',';
        }
        return (($Order !== '') ? ' ORDER BY '.rtrim($Order,',') : '');
        
}
?>