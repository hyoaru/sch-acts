<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>WS101 Exer4 Cabrera</title>
        <!-- Bootstrap CSS -->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" 
        integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
    </head>
    <body>
        <center>
            <div style="height: 4em;"></div>
            <div class="form-group">
                <form action="results.php" method="POST">
                    <table>
                        <thead>
                            <tr>
                                <th colspan="2">
                                    <h3 class="fw-bold text-center mb-4">Loan System</h3>
                                </th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="loanId">Loan ID</label>
                                </th>
                                <td>
                                    <input class="form-control" type="number" name="loanId" id="loanID" required>
                                </td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="firstName">First Name</label>
                                </th>
                                <td>
                                    <input class="form-control" type="text" name="firstName" id="firstName" required>
                                </td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="middleName">Middle Name</label>
                                </th>
                                <td>
                                    <input class="form-control" type="text" name="middleName" id="middleName" required>
                                </td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="lastName">Last Name</label>
                                </th>
                                <td>
                                    <input class="form-control" type="text" name="lastName" id="lastName" required>
                                </td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="loanAmount">Loan Amount</label>
                                </th>
                                <td>
                                    <input class="form-control" type="number" name="loanAmount" id="loanAmount" required>
                                </td>
                            </tr>
                            <tr>
                                <th scope="row">
                                    <label class="pe-3" for="installmentOption">Installment Option</label>
                                </th>
                                <td>
                                    <select name="installmentOption" id="installmentOption" class="form-select" required>
                                        <?php 
                                            $installmentOptions = array(3, 6 ,9 ,12);
                                            for ($i=0; $i < count($installmentOptions); $i++) { 
                                                echo "<option value={$installmentOptions[$i]}> {$installmentOptions[$i]} months </option>";
                                            }
                                        ?>
                                    </select>
                                </td>
                            </tr>
                        </tbody>

                        <tfoot>
                            <tr>
                                <th class="text-center pt-4" colspan="2">
                                    <input class="btn btn-primary" type="submit" value="Submit">
                                </th>
                            </tr>
                        </tfoot>
                    </table>
                </form>
            </div>
        </center>
        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
    </body>
</html>