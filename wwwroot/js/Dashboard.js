
let savingsAmount;
let goals =
    [{}];

const getSavingsAmount = function () {
    let xhr = new XMLHttpRequest();
    xhr.open('GET', '/api/SavingsAmount', true);

    xhr.onload = function () {
        if (this.status == 200) {
            savingsAmount = JSON.parse(this.responseText);
            document.getElementById("amount-saved")
                .value = savingsAmount.amount;
        };
    };
    xhr.send();
};

const updateSavingsAmount = function () {
    savingsAmount.amount = document.getElementById("amount-saved").value;
    xhr = new XMLHttpRequest();
    let json = JSON.stringify(savingsAmount);
    xhr.open('PUT', '/api/SavingsAmount');
    xhr.setRequestHeader('Content-type', 'application/json; charset=utf-8');
    xhr.onload = function () {
        console.log(xhr.status)
    };
    xhr.send(json);
};

//const getGoals = function () {
//    let xhr = new XMLHttpRequest();
//    xhr.open('GET', '/api/Goals', true);

//    xhr.onload = function () {
//        if (this.status == 200) {
//            goals = JSON.parse(this.responseText);
//            console.log(goals);
//            clearGoalsDisplay();
//            writeGoalsDisplay();
//        }
//    }
//    xhr.send();
//};

function clearGoalsDisplay() {
    goalNodes = document.getElementById("goal-list");
    while (goalNodes.hasChildNodes()) {
        goalNodes.removeChild(goalsNodes.firstChild);
    };
};

writeGoalsDisplay = function () {
    goals.forEach(() => {
        //create the node
        var goal = document.createElement("div");
        //set the properties
        goal.setAttribute("class", "democlass");
        //append to the parent
        document.getElementById("goals-section").appendChild(goal);
    });
};

document.getElementById('update-amount').addEventListener('click',
    updateSavingsAmount);

$(document).ready(getSavingsAmount);
$(document).ready(writeGoalsDisplay);
