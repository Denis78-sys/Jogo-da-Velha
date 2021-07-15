using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (textBox1_jog_01.Text != "" && textBox2_jog_02.Text != "")
            {
                
                Form2 form2 = new Form2(textBox1_jog_01.Text, textBox2_jog_02.Text);
                form2.ShowDialog();
                
                
                
            }
            else
            {
                MessageBox.Show("Voce precisa informar o nome dos dois Jogadores!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
