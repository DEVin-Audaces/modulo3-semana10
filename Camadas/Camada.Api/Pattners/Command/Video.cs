namespace Camada.Api.Pattners.Command
{
    public class Video
    {
        public string Play(string urlVideo)
        {
            return $"Opcao Play da {urlVideo} - ";
        }

        public string Stop()
        {
            return "Opcao parar";
        }

        public string AvancarVelocidade2()
        {
            return "Opcao Avancar Velocidade Dois - ";
        }
    }
}
