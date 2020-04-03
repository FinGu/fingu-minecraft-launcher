<?php

if(isset($_GET["vc"])) {
    $version = '1.2';
    echo $version;
}
if(isset($_GET["lg"])){
    $data = "
    Welcome to my Minecraft Launcher!!
    The most recent logs are :
    Settings added,
    Decent GUI,
    Bugs Fix
    ";
    echo $data;
}

