using System;

class Programm{
    class Bus
    {
    	public int? Load;

    	public void PrintStatus()
    	{
            if (Load.HasValue){
                Console.WriteLine("В автобусе {0} пассажиров", Load);
            }
            else{
                Console.WriteLine("В автобусе пусто");
            }
    	}
        public Bus(int load){
            Load = load;
        }
        public Bus(){
        }
    }

    static void Main(){
        Bus bus1 = new Bus();
        Bus bus2 = new Bus(143);
        bus1.PrintStatus();
        bus2.PrintStatus();
        Console.ReadKey();
    }
}
