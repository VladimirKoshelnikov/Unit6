using System;

class Programm{

    class Company{
        public string Type;
        public string Name;
    }

    class Departament {
        public Company Company;
        public City City;

        public Departament(){
            City = new City();
            City.Name = "Санкт-Петербург";

            Company = new Company();
            Company.Type = "Банк";
            Company.Name = "Адидас";
        }

            public Departament(string newCity){
            City = new City();
            City.Name = newCity;

            Company = new Company();
            Company.Type = "Банк";
            Company.Name = "Адидас";
            }
        
            public Departament(string newCity, string newCompany){
            City = new City();
            City.Name = newCity;

            Company = new Company();
            Company.Type = "Банк";
            Company.Name = newCompany;
            }
            
            public Departament(string newCity, string newCompany, string newType){
            City = new City();
            City.Name = newCity;

            Company = new Company();
            Company.Type = newType;
            Company.Name = newCompany;
            }
            

    }

    class City{
        public string Name;
    }

    public static void Main(){
        var departament1 = GetCurrentDepartament();
        var departament2 = GetCurrentDepartament("Пенза");
        var departament3 = GetCurrentDepartament("Санкт-Петербург", null, "Банк");
        var departament4 = GetCurrentDepartament("Санкт-Петербург", "Puma", "Банк");

        CheckDepartament(departament1);
        CheckDepartament(departament2);
        CheckDepartament(departament3);
        CheckDepartament(departament4);

        Console.ReadKey();
    }
    static Departament GetCurrentDepartament(string newCity = "Санкт-Петербург", string newCompany = "Адидас", string newType = "Банк"){
        Departament result = new Departament(newCity, newCompany, newType);
        return result;
    }

    static void CheckDepartament(Departament departament) {
        if (departament?.City?.Name == "Санкт-Петербург"&& departament?.Company?.Type == "Банк"){
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", departament?.Company?.Name ?? "Неизвестная компания");
        }
    }

}