using System;

namespace UserRegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------*Registration form*--------");
        uc1: Console.WriteLine("First Name(First letter shuld be capitle)");
            string FistName = Console.ReadLine();
            if (!isValid.CheckFirstName(FistName))
            {
                Console.WriteLine("enter valid name");
                goto uc1;
            }
        uc2: Console.WriteLine("First Name(First letter shuld be capitle)");
            string LastName = Console.ReadLine();
            if (!isValid.CheckLastName(LastName))
            {
                Console.WriteLine("enter valid last name");
                goto uc2;
            }
        uc3: Console.WriteLine("Enter the Mail Id");
            string MailId = Console.ReadLine();
            if (!isValid.CheckMailId(MailId))
            {
                Console.WriteLine("Mail Id is invalid");
                goto uc3;
            }
        uc4: Console.WriteLine("Enter the Mobil number(include +91-)");
            string MobileNumber = Console.ReadLine();
            if (!isValid.CheckMobileNumber(MobileNumber))
            {
                Console.WriteLine("Mobile number is invalid");
                goto uc4;
            }
        uc5: Console.WriteLine("Enter the Password(enter min 8 charector)");
            string Password = Console.ReadLine();
            if (!isValid.CheckPassword(Password))
            {
                Console.WriteLine(" invalid password");
                goto uc5;
            }
        uc6: Console.WriteLine("Enter the Password(enter min 8 charector and atlist 1 Uppercase latter)");
            string Password1 = Console.ReadLine();
            if (!isValid.CheckPassword1(Password1))
            {
                Console.WriteLine(" invalid password");
                goto uc6;
            }
        uc7: Console.WriteLine("Enter the Password(enter min 8 charector and atlist 1 Uppercase and atlist 1 number)");
            string Password2 = Console.ReadLine();
            if (!isValid.CheckPassword2(Password2))
            {
                Console.WriteLine(" invalid password");
                goto uc7;
            }
        uc8: Console.WriteLine("Enter the Password(enter min 8 charector and atlist 1 Uppercase and atlist 1 number and 1 special char)");
            string Password3 = Console.ReadLine();
            if (!isValid.CheckPassword3(Password3))
            {
                Console.WriteLine(" invalid password");
                goto uc8;
            }
        }
    }
}
