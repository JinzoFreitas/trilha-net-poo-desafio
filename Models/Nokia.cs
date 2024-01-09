namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - OK
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" - OK
        public void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia")
        }
    }
}
