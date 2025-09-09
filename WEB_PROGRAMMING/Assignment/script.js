// first get the values from the form fields and store them in variables
// then validate each field according to the requirements
// first is Username validation (6–8 characters)
//2nd is Pin validation (only if checkbox is checked)
//3rd is check for state is selected or not
//4th is Radio button validation (only one is selected)
//5th give an error msg only if any of the above validation fails or else give a success msg


function validateForm() {
    let username = document.getElementById("username").value;
    let pin = document.getElementById("pin").value;
    let state = document.getElementById("state").value;
    let validatePin = document.getElementById("validatePin").checked;
    let result = document.getElementById("result");
    let radios = document.getElementsByName("food");

    let messages = [];

    
    if (username.length < 6 || username.length > 8) {
        messages.push("Username should be between 6 and 8 characters");
    }

     
    if (validatePin) {
        let alphaNum = /^[a-zA-Z0-9]+$/;
        if (!alphaNum.test(pin)) {
            messages.push("Pin should be alphanumeric");
        }
    }

    if (state === "") {
        messages.push("State should be selected");
    }

   
    let radioSelected = false;
    for (let i = 0; i < radios.length; i++) {
        if (radios[i].checked) {
            radioSelected = true;
        }
    }
    if (!radioSelected) {
        messages.push("Please select a food option");
    }

    if (messages.length > 0) {
        result.innerHTML = messages.join("<br>");
    } else {
        result.innerHTML = "Form validated successfully!";
        result.style.color = "green";
    }
}