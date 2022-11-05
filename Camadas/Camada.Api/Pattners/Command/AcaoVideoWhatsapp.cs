namespace Camada.Api.Pattners.Command
{
    public class AcaoVideoWhatsapp : ICommand
    {
        private Video video;
        private string urlVideo;

        public AcaoVideoWhatsapp(Video video, string urlVideo)
        {
            this.video = video;
            this.urlVideo = urlVideo;
        }

        public string Execute()
        {
            string returnPlay = video.Play(urlVideo);
            string returnAvancarVelocidadeDois = video.AvancarVelocidade2();
            string returnsPararVideo = video.Stop();

            return returnPlay + returnAvancarVelocidadeDois + returnsPararVideo;
        }
    }
}
