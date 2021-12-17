﻿global using WindowsFormsApp1.Properties;
using Thot_Librery.Menu;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            fecha.Start();
        }
        public int id;
        public string name_business;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Task(() => MessageBox.Show(Settings.Default.Idusuario.ToString(), Settings.Default.Namesbusiness.ToString())).Start();
        }

        private void BtFactura_Click(object sender, EventArgs e)
        {
            Facturar form = new Facturar
            {
                id_empleado = id
            };
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            new Task(() => L_Fecha.Text = DateTime.Now.ToString()).Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entrada form = new()
            {
                id_empleado = id
            };
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menus().Limpiar(splitContainer1.Panel2);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Settings.Default.Idusuario = id;
            Settings.Default.Namesbusiness = name_business;
            Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controdegastos form = new controdegastos();
            //form.id_empleado = id;
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ctlservicios form = new ctlservicios();
            //form.id_empleado = id;
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }
    }
}
