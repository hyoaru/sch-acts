<?php 
    $sum = 0;
    if (isset($_POST['computeButton'])){
        $input = $_POST['input'];

        for ($i=0; $i <= $input; $i++) { 
            $sum += $i;
        }
    }
?>

<!doctype html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>WS101 Exer1 - Cabrera</title>
        <!-- Boostrap CSS -->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    </head>
    <body>
        <center>
            <div style="height: 5em;"></div>
            <div class="container">
                <form action="#" method="POST">
                    <table>
                        <thead>
                            <tr>
                                <th colspan="2">
                                    <h1 class="mb-4">Sum of numbers in a loop</h1>
                                </th>
                            </tr>
                        </thead>
    
                        <tbody>
                            <tr>
                                <th scope="row">
                                    <label for="input">Enter a number</label>
                                </th>
                                <td>
                                    <input type="number" name="input" class="form-control" value=<?php echo "{$input}"?>>
                                </td>
                            </tr>
    
                            <tr>
                                <th scope="row">
                                    <label>Output</label>
                                </th>
                                <td>
                                    <input class="form-control" type="number" value=<?php echo "{$sum}" ?> disabled>
                                </td>
                            </tr>
                        </tbody>
    
                        <tfoot>
                            <tr>
                                <th colspan="2" class="text-center">
                                    <input type="submit" value="Compute" name="computeButton" class="mt-3 btn btn-primary">
                                </th>
                            </tr>
                        </tfoot>
                    </table>
                </form>
            </div>
        </center>


        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
    </body>
</html>