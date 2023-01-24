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
                <form action="output.php" method="POST">
                    <div class="row mx-0 mx-md-5 gx-5">
                        <span class="text-muted fw-semibold mb-1">Please fill in the following.</span>
                        <div class="col-12 col-sm-6">
                            <div class="mb-3 mb-md-2">
                                <label for="employeeNumber" class="form-label">Employee number</label>
                                <input type="number" name="employeeNumber" id="employeeNumber" class="form-control" placeholder="01XXXXXX" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeFirstName" class="form-label">First name</label>
                                <input type="text" name="employeeFirstName" id="employeeFirstName" class="form-control" placeholder="John" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeMiddleName" class="form-label">Middle name</label>
                                <input type="text" name="employeeMiddleName" id="employeeMiddleName" class="form-control" placeholder="Smith" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeLastName" class="form-label">Last name</label>
                                <input type="text" name="employeeLastName" id="employeeLastName" class="form-control" placeholder="Cena" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeRatePerHour" class="form-label">Rate per Hour</label>
                                <input type="number" name="employeeRatePerHour" id="employeeRatePerHour" class="form-control" placeholder="" step="any" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeNumberDaysWorked" class="form-label">Number of days worked</label>
                                <input type="number" name="employeeNumberDaysWorked" id="employeeNumberDaysWorked" class="form-control" placeholder="" required>
                            </div>
                        </div>

                        <div class="col-12 col-sm-6">
                            <div class="mb-3 mb-md-2">
                                <label for="employeePosition" class="form-label">Employee number</label>
                                <select name="employeePosition" id="employeePosition" class="form-select" required>
                                    <option selected>Select a position</option>
                                    <option value="Representative">Representative</option>
                                    <option value="Specialist">Specialist</option>
                                    <option value="Analyst">Analyst</option>
                                    <option value="Coordinator">Coordinator</option>
                                    <option value="Administrator">Administrator</option>
                                    <option value="Generalist">Generalist</option>
                                    <option value="Consultant">Consultant</option>
                                    <option value="Associate">Associate</option>
                                    <option value="Technician">Technician</option>
                                </select>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeOvertimeInMinutes" class="form-label">Overtime in minutes</label>
                                <input type="number" name="employeeOvertimeInMinutes" id="employeeOvertimeInMinutes" class="form-control" placeholder="" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeLateInMinutes" class="form-label">Late in minutes</label>
                                <input type="number" name="employeeLateInMinutes" id="employeeLateInMinutes" class="form-control" placeholder="" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeYearsInService" class="form-label">Years in service</label>
                                <input type="number" name="employeeYearsInService" id="employeeYearsInService" class="form-control" placeholder="" required>
                            </div>
                            <div class="mb-3 mb-md-2">
                                <label for="employeeNumberOfDependents" class="form-label">Number of dependents</label>
                                <input type="number" name="employeeNumberOfDependents" id="employeeNumberOfDependents" class="form-control" placeholder="1X" required>
                            </div>
                        </div>
                        <div class="mb-3 mb-md-2 text-end mt-4 mt-md-0">
                            <input type="submit" value="Compute salary" class="btn btn-primary">
                            <a href="base.php" class="btn btn-danger">Clear Information</a>
                        </div>
                    </div>
                </form>
            </main>
        </div>


        <!-- Bootstrap JS -->
        <script src="js/bootstrap.bundle.js"></script>
    </body>

</html>