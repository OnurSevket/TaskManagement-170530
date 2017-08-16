using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BLL
{
    public class CustomerBusiness : IBusiness<Customer>
    {
        UnitOfWork _uof;  
        Employee _emp;

        public CustomerBusiness(Employee employee)
        {
            _emp = employee;
            _uof = new UnitOfWork();
        }

        public bool Add(Customer item)
        {
            if (item!=null)
            {
                if (item.CompanyName==null)
                {
                    throw new Exception("Müşteri eklenirken mutlaka şirket bilgisi girilmelidir");
                }
                if (item.ContactName==null)
                {
                    throw new Exception("Şirkette irtibata geçilecek kişi belirtilmelidir");
                }
                if (item .ContactTitle==null)
                {
                    item.ContactTitle = "Çalışan";
                }
                if (item.City==null)
                {
                    throw new Exception("Şirket şehir bilgisi mutlaka girilmelidir");
                }
                if (item.Address==null)
                {
                    throw new Exception("Şirket adres bilgisi mutlaka girilmelidir");
                }
                if (item.Email==null)
                {
                    throw new Exception("Şirket mail adresi mutlaka bildirilmelidir");
                }
                if (item.Phone==null)
                {
                    throw new Exception("Şirket irtibat numarası mutlaka bildirilmelidir");
                }
                if (true)
                {
                    _uof.CustomerRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                
            }
            return false;
        }

        public Customer Get(int id)
        {
            if (id>0)
            {
                return _uof.CustomerRepository.Get(id);
            }
            else
            {
                throw new Exception("Gelen değerin 0 dan büyük olması gerekmektedir");
            }
        }

        public ICollection<Customer> GetAll()
        {
           
                return _uof.CustomerRepository.GetAll();
            
            //else
            //{
            //    throw new Exception("İstediğiniz listede eleman bulunmamaktadır");
            //}
        }

        public bool Remove(Customer item)
        {
            if (item !=null )
            {
                _uof.CustomerRepository.Remove(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public bool Update(Customer item)
        {
            if (item != null)
            {
                if (item.CompanyName == null)
                {
                    throw new Exception("Müşteri eklenirken mutlaka şirket bilgisi girilmelidir");
                }
                if (item.ContactName == null)
                {
                    throw new Exception("Şirkette irtibata geçilecek kişi belirtilmelidir");
                }
                if (item.ContactTitle == null)
                {
                    item.ContactTitle = "Çalışan";
                }
                if (item.City == null)
                {
                    throw new Exception("Şirket şehir bilgisi mutlaka girilmelidir");
                }
                if (item.Address == null)
                {
                    throw new Exception("Şirket adres bilgisi mutlaka girilmelidir");
                }
                if (item.Email == null)
                {
                    throw new Exception("Şirket mail adresi mutlaka bildirilmelidir");
                }
                if (item.Phone == null)
                {
                    throw new Exception("Şirket irtibat numarası mutlaka bildirilmelidir");
                }
                if (true)
                {
                    _uof.CustomerRepository.Update(item);
                    return _uof.ApplyChanges();
                }

            }
            return false;
        }
    }
}
