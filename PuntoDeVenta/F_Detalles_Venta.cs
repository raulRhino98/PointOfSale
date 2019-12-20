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
    public partial class F_Detalles_Venta : Form
    {

        ConexionBD con = new ConexionBD();

        public F_Detalles_Venta()
        {
            InitializeComponent();

            con.Mostrar_Producto(Cb_Producto);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se perderán los datos no guardados\n¿Está seguro que desea salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TopPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void Lb_Venta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Tb_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if(Cb_Producto.Text != "" && Tb_Cantidad.Text != "")
            {
                con.Insertar_Detalle_Venta(Lb_Id_Venta.Text, Cb_Producto.Text, Tb_Cantidad.Text);
                MessageBox.Show("¡Producto agregado exitosamente a la venta: " + Lb_Id_Venta.Text + "!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tb_Cantidad.Text = "";
                Cb_Producto.Focus();
                Dgv_Ventas.DataSource = con.Mostrar_Detalles_Venta(Lb_Id_Venta.Text);

                for (int fila = 0; fila < Dgv_Ventas.Rows.Count; fila++)
                {
                    totalVenta += Convert.ToInt32(Dgv_Ventas.Rows[fila].Cells[5].Value);
                }
                Total.Text = "Total:\n$ " + totalVenta.ToString() + " MXN";
            }
            else
            {
                MessageBox.Show("Revise que los campos no estén vacíos", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int totalVenta = 0;
        private void F_Detalles_Venta_Load(object sender, EventArgs e)
        {
            Dgv_Ventas.DataSource = con.Mostrar_Detalles_Venta(Lb_Id_Venta.Text);

            Dgv_Ventas.Columns[0].Width = 60;
            Dgv_Ventas.Columns[1].Width = 80;
            Dgv_Ventas.Columns[2].Width = 150;
            Dgv_Ventas.Columns[3].Width = 90;
            Dgv_Ventas.Columns[4].Width = 85;
            Dgv_Ventas.Columns[5].Width = 90;
            Dgv_Ventas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dgv_Ventas.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            totalVenta = 0;
            for (int fila = 0; fila < Dgv_Ventas.Rows.Count; fila++)
            {
                totalVenta += Convert.ToInt32(Dgv_Ventas.Rows[fila].Cells[5].Value);
            }
            Total.Text = "Total:\n$ " + totalVenta.ToString() + " MXN";
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la venta del producto: " + Dgv_Ventas.CurrentRow.Cells[1].Value.ToString() + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                con.Eliminar_Detalle_Venta(Dgv_Ventas.CurrentRow.Cells[0].Value.ToString(), Dgv_Ventas.CurrentRow.Cells[1].Value.ToString(), Dgv_Ventas.CurrentRow.Cells[4].Value.ToString());
                MessageBox.Show("¡La venta se eliminó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dgv_Ventas.DataSource = con.Mostrar_Detalles_Venta(Lb_Id_Venta.Text);

                totalVenta = 0;
                for (int fila = 0; fila < Dgv_Ventas.Rows.Count; fila++)
                {
                    totalVenta += Convert.ToInt32(Dgv_Ventas.Rows[fila].Cells[5].Value);
                }
                Total.Text = "Total:\n$ " + totalVenta.ToString() + " MXN";
            }
        }
    }
}
