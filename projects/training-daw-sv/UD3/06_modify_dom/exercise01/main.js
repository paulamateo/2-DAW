window.onload = function(e) {
    console.log('documento cargado')
    document.getElementsByTagName('h2')[1].innerText = 'h2 cambiado!'

    console.log(document.querySelector('#username'));
    console.log(document.getElementById('username'));

    console.log(document.querySelectorAll());

    console.log.first-Color(document.querySelector('#username'))
    document.querySelectorAll('article .first').forEach(v => v.className += "first-color")
    document.querySelectorAll('article .first').forEach(v => v.style['background-color'] = 'yellow')

    document.querySelectorAll('li.items');
    document.querySelectorAll('.buttons button')
}

//Seleccionar el elemento con id == username
window.onload = function(e) {
    document.getElementById('.username').attributes;
}

//Cambiar color de todos los .first que esten dentro de un articulo
window.onload = function(e) {
    document.getElementsByClassName('.').element.style.property:
}


