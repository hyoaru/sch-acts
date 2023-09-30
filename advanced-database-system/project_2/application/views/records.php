<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head> 

<body>
    <form action=<?= base_url() . "records/save" ?> method="POST">
        
        <label>Greeting:</label>
        <select name="greeting" id="">
            <option value="Mr">Mr</option>
            <option value="Mrs">Mrs</option>
            <option value="Ms">Mss</option>
        </select>
        <br>
        <table>
            <tr>
                <td>Name</td>
                <td><input type="text" name="fname" id="" placeholder="First Name"></td>
                <td><input type="text" name="lname" id="" placeholder="Last Name"></td>
                <td><input type="text" name="mi" id="" placeholder="Middle Initial"></td>
            </tr>
        </table>
        <div>
            <label for="">Subject</label>
            <br>
            <input type="checkbox" name="subject_1" value="1">
            <label>Thesis</label><br>
            <input type="checkbox" name="subject_2" value="1">
            <label>Capstone</label><br>
            <input type="checkbox" name="subject_3" value="1">
            <label>English</label><br>
            <input type="checkbox" name="subject_4" value="1">
            <label>Math</label><br>
        </div>
        <table>
            <tr>
                <td>Response type</td>
                <td>
                    <input type="radio" name="response" value="1">
                    <label>Radio</label><br>
                </td>
                <td>
                    <input type="radio" name="response" value="2">
                    <label>Fax</label><br>
                </td>
                <td>
                    <input type="radio" name="response" value="3">
                    <label>Telephone</label><br>
                </td>
            </tr>
        </table>
        <div>
            <label for="">Comments</label>
            <br>
            <textarea name="comment" id="" cols="80" rows="10"></textarea>
        </div>
        <input type="submit" value="Save">
    </form>
</body>

</html>

