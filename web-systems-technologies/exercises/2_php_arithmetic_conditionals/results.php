<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Grade Results</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" 
    rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" 
    crossorigin="anonymous">
  </head>
  <body>
    <div style="height: 2em;"></div>
    <?php
        $nameFirst = $_POST['nameFirst'];
        $nameMiddle = $_POST['nameMiddle'];
        $nameLast = $_POST['nameLast'];
        $yearLevel = $_POST['yearLevel'];
        $course = $_POST['course'];
        $gradePrelims = $_POST['gradePrelims'];
        $gradeMidterms = $_POST['gradeMidterms'];
        $gradeFinals = $_POST['gradeFinals'];
        $gradeAverage = ($gradePrelims + $gradeMidterms + $gradeFinals) / 3;
        $gradeRemarks = "test";
        if ($gradeAverage >= 96){
            $gradeRemarks = "A";
        } elseif ($gradeAverage >= 90 && $gradeAverage < 96){
            $gradeRemarks = "B";
        } elseif ($gradeAverage >= 85 && $gradeAverage < 90){
            $gradeRemarks = "C";
        } elseif ($gradeAverage >= 80 && $gradeAverage < 85){
            $gradeRemarks = "D";
        } elseif ($gradeAverage >= 75 && $gradeAverage < 80){
            $gradeRemarks = "E";
        } else {
            $gradeRemarks = "F";
        }
    ?>
    <center>
        <table>
            <thead>
                <tr>
                    <th colspan="2">
                        <h3 class="fw-bold text-center mb-4">Student Average Grade</h3>
                    </th>
                </tr>
            </thead>
            <tbody class="form-group">
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="nameFirst">First Name</label>
                    </th>
                    <td>
                        <input class="form-control" type="text" name="nameFirst" id="nameFirst" placeholder=<?php echo $nameFirst ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="nameMiddle">Middle Name</label>
                    </th>
                    <td>
                        <input class="form-control" type="text" name="nameMiddle" id="nameMiddle" placeholder=<?php echo $nameMiddle ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="nameLast">Last Name</label>
                    </th>
                    <td>
                        <input class="form-control" type="text" name="nameLast" id="nameLast" placeholder=<?php echo $nameLast ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label for="yearLevel">Year Level</label>
                    </th>
                    <td>
                        <input class="form-control" type="text" name="yearLevel" id="yearLevel" placeholder=<?php echo $yearLevel ?> disabled>
                        </div>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label for="course">Course</label>
                    </th>
                    <td>
                        <input class="form-control" type="text" name="course" id="course" placeholder=<?php echo $course ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="gradePrelims">Preliminary Grade</label>
                    </th>
                    <td>
                        <input class="form-control" type="number" name="gradePrelims" id="gradePrelims" placeholder=<?php echo $gradePrelims ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="gradeMidterms">Midterms Grade</label>
                    </th>
                    <td>
                        <input class="form-control" type="number" name="gradeMidterms" id="gradeMidterms" placeholder=<?php echo $gradeMidterms ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="gradeFinals">Finals Grade</label>
                    </th>
                    <td>
                        <input class="form-control" type="number" name="gradeFinals" id="gradeFinals" placeholder=<?php echo $gradeFinals ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="gradeAverage">Average Grade</label>
                    </th>
                    <td>
                        <input class="form-control" type="number" name="gradeAverage" id="gradeAverage" placeholder=<?php echo $gradeAverage ?> disabled>
                    </td>
                </tr>
                <tr>
                    <th scope="row">
                        <label class="form-label pt-1 pe-4" for="gradeRemarks">Grade Remarks</label>
                    </th>
                    <td>
                        <input class="form-control" type="number" name="gradeRemarks" id="gradeRemarks" placeholder=<?php echo $gradeRemarks ?> disabled>
                    </tr>
                    </td>
            </tbody>
        </table>
    </center>
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" 
    integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" 
    crossorigin="anonymous"></script>
  </body>
</html>