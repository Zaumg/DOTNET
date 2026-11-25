using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //A View Index lê essa chave para exibir a mensagem
        ViewData["Mensagem"] = "Bem-vindo ao sistema!";
        return View();
    }

//Action que recebe parametro pela: /Home/Sobre/3
    public IActionResult Sobre(int? id)
    {
        ViewBag.Versao = "1.0";
        ViewBag.ParametroId = id;
        return View();
    }

    //Action que recebe parametros via query string: /Home/Saudacao?nome=Kessia
    public IActionResult Saudacao(string nome)
    {
        //Model Binding obtem nome da URL; usa "Visitante" se nada for informado
        ViewData["Nome"] = nome ?? "Visitante";
        return View();
    }
}
