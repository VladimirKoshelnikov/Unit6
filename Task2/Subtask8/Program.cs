using System;

class Programm{

    class Rectangle{
        public uint a;
        public uint b;

        public uint GetSquare(){
            return a * b;
        }

        public Rectangle(){
            a = 6;
            b = 4;
        }

        
        public Rectangle(uint side){
            a = side;
            b = a;
        }

        public Rectangle(uint side1, uint side2){
            a = side1;
            b = side2;
        }
    }
    public static void Main(){
        Rectangle rect1 = new Rectangle();
        Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} равна {2}", rect1.a, rect1.b, rect1.GetSquare());

        Rectangle rect2 = new Rectangle(10);
        Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} равна {2}", rect2.a, rect2.b, rect2.GetSquare());

        Rectangle rect3 = new Rectangle(5, 10);
        Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} равна {2}", rect3.a, rect3.b, rect3.GetSquare());

        Console.ReadKey();
    }
}