using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    class Libros
    {
        private string Nombre;
        private string Autor;
        private string Clave;
        private string Ubicacion;
        private string Descripcion;
        private int Id;


        SqlConnection cn = new SqlConnection("Data Source=LAPORI\\SQLEXPRESS;Initial Catalog=BD_Biblioteca;Integrated Security=True");

        public Libros(int id, string nombre, string autor, string clave, string ubicacion, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Clave = clave;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
            
        }
        public Libros()
        {

        }
        public Libros(int id)
        {
            this.Id = id;
        }
        public int AgregarLibro()
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("Insert INTO tb_libros VALUES (@nombre, @autor, @clave, @ubicacion, @descripcion)", cn);
            consulta.Parameters.AddWithValue("nombre", Nombre);
            consulta.Parameters.AddWithValue("autor", Autor);
            consulta.Parameters.AddWithValue("clave", Clave);
            consulta.Parameters.AddWithValue("ubicacion", Ubicacion);
            consulta.Parameters.AddWithValue("descripcion", Descripcion);

            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();

            return filasAfectadas;
        }
        public void CargarLibros(DataGridView dtg)
        {
            string consulta = "SELECT * From tb_libros";
            cn.Open();
            SqlDataAdapter data = new SqlDataAdapter(consulta, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dtg.DataSource = dt;
        }

        public int EliminarContacto()
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("DELETE FROM tb_libros WHERE ID = @id", cn);
            consulta.Parameters.AddWithValue("id", Id);
            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();

            return filasAfectadas;
        }
        public int EditarLibros()
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("UPDATE tb_libros SET Nombre = @nombre, Autor = @autor, Clave = @clave, Ubicacion = @ubicacion, Descripcion = @descripcion WHERE ID = id", cn);
            consulta.Parameters.AddWithValue("id", Id);
            consulta.Parameters.AddWithValue("nombre", Nombre);
            consulta.Parameters.AddWithValue("autor", Autor);
            consulta.Parameters.AddWithValue("clave", Clave);
            consulta.Parameters.AddWithValue("ubicacion", Ubicacion);
            consulta.Parameters.AddWithValue("descripcion", Descripcion);

            int filasAfectadas = consulta.ExecuteNonQuery();
            cn.Close();

            return filasAfectadas;
        }
    }
}
