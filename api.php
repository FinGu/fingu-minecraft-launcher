<?php

if (isset($_GET["vc"])) {
	$version = '1.2';

	die($version);
}
if (isset($_GET["lg"])) {
	$data = "
    Welcome to my Minecraft Launcher!!
    The most recent logs are :
    snake_case
    ";

	die($data);
}
