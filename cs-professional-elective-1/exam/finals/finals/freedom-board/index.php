<?php
    include 'connect.php';
    session_start();

    $query = "SELECT * FROM `posts` WHERE is_archived = FALSE AND category IS NULL";

    if (isset($_GET['category'])) {
        $category = $_GET['category'];
        $query = "SELECT * FROM `posts` WHERE is_archived = FALSE AND category = '$category'";
    }

    $result = mysqli_query($connection, $query);
    $categoryQuery = "SELECT DISTINCT `category`, `is_archived` FROM `posts` WHERE is_archived = 0";
    $categoryResult = mysqli_query($connection, $categoryQuery);

    if (isset($_POST['logout'])) {
        $_SESSION['is_authenticated'] = False;
        header('location:index.php');
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
            <div class="d-flex">
                <div class="dropdown me-auto">
                    <a class="btn btn-primary dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                        Category
                    </a>

                    <ul class="dropdown-menu">
                        <?php if($categoryResult) : ?>
                            <li><a class="dropdown-item" href="index.php">Uncategorized</a></li>
                            <?php while($row = mysqli_fetch_assoc($categoryResult)) : ?>
                                <li><a class="dropdown-item" href="index.php?category=<?= $row['category'] ?>"><?= $row['category'] ?></a></li>
                            <?php endwhile ; ?>   
                        <?php else : ?>
                            <?php die(mysqli_error($connection)); ?>
                        <?php endif ; ?>
                    </ul>
                </div>

                <?php if ($_SESSION['is_authenticated']) : ?>
                    <button type="button" class="btn btn-outline-warning me-1" data-bs-toggle="modal" data-bs-target="#archivePostsModal" name="archive">
                        ARCHIVE
                    </button>
                    <button type="submit" class="btn btn-outline-danger me-1" name="logout">
                        LOG OUT
                    </button>
                <?php endif ?>
            </div>
        </form>

        <div class="d-flex justify-content-center align-items-center flex-wrap">

            <?php if ($result) : ?>
                <?php if (mysqli_num_rows($result) > 0) : ?>
                    <?php while ($row = mysqli_fetch_assoc($result)) : ?>
                        <div class="py-4 px-5 bg-body-secondary rounded-5 me-3 mb-3">
                            <div class="d-flex align-items-center">
                                <small class="fw-bold text-primary me-auto"><?= $row['author'] ?></small>
                                <?php if ($_SESSION['is_authenticated']) : ?>
                                    <div class="dropdown">
                                        <a class="btn btn-sm dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                                        </a>
    
                                        <ul class="dropdown-menu dropdown-menu-end">
                                            <li><a class="dropdown-item" href="delete_post.php?id=<?php echo $row['id'] ?>">Delete</a></li>
                                        </ul>
                                    </div>
                                <?php endif ; ?>
                            </div>
                            <p class="my-2 text-break"><?= $row['content'] ?></p>
                            <small class="fw-bold text-primary"><?= date_format(date_create(substr($row['date'], 0, 10)), 'F d, Y, l') ?></small>
                        </div>
                    <?php endwhile; ?>
                <?php else : ?>
                    <div class="p-5 bg-body-secondary rounded-5 me-3 mb-3 text-center">
                        <h3 class="fw-bold px-5">No posts yet.</h3>
                        <small><a href="#createPostModal" data-bs-toggle="modal">Write a public post</a></small>
                    </div>
                <?php endif; ?>
            <?php else : ?>
                <?php die(mysqli_error($connection)); ?>
            <?php endif; ?>
        </div>
    </div>


    <?php include 'components/default/footer.php' ?>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>

</html>