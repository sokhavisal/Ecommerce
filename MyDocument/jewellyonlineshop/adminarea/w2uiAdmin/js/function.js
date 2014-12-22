
var pstyle = 'background-color: #FFF; border: 1px solid #dfdfdf; padding: 5px;';
var confirmLogout = 'ログアウトします。<br>よろしでしょうか？';
var msg_logoutConfirm = '保存されていない情報があります。<br>ログアウトすると、編集内容は失われます。<br><br>ログアウトしますか？';
var MSG_RELOAD	= "まだ保存されていない情報があります。\n再読み込みすると、編集内容は失われます。\n\n再読み込みしますか？";
var popSiirePalam='';
var rc='';
var rs='';
var MainCat='';
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
// variable for create combobox in toolbar. 
var htmlMaincom='';
htmlMaincom+='<input type="button" onclick="getDataMainCategory();"><form name=myform><label> Main Category Items: </label>';
htmlMaincom+='<select id="my_select" onchange="">';
htmlMaincom+='<option name=one value=one id="0" selected >  </option>';
htmlMaincom+='<option name=one value=one id="1" > Diamond </option>';
htmlMaincom+='<option name=two value=two id="2"> Gold </option>';
htmlMaincom+='<option name=three value=three id="3"> Silver </option>';
htmlMaincom+='<option name=four value=four id="4"> four </option>';
htmlMaincom+='</select>';
htmlMaincom+='</form>';

function getValueCombo(s){
    var valueCat=(s[s.selectedIndex].value); // get value
    var IdCate=(s[s.selectedIndex].id);
    var CmboArr=new Array();
cmboArry=[IdCate,valueCat];
alert(cmboArry);
w2ui.gExport.lock('Loading..',true);
return cmboArry;
}

function getDataMainCategory(){
     var MainCatearr=new Array();
      var MainCat ;
       //row['rows'][0] =  '1';
    $.ajax({
	url:'getdata_MainCategoryItem.php',
	dataType: 'json', 
	type:'POST',
	//data:row,
	async:false,
	success:function(data){ 
//	$.each(data.records, function(key, value) {
//	   MainCatearr[key]=value;
//	    alert(MainCatearr[key]);
//});
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
			    {type:'html',id:'SubCate',html:htmlMaincom},
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


/*============== Grid==============*/
var gExport={
       name: 'gExport', 
        header: 'Products ',
        show: { header: true , footer: true,  toolbar     : true,  toolbarAdd: true,
            toolbarDelete: true,
            toolbarSave: true,
            toolbarEdit: true},
        columns: [                
            { field: 'recid', caption: 'Code', size: '20', sortable: true, attr: 'align=center' },
            { field: 'imagePath', caption: 'Item Type', size: '30%', sortable: true },
	    { field: 'imagePath', caption: 'Category', size: '30%', sortable: true },
	    { field: 'imagePath', caption: 'Item Name', size: '30%', sortable: true },
	    { field: 'imagePath', caption: 'Item Price', size: '30%', sortable: true },
	    { field: 'imagePath', caption: 'Images', size: '30%', sortable: true },
	    { field: 'imagePath', caption: 'Description', size: '50%', sortable: true },
	     { field: 'imagePath', caption: 'Path', size: '30%', sortable: true }
	    
        ]
};


$(document).ready(function(){
    w2utils.locale('ja-jp');
    $('#layout').w2layout(main);    
    w2ui.layout.content('main',$().w2grid(gExport));
    w2ui.layout.load('top','header.php');   
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