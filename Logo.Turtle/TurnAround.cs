namespace Logo.Turtle
{
    public class TurnAround
    {
        public TurnAround(int posicao, int quantidade, int quantidadeF)
        {
            Posicao = posicao;
            Quantidade = quantidade;
            QuantidadeF = quantidadeF;
        }

        public int Posicao { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeF { get; set; }
        public bool IsImpar => Quantidade % 2 != 0;
    }
}
