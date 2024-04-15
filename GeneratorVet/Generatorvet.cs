using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{

    class GeneratorVet
    {
        /// <summary>
        /// Slovní zásoba přívlastků
        /// </summary>
        private string[] privlastky = { "modrý", "velký", "hubený", "nejlepší", "automatizovaný" };

        /// <summary>
        /// Slovní zásoba předmětů
        /// </summary>
        private string[] podmety = { "jednorožec", "programátor", "manažer", "hroch", "T-rex" };

        /// <summary>
        /// Slovní zásoba příslovcí
        /// </summary>
        private string[] prislovce = { "rychle", "s oblibou", "hodně", "málo", "se zpožděním" };

        /// <summary>
        /// Slovní zásoba sloves
        /// </summary>
        private string[] slovesa = { "spal", "ležel", "vařil", "uklízel", "derivoval" };

        /// <summary>
        /// Slovní zásoba příslovečných určení místa
        /// </summary>
        private string[] mista = { "pod stolem", "v lese", "u babičky", "v práci", "na stole" };

        // Zde dokonči úlohu svým kódem...
        private Random random = new Random();
        private int index = 4;

        public string VygenerujVetu()
        {
            string veta = "";
            veta += $"{privlastky[random.Next(privlastky.Length)]} ";
            veta += $"{podmety[random.Next(podmety.Length)]} ";
            veta += $"{prislovce[random.Next(prislovce.Length)]} ";
            veta += $"{slovesa[random.Next(slovesa.Length)]} ";
            veta += $"{mista[random.Next(mista.Length)]}.";
            return veta;
        }
    }


}
