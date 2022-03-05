namespace src.Entities
{
    public class Warrior : Hero
    {
        
        public Warrior(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }
        
        protected string Arma = "Espada Comum";
        private int DanoArma = 50;
        protected string Defesa = "Escudo Comum";
        private int Defender = 30;
        public override string Attack()
        {
            return this.Name + $" Atacou com a {Arma} e deu {DanoArma} de dano";
        }
        public string MagicAttack(){
            return this.Name + $" Usou ataque mágico!! e gastou -50 de Mana, Total de Mana : {this.pontosMana - 50}";
        }
        public override string Deffend()
        {
            return this.Name + $" Se defendeu com o {Defesa} - {Defender} de dano do inimigo";
        }
    }
}