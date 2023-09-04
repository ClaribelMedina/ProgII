using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarpinteriaApp.Entidad;
using System.Security.Claims;

namespace CarpinteriaApp.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        Presupuesto nuevo= new Presupuesto();
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
        }

        private void FrmPresupuesto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
            ProximoPresupuesto();
            CargarProductos();
        }

        private void CargarProductos()
        {
            SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString = @"Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;Persist Security Info=True;User ID=alumno1w1; Password=alumno1w1";
            conexion.ConnectionString = @"Data Source=CLARI\SQLEXPRESS01;Initial Catalog=Carpinteria_2023;Integrated Security=True";
            conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;  //procedimiento almacenado 
            comando.CommandText = "SP_CONSULTAR_PRODUCTOS";
            DataTable tabla= new DataTable();
            tabla.Load(comando.ExecuteReader());
         
            
            conexion.Close();

            cboProducto.DataSource = tabla;
            cboProducto.ValueMember = tabla.Columns[0].ColumnName;
            cboProducto.DisplayMember = tabla.Columns[1].ColumnName;
            cboProducto.DropDownStyle= ComboBoxStyle.DropDownList;

        }

        private void ProximoPresupuesto()
        {
            SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString = @"Data Source=172.16.10.196;Initial Catalog=Carpinteria_2023;Persist Security Info=True;User ID=alumno1w1; Password=alumno1w1";
            conexion.ConnectionString = @"Data Source = CLARI\SQLEXPRESS01; Initial Catalog = Carpinteria_2023; Integrated Security = True";
            conexion.Open();

            SqlCommand comando= new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;  //procedimiento almacenado 
            comando.CommandText = "SP_PROXIMO_ID";
            SqlParameter parametro = new SqlParameter("@next", SqlDbType.Int);
            //parametro.ParameterName = "@next";
            //parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            conexion.Close();

            lblPresupuesto.Text = lblPresupuesto.Text + " " + parametro.Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto..", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad valida..", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["ColProducto"].Value.ToString().Equals(cboProducto.Text)) ;
            }

            DataRowView item= (DataRowView)cboProducto.SelectedItem;

            int nro =Convert.ToInt32(item.Row.ItemArray[0]);
            string  nom= item.Row.ItemArray[1].ToString();
            double precio = Convert.ToDouble(item.Row.ItemArray[2]);

            Productos p = new Productos(nro, nom, precio, true);

            int cant= Convert.ToInt32(txtCantidad.Text);
            DetallePresupuesto detalle = new DetallePresupuesto(p, cant) ;

            //nuevo.AgregarDetalle(detalle);
            //dgvDetalle.Rows.Add(new object[] {detalle.Producto.ProductoNro,
            //                                  detalle.Producto.Nombre,
            //                                  detalle.Producto.Precio,
            //                                  detalle.Cantidad});

            dgvDetalle.Rows.Add(new object[] {nro,nom,precio,cant, "Quitar"});
            nuevo.AgregarDetalle(detalle) ;
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            txtSubtotal.Text = nuevo.CalcularTotal().ToString();

         if (string.IsNullOrEmpty(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out _))   //si txtcantidad es nulo o si es una caracter que no sea numero
            {
            double desc = nuevo.CalcularTotal() * Convert.ToDouble(txtDescuento.Text) / 100;
            txtTotal.Text = (nuevo.CalcularTotal() - desc).ToString();

            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                nuevo.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
                CalcularTotales();
            }
        }
    }
}
