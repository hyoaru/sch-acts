<!doctype html>
<html lang="en">

    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- <title>Websys </title> -->

        <!-- Bootstrap CSS -->
        <link rel="stylesheet" href="css/bootstrap.css">
        <!-- User defined CSS -->
        <link rel="stylesheet" href="css/style.css">
    </head>

    <body>
        <div class="container">
            <header>
                <nav class="navbar bg-white">
                    <div style="height: 5em;"></div>
                    <div class="container-fluid">
                        <a class="navbar-brand" href="base.php">
                            <img src="images/svg/people-fill.svg" class="me-3" width="30" alt="">
                            <span class="fw-bold">Employee Salary System</span>
                        </a>
                    </div>
                </nav>
            </header>
    
            <main>
                <?php 
                    // Employee Information
                    $employeeNumber = $_POST['employeeNumber'];
                    $employeeFirstName = $_POST['employeeFirstName'];
                    $employeeMiddleName = $_POST['employeeMiddleName'];
                    $employeeLastName = $_POST['employeeLastName'];
                    $employeeFullName = "{$employeeFirstName}_{$employeeMiddleName}_{$employeeLastName}";
                    $employeeRatePerHour = $_POST['employeeRatePerHour'];
                    $employeePosition = $_POST['employeePosition'];
                    $employeeNumberDaysWorked = $_POST['employeeNumberDaysWorked'];
                    $employeeOvertimeInMinutes = $_POST['employeeOvertimeInMinutes'];
                    $employeeLateInMinutes = $_POST['employeeLateInMinutes'];
                    $employeeYearsInService = $_POST['employeeYearsInService'];
                    $employeeNumberOfDependents = $_POST['employeeNumberOfDependents'];
                    
                    // Salary Calculation
                    $employeeRatePerDay = $employeeRatePerHour * 8;
                    $employeeGrossPay = $employeeNumberDaysWorked * $employeeRatePerDay;
                    $employeeSSSDeduction = $employeeGrossPay * 0.025;
                    $employeePagibigDeduction = $employeeGrossPay * 0.02;
                    $employeePhilhealthDeduction = $employeeGrossPay * 0.0125;
                    $employeeOvertimePay = (($employeeRatePerHour / 60) * 1.5) * $employeeOvertimeInMinutes;
                    $employeeLateDeduction = (($employeeRatePerHour / 60) * $employeeLateInMinutes);

                    $employeeWithHoldingTax = 0;
                    if ($employeeNumberOfDependents <= 0){
                        $employeeWithHoldingTax = ((
                            $employeeOvertimePay 
                            + $employeeGrossPay 
                            - $employeeSSSDeduction 
                            - $employeePagibigDeduction
                            - $employeePhilhealthDeduction
                            - $employeeLateDeduction)
                            * 0.1);
                    } elseif (($employeeNumberOfDependents >= 1) and ($employeeNumberOfDependents <= 3)){
                        $employeeWithHoldingTax = ((
                            $employeeOvertimePay 
                            + $employeeGrossPay 
                            - $employeeSSSDeduction 
                            - $employeePagibigDeduction
                            - $employeePhilhealthDeduction
                            - $employeeLateDeduction)
                            * 0.07);
                    } else {
                        $employeeWithHoldingTax = ((
                            $employeeOvertimePay 
                            + $employeeGrossPay 
                            - $employeeSSSDeduction 
                            - $employeePagibigDeduction
                            - $employeePhilhealthDeduction
                            - $employeeLateDeduction)
                            * 0.05);
                    }

                    $employeeHonorarium = 0;
                    if ($employeeYearsInService < 5){
                        $employeeHonorarium = 0;
                    } elseif (($employeeYearsInService >= 5) and ($employeeYearsInService < 10)){
                        $employeeHonorarium = 2500;
                    } elseif (($employeeYearsInService >= 10) and ($employeeYearsInService < 20)){
                        $employeeHonorarium = 4000;
                    } elseif ($employeeYearsInService > 20){
                        $employeeHonorarium = 6000;
                    }

                    $employeeTotalDeductions = (
                        $employeeWithHoldingTax
                        + $employeeSSSDeduction
                        + $employeePagibigDeduction
                        + $employeePhilhealthDeduction
                        + $employeeLateDeduction
                    );

                    $employeeNetPay = (
                        $employeeGrossPay
                        + $employeeOvertimePay
                        + $employeeHonorarium
                        - $employeeTotalDeductions
                    );
                ?>

                <div class="row mx-0 mx-md-5 gx-5">
                    <div class="col-12 col-sm-6">
                        <span class="fw-semibold mb-1">Employee Information</span>
                        <div class="mb-3 mb-md-2">
                            <label for="employeeNumber" class="form-label">Employee number</label>
                            <input type="number" name="employeeNumber" id="employeeNumber" class="form-control" disabled value=<?php echo "{$employeeNumber}" ?>>
                        </div>
                        <div class="mb-3 mb-md-2">
                            <label for="employeeFullName" class="form-label">Full name</label>
                            <input type="text" name="employeeFullName" id="employeeFullName" class="form-control" disabled value=<?php echo "{$employeeFullName}" ?>>
                        </div>
                        <div class="mb-3 mb-md-2">
                            <label for="employeePosition" class="form-label">Position</label>
                            <input type="text" name="employeePosition" id="employeePosition" class="form-control" disabled value=<?php echo "{$employeePosition}" ?>>
                        </div>

                        <div class="row">
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeRatePerHour" class="form-label">Rate per hour</label>
                                    <input type="number" name="employeeRatePerHour" id="employeeRatePerHour" class="form-control" disabled value=<?php echo "{$employeeRatePerHour}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeNumberDaysWorked" class="form-label">Number of days worked</label>
                                    <input type="number" name="employeeNumberDaysWorked" id="employeeNumberDaysWorked" class="form-control" disabled value=<?php echo "{$employeeNumberDaysWorked}" ?>>
                                </div>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeOvertimeInMinutes" class="form-label">Overtime in minutes</label>
                                    <input type="number" name="employeeOvertimeInMinutes" id="employeeOvertimeInMinutes" class="form-control" disabled value=<?php echo "{$employeeOvertimeInMinutes}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeLateInMinutes" class="form-label">Late in minutes</label>
                                    <input type="number" name="employeeLateInMinutes" id="employeeLateInMinutes" class="form-control" disabled value=<?php echo "{$employeeLateInMinutes}" ?>>
                                </div>
                            </div>
                        </div>

                        <div class="mb-3 mb-md-2">
                            <label for="employeeYearsInService" class="form-label">Years in service</label>
                            <input type="number" name="employeeYearsInService" id="employeeYearsInService" class="form-control" disabled value=<?php echo "{$employeeYearsInService}" ?>>
                        </div>
                        <div class="mb-3 mb-md-2">
                            <label for="employeeNumberOfDependents" class="form-label">Number of dependents</label>
                            <input type="number" name="employeeNumberOfDependents" id="employeeNumberOfDependents" class="form-control" disabled value=<?php echo "{$employeeNumberOfDependents}" ?>>
                        </div>
                    </div>

                    <div class="col-12 col-sm-6">
                        <span class="fw-semibold mb-1">Salary Computation</span>
                        <div class="mb-3 mb-md-2">
                            <label for="employeeGrossPay" class="form-label">Gross pay</label>
                            <input type="number" name="employeeGrossPay" id="employeeGrossPay" class="form-control" disabled value=<?php echo "{$employeeGrossPay}" ?>>
                        </div>

                        <div class="row">
                            <div class="col-12 col-xl-4">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeSSSDeduction" class="form-label">SSS deduction</label>
                                    <input type="number" name="employeeSSSDeduction" id="employeeSSSDeduction" class="form-control" disabled value=<?php echo "{$employeeSSSDeduction}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6 col-xl-4">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeePagibigDeduction" class="form-label">Pagibig deduction</label>
                                    <input type="number" name="employeePagibigDeduction" id="employeePagibigDeduction" class="form-control" disabled value=<?php echo "{$employeePagibigDeduction}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6 col-xl-4">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeePhilhealthDeduction" class="form-label">Philhealth deduction</label>
                                    <input type="number" name="employeePhilhealthDeduction" id="employeePhilhealthDeduction" class="form-control" disabled value=<?php echo "{$employeePhilhealthDeduction}" ?>>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeOvertimePay" class="form-label">Overtime pay</label>
                                    <input type="number" name="employeeOvertimePay" id="employeeOvertimePay" class="form-control" disabled value=<?php echo "{$employeeOvertimePay}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeLateDeduction" class="form-label">Late deduction</label>
                                    <input type="number" name="employeeLateDeduction" id="employeeLateDeduction" class="form-control" disabled value=<?php echo "{$employeeLateDeduction}" ?>>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeWithHoldingTax" class="form-label">Tax</label>
                                    <input type="number" name="employeeWithHoldingTax" id="employeeWithHoldingTax" class="form-control" disabled value=<?php echo "{$employeeWithHoldingTax}" ?>>
                                </div>
                            </div>
                            <div class="col-12 col-md-6">
                                <div class="mb-3 mb-md-2">
                                    <label for="employeeHonorarium" class="form-label">Honorarium</label>
                                    <input type="number" name="employeeHonorarium" id="employeeHonorarium" class="form-control" disabled value=<?php echo "{$employeeHonorarium}" ?>>
                                </div>
                            </div>
                        </div>

                        <div class="mb-3 mb-md-2">
                            <label for="employeeTotalDeductions" class="form-label">Total deductions</label>
                            <input type="number" name="employeeTotalDeductions" id="employeeTotalDeductions" class="form-control" disabled value=<?php echo "{$employeeTotalDeductions}" ?>>
                        </div>
                        <div class="mb-3 mb-md-2">
                            <label for="employeeNetPay" class="form-label">Net pay</label>
                            <input type="number" name="employeeNetPay" id="employeeNetPay" class="form-control" disabled value=<?php echo "{$employeeNetPay}" ?>>
                        </div>
                    </div>
                    <div class="mb-3 mb-md-2 text-end mt-4 mt-xl-0">
                        <button onclick="window.print()" class="btn btn-primary">Print this page</button>
                        <a href="base.php" class="btn btn-danger">Return</a>
                    </div>
                </div>
            </main>
        </div>


        <!-- Bootstrap JS -->
        <script src="js/bootstrap.bundle.js"></script>
    </body>

</html>