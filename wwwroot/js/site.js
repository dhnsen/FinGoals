
let savingsAmount;
let savingsToDistribute;
let totalSavingsRequired;
let goals;

const getGoals = function(){
    let xhr = new XMLHttpRequest();
    xhr.open('GET', '/api/Goals', true);

    xhr.onload = function(){
        if(this.status == 200){
            goals = JSON.parse(this.responseText);
            console.log(goals);
            clearGoalsDisplay();
            writeGoalsDisplay();
        }
    }
    xhr.send();
}

function clearGoalsDisplay() {
    goalNodes = document.getElementById("goal-list");
    while (goalNodes.hasChildNodes()){
        goalNodes.removeChild(goalsNodes.firstChild);
    }
}

function writeGoalsDisplay() {
    // define the parent node

    goals.array.forEach(element => {
        //append a child node to the parent with unique ID

        //create variable for the child node

        //set attributes for the node
    });
}

//update amount
const getSavingsAmount = function() {
    let xhr = new XMLHttpRequest();
    xhr.open('GET', '/api/SavingsAmount', true);

    xhr.onload = function(){
        if(this.status == 200){
            savingsAmount = JSON.parse(this.responseText);
            console.log(savingsAmount)
            document.getElementById("amount-saved")
            .value = savingsAmount.amount;
        }
    }
    xhr.send();
};

const updateSavingsAmount = function() {
    savingsAmount.amount = document.getElementById("amount-saved").value;
    xhr = new XMLHttpRequest();
    let json = JSON.stringify(savingsAmount);
    xhr.open('PUT', '/api/SavingsAmount');
    xhr.setRequestHeader('Content-type','application/json; charset=utf-8');
    xhr.onload = function(){
        console.log(xhr.status)
    }
    xhr.send(json);
    document.location.reload()
};

document.getElementById('update-amount').addEventListener('click',
updateSavingsAmount);

$(document).ready(getSavingsAmount);