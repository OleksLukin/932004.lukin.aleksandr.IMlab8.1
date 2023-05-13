using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rn = new Random();
		
        
        public void Ans(double p)
        {
            double a = (double)rn.NextDouble();   
            if (a > p) l_ans.Text = "Да";
            else l_ans.Text = "Нет";
            
            if (textBox1.Text == "")
            {
                l_ans.Text = "Вы не ввели вопрос :(";
            }
		}

        private void b_yesno_Click(object sender, EventArgs e)
        {
            Ans(0.6);
        }

	}
}
