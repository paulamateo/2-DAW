/*The function job must return a promise object (you are in a NodeJS environment, you can use new Promise)
The promise must resolve itself 2 seconds after the call to job and must provide hello world in the data*/

function job() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve('hello world');
        }, 2000)
        //setTimeout()
    });
}

job().then(data => {
    console.log(data);
});

module.exports = job;