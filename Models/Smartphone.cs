namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Propriedades adicionais podem ser adicionadas aqui

        public Smartphone(string numero)
        {
            Numero = numero;
            // Outras propriedades podem ser inicializadas aqui
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    
    }
}