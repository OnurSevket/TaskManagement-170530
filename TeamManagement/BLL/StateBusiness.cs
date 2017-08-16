using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class StateBusiness : IBusiness<State>
    {
        UnitOfWork _uof;
        Employee emp;

        public StateBusiness(Employee employee)
        {
            emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(State item)
        {
            if (item!=null)
            {
                if (item.StateName == null)
                {
                    throw new Exception("Durum metni mutlaka girilmelidir");
                }
                if (true)
                {
                    _uof.StateRepository.Add(item);
                    return _uof.ApplyChanges();
                }

            }
            return false;        
        }

        public State Get(int id)
        {
            if (id > 0)
            {
                return _uof.StateRepository.Get(id);
            }
            else
            {
                throw new Exception("Gelen değerin 0 dan büyük olması gerekmektedir");
            }
        }

        public ICollection<State> GetAll()
        {
            if (_uof.StateRepository.GetAll().Count > 0)
            {
                return _uof.StateRepository.GetAll();
            }
            else
            {
                throw new Exception("İstediğiniz listede kayıt bulunmamaktadır");
            }
        }

        public bool Remove(State item)
        {
            if (item != null)
            {
                _uof.StateRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(State item)
        {
            if (item != null)
            {
                if (item.StateName == null)
                {
                    throw new Exception("Durum metni mutlaka girilmelidir");
                }
                if (true)
                {
                    _uof.StateRepository.Update(item);
                    return _uof.ApplyChanges();
                }

            }
            return false;
        }
    }
}
