using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clicouSomar(object sender, EventArgs e)
        {
            /*
            int num1;
            int num2;
            int result;
            num1 = int.Parse(n1.Text);
            num2 = int.Parse(n2.Text);
            result = num1 + num2;
            resultado.Text = result.ToString();
            */
            Soma s = new Soma();
            s.setN1(int.Parse(n1.Text));
            s.setN2(int.Parse(n2.Text));
            s.calcular();
            resultado.Text = s.getResultado().ToString();

        }
    }
}
