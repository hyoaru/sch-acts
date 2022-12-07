<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Document</title>

        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <center>
            <form action="output.php" method="POST">
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
                                <input type="number" name="accountNumber" id="" class="form-number">
                            </td>
                        </tr>
    
                        <tr>
                            <th>
                                <label for="lastName" class="form-label">Last Name</label>
                            </th>
                            <td>
                                <input type="text" name="lastName" id="" class="form-text">
                            </td>
                        </tr>
    
                        <tr>
                            <th>
                                <label for="firstName" class="form-label">First Name</label>
                            </th>
                            <td>
                                <input type="text" name="firstName" id="" class="form-text">
                            </td>
                        </tr>
    
                        <tr>
                            <th>
                                <label for="middleName" class="form-label">Middle Name</label>
                            </th>
                            <td>
                                <input type="text" name="middleName" id="" class="form-text">
                            </td>
                        </tr>
    
                        <tr>
                            <th>
                                <label for="usageType" class="form-label">Type of Usage</label>
                            </th>
                            <td>
                                <select name="usageType" class="form-select">
                                    <option selected>Select type of usage</option>
                                    <option value="Home">Home</option>
                                    <option value="Commercial">Commercial</option>
                                    <option value="Industrial">Industrial</option>
                                </select>
                            </td>
                        </tr>
    
                        <tr>
                            <th>
                                <label for="gallonsUsed" class="form-label">Gallons Used</label>
                            </th>
                            <td>
                                <input type="number" name="gallonsUsed" id="" class="form-number">
                            </td>
                        </tr>
                    </tbody>

                    <tfoot>
                        <tr>
                            <th colspan="2" style="padding-top: 2em;">
                                <input type="submit" value="Submit" class="button-submit">
                            </th>
                        </tr>
                    </tfoot>

                </table>
            </form>
        </center>
        
    </body>
</html>