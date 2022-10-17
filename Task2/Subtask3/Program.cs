using System;

class Programm{

    struct Animal{
        public string name;
        public string type;
        public int age;

        public void Greetings(){
            Console.WriteLine("Привет, я {0}. Меня зовут {1}", type, name);
        }
    }
    public static void Main(){
        Animal myPet = new Animal{name = "Вольт", type = "Собака", age = 2};
        
        Console.ReadKey();
    }
}