namespace Models
{
    public class Oportunidade
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public DateTime dataEntrega { get; set; }
        public string nvlSurto { get; set; }
        public int qtdHoras {  get; set; }
        public long qtdErros { get; set;}
        public long aprendizadoNvl  { get; set;}
        public short horasDeSono { get; set; }
        public int horasFolga { get; set; }

    }
}
