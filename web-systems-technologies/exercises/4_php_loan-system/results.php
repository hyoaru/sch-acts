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
                <?php
                    // From user input 
                    $loanId = $_POST['loanId'];
                    $firstName = $_POST['firstName'];
                    $middleName = $_POST['middleName'];
                    $lastName = $_POST['lastName'];
                    $loanAmount = $_POST['loanAmount'];
                    $installmentOption = $_POST['installmentOption'];
                    
                    // Computations
                        // 3 months – interest rate is 0.25% of the total loan amount
                            // 0.25% in decimal is 0.25 / 100 = 0.0025
                        // 6 months – interest rate is 0.50% of the total loan amount
                            // 0.50% in decimal is 0.50 / 100 = 0.005
                        // 9 months – interest rate is 1% of the total loan amount
                            // 1% in decimal is 1 / 100 = 0.01
                        // 12 months – interest rate is 1.5% of the total loan amount
                            // 1.5% in decimal is 1.5 / 100 = 0.015

                        // total dues = loan amout + (loan amount * interest rate)
                        // monthy due = total due / no. of months

                    $installmentOptions = array(3, 6, 9, 12);
                    $interestRates = array(0.0025, 0.005, 0.01, 0.015);
                    
                    // Get interest rate
                    $interestRate = -1;
                    for ($i=0; $i < count($installmentOptions); $i++) { 
                        if ($installmentOption == $installmentOptions[$i]){
                            $interestRate = $interestRates[$i];
                        }
                    }

                    // Get total dues and monthly due
                    $totalDues = $loanAmount + ($loanAmount * $interestRate);
                    $monthlyDue = $totalDues / $installmentOption;
                    
                ?>
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
                                <label class="pe-3">Loan ID</label>
                            </th>
                            <td>
                                <input class="form-control" type="number" value=<?php echo $loanId ?> disabled>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3">Full Name</label>
                            </th>
                            <td>
                                <input class="form-control" type="text" value=<?php echo "{$firstName}_{$middleName}_{$lastName}" ?> disabled>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3">Loan Amount</label>
                            </th>
                            <td>
                                <input class="form-control" type="number" value=<?php echo $loanAmount ?> disabled>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3">Installment Option</label>
                            </th>
                            <td>
                                <input class="form-control" type="text" value=<?php echo "{$installmentOption}_months"?> disabled>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3">Total Dues</label>
                            </th>
                            <td>
                                <input class="form-control" type="text" value=<?php echo $totalDues ?> disabled>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">
                                <label class="pe-3">Monthly Dues</label>
                            </th>
                            <td>
                                <input class="form-control" type="text" value=<?php echo $monthlyDue ?> disabled>
                            </td>
                        </tr>
                    </tbody>

                    <tfoot>
                        <tr>
                            <th class="text-center pt-4" colspan="2">
                                <a href="index.php">
                                    <input class="btn btn-danger" type="button" value="Go back">
                                </a>
                            </th>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </center>
        <!-- Bootstrap JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" 
        integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
    </body>
</html>