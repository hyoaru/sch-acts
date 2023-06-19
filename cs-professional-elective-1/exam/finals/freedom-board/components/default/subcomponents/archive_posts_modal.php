<?php 
    include 'connect.php';
    if (isset($_POST['archiveConfirm'])){
        $categoryName = $_POST['categoryName'];
        $query = "SELECT `id` FROM `posts` WHERE category IS NULL";
        $result = mysqli_query($connection, $query);

        if ($result) {  
            while ($row = mysqli_fetch_assoc($result)) {
                $id = $row['id'];
                $query = "UPDATE `posts` SET `category` = '$categoryName' WHERE `posts`.`id` = $id";
                mysqli_query($connection, $query);
            }
            header("location:index.php");
        } else {
            die(mysqli_error($connection));
        }
    }
?>

<div class="modal fade" id="archivePostsModal" tabindex="-1" aria-labelledby="archivePostsModalLabel" aria-hidden="true">
    <form method="POST">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="archivePostsModalLabel">Archive posts</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="mb-3">
                        <label for="" class="form-label">Category name</label>
                        <input type="text" name="categoryName" id="" class="form-control" placeholder="Enter category name">
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="submit" name="archiveConfirm" class="btn btn-warning">Archive</button>
                </div>
            </div>
        </div>
    </form>
</div>