using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Presidents.Controllers
{
    public class PresidentController : ApiController
    {
        private IOperations<President> _president;
        
        public PresidentController(IOperations<President> president)
        {
            this._president = new BLLPresident();
        }

        public IEnumerable<President> GetAll()
        {
            try
            {
                return _president.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("PresidentController. Error en GetAll. Error:" + ex.Message);
            }
        }

        public IHttpActionResult GetPresidentByName(string id)
        {
            try
            {
                var president = this._president.GetByName(id);

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