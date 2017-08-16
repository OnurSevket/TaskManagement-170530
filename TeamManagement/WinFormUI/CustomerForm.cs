using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
namespace WinFormUI
{
    public partial class CustomerForm : MetroFramework.Forms.MetroForm
    {
       // static Customer _customer;
        CustomerBusiness _cusBus;
        int selectedID;

        public CustomerForm()
        {
            InitializeComponent();
            //_customer = new Customer();
            _cusBus= new CustomerBusiness(LoginForm.EmployeeId());
        }

        private void dvgCustomerList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dvgCustomerList.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dvgCustomerList.SelectedRows[0];
                    string updateIdInput = dr.Cells[0].Value.ToString();
                    selectedID = int.Parse(updateIdInput);
                    Customer updateCustomer = _cusBus.Get(selectedID);



                    txtCompanyName.Text = updateCustomer.CompanyName;
                    txtContactName.Text = updateCustomer.ContactName;
                    txtContactTitle.Text = updateCustomer.ContactTitle;
                    txtEmail.Text = updateCustomer.Email;
                    mtxtPhone.Text = updateCustomer.Phone;
                    txtAddress.Text = updateCustomer.Address;
                    txtCity.Text = updateCustomer.City;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = null;
                newCustomer = new Customer();

                newCustomer.Address = txtAddress.Text;
                newCustomer.City = txtCity.Text;
                newCustomer.CompanyName = txtCompanyName.Text;
                newCustomer.ContactName = txtContactName.Text;
                newCustomer.ContactTitle = txtContactTitle.Text;
                newCustomer.Email = txtEmail.Text;
                newCustomer.Phone = mtxtPhone.Text;
                _cusBus.Add(newCustomer);

                //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
                RefreshGridCustomer();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Customer deleteCustomer=null;
                deleteCustomer = _cusBus.Get(selectedID);
                selectedID = 0;
                _cusBus.Remove(deleteCustomer);
                RefreshGridCustomer();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer updateCustomer = null;
                updateCustomer = new Customer();
                updateCustomer = _cusBus.Get(selectedID);
               

                updateCustomer.Address = txtAddress.Text;
                updateCustomer.City = txtCity.Text;
                updateCustomer.CompanyName = txtCompanyName.Text;
                updateCustomer.ContactName = txtContactName.Text;
                updateCustomer.ContactTitle = txtContactTitle.Text;
                updateCustomer.Email = txtEmail.Text;
                updateCustomer.Phone = mtxtPhone.Text;

                

                _cusBus.Update(updateCustomer);
                RefreshGridCustomer();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        //public static Customer CustomerId()
        //{
        //   // return _customer;
        //}


        //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
        public void RefreshGridCustomer()
        {
            try
            {
                ICollection<Customer> projectList = _cusBus.GetAll();
                dvgCustomerList.DataSource = null;
                dvgCustomerList.DataSource = projectList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
            RefreshGridCustomer();
        }


    }
}
