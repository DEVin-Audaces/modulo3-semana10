namespace Camada.Api.Pattners.Command
{
    public class WhatsApp : ICommand
    {
        private string _mensagemEnviada = string.Empty;

        public WhatsApp(string mensagemEnviada)
        {
            _mensagemEnviada = mensagemEnviada;
        }

        public string Execute()
        {
            return _mensagemEnviada;
        }
    }
}
