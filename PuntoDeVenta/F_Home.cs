using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class F_Home : Form
    {

        ConexionBD con = new ConexionBD();

        public F_Home()
        {
            InitializeComponent();
        }

        public void AbrirFormInPanel(object Formhijo)
        {
            if (this.Wrapper.Controls.Count > 0)
                this.Wrapper.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Wrapper.Controls.Add(fh);
            this.Wrapper.Tag = fh;
            fh.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?", "Información del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Btn_Maximizar.Visible = false;
            Btn_Restaurar.Visible = true;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("" + Directory.GetCurrentDirectory());
            Cursor.Current = Cursors.WaitCursor;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Btn_Maximizar.Visible = false;
            Btn_Restaurar.Visible = true;
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 68 && SidebarWrapper.Width == 90)
            {
                Cursor.Current = Cursors.WaitCursor;
                AbrirFormInPanel(new F_Productos());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                AbrirFormInPanel(new F_Productos());
            }
        }

        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 68 && SidebarWrapper.Width == 90)
            {
                Cursor.Current = Cursors.WaitCursor;
                AbrirFormInPanel(new F_Ventas());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                AbrirFormInPanel(new F_Ventas());
            }
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 68 && SidebarWrapper.Width == 90)
            {
                Cursor.Current = Cursors.WaitCursor;
                AbrirFormInPanel(new F_Compras());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                AbrirFormInPanel(new F_Compras());
            }
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 68 && SidebarWrapper.Width == 90)
            {
                Cursor.Current = Cursors.WaitCursor;
                AbrirFormInPanel(new F_Clientes());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                AbrirFormInPanel(new F_Clientes());
            }
        }

        private void Btn_Proveedores_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 68 && SidebarWrapper.Width == 90)
            {
                Cursor.Current = Cursors.WaitCursor;
                AbrirFormInPanel(new F_Proveedores());
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                AbrirFormInPanel(new F_Proveedores());
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=posdb; Uid=root; Pwd=;");

            try
            {
                //con.Insertar_Empleado();
            }
            catch(Exception)
            {
                MessageBox.Show("Valió madre ");
            }
        }
    }
}
