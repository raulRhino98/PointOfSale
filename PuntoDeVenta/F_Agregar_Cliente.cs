using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class F_Agregar_Cliente : Form
    {

        ConexionBD con = new ConexionBD();
        public F_Agregar_Cliente()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se perderán los datos no guardados\n¿Está seguro que desea salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se perderán los datos no guardados\n¿Está seguro que desea salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Lb_Id.Text == "Id_Cliente")
            {
                if (Tb_Nombre.Text != "" && Tb_Telefono.Text != "" && Tb_Direccion.Text != "")
                {
                    if (con.Insertar_Cliente(Tb_Nombre.Text, Tb_RFC.Text, Tb_Telefono.Text, Tb_Direccion.Text) == true)
                    {
                        MessageBox.Show("¡El cliente se registró exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar_TextBox();
                    }
                    else
                    {
                        MessageBox.Show("¡El cliente ya está registrado!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tb_Nombre.Text = "";
                        Tb_Nombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor revise que los campos obligatorios se hayan ingresado", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                con.Actualizar_Cliente(Lb_Id.Text, Tb_Nombre.Text, Tb_RFC.Text, Tb_Telefono.Text, Tb_Direccion.Text);
                Limpiar_TextBox();
                MessageBox.Show("¡La información del cliente se actualizó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Limpiar_TextBox()
        {
            Tb_Nombre.Text = "";
            Tb_RFC.Text = "";
            Tb_Telefono.Text = "";
            Tb_Direccion.Text = "";
            Tb_Nombre.Focus();
        }
    }
}
