const { Car } = require('./car')

test('test básico sobre coche', () => {
    const ferrari = new Car('ferrari', 'f50', 25) 
    ferrari.reposta(100)
    ferrari.move(200)
    expect(ferrari.restante()).toBe(200)
})