

namespace c_1.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType){
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + "Lançou magia";
        }

        public string Attack(int Bonus){           
          
          if (Bonus > 6){
              return this.Name + "Lançou magia super efetiva com bonus de ataque de " + Bonus ;

          }else{
              return this.Name + "Lançou magia com forca fraca";
          }
        }

    }
}