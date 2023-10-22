window.onload = function() {
    console.log('document loaded');

    var xhttp = new XMLHttpRequest();   

    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            var data = JSON.parse(this.responseText);
            data.forEach(function(employee) {
                addRow(employee);
            });
        }
    };

    xhttp.open("GET", "http://dummy.restapiexample.com/api/v1/employees", true);
    xhttp.send();

    function addRow(employee) {
        var table = document.getElementById('table').getElementsByTagName('tbody')[0];
        var newRow = table.insertRow();
        
        var id = newRow.insertCell(0);
        var name = newRow.insertCell(1);
        var salary = newRow.insertCell(2);
        var age = newRow.insertCell(3);
        var img = newRow.insertCell(4);

        id.innerText = employee.id;
        name.innerText = employee.employee_name;
        salary.innerText = employee.employee_salary;
        age.innerText = employee.employee_age;
        img.innerHTML = `<img src="${employee.employee_img}"/>`;
    }

    document.getElementById('button').addEventListener('click', function() {
        xhttp.open("GET", "http://dummy.restapiexample.com/api/v1/employees", true);
        xhttp.send();
    });
}