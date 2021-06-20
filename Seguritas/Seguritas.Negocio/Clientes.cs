using Seguritas.Contexto;
using Seguritas.Contexto.DAL;
using Seguritas.Negocio.Utilities;
using SeguritasModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguritas.Negocio
{
    public class FxClientes
    {

        public static ProcessResult ObtenerClientes()
        {
            ProcessResult pResult = new ProcessResult();

            try
            {
                var responseDAL = ClientesDAL.ListarClientes();
                if (responseDAL.Status != Contexto.Utilities.ProcessResult.StatusCode.Failure)
                    pResult.Result = responseDAL.Result;
                else
                {
                    pResult.Mensaje = responseDAL.Mensaje;
                    pResult.CodeRequest = (ProcessResult.ProcessCodeTypes)responseDAL.CodeRequest;
                    pResult.Status = (ProcessResult.StatusCode)responseDAL.Status;
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
