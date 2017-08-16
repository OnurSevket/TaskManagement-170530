using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class RoleBusiness : IBusiness<Role>
    {
        UnitOfWork _uof;
        Employee emp;

        public RoleBusiness(Employee employee)
        {
            emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Role item)
        {
            if (item != null)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    throw new Exception("Role Adı Girilmelidir.");
                }
                if (true)
                {
                    _uof.RoleRepository.Add(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;
        }

        public bool Remove(Role item)
        {

            if (item != null)
            {
                _uof.RoleRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;

        }

        public bool Update(Role item)
        {
            _uof.RoleRepository.Update(item);
            return _uof.ApplyChanges();
        }

        public Role Get(int id)
        {
            if (id > 0)
            {
                return _uof.RoleRepository.Get(id);
            }
            else
            {
                throw new Exception("Id'nin 0 dan büyük olması gerekmektedir");
            }

        }

        public ICollection<Role> GetAll()
        {

            if (_uof.RoleRepository.GetAll().Count > 0)
            {
                return _uof.RoleRepository.GetAll();
            }
            else
            {
                throw new Exception("İstediğiniz listede kayıt bulunmamaktadır");
            }

        }


    }
}
