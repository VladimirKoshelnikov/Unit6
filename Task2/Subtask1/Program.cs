using System;

class Programm{

    class Human{
        public string name;
        public int age;

        public void Greetings(){
            Console.WriteLine("Привет, меня зовут {0}", name);
        }

            // Конструктор 1
	    public Human()
	    {
	    	name = "Неизвестно";
	    	age = 20;
	    }
	    // Конструктор 2
	    public Human(string n)
	    {
	    	name = n;
	    	age = 20;
	    }
	    // Конструктор 3
	    public Human(string n, int a)
	    {
	    	name = n;
	    	age = a;
	    }
    }

    struct Animal{
        public string name;
        public string type;
        public int age;

        public void Greetings(){
            Console.WriteLine("Привет, я {0}. Меня зовут {1}", type, name);
        }
    }
    public static void Main(){
        Animal myPet;
        myPet.age = 2;
        myPet.name = "Варя";
        myPet.type = "Крыса";
        myPet.Greetings();

        Human me = new Human("Владимир", 27);
        me.Greetings();
        
        Console.ReadKey();
    }
}