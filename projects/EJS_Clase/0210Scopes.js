function scopes() {
    var i = 0;

    for (let j = 0; j < 10; j++) {
        let i = j;
        console.log('i ' + i)
    }

    console.log(i)
}

scopes()