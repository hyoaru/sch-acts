<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>WS101 Exer 1</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" 
    rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" 
    crossorigin="anonymous">
  </head>
  <body>
    <div style="height: 2em;"></div>
    <center>
        <form action="results.php" method="post" id="mainform">
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
                            <input class="form-control" type="text" name="nameFirst" id="nameFirst" required>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label class="form-label pt-1 pe-4" for="nameMiddle">Middle Name</label>
                        </th>
                        <td>
                            <input class="form-control" type="text" name="nameMiddle" id="nameMiddle" required>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label class="form-label pt-1 pe-4" for="nameLast">Last Name</label>
                        </th>
                        <td>
                            <input class="form-control" type="text" name="nameLast" id="nameLast" required>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label for="yearLevel">Year Level</label>
                        </th>
                        <td>
                            <div class="form-check form-check-inline">
                                <input type="radio" class="form-check-input" id="radioYearLevel1" name="yearLevel" value="1st">
                                <label for="radioYearLevel1" class="form-check-label">1st</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input type="radio" class="form-check-input" id="radioYearLevel2" name="yearLevel" value="2nd">
                                <label for="radioYearLevel2" class="form-check-label">2nd</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input type="radio" class="form-check-input" id="radioYearLevel3" name="yearLevel" value="3rd">
                                <label for="radioYearLevel3" class="form-check-label">3rd</label>
                            </div>
                            <div class="form-check form-check-inline">
                                <input type="radio" class="form-check-input" id="radioYearLevel4" name="yearLevel" value="4th">
                                <label for="radioYearLevel4" class="form-check-label">4th</label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label for="course">Course</label>
                        </th>
                        <td>
                            <select name="course" id="course" class="form-select">
                                <option selected>Choose a course</option>
                                <option value="BS_Computer_Science">BS Computer Science</option>
                                <option value="BS_Information_Technology">BS Information Technology</option>
                                <option value="BS_Accountancy">BS Accountancy</option>
                                <option value="BS_Nursing">BS Nursing</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label class="form-label pt-1 pe-4" for="gradePrelims">Preliminary Grade</label>
                        </th>
                        <td>
                            <input class="form-control" type="number" name="gradePrelims" id="gradePrelims" required>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label class="form-label pt-1 pe-4" for="gradeMidterms">Midterms Grade</label>
                        </th>
                        <td>
                            <input class="form-control" type="number" name="gradeMidterms" id="gradeMidterms" required>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">
                            <label class="form-label pt-1 pe-4" for="gradeFinals">Finals Grade</label>
                        </th>
                        <td>
                            <input class="form-control" type="number" name="gradeFinals" id="gradeFinals" required>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <th colspan="2" scope="row" class="text-center">
                            <input class="btn btn-primary mt-3" type="submit" value="Submit">
                        </th>
                    </tr>
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