using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatusAlumno
{
    internal class CRUDEstatus
    {
        private static List<Estatus> _listStatus = new List<Estatus>();

        public static List<Estatus> ConsultarTodos()
        {
            return _listStatus;
        }
        public static Estatus ConsultarUno(int id)
        {
            Estatus status1 = _listStatus.Find(esta => esta.id == id);
            return status1;
        }
        public static void Agregar(Estatus estatus)
        {
            _listStatus.Add(estatus);
        }
        public static void Actualizar(Estatus estaus)
        {
            Estatus status1 = _listStatus.Find(esta => esta.id == estaus.id);
            status1.nombre = estaus.nombre;
            status1.clave = estaus.clave;
        }
        public static void Eliminar(Estatus estatus)
        {
            _listStatus.Remove(estatus);
        }

    }
}

