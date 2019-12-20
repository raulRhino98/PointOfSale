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
    public partial class F_Agregar_Producto : Form
    {

        ConexionBD con = new ConexionBD();

        public F_Agregar_Producto()
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Lb_Id.Text == "Id_Producto")
            {
                if (Tb_Producto.Text != "" && Tb_Codigo.Text != "" && Tb_Precio_Venta.Text != "")
                {
                    if (con.Insertar_Producto(Tb_Producto.Text, Tb_Descripcion.Text, Tb_Codigo.Text, Tb_Precio_Venta.Text, "0") == true)
                    {
                        MessageBox.Show("¡El producto se registró exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar_TextBox();
                    }
                    else
                    {
                        MessageBox.Show("¡El producto ya está registrado!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tb_Producto.Text = "";
                        Tb_Producto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor revise que los campos obligatorios se hayan ingresado", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                con.Actualizar_Producto(Lb_Id.Text, Tb_Producto.Text, Tb_Descripcion.Text, Tb_Codigo.Text, Tb_Precio_Venta.Text);
                Limpiar_TextBox();
                MessageBox.Show("¡La pieza se actualizó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Limpiar_TextBox()
        {
            Tb_Producto.Text = "";
            Tb_Descripcion.Text = "";
            Tb_Codigo.Text = "";
            Tb_Precio_Venta.Text = "";
            Tb_Producto.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se perderán los datos no guardados\n¿Está seguro que desea salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
