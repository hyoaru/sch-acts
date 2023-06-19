<?php 
    include 'connect.php';
    session_start();
    if (isset($_POST['login'])) {
        $username = $_POST['username'];
        $password = $_POST['password'];
        
        $query = "SELECT * FROM `admins` WHERE username = '$username' AND password = '$password'";
        $result = mysqli_query($connection, $query);

        if ($result && mysqli_num_rows($result) > 0) {
            $_SESSION['is_authenticated'] = TRUE;
            header('location:index.php');
        } else {
            die(mysqli_error($connection));
        }
    }
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Freedom Board</title>

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
</head>

<body>
    <?php include 'components/default/header.php' ?>
    <div class="container">
        <form method="POST">
            <div class="d-flex align-items-center justify-content-center mb-3">
                <div class="rounded-5 my-4">
                    <h3 class="fw-bold text-center mb-3">Admin login</h3>
                    <div class="mb-2">
                        <input type="text" name="username" id="" class="form-control" placeholder="Enter username">
                    </div>
                    <div class="mb-2">
                        <input type="password" name="password" id="" class="form-control" placeholder="Enter password">
                    </div>
                    <div class="d-flex mt-3">
                        <button type="submit" name="login" class="btn btn-primary mx-auto">Log in</button>
                    </div>
                </div>
            </div>
        </form>
    </div>

    <?php include 'components/default/footer.php' ?>    
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>

</html>