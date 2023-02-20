using System;
using System.Text.RegularExpressions;

namespace trycatch
{
    class ass
    {
        static void Main()
        {
            try
            {

       // логин

                Console.WriteLine("Введиту логин");
                string Login = "q " + "w " + "e " + "r " + "t " + "y " + "u " + "i " + "o " + "p " + "a " + "s " + "d " + "f " + "g " + "h " + "j " + "k " + "l " + "z " + "x " + "c " + "v " + "b " + "n " + "m " + "_" + "1 " + "2 " + "3 " + "4 " + "5 " + "6 " + "7 " + "8" + "9" + "0";
                Login = Console.ReadLine();
                if (Login.Length > 20)
                {
                    Console.WriteLine("Логин введен не верно");
                }
                else
                {
                    Console.WriteLine("Логин введен верно");
                }
            }catch
            {
                Console.WriteLine("WrongLoginException");
            }


            //пароль
            try
            {
                Console.WriteLine("Введиту пароль");
                string Password = "q " + "w " + "e " + "r " + "t " + "y " + "u " + "i " + "o " + "p " + "a " + "s " + "d " + "f " + "g " + "h " + "j " + "k " + "l " + "z " + "x " + "c " + "v " + "b " + "n " + "m " + "_" + "1 " + "2 " + "3 " + "4 " + "5 " + "6 " + "7 " + "8" + "9" + "0";
                Password = Console.ReadLine();
                if (Password.Length > 20)
                {
                    Console.WriteLine("Логин введен не верно");
                }
                else
                {
                    Console.WriteLine("Логин введен верно");
                }


                Console.WriteLine("Введити повторный пароль");

                string confirmPassword = "q " + "w " + "e " + "r " + "t " + "y " + "u " + "i " + "o " + "p " + "a " + "s " + "d " + "f " + "g " + "h " + "j " + "k " + "l " + "z " + "x " + "c " + "v " + "b " + "n " + "m " + "_" + "1 " + "2 " + "3 " + "4 " + "5 " + "6 " + "7 " + "8" + "9" + "0";
                confirmPassword = Console.ReadLine();
                if (confirmPassword.Length > 20 == Password.Length > 20)
                {
                    Console.WriteLine("Логин введен не верно");
                }
                else
                {
                    Console.WriteLine("Логин введен верно");
                }

            }
            catch
            {
                Console.WriteLine("WrongconfirmPasswordException");
            }


            //повторный пароль 













        }






    }
}





