namespace src.Entities
{
    public class Hero 
    {
        protected string Name;
        protected int Age;
        protected int Level = 1;
        protected string Class;
        protected int pontosVida = 300;
        protected int pontosMana = 300;
        protected int xp = 0;

        public Hero (string n, int a){
            this.Name = n;
            this.Age = a;
        }
        public Hero (){

        }
        public virtual string Attack(){
            return this.Name + " Atacou com a espada!";
        }

        public virtual string Deffend(){
            return this.Name + "Defendeu-se";
        }

        
    }
}