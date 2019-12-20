using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PuntoDeVenta
{
    public partial class F_Clientes : Form
    {

        ConexionBD con = new ConexionBD();
        public F_Clientes()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del apartado CLIENTES?", "Información del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            F_Agregar_Cliente FAC = new F_Agregar_Cliente();
            Cursor.Current = Cursors.WaitCursor;
            FAC.ShowDialog();
        }

        private void F_Clientes_Load(object sender, EventArgs e)
        {
            Dgv_Clientes.DataSource = con.Mostrar_Clientes();

            Dgv_Clientes.Columns[0].Width = 80;
            Dgv_Clientes.Columns[1].Width = 205;
            Dgv_Clientes.Columns[2].Width = 205;
            Dgv_Clientes.Columns[3].Width = 175;
            Dgv_Clientes.Columns[4].Width = 173;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Dgv_Clientes.DataSource = con.Mostrar_Clientes();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            F_Agregar_Cliente FAC = new F_Agregar_Cliente();
            if (Dgv_Clientes.SelectedRows.Count > 0)
            {
                FAC.Lb_Id.Text = Dgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                FAC.Tb_Nombre.Text = Dgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                FAC.Tb_RFC.Text = Dgv_Clientes.CurrentRow.Cells[2].Value.ToString();
                FAC.Tb_Telefono.Text = Dgv_Clientes.CurrentRow.Cells[3].Value.ToString();
                FAC.Tb_Direccion.Text = Dgv_Clientes.CurrentRow.Cells[4].Value.ToString();

                FAC.ShowDialog();
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el cliente: " + Dgv_Clientes.CurrentRow.Cells[0].Value.ToString() + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (con.Eliminar_Cliente(Dgv_Clientes.CurrentRow.Cells[0].Value.ToString()) == true)
                    {
                        MessageBox.Show("¡El cliente se eliminó exitosamente!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dgv_Clientes.DataSource = con.Mostrar_Clientes();
                    }
                    else
                    {
                        MessageBox.Show("¡El cliente ya tiene movimientos registrados!\n No es posible eliminarla", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
