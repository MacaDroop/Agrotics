using Agrotics.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Agrotics
{
    public partial class ProductosCultivo : Form
    {
        public String ValorCelda { get; set; }
        public String ValorEnviado { get; set; }
        public ProductosCultivo()
        {
            InitializeComponent();
            
        }

        public void consulta2()
        {
            MySqlDataReader reader = null;

            //REVISAR LA CADENA DE CONSULTA Y LA CONCATENACION DE LA VARIABLE
            string sql = "SELECT * FROM productos WHERE Cultivos LIKE '%" + ValorEnviado.Replace("'", "''") + "%' AND Tipo = 'Pesticida'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvPesticidas.DataSource = datos;
            }

        }
        public void consulta3()
        {
            MySqlDataReader reader = null;

            //REVISAR LA CADENA DE CONSULTA Y LA CONCATENACION DE LA VARIABLE
            string sql = "SELECT * FROM productos WHERE Cultivos LIKE '%" + ValorEnviado.Replace("'", "''") + "%' AND Tipo = 'Fungicida'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvFungicidas.DataSource = datos;
            }
        }
        public void consulta4()
        {
            MySqlDataReader reader = null;

            //REVISAR LA CADENA DE CONSULTA Y LA CONCATENACION DE LA VARIABLE
            string sql = "SELECT * FROM productos WHERE Cultivos LIKE '%" + ValorEnviado.Replace("'", "''") + "%' AND Tipo = 'Insecticida'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvInsecticidas.DataSource = datos;
            }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ProductosCultivo_Load(object sender, EventArgs e)
        {
            label2.Text = ValorEnviado;


            MySqlDataReader reader = null;

            //REVISAR LA CADENA DE CONSULTA Y LA CONCATENACION DE LA VARIABLE
            string sql = "SELECT * FROM productos WHERE Tipo='Fertilizante' AND Cultivos LIKE '%" + ValorEnviado.Replace("'", "''") + "%'";
            MySqlConnection conexionBD = Conexion2.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable datos = new DataTable();

                datos.Load(reader);
                dgvFertilizantes.DataSource = datos;
            }

            consulta2();
            consulta3();
            consulta4();


        }

        private void dgvFertilizantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFertilizantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValorCelda = dgvFertilizantes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            
        }

        private void btnAddFert_Click(object sender, EventArgs e)
        {
            
            Ventas1 mensajero = new Ventas1();
            label1.Text = ValorCelda;
            mensajero.ValorCelda = this.ValorCelda;
            mensajero.Show(); 
        }

        private void btnPesticidas_Click(object sender, EventArgs e)
        {
            Ventas1 mensajero = new Ventas1();
            label1.Text = ValorCelda;
            mensajero.ValorCelda = this.ValorCelda;
            mensajero.Show();
        }

        private void dgvPesticidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValorCelda = dgvPesticidas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dgvFungicidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValorCelda = dgvFungicidas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void btnFungicidas_Click(object sender, EventArgs e)
        {
            Ventas1 mensajero = new Ventas1();
            label1.Text = ValorCelda;
            mensajero.ValorCelda = this.ValorCelda;
            mensajero.Show();
        }

        private void dgvInsecticidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInsecticidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ValorCelda = dgvInsecticidas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void btnInsecticidas_Click(object sender, EventArgs e)
        {
            Ventas1 mensajero = new Ventas1();
            label1.Text = ValorCelda;
            mensajero.ValorCelda = this.ValorCelda;
            mensajero.Show();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

         }
    }
}
