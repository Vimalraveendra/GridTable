
window.logUser = window.logUser ||
    function () {
        loadUsers();
    }


function loadUsers() {
    const inputValueEl = document.getElementById('name')

    //let personData = [
    //    {
    //        Name: "John"
    //    },
    //    {
    //        Name: "Boss"
    //    },
    //    {
    //        Name: "Denver"
    //    },
    //    {
    //        Name: "Pawel"
    //    },
    //    {
    //        Name: "Xavier"
    //    },
    //]




    //loadTableData(personData)

    //function loadTableData(personData) {
       
    //    let tableBody = document.getElementById('table-data')
    //    let dataHtml = '';
    //    var current = document.getElementsByClassName("active");
    //    for (person of personData) {
    //        dataHtml += `<tr><td></td><td>${person.Name}</td><td></td></tr>`
    //    }
    //    // If there's no active class
    //    if (current.length > 0) {
    //        current[0].className = current[0].className.replace(" active", "");
    //    }

    //    tableBody.innerHTML = dataHtml;



    

    //    const tRowContainerEl = document.querySelectorAll('.table-data tr')


    


    //}

    let count = 1;

    window.setInputTextToTable = () => {
        text =inputValueEl.value
        if (text) {
            let tableBody = document.getElementById('table-data')
            var current = document.getElementsByClassName("active");
            console.log('cur', current)

            if (current.length > 0) {
                current[0].className = current[0].className.replace(" active", "");
            }

            
            tableBody.innerHTML += `<tr><td >${count}</td><td class=" active">${text}</td><td></td></tr>`

            inputValueEl.value = "";
        }
        count++;

        const tRowContainerEl = document.querySelectorAll('.table-data tr')
        console.log("table", tRowContainerEl)
        tRowContainerEl.forEach(list => {
            list.addEventListener("click", function () {
                var current = document.getElementsByClassName("active");
                console.log('cur', current)

                if (current.length > 0) {
                    current[0].className = current[0].className.replace(" active", "");
                }

                list.childNodes[1].className += " active";

            })
        })
    };


    
}