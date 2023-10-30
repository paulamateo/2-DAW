const { Rectangle } = require('./rectangle')

test('comprobar valores dentro del rectangulo', () => {
    let r1 = new Rectangle(1,1,5,5);

    expect(r1.checkInside(1,6)).toBeFalsy()
    expect(r1.checkInside(7,6)).toBeFalsy()
    expect(r1.checkInside(3,2)).toBeTruthy()
})

test('comprobar que funciona el overlay', () => {
    let r1 = new Rectangle(1,1,5,5);
    let r2 = new Rectangle(6,6,8,8);
    
})