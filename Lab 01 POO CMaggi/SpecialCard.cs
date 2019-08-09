using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_POO_CMaggi
{
    class SpecialCard
    {
        private string name;
        private string type;
        private string buffType;
        private string effect;

        public SpecialCard(string N, string T, string B, string E)
        {
            string name = N;
            string type = T;
            string buffType = B;
            string effect = E;
        }
        public string Name { get => name; set => name = value; }
        public string BuffType { get => buffType; set => buffType = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }

    }

}
