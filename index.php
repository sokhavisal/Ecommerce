<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<?php
include ("func_Category.php");

?>
<html>
    <head>
        <meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="css/css.css">
	<script src="js/js.js"></script>
	<link rel="stylesheet" href="css/styles.css">
	<script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
	<script src="js/script.js"></script>
        <title>Mywebsite</title>
    </head>
    <body>
	<div id="nav">
	    
	   
	    <div id="nav-wrapper">
		<div id="Logo">
		    <img  src="logo/logo.gif" width="300px" height="50px">
		</div>
		<ul>
		    <li><a href="#">Home</a>
		    <li><a href="#">About us</a>
		    <li><a href="#">Contact</a>
			
		</ul>
	    </div>
	  	
	    <div id="search">
		<div id="search-box">
		    <input id="txtSearch" type="textbox" name="txtsearch"  placeholder="search Product..." width="80px" height="30px" >
		    <input id="btnsearch" type="button" value="Search" >   
		</div>
	    </div>
	    
	</div>
	<div style="clear: both;"></div>	
	
<div id ="wrapper">
	
	<div id="leftside" > <!-- block leftSide -->
	    
	    
	    <!-- ************************ Start of Category Item. *********************** -->
	    
	  <?php echo $htmlCateogry; ?>
	    
	    <!-- ************************** End one of Category Item. *********************** -->
	    
	    <br>
	 
	 <!-- Accesory Category Item. -->
	    <div id='cssmenu'>
		<ul>
		   <li class='active'><a href='#'><span>Ranking Product</span></a></li>
		   <li class='has-sub'><a href='#'><span>Products </span></a>
		      <ul>
			 <li><a href='#'><span>10000$ - 30000$ </span></a></li>
			 <li><a href='#'><span>Product 2</span></a></li>
			 <li class='last'><a href='#'><span>Product 3</span></a></li>
		      </ul>
		   </li>
		   <li class='has-sub'><a href='#'><span>About</span></a>
		      <ul>
			 <li><a href='#'><span>Company</span></a></li>
			 <li class='last'><a href='#'><span>Contact</span></a></li>
		      </ul>
		   </li>
<!--		   ///<li class='last'><a href='#'><span>Contact</span></a></li>-->
		</ul>
	    </div> <!--- End of Accesory Category Item. -->
	    
	     
	    
	</div> <!--- End of Block LeftSide. -->
	
    
	<div id ="content">
	    <div id="home">
		<div id="Wrap-Privousbtn">
		    <input id="btnNext" type="button" value="Next" >
		    <input id="btnPrivous" type="button" value="Privous" >
		</div>
	    </div>
	    <div id="Pro-header">
		<p id="Pro-title">Product Title</p>
	    </div>
	   <div id="Pro-show"> <!-- Box for show Item. -->
	       
	       
		<div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
	       
	       
	       
	       <div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
	       
	       
	       
	       <div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
	       
	       
	       
	       <div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
	       <div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
	       
	       
	       
	       <div Class="Pro-Box"> <!-- Box for Item. -->
		    <div class="imagBox"><!-- Box for Image. -->
			
			<img src="img/golf.jpg" width="190px" height="170px" >
			
		    </div><!-- End of Image. -->
		   
		    
		    <div class="ImagBox-Dec"><!-- Box for Image Description. -->
			<p> Model: 1201-aaa199</p>
			<p>color: blue.</p>
			<p>years: 2012.</p>
			<p> Price: 120000$</p>
			
			
		    </div><!-- End of Box for Image Description. -->
		    
		    <div class="Pro-btnView"><!-- Box for for Button View. -->
			
			<input class="mybtn" name="btnview" type="button" value="View Detail">
		    </div><!-- End of Box for Button View. -->
		</div>
		<div style="clear: both;"></div>	
	    
		</div> <!-- End of Box for Item. -->
	<div class="Pro-Privouse">
	    <div id="Wrap-Privousbtn">
		 <input id="btnNext" type="button" value="Next" >
		 <input id="btnPrivous" type="button" value="Privous" >
	    </div>
	</div>
		
	<div id="Otherllogo"><!-- start block for Sponsor -->
	       <div id="Otherllogo-header">
		   <h3> Other Sponsor</h3>
	       </div>
	    <div id="Sponsor">
		<img src="img/bnr07.jpg" >
	    </div>
	    <div id="Sponsor">
		<img src="img/top_newreview.gif" >
	    </div>
	    <div id="Sponsor">
		<img src="img/bnr_ato_labo.gif" >
	    </div>
	    <div id="Sponsor">
		<img src="img/top_dictionary.gif" >
	    </div>
	</div><!-- End of block Sponsor -->
	
	<div id="facebook-likebox">
	<div class="fb-like-box" data-href="https://www.facebook.com/atomicgolf.jp" data-width="990px" data-colorscheme="light" data-show-faces="true" data-header="true" data-stream="false" data-show-border="true"></div>
	    
	</div>
	
	
</div> <!-- End of Content. -->
 
	 
    

    <div id="footer">
		<div id="footerMenu">
		    <div id="footer-nav">
			<ul>
			    <li><a href="#">Home</a>
			    <li> | </li>
			    <li><a href="#">About us</a>
				<li> | </li>
			    <li><a href="#">Contact</a>
				<li> | </li>
			    <li><a href="#">Home</a>
				<li> | </li>
			    <li><a href="#">About us</a>
				<li> | </li>
			    <li><a href="#">Contact</a>
				<li> | </li>
			    <li><a href="#">Home</a>
				<li> | </li>
			    <li><a href="#">About us</a>
				<li> | </li>
			    <li><a href="#">Contact</a>
			</ul>
		    </div>
		</div>
		<div id="copy"><span>Copyright &copy; Khmer Kon Kat.,Ltd. All Rights Reserved.</span></div>
    </div>
	
	   
</div>
<div id="fb-root"></div>
<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.0";
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>	

	
    
    </body>
</html>
