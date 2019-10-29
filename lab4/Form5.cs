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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string[] toppings = { "1. bacon", "2. mushrooms", "3. onion", "4. sausage", "5. olives" };
            
            foreach(string top in toppings)
            {
                this.checkedListBox1.Items.Add(top);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = 0;
            int count = 0;
            List<string> toppings = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState st = checkedListBox1.GetItemCheckState(i);
                if (st == CheckState.Checked)
                {
                    count++;
                    money++;
                    string qq = String.Format("{0}", (int.Parse(checkedListBox1.GetItemText(i))+1));
                    toppings.Add(qq);
                }
            }

            int size = 0;
            if (radioButton1.Checked)
            {
                money += 9;
                size = 1;
            }

            if (radioButton2.Checked)
            {
                money += 12;
                size = 2;
            }

            if (radioButton3.Checked)
            {
                money += 15;
                size = 3;
            }

            if (checkBox1.Checked)
                money += 2;
            string strr = "";
            if (count > 0)
            {
                 strr = String.Format("You ordered a {0} crust {1} pizza {2} with {3} toppings\n(",
                    radioButton4.Checked == true ? "Thin" : "Thick",
                    size==1 ? "Small" : size == 2 ? "Medium" : "Large",
                    checkBox1.Checked ? "With Extra Cheese" : "Without Extra Cheese",
                    count);
                foreach(string top in toppings)
                {
                    strr = String.Format("{0}{1} ", strr, top);
                }
                strr = String.Format("{0})", strr);
            }
            else
            {
                strr = String.Format("You ordered a {0} crust {1} pizza {2} without toppings",
                       radioButton4.Checked == true ? "Thin" : "Thick",
                       size == 1 ? "Small" : size == 2 ? "Medium" : "Large",
                       checkBox1.Checked ? "With Extra Cheese" : "Without Extra Cheese");
            }
            strr = String.Format("{0}\nTotal Price is: {1}", strr, money);
            label3.Text = strr;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
