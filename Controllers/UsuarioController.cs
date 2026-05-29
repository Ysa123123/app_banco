using Microsoft.AspNetCore.Mvc;
using Segundo_App_BancoDados.Models;
using Segundo_App_BancoDados.Repository.Contract;

namespace Segundo_App_BancoDados.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            return View(_usuarioRepository.ObterTodosUsuarios());
        }
        [HttpGet]
        public IActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepository.Cadastrar(usuario);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            return View(_usuarioRepository.ObterUsuario(id));
        }
        [HttpPost]
        public IActionResult Atualizar(Usuario usuario)
        {
            return View();
        }

}
