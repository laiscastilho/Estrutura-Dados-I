using System;
using System.Collections.Generic;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public List<Funcionario> Subordinados { get; set; }
}

class ProgramaPrincipal
{
    static void Main()
    {
        Funcionario chefe = CriarChefe("José Japão", "Diretor");
        ExibirHierarquia(chefe, 0);
    }

    static Funcionario CriarChefe(string nome, string cargo)
    {
        return new Funcionario
        {
            Nome = nome,
            Cargo = cargo,
            Subordinados = new List<Funcionario>
            {
                CriarFuncionario("Joãozinho", "Assistente de Vendas"),
                CriarFuncionario("Mariazinha", "Analista de Marketing",
                    new List<Funcionario>
                    {
                        CriarFuncionario("Pedrinho", "Assistente de Marketing")
                    }
                )
            }
        };
    }

    static Funcionario CriarFuncionario(string nome, string cargo, List<Funcionario> subordinados = null)
    {
        return new Funcionario
        {
            Nome = nome,
            Cargo = cargo,
            Subordinados = subordinados
        };
    }

    static void ExibirHierarquia(Funcionario funcionario, int nivel)
    {
        Console.WriteLine($"{new string('-', nivel * 4)}{funcionario.Nome} [{funcionario.Cargo}]");
        if (funcionario.Subordinados != null)
        {
            foreach (var subordinado in funcionario.Subordinados)
            {
                ExibirHierarquia(subordinado, nivel + 1);
            }
        }
    }
}
