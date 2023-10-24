window.onload = function() {
    console.log('document loaded');

    var xhttp = new XMLHttpRequest();   
    var solicitudRealizada = false; 

    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            var data = JSON.parse(this.responseText);
            data.data.forEach(function(employee) {
                addRow(employee);
            });
            solicitudRealizada = true; 
        }
    };

    function addRow(employee) {
        var table = document.getElementById('table').getElementsByTagName('tbody')[0];
        var newRow = table.insertRow();
        
        var id = newRow.insertCell(0);
        var name = newRow.insertCell(1);
        var lastname = newRow.insertCell(2);
        var email = newRow.insertCell(3);
        var avatar = newRow.insertCell(4);

        id.innerText = employee.id;
        name.innerText = employee.first_name; 
        lastname.innerText = employee.last_name; 
        email.innerText = employee.email;
        avatar.innerHTML = `<img src="${employee.avatar}"/>`;
    }

    document.getElementById('button').addEventListener('click', function() {
        if (!solicitudRealizada) {
            xhttp.open("GET", "https://reqres.in/api/users", true);
            xhttp.send();
        }
    });
}
