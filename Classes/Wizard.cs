
namespace DIOGame{

    public class Wizard : Heros {

        public Wizard(string Name, int Level, string HeroType,int Hp)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            
        }

    public override string Attack(){
            return this.Name + " Lançou Magia";
        }
         public string Attack(int Bonus){
            
            if (Bonus > 6){
             return this.Name + " Lançou Magia Super Efetiva com bonus de "+ Bonus;
            }else{
                return this.Name + " Lançou Magia com força fraca com bonus de ataque de "+ Bonus;
            }
            
        }
    }
}










