//https://nodejs.org/docs/latest-v18.x/api/fs.html#promise-example
//https://nodejs.org/docs/latest-v18.x/api/buffer.html#buftostringencoding-start-end

const { readFile } = require('node:fs/promises');

readFile('./EJERCICIOS_CLASE/2410_Callback/data.csv')
    .then(data => {
        let users = data.toString()
        let usersArray = users.split('\n')
        for (let u of usersArray) {
            let userData = u.split(',')
            console.log(`Hola ${userData[0]}, tienes ${userData[1]} y cobras ${userData[2]}`);
        }
    })
    .catch(err => console.log(err))





// function example(data) {
//     console.log(`length: ${data.length}`);
//     console.log(`position 0: ${data[0]}`);
// }

// example([1,2,3]);
// example([2,3,4,5,6,7]);

// function example2(...data) {
//     console.log(`length: ${}`)
// }