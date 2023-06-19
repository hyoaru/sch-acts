<?php 
    include 'connect.php';
    session_start();

    if (isset($_GET['id']) && $_SESSION['is_authenticated']) {
        $id = $_GET['id'];
        $query = "UPDATE `posts` SET `is_archived` = '1' WHERE `posts`.`id` = $id";
        $result = mysqli_query($connection, $query);
        if ($result) {
            header('location:index.php');
        } else {
            die(mysqli_error($connection));
        }
    }
?>