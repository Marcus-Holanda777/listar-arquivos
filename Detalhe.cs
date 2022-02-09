namespace Lista
{
    class Detalhe
    {
        public string Referencia { get; set; }
        public long Tamanho { get; set; }

        public Detalhe()
        {

        }
        public Detalhe(string referencia, long tamanho)
        {
            Referencia = referencia;
            Tamanho = tamanho;
        }
    }
}
