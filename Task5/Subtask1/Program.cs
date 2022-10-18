using System;

class Programm{
    class Car{
        public double fuel;
        public int millage;

        public Car(){
            fuel = 50;
            millage = 0;
        }
        
        public void Move(){
            fuel -= 0.5;
            millage++;    
        }

        public void FillTheCar(){
            fuel = 50;
        }

    }
    static void Main(){
        Car myCar = new Car();

        while (myCar.fuel > 0){
            myCar.Move();
        }
        Console.WriteLine("Вы проехали {0}км. Теперь у вас пустой бак и вы не можете ехать, но зато как роскошно вы идете с канистрой", myCar.millage);
        Console.ReadKey();
    }
}
