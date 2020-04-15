<?php

if(isset($_GET["vc"])) {
    $version = '1.2';
    echo $version;
}
if(isset($_GET["lg"])){
    $data = "
    Welcome to my Minecraft Launcher!!
    The most recent logs are :
    Decent GUI,
    Bugs Fix,
    Updated dependencies
    ";
    echo $data;
}

