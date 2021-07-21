
window.logUser = window.logUser ||
    function () {
        loadUsers();
    }


function loadUsers() {


let personData = [
    {
    Name:"John"
    },
    {
        Name: "Boss"
    },
    {
        Name: "Denver"
    },
    {
        Name: "Pawel"
    },
    {
        Name: "Xavier"
    },
]



  
    loadTableData(personData)

function loadTableData(personData) {
    console.log("ehheeh")
    let tableBody = document.getElementById('table-data')
    let dataHtml = '';

    for (person of personData) {
        dataHtml += `<tr><td></td><td>${person.Name}</td><td></td></tr>`
    }
    tableBody.innerHTML = dataHtml;

}

}
