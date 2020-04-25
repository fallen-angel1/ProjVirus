using grafico;
using ProjVirus.pais;
using System;
using WindowsInput.Native;
using WindowsInput;
using System.Text.RegularExpressions;
using System.Linq;

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

        public static void escolhaPortugal(GraficoMov grafico)
        {
            Console.Write("Dados atualmente: ");
            for (int i = 0; i < Program.portugal.Count; i++)
            {
                Console.WriteLine(Program.italia[i]);
            }
            bool possivel = false;

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

                            var NumerAntes = Program.portugal[0].idadeMedia;
                            int idadNumeroAt = (NumerAntes + idaNum) / 2;
                            Program.portugal[0].idadeMedia = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = Program.portugal[0].mortalidade;
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        int CasosMorAct = CasosAntesMo + mortNum;
                                        Program.portugal[0].mortalidade = CasosMorAct;
                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosReAn = Program.portugal[0].casosRecuperados;
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    int casosRecAt = casosNovoRec + CasosReAn;
                                                    Program.portugal[0].casosRecuperados = casosRecAt;
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
                                    var CasosReAn = Program.portugal[0].casosRecuperados;
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            int casosRecAt = casosNovoRec + CasosReAn;
                                            Program.portugal[0].casosRecuperados = casosRecAt;
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
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
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
            bool possivel = false;

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

                            var NumerAntes = Program.italia[0].idadeMedia;
                            int idadNumeroAt = (NumerAntes + idaNum) / 2;
                            Program.italia[0].idadeMedia = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = Program.italia[0].mortalidade;
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        int CasosMorAct = CasosAntesMo + mortNum;
                                        Program.italia[0].mortalidade = CasosMorAct;
                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosReAn = Program.italia[0].casosRecuperados;
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    int casosRecAt = casosNovoRec + CasosReAn;
                                                    Program.italia[0].casosRecuperados = casosRecAt;
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
                                    var CasosReAn = Program.italia[0].casosRecuperados;
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            int casosRecAt = casosNovoRec + CasosReAn;
                                            Program.italia[0].casosRecuperados = casosRecAt;
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
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
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
            bool possivel = false;

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

                            var NumerAntes = Program.EUA[0].idadeMedia;
                            int idadNumeroAt = (NumerAntes + idaNum) / 2;
                            Program.EUA[0].idadeMedia = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = Program.EUA[0].mortalidade;
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        int CasosMorAct = CasosAntesMo + mortNum;
                                        Program.EUA[0].mortalidade = CasosMorAct;
                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosReAn = Program.EUA[0].casosRecuperados;
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    int casosRecAt = casosNovoRec + CasosReAn;
                                                    Program.EUA[0].casosRecuperados = casosRecAt;
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
                                    var CasosReAn = Program.EUA[0].casosRecuperados;
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            int casosRecAt = casosNovoRec + CasosReAn;
                                            Program.EUA[0].casosRecuperados = casosRecAt;
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
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
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
            bool possivel = false;

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

                            var NumerAntes = Program.china[0].idadeMedia;
                            int idadNumeroAt = (NumerAntes + idaNum) / 2;
                            Program.china[0].idadeMedia = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = Program.china[0].mortalidade;
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        int CasosMorAct = CasosAntesMo + mortNum;
                                        Program.china[0].mortalidade = CasosMorAct;
                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosReAn = Program.china[0].casosRecuperados;
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    int casosRecAt = casosNovoRec + CasosReAn;
                                                    Program.china[0].casosRecuperados = casosRecAt;
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
                                    var CasosReAn = Program.china[0].casosRecuperados;
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            int casosRecAt = casosNovoRec + CasosReAn;
                                            Program.china[0].casosRecuperados = casosRecAt;
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
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
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
            bool possivel = false;

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

                            var NumerAntes = Program.espanha[0].idadeMedia;
                            int idadNumeroAt = (NumerAntes + idaNum) / 2;
                            Program.espanha[0].idadeMedia = idadNumeroAt;

                            Console.Write("Houve mais falecimentos devido ao pandemia? s/n ");
                            char resposta = char.Parse(Console.ReadLine());
                            if (resposta == 's')
                            {
                                var CasosAntesMo = Program.espanha[0].mortalidade;
                                Console.Write("Quantas casos há? ");
                                int mortNum;

                                bool naoNuMor = false;
                                while (!naoNuMor)
                                {
                                    if (int.TryParse(Console.ReadLine(), out mortNum))
                                    {
                                        int CasosMorAct = CasosAntesMo + mortNum;
                                        Program.espanha[0].mortalidade = CasosMorAct;
                                        naoNuMor = true;

                                        Console.Write("Houve recuperados, no dia anterior? s/n ");
                                        char respostRec = char.Parse(Console.ReadLine());

                                        if (respostRec == 's')
                                        {
                                            var CasosReAn = Program.espanha[0].casosRecuperados;
                                            Console.Write("Qual a quantidade de casos recuperados? ");
                                            bool nNumCre = false;
                                            int casosNovoRec;
                                            while (!nNumCre)
                                            {
                                                if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                                {
                                                    int casosRecAt = casosNovoRec + CasosReAn;
                                                    Program.espanha[0].casosRecuperados = casosRecAt;
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
                                    var CasosReAn = Program.espanha[0].casosRecuperados;
                                    Console.Write("Qual a quantidade de casos recuperados? ");
                                    bool nNumCre = false;
                                    int casosNovoRec;
                                    while (!nNumCre)
                                    {
                                        if (int.TryParse(Console.ReadLine(), out casosNovoRec))
                                        {
                                            int casosRecAt = casosNovoRec + CasosReAn;
                                            Program.espanha[0].casosRecuperados = casosRecAt;
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
                }
                else
                {
                    Console.Write("Invalido não premiu um numero!\nQual é a idade media dos falecidos?");
                }
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