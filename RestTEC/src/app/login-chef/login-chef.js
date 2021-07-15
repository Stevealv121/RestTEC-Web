var baseurl = "http://localhost:5001/api/chef";
var email = document.getElementById("form-username");
var password = document.getElementById("form-password");

function login(){

    var object = {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify({
            email: email.value,
            password: password.value,
        })};
    //fetch(baseurl,object);
    window.location.href = '/chef';
    

}