using System;

namespace DIOGame{

    public abstract class Heros
    {
        public Heros(string Name, int Level, string HeroType, int Hp){
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
        }
        public string Name;
        public int level;
        public string HeroType;

        public int Hp;
        
        public Heros(){

        }



        public override string ToString(){
            return this.Name + " "+ this.level + " " + this.HeroType;

        }


        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }
    }

}