using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class F_Productos : Form
    {

        ConexionBD con = new ConexionBD();
        public F_Productos()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            F_Home FH = new F_Home();
            if(MessageBox.Show("¿Está seguro que desea salir del apartado PRODUCTOS?", "Información del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                FH.MenuSidebar.Enabled = true;
            }
            FH.MenuSidebar.Enabled = true;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            F_Agregar_Producto FAP = new F_Agregar_Producto();
            Cursor.Current = Cursors.WaitCursor;
            FAP.ShowDialog();
        }

        private void F_Productos_Load(object sender, EventArgs e)
        {
            try
            {
                Dgv_Productos.DataSource = con.Mostrar_Productos();

                Dgv_Productos.Columns[0].Width = 80;
                Dgv_Productos.Columns[1].Width = 205;
                Dgv_Productos.Columns[2].Width = 205;
                Dgv_Productos.Columns[3].Width = 175;
                Dgv_Productos.Columns[4].Width = 173;
                Dgv_Productos.Columns[5].Width = 173;
            }
            catch
            {
                con.conexion.Close();
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            F_Agregar_Producto FAP = new F_Agregar_Producto();
            if (Dgv_Productos.SelectedRows.Count > 0)
            {
                FAP.Lb_Id.Text = Dgv_Productos.CurrentRow.Cells[0].Value.ToString();
                FAP.Tb_Producto.Text = Dgv_Productos.CurrentRow.Cells[1].Value.ToString();
                FAP.Tb_Descripcion.Text = Dgv_Productos.CurrentRow.Cells[2].Value.ToString();
                FAP.Tb_Codigo.Text = Dgv_Productos.CurrentRow.Cells[3].Value.ToString();
                FAP.Tb_Precio_Venta.Text = Dgv_Productos.CurrentRow.Cells[4].Value.ToString();

                FAP.ShowDialog();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar la pieza: " + Dgv_Productos.CurrentRow.Cells[0].Value.ToString() + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (con.Eliminar_Producto(Dgv_Productos.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        MessageBox.Show("¡La pieza se eliminó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dgv_Productos.DataSource = con.Mostrar_Productos();
                    }
                    else
                    {
                        MessageBox.Show("¡La pieza ya tiene movimientos!\n No es posible eliminarla", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡No hay elementos a eliminar!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Dgv_Productos.DataSource = con.Mostrar_Productos();
        }
    }
}
