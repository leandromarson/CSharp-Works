namespace Interface
{
    class Animal : IAnimal
    {
        private int _numPatas;
        private string _cor, _nome;

        public int NumPatas{
            get => _numPatas;
            set => _numPatas = value;
        }
        public string Cor{
            get => _cor;
            set => _cor = value;
        }
        public string Nome{
            get => _nome;
            set => _nome = value;
        }


        public Animal(int numPatas, string cor, string nome)
        {
            _numPatas = numPatas;
            _cor = cor;
            _nome = nome;
        }


        public void Comer()
        {
            try{
                System.Console.WriteLine(Nome+" está comendo!");                    
            }catch{
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
        }

        public void Correr()
        {
            try{
                if(this._numPatas>0){
                    System.Console.WriteLine(Nome+" está correndo!");
                }else{
                    System.Console.WriteLine(Nome+" está rastejando!");
                }
            }catch{
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
                
        }

        public void FazerBarulho()
        {
            try{
                System.Console.WriteLine(Nome+" está fazendo barulho!");                    
            }catch{
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }                                
        }
    }
}

