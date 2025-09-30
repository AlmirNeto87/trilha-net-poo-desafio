namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria)
           : base(numero, modelo, imei, memoria)
        {
        }



        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (!AplicativosInstalados.Contains(nomeApp))
            {
                AplicativosInstalados.Add(nomeApp);
                Console.WriteLine($"Aplicativo {nomeApp} Instalado pela I Place da Apple");
            }
            else
            {
                Console.WriteLine($"O aplicativo '{nomeApp}' já está instalado.");
            }
            
        }

         public override void ListarAplicativos()
        {   
            Console.WriteLine("Lista dos Aplicativos Instalados na Iplace Abaixo:");
                if (AplicativosInstalados.Count == 0)
            {
                Console.WriteLine("- Nenhum aplicativo instalado.");
                return;
            }

            
            foreach (var app in AplicativosInstalados)
            {
                Console.WriteLine($"Aplicativo {app} ");
            }
        }

        public override void DeletarAplicativo(string nomeApp)
        {
            if (AplicativosInstalados.Contains(nomeApp))
            {
                AplicativosInstalados.Remove(nomeApp);
                Console.WriteLine($"Aplicativo '{nomeApp}' desinstalado com sucesso.");
            }
            else
            {
                Console.WriteLine($"O aplicativo '{nomeApp}' não está instalado.");
            }
            
        }  

        
    }
}