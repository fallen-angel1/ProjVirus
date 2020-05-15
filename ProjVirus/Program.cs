using grafico;
using ProjVirus.grafico;
using ProjVirus.pais;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsInput;
using WindowsInput.Native;

namespace ProjVirus
{
    class Program
    {
        public static List<Italia> italia = new List<Italia>();
        public static List<Portugal> portugal = new List<Portugal>();
        public static List<EUA> EUA = new List<EUA>();
        public static List<China> china = new List<China>();
        public static List<Espanha> espanha = new List<Espanha>();
        public static List<PaisesDadosGer> paisesDados = new List<PaisesDadosGer>();

        public static List<Tuple<int, int, int>> portugalValores = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> espanhaValores = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> italiaValores = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> chinaValores = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> euaValores = new List<Tuple<int, int, int>>();

        static void Main(string[] args)
        {
            int opcao = 0;
            int[] morItEuaEsCh = new int[4];

            Random rd = new Random();

            for (int i = 0; i < morItEuaEsCh.Length; i++)
            {
                morItEuaEsCh[i] = rd.Next(5000, 92000);
            }

            italia.Add(new Italia(80, morItEuaEsCh[0]));
            EUA.Add(new EUA(81, morItEuaEsCh[1]));
            china.Add(new China(78, morItEuaEsCh[2]));
            espanha.Add(new Espanha(82, morItEuaEsCh[3]));
            portugal.Add(new Portugal(79));

            int somArrayMortes = morItEuaEsCh.Sum();
            int dadosMortalidadePortugal = Program.portugal.Where(item => item.mortalidade > 0).Sum(item => item.mortalidade);
            int todasMortesPaises = somArrayMortes + dadosMortalidadePortugal;

            paisesDados.Add(new PaisesDadosGer(todasMortesPaises));
            try
            {
                GraficoMov grafico = new GraficoMov();

                while (!grafico.GrafTerminar)
                {
                    Console.Clear();
                    Tela.imprimirGraficoInicio(grafico);
                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                        opcao = 0;
                    }
                    Console.WriteLine();

                    if (opcao == 1)
                    {
                        Tela.DadosGerais(grafico);

                    }
                    else if (opcao == 2)
                    {
                        Tela.escolhaPortugal(grafico);
                        grafico.VirusDadosGerais("Portugal");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        grafico.VirusDadosGerais("Todos");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Write("Voltar ao ecra inicial? s/n");
                        char afir = char.Parse(Console.ReadLine());
                        if (afir == 's')
                        {
                            Console.Clear();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else
                        {
                            Console.WriteLine("Fim do Programa!");
                        }
                    }
                    else if (opcao == 3)
                    {
                        Tela.escolhaItalia(grafico);
                        grafico.VirusDadosGerais("Italia");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        grafico.VirusDadosGerais("Todos");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Write("Voltar ao ecra inicial? s/n");
                        char afir = char.Parse(Console.ReadLine());
                        if (afir == 's')
                        {
                            Console.Clear();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else
                        {
                            Console.WriteLine("Fim do Programa!");
                        }
                    }
                    else if (opcao == 4)
                    {
                        Tela.escolhaChina(grafico);
                        grafico.VirusDadosGerais("China");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        grafico.VirusDadosGerais("Todos");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Write("Voltar ao ecra inicial? s/n");
                        char afir = char.Parse(Console.ReadLine());
                        if (afir == 's')
                        {
                            Console.Clear();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else
                        {
                            Console.WriteLine("Fim do Programa!");
                        }
                    }
                    else if (opcao == 5)
                    {
                        Tela.escolhaEua(grafico);
                        grafico.VirusDadosGerais("Eua");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        grafico.VirusDadosGerais("Todos");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Write("Voltar ao ecra inicial? s/n");
                        char afir = char.Parse(Console.ReadLine());
                        if (afir == 's')
                        {
                            Console.Clear();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else
                        {
                            Console.WriteLine("Fim do Programa!");
                        }
                    }
                    else if (opcao == 6)
                    {
                        Tela.escolhaEspanha(grafico);
                        grafico.VirusDadosGerais("Espanha");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        grafico.VirusDadosGerais("Todos");
                        Tela.imprimirGraficoInicio(grafico);

                        Console.Write("Voltar ao ecra inicial? s/n");
                        char afir = char.Parse(Console.ReadLine());
                        if (afir == 's')
                        {
                            Console.Clear();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else
                        {
                            Console.WriteLine("Fim do Programa!");
                        }
                    }
                    Console.ReadLine();
                }
            }
            catch (GraficoException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}