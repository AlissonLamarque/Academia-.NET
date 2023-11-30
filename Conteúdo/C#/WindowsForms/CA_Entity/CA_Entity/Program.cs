using CA_Entity.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CA_Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite:\n1 - Criar uma pessoa\n2 - Alterar o nome de uma pessoa\n" +
                "3 - Inserir um email\n4 - Excluir uma pessoa\n5 - Consultar tudo\n" +
                "6 - Consultar pelo ID da pessoa\nSua opção: ");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Pessoa p = new Pessoa();
                        Console.WriteLine("Insira o nome da pessoa: ");
                        p.nome = Console.ReadLine();

                        Console.WriteLine("Insira um email: ");
                        string emailTmp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTmp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Pessoa inserida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o nome correto: ");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                        Console.WriteLine("Alteração efetuada!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe um novo email: ");
                        string emailTmp = Console.ReadLine();

                        p.Emails.Add(new Email() { email = emailTmp });
                        contexto.Pessoas.Update(p);
                        contexto.SaveChanges();
                        Console.WriteLine("Sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine($"Confirma a exclusão de {p.nome} e de seus emails?");
                        foreach(Email e in p.Emails)
                        {
                            Console.WriteLine($"\t{e.email}");
                        }
                        Console.WriteLine("1 para SIM e 2 para NÃO");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine($"{p.nome} removido com sucesso!");
                        } 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        //LINQ
                        List<Pessoa> lista = (from Pessoa p in contexto.Pessoas select p).Include(pes => pes.Emails).ToList<Pessoa>();

                        foreach (Pessoa p in lista)
                        {
                            Console.WriteLine($"{p.nome}");
                            foreach (Email e in p.Emails)
                            {
                                Console.WriteLine("\t" + e.email);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails).FirstOrDefault(p => p.id == id);

                        foreach (Email item in pessoa.Emails)
                        {
                            Console.WriteLine($"\t{item.email}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }
}