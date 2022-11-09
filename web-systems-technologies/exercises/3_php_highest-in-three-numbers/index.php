<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WS101 Exer3</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet"
    integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
</head>
    <body>
        <center>
            <div style="height: 3em;"></div>
            <form action="results.php" method="POST" id="mainform">
                <table>
                    <thead>
                        <tr><th colspan="2">
                            <h3 class="fw-bold text-center mb-4">Highest in three numbers</h3>
                        </th></tr>
                    </thead>
                    <tbody class="form-group">
                        <tr>
                            <th scope="row">
                                <label class="pe-3" for="firstNumber">First Number</label>
                            </th>
                            <td>
                                <input class="form-control" type="number" name="firstNumber" id="firstNumber" required>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3" for="secondNumber">Second Number</label>
                            </th>
                            <td>
                                <input class="form-control" type="number" name="secondNumber" id="secondNumber" required>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3" for="thirdNumber">Third Number</label>
                            </th>
                            <td>
                                <input class="form-control" type="number" name="thirdNumber" id="thirdNumber" required>
                            </td>
                        </tr>                                                
                    </tbody>
                    <tfoot>
                        <tr><th colspan="2" scope="row" class="text-center">
                            <input type="submit" class="btn btn-primary mt-4" value="Submit"> 
                        </th></tr>
                    </tfoot>
                </table>
            </form>
        </center>    

        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" 
        crossorigin="anonymous"></script>
    </body>
</html>