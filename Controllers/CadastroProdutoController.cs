using EspacoVerde.Data;
using EspacoVerde.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EspacoVerde.Controllers
{
    public class CadastroProdutoController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;

        public CadastroProdutoController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var localizacoes = _context.Localizacoes.ToList();
            ViewBag.ID_Localizacao = new SelectList(localizacoes, "ID_Localizacao", "Cidade");
            return View();
        }


        // POST: Residuos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Residuo residuo)
        {
            //o erro esta aqui, o ModelState.IsValid está sempre retornando false mesmo com os dados sendo preenchidos corretamnente
            //na view Create quando enviado com o metodo post
            if (ModelState.IsValid)
            {
                if (residuo.ImageFile != null && residuo.ImageFile.Length > 0)
                {
                    
                    // Caminho onde a imagem será salva
                    string wwwRootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(residuo.ImgUrl);
                    string extension = Path.GetExtension(residuo.ImageFile.FileName);
                    fileName = fileName + "_" + Guid.NewGuid().ToString().Substring(0, 6) + extension;
                    string path = Path.Combine(wwwRootPath + "/vendor/imgs/", fileName);

                    // Salva a imagem
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await residuo.ImageFile.CopyToAsync(fileStream);
                    }

                    // Guarda apenas o nome do arquivo no banco
                    residuo.ImgUrl = fileName;
                }

                // Define o ID do usuário (lembre-se que este é um placeholder)
                residuo.ID_Usuario = 1;

                // Salva o objeto no banco de dados
                _context.Add(residuo);
                await _context.SaveChangesAsync();

                // Redireciona para outra página
                return RedirectToAction("Index", "Home"); // Ou para a página de listagem de resíduos
            }

            // Se o ModelState não for válido, retorna a View com os erros e recarrega as localizações
            var localizacoesParaRetorno = _context.Localizacoes.ToList();
            ViewBag.ID_Localizacao = new SelectList(localizacoesParaRetorno, "ID_Localizacao", "Cidade");
            return View(residuo);
        }



    }
}
