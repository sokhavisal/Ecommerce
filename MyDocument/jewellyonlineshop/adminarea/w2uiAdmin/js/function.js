
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
var htmlMaincom='';
var SubCat;
var htmlItemcom='';
var obj = getDataMainCategory();



//--------------------*************** block Function *******************---------------------------------------
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


function countobj(obj){
    var count = 0;
    for (var k in obj) {
	if (obj.hasOwnProperty(k)) {
	   ++count;
	}
    }
    return count;
}

function getValueCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
    var SubCat;
    var row={rows:[]};
    
	MainCatArray[0]=IdCate ;
	MainCatArray[1]=valueCat;
	
	row['rows'][0] = MainCatArray[0] ;
	$.ajax({
	url:'getdata_SubCategory.php',
	dataType: 'json', 
	type:'POST',
	data:row,
	async:false,
	    success:function(data){ 


		if ( data == null){
		  
		    MainCatArray[2] =" ";
		    w2ui['fAddProduct'].record['fSubCat']=' ';
		}else{

		     SubCat=data.records;
		     MainCatArray[2]=SubCat.SubCatName;
		}


	    }
	
	});
   
	var option = $('<option></option>').attr("value", "option value").text("Text");
	$("#SubSelect").empty().append(option);

	 var $el = $("#SubSelect");
	$el.empty(); // remove old options
	$.each(MainCatArray[2], function(value,key) {
	    $el.append($("<option></option>")
	    .attr("value", key).text(key));
	});
	
	 w2ui['fAddProduct'].record['fMainCat']=MainCatArray[1];
	//document.getElementById("fMainCat").value=MainCatArray[1];
	w2ui.gItemRanking.url='getdata_Items.php?MainCat='+ MainCatArray[0] ;
	w2ui.gItemRanking.reload();
	w2ui['fAddProduct'].record['fSubCat']=' ';
	
	//alert(MainCatArray[0]);
return MainCatArray;
}


function getValueSubCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
   
    SubCatArray[0]=IdCate ;
    SubCatArray[1]=valueCat;
   // var SubCatId=SubCatArray.split(",");
    //alert(SubCatArray[1]);
    w2ui['fAddProduct'].record['fSubCat']=SubCatArray[1];
   // document.getElementById("fSubCat").value=SubCatArray[1];
       w2ui.fAddProduct.refresh();
return SubCatArray;
}

function getDataMainCategory(){
	var MainCat ;
	$.ajax({
	    url:'getdata_MainCategoryItem.php',
	    dataType: 'json', 
	    type:'POST',
	    //data:row,
	    async:false,
	    success:function(data){ 

		MainCat= data.records;
	    }

	}); 

	return MainCat;
}

//function getDataSubCategory(){
//	var SubCat ;
//	var row={rows:[]},
//	$.ajax({
//	    url:'getdata_SubCategory.php',
//	    dataType: 'json', 
//	    type:'POST',
//	    data:row,
//	    async:false,
//	    success:function(data){ 
//
//		 SubCat=data.records;
//	    }
//
//	}); 
//
//	return SubCat;
//}


function getvalueCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
   // alert(IdCate);
    return IdCate;
}

function readURL(input) {
if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
        $('#preview').attr('src', e.target.result);
	recordChanged=true;
       }
        reader.readAsDataURL(input.files[0]);
       }

}

function readURLp1(input) {
    if (input.files && input.files[0]) { 
	    var reader = new FileReader();
	    reader.onload = function (e) {
		$('#preview1').attr('src', e.target.result);
		document.getElementById("fileName1").value=input.files[0]['name']; 
		recordChanged=true;
	   }
	    reader.readAsDataURL(input.files[0]);
    }
}

function uploadAjax(id,FileName){ 
    _file = document.getElementById(id);
    if(_file.files.length === 0){
        return false;
    }
    var fileUpload = new FormData();
    fileUpload.append('SelectedFile', _file.files[0]);
    var fileName=[];
   
    $.ajax({
	url: "upload.php?f="+FileName, // Url to which the request is send
	type: "POST",             // Type of request to be send, called as method
	data: fileUpload, // Data sent to server, a set of key/value pairs (i.e. form fields and values)
	contentType: false,       // The content type used when sending data to the server.
	cache: false,             // To unable request pages to be cached
	processData:false,        // To send DOMDocument or non processed data file it is set to false
	async:false,
	success: function(data)   // A function to be called if request succeeds
	{
	  fileName=  data;
	  //(data);
	}
	});
	return fileName;
     
}
//--------------------*************** End block Function *******************---------------------------------------




// variable for create MainCategory combobox in toolbar. 

    htmlMaincom+='<form  name=myform><label>Category Item : </label>';
    htmlMaincom+='<select style="margin: 0px 0px 0px 15px;" id="my_select" name="MainCat" onchange="getValueCombo(this);">';
    htmlMaincom+='<option name=0000 value=0000 id="0" selected > All Items </option>';
    for(var i=0;i<countobj(obj.id);i++){
    htmlMaincom+='<option name='+obj.MainCat[i]+' value='+ obj.id[i]+' id='+ obj.id[i]+' >'+obj.MainCat[i]+' </option>';
    }
    htmlMaincom+='</select>';
    htmlMaincom+='</form>';



    htmlItemcom+='<form id="combo1" name=myform><label> Item Type : </label>';
    htmlItemcom+='<select style="margin: 0px 0px 0px 40px;" id="SubSelect" onchange="getValueSubCombo(this);">';
    htmlItemcom+='<option name=0000 value=0000 id="0" selected >  </option>';
    htmlItemcom+='</select>';
    htmlItemcom+='</form>';










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
			  // {type:'html',id:'SubSelect',html:htmlItemcom},
			{ type: 'spacer' },
			{ type: 'button',  id: 'logout', caption: 'ログアウト', icon:'icn-door-in' }   
		    ],
            onClick: function (event) {
		var list;
		  $.ajax({
	url:'getdata_MainCategoryItem.php',
	dataType: 'json', 
	type:'POST',
	//data:row,
	sync:false,
	success:function(data){
	   list=data.records;
	   
	}
	
    });
//		    if(!session_checking()){
//			switch (event.target) {
//			    //Case log out application
//			    case 'logout':	
//				 w2ext.confirm(confirmLogout, function(btn) {
//				    if (btn === w2ext.buttons.Yes) { document.location = '../logout.php'; }
//				});					                                                               					
//				break;
//			    case 'backHome':										   
//				document.location = '../PortalMain.php';						             				    
//				break;	
//			    case 'Cat_Import':					   
//				    func_import();
//				    break;
//				case 'Data_Output':
//				    if(w2ui.gExport.records.length > 0){
//					func_export();
//				    }else{
//					w2ext.alertIcon = w2ext.icons.exclamation;                  
//					w2ext.alert("データを出力する前に\nファイルをインポートしてください。");
//				    }
//				break
//			    default:
//				    this.owner.content('main','開発中');
//			}
//		    }
		}
            }},                
    ]
};

 var gItemRanking = {
	grid: { 
		name: 'gItemRanking',
                style:pstyle,
		header:'<font color="#FFF">PRODUCTS</font>',
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
		   //w2ui.gItemRanking.select(1);
		openPopup('Add Product',w2ui.layPopup,w2ui.fAddProduct,700,1000);
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


var MainCat=getDataMainCategory();
//------------------------- ********** FORM W2UI ***********-----------------------------------------------------
	var fAddProduct ={ 
	    form : {
		name:'fAddProduct',
		formHTML: 
			
			
	' <div class="w2ui-page page-0">'+


		
		'<div id="frmWrapper" style=" float:left; width:400px; height:500px;background-color:#FFF; ">'+
		
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:5px;"> Item Code: </label>'+
			'<input  style=" font-size:12px; float:left; margin:0px 0px 0px 40px;  " type="text" name="itemcode" size="15" placeholder="ex.GD001......." >'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			//'<label style="float:left; margin:5px;"> Main Category: </label>'+
			htmlMaincom +
			'<input style="float:left; display:none;  margin: 0px 0px 0px 10px ; height:30px " type="text"  id="fMainCat" name="fMainCat" size="10" placeholder="ex:Ring,Ear.......">'+
			//'<input id="comMainCat" style="float:left; margin: 0px 0px 0px 10px; height:30px " type="text" name="comMainCat" size="33" placeholder="ex:Diamond,Gold,Silver...." onchange="getvalueCombo(this);">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			htmlItemcom +
			'<input style="float:left;  display:none;  margin: 0px 0px 0px 10px ; height:30px " type="text"  id="fSubCat" name="fSubCat" size="10" placeholder="ex:Ring,Ear.......">'+
			//'<label style="float:left; margin:5px;"> Sub Category: </label>'+
			//'<input style="float:left; margin: 0px 0px 0px 10px ; height:30px " type="text"  id="SubCat" name="SubCat" size="35" placeholder="ex:Ring,Ear.......">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:5px;"> Item Name: </label>'+
			'<input style="float:left; margin:0px 0px 0px 30px; height:30px " type="text"  id="itemname" name="itemname" size="35" placeholder="ex:DiaRing DR001.......">'+
		    '</div>'+
		    '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:5px;"> Price: </label>'+
			'<input style="float:left; margin: 0px 0px 0px 65px ; height:30px " type="text" name="itemprice" size="35" placeholder="ex: 1000$">'+
		    '</div>'+
		     '<div style=" width:400px; height:150px;"> '+
			'<label style="float:left; margin:5px;"> Description: </label>'+
			'<textarea style="float:left; margin: 0px 0px 0px 30px; height:130px; width:290px; resize:none;" type="text" name="itemdescription" size="50" placeholder="ex:Discount 10% ......." required></textarea>'+
		    '</div>'+
		     '<div style=" width:400px; height:50px;"> '+
			'<label style="float:left; margin:5px;"> ImageURL: </label>'+
			'<textarea style="float:left; resize:none; margin:0px 0px 0px 40px; height:40px; width:280px" type="text" name="itemimageurl" size="35" placeholder="ex:wwww.jewelly.com/admin/photos/Diamond001.jpg"></textarea>'+
		    '</div>'+
		    '<div style=" width:400px; height:60px;"> '+
			'<label style="float:left; margin:5px;"> Type: </label>'+
			'<input style="float:left; margin: 0px 0px 0px 70px ; height:30px " type="text" name="itemtype" size="15" placeholder="ex:Feature, last , soon .......">'+
		    '</div>'+
		   
		' </div> '+
	
		'<div id="frmWrapper" style=" float:right; width:555px; height:500px;background-color:#FFF; ">'+
		
		    '<div id="tilte" style=" text-align:center;float:left; width:400px; height:30px; margin:10px ;" >'+
			'<h3 style="color:#0099cc">PRODUCTS DETAIL </h3>'+
		    '</div>'+
		    
		    '<div id="Detail"style=" float:left; margin:5px; width:220px; height:460px;background-color:#f7f7f7; " >'+
			'<center><h4 style="color:#088da5; margin:5px;">Detail</label></h4>'+
			'<textarea style="float:left; margin:5px 0px 0px 5px; height:420px; width:210px; resize:none;" type="text" name="txtboxcode" size="50" placeholder="ex:Discount 10% ......."></textarea>'+
		    '</div>'+
		    '<div id="Detail"style=" float:right; margin:5px; width:310px; height:460px;background-color:#f7f7f7; " >'+
			'<center><h4 style="color:#088da5; margin:5px;">Image</label></h4>'+
			
                '	    <div style="width:235px;height:150px;border:1px solid #CCCCCC;padding:0px;">'+               
		'		 <input name="image" type="text" maxlength="2" style="width: 235px; display:none; " readonly>'+
		'		 <img alt="Image Display Here" width="235px" height="150px" id="preview1" src="#" />'+
		'	    </div>'+
			    '<div>'+                
		'		<input name="fileName1" id="fileName1" type="text" style="width: 150px; " readonly >'+
		'		<button class="btn btn-green" name="browse" onclick="filePreview1.click();" >Browse</button>'+
                '	    </div>'+
			'<div style="float:right; display:none; margin:5px;">'+
			    
			 '<form action="upload.php" method="post" enctype="multipart/form-data" name="formPreview1" id="formPreview1">'+
			 //'<img src="" alt="Image Here" height="130" width="130" border="0" id="preview1" src="#" > ' +
			   ' <input onchange="readURLp1(this);" type="file" name="filePreview1" id="filePreview1" accept="image/*" /> '+
			// '<input type="file" name="datafile" size="0">' +
			 '</form>'+
			 '</div>'+
			 
			
		    '</div>'+
		    
		'</div>'+
		
		' <div style="clear:both;"></div>'+
		
                
		'<div style="width:964px; height:50px; background-color:#FFF; margin:10px 0px 0px 0px ; ">'+
//		   '<center ><input type="button" class="btn btn-blue" style="margin:10px;" value="Cancel" name="Cancel"><input class="btn btn-blue" type="button" value="Save" name="Save"></center>'+
		//'<div class="w2ui-buttons">'+
		    '<center >'+
                    '<button  style="margin:10px;" class="btn btn-blue" name="reset">Reset</button>'+
                    '<button  style="margin:10px;" class="btn btn-blue" name="save">Save</button>'+
		    '</center>'+
		    '</div>'+
		'</div>'+
		'</div>',
		
		
	    fields: [
		     { name: 'itemcode', type: 'text', required: true },
		     { name: 'itemname', type: 'text', required: true },
		     { name: 'itemprice', type: 'text', required: true },
		     { name: 'MainCat', type: 'text', required: true},
		      { name: 'fMainCat', type: 'text', required: true},
		     { name: 'SubSelect', type: 'text', required: true},
		      { name: 'fSubCat', type: 'text', required: true},
		     { name: 'itemdescription', type: 'text', required:true},
		     { name: 'itemimageurl', type: 'text', required: true },
		     { name: 'itemtype', type: 'text', required: true },
		     { name: 'image', type: 'text',  html: { caption: 'logo', attr: 'size="50" ' } },
		    
	    ],
	     actions: {
		    onLoad: function (){
			    $('#itemname').load('sfsdf');
			    
		    },
		    
		    reset: function(event){
			var records= this.record;
			//alert(records.fMainCat);
		    },
		     save: function (event) {
			 var records=this.record;
			 var row={rows:[]};
			 row['rows'][0]=records;
			 $.ajax({
			    url:'dbsMain.php?T=save&tbl=0',
			    data:row,
			    type:"POST",
			    success:function (data){
				alert(data);
				
			    }
			 });
			// alert(records.fSubCat);
			var fileUpload =uploadAjax('filePreview1','Pro'+w2ui['fAddProduct'].record['itemname']);
			if (fileUpload !==false){
			    if (fileUpload.status=='error'){
				 w2ext.alertIcon = w2ext.icons.error;
				 w2ext.alert("Error Upload Logo: " + fileUpload.data);
				 return;
			    }else{
				
				 w2ui['formMain'].record['Logo']=fileUpload.data;
				 w2ui['formMain'].refresh();
			    }
			}
			
		     }
	    }
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