using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReservation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        List<Button> buttonSelect = new List<Button>();
        private void selectPlace(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (button17.BackColor== Color.Red && btn.BackColor == SystemColors.Control)
            {
                textBox4.Text = "Siz artiq secim ede bilmezsiniz";
            }
            else
            {
                if (btn.BackColor == Color.Red)
                {
                    textBox3.Text = "Bu yer doludur";
                }
                if (btn.BackColor == Color.Green)
                {
                    btn.BackColor = SystemColors.Control;
                }
                else if (btn.BackColor == SystemColors.Control)
                {
                    btn.BackColor = Color.Green;
                    buttonSelect.Add(btn);
                    textBox3.Text = "";
                }
            }       
        }
        int countMoney = 0;

        private void Confirm(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string result = null;
            for (int i = 0; i < buttonSelect.Count; i++)
            {
                if (buttonSelect[i].BackColor == Color.Green)
                {
                    buttonSelect[i].BackColor = Color.Red;
                    countMoney += 5;
                    result += buttonSelect[i].Text + ",";
                    btn.BackColor = Color.Red;
                }
            }
            
            textBox2.Text = result.Substring(0, result.Length-1) + " kreslolar tutulub" + "Sizin odeyeceyiniz mebleg " + countMoney.ToString() + " manatdir";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
