/**
 * アラートダイアログ、問い合わせダイアログを表示する。
 *	w2ext.alert(メッセージ[,タイトル][,コールバック関数])
 *
 *		alertを表示する前に、毎回表示アイコンをalertIconに設定する事
 *			w2ext.alertIcon = w2ext.icons.exclamation;		//警告
 *			w2ext.alertIcon = w2ext.icons.error;			//エラー
 *			w2ext.alertIcon = w2ext.icons.accept;			//確認
 *
 *	w2ext.confirm(メッセージ[,タイトル][,コールバック関数])
 *		クリックされたボタンのidがコールバック関数の引数として返される。
 *			w2ext.buttons.Yes	// 'Yes'ボタンが押された場合
 *			w2ext.buttons.No	// 'No'ボタンが押された場合
 *		
 * @type type
 */
var w2ext = {
	btn: '',
	alertIcon: null,
	buttons: {
		Yes	: 'Yes',
		No	: 'No',
		Ok	: 'Ok'
	},
	alert: function(msg, title, callBack) {
		if (typeof callBack === 'undefined' && typeof title === 'function') {
			callBack = title;
			title = w2utils.lang('Notification');
		}
		if (typeof title === 'undefined') {
			title = w2utils.lang('Notification');
		}
		w2ext.btn = '';
		var imgicon = (w2ext.alertIcon) ? w2ext.alertIcon : w2ext.icons.exclamation;
		if ($('#w2ui-popup').length > 0) {
			w2popup.message({
				width	: 400,
				height	: 150,
				html:   '<div style="position: absolute; top: 12px; left: 0px; right: 0px; bottom: 40px; overflow: auto">'+
						'	<div class="w2ui-centered">'+
						'		<div style="font-size:13px;"><img src="'+ imgicon +'" align="middle" style="position:relative;top:-7px;left:-13px;">'+ this.Return2Br(msg) +'</div>'+
						'	</div>'+
						'</div>'+
						'<div style="position: absolute; bottom: 7px; left: 0px; right: 0px; text-align: center; padding: 5px">'+
						'   <input type="button" id="'+ w2ext.buttons.Ok +'" value="OK" onclick="w2popup.message();" class="w2ui-popup-button">'+
						'</div>',
				onOpen: function () {
					var btns = $('#w2ui-popup .w2ui-popup-message .w2ui-popup-button');
					btns.on('click', function () {
						w2popup.message();
					});
					btns.on('blur', function(){
						var bt2 = $('#w2ui-popup .w2ui-popup-message .w2ui-popup-button');
						for (var i=0;i<bt2.length;i++) {
							if (bt2[i].id === w2ext.buttons.Ok) {
								setTimeout(function() {
									$(bt2[i]).focus();
								}, 0);
								break;
							}
						}
					});
					btns.on('keydown', function(event) {
						event.preventDefault();
						switch (event.keyCode) {
							case 13: // enter
								w2popup.message();
								break;
						}
					});
					for (var i=0;i<btns.length;i++) {
						if (btns[i].id === w2ext.buttons.Ok) { $(btns[i]).focus(); break;}
					}
				},
				onClose : function () {
					if (typeof callBack === 'function') { callBack(); }
				}
		});
	} else {
			w2popup.open({
				width	: 450,
				height	: 200,
				showMax	: false,
				modal	: true,
				title	: title,
				speed	: 0.2,
				body:	'<div class="w2ui-centered">'+
						'	<div style="font-size:13px;"><img src="'+ imgicon +'" align="middle" style="position:relative;top:-7px;left:-13px;">'+ this.Return2Br(msg) +'</div>'+
						'</div>',
				buttons:'<input type="button" id="'+ w2ext.buttons.Ok +'" value="OK" class="w2ui-popup-button">',
				onOpen: function (event) {
					event.onComplete = function () {
						var btns = $('#w2ui-popup .w2ui-popup-button');
						btns.on('click', function () {
							w2popup.close();
						});
						btns.on('blur', function(){
							var bt2 = $('#w2ui-popup .w2ui-popup-button');
							for (var i=0;i<bt2.length;i++) {
								if (bt2[i].id === w2ext.buttons.Ok) {
									setTimeout(function(){
									   $(bt2[i]).focus();
									}, 0);
									break;
								}
							}
						});
						btns.on('keydown', function(event) {
							event.preventDefault();
							switch (event.keyCode) {
								case 13: // enter
									w2popup.close();
									break;
							}
						});
						for (var i=0;i<btns.length;i++) {
							if (btns[i].id === w2ext.buttons.Ok) { $(btns[i]).focus(); break;}
						}
					};
				},
				onClose : function (event) {
					event.onComplete = function() {
						if (typeof callBack === 'function') { callBack(); }
					};
				}
			});
		}
	},
	confirm : function (msg, title, callBack) {
		if (typeof callBack === 'undefined' && typeof title === 'function') {
			callBack = title;
			title = w2utils.lang('Confirmation');
		}
		if (typeof title === 'undefined') {
			title = w2utils.lang('Confirmation');
		}
		w2ext.btn = '';
		if ($('#w2ui-popup').length > 0) {
			w2popup.message({
				width	: 400,
				height	: 150,
				html:	'<div style="position:absolute;top:12px;left:0px;right:0px;bottom:40px;overflow:auto;">'+
						'	<div class="w2ui-centered">'+
						'		<div style="font-size:13px;"><img src="'+ w2ext.icons.question +'" align="middle" style="position:relative;top:-7px;left:-13px;">'+ this.Return2Br(msg) +'</div>'+
						'	</div>'+
						'</div>'+
						'<div style="position: absolute; bottom: 7px; left: 0px; right: 0px; text-align: center; padding: 5px">'+
						'   <input id="'+ w2ext.buttons.No +'" type="button" value="'+ w2utils.lang(w2ext.buttons.No) +'" class="w2ui-popup-button">'+
						'   <input id="'+ w2ext.buttons.Yes +'" type="button" value="'+ w2utils.lang(w2ext.buttons.Yes) +'" class="w2ui-popup-button">'+
						'</div>',
				onOpen: function () {
					var btns = $('#w2ui-popup .w2ui-popup-message .w2ui-popup-button');
					btns.on('click', function (event) {
						w2ext.btn = event.target.id;
						w2popup.message();
					});
					btns.on('blur', function(event){
						var bt2 = $('#w2ui-popup .w2ui-popup-message .w2ui-popup-button');
						var next = (event.target.id === w2ext.buttons.Yes) ? w2ext.buttons.No : w2ext.buttons.Yes;
						for (var i=0;i<bt2.length;i++) {
							if (bt2[i].id === next) { $(bt2[i]).focus(); event.preventDefault(); break;}
						}
					});
					btns.on('keydown', function(event) {
						event.preventDefault();
						switch (event.keyCode) {
							case 9: // tab
								$(event.target).blur();
								break;
							case 13: // enter
								$(event.target).click();
								break;
						}
					});
					for (var i=0;i<btns.length;i++) {
						if (btns[i].id === w2ext.buttons.Yes) { $(btns[i]).focus(); break;}
					}
				},
				onClose: function() {
					if (typeof callBack === 'function') { callBack(w2ext.btn); }
					w2ext.btn = '';
				}
			});
		} else {
			w2popup.open({
				width		: 450,
				height		: 200,
				title		: title,
				modal		: true,
				showClose	: false,
				speed		: 0.2,
				body:		'<div class="w2ui-centered">'+
							'	<div style="font-size:13px;"><img src="'+ w2ext.icons.question +'" align="middle" style="position:relative;top:-7px;left:-13px;">'+ this.Return2Br(msg) +'</div>'+
							'</div>',
				buttons:	'<input id="'+ w2ext.buttons.No +'" type="button" value="'+ w2utils.lang(w2ext.buttons.No) +'" class="w2ui-popup-button">'+
							'<input id="'+ w2ext.buttons.Yes +'" type="button" value="'+ w2utils.lang(w2ext.buttons.Yes) +'" class="w2ui-popup-button">',
				onOpen: function (event) {
					event.onComplete = function () {
						var btns = $('#w2ui-popup .w2ui-popup-button');
						btns.on('click', function (event) {
							w2ext.btn = event.target.id;
							w2popup.close();
						});
						btns.on('blur', function(event){
							var bt2 = $('#w2ui-popup .w2ui-popup-button');
							var next = (event.target.id === w2ext.buttons.Yes) ? w2ext.buttons.No : w2ext.buttons.Yes;
							for (var i=0;i<bt2.length;i++) {
								if (bt2[i].id === next) { $(bt2[i]).focus(); break;}
							}
						});
						btns.on('keydown', function(event) {
							event.preventDefault();
							switch (event.keyCode) {
								case 9: // tab
									$(event.target).blur();
									break;
								case 13: // enter
									$(event.target).click();
									break;
							}
						});
						for (var i=0;i<btns.length;i++) {
							if (btns[i].id === w2ext.buttons.Yes) { $(btns[i]).focus(); break;}
						}
					};
				},
				onClose: function(event) {
					event.onComplete = function() {
						if (typeof callBack === 'function') { callBack(w2ext.btn); }
						w2ext.btn = '';
					};
				}
			});
		}
	},
	Return2Br: function(html) {
		if (html === null) return html;
		switch (typeof html) {
			case 'number':
					break;
			case 'string':
					html = String(html).replace(/\n/g, "<br>");
					break;
			case 'object':
					for (var a in html) html[a] = this.Return2Br(html[a]);
					break;
		}
		return html;
	},
	icons: {
//  icons obtained from http://ec-sozai.net/
		accept: 'data:image/png;base64,'+
			'iVBORw0KGgoAAAANSUhEUgAAABsAAAAbCAYAAACN1PRVAAAABHNCSVQICAgIfAhkiAAAAAlwSFlz'+
			'AAALEgAACxIB0t1+/AAAABh0RVh0U29mdHdhcmUAQWRvYmUgRmlyZXdvcmtzT7MfTgAAABZ0RVh0'+
			'Q3JlYXRpb24gVGltZQAwMy8xNC8xMfMrQs0AAAO5SURBVEiJrZZdaFtlGMd/OUlOPtY2SQ1t1YqV'+
			'Zlvb1A5dQK0TYd4NsTVFBl6sjImFYUEUBWErYi9UJgpWyxRlIILI6FanF96osM2wyWgvuiw1plPo'+
			'apd+nX6ZtDntOV4cc3pOzpI26v8qz5PnPb/3Pe973udvm52dZRudBN7argjoA/pLFdhKwKLA0A4g'+
			'heoCzpUDU43Br3PXGEvH+GMxzmpuESk7Q8BTQ4Xop8Ef5sHadvYGI5Zn7wSmg5LzowwnBpnJpHA6'+
			'wWEHwQaCAIoCigobmyDLUOMN0dl8nD13PVQUWAhTARRVYTgxSOzWEC4RROedFm9WTob1HLTXd9HZ'+
			'fBzBJliARpgOOjP6JsmFS3g920MKlclCKNDOsYf7LcB8FM1nL4yf/tcgAK8HUlKMC+OnjemoETYE'+
			'2h5dnjyLx10+5J6q3TzT8jIAHjdcnjxLcn40//eQEQbAcGIQlwg2yzkqrUj9IV5/8msqxACgjXeJ'+
			'2vOMEvhnr25KY6QzqR0dBqMeuz9K9/53sQtOMvKSnhedkM6kuCmN5VOqvrLr6RiiozzQA9X7ONx2'+
			'Qo/tgnmmogPiM1f0WIcl50dwlAHzij6ORk6ZAPf5Wkw1TgckZn+xwpbW5hBMO1ha3fvfIeC5W4+z'+
			'8iojU9+bagQBpGzaCvtLXka4w8GwC06eCh3FK/r0XKT+EC01B/T49soEb/8U5eLvX5nG2myQkVf0'+
			'WH9xu5xVKOqCCbgn+AjPtb1BXWUjla4Aw/H3sQtOOsKv6jV/Lv/GQOwYq+uSZaKqCh7HLuvKfO4g'+
			'irJV2Bl+hd7HP6OushGAAw2HqXIFOdh4BL+7ZlsQaPdntXfrVeuwUPU+Nja2Cr9NDHD++ik2FRkA'+
			'l8PL0829HGzsBmB1XeLTq71FQQDyBjQZuoEOa6t7gpwBtqnI/DjxBe9dfB4pOw1o31SFK6Ddn9de'+
			'Yz4zVRQEkNuA1tp2E6wVoMEfptYbIiebB9xaGueDS93cXpnQc98lPiQ5d7U0SIZab4gGfzifahWA'+
			'OIBgE+ho6mE9Zx0oZaf5OPYiUnaaycUb/JA6UxIEWrvpaOox3vzx/K8+gL3BCO31XWSy1sGLazMM'+
			'/PwCX46eQFEVa4FBmazW1wzduw+K9LPPR06SkmL/ez8r2qnP3fiIK1Pny+7Uj977LNGWl7bt1CYg'+
			'aEbnm/FPzB5E0HyIomrfkdGDdDT1FBqfkh7EAsxD8+5qaW2O5fUFqlzV+NzB/+yu8tqpOS1UUbNa'+
			'6p7vR5tdXxkQWzEQwN8kyHfwFX3KEgAAAABJRU5ErkJggg==',
		exclamation: 'data:image/png;base64,'+
			'iVBORw0KGgoAAAANSUhEUgAAABsAAAAbCAYAAACN1PRVAAAABHNCSVQICAgIfAhkiAAAAAlwSFlz'+
			'AAALEgAACxIB0t1+/AAAABh0RVh0U29mdHdhcmUAQWRvYmUgRmlyZXdvcmtzT7MfTgAAABZ0RVh0'+
			'Q3JlYXRpb24gVGltZQAwMy8xNC8xMfMrQs0AAAKoSURBVEiJtZbPS1RRFMc/576ZRrOBCAYzDAyk'+
			'hdhChSAQXEj+AfoHqC0DN22kIBcKhv+Au378A7ZqEYiQIbpxbJNuDNyYvwZK0GmcZt49LV7vze83'+
			'b4i+q7nnXu7nnDnn3XMkk8nQRC+B+WaHgDlgIeyAhMDGgZUIkGpNAO9bgWnFoeMNOFxDMl8g/wOy'+
			'R9BxBxK30NQAdI+iXcM1d0eBBSA52ULSi8jFHiZukZiCgBhFrYCCFgVbMGiyDx16gd5+1BBYDfNA'+
			'6iLpV5hvbzEJi4nbetFXyBYMNm+wvdPo0HMQpwZYDiuBPs/gnH3EaXebQqrl5hzc1GN0ZLkGaP4u'+
			'xgPrzlJD0LUHz0hOZUlOZbk+9qEuzGl3cTKryM5SuXm8HLYCXo7M/muctuYR6e+fDfecNhez/xo5'+
			'2fJNK+UwL6r0IiZh69RRPdh5400Bk7BIerHCbPBzdbYdVF0U2YuD0H0Tt8jFHpxtB/4FkcnhWmRQ'+
			'VJmYRb5/Kq0D2MmW9x1FlOZD/kb/zrgiR+u1MHKniITDTPJeZGfA+/jJHteB5c+ryiVc9jI8Zx4N'+
			'KCukWPArcRPsr1Dg1eYMV5sz0T1SIJ4MlqWr2ztRjVDzLUitwI3uWph2PkSL4bCOia/BCxK//6Q5'+
			'rCgV3aAEuzuGLbSQtAiyBYN2j1bA+gFIDaDJvsjAZgXitx1SA76p3wC7AIiDDs5i841hrZS+zRt0'+
			'cLb85d/1q3EOmNeuYWzvNO7Bm7qv/sW7jkggN+d4fa2Urzlo1M/Wn+JkVv9bPwsMiIOOLOP2TFK8'+
			'jEXPYcFQvIzh9kzWBVVH5qs0gxxvIDtLFTOIiHouWlCVyhlkcLZ68AmdQWqAPjSYrnKnkMtAe8p7'+
			'CP5xuvIVdTitVsNhNSwhC3jezbUAkUYggD/OJSPPzlV+/wAAAABJRU5ErkJggg==',
		error: 'data:image/png;base64,'+
			'iVBORw0KGgoAAAANSUhEUgAAABsAAAAbCAYAAACN1PRVAAAABHNCSVQICAgIfAhkiAAAAAlwSFlz'+
			'AAALEgAACxIB0t1+/AAAABh0RVh0U29mdHdhcmUAQWRvYmUgRmlyZXdvcmtzT7MfTgAAABZ0RVh0'+
			'Q3JlYXRpb24gVGltZQAwMy8xNC8xMfMrQs0AAAOzSURBVEiJpZZPTBxVHMc/7w3LLruLTaPdbsXY'+
			'NlE8aPQgSGtigNI0Nr0YTCVkE26NaYxR0R7lYI8C0igxjYfGEDSaYLySSGAltl2QUo0X0It/SmFG'+
			'00JZlmWYeR7orPP2sRTi9/Z+8+b3eb8333nvJxzH4QF6H/jgQZOAHuDiThPEDrB2YGQXkHK9Cnyz'+
			'F5gKD25dv8bv2XHsn39i/c4dVhdvk0wfIrZ/P6lnn+Nwcyt1x44buXcDK4EWpnPk+nu5Nz9HVAoi'+
			'QiAQWAI8BQqFqxRFX1Fb/xRN3e/xaGNTRWA5TAEo3yfX/yHzXw5TIyVRaSzSUNFXFHyf+s4MTd0X'+
			'EFIawDCsBBq70M1SdpykJc292EEKWPV8Ui81c7JvwAAGo/YgOjXQx1J2nNo9goKMtZbEnswyNdAX'+
			'ftQeho3A1jeaGx4iaUk9iWURiSe2BVixGMKytFjSkswND7EwnQtCI2EYALn+XmqkXpGwLFovDXLq'+
			'ypABtGIxXv78C1ovDWpAAdRISa6/V5svuf+tFm/eYOW+68pBR06f4WBDowYMQAcbGjly+owBjErB'+
			'yvwcizdvBCFVquyP7IThuqpojHg6XRoHwJoDB0qgQPF0mqpoTHs/KgV/Tn6vVQbAwlSOaqHD3LU8'+
			'o10Z7NkZDfjaxFUNZM/OMNqVwV3La+9XC8FfV38wYXnbRgrTfwFw6cfpUsyK/VdBJRCAFILVxdsm'+
			'rLiyXNHq7lqesfPn8NbXtbi3vs7Y+XPbgoLkxeVlExZ9aJ9+IIZkxWK0ffqZVlEQP/HJ5Yq/hQKq'+
			'k0kTlkil8JWJC7suXFGgcpeG5SlFbd1jJuzQ8w1slMEi8YQBsmdn+LrlRcM02wE3lNJugxLs8Ik2'+
			'ir4O89wNCo6tgUa7MhQcx3BpwbHx3A3t/aKveLy5pTQWjuM8DfyifJ9vMx1s/var9r/JSISWjz4m'+
			'nk4brovEE5y6MkTBsZl4501819VAVU88ySvDXwUH8jPBqa9g65Ice+N19lVZmjNlJIIVqd7WdZF4'+
			'As/d0EAKWN70aBu8HN5GEWxjD0DdsePUd2ZY9Xwtoe+6Fe3truU1EGxdM/WdmTCoJ9jG8IJQvs93'+
			'776NPZmltuz0343u7eI+KwWElJzsG+Do2Q7ubnqGaSqp6CvubnocPduxLai8skCl7LeuX2PqUr/W'+
			'g0ghkIAP+ErvQV54q7u88dmxBzGAATTorvK2TeGfv6l5+BESqdT/7q4C7bY5LVfFZnUnB1xka3U9'+
			'e4CISiCAfwHJg65g4mpiKQAAAABJRU5ErkJggg==',
		question: 'data:image/png;base64,'+
			'iVBORw0KGgoAAAANSUhEUgAAABsAAAAbCAYAAACN1PRVAAAABHNCSVQICAgIfAhkiAAAAAlwSFlz'+
			'AAALEgAACxIB0t1+/AAAABh0RVh0U29mdHdhcmUAQWRvYmUgRmlyZXdvcmtzT7MfTgAAABZ0RVh0'+
			'Q3JlYXRpb24gVGltZQAwMy8xNC8xMfMrQs0AAANCSURBVEiJrZbNbxNHGIefmXXiOHEajIMtFKIC'+
			'iapUQZhU4kIrLhE5V66qtJXyB3DoDbg1quDWcqv6FyARQCLihgTlAmouPSQrFIGiElRFbonzYYId'+
			'25tkZ3pwd+3x+iuF32n21cw+85uv9xUbGxu00Q/A9XadgFngRqsOogUsDdzvAFKvr4D5w8B07cfy'+
			'epnFTJE/txzyjmKreEC8N0R/WDIaDzMx1Mt4sifw705gPuhFtszcUo61d/tIIRBSAAIhQOtKV600'+
			'SmuGP+ri23MxPk0YUANYD9MASsOdpW0evyogpUTKwCQDUkqjlOLSSJRvzh2lZojfqoX5oF8XNlh8'+
			'U8ayZFtIvVxXkUqG+f7zRADo/S3tRe/Zuf8NArAsib3ucM/O1YbTUHWmobJHPz3NEgpZgZ+MDEZI'+
			'pxJcOHXEj9mZPI9ebrPw+m2g/8GBy7WLido9FMb055ZySBl0NDIY4eaXnxgggNRQP1cnP2ZqLB4Y'+
			'I6VkbilnxjxXK5sOazv7DQ/D1cmTfrvguNz64x/sTN6PzZw/TjRsroaUgrWdfVY2HS+kfRuLmWJD'+
			'ULK/m2R/t/995cEK83aWHx+usp7fAyAatujrDi69lAL775L/HfIaL7Ll/+6Rqd29ihPPlQeYGosb'+
			'k9jdcwNjhRQ8f1Pi67NHTFiu5CKCl56C4zJvZ43Y5S9OGPu08PotBacBTAi2igdVp9WZqQYPTFDp'+
			'VMIA2Zk8Pz/5q2n/3T3lt31nfd2SoktbYO2JnLez/hI3U6Srerr9Vixioc33t6G8U/dqs9QWpLXm'+
			'WJ/vp+ps7FgPa+8KCKu1tUcvtwAa7lEAprSRDXxnn53oRan2zqbG4sycP86FUwNt+yqlmRjqNWBn'+
			'AEbjYYYHujoCdiKlNMMDXYzGw17oTAhYBpACplMxbj7LImXwgnrqdBmVUkynBmtf/mVvz2aB6+PJ'+
			'Hi6NRPltdbfpq19/5xrJdSt5rWa/ZqFJPvvl9yz2uvPB81nTTH17cZsnq4fP1JOno3w30T5TG0Co'+
			'FDp3bbMGEYjKcA26rgaZTsXqC5+WNUgA6EG96ipXctkpuwz0WMQi1ntXV546LU7r1bRYbXUCblCZ'+
			'3ewhIKIZCOBfhDxozvp/VHsAAAAASUVORK5CYII='
	}
};
