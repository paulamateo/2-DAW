class Rectangle {

    // add x1, y1
    constructor(x, y, x1, y1) {
        this.x = x;
        this.y = y;
        this.x1 = x1;
        this.y1 = y1;
    }

    print() {
        console.log(`[${this.x}, ${this.y}][${this.x1}, ${this.y1}]`)
    }

    checkInside(cx, cy) {
        return cx > this.x && cx < this.x1 && 
                cy > this.y && cy < this.y1
    }

    checkOverlay(rect) {
        return this.checkInside(rect.x, rect.y) || this.checkInside(rect.x1, rect.y1)
    }
    // tenemos que comprobar la siguiente situación
    // .x----------x.....
    // .|..........|.....
    // .|......x---|----x
    // .x------|---x....|
    // ........x--------x
    // Se superponen si alguna de sus coordenadas están dentro de los límites
    // del otro rectángulo
}

let r1 = new Rectangle(1,1,5,5);
// let r2 = new Rectangle(3,4);

r1.print()
// r2.print()

// let area = r1.area();
// console.log(`area ${area}`)

// let isOverlay = r1.overlay(r2)

module.exports = {
    Rectangle
}
