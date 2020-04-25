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

            int mortGeral = 0;
            foreach (int item in morItEuaEsCh)
            {
                mortGeral += item;
            }
            paisesDados.Add(new PaisesDadosGer(mortGeral));

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

                        var cRec = Program.portugal[0].casosRecuperados;
                        var cMor = Program.portugal[0].mortalidade;
                        if (cRec > cMor)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('2', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('2', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMor > cRec)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('2', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('2', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        var cRecGe = Program.paisesDados[0].casosRecuperados;
                        var cMortGe = Program.paisesDados[0].mortalidade;
                        if (cRecGe > cMortGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMortGe > cRecGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }


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

                        var cRec = Program.italia[0].casosRecuperados;
                        var cMor = Program.italia[0].mortalidade;
                        if (cRec > cMor)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('3', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('3', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMor > cRec)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('3', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('3', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        var cRecGe = Program.paisesDados[0].casosRecuperados;
                        var cMortGe = Program.paisesDados[0].mortalidade;
                        if (cRecGe > cMortGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMortGe > cRecGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }


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

                        var cRec = Program.china[0].casosRecuperados;
                        var cMor = Program.china[0].mortalidade;
                        if (cRec > cMor)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('4', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('4', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMor > cRec)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('4', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('4', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        var cRecGe = Program.paisesDados[0].casosRecuperados;
                        var cMortGe = Program.paisesDados[0].mortalidade;
                        if (cRecGe > cMortGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMortGe > cRecGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }


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

                        var cRec = Program.EUA[0].casosRecuperados;
                        var cMor = Program.EUA[0].mortalidade;
                        if (cRec > cMor)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('5', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('5', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMor > cRec)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('5', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('5', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        var cRecGe = Program.paisesDados[0].casosRecuperados;
                        var cMortGe = Program.paisesDados[0].mortalidade;
                        if (cRecGe > cMortGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMortGe > cRecGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }


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

                        var cRec = Program.espanha[0].casosRecuperados;
                        var cMor = Program.espanha[0].mortalidade;
                        if (cRec > cMor)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('6', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('6', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMor > cRec)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('6', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('6', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }

                        Console.Clear();
                        Tela.imprimirGraficoInicio(grafico);
                        InputSimulator sim = new InputSimulator();
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                        var cRecGe = Program.paisesDados[0].casosRecuperados;
                        var cMortGe = Program.paisesDados[0].mortalidade;
                        if (cRecGe > cMortGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 3);
                            Grafico gDestino = dest.toGrafico();

                            grafico.melhoriaVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }
                        else if (cMortGe > cRecGe)
                        {
                            PosicaoIndGraf orig = new PosicaoIndGraf('1', 2);
                            Grafico gOrig = orig.toGrafico();
                            PosicaoIndGraf dest = new PosicaoIndGraf('1', 1);
                            Grafico gDestino = dest.toGrafico();

                            grafico.piorVirus(gOrig, gDestino);
                            Console.ReadLine();
                            Tela.imprimirGraficoInicio(grafico);
                        }


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