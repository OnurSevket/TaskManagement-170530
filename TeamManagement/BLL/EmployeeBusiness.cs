using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class EmployeeBusiness : IBusiness<Employee>
    {
        UnitOfWork _uof;
        Employee _emp;
        public EmployeeBusiness()
        {
            _uof = new UnitOfWork();
        }
        public EmployeeBusiness(Employee employee)
        {
            _emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Employee item)
        {
            if (_emp.RoleID != 1)
            {
                throw new Exception("Çalışan eklemeye yetkili değilsiniz");
            }
            if (item != null)
            {

                if (item.RoleID == 0)
                {
                    throw new Exception("Her çalışanın mutlaka rolü belirlenmelidir");
                }
                if (item.Phone == null)
                {
                    throw new Exception("Telefon numarası mutlaka belirtilmelidir");
                }
                if (item.Mail == null)
                {
                    throw new Exception("Mail adresi mutlaka belirtilmelidir");
                }
                if (item.LastName == null)
                {
                    throw new Exception("Soyisim mutlaka belirtilmelidir");
                }
                if (item.FirstName == null)
                {
                    throw new Exception("İsim mutlaka belirtilmelidir");
                }
                if (true)
                {
                    _uof.EmployeeRepository.Add(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;
        }

        public Employee Get(int id)
        {
            if (id > 0)
            {
                return _uof.EmployeeRepository.Get(id);

            }
            else
            {
                throw new Exception("Değer 0'dan büyük olmalıdır");
            }
        }

        public ICollection<Employee> GetAll()
        {
            return _uof.EmployeeRepository.GetAll();
        }

        public bool Remove(Employee item)
        {
            if (item !=null )
            {
                _uof.EmployeeRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(Employee item)
        {
            if (_emp.RoleID != 1)
            {
                throw new Exception("Çalışan eklemeye yetkili değilsiniz");
            }
            if (item != null)
            {

                if (item.RoleID == 0)
                {
                    throw new Exception("Her çalışanın mutlaka rolü belirlenmelidir");
                }
                if (item.Phone == null)
                {
                    throw new Exception("Telefon numarası mutlaka belirtilmelidir");
                }
                if (item.Mail == null)
                {
                    throw new Exception("Mail adresi mutlaka belirtilmelidir");
                }
                if (item.LastName == null)
                {
                    throw new Exception("Soyisim mutlaka belirtilmelidir");
                }
                if (item.FirstName == null)
                {
                    throw new Exception("İsim mutlaka belirtilmelidir");
                }
                if (true)
                {
                    _uof.EmployeeRepository.Update(item);
                    return _uof.ApplyChanges();
                }
            }
            return false;
        }
    }
}
