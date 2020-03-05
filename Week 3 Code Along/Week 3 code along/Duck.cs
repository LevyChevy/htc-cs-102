using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Goose
    {
        public string Name;
        public int Age;
        public int AttackDamage;

        public void Honk()
        {
            MessageBox.Show("Honk, my name is " + Name + ". I am " + Age + " honks old.");
        }

        public void Aquack()
        {
            MessageBox.Show("I attack you for " + AttackDamage + " damage.");
        }
    }
}
