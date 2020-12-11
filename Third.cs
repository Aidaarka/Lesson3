using System;
using System.Text.RegularExpressions;

namespace lesson3.Reged
{
    class Third
    {
        static void Main()
        {
            //Email checking
            Regex RuleCheckEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Console.WriteLine(RuleCheckEmail.IsMatch("email@mail.ru"));

            //IP checking
            Regex RuleCheckIP = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            Console.WriteLine(RuleCheckIP.IsMatch("0.0.0.0"));
        }
    }
}
