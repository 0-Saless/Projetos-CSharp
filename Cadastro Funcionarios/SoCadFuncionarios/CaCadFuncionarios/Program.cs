using System;
using System.Collections.Generic;


namespace CaCadFuncionarios
{
    internal class Program
    {
        //Cria uma lista para armazenar objetos da classe Funcionario
        static List<Funcionario> funcionarios = new List<Funcionario>();
        static void Main(string[] args)//Menu
        {
            //Título e cores da console
            Console.Title = "Cadastro de Funcionários";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            
            int opcao;
            
            do//Cria o menu de opções
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Alterar");
                Console.WriteLine("3. Pesquisar");
                Console.WriteLine("4. Listar");
                Console.WriteLine("5. Excluir");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                //Verifica se o usuário digitou uma opção válida
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }
                //Executa a opção escolhida
                switch (opcao)
                {
                    case 1: CadastrarFuncionario(); break;
                    case 2: AlterarFuncionario(); break;
                    case 3: PesquisarFuncionario(); break;
                    case 4: ListarFuncionarios(); break;
                    case 5: ExcluirFuncionario(); break;
                    case 0: Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void CadastrarFuncionario()//Cadastrar
        {
            Console.Clear();
            Console.WriteLine("=== Cadastrar Funcionário ===");

            Console.Write("Matrícula: ");//Exige a matrícula
            //Verifica se o formato digitado é válido
            if (!int.TryParse(Console.ReadLine(), out int matricula))
            {
                Console.WriteLine("Matrícula inválida!");
                return;
            }

            // Verifica se a matrícula já existe
            if (funcionarios.Exists(f => f.Matricula == matricula))
            {
                Console.WriteLine("Erro: Já existe um funcionário com essa matrícula!");
                return;
            }
            Console.Write("Nome: ");//Exige o nome
            string nome = Console.ReadLine();

            Console.Write("Endereço: ");//Exige o endereço
            string endereco = Console.ReadLine();

            Console.Write("Telefone: ");//Exige o telefone
            string telefone = Console.ReadLine();

            Console.Write("Data de Nascimento (dd/MM/yyyy): ");//Exige a data de nascimento
            //Verifica se a data é válida
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataNasc))
            {
                Console.WriteLine("Data inválida!");
                return;
            }

            ///<summary>
            ///Cria uma nova instância da classe Funcionario com os dados fornecidos 
            ///Adiciona o novo funcionário a lista funcionarios
            /// </summary>
            funcionarios.Add(new Funcionario(matricula, nome, endereco, telefone, dataNasc));


            Console.WriteLine("Funcionário cadastrado com sucesso!");
        }

        static void AlterarFuncionario()//Alterar
        {
            Console.Clear();
            Console.WriteLine("=== Alterar Funcionário ===");
            Console.Write("Informe a matrícula: ");
            //Verfica se a matrícula é válida
            if (!int.TryParse(Console.ReadLine(), out int mat))
            {
                Console.WriteLine("Matrícula inválida!");
                return;
            }
            //Verfica se a matrícula existe
            Funcionario func = funcionarios.Find(f => f.Matricula == mat);
            if (func == null)
            {
                Console.WriteLine("Funcionário não encontrado!");
                return;
            }

            Console.Write("Novo Nome (vazio para manter): ");//Exige o novo nome
            string nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome)) func.Nome = nome;//Mantém o atual se o usuario não alterar

            Console.Write("Novo Endereço (vazio para manter): ");//Exige o novo endereço
            string endereco = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(endereco)) func.Endereco = endereco;//Mantém o atual se o usuario não alterar

            Console.Write("Novo Telefone (vazio para manter): ");//Exige o novo telefone
            string telefone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(telefone)) func.Telefone = telefone;//Mantém o atual se o usuario não alterar

            Console.Write("Nova Data de Nascimento (dd/MM/yyyy, vazio para manter): ");//Exige a nova data de nascimento
            string dataNascStr = Console.ReadLine();
            if (DateTime.TryParse(dataNascStr, out DateTime dataNasc)) func.DataNasc = dataNasc;//Mantém o atual se o usuario não alterar

            Console.WriteLine("Funcionário atualizado!");
        }

        static void PesquisarFuncionario()//Pesquisar
        {
            Console.Clear();
            Console.WriteLine("=== Pesquisar Funcionário ===");
            Console.Write("Digite a matrícula ou nome: ");//Exige a matrícula ou o nome
            string entrada = Console.ReadLine();
            //Pesquisa na List Funcionario se a opção digitada existe
            List<Funcionario> resultados = funcionarios.FindAll(f =>
            f.Matricula.ToString() == entrada || f.Nome.ToLower().Contains(entrada.ToLower()));
            if (resultados.Count == 0)// If não existe
            {
                Console.WriteLine("Nenhum funcionário encontrado!");
                return;
            }

            foreach (var func in resultados) //If existe, retorna os dados do funcionario
                Console.WriteLine(func);
        }

        static void ListarFuncionarios()//Listar
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Funcionários ===");
            //Verifica se não existe nenhum cadastro
            if (funcionarios.Count == 0)// If não existe
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
                return;
            }

            foreach (var func in funcionarios)// If existe, retorna todos os dados cadastrados
                Console.WriteLine(func);
        }

        static void ExcluirFuncionario()// Excluir
        {
            Console.Clear();
            Console.WriteLine("=== Excluir Funcionário ===");
            Console.Write("Informe a matrícula: ");
            //Verfica se a matrícula é válida
            if (!int.TryParse(Console.ReadLine(), out int mat))
            {
                Console.WriteLine("Matrícula inválida!");
                return;
            }
            //Verfica se a matrícula existe
            Funcionario func = funcionarios.Find(f => f.Matricula == mat);
            if (func == null)
            {
                Console.WriteLine("Funcionário não encontrado!");
                return;
            }

            funcionarios.Remove(func);//Remove o funcionario
            Console.WriteLine("Funcionário removido com sucesso!");
        }
       
    }
}
