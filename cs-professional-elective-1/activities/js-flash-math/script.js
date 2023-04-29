const num1 = document.querySelector('#num1');
const num2 = document.querySelector('#num2');
const input = document.querySelector('#input');
const submitButton = document.querySelector('#submit');
const correct = document.querySelector('#correct');
const error = document.querySelector('#error');

var sum;
var correctCount = 0;
var errorCount = 0;

let getGeneratedNumbers = () => {
    return ({
        generatedNum1: Math.floor(Math.random() * 20 + 1),
        generatedNum2: Math.floor(Math.random() * 20 + 1)
    });
}

let reflectGeneratedNumbers = (generatedNum1, generatedNum2) => {
    num1.innerText = generatedNum1;
    num2.innerText = generatedNum2;
}

let reflectStats = () => {
    correct.value = correctCount;
    error.value = errorCount;
}

let generateAndReflect = () => {
    let generatedNumbers = getGeneratedNumbers();
    var generatedNum1 = generatedNumbers.generatedNum1;
    var generatedNum2 = generatedNumbers.generatedNum2;
    reflectGeneratedNumbers(generatedNum1, generatedNum2);
}

generateAndReflect()
document.querySelector('#submit').addEventListener("click", () => {
    var generatedNum1 = parseInt(num1.innerText);
    var generatedNum2 = parseInt(num2.innerText);
    sum = generatedNum1 + generatedNum2;
    
    let userInput = input.value;
    if (userInput == sum) {
        correctCount++;
    } else {
        errorCount++;
    }

    input.value = "";
    reflectStats()
    generateAndReflect()
})
