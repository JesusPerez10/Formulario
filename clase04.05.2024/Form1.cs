using clase04._05._2024.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase04._05._2024
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

        private void Form1_Activated(object sender, EventArgs e)
        {
            // MessageBox.Show("Bienvenido a mi App");
        }
        private int intentos=0;
        private void button1_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text.ToLower();
            string pwd = textBox2.Text.ToLower();
            if (usr == null || pwd == null)
            {
                MessageBox.Show("No puede dejar en blanco");
            }
            else
            {

            }
                if (usr.Equals("admin") && pwd.Equals("admin"))
                {
                    frmregistro reg = new frmregistro();
                reg.Show();
                }
            else
            {

            }
        }
    }
}
