using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class Duck : Animal
    {
        //method
        public void Quack()
        {
            MessageBox.Show("Quack");
        }
        //constructers

        public Duck()
        {

        }

        public Duck(int height, string name)
        {
            Height = height;
            Name = name;
        }

    }
}
