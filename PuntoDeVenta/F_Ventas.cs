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
    public partial class F_Ventas : Form
    {

        ConexionBD con = new ConexionBD();
        public F_Ventas()
        {
            InitializeComponent();

            Dgv_Ventas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con.Mostrar_Cliente(Cb_Cliente);
            con.Mostrar_Empleado(Cb_Empleado);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del apartado VENTAS?", "Información del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Agregar_Venta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + con.Insertar_Venta(Cb_Cliente.Text, DateTime.Now.ToString("yyyyMMdd"), "Abierto", Cb_Empleado.Text));
            MessageBox.Show("Se creo una nueva venta", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dgv_Ventas.DataSource = con.Mostrar_Ventas();
        }

        private void F_Ventas_Load(object sender, EventArgs e)
        {
            Dgv_Ventas.DataSource = con.Mostrar_Ventas();

            Dgv_Ventas.Columns[0].Width = 80;
            Dgv_Ventas.Columns[1].Width = 205;
            Dgv_Ventas.Columns[2].Width = 205;
            Dgv_Ventas.Columns[3].Width = 175;
            Dgv_Ventas.Columns[4].Width = 173;
            Dgv_Ventas.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void Btn_Editar_Venta_Click(object sender, EventArgs e)
        {
            F_Detalles_Venta FDV = new F_Detalles_Venta();
            FDV.Lb_Venta.Text = FDV.Lb_Venta.Text + Dgv_Ventas.CurrentRow.Cells[0].Value.ToString();
            FDV.Lb_Id_Venta.Text = Dgv_Ventas.CurrentRow.Cells[0].Value.ToString();
            FDV.ShowDialog();
        }

        private void Btn_Eliminar_Venta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar la venta: " + Dgv_Ventas.CurrentRow.Cells[0].Value.ToString() + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                con.Eliminar_Detalle_Venta(Dgv_Ventas.CurrentRow.Cells[0].Value.ToString());
                con.Eliminar_Venta(Dgv_Ventas.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("¡La venta con el id: " + Dgv_Ventas.CurrentRow.Cells[0].Value.ToString() + " se eliminó con éxito!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dgv_Ventas.DataSource = con.Mostrar_Ventas();
            }
        }
    }
}
