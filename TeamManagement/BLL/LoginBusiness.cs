using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class LoginBusiness : IBusiness<Login>
    {
        UnitOfWork _uof;        
        Employee _emp;

        public LoginBusiness(Employee employee)
        {
            _emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Login item)
        {
            if (item != null)
            {
                if (item.UserName == null)
                {
                    throw new Exception("Kullanıcı adı mutlaka girilmelidir");
                }
                if (item.Password == null)
                {
                    throw new Exception("Kullacıya ait şifre mutlaka girilmelidir");
                }
                
                if (true)
                {
                    _uof.LoginRepository.Add(item);
                    return _uof.ApplyChanges();
                }

            }
            return false;
        }

        public Login Get(int id)
        {
            if (id > 0)
            {
                return _uof.LoginRepository.Get(id);
            }
            else
            {
                throw new Exception("Id'nin 0 dan büyük olması gerekmektedir");
            }
        }

        public ICollection<Login> GetAll()
        {
            if (_uof.LoginRepository.GetAll().Count > 0)
            {
                return _uof.LoginRepository.GetAll();
            }
            else
            {
                throw new Exception("İstediğiniz listede kayıt bulunmamaktadır");
            }
        }

        public bool Remove(Login item)
        {
            if (item != null)
            {
                _uof.LoginRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(Login item)
        {
            if (item != null)
            {
                if (item.UserName == null)
                {
                    throw new Exception("Kullanıcı adı mutlaka girilmelidir");
                }
                if (item.Password == null)
                {
                    throw new Exception("Kullacıya ait şifre mutlaka girilmelidir");
                }

                if (true)
                {
                    _uof.LoginRepository.Update(item);
                    return _uof.ApplyChanges();
                }

            }
            return false;
        }
    }
}
