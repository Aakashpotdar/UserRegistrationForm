using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationForm
{
    class isValid
    {
        public static bool CheckFirstName(string name)
        {
            string regexName = "^([A-Z][a-z]{3}[a-z]+)$";
            return Regex.IsMatch(name, regexName);
        }
        public static bool CheckLastName(string name)
        {
            string regexLastName = "^([A-Z][a-z]{3}[a-z]+)$";
            return Regex.IsMatch(name, regexLastName);
        }
        public static bool CheckMailId(string Id)
        {
            string regexId = "^([a-zA-Z0-9]+)(.?)([a-zA-Z0-9]+)([@][a-z]+)([.][a-z]+)$";
            return Regex.IsMatch(Id, regexId);
        }
        public static bool CheckMobileNumber(string Number)
        {
            string regexNumber = "^[+]{1}[9][1][-][6-9][0-9]{9}$";
            return Regex.IsMatch(Number, regexNumber);
        }
        public static bool CheckPassword(string Password)
        {
            string regexPassword = "^([a-zA-Z]{8})([a-zA-Z]+)?$";
            return Regex.IsMatch(Password, regexPassword);
        }
        public static bool CheckPassword1(string Password1)
        {
            string regexPassword1 = "^(?=.*[A-Z])[A-Za-z]{8,}$";
            return Regex.IsMatch(Password1, regexPassword1);
        }

        public static bool CheckPassword2(string Password2)
        {
            string regexPassword2 = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
            return Regex.IsMatch(Password2, regexPassword2);
        }
        public static bool CheckPassword3(string Password3)
        {
            string regexPassword3 = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[@#$^&*])(?=.*?[0-9]).{8,}$";
            return Regex.IsMatch(Password3, regexPassword3);
        }
    }
}
