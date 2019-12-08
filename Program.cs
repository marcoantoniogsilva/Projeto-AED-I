﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projeto_Presidio
{
    class Program
    {
        static void Main(string[] args)
        {
           
                    Menu();
                    
           
        }

        public static void Menu()
        {
            Console.WriteLine("                                      "
                              + "    _________________________________");
            Console.WriteLine();
            Console.WriteLine("                                      "
                              + "    Presídio de Xuri - Prison Control");
            Console.WriteLine("                                      "
                              + "    _________________________________");
            Console.WriteLine();
            Console.WriteLine("                                      "
                              + "              MENU PRINCIPAL         ");
            Console.WriteLine("1 - Ver relatorios das celas");
            Console.WriteLine("2 - Cadastrar Preso;");
            Console.WriteLine("3 - Gerenciar Preso;");
            Console.WriteLine("4 - Ver arquivo de Presos Transferidos");
            Console.WriteLine("5 - Cadastrar carcereiro;");
            Console.WriteLine("6 - Gerenciar carcereiro;");
            Console.WriteLine("7 - Ver relatorios de Carcereiros");
            Console.WriteLine("8 - Ver arquivo de Carcereiros Demitidos");
            Console.WriteLine("9 - Sair;");
            Console.WriteLine();
            Console.Write("> Digite a opção desejada: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num == 1)
            {
                VerCela();
            }
           else if (num == 2)
           {
                CadastrarPreso();
           }
            else if (num == 3)
            {
                GerenciarPreso();
            }
            else if (num == 4)
            {
                Presidio.RelatorioPresosTrasferidos();
            }
            else if (num == 5)
            {
                CadastrarCarcereiro();
            }
            else if (num == 6)
            {
                Gerenciarcarcereiros();
            }
            else if (num == 7)
            {
                Presidio.RelatorioCarcereiros();
            }
            else if (num == 8)
            {
                Presidio.RelatorioCarcereirosDemitidos();
            }
            else 
            {
                Console.WriteLine(" Sistema Finalizado");
            }
        }

        public static void VerCela()
        {
            
            while (true)
            {
                Console.WriteLine("                                      "
                              + "                VER CELAS                  ");
               
                Console.WriteLine("  1 - Cela M1; 2 - Cela M2; 3 - Cela M3;");
                Console.WriteLine("  4 - Cela F1; 5 - Cela F2; 6 - Cela F3;");
                Console.WriteLine("  7 - Nenhuma (Sair); 8 - Menu principal");
                Console.WriteLine();
                Console.Write("> Digite o número da cela que queira ver: ");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 == 1 || num1 == 2 || num1 == 3)
                {
                    Presidio.Ver_CelaMasculina(num1);
                }
                else if (num1 == 4 || num1 == 5 || num1 == 6)
                {
                    Presidio.Ver_CelaFeminina(num1);
                }

                else if ( num1 == 7)
                {
                    Console.WriteLine("Sistema finalizado com sucesso!");
                    break;
                }
                else if (num1 == 8)
                {
                    Menu();
                }
              
            }
        }

        public static void CadastrarPreso()
        {
            Console.WriteLine("                                      "
                             + "             CADASTRAR PRESO                  ");

            Presidiario P2 = new Presidiario();

            Console.WriteLine(" Sexo do Preso: M - Masculino / F - Feminino.");
            char S = char.Parse(Console.ReadLine());
            while (!P2.setSexo(S))
            {
                Console.WriteLine("Caracter inválido!");
                Console.Write("> Por favor, tente novamente: ");
                S = char.Parse(Console.ReadLine());
            }

            if (P2.getsexo() == 'M' || P2.getsexo() == 'm')
            {
                CadastrarPresoMasculino();
            }

            else if (P2.getsexo() == 'F' || P2.getsexo() == 'f')
            {
                CadastrarPresoFeminino();
            }

        }

        static void CadastrarPresoMasculino()
        {
            List<Presidiario> Simples = new List<Presidiario>();
            List<Presidiario> Qualificado = new List<Presidiario>();
            List<Presidiario> Hediondo = new List<Presidiario>();

            CelaMasculina cela1 = new CelaMasculina();
            CelaMasculina cela2 = new CelaMasculina();
            CelaMasculina cela3 = new CelaMasculina();


            Presidio Xuri2 = new Presidio(cela1, cela2, cela3);

            Presidiario P1 = new Presidiario();

            Console.WriteLine("Opções de crimes:");
            Console.WriteLine("| 1 - Simples; 2 - Qualificado; 3 - Hediondo |");
            Console.Write("> Digite o tipo de crime: ");
            int crime = int.Parse(Console.ReadLine());

            while (!P1.setCrime(crime))
            {
                Console.WriteLine("Opção inválida! Tipo de crime inexistente!");
                Console.WriteLine("| 1 - Simples; 2 - Qualificado; 3 - Hediondo |");
                Console.Write("> Por favor, tente novamente: ");
                crime = int.Parse(Console.ReadLine());
            }
            
            if (P1.getCrime() == 1)
            {
                while (!cela1.VerificaCelaMasculina1())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            if (P1.getCrime() == 2)
            {
                while (!cela2.VerificaCelaMasculina2())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int res = int.Parse(Console.ReadLine());
                    if (res == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            if (P1.getCrime() == 3)
            {
                while (!cela3.VerificaCelaMasculina3())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int resp = int.Parse(Console.ReadLine());
                    if (resp == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            Console.Write("> Nome: ");
            string nome = Console.ReadLine();

            while (!P1.setNome(nome))
            {
                Console.Write("Nome inválido!");
                Console.WriteLine("> Por favor, tente novamente: ");
                nome = Console.ReadLine();
            }
            P1.setNome(nome);

            Console.Write("> ID (4 primeiros dígitos do CPF): ");
            string id = Console.ReadLine();

            while (!P1.verificarId(id))
            {
                Console.Write("ID inválido!");
                Console.WriteLine("> Por favor, tente novamente: ");
                id = Console.ReadLine();
            }


            Data dat = new Data();
            Console.Write("> Data de nascimento (DD/MM/AAAA): ");
            string datanascimento = Console.ReadLine();

            while (!dat.setData(datanascimento))
            {
                Console.WriteLine("Data de nascimento inválida!");
                Console.Write("> Por favor, tente novamente: ");
                datanascimento = Console.ReadLine();
            }

            Data nascimento = new Data(datanascimento);
            while (!P1.setDataDeNascimento(nascimento))
            {
                Console.WriteLine("Data de nascimento inválida!");
                Console.Write("> Por favor, tente novamente: ");
                datanascimento = Console.ReadLine();
                nascimento = new Data(datanascimento);
            }
            P1.setDataDeNascimento(nascimento);


            if (P1.getCrime() == 1)
            {
                P1.setPeriodoDeReclusao(15);
                Simples.Add(P1);
                cela1.setPreso(Simples);
                Xuri2.Cadastrar_presosMasculino1();

            }

            else if (P1.getCrime() == 2)
            {
                P1.setPeriodoDeReclusao(20);
                Qualificado.Add(P1);
                cela2.setPreso(Qualificado);
                Xuri2.Cadastrar_presosMasculino2();
            }

            else if (P1.getCrime() == 3)
            {
                P1.setPeriodoDeReclusao(30);
                Hediondo.Add(P1);
                cela3.setPreso(Hediondo);
                Xuri2.Cadastrar_presosMasculino3();
            }
                                             
            Console.WriteLine("Cadastrar novo preso?");
            Console.Write("| 1 - Sair; 2 - Sim;  3 - Menu principal |");
            Console.WriteLine("> Digite a opção desejada:");
           int  re = int.Parse(Console.ReadLine());
            if (re == 3)
            {
                Menu();
            }

            else if ( re == 2)
            {
                CadastrarPreso();
            }           
             else
            {
                Console.WriteLine( " Sisitema finalizado com sucesso:");
            }
        }

        static void CadastrarPresoFeminino()
        {
            List<Presidiario> Simples = new List<Presidiario>();
            List<Presidiario> Qualificado = new List<Presidiario>();
            List<Presidiario> Hediondo = new List<Presidiario>();

            CelaFeminina cela1 = new CelaFeminina();
            CelaFeminina cela2 = new CelaFeminina();
            CelaFeminina cela3 = new CelaFeminina();


            Presidio Xuri2 = new Presidio(cela1, cela2, cela3);

            Presidiario P1 = new Presidiario();

           


            Console.WriteLine("Opções de crimes:");
            Console.WriteLine("| 1 - Simples; 2 - Qualificado; 3 - Hediondo |");
            Console.Write("> Digite o tipo de crime: ");
            int crime = int.Parse(Console.ReadLine());

            while (!P1.setCrime(crime))
            {
                Console.WriteLine("Opção inválida! Tipo de crime inexistente!");
                Console.WriteLine("| 1 - Simples; 2 - Qualificado; 3 - Hediondo |");
                Console.Write("> Por favor, tente novamente: ");
                crime = int.Parse(Console.ReadLine());
            }
            P1.setCrime(crime);

            if (P1.getCrime() == 1)
            {
                while (!cela1.VerificaCelaFeminina1())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int res = int.Parse(Console.ReadLine());
                    if (res == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            if (P1.getCrime() == 2)
            {
                while (!cela2.VerificaCelaFeminina2())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int resp = int.Parse(Console.ReadLine());
                    if (resp == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            if (P1.getCrime() == 3)
            {
                while (!cela3.VerificaCelaFeminina3())
                {
                    Console.WriteLine("Opção inválida! A cela está cheia!");
                    Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
                    Console.Write("> Digite a opção desejada: ");
                    int respo = int.Parse(Console.ReadLine());
                    if (respo == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Sistema finalizado com sucesso!");
                        break;
                    }
                }
            }

            Console.Write("> Nome: ");
            string nome = Console.ReadLine();

            while (!P1.setNome(nome))
            {
                Console.Write("Nome inválido!");
                Console.WriteLine("> Por favor, tente novamente: ");
                nome = Console.ReadLine();
            }
            P1.setNome(nome);

            Console.Write("> ID (4 primeiros dígitos do CPF): ");
            string id = Console.ReadLine();

            while (!P1.verificarId(id))
            {
                Console.Write("ID inválido!");
                Console.WriteLine("> Por favor, tente novamente: ");
                id = Console.ReadLine();
            }


            Data dat = new Data();
            Console.Write("> Data de nascimento (DD/MM/AAAA): ");
            string datanascimento = Console.ReadLine();

            while (!dat.setData(datanascimento))
            {
                Console.WriteLine("Data de nascimento inválida!");
                Console.Write("> Por favor, tente novamente: ");
                datanascimento = Console.ReadLine();
            }

            Data nascimento = new Data(datanascimento);
            while (!P1.setDataDeNascimento(nascimento))
            {
                Console.WriteLine("Data de nascimento inválida!");
                Console.Write("> Por favor, tente novamente: ");
                datanascimento = Console.ReadLine();
                nascimento = new Data(datanascimento);
            }
            P1.setDataDeNascimento(nascimento);


            if (P1.getCrime() == 1)
            {
                P1.setPeriodoDeReclusao(15);
                Simples.Add(P1);
                cela1.setPreso(Simples);
                Xuri2.Cadastrar_presosFeminina1();

            }

            else if (P1.getCrime() == 2)
            {
                P1.setPeriodoDeReclusao(20);
                Qualificado.Add(P1);
                cela2.setPreso(Qualificado);
                Xuri2.Cadastrar_presosFeminina2();
            }

            else if (P1.getCrime() == 3)
            {
                P1.setPeriodoDeReclusao(30);
                Hediondo.Add(P1);
                cela3.setPreso(Hediondo);
                Xuri2.Cadastrar_presosFeminina3();
            }

            Console.WriteLine("Cadastrar novo preso?");
            Console.Write("| 1 - Sair; 2 - Sim;  3 - Menu principal |");
            Console.WriteLine("> Digite a opção desejada:");
            int re = int.Parse(Console.ReadLine());
            if (re == 3)
            {
                Menu();
            }
                 
            else if (re == 2)
            {
                CadastrarPreso();
            }

            else
            {
                Console.WriteLine(" Sistema finalozado com sucesso: ");
            }
        }
        static void CadastrarCarcereiro()
        {
           
            while (true)
            {
                Carcereiro C1 = new Carcereiro();

                while (!C1.VerificaqtdCarcereiro())
                {
                    Console.Write("ERRO! Quadro de funcionarios completo");
                    Menu();
                }

               
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                while (!C1.setNome(nome))
                {
                    Console.Write("ERRO! Nome inválido.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    nome = Console.ReadLine();
                }

                Console.Write("Número ID do, com 4 digitos): ");
                string cpf = Console.ReadLine();
                while (!C1.verificarId(cpf))
                {
                    Console.Write("ERRO! ID ja existente.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    cpf = Console.ReadLine();
                }

                Data dat = new Data();
                Console.Write("Data de nascimento (dd/MM/AAAA): ");
                string datanascimento = Console.ReadLine();
                while (!dat.setData(datanascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    datanascimento = Console.ReadLine();
                }
                Data nascimento = new Data(datanascimento);
                while (!C1.setDataDeNascimento(nascimento))
                {
                    Console.WriteLine("ERRO! Data de nascimento inválida, carcereiro  é menor de idade.");
                    Console.Write("Por favor, tente novamente: ");
                    datanascimento = Console.ReadLine();
                    nascimento = new Data(datanascimento);
                }

                Console.WriteLine(" Qual Sexo: M - Masculino / F - Feminino");
                char S = char.Parse(Console.ReadLine());
                while (!C1.setSexo(S))
                {
                    Console.WriteLine("ERRO! Sexo inválido.");
                    Console.Write("Por favor, tente novamente (dd/MM/AAAA): ");
                    S = char.Parse(Console.ReadLine());
                }

                Console.Write("Qual a Patente do carcereiro? Soldado / Cabo : ");
                string Car = Console.ReadLine();
                while (!C1.VerificaPatente(Car))
                {
                    Console.Write("ERRO! Patente não existente.");
                    Console.WriteLine("Por favor, tente novamente: ");
                    Car = Console.ReadLine();
                }

                if (C1.getPatente() == "Soldado" || C1.getPatente() == "soldado")
                {
                    C1.setSalario(2000);
                }
                else if (C1.getPatente() == "Cabo" || C1.getPatente() == "cabo")
                {
                    C1.setSalario(3000);
                }


                List<Carcereiro> Car1 = new List<Carcereiro>();
                Car1.Add(C1);
                Presidio xuri3 = new Presidio();
                xuri3.setCarcereiros(Car1);



                Console.WriteLine("Cadastrar novo Carcereiro? (1 - Sair | 2 - Sim |+" +
                                  " 3 - Menu principal):");
                int numero = int.Parse(Console.ReadLine());

                xuri3.CadastrarCarcereiros();

                if (numero == 1)
                {
                    break;
                }
                else if (numero == 3)
                {
                    Menu();
                }

            }

        }
        static void GerenciarPreso()
        {
            Presidio xuri4 = new Presidio();
            Console.WriteLine("                                      "
                              + "             GERENCIAR PRESO                  ");
            Console.WriteLine("Opções de celas:");
            Console.WriteLine("| 1 - M Simples; 2 - M Qualificados; 3 - M Hediondos + " +
                              "| 4 - F Simples; 5 - F Qualificados; 6 - F Hediondos");
            Console.Write("> Digite o número da cela: ");
            int cr = int.Parse(Console.ReadLine());

            if (cr == 1)
            {
                xuri4.GerenciarCelaMasculina1();
            }
            else if (cr == 2)
            {
                xuri4.GerenciarCelaMasculina2();
            }

            else if (cr == 3)
            {
                xuri4.GerenciarCelaMasculina3();
            }

            else if (cr == 4)
            {
                xuri4.GerenciarCelaFeminina1();
            }
            else if (cr == 5)
            {
                xuri4.GerenciarCelaFeminina2();
            }

            else if (cr == 6)
            {
                xuri4.GerenciarCelaFeminina3();
            }
         
            Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
            Console.Write("> Digite a opção desejada: ");
            int numer = int.Parse(Console.ReadLine());

            if (numer == 1)
            {
                Menu();
            }
            else if (numer == 2)
            {
                Console.WriteLine("Sistema finalizado com sucesso!");
            }
        }

        static void Gerenciarcarcereiros()
        {
            Presidio xuri2 =  new Presidio();
            xuri2.GerenciarCarcereiros();

            Console.WriteLine("| 1 - Menu principal; 2 - Sair |");
            Console.Write("> Digite a opção desejada: ");
            int numer = int.Parse(Console.ReadLine());

            if (numer == 1)
            {
                Menu();
            }
            else if (numer == 2)
            {
                Console.WriteLine("Sistema finalizado com sucesso!");
            }
        }


    }
}
