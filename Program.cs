using System;
using Sinopac.Shioaji;

namespace dotnet_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Shioaji _api = new Shioaji();
            var _accounts = _api.Login("", "");
            Console.WriteLine(_accounts);
        }
    }
}