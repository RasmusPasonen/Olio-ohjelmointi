using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Seikkailijanreppu
{
    public class Reppu
    {
        private List <Tavara> listaTavaroita = new List <Tavara> ();
        private double paino;
        private double tilavuus;
        private int maara;
        public Reppu()
        {
            this.paino = 0;
            this.tilavuus = 0;
            this.maara = 0;
        }
        public bool lisaa(Tavara tavara)
        {
            if (maara == 10)
            {
                return false;

            }
            else if (paino + tavara.getPaino() > 30)
            {
                return false;
            }
            else if (tilavuus + tavara.getTilavuus() > 20)
            {
                return false;
            }
            else
            {
                listaTavaroita.Add(tavara);
                paino = paino+ tavara.getPaino();
                tilavuus = tilavuus+ tavara.getTilavuus();
                maara++;
                return true;

            }
            

        }
        public double getPaino()
        {
            return paino;
        }
        public double getTilavuus()
        {
            return tilavuus;
        }
        public int getMaara()
        {
            return maara;
        }
    }
    public class Tavara
    {
        public double paino;
        public double tilavuus;
        public Tavara(double paino, double tilavuus)
        {
            this.paino = paino;
            this.tilavuus = tilavuus;

        }
        public double getPaino()
        {
            return paino;
        }
        public double getTilavuus()
        {
            return tilavuus;
        }
    }

    public class Nuoli : Tavara
    {
        public Nuoli() 
            : base(0.1,0.05)
        {

        }
    }
    public class Jousi : Tavara
    {
        public Jousi()
            : base(1,4)
        {

        }
    }
    public class Koysi : Tavara
    {
        public Koysi()
            : base(1,1.5)
        {

        }
    }
    public class Vesi : Tavara
    {
        public Vesi()
            : base(2,2)
        {

        }
    }
    public class Ruokaannos : Tavara
    {
        public Ruokaannos()
            : base(1,0.5)
        {

        }
    }
    public class Miekka : Tavara
    {
        public Miekka()
            : base(5,3)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            Reppu kassi = new Reppu();
            for (; ; )
            {
                Console.WriteLine("Repussa on tällä hetkellä " + kassi.getMaara() + "/10 tavaraa, " + kassi.getPaino() + "/30 painoa, " + kassi.getTilavuus() + " /20  tilavuus.");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vettä");
                Console.WriteLine("5 - Ruokaa");
                Console.WriteLine("6 - Miekka");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    if (kassi.lisaa(new Nuoli()) == false)
                    {
                        break;
                    }
                }
                else if (input == "2")
                {
                    if (kassi.lisaa(new Jousi()) == false)
                    {
                        break;
                    }
                }
                else if (input == "3")
                {
                    if (kassi.lisaa(new Koysi()) == false)
                    {
                        break;
                    }
                }
                else if (input == "4")
                {
                    if (kassi.lisaa(new Vesi()) == false)
                    {
                        break;
                    }
                }
                else if (input == "5")
                {
                    if (kassi.lisaa(new Ruokaannos()) == false)
                    {
                        break;
                    }
                }
                else if (input == "6")
                {
                    if (kassi.lisaa(new Miekka()) == false)
                    {
                        break;
                    }
                }

            }

        }
        
    }
}