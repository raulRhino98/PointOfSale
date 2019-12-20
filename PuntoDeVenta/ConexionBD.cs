using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    class ConexionBD
    {
        public MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=posdb; Uid=root; Pwd=;");
        DataSet ds = new DataSet();

        public DataTable Mostrar_Productos()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT productoid as ID, producto as Producto, descripcion as Descripcion, codigo as Codigo, precioVenta as Precio, stock as Stock FROM productos ORDER BY ID;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public DataTable Mostrar_Clientes()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT clienteid as ID, nombre as Cliente, rfc as RFC, telefono as Telefono, direccion as Direccion FROM clientes ORDER BY ID;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public void Mostrar_Cliente(ComboBox cb_cliente)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM clientes ORDER BY nombre;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            cb_cliente.DisplayMember = "nombre";
            cb_cliente.ValueMember = "clienteid";
            cb_cliente.DataSource = dt;
        }

        public void Mostrar_Empleado(ComboBox cb_empleado)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT usuario FROM empleados ORDER BY usuario;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            cb_empleado.DisplayMember = "usuario";
            cb_empleado.ValueMember = "usuario";
            cb_empleado.DataSource = dt;
        }

        public void Mostrar_Producto(ComboBox cb_producto)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT producto FROM productos ORDER BY producto;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            cb_producto.DisplayMember = "producto";
            cb_producto.ValueMember = "producto";
            cb_producto.DataSource = dt;
        }

        public DataTable Mostrar_Proveedores()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT proveedorid as ID, nombre as Proveedor, rfc as RFC, telefono as Telefono, direccion as Direccion FROM proveedores ORDER BY ID;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public DataTable Mostrar_Cliente(string Nombre)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT clienteid FROM clientes WHERE nombre = '{0}';", new string[] { Nombre }), conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public DataTable Mostrar_Ventas()
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT ventaid as ID, clienteid as Cliente, date_format(fecha, \'%d-%m-%Y\') as Fecha, estado as Estado, empleadoid as Empleado FROM ventas WHERE estado = 'abierto' ORDER BY ID;", conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public DataTable Mostrar_Detalles_Venta(string IdPerro)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(String.Format("SELECT D.ventaid AS 'Id', D.productoid AS 'Id de producto', P.producto AS 'Producto', P.precioVenta AS 'Precio Unitario', D.cantidad AS 'Cantidad', (P.precioVenta * D.cantidad) AS 'Monto' FROM detalleventa AS D INNER JOIN productos AS P ON D.productoid = P.productoid WHERE ventaid = '{0}' ORDER BY D.ventaid;", new string[] { IdPerro }), conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();

            return ds.Tables["tabla"];
        }

        public bool Insertar_Empleado(string Nombre, string Paterno, string Materno, string Usuario, string Clave)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO empleados(nombre, apaterno, amaterno, usuario, clave) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", new string[] { Nombre, Paterno, Materno, Usuario, Clave }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Cliente(string Nombre, string RFC, string Tel, string Direccion)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO clientes(nombre, rfc, telefono, direccion) VALUES('{0}', '{1}', '{2}', '{3}');", new string[] { Nombre, RFC, Tel, Direccion }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Proveedor(string Nombre, string RFC, string Tel, string Direccion)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO proveedores(nombre, rfc, telefono, direccion) VALUES('{0}', '{1}', '{2}', '{3}');", new string[] { Nombre, RFC, Tel, Direccion }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Compra(string ProveedorId, string Fecha, string Estado)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO empleados(proveedorid, fecha, estado) VALUES('{0}', '{1}', '{2}');", new string[] { ProveedorId, Fecha, Estado }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Detalle_Compra(string ProductoId, string Cantidad, string PrecioCompra)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO detallecompra(productoid, cantidad, precioCompra) VALUES('{0}', '{1}', {2});", new string[] { ProductoId, Cantidad, PrecioCompra }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Detalle_Venta(string Venta, string ProductoId, string Cantidad)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO detalleventa(ventaid, productoid, cantidad) VALUES('{0}', (SELECT productoid FROM productos WHERE producto = '{1}'), '{2}');", new string[] { Venta, ProductoId, Cantidad }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Producto(string Producto, string Descripcion, string Codigo, string PrecioVenta, string Stock)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO productos(producto, descripcion, codigo, precioVenta, stock) VALUES('{0}', '{1}', '{2}', '{3}', {4});", new string[] { Producto, Descripcion, Codigo, PrecioVenta, Stock }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Proveedor(string ProveedorId, string Nombre, string RFC, string Tel, string Direccion)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO proveedores(proveedorid, nombre, rfc, telefono, direccion) VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", new string[] { ProveedorId, Nombre, RFC, Tel, Direccion }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Insertar_Venta(string Cliente, string Fecha, string Estado, string Empleado)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO ventas(clienteid, fecha, estado, empleadoid) VALUES((SELECT clienteid FROM clientes WHERE nombre = '{0}'), '{1}', '{2}', (SELECT empleadoid FROM empleados WHERE usuario = '{3}'));", new string[] { Cliente, Fecha, Estado, Empleado }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Actualizar_Producto(string Id, string Producto, string Descripcion, string Codigo, string PrecioVenta)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE productos SET producto = '{1}', descripcion = '{2}', codigo = '{3}', precioVenta = '{4}' WHERE productoid = '{0}';", new string[] { Id, Producto, Descripcion, Codigo, PrecioVenta }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar_Cliente(string Id, string Nombre, string RFC, string Tel, string Dir)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE clientes SET nombre = '{1}', rfc = '{2}', telefono = '{3}', direccion = '{4}' WHERE clienteid = '{0}';", new string[] { Id, Nombre, RFC, Tel, Dir }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar_Proveedor(string Id, string Nombre, string RFC, string Tel, string Dir)
        {
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE proveedores SET nombre = '{1}', rfc = '{2}', telefono = '{3}', direccion = '{4}' WHERE proveedorid = '{0}';", new string[] { Id, Nombre, RFC, Tel, Dir }), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Eliminar_Producto(string Id)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM productos WHERE productoid = '{0}'", new string[] { Id }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Eliminar_Venta(string Id)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM ventas WHERE ventaid = '{0}'", new string[] { Id }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Eliminar_Detalle_Venta(string Id)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM detalleventa WHERE ventaid = '{0}'", new string[] { Id }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Eliminar_Proveedor(string Id)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM proveedores WHERE proveedorid = '{0}'", new string[] { Id }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Eliminar_Detalle_Venta(string Id, string Producto, string Cantidad)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM detalleventa WHERE ventaid = '{0}' AND productoid = '{1}' AND cantidad = '{2}'", new string[] { Id, Producto, Cantidad }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public bool Eliminar_Cliente(string Id)
        {
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(string.Format("DELETE FROM clientes WHERE clienteid = '{0}'", new string[] { Id }), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }
    }
}
