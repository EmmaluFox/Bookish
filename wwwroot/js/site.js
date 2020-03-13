const newUserBox = document.getElementById("addNewUser");
const newUserButton = document.getElementById("newUserButton");

newUserButton.addEventListener("click",function(event){
    newUserBox.style.display = "flex";
    event.preventDefault();
});