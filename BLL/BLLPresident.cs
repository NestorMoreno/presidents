using System;
using System.Collections.Generic;
using DTO;
using DAL.Presidents;

namespace BLL
{
    public class BLLPresident : IOperations<DTO.President>
    {
        PresidentRepository president;
        
        public BLLPresident()
        {
            president = new PresidentRepository();                
        }

        public List<President> GetAll()
        {
            try
            {
                var presidents = president.GetAll();
                
                // Calcular el edad
                presidents.ForEach(e=>e.Age = new PresidentOperationsFactory().CreateSalesOperations(e).getAge(e) );

                return presidents;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLPresident. Error en GetAll. Error:" + ex.Message);
            }
        }

        public President GetByName(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var presid = president.GetAll().Find(e => e.Name.Equals(name));
                    return presid;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLLPresident. Error en GetByName. Error:" + ex.Message);
            }
            
        }
    }
}
