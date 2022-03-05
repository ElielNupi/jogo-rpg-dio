namespace src.Entities
{
    public class Mage : Hero
    {
        public Mage(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }

        public override string Attack()
        {
            return this.Name + $" Atacou com Mágia e gastou -50 de mana Total de mana: {this.pontosMana - 50}";
        }
        public string Attack(int T)
        {
            string res;
            if(T == 1){
                res = $" Usou mágia de fogo, gastou -70 de mana Total de mana:{this.pontosMana - 70}";
            }
            else if (T == 2){
                res = $" Usou mágia elétrica, gastou -80 de mana Total de mana:{this.pontosMana - 80}";
            }
            else{
                res = " NÃO CASTOU MÁGIA, use entre os números 1 e 2 das mágias disponiveis!";
            }
            return this.Name + res;
        }
        public override string Deffend()
        {
            return this.Name + $" Usou barreira mágica para se defender, gastou -20 de mana, Total de mana: {this.pontosMana - 20}";
        }
    }
}