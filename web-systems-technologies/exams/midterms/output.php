<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta content="width=device-width, initial-scale=1.0">
        <title>Document</title>

        <link rel="stylesheet" href="style.css">
    </head>
    <body>

        <?php 
            $accountNumber = $_POST['accountNumber'];
            $firstName = $_POST['firstName'];
            $middleName = $_POST['middleName'];
            $lastName = $_POST['lastName'];
            $fullName = "{$firstName}_{$middleName}_{$lastName}";
            $usageType = $_POST['usageType'];
            $gallonsUsed = $_POST['gallonsUsed'];

            $amountDue = 0;

            if ($usageType == "Home") {
                $amountDue = 5 + (0.0005 * $gallonsUsed);
            } elseif ($usageType == "Commercial") {
                $amountDue = 1000;
                if ($gallonsUsed > 4000000) {
                    $amountDue += ($gallonsUsed - 4000000) * 0.00025;
                }
            } elseif ($usageType == "Industrial") {
                if ($gallonsUsed <= 4000000) {
                    $amountDue = 1000;
                } elseif ($gallonsUsed > 4000000 && $gallonsUsed <= 10000000) {
                    $amountDue = 2000;
                } else {
                    $amountDue = 3000;
                }
            }
        ?>

        <center>
            <table>
                <thead>
                    <tr>
                        <th colspan="2">
                            <h1>City Water Company</h1>
                        </th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <th>
                            <label for="accountNumber" class="form-label">Account Number</label>
                        </th>
                        <td>
                            <input type="number" id="" class="form-number" value=<?php echo "$accountNumber" ?> disabled>
                        </td>
                    </tr>

                    <tr>
                        <th>
                            <label for="fullName" class="form-label">Full Name</label>
                        </th>
                        <td>
                            <input type="text" id="" class="form-text" value=<?php echo "$fullName" ?> disabled>
                        </td>
                    </tr>

                    <tr>
                        <th>
                            <label for="usageType" class="form-label">Type of Usage</label>
                        </th>
                        <td>
                            <input type="text" class="form-text" value=<?php echo "$usageType" ?> disabled>
                        </td>
                    </tr>

                    <tr>
                        <th>
                            <label for="gallonsUsed" class="form-label">Gallons Used</label>
                        </th>
                        <td>
                            <input type="number" id="" class="form-number" value=<?php echo "$gallonsUsed" ?> disabled>
                        </td>
                    </tr>

                    <tr>
                        <th>
                            <label for="amountDue" class="form-label">Amount Due</label>
                        </th>
                        <td>
                            <input type="number" id="" class="form-number" value="<?php echo "$amountDue" ?>" disabled>
                        </td>
                    </tr>


                </tbody>

                <tfoot>
                    <tr>
                        <th colspan="2" style="padding-top: 2em;">
                            <a href="input.php"><input type="submit" value="Go Back" class="button-cancel"></a>
                        </th>
                    </tr>
                </tfoot>

            </table>
        </center>
        
    </body>
</html>