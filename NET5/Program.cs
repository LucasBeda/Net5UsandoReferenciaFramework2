using Framework2.Service;
using System;

Console.WriteLine("Hello World!");

var a = new
{
    Nome = "LkzA",
    Senha = "123"
};

Console.WriteLine($"Usuario {a}");

ControleAcesso.Login(a.Nome, a.Senha);
bool loginFeito = ControleAcesso.RetornaLoginRealizado();
Console.WriteLine($"Login Realizado? {loginFeito}");

Console.WriteLine("Fim execução código");
Console.ReadKey();
