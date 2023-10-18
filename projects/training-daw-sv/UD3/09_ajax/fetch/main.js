window.onload = function() {
    console.log('document loaded');

    let botonCargarDatos = document.getElementById('botonCargarDatos');
    let tablaEmpleados = document.getElementById('tablaEmpleados');

    botonCargarDatos.addEventListener('click', function() {
        fetch('http://dummy.restapiexample.com/api/v1/employees')
        .then(response => response.json())
        .then(response => {
            console.log(response)
        })
        .catch(console.log("Error " +error))
    })

}