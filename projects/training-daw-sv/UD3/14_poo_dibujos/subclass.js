class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }
}

class Figure {
    constructor(point) {
        this.point = point;
    }

    // print() {
    //     console.log('I\'m a figure');
    // }

    drawPosition() {
        console.log(`Estoy en la posición ${this.point.x},${this.point.y}. Soy una figura`);
    }

    draw() {
        this.drawPosition();
    }
}

class Square extends Figure {
    constructor(point, point1) {
        super(point);
        this.point1 = point1;
    }

    draw() {
        super.draw;
        console.log(`Estoy en la posición ${this.point.x},${this.point.y} y ${this.point1.x},${this.point1.y}. Soy un cuadrado`)
    }

    // print() {
    //     console.log('I\'m a square');
    // }
}

class Circle extends Figure {
    constructor(point, radius) {
        super(point);
        this.radius = radius;
    }

    draw() {
        super.draw;
        console.log(`Estoy en la posición ${this.point.x},${this.point.y}. Soy un círculo de radio ${this.radius}`)
    }
}

class Triangle extends Figure {
    constructor(point, width, heigth) {
        super(point);
        this.width = width;
        this.heigth = heigth;
    }

    draw() {
        super.draw;
        console.log(`Estoy en la posición ${this.point.x},${this.point.y}. Soy un triángulo con una altura de ${this.heigth} y un ancho de ${this.width}`)
    }

    // print() {
    //     super.print();
    //     console.log('and a triangle')
    // }
}


let draws = [new Figure(new Point(3,4)),
            new Square(new Point(7,8), new Point(9,9)),
            new Circle(new Point(4,5),7), 
            new Triangle(new Point(2,3),2,4)]
            
draws.forEach(f => f.draw())


module.exports = {
    Point,
    Figure,
    Square,
    Circle,
    Triangle
}