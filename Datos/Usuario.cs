using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelo;

namespace WindowsFormsApp1.Datos
{
    public class Usuario
    {
        List<Librosmodel> lista = new List<Librosmodel>();
        
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(Librosmodel modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>Datos de usuarios </returns>
        public List<Librosmodel> Consultar()
        {
            return lista;
        }
    }
}
