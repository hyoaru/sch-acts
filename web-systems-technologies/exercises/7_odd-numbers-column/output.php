<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Cabrera - Exercise 7</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>

<body>
    <div style="height: 7em;"></div>
    <div class="container">
        <center>
            <?php 
                $givenNumber = $_POST['givenNumber'];

                echo "<table class='table table-bordered text-center'>";
                for ($i=1; $i < $givenNumber; $i++) { 
                    echo "<tbody>";
                    if ($i % 2 != 0){
                        echo "<td> $i </td>";
                    }
                    echo "</tbody>";
                }
                echo "</table>";
            ?>
        </center>    
    </div>


    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</body>

</html>