
using Seguritas.Contexto.Utilities;
using SeguritasModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguritas.Contexto.DAL
{
    public class HomeDAL
    {

        public static async Task<ProcessResult> ListarHome()
        {
            ProcessResult pResult = new ProcessResult();
            await Task.Run(() =>
            {
                try
                {
                    var listado = new List<HomeModel>();
                    using (var ctx = new SeguritasContext())
                    {
                        listado = ctx.Database.SqlQuery<HomeModel>("dbo.GetHome").ToList();
                        if (listado.Any())
                            pResult.Result = listado;
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
