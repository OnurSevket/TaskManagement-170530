using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class WorkBusiness : IBusiness<Work>
    {
        UnitOfWork _uof;
        Employee emp;

        public WorkBusiness(Employee employee)
        {
            emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Work item)
        {          
            if (item!=null)
            {
                if (item.Name==null)
                {
                    throw new Exception("Çalışan adı mutlaka girilmelidir");
                }
                if (item.Description==null)
                {
                    throw new Exception("Tanımlama adı mutlaka girilmelidir");
                }

                if (item.StartDate==null)
                {
                    throw new Exception("Giriş Tarihi mutlaka girilmelidir.");
                }

                if (item.EndDate==null)
                {
                    throw new Exception("Bitiş Tarihi mutlaka girilmelidir.");
                }

                if (true)
                {
                    _uof.WorkRepository.Add(item);
                    return _uof.ApplyChanges();
                }

            }

            return false;
        }
        public bool Remove(Work item)
        {
            

            if (item != null)
            {
                _uof.WorkRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;

        }

        public bool Update(Work item)
        {

            if (item != null)
            {
                if (item.Name == null)
                {
                    throw new Exception("Çalışan adı mutlaka girilmelidir");
                }
                if (item.Description == null)
                {
                    throw new Exception("Tanımlama adı mutlaka girilmelidir");
                }

                if (item.StartDate == null)
                {
                    throw new Exception("Giriş Tarihi mutlaka girilmelidir.");
                }

                if (item.EndDate == null)
                {
                    throw new Exception("Bitiş Tarihi mutlaka girilmelidir.");
                }

                if (true)
                {
                    _uof.WorkRepository.Update(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;
        }

        public Work Get(int id)
        {
       
            if (id > 0)
            {
                return _uof.WorkRepository.Get(id);
            }
            else
            {
                throw new Exception("Id'nin 0 dan büyük olması gerekmektedir");
            }
        }

        public ICollection<Work> GetAll()
        {
            
           
                return _uof.WorkRepository.GetAll();
            }
           

        
    }
}
