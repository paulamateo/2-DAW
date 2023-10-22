window.onload = function() {
    console.log('document loaded');

    document.getElementById('button').addEventListener('click', function() {
        fetch('http://dummy.restapiexample.com/api/v1/employees')
        .then(response => response.json())
        .then(response => {
            console.log(response)
            let table = document.getElementById('table');
            response.forEach(employee => {
                let row = document.createElement('tr');
                let name = document.createElement('td');
                let salary = document.createElement('td');
                let age = document.createElement('td');

                name.textContent = employee.employee_name;
                salary.textContent = employee.employee_salary;
                age.textContent = employee.employee_age;

                row.appendChild(name);
                row.appendChild(salary);
                row.appendChild(age);
                table.appendChild(row);
            });

        })
    });

}
