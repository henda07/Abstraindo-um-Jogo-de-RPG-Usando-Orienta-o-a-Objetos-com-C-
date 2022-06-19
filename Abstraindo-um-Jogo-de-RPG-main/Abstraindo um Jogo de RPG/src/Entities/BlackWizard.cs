namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou magia ";
        }

        public string Attack(int Bonus){

            if (Bonus> 6){
               return this.Name + " Lançou Super Magia com Bonus de " + Bonus;
            }else{
                return this.Name + " Lançou Magia com Bonus de " + Bonus;
            }
        }
    }
}