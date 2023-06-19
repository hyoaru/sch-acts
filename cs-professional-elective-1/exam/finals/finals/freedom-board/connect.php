<?php 
    $connection = new mysqli('localhost', 'root', '', 'freedom_board');
    if (!$connection) {
        die(mysqli_error($connection));
    }
?>
