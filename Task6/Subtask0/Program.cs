using System;

class Programm{
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }
    class Car{
        private double fuel;
        private int millage;
        private string color;
        private TurnDirection turn;
        public Car(){
            fuel = 50;
            millage = 0;
            color = "White";
        }
        
        private void Move(){
            fuel -= 0.5;
            millage++;    
        }

        public void FillTheCar(){
            fuel = 50;
        }

        private void Turn(TurnDirection direction){
            turn = direction;
        }

        public string GetColor(){
            return color;
        }

        public void ChangeColor (string newColor){
            if (color != newColor){
                color = newColor;
            }
        }

        public bool isTurningLeft(){
            return turn == TurnDirection.Left;
        }
        public bool isTurningright(){
            return turn == TurnDirection.Right;
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
