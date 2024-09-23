using Rosales_WaterLevel_Monitor.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosales_WaterLevel_Monitor.Controllers
{
    internal class UsuariosController
    {
        public UsuariosModel InsertarUsuario(UsuariosModel USUARIO)
        {
            return UsuariosModel.Insertar(USUARIO);
        }

        public string ActualizarUsuario(UsuariosModel USUARIO)
        {
            return UsuariosModel.Actualizar(USUARIO);
        }

        public string EliminarUsuario(int IDUSUARIO)
        {
            return UsuariosModel.Eliminar(IDUSUARIO);
        }

        public UsuariosModel ObtenerUsuarioPorId(int IDUSUARIO)
        {
            return UsuariosModel.ObtenerPorId(IDUSUARIO);
        }

        public List<UsuariosModel> ObtenerUsuarios()
        {
            return UsuariosModel.ObtenerTodos();
        }

        public UsuariosModel AutenticarUsuario(string USUARIO, string CONTRASEÑA)
        {
            return UsuariosModel.Autenticar(USUARIO, CONTRASEÑA);
        }
    }
}
