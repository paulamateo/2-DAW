const { Square } = require('./subclass')

test('test básico sobre figuras', () => {
    let draws = [new Square(new Point(7,8))]
    draws.forEach(f => f.draw())
})