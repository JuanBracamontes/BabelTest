using Seguritas.Contexto.Utilities;
using SeguritasModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguritas.Contexto.DAL
{
    public class ClientesDAL
    {

        public static ProcessResult ListarClientes()
        {
            ProcessResult pResult = new ProcessResult();
            try
            {
                var ltCliente = new List<Cliente>();
                using (var ctx = new SeguritasContext())
                {
                    var response = ctx.Clientes;
                }
            }
            catch (Exception ex)
            {
                pResult.Mensaje = ex.Message;
                pResult.Status = ProcessResult.StatusCode.Failure;
                pResult.CodeRequest = ProcessResult.ProcessCodeTypes.InternalServerError;
            }
            
            return pResult;
        }


    }
}
