using System;

class Programm{
    class TrafficLight{
        private string Color;
        public void ChangeColor(string newColor){
            if (Color != newColor){
                Color = newColor;
            }
        }

        public string GetColor(){
            return Color;
        }
    }
    
    static void Main(){

    }
}
