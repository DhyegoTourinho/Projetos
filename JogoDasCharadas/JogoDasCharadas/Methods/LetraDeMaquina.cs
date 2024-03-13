using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasCharadas.Methods
{
    internal class LetraDeMaquina
    {
        public int VeloEscreva = 55;
        public int BigText = 275;
        public LetraDeMaquina() { }

        public async Task Aguarde(int tempo)
        {
            await Task.Delay(TimeSpan.FromSeconds(tempo));
        }

        public async Task Escreva(string frase)
        {
            foreach (char item in frase)
            {
                Console.Write(item);
                await Task.Delay(VeloEscreva);
            }
            Console.WriteLine();
        }
        public async Task EscrevaSemPularLinha(string frase)
        {
            foreach (char item in frase)
            {
                Console.Write(item);
                await Task.Delay(VeloEscreva);
            }
        }
        public async Task Bug()
        {
            string[] TextBug =
            {
            "ghjakslDUcYhJKlviUyGBnM,LDiSuyqGwneKlDxLsK HACKING asdjHcnMKuHGbnMkvsIUsHbnMLVOIdjFD",
            "asJkdLLLlllLLllaaaJJjjjFFfUuAAaaAksaKsaIS HELP ashGtYuIOL,CmNbgxYuIoLs,MdNbCyUiXOlss",
            "ajUUuuUuuuUuUUuUuUUuUuUUuUuUuUuUuUuUuUuASDAHDSBNMDKIA9U8YYAHahsbdnkjasuigmUUuUdAAAAa",
            "hGasUilV,mnBchUiL,dMfnVcxOÇ,MdHcuIcoXlS,MnDfvUiOcxL,MdNhFvUiCols,MdHfUiDolkHuSKmnBHa",
            "SiUsDyHaNMsKfoIVuHsDlçAoIsVuOihkLDjaSdHaKdslAYAsDkEsAkdjAGasDkO Ama vOcEajSdHaJsKdJa",
            "AgvBnM,cKjHnMsKdfAhNsMf,LAsJfNmA,k98uyhjklpd0c9aks----- aAaAaAaAaAaA----aAaAaAaA----S",
            "ghJaksldUcyHjklviUygBnm,LDiSuyqgwNekldXlsk HACKING asdJhCnMkuhGbnMkvsIushbnMLvOiDjFD",
            "asjkdLLLlllLLllaaaJJjjjFFfUuAAaaAksaKsaIS HELP ashGtYuIOL,CmNbgxYuIoLs,MdNbCyUiXOlss",
            "ajuuuuUuUuuuuuUuuuuuUuUUuUuuuuuuuuuuuUuuuuU    wwwwwww wasdsgsdfnalkçaskjkjbuUdAAAAa",
            "hGasUilV,mnBchUiL,dMfnVcxOÇ,MdHcuIcoXlS,MnDfvUiOcxL,MdNhFvUiCols,MdHfUiDolkHuSKmnBHa",
            "SiUsDyHaNMsKfoIVuHsDlçAoIsVuOihkLDjaSdHaKdslAYAsDkEsAkdjAGasDkO Ama vOcEajSdHaJsKdJa",
            "AgvBnM,cKjHnMsKdfAhNsMf,LAsJfNmA,s---kajsnmlxj------- aAaAaAaAaAaA----aAaAaAaA--  --S",
            "ghJaksldUcyHjklviUygBnm,LDiSuyqgwNekldXlsk HACKING asdJhCnMkuhGbnMkvsIushbnMLvOiDjFD",
            "asjkdLLLlllLLllaaaJJjjjFFfUuAAaaAksaKsaIS HELP ashGtYuIOL,CmNbgxYuIoLs,MdNbCyUiXOlss",
            "+== ============                        =V uOihkLDjaSdHaKdslAYuuuuuuuuUuuuuUuUdAAAAa",
            "hGasUilV,mnBchUiL,dMfnVcxOÇ,MdHcuIcoXlS,MnDfvUiOcxL,MdNhFvUiCols,MdHfUiDolkHuSKmnBHa",
            "SiUsDyHaNMsKfoIVuHsDlçAoIsVuOihkLDjaSdHaKdslAYAsDkEsAkdjAGasDkO Ama vOcEajSdHaJsKdJa",
            "dmfnvcxoç,mdhcuicoxls,mndfvuiocxl,=============mdhfuidoIsVuOihkLDjaSdH  olkhuskmnbha",
            "siusdyhanmskfoivuhsdlçaoisvuoihklDjasdHakdslaYasdkEsakdjaGasdkO Ama voceajsdhajskdja",
            "agvbnm,ckjhnmskdfahnsmf,lasjfnma,s------------------ aaaaaaaaaaaaa----aaaaaaaaa----s",
            "ghjakslducyhjklviuygbnm,ldisuyqgwnekldxlsk HACKING asdjhcnmkuhgbnmkvsiushbnmlvoidjfd",
            " =                                 =                            =xol =           =ss",
            " = aa        =                    asdasfv=             kmasldoa=  =                =",
            "hgasuilv,mnbchuil,dmfnvcxoç,mdhcuicoxls,mndfvuiocxl,mdnhfvuicols,mdhfuidolkhuskmnbha",
            "=    =             ==============                      = ==========          = skdja",
            "AgvBnM,cK =                                 =                              ===   -S ",
            "=              ====        =   =                                           =MLvOiDjD",
            "  =       =                                                       = iXOlss          ",
            "ajuuuu=                 =              ======               =             ====UdAAAa",
            "hGasUilV,mnBchUiL,dMfnVcxOÇ,Md =                   =      =         HfUiDolkHuSKnBHa",
            " =                       =                                  === =    =vOcEajSdJsKdJa",
            "AgvBnM,=            =           D           =                ==         = =-AaA----S",
            " =                               J      =                                    =       ",
            "           =                     =O                              =                  =",
            "           =                     = N                             =                  =",
            "           =                     =  G                      =                         ",
            "           = ==                   =  A                           =                  =",
            "       =                     =        =====     =            =                  =   ",
            "           =                      =             =               =                  =",            
                "           = ==                   =                             =                  =",
            "       =           k          =        =====     =            =                  =   ",
            "           =       e               =             =               =                  =",
            "           =       n              =   ==  =====                        =              ",
            "           =  ===  d                =          =                 =                   ",            
                "           = ==r                   =                             =                ",
            "       =           i          =        =====     =            =                  =   ",
            "           =       c               =             =               =                  =",
            "        =======    k              =           ==                 =                   ",
            "           ==== =                     =        =    =           =                   ",
            "        =                  =                   ======          =     =  =           ",
            "           =                     =                    Taylor        =           =   ",
            "           =                     =                    Swift                     =   ",
            "           =                     =                           ===                  = ",
            "   =                   =                                          =             =   "
            };

            foreach (string line in TextBug)
            {
                Console.Write(line);
                await Task.Delay(40);
            }


        }

        public async Task Hacker()
        {
            string[] hackerArt =
            {
            "==     ==        ===           ===    ==    ==   ==   ==      ==     =====     ",
            "==     ==      ==   ==       ==       ==   ==         ===     ==   ==     ==   ",
            "==     ==     ==     ==    ==         == ==      ==   ==  =   ==   ==          ",
            "=========     =========    ==         ===        ==   ==   =  ==   ==          ",
            "==     ==     ==     ==    ==         == ==      ==   ==    = ==   ==   ====   ",
            "==     ==     ==     ==      ==       ==   ==    ==   ==     ===    ==    ==   ",
            "==     ==     ==     ==        ===    ==    ==   ==   ==      ==      ====     "
        };

            foreach (string line in hackerArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

        public async Task Enigma()
        {
            string[] enigmaArt =
            {
                "   ======  ==      ==  ==     =====   ==        ==      ===       ",
                "   ==      ====    ==       ==    ==  ====    ====    ==   ==     ",
                "   ==      == ==   ==  ==  ==         == ==  == ==   ==     ==    ",
                "   ======  ==  ==  ==  ==  ==         ==   ==   ==  ==       ==   ",
                "   ==      ==   == ==  ==  ==   ====  ==        ==  ===========   ",
                "   ==      ==    ====  ==   ==    ==  ==        ==  ==       ==   ",
                "   ======  ==      ==  ==     ====    ==        ==  ==       ==   "
             };

            foreach (string line in enigmaArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

        public async Task Um()
        {
            string[] enigmaArt =
            {
                "                                 ===   ",
                "                               == ==   ",
                "                              ==  ==   ",
                "                                  ==   ",
                "                                  ==   ",
                "                                  ==   ",
                "                                ====== "
             };

            foreach (string line in enigmaArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

        public async Task Dois()
        {
            string[] enigmaArt =
            {
                "                               =====    ",
                "                             ==     ==  ",
                "                             ==    ==   ",
                "                                 ==     ",
                "                               ==       ",
                "                             ==         ",
                "                             ========  "
             };

            foreach (string line in enigmaArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

        public async Task Tres()
        {
            string[] enigmaArt =
            {
                "                               =====    ",
                "                             ==     ==  ",
                "                                   ==   ",
                "                                 ==     ",
                "                                   ==   ",
                "                             ==     ==  ",
                "                               =====    "
             };

            foreach (string line in enigmaArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

        public async Task Fail()
        {
            string[] failArt =
            {
            "          =====     ===    ==  ==    ",
            "          ==      ==   ==      ==    ",
            "          =====   =======  ==  ==    ",
            "          ==      ==   ==  ==  ==    ",
            "          ==      ==   ==  ==  ======"
        };

            foreach (string line in failArt)
            {
                Console.WriteLine(line);
                await Task.Delay(BigText);
            }
        }

    }
}

