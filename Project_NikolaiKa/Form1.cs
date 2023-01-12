using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_NikolaiKa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal result = calculate(age_obj.Value, smoke_choose.Checked, gender_obj.Checked);
            MessageBox.Show("You will live for another "+result+" years");
        }

        private decimal calculate(decimal age, bool smoke, bool gender)
        {
            int averageLifeExpectancy = 0;
            if (gender)
            {
                averageLifeExpectancy = 76;
            }
            else
            {
                averageLifeExpectancy = 82;
            }

            if (smoke)
            {
                if (gender)
                {
                    averageLifeExpectancy -= 12;
                }
                else
                {
                    averageLifeExpectancy -= 11;
                }
            }

            decimal yearsLeft = averageLifeExpectancy - age;
            return yearsLeft;
        }
    }
}
