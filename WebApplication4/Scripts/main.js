// The method that is called in the 'onclick' event of demo1
function getDemo1Value() {

    var myVariable = document.getElementById("Text1").value;

    alert(myVariable);
}


// The method that is called in the 'onclick' event of button type 2 in demo2
function getDemo2Values() {

    var fname = document.getElementById("fname").value;

    var lname = document.getElementById("lname").value;

    alert('First name: ' + fname + '\nLastName: ' + lname); /* The \n is a character used to issue a line break in the alert box */
}

function validate() {
    //Get the value of fname
    var fname = document.getElementById("fname").value;

    //Get the value of lname
    var lname = document.getElementById("lname").value;

    // This is some logic that we haven't covered in class yet. It first checks that 'fname' is null then 
    // with the '||' symbol says 'OR' the length of the string is zero. If either are true the user will 
    // get the appropriate message. Don't worry about understanding it 
    // completely at this point.
    if (!fname || 0 === fname.length) {
        alert('Please enter a first name');
    }
    else if (!lname || 0 === lname.length) {
        alert('Please enter a last name')
    }
    else {
        alert('Success! \n' + 'First name: ' + fname + '\n' + 'Last name: ' + lname);
    }
}