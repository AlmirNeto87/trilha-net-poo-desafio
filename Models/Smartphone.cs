namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public List<string> AplicativosInstalados { get; set; } = new List<string>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Este e o Aparelho Celular Modelo: {Modelo} com memoria de {Memoria}gb, de numero({Numero}) com o IMEI:{IMEI}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void ListarAplicativos();

        public abstract void DeletarAplicativo(string nomeApp);


    }
}