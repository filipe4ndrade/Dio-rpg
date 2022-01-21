using System;

namespace DIOGame
{
    class Program{
      
        static void Main (string[] args){
           
           Knight Arus = new Knight("Arus",23,"Knight",100);
           Wizard wizard = new Wizard("Jenica",23,"white wizard",100);
           
           Console.WriteLine(Arus.Attack());
           Console.WriteLine(wizard.Attack(1));
           Console.WriteLine(wizard.Attack(7));
           Console.WriteLine(Arus.Attack());

        //    hero.Name = "Arus";
        //    hero.level = 2;
        //    hero.HeroType = "Knight";




        }
        }
        }