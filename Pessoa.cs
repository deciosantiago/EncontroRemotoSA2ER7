namespace Encontro_Remoto
{
    public abstract class Pessoa
    {
        public string? nome { get; set; }

        public Endereco? endereco { get; set; }

        public abstract double PagarImposto(float rendimento);

        public float rendimento { get; set; }


    }
}