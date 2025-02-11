namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo  { get; set; }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        private string _imei { get; set; } 
        public string Imei
        {
            get { return _imei; }
            set { _imei = value; }
        }
        private string _memoria { get; set; }
        public string Memoria
        {
            get { return _memoria; }
            set { _memoria = value; }
        }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
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

        public abstract void InstalarAplicativo(string nomeApp);
    }
}