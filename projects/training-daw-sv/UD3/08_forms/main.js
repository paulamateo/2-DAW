window.onload = function() {
    console.log(document.main_form.elements)

    console.log(document.getElementById('pregunta_si').value)
    console.log(document.getElementById('pregunta_si').checked)

    document.getElementById('pregunta_si').onchange = changeValue
    document.getElementById('pregunta_no').onchange = changeValue

    document.getElementById('condiciones').onclick = checkSubmit
    document.getElementById('privacidad').onclick = checkSubmit

    document.getElementById('submit').onclick = NameLastname

    checkSubmit()
    document.getElementById('opciones').disabled = true
    
}


//El combo de opciones sólo estará habilitado si se pulsa “si” en el primer check
function changeValue(e) {
    console.log('changed' + e.target.value)
    if (e.target.value === 'si') {
        document.getElementById('opciones').disabled = false;
    }else {
        document.getElementById('opciones').disabled = true;
    }
}

//Nombre y apellidos son obligatorios. Si no se han rellenado al pulsar el botón, informar al usuario
function NameLastname(e) {
    if (document.getElementById('name').value === '' && document.getElementById('surname').value === '') { 
        alert('Rellena los datos');
        return false;
    }else {
        document.getElementById('submit').disabled = false; 
    }
}

//El botón enviar sólo debe estar habilitado si se han marcado los 2 checks
function checkSubmit() {
    if (document.getElementById('condiciones').checked && document.getElementById('privacidad').checked) {
        document.getElementById('submit').disabled = false;
    }else {
        document.getElementById('submit').disabled = true;   
    }
}

