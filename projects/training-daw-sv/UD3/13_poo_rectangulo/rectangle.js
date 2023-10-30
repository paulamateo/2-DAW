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
        if() {
            return true
        }
    }

    area() {
        return this.x*this.y;
    }

    overlay() {

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
