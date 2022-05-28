namespace dotnet_POO.crc.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou magia!";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bonus de " + bonus + "!";   
            }
            else
            {
                return this.Name + " lançou magia fraca com bonus de " + bonus + "!";
            }
        }
    }
}