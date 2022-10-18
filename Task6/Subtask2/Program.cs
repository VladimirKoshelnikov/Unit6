using System;

class Programm{
    class User{
        
        private string _login;
        private string _email;
        public string Login{
            get{
                return _login;
                }
            set{
                if (value.Length < 3)
                {
                    Console.WriteLine("Длина логина должна быть больше 3 символов");
                } 
                else{
                    _login = value;
                }
                
                }
            }
        public string Email{
            get{
                return _email;
            }
            set{
                if (value.Contains('@')){
                    _email = value;
                }
                else{
                    Console.WriteLine("Почтовый адрес должен содержать символ @");
                }
            }
            }
    }
    
    static void Main(){
        User myUser = new User();
        myUser.Login = "A";
        myUser.Login = "ABC";
        myUser.Login = "ABCD";

        myUser.Email = "adf";
        myUser.Email = "adf@";
    }
}