using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguritas.Negocio.Utilities
{
    public class ProcessResult
    {

        public ProcessResult()
        {
            Mensaje = string.Empty;
            Status = StatusCode.Complete;
            CodeRequest = ProcessCodeTypes.Success;
            Result = new object();
        }
        

        public string Mensaje { get; set; }
        public StatusCode Status { get; set; }
        public ProcessCodeTypes CodeRequest { get; set; }
        public object Result { get; set; }

        public enum StatusCode
        {
            Success,
            Complete,
            Failure
        }
        
        public enum ProcessCodeTypes
        {
            Success = 200,
            NotFound = 404,
            InternalServerError = 500,
            BadRequest = 400
        }

    }
}
