using DAL.Presidents;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLPresident : IOperations<President>
    {
        PresidentRepository _repository;
        
        public BLLPresident()
        {
            this._repository = new PresidentRepository();                
        }

        public List<President> GetAll()
        {
            try
            {
                var presidents = _repository.GetAll();
                // Calcular edad
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
                    var president = _repository.GetAll().Find(p => p.Name.ToLower().Contains(name.ToLower()));
                    if (president != null)
                    {
                        president.Age = new PresidentOperationsFactory().CreateSalesOperations(president).getAge(president);
                    }
                    return president;
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
