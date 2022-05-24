using System;
using System.Threading;
using System.Collections.Generic;

namespace Encontro_Remoto
{

    class Program
    {

        static void Main(string[] args)
        {
            List<PessoaFisica> ListPf = new List<PessoaFisica>();
            List<PessoaJuridica> ListPj = new List<PessoaJuridica>();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"

============================================
| Seja bem vindo ao cadastro de usuários   |
============================================
");

            BarraCarregamento("Iniciando");

            String? opcao;

            do
            {

                Console.WriteLine(@$"

        
============================================
| Escolha uma das opções abaixo:           |
|                                          |
|              Pessoa Física               |
|                                          |
|  1 - Cadastrar Física                    |
|  2 - Lista Física                        |
|  3 - Remove Física                       |
|  0 - Sair                                |
|                                          |
|              Pessoa Jurídica             |
|                                          |
|  4 - Cadastrar Jurídica                  |
|  5 - Lista Jurídica                      |
|  6 - Remove Jurídica                     |
|  0 - Sair                                |
|                                          |
============================================    
");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        Endereco end = new Endereco();

                        Console.WriteLine($"Digite seu Endereço");
                        end.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número do seu endereço");
                        end.numero = int.Parse(Console.ReadLine());


                        Console.WriteLine($"Digite o Complemento");
                        end.complemento = Console.ReadLine();


                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string enderecoComercial = Console.ReadLine().ToUpper();

                        if (enderecoComercial == "S")
                        {
                            end.enderecoComercial = true;
                        }
                        else
                        {
                            end.enderecoComercial = false;
                        }





                        PessoaFisica Pf = new PessoaFisica();


                        Console.WriteLine($"Digite o número do Cpf (somente números)");
                        Pf.cpf = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite Seu nome");
                        Pf.nome = Console.ReadLine();

                        Console.WriteLine($"Digite sua data de nascimento");
                        Pf.dataDeNascimento = DateTime.Parse(Console.ReadLine());







                        PessoaFisica NovaPf = new PessoaFisica();




                        bool idadeValida = NovaPf.ValidarDataNascimento(NovaPf.dataDeNascimento);


                        Console.WriteLine("Maior de idade: " + idadeValida);

                        if (idadeValida == true)
                        {

                            Console.WriteLine("Cadastro Aprovado");
                            ListPf.Add(NovaPf);

                        }
                        else
                        {

                            Console.WriteLine("Cadastro inválido");
                        }


                        break;


                    case "2":

                        foreach (var cadaItem in ListPf)
                        {
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}, {cadaItem.dataDeNascimento}");
                        }

                        break;




                    case "3":

                        Console.WriteLine($"Digite o CPF que deseja remover");
                       float cpfprocurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada ListPf.Find(cadaItem => cadaItem.cpf == cpfprocurado);

                        if (pessoaEncontrada != null)
                        {
                            ListPf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Cadastro removido");


                        }
                        else
                        {

                            Console.WriteLine($"Cpf não encontrado");
                        }


                        break;



                    case "4":

                        Endereco endPj = new Endereco();

                        Console.WriteLine($"Digite seu Endereço");
                        endPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite seu Endereço");
                        endPj.numero = int.Parse(Console.ReadLine());


                        Console.WriteLine($"Digite o Complemento");
                        endPj.complemento = Console.ReadLine();


                        
                        PessoaJuridica Pj = new PessoaJuridica();


                        Console.WriteLine($"Digite o número do Cpf (somente números)");
                        Pj.cnpj = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite Sua Razão Social");
                        Pj.razaoSocial = Console.ReadLine();




                        break;


                    case "5":

                        foreach (var cadaItemPj in ListPj)
                        {
                            Console.WriteLine($"{cadaItemPj.nome}, {cadaItemPj.cnpj}");
                        }

                        break;




                    case "6":

                        Console.WriteLine($"Digite o CNPJ que deseja remover");
                        float cnpjProcurado = Console.ReadLine();

                        PessoaJuridica pessoaPjEncontrada ListPj.Find(cadaItem => cadaItem.cnpj == cnpjProcurado);

                        if (pessoaEncontrada != null)
                        {
                            ListPj.Remove(pessoaPjEncontrada);
                            Console.WriteLine($"Cadastro removido");


                        }
                        else
                        {

                            Console.WriteLine($"Cnpj não encontrado");
                        }


                        break;
                }


            } while (opcao != "0");




            static void BarraCarregamento(string textoCarregamento)

            {

                Console.ResetColor();
                Console.WriteLine(textoCarregamento);
                Thread.Sleep(500);


                for (var contador = 0; contador < 10; contador++)
                {

                    Console.Write($".");
                    Thread.Sleep(500);

                }


                Console.ResetColor();

            }
        }

    }

}
