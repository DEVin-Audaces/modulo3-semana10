namespace Camada.Api.Pattners.Command
{
    public class Invoker
    {
        private readonly ICommand whatsApp;
        private readonly ICommand acaoVideoWhatsapp;

        public Invoker(ICommand whatsApp, ICommand acaoVideoWhatsapp)
        {
            this.whatsApp = whatsApp;
            this.acaoVideoWhatsapp = acaoVideoWhatsapp;
        }

        public string ExecutaRotinaEventos()
        {
            string mensagemWhatsApp = whatsApp.Execute();  
            string mensagemAcaoVideoWhatsApp = acaoVideoWhatsapp.Execute();
            return mensagemWhatsApp + mensagemAcaoVideoWhatsApp;
        }
    }
}
