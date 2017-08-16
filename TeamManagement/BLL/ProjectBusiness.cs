using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class ProjectBusiness : IBusiness<Project>
    {
        UnitOfWork _uof;
        Employee _emp;

        public ProjectBusiness(Employee employee)
        {
            _emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Project item)
        {
            
            if (item!=null)
            {

                if (item.CustomerID==null )
                {
                    throw new Exception("Projenin mutlaka bir müşterisi olmalıdır");
                }
                //Bir projenin 4 tane çalışanı olmak zorunda ve çalışanı boş geçileme< 
                if (item.Employees.Count < 4 || item.Employees == null)
                {
                    throw new Exception("Projenin mutlaka en az 4 farklı çalışanı olmalıdır");
                }
                if (item.PlannedEndDate==null )
                {
                    throw new Exception("Projenin planlanan başlangıç tarihi belirlenmelidir");
                }
                if (item.PlannedStartDate==null)
                {
                    throw new Exception("Projenin planlanan bitiş tarihi belirlenmelidir");
                }
                if (item.State==null)
                {
                    item.State = "Oluşturuldu";
                }
                if (item.Name==null)
                {
                    throw new Exception("Proje ismi mutlaka girilmelidir");
                }
                if (item.Description==null)
                {
                    throw new Exception("Proje oluşturulurken mutlaka detay kısmı doldurulmalıdır");
                }
                if (true)
                {
                    _uof.ProjectRepository.Add(item);
                  return   _uof.ApplyChanges();
                    
                }
            }
            return false;
          
        }

        public Project Get(int id)
        {
            if (id>0)
            {
              return   _uof.ProjectRepository.Get(id);
                
            }
            return null;
        }

        public ICollection<Project> GetAll()
        {
            return _uof.ProjectRepository.GetAll();
        }

        public bool Remove(Project item)
        {
            if (item!=null)
            {
                _uof.ProjectRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(Project item)
        {
            if (item != null)
            {

                if (item.Customer == null )
                {
                    throw new Exception("Projenin mutlaka bir müşterisi olmalıdır");
                }
                //Bir projenin 4 tane çalışanı olmak zorunda ve çalışanı boş geçileme< 
                if (item.Employees.Count<4 || item.Employees==null)
                {
                    throw new Exception("Projenin mutlaka en az 4 farklı çalışanı olmalıdır");
                }
                if (item.PlannedEndDate == null)
                {
                    throw new Exception("Projenin planlanan başlangıç tarihi belirlenmelidir");
                }
                if (item.PlannedStartDate == null)
                {
                    throw new Exception("Projenin planlanan bitiş tarihi belirlenmelidir");
                }
                if (item.State == null)
                {
                    item.State = "Güncellendi";
                }
                if (item.Name == null)
                {
                    throw new Exception("Proje ismi mutlaka girilmelidir");
                }
                if (item.Description == null)
                {
                    throw new Exception("Proje oluşturulurken mutlaka detay kısmı doldurulmalıdır");
                }
                if (true)
                {
                    _uof.ProjectRepository.Update(item);
                    _uof.ApplyChanges();
                    return true;
                }
            }
            return false;

        }
    }
}
