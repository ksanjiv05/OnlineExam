﻿//var currentTab = 0; // Current tab is set to be the first tab (0)
//showTab(currentTab); // Display the current tab

//function showTab(n) {
//    // This function will display the specified tab of the form...
//    var x = document.getElementsByClassName("tab");
//    x[n].style.display = "block";
//    //... and fix the Previous/Next buttons:
//    if (n == 0) {
//        document.getElementById("prevBtn").style.display = "none";
//    } else {
//        document.getElementById("prevBtn").style.display = "inline";
//    }
//    if (n == (x.length - 1)) {
//        document.getElementById("nextBtn").innerHTML = "Submit";
//    } else {
//        document.getElementById("nextBtn").innerHTML = "Next";
//    }
//    //... and run a function that will display the correct step indicator:
//    fixStepIndicator(n)
//}

//function nextPrev(n) {
//    // This function will figure out which tab to display
//    var x = document.getElementsByClassName("tab");
//    // Exit the function if any field in the current tab is invalid:

//    //if (n == 1 && !validateForm()) return false;

//    // Hide the current tab:
//    x[currentTab].style.display = "none";
//    // Increase or decrease the current tab by 1:
//    currentTab = currentTab + n;
//    // if you have reached the end of the form...
//    if (currentTab >= x.length) {
//        // ... the form gets submitted:
//        document.getElementById("regForm").submit();
//        return false;
//    }
//    // Otherwise, display the correct tab:
//    showTab(currentTab);
//}

//function validateForm() {
//    // This function deals with validation of the form fields
//    var x, y, i, valid = true;
//    x = document.getElementsByClassName("tab");
//    y = x[currentTab].getElementsByTagName("input");
//    // A loop that checks every input field in the current tab:
//    for (i = 0; i < y.length; i++) {
//        // If a field is empty...
//        if (y[i].value == "") {
//            // add an "invalid" class to the field:
//            y[i].className += " invalid";
//            // and set the current valid status to false
//            valid = false;
//        }
//    }
//    // If the valid status is true, mark the step as finished and valid:
//    if (valid) {
//        document.getElementsByClassName("step")[currentTab].className += " finish";
//    }
//    return valid; // return the valid status
//}

//function fixStepIndicator(n) {
//    // This function removes the "active" class of all steps...
//    var i, x = document.getElementsByClassName("step");
//    for (i = 0; i < x.length; i++) {
//        x[i].className = x[i].className.replace(" active", "");
//    }
//    //... and adds the "active" class on the current step:
//    x[n].className += " active";
//}


function getRandomInt(max) {
    return Math.floor(Math.random() * Math.floor(max));
}
function Catcha() {
    //Creating 3 random number 0-9
    var index1 = getRandomInt(51);
    var index2 = getRandomInt(51);
    var index3 = getRandomInt(51);
    var index4 = getRandomInt(51);
    var index5 = getRandomInt(9);
    var index6 = getRandomInt(9);

    var captchaLatter = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];    //fourth random number

    document.getElementById("catcha").value = captchaLatter[index1] + "" + index5 + "" + captchaLatter[index2] + "" + index6 + "" + captchaLatter[index3] + "" + captchaLatter[index4];


}
function validation(ev) {
    //alert(document.getElementById("catcha").value);
    //alert(document.getElementById("captcha_input").value);
    if (document.getElementById("catcha").value !== document.getElementById("captcha_input").value) {
        alert("invalid captcha");
        ev.preventDefault()
    } else {
        //alert('valid');
    }
}
function captchaReload() {
    console.log("reloded");
    Catcha();

}
Catcha();

