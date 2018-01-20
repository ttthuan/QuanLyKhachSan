using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataTranferObject;
using BusinessLayer;

namespace WebAPIService.Controllers
{
    public class DatPhongController : ApiController
    {
        [HttpPost]
        [Route("api/datphongs")]
        public HttpResponseMessage DatPhongAPI([FromBody]PhieuThuePhongDTO phieuThuePhongDTO)
        {
            if(phieuThuePhongDTO != null)
            {
                PhieuThuePhongBUS phieuThuePhongBUS = new PhieuThuePhongBUS();
                try
                {
                    phieuThuePhongBUS.ThemPhieuThuePhong(phieuThuePhongDTO);
                    return Request.CreateResponse(HttpStatusCode.OK, "success");
                }
                catch(Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.GatewayTimeout, "error");
                }
            }
            return Request.CreateResponse(HttpStatusCode.GatewayTimeout, "error");
        }
    }
}
