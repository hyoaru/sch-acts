<header class="mt-5">
    <form method="POST">
        <div class="container border-bottom">
            <div class="d-flex align-items-center">
                <a href="index.php" class="ms-auto text-decoration-none">
                    <h1 class="fw-bold m-0 text-dark">Freedom Board</h1>
                </a>
                
                <button 
                    type="button" 
                    class="btn btn-outline-primary ms-auto my-3 me-1" 
                    data-bs-toggle="modal" 
                    data-bs-target="#createPostModal" 
                    <?php if (isset($_GET['category'])) : ?>
                        disabled
                    <?php endif ; ?>
                    >
                    CREATE
                </button>
            </div>
        </div>
    </form>
</header>

<div style="height: 1.3em;"></div>



<?php include 'components/default/subcomponents/create_post_modal.php' ?>
<?php include 'components/default/subcomponents/archive_posts_modal.php' ?>