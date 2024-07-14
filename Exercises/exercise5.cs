// /*
//  * Crea una única función (importante que sólo sea una) que sea capaz
//  * de calcular y retornar el área de un polígono.
//  * - La función recibirá por parámetro sólo UN polígono a la vez.
//  * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
//  * - Imprime el cálculo del área de un polígono de cada tipo.
//  */

//  //AQUÍ EMPIEZA =>
// var pol = new PolygonFactory();

// var Triangle = new Triangle(1, 83);
// pol.printPolygon(Triangle);
// var Square = new Square(18);
// pol.printPolygon(Square);
// var Rectangle = new Rectangle(55.5, 483.2);
// pol.printPolygon(Rectangle);

// public interface Polygon{
//     double Area();
//     string printArea();
// }

// public class Triangle(double baseT, double height) : Polygon{
//     public double Area(){
//         return baseT * height / 2;
//     }

//     public string printArea(){
//         return $"El área del triángulo es: {Area()}";
//     }
// }

// public class Square(double side) : Polygon{
//     public double Area(){
//         return side*side;
//     }

//     public string printArea(){
//         return $"El área del cuadrado es: {Area()}";
//     }
// }

// public class Rectangle(double baseR, double height) : Polygon{
//     public double Area(){
//         return baseR * height;
//     }

//     public string printArea(){
//         return $"El área del rectángulo es: {Area()}";
//     }
// }

// public class PolygonFactory{
//     public void printPolygon(Polygon polygon){
//         Console.WriteLine(polygon.printArea());
//     }
// }