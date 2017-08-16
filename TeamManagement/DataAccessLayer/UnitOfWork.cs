using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace DataAccessLayer
{
    public class UnitOfWork
    {

        TaskManagementContext _dbContext;
        DbContextTransaction _transaction;
        public UnitOfWork()
        {
            _dbContext = new TaskManagementContext();
            //_transaction = _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        private StateRepository _stateRepo;

        public StateRepository StateRepository
        {
            get
            {
                if (_stateRepo==null)
                {
                    _stateRepo = new StateRepository(_dbContext);
                }
                return _stateRepo;
            }
        }

        private ProjectRepository  _projectRepo;

        public ProjectRepository  ProjectRepository
        {
            get
            {
                if (_projectRepo==null)
                {
                    _projectRepo = new ProjectRepository(_dbContext);
                }
                return _projectRepo;
            }
           
        }
        private EmployeeRepository _employeeRepo;

        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepo==null)
                {
                    _employeeRepo = new EmployeeRepository(_dbContext);
                }
                return _employeeRepo;
            }
           
        }
        private WorkRepository _workRepo;

        public WorkRepository WorkRepository
        {
            get
            {
                if (_workRepo==null)
                {
                    _workRepo = new WorkRepository(_dbContext);
                }
                return _workRepo;
            }
          
        }
        private RequestRepository _requestRepo;

        public RequestRepository RequestRepository
        {
            get
            {
                if (_requestRepo==null)
                {
                    _requestRepo = new RequestRepository(_dbContext);
                }
                return _requestRepo;
            }
         
        }
        private CustomerRepository _customerRepo;

        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepo==null)
                {
                    _customerRepo = new CustomerRepository(_dbContext);
                }
                return _customerRepo;
            }
        }
        private LoginRepository _loginRepo;

        public LoginRepository LoginRepository
        {
            get
            {
                if (_loginRepo==null)
                {
                    _loginRepo = new LoginRepository(_dbContext);
                }
                return _loginRepo;
            }
        }

        private RoleRepository _roleRepo;

        public RoleRepository RoleRepository
        {
            get
            {
                if (_roleRepo==null)
                {
                    _roleRepo = new RoleRepository(_dbContext);
                }
                return _roleRepo;
            }
        }

       

        public bool ApplyChanges()
        {
            bool isSuccess = false;
            _transaction= _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _dbContext.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }

            catch (Exception ex)
            {

                _transaction.Rollback();
                isSuccess = false;

            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;



            
           

        }


    }
}
