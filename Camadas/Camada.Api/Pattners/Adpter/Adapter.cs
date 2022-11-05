namespace Camada.Api.Pattners.Adpter
{
    public class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string GetRequestNew()
        {
            return $"Nova Acao chamando a mensagem do request antiga {adaptee.GetRequestOld()}";
        }
    }
}
