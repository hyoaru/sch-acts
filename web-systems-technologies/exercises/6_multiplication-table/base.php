<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Cabrera - Exercise 6</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>

<body>
    <div style="height: 6em;"></div>
    <div class="container">
        <center>
            <h1 class="mb-5">Cabrera - Exer6: Multiplication Table</h1>
            <?php
                $colRange = 10;
                $rowRange = 10;
    
                echo "<table class='table table-bordered text-center'>";
                echo "<tbody>";
                for ($i=1; $i <= $colRange; $i++) { 
                    echo "<tr>";
                    for ($j=1; $j <= $rowRange; $j++) { 
                        $product = $i * $j;
                        echo "<td>{$product}</td>";
                    }
                    echo "</tr>";
                }
                echo "</tbody>";
                echo "</table>";
            ?>
        </center>
    </div>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</body>

</html>