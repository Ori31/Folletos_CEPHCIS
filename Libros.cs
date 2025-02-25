using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace SoftwareFolletosCEPHCIS
{
    class Libros
    {
        private string Nombre;
        private string Autor;
        private string Clave;
        private string Ubicacion;
        private string Descripcion;
        private int Id;
        private string Busqueda;


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
        public Libros(string busqueda)
        {
            this.Busqueda = busqueda;
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
            SqlCommand consulta = new SqlCommand("UPDATE tb_libros SET Nombre = @nombre, Autor = @autor, Clave = @clave, Ubicacion = @ubicacion, Descripcion = @descripcion WHERE ID = @id", cn);
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

        public string Des1()
        {
            string des = string.Empty;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT TOP 1 Descripcion FROM tb_libros ORDER BY Id ASC", cn);
            object resultado = consulta.ExecuteScalar();
            des = resultado.ToString();
            cn.Close();
            return des;
        }
        public string T1()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT TOP 1 Nombre FROM tb_libros ORDER BY Id ASC", cn);
            object resultado = consulta1.ExecuteScalar();
            titu = resultado.ToString();
            cn.Close();
            return titu;
        }

        public string T2()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            titu = resultado.ToString();
            cn.Close();
            return titu;
        }

        public string Des2()
        {
            string des = string.Empty;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT Descripcion FROM tb_libros ORDER BY Id ASC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta.ExecuteScalar();
            des = resultado.ToString();
            cn.Close();
            return des;
        }

        public string Autor1()
        {
            string A = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT TOP 1 Autor FROM tb_libros ORDER BY Id ASC", cn);
            object resultado = consulta1.ExecuteScalar();
            A = resultado.ToString();
            cn.Close();
            return A;
        }
        public string Autor2()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            titu = resultado.ToString();
            cn.Close();
            return titu;
        }

        public string T3()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor3()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 2 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T4()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 3 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor4()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 3 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T5()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 4 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor5()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 4 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T6()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 5 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor6()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 5 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T7()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 6 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor7()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 6 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T8()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 7 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor8()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 7 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string T9()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros ORDER BY Id ASC OFFSET 8 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {
                titu = resultado.ToString();
                cn.Close();
                return titu;
            }

        }

        public string Autor9()
        {
            string titu = string.Empty;
            cn.Open();
            SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros ORDER BY Id ASC OFFSET 8 ROWS FETCH NEXT 1 ROWS ONLY", cn);
            object resultado = consulta1.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No hay datos";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();
                cn.Close();
                return titu;
            }
        }

        public string p1()
        {
            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;
            }
        }

        public string a2()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }

        public string Des()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Descripcion FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }

        public string Nom()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Nombre FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }
        public string Cla()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Clave FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }

        public string Au()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Autor FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }

        public string Ubi()
        {

            string titu;
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT ID FROM tb_libros WHERE Nombre LIKE @busqueda or Autor LIKE @busqueda or Clave LIKE @busqueda or Ubicacion LIKE @busqueda or Descripcion LIKE @busqueda", cn);
            consulta.Parameters.AddWithValue("busqueda", Busqueda);
            object resultado = consulta.ExecuteScalar();
            if (resultado == null)
            {

                titu = "No se encontro";
                cn.Close();
                return titu;
            }
            else
            {

                titu = resultado.ToString();

                SqlCommand consulta1 = new SqlCommand("SELECT Ubicacion FROM tb_libros WHERE ID = " + titu, cn);

                object resultado1 = consulta1.ExecuteScalar();
                string ti = resultado1.ToString();

                cn.Close();
                return ti;

            }

        }
    }
}
