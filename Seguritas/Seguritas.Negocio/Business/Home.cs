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
    public class FxHome
    {

        public static ProcessResult ListarRegistros()
        {
            ProcessResult pResult = new ProcessResult()
            {
                Status = ProcessResult.StatusCode.Success
            };

            try
            {
                var responseDAL = Task.Run(async () => await HomeDAL.ListarHome()).Result;
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
