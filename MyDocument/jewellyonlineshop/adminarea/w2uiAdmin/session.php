<?php
    session_start();
    if( time() - $_SESSION['last_activity'] > $_SESSION["time_out"])
    {
        echo '-1';
    }else{
        $_SESSION['last_activity'] = time();
    }
?>