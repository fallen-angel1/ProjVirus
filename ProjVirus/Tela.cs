using grafico;
using ProjVirus.pais;
using System;
using WindowsInput.Native;
using WindowsInput;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace ProjVirus
{
    class Tela
    {
        public static void imprimirGraficoInicio(GraficoMov grafico)
        {
            imprimirGrafico(grafico.alt);
            Console.WriteLine();
        }

        public static void imprimirGrafico(Alteracoes alt)
        {
            Console.WriteLine();
            Console.WriteLine("                 Covid 19 (Diario)");

            string[] linhTex = new string[3];

            linhTex[0] = "Melhoria  ";
            linhTex[1] = "Sem Dados ";
            linhTex[2] = "Pior      ";

            for (int i = 0; i < alt.linhas; i++)
            {
                Console.WriteLine();
                Console.Write(linhTex[i]);
                for (int j = 0; j < alt.colunas; j++)
                {
                    imprimirIndicador(alt.pais(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("          1  2  3  4  5  6");

            string[] colTex = new string[6];

            colTex[0] = "1-Dados gerais nos 5 paises";
            colTex[1] = "2-Portugal";
            colTex[2] = "3-Italia";
            colTex[3] = "4-China";
            colTex[4] = "5-EUA";
            colTex[5] = "6-Espanha";

            int col = 6;
            for (int g = 0; g < col; g++)
            {
                Console.WriteLine();
                Console.Write(colTex[g]);
            }

            Console.WriteLine();
            Console.WriteLine("Escolha uma das opçoes");

            Console.WriteLine();
            Console.Write("Digite uma opção: ");
        }

        public static void imprimirIndicador(Pais indicador)
        {
            if (indicador == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (indicador.cor == Cor.Branco)
                {
                    Console.Write(indicador);
                }
                else if (indicador.cor == Cor.Vermelho)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(indicador);
                    Console.ForegroundColor = aux;
                }
                else if (indicador.cor == Cor.Verde)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(indicador);
                    Console.ForegroundColor = aux;
                }
                else if (indicador.cor == Cor.Azul)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(indicador);
                    Console.ForegroundColor = aux;
                }
                else if (indicador.cor == Cor.Amarelo)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(indicador);
                    Console.ForegroundColor = aux;
                }
                else if (indicador.cor == Cor.Laranja)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(indicador);
                    Console.ForegroundColor = aux;
                }
            }
            Console.Write(" ");
        }

        public static void DadosGerais(GraficoMov grafico)
        {
            Console.WriteLine("     Lista atualmente:");
            for (int i = 0; i < Program.paisesDados.Count; i++)
            {
                Console.WriteLine(Program.paisesDados[i]);
            }
            if (Program.portugal != null)
            {
                for (int i = 0; i < Program.portugal.Count; i++)
                {
                    Console.WriteLine(Program.portugal[i]);
                }

            }
            if (Program.italia != null)
            {
                for (int i = 0; i < Program.italia.Count; i++)
                {
                    Console.WriteLine(Program.italia[i]);
                }
            }
            if (Program.EUA != null)
            {
                for (int i = 0; i < Program.EUA.Count; i++)
                {
                    Console.WriteLine(Program.EUA[i]);
                }
            }
            if (Program.china != null)
            {
                for (int i = 0; i < Program.china.Count; i++)
                {
                    Console.WriteLine(Program.china[i]);
                }
            }
            if (Program.espanha != null)
            {
                for (int i = 0; i < Program.espanha.Count; i++)
                {
                    Console.WriteLine(Program.espanha[i]);
                }
            }

            Console.Write("Voltar ao ecra inicial? s/n  ");
            char afir = char.Parse(Console.ReadLine());


            if (afir == 's')
            {
                Tela.imprimirGraficoInicio(grafico);
            }
            else
            {
                Console.WriteLine("Fim do Programa!");
            }
        }

        public static int PaisEscolhidoCasosRecuperados(string PaisEscolhidoCasosRec, int escolherPosicaoAlterar)
        {
            int paisAlterarPortugal = Program.portugal[escolherPosicaoAlterar].casosRecuperados;
            int paisAlterarItalia = Program.italia[escolherPosicaoAlterar].casosRecuperados;
            int paisAlterarChina = Program.china[escolherPosicaoAlterar].casosRecuperados;
            int paisAlterarEspanha = Program.espanha[escolherPosicaoAlterar].casosRecuperados;
            int paisAlterarEua = Program.EUA[escolherPosicaoAlterar].casosRecuperados;

            switch (PaisEscolhidoCasosRec)
            {
                case "Portugal casosRecuperados":
                    return paisAlterarPortugal;
                case "Italia casosRecuperados":
                    return paisAlterarItalia;
                case "China casosRecuperados":
                    return paisAlterarChina;
                case "Espanha casosRecuperados":
                    return paisAlterarEspanha;
                case "Eua casosRecuperados":
                    return paisAlterarEua;
            }
            return 0;
        }

        public static int PaisEscolhidoIdadeMedia(string PaisEscolhidoIdadeMedia, int escolherPosicaoAlterar)
        {
            int paisAlterarPortugal = Program.portugal[escolherPosicaoAlterar].idadeMedia;
            int paisAlterarItalia = Program.italia[escolherPosicaoAlterar].idadeMedia;
            int paisAlterarChina = Program.china[escolherPosicaoAlterar].idadeMedia;
            int paisAlterarEspanha = Program.espanha[escolherPosicaoAlterar].idadeMedia;
            int paisAlterarEua = Program.EUA[escolherPosicaoAlterar].idadeMedia;

            switch (PaisEscolhidoIdadeMedia)
            {
                case "Portugal idadeMedia":
                    return paisAlterarPortugal;
                case "Italia idadeMedia":
                    return paisAlterarItalia;
                case "China idadeMedia":
                    return paisAlterarChina;
                case "Espanha idadeMedia":
                    return paisAlterarEspanha;
                case "Eua idadeMedia":
                    return paisAlterarEua;
            }
            return 0;
        }

        public static int PaisEscolhidoMortalidade(string PaisEscolhidoMortalidade, int escolherPosicaoAlterar)
        {
            int paisAlterarPortugal = Program.portugal[escolherPosicaoAlterar].mortalidade;
            int paisAlterarItalia = Program.italia[escolherPosicaoAlterar].mortalidade;
            int paisAlterarChina = Program.china[escolherPosicaoAlterar].mortalidade;
            int paisAlterarEspanha = Program.espanha[escolherPosicaoAlterar].mortalidade;
            int paisAlterarEua = Program.EUA[escolherPosicaoAlterar].mortalidade;

            switch (PaisEscolhidoMortalidade)
            {
                case "Portugal Falecidos":
                    return paisAlterarPortugal;
                case "Italia Falecidos":
                    return paisAlterarItalia;
                case "China Falecidos":
                    return paisAlterarChina;
                case "Espanha Falecidos":
                    return paisAlterarEspanha;
                case "Eua Falecidos":
                    return paisAlterarEua;
            }
            return 0;
        }

        public static void escolherPais(string PaisEscolhidoIdade, string PaisEscolhidoMort, string PaisEscolhidoCasosRec, string paisValoresLista, int escolherPosicaodaLista)
        {
            bool possivel = false;

            int idadNumeroAt = 0;
            int CasosMorAct = 0;
            int casosRecAt = 0;

            Console.Write("Qual a idade media dos falecidos? ");
            int idaNum;
            bool naoENum = false;
            while (!naoENum)
            {
                if (int.TryParse(Console.ReadLine(), out idaNum))
                {
                    while (!possivel)
                    {
                        if (idaNum > 0 && idaNum < 120)
                        {
                            var NumerAntes = PaisEscolhidoIdadeMedia(PaisEscolhidoIdade, escolherPosicaodaLista);
                            idadNumeroAt = (NumerAntes + idaNum) / 2;
                            var NumeroAgora = PaisEscolhidoIdadeMedia(PaisEscolhidoIdade, escolherPosicaodaLista);
                            NumeroAgora = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = PaisEscolhidoMortalidade(PaisEscolhidoMort, escolherPosicaodaLista);
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        CasosMorAct = CasosAntesMo + mortNum;
                                        var CasosMorAtualmente = PaisEscolhidoMortalidade(PaisEscolhidoMort, escolherPosicaodaLista);
                                        CasosMorAtualmente = CasosMorAct;

                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosRecAntes = PaisEscolhidoCasosRecuperados(PaisEscolhidoCasosRec, escolherPosicaodaLista);
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    casosRecAt = casosNovoRec + CasosRecAntes;
                                                    var casosRecuperadosAgora = PaisEscolhidoCasosRecuperados(PaisEscolhidoCasosRec, escolherPosicaodaLista);
                                                    casosRecuperadosAgora = casosRecAt;
                                                    nNumCre = true;
                                                }
                                                else
                                                {
                                                    Console.Write("Invalido, insira outra vez. Qual a quantidade de casos recuperados? ");
                                                }
                                            }
                                        }
                                        possivel = true;
                                    }
                                    else
                                    {
                                        Console.Write("Invalido, insira outra vez. Quantas casos há? ");
                                    }
                                }
                            }
                            else
                            {
                                Console.Write("Houve recuperados, no dia anterior? s/n ");
                                char respostRec = char.Parse(Console.ReadLine());

                                if (respostRec == 's')
                                {
                                    var CasosReAn = PaisEscolhidoCasosRecuperados(PaisEscolhidoCasosRec, escolherPosicaodaLista);
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            casosRecAt = casosNovoRec + CasosReAn;

                                            var CasosRecuperadosAgora = PaisEscolhidoCasosRecuperados(PaisEscolhidoCasosRec, escolherPosicaodaLista);
                                            CasosRecuperadosAgora = casosRecAt;
                                            nNumCre = true;
                                        }
                                        else
                                        {
                                            Console.Write("Invalido, insira outra vez. Qual a quantidade de casos recuperados? ");
                                        }
                                    }

                                }
                                possivel = true;

                            }
                        }
                        else
                        {
                            Console.Write("Invalido, insira outra vez. Qual é a idade media dos falecidos? ");
                            idaNum = int.Parse(Console.ReadLine());
                        }
                    }
                    naoENum = true;

                    switch (paisValoresLista)
                    {
                        case "Portugal":
                            Program.portugalValores.Add(new Tuple<int, int, int>(idadNumeroAt, CasosMorAct, casosRecAt));
                            break;
                        case "Espanha":
                            Program.espanhaValores.Add(new Tuple<int, int, int>(idadNumeroAt, CasosMorAct, casosRecAt));
                            break;
                        case "China":
                            Program.chinaValores.Add(new Tuple<int, int, int>(idadNumeroAt, CasosMorAct, casosRecAt));
                            break;
                        case "Eua":
                            Program.euaValores.Add(new Tuple<int, int, int>(idadNumeroAt, CasosMorAct, casosRecAt));
                            break;
                        case "Italia":
                            Program.italiaValores.Add(new Tuple<int, int, int>(idadNumeroAt, CasosMorAct, casosRecAt));
                            break;
                    }
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
            }
        }

        public static void escolhaPortugal(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.portugal.Count; i++)
            {
                Console.WriteLine(Program.portugal[i]);
            }

            escolherPais("Portugal idadeMedia", "Portugal Falecidos", "Portugal casosRecuperados", "Portugal", 0);

            var valorIdadeAtual = Program.portugalValores[0].Item1;
            Program.portugal[0].idadeMedia = valorIdadeAtual;

            var valorMortalidade = Program.portugalValores[0].Item2;
            if (valorMortalidade != 0)
            {
                Program.portugal[0].mortalidade = valorMortalidade;
            }

            var valorCasosRec = Program.portugalValores[0].Item3;
            if (valorCasosRec != 0)
            {
                Program.portugal[0].casosRecuperados = valorCasosRec;
            }

            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.portugal.Count; i++)
            {
                Console.WriteLine(Program.portugal[i]);
            }
            //Teclado
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public static void escolhaItalia(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.italia.Count; i++)
            {
                Console.WriteLine(Program.italia[i]);
            }

            escolherPais("Italia idadeMedia", "Italia Falecidos", "Italia casosRecuperados", "Italia", 0);

            var valorIdadeAtual = Program.italiaValores[0].Item1;
            Program.italia[0].idadeMedia = valorIdadeAtual;

            var valorMortalidade = Program.italiaValores[0].Item2;
            if (valorMortalidade != 0)
            {
                Program.italia[0].mortalidade = valorMortalidade;
            }

            var valorCasosRec = Program.italiaValores[0].Item3;
            if (valorCasosRec != 0)
            {
                Program.italia[0].casosRecuperados = valorCasosRec;
            }

            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.italia.Count; i++)
            {
                Console.WriteLine(Program.italia[i]);
            }
            //Teclado
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public static void escolhaEua(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.EUA.Count; i++)
            {
                Console.WriteLine(Program.EUA[i]);
            }

            escolherPais("Eua idadeMedia", "Eua Falecidos", "Eua casosRecuperados", "Eua", 0);

            var valorIdadeAtual = Program.euaValores[0].Item1;
            Program.EUA[0].idadeMedia = valorIdadeAtual;

            var valorMortalidade = Program.euaValores[0].Item2;
            if (valorMortalidade != 0)
            {
                Program.EUA[0].mortalidade = valorMortalidade;
            }

            var valorCasosRec = Program.euaValores[0].Item3;
            if (valorCasosRec != 0)
            {
                Program.EUA[0].casosRecuperados = valorCasosRec;
            }

            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.EUA.Count; i++)
            {
                Console.WriteLine(Program.EUA[i]);
            }
            //Teclado
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public static void escolhaChina(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.china.Count; i++)
            {
                Console.WriteLine(Program.china[i]);
            }

            escolherPais("China idadeMedia", "China Falecidos", "China casosRecuperados", "China", 0);

            var valorIdadeAtual = Program.chinaValores[0].Item1;
            Program.china[0].idadeMedia = valorIdadeAtual;

            var valorMortalidade = Program.chinaValores[0].Item2;
            if (valorMortalidade != 0)
            {
                Program.china[0].mortalidade = valorMortalidade;
            }

            var valorCasosRec = Program.chinaValores[0].Item3;
            if (valorCasosRec != 0)
            {
                Program.china[0].casosRecuperados = valorCasosRec;
            }

            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.china.Count; i++)
            {
                Console.WriteLine(Program.china[i]);
            }
            //Teclado
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }

        public static void escolhaEspanha(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.espanha.Count; i++)
            {
                Console.WriteLine(Program.espanha[i]);
            }

            escolherPais("Espanha idadeMedia", "Espanha Falecidos", "Espanha casosRecuperados", "Espanha", 0);

            var valorIdadeAtual = Program.espanhaValores[0].Item1;
            Program.espanha[0].idadeMedia = valorIdadeAtual;

            var valorMortalidade = Program.espanhaValores[0].Item2;
            if (valorMortalidade != 0)
            {
                Program.espanha[0].mortalidade = valorMortalidade;
            }

            var valorCasosRec = Program.espanhaValores[0].Item3;
            if (valorCasosRec != 0)
            {
                Program.espanha[0].casosRecuperados = valorCasosRec;
            }

            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.espanha.Count; i++)
            {
                Console.WriteLine(Program.espanha[i]);
            }
            //Teclado
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
    }
}