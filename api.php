<?php

if(isset($_GET["vc"])) {
    $version = '1.1';
    echo $version;
}
if(isset($_GET["lg"])){
    $data = "
    Welcome to my Minecraft Launcher!!
    The most recent logs are :
    First release,
    Settings added,
    Decent GUI
    ";
    echo $data;
}

