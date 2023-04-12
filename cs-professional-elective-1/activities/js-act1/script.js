var txtFirstNumber = document.getElementById("firstNumber");
var txtSecondNumber = document.getElementById("secondNumber");
var txtCelsius = document.getElementById("celsius");

function clearForm1InputFields() {
    txtFirstNumber.value = "";
    txtSecondNumber.value = "";
}

function calculateFromOperation() {
    var operation = document.getElementById("operationList").value;
    var firstNumber = parseFloat(txtFirstNumber.value);
    var secondNumber = parseFloat(txtSecondNumber.value); 

    var result;
    if (operation == "noSelected") {
        result = "Please select operation.";
        clearForm1InputFields();
    } else {
        if (operation == "operationAdd") {
            result = firstNumber + secondNumber;
        } else if (operation == "operationMultiply") {
            result = firstNumber * secondNumber;
        } else {
            result = firstNumber / secondNumber;
        }
    }

    document.getElementById("calculatedResult").textContent = result;
}

function clearForm2InputFields(){
    txtCelsius.value = "";
}

function convertToFahrenheit() {
    var celsius = parseFloat(txtCelsius.value);

    var result;
    if (Number.isNaN(celsius)) {
        result = "Please input a value.";
    } else {
        result = ((celsius * (9/5)) + 32) + "°F";
    }

    document.getElementById("fahrenheit").textContent = result;
}