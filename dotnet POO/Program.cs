// Abstraindo um jogo de RPG usando orientação a objetos com C#

using System;
using dotnet_POO.crc.Entities;

namespace dotnet_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 99, "white wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(5));
        }
    }

}