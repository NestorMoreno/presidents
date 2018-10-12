using BLL;
using System.Collections.Generic;
using System.Web.Http;
using DTO;
using System;

namespace Presidents.Controllers
{
    public class PresidentController : ApiController
    {
        BLL.BLLPresident president = new BLLPresident();

        public IEnumerable<President> GetAll()
        {
            try
            {
                return president.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("PresidentController. Error en GetAll. Error:" + ex.Message);
            }
            
        }

        public IHttpActionResult GetPresident(string name)
        {
            try
            {
                var president = this.president.GetByName(name);

                if (president == null)
                {
                    return NotFound();
                }
                return base.Ok(president);
            }
            catch (Exception ex)
            {
                throw new Exception("PresidentController. Error en GetPresident. Error:" + ex.Message);
            }
            
        }
    }
}