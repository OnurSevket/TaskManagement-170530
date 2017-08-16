using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class RequestBusiness : IBusiness<Request>
    {
        UnitOfWork _uof;
        Employee emp;

        public RequestBusiness(Employee employee)
        {
            emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Request item)
        {
            if (item!=null)
            {
                if (item.ProjectId<0)
                {
                    throw new Exception("Talep oluştururken bir proje seçilmelidir");
                }
                if (item.Type==null)
                {
                    throw new Exception("Talep tipi mutlaka seçilmelidir");
                }
                if (item.Description==null)
                {
                    throw new Exception("Talep açıklama kısmı doldurulmalıdır");
                }
                if (true)
                {
                    _uof.RequestRepository.Add(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;

        }

        public Request Get(int id)
        {
            if (id>0)
            {
                return _uof.RequestRepository.Get(id);
            }
            else
            {
                throw new Exception("Id değeri 0'dan büyük olmalıdır");
            }
        }

        public ICollection<Request> GetAll()
        {
            if (_uof.RequestRepository.GetAll().Count!=0)
            {
                return _uof.RequestRepository.GetAll();
            }
            throw new Exception("Listede kayıt bulunamadı");
        }

        public bool Remove(Request item)
        {
            if (item!=null)
            {
                _uof.RequestRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(Request item)
        {
            if (item != null)
            {
                if (item.ProjectId < 0)
                {
                    throw new Exception("Talep güncellenirken bir proje seçilmelidir");
                }
                if (item.Type == null)
                {
                    throw new Exception("Talep tipi mutlaka seçilmelidir");
                }
                if (item.Description == null)
                {
                    throw new Exception("Talep açıklama kısmı doldurulmalıdır");
                }
                if (true)
                {
                    _uof.RequestRepository.Update(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;
        }
    }
}
