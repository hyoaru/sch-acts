<?php 
    include 'connect.php';
    if (isset($_POST['submit'])) {
        $author = $_POST['author'];
        $content = $_POST['content'];

        $query = "INSERT INTO `posts` (content, author) values('$content', '$author')";
        $result = mysqli_query($connection, $query);

        if (!$result){
            die(mysqli_error($connection));
        } else {
            header('location:index.php');
        }
    }
?>

<div class="modal fade" id="createPostModal" tabindex="-1" aria-labelledby="createPostModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <form method="POST">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5 fw-bold" id="createPostModalLabel">Create post</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="mb-3">
                        <label for="" class="form-label fw-bold">Author</label>
                        <input type="text" name="author" id="" class="form-control"  placeholder="Enter the name you would want to be displayed">
                    </div>
                    <div class="mb-3">
                        <label for="" class="form-label fw-bold">Content</label>
                        <textarea name="content" id="" rows="5" class="form-control" placeholder="Enter your message"></textarea>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="submit" name="submit" class="btn btn-primary">Post</button>
                </div>
            </div>
        </form>
    </div>
</div>