window.onload = function() {
    console.log('document loaded');

    document.addEventListener('DOMContentLoaded', function() {
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
            img.innerHTML = `<img src="${employee.employee_img}"">`;
        }

        function addNewEmployee() {
            fetch('http://dummy.restapiexample.com/api/v1/employees')
            .then(response => response.json())
            .then(response => {
                console.log(response)
                data.forEach(employee => {
                    addRow(employee);
                });
            });
        }


        document.getElementById('button').addEventListener('click', addNewEmployee);
    });

}





