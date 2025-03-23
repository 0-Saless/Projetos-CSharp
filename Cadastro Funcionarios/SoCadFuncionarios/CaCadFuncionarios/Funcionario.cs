using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaCadFuncionarios
{
    class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }

        // Construtor padrão
        public Funcionario() { }

        // Construtor parametrizado
        public Funcionario(int matricula, string nome, string endereco, string telefone, DateTime dataNasc)
        {
            Matricula = matricula;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            DataNasc = dataNasc;
        }

        // Método para calcular idade corretamente
        public int Idade()
        {
            int idade = DateTime.Now.Year - DataNasc.Year;
            if (DateTime.Now < DataNasc.AddYears(idade))
                idade--;
            return idade;
        }

        // Sobrescrevendo ToString()
        public override string ToString()
        {
            return $"\n\nFuncionário\n" +
                   $"Matrícula: {Matricula}\n" +
                   $"Nome: {Nome}\n" +
                   $"Endereço: {Endereco}\n" +
                   $"Telefone: {Telefone}\n" +
                   $"Data de Nascimento: {DataNasc:dd/MM/yyyy}\n" +
                   $"Idade: {Idade()} anos";
        }
    }
}
