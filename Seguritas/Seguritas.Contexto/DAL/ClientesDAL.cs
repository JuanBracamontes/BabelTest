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

        public static async Task<ProcessResult> ListarClientes()
        {
            ProcessResult pResult = new ProcessResult();
            await Task.Run(() =>
            {
                try
                {
                    var ltCliente = new List<ClienteModel>();
                    using (var ctx = new SeguritasContext())
                    {
                        var response = ctx.Clientes.ToList();
                        foreach (var item in response)
                        {
                            ltCliente.Add(new ClienteModel()
                            {
                                FechaCreacion = item.FechaCreacion.ToString("dd/MM/yyyy"),
                                FechaModificacion = item.FechaModificacion.ToString("dd/MM/yyyy"),
                                Nombre = item.Nombre,
                                Id = item.Id
                            });
                        }
                        pResult.Result = ltCliente;
                    }
                }
                catch (Exception ex)
                {
                    pResult.Mensaje = ex.Message;
                    pResult.Status = ProcessResult.StatusCode.Failure;
                    pResult.CodeRequest = ProcessResult.ProcessCodeTypes.InternalServerError;
                }
            });
            return pResult;
        }


    }
}
