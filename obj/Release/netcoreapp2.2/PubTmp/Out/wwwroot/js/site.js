// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


let savingsAmount;

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
}

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
}

document.getElementById('update-amount').addEventListener('click',
updateSavingsAmount);

$(document).ready(getSavingsAmount);