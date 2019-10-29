using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double angle = double.Parse(textBox1.Text);

                if (angle <= 360 && angle >= -360)
                {

                    double cos = Math.Cos(angle);
                    double sin = Math.Sin(angle);
                    double tg = Math.Tan(angle);

                    string text = String.Format("trigonometrichni funkcii...\nCos {0} = {1:0.000}\nSin {2} = {3:0.000}\nTg {4} = {5:0.000}",
                        angle, cos, angle, sin, angle, tg);

                    MessageBox.Show(text);
                }
            }
            catch (Exception)
            { }

            try
            {
                double radius = double.Parse(textBox2.Text);

                if (radius >= 1 && radius <= 10)
                {
                    double s = 3.14 * radius * radius;
                    double p = 2 * 3.14 * radius;

                    string text = String.Format("Okrujnost s radius {0}...\nS = {1:0.00}\nP = {2:0.00}",
                        radius, s, p);

                    MessageBox.Show(text);
                }
            }
            catch (Exception)
            { }
        }
    }
}
