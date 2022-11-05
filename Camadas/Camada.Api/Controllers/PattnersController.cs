using Camada.Api.Pattners.Adpter;
using Camada.Api.Pattners.Command;
using Camada.Api.Pattners.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace Camada.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PattnersController : ControllerBase
    {
        [HttpGet]
        [Route("Singleton")]
        public ActionResult<string> Singleton()
        {
            string mensagem = "";

            SingletonExemplo exemplo1 = SingletonExemplo.BuscarInstancia();
            SingletonExemplo exemplo2 = SingletonExemplo.BuscarInstancia();

            if (exemplo1 == exemplo2)
            {
                mensagem = "Singleton correto";

                if (exemplo1.AumentoSalario == 50)
                {
                    mensagem += "Aumento de salario em 50%";
                }
            }
            else
            {
                mensagem = "Singleton incorreto";
            }

            return Ok(mensagem);
        }

        [HttpGet]
        [Route("Adapter")]
        public ActionResult<string> Adapter()
        {
            string mensagem = "";
            Adaptee adaptee = new Adaptee();

            mensagem = adaptee.GetRequestOld();

            ITarget target = new Adapter(adaptee);
            mensagem += $"\n\t {target.GetRequestNew()}";


            return Ok(mensagem);
        }

        [HttpGet]
        [Route("Command")]
        public ActionResult<string> Command()
        {
            string mensagem = "";

            Video video = new Video();

            ICommand whatappCommand = new WhatsApp("Video audioslave - Musica Like a Strone");
            ICommand acaoVideoWhatsapp = new AcaoVideoWhatsapp(video, "https://www.youtube.com/watch?v=7QU1nvuxaMA");

            Invoker invoker = new Invoker(whatappCommand, acaoVideoWhatsapp);
            mensagem = invoker.ExecutaRotinaEventos();

            return Ok(mensagem);
        }
    }
}