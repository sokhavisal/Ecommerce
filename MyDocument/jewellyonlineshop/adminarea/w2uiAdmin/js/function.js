
var pstyle = 'background-color: #FFF; border: 1px solid #dfdfdf; padding: 5px;';
var confirmLogout = 'ログアウトします。<br>よろしでしょうか？';
var msg_logoutConfirm = '保存されていない情報があります。<br>ログアウトすると、編集内容は失われます。<br><br>ログアウトしますか？';
var MSG_RELOAD	= "まだ保存されていない情報があります。\n再読み込みすると、編集内容は失われます。\n\n再読み込みしますか？";
var popSiirePalam='';
var rc='';
var rs='';
var MainCat='';
var MainCatArray=[];
var SubCatArray=[];
function session_checking(){ 
    var result = false;
	$.ajax({
		url:'../session.php',
		async: false
	}).fail(function(xhr,status,error) {
		result = false;		
	}).done(function(data,status,xhr){
                if(data == "-1"){       
                    result = true;
                    w2ext.alertIcon = w2ext.icons.error;                    
                    w2ext.alert("セッション切れです。強制ログアウトします。",function(btn) {
                                if (true) { document.location = '../../logout.php'; }
                        });    
                }                		
	});
	return result;     
} 

var obj = getDataMainCategory();




var objSubCat = getDataSubCategory('003');
// variable for create MainCategory combobox in toolbar. 
var htmlMaincom='';
htmlMaincom+='<form  name=myform><label>Category Item : </label>';
htmlMaincom+='<select id="my_select" onchange="getValueCombo(this)">';
htmlMaincom+='<option name=one value=one id="0" selected > All Items </option>';
  for(var i=0;i<3;i++){
       htmlMaincom+='<option name=one value='+ obj.MainCat[i]+' id='+ obj.id[i]+' >'+ obj.MainCat[i]+' </option>';
    }
htmlMaincom+='</select>';
htmlMaincom+='</form>';


var htmlItemcom='';
htmlItemcom+='<form id="combo1" name=myform><label> Item Type : </label>';
htmlItemcom+='<select id="my_select" onchange="getValueSubCombo(this)">';
htmlItemcom+='<option name=one value=one id="0" selected >  </option>';
//if(typeof  MainCatArray[0]=='undefined'){
//   htmlItemcom+='<option name=one value="1" id="2" > dfsdsf    </option>';
// }else{
    
      for(var i=0;i<10;i++){
       htmlItemcom+='<option name=one value='+objSubCat.id[i]+' id='+objSubCat.id[i]+' >'+objSubCat.SubCatName[i]+' </option>';
     }
// }
htmlItemcom+='</select>';
htmlItemcom+='</form>';




function getValueCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
   
    MainCatArray[0]=IdCate ;
    MainCatArray[1]=valueCat;
    w2ui.gItemRanking.url='getdata_Items.php?MainCat='+ MainCatArray[0] ;
    w2ui.gItemRanking.reload();

return MainCatArray;
}

function getValueSubCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
   
    SubCatArray[0]=IdCate ;
    SubCatArray[1]=valueCat;
   // alert(str);
    var row={rows:[]};
       row['rows'][0] = SubCatArray[0] ;
    $.ajax({
	url:'getdata_SubCategory.php',
	dataType: 'json', 
	type:'POST',
	data:row,
	async:false,
	success:function(data){ 

	    SubCat=data.records;
	
	}
	
    });
    // use ajax for to select Sub Category pass in combobox. 
   
    
//w2ui.gExport.lock('Loading..',true);
return SubCatArray;
}


function getDataSubCategory(param){
 // MainCatID= MainCatID;
     var SubCat ;
	var row={rows:[]};
       row['rows'][0] = param ;
    $.ajax({
	url:'getdata_SubCategory.php',
	dataType: 'json', 
	type:'POST',
	data:row,
	async:false,
	success:function(data){ 

	    SubCat=data.records;
	
	}
	
    });
    return SubCat;
}

function getDataMainCategory(){
      var MainCat ;
       //row['rows'][0] =  '1';
    $.ajax({
	url:'getdata_MainCategoryItem.php',
	dataType: 'json', 
	type:'POST',
	//data:row,
	async:false,
	success:function(data){ 

	    MainCat=data.records;
	
	}
	
    }); 
    return MainCat;
}


var main={
    name:'layout',
    padding:4,
    panels:[{type:'top',size:50,style:pstyle,content:'header'},
            {type:'main',style:pstyle,content:'Main Panel',   toolbar:{
                items:[	
			{ type: 'button',  id: 'backHome',  caption: 'メインページ',icon:'icn-application-home'},
			{ type: 'break' },
			{ type: 'button',  id: 'Cat_Import',  caption: 'ファイル取込', icon: 'icn-application-get' },
			{ type: 'break' },
			{ type: 'button',  id: 'Data_Output',  caption: 'データ出力', icon: 'icn-application-put' },
			{ type: 'html',  id: 'item8',
				html: '<div>'+
					'<div style="display:none;"><form id="form" action="process/import.php" method="post" enctype="multipart/form-data" target="upload_target" >'+
					    '<input id="fileupload"  name="csv" type="file" onchange="startRead()" />'+
					    '<input type="submit" id="save" name="submit"  /></div>'+
					'<iframe id="upload_target" name="upload_target" src="#" style="width:0;height:0;border:0px solid #fff;"></iframe>'+
					'<a id="downloadLink" href="" download=""></a>'+
					'</form>'+
				      '</div>'+
				      '</div>' 						    
			    },	
			    { type: 'break' },
			    {type:'html',id:'MainCat',html:htmlMaincom},
			    { type: 'break' },
			    {type:'html',id:'SubCate',html:htmlItemcom},
			{ type: 'spacer' },
			{ type: 'button',  id: 'logout', caption: 'ログアウト', icon:'icn-door-in' }   
		    ],
            onClick: function (event) {
		    //セッション確認
		    if(!session_checking()){
			switch (event.target) {
			    //Case log out application
			    case 'logout':	
				 w2ext.confirm(confirmLogout, function(btn) {
				    if (btn === w2ext.buttons.Yes) { document.location = '../logout.php'; }
				});					                                                               					
				break;
			    case 'backHome':										   
				document.location = '../PortalMain.php';						             				    
				break;	
			    case 'Cat_Import':					   
				    func_import();
				    break;
				case 'Data_Output':
				    if(w2ui.gExport.records.length > 0){
					func_export();
				    }else{
					w2ext.alertIcon = w2ext.icons.exclamation;                  
					w2ext.alert("データを出力する前に\nファイルをインポートしてください。");
				    }
				break
			    default:
				    this.owner.content('main','開発中');
			}
		    }
		}
            }},                
    ]
};

 var gItemRanking = {
	grid: { 
		name: 'gItemRanking',
                style:pstyle,
		header:'<font color="#FFF">PRODUCTS</font>',
		//autoload:true,
		url:'getdata_Items.php',
		toolbar: {
		    items: [
			{ type: 'spacer', id: 'spacer'},
			{ type: 'menu',   id: 'output', caption: '出力', img: 'icn-application-put', items: 
                                                  [
						      { id: 'outcsv',text: 'CSV', icon: 'icon-excel-csv' },
                              { id: 'outxls',text: 'Excel', icon: 'icon-excel-xls' },                                                      
						      { id: 'outxlsx',text: 'Excel2007', icon: 'icon-excel-xlsx' }
						   ]
                                               },
					   
					    { type: 'break',  id: 'break0' }
		    ],
		   
	     },
		
		show: {
	    footer:true,
	    toolbar:true,
	    toolbarReload:true,                     
	    toolbarColumns:true,
	    toolbarAdd:true,
	    toolbarDelete:true,
	    toolbarSave:true,
	    toolbarEdit:true,
	    header:true,
	    toolbarSearch:true 
			
		},
		multiSearch: true,
		searchs:[{}],
		columns: [{}],

    
	        onClick: function (event) {        
                   
		    
		},
		
		onAdd: function (){
			openPopup('Add Product',w2ui.layPopup,w2ui.fAddProduct,700,840);
		}
	}
    };
var layPopup = {
    name: 'layPopup',
    padding: 4,
    panels: [
        { type: 'main', minSize: 300, overflow: 'hidden' }
    ]
};



//------------------------- ********** FORM W2UI ***********-----------------------------------------------------
	var fAddProduct ={ 
	    form : {
		name:'fAddProduct',
		formHTML: 
		'<div id="frmWrapper" style=" float:left; width:400px; height:500px;background-color:#DDD; ">'+
		
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px;  " type="text" name="txtboxcode" size="5" >'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="30">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="30">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="30">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="30">'+
		    '</div>'+
		     '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:100px " type="text" name="txtboxcode" size="30">'+
		    '</div>'+
		     '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="10">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:15px;"> Item Code: </label>'+
			'<input style="float:left; margin:10px; height:30px " type="text" name="txtboxcode" size="10">'+
		    '</div>'+
		   
		' </div> '+
		
		'<div id="frmWrapper" style=" float:right; width:400px; height:500px;background-color:#DDD; ">'+
		'</div>'+
		
		'<div class="w2ui-buttons">'+
		'	<input class="btn btn-Green" type="button" value="Cancel" name="Cancel">'+
		'	<input  class="btn-Save" type="button" value="Save" name="Save">'+
		'</div>',
	    fields: [
		    { name: 'passwd', type: 'text', required: true },
		    { name: 'repasswd', type: 'text', required: true }
	    ],
	}
    };
//------------------------- ********** END FORM ************-----------------------------------------------------




$(document).ready(function(){
    w2utils.locale('ja-jp');
    $('#layout').w2layout(main);    
    w2ui.layout.content('main',$().w2grid(gItemRanking.grid));
    w2ui.layout.load('top','header.php');    
    $("#combo1").hide();
    
    $().w2layout(layPopup);
    $().w2form(fAddProduct.form);
    
    //$('input[type=list]').w2field('list', {options:{items:people}});
});
$(window).resize(function() {
	var wheight=$(window).height()-15;
	$("#layout").css("height",wheight);
});
$(document).keydown(function(e) {
	var element = e.target.nodeName.toLowerCase();
	if (element !== 'input' && element !== 'textarea') {
		if (e.keyCode === 8) {
			return false;
		}
	}
});
//==========Function import File========
function func_import(){
    var input = document.getElementById ("fileupload");
    input.click();
}
//==========Function on Start to read File========
function startRead() {
    var file = document.getElementById('fileupload').files[0];
    if (file) {	
	w2ui.gExport.lock('ファイル取込中...', true);
	document.getElementById('save').click();
    }
}
//==========Function on After finish Upload=======
function stopUpload(data){    	
	w2ui.gExport.unlock();	
	var record = parseJSON(data);
	console.log(record);	
	w2ui.gExport.clear();
	w2ui.gExport.records = record.Export;
	w2ui.gExport.total = record.Export.length;
	w2ui.gExport.refresh();
      $('#form').each(function(){
	    this.reset();
	});
}
//==========Function on export file CSV=======
function func_export(){
    console.log(w2ui.gExport.records);
    var record = w2ui.gExport.records;
    // prepare CSV data
    var csvData = new Array();
    csvData.push('"画像パス"');
    record.forEach(function (item, index, array) {
	csvData.push('"' + item.imagePath + '"');
    });
    // download stuff
    var buffer = csvData.join("\n");
    var uri = "data:text/csv;charset=utf8," + encodeURIComponent(buffer);
    var date = new Date();
    var yy = date.getFullYear();
    var mm = ('0' + (date.getMonth() + 1)).slice(-2);
    var dd = ('0' + date.getDate()).slice(-2);
    var HH= ('0'  + date.getHours()).slice(-2);
    var MM= ('0'+   date.getMinutes()).slice(-2);
    var ss= ('0'+   date.getSeconds()).slice(-2); 
    var fileName = yy+mm+dd+HH+MM+ss+"RCI.csv";    
    var link = document.createElement("a");
        if (link.download !== undefined) { // feature detection
            // Browsers that support HTML5 download attribute
            link.setAttribute("href", uri);
            link.setAttribute("download", fileName);
        }
        else if (navigator.msSaveBlob) { // IE 10+
            link.addEventListener("click", function (event) {
                var blob = new Blob([buffer], {
                    "type": "text/csv;charset=utf-8;"
                });
                navigator.msSaveBlob(blob, fileName);
            }, false);
        }        	
        document.body.appendChild(link);
	link.click();  
}
//==========Function on parse JSON=======
function parseJSON(data) {
    return window.JSON && window.JSON.parse ? window.JSON.parse( data ) : (new Function("return " + data))(); 
}

//---------------------- ********* func_Open form ************--------------

function openPopup(title,lobj,fobj,h,w) {
	var winh=h || 400;
	var winw=w || 600;
	
	w2popup.open({
		title 	: title,
		width	: winw,
		height	: winh,
		showMax : true,
		body 	: '<div id="main" style="position: absolute; left: 5px; top: 5px; right: 5px; bottom: 5px;"></div>',
		onOpen  : function (event) {
			event.onComplete = function () {
				$('#w2ui-popup #main').w2render(lobj);
				lobj.content('main', fobj);
			};
		},
		onMax : function (event) { 
			event.onComplete = function () {
				//w2ui.mainf.resize();
				//w2ui.frmContent.resize();
			};
		},
		onMin : function (event) {
			event.onComplete = function () {
				//w2ui.mainf.resize();
				//w2ui.frmContent.resize();
			};
		}
	});
};