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
    public partial class F_Proveedores : Form
    {

        ConexionBD con = new ConexionBD();

        public F_Proveedores()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del apartado PROVEEDORES?", "Información del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void F_Proveedores_Load(object sender, EventArgs e)
        {
            Dgv_Proveedores.DataSource = con.Mostrar_Proveedores();

            Dgv_Proveedores.Columns[0].Width = 80;
            Dgv_Proveedores.Columns[1].Width = 205;
            Dgv_Proveedores.Columns[2].Width = 205;
            Dgv_Proveedores.Columns[3].Width = 175;
            Dgv_Proveedores.Columns[4].Width = 173;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            F_Agregar_Proveedor FAP= new F_Agregar_Proveedor();
            Cursor.Current = Cursors.WaitCursor;
            FAP.ShowDialog();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Dgv_Proveedores.DataSource = con.Mostrar_Proveedores();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            F_Agregar_Proveedor FAP = new F_Agregar_Proveedor();
            if (Dgv_Proveedores.SelectedRows.Count > 0)
            {
                FAP.Lb_Id.Text = Dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
                FAP.Tb_Nombre.Text = Dgv_Proveedores.CurrentRow.Cells[1].Value.ToString();
                FAP.Tb_RFC.Text = Dgv_Proveedores.CurrentRow.Cells[2].Value.ToString();
                FAP.Tb_Telefono.Text = Dgv_Proveedores.CurrentRow.Cells[3].Value.ToString();
                FAP.Tb_Direccion.Text = Dgv_Proveedores.CurrentRow.Cells[4].Value.ToString();

                FAP.ShowDialog();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el proveedor: " + Dgv_Proveedores.CurrentRow.Cells[0].Value.ToString() + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (con.Eliminar_Proveedor(Dgv_Proveedores.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        MessageBox.Show("¡El proveedor se eliminó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dgv_Proveedores.DataSource = con.Mostrar_Proveedores();
                    }
                    else
                    {
                        MessageBox.Show("¡El proveedor ya tiene movimientos registrados!\n No es posible eliminarla", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡No hay elementos a eliminar!", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
