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
using System.Data.Entity;
namespace WinFormUI
{
    public partial class ProjectForm : MetroFramework.Forms.MetroForm
    {
        int selectedID;
        EmployeeBusiness _employee;
        CustomerBusiness _customer;
        ProjectBusiness _project;
        public ProjectForm()

        {
            InitializeComponent();
            _customer = new CustomerBusiness(LoginForm.EmployeeId());
            _employee = new EmployeeBusiness(LoginForm.EmployeeId());
            _project = new ProjectBusiness(LoginForm.EmployeeId());
        }

        //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
        public void RefreshGridProject()
        {
            try
            {
                ICollection<Project> projectList = _project.GetAll();
                dvgProjectList.DataSource = null;
                dvgProjectList.DataSource = projectList;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {


        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

            //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
            RefreshGridProject();

            //ProjectBusiness _project = new ProjectBusiness(employee);
            cmbCompanyName.DataSource = _customer.GetAll();
            cmbCompanyName.ValueMember = "ID";
            cmbCompanyName.DisplayMember = "CompanyName";
            cmbCompanyName.SelectedIndex = -1;

            cmbJobAnalyst.DataSource = (from c in _employee.GetAll()
                                        where c.RoleID == 3
                                        select c).ToList();
            cmbJobAnalyst.DisplayMember = "FullName";
            cmbJobAnalyst.ValueMember = "ID";

            cmbSoftwareDeveloper.DataSource = (from c in _employee.GetAll()
                                               where c.RoleID == 4
                                               select c).ToList();
            cmbSoftwareDeveloper.DisplayMember = "FullName";
            cmbSoftwareDeveloper.ValueMember = "ID";

            cmbTeamLeader.DataSource = (from c in _employee.GetAll()
                                        where c.RoleID == 2
                                        select c).ToList();
            cmbTeamLeader.DisplayMember = "FullName";
            cmbTeamLeader.ValueMember = "ID";

            cmbTester.DataSource = (from c in _employee.GetAll()
                                    where c.RoleID == 5

                                    select c)

                                        .ToList();
            cmbTester.DisplayMember = "FullName";
            cmbTester.ValueMember = "ID";
        }

        #region Listeye göndermemize yarayan Buton Eventleri
        private void btnAddTeamLeader_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_employee.Get((int)cmbTeamLeader.SelectedValue));
        }

        private void btnAddJobAnalist_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_employee.Get((int)cmbJobAnalyst.SelectedValue));
        }

        private void btnAddTester_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_employee.Get((int)cmbTester.SelectedValue));
        }

        private void btnAddSoftwareDevelepor_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_employee.Get((int)cmbSoftwareDeveloper.SelectedValue));
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndex);
        }
        #endregion



        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }
       
        private void btnAddProject_Click(object sender, EventArgs e)
        {           
            try
            {
                Project project = new Project();

                project.Name = txtProjectName.Text;
                project.Description = txtDescription.Text;
                project.PlannedStartDate = dtpPlannedStartDate.Value;
                project.PlannedEndDate = dtpPlannedEndDate.Value;
                project.RealStartDate = dtpPlannedStartDate.Value;
                project.RealEndDate = dtpPlannedEndDate.Value;


                Customer customer = new Customer();
                if (cmbCompanyName.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Müşterisi Olmayan bir Proje Oluşturulamaz.Lütfen Bir Müşteri Seçiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {  
                    foreach (Customer item in _customer.GetAll())
                    {
                        if (cmbCompanyName.SelectedValue.ToString() == item.ID.ToString())
                        {
                            project.CustomerID = item.ID;

                            //Customer seçildiğinde veritabanına o id 'li Customerı komple gönderildi.
                            //Customer customName = _customer.Get(item.ID);
                            //project.Customer = customName;
                        }
                    }
             //TODO:Çalışanlarımı gönderirken hata ile karşılaşıyorum
                    List<Employee> empCollection = new List<Employee>();
                    for (int i = 0; i < lstEmployee.Items.Count; i++)
                    {
                      
                        empCollection.Add((Employee)lstEmployee.Items[i]);
                                           
                    }
                    project.Employees = empCollection;
                    _project.Add(project);
                }
                //Bu method yapılan değişiklikler için DataGridView 'imizi yenilememizi sağlar.
                RefreshGridProject();
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
                Project deleteProject = null;
                deleteProject = _project.Get(selectedID);
                selectedID = 0;
                _project.Remove(deleteProject);
                RefreshGridProject();
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
                Project updateProject = null;
                updateProject = new Project();

                updateProject = _project.Get(selectedID);

                updateProject.Name = txtProjectName.Text;
                updateProject.Description = txtDescription.Text;
                updateProject.PlannedStartDate = dtpPlannedStartDate.Value;
                updateProject.PlannedEndDate = dtpPlannedEndDate.Value;
                updateProject.RealStartDate = dtpPlannedStartDate.Value;
                updateProject.RealEndDate = dtpPlannedEndDate.Value;

                //Customer customer = new Customer();
                if (cmbCompanyName.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Müşterisi Olmayan bir Proje Güncellenemez.Lütfen Bir Müşteri Seçiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    foreach (Customer item in _customer.GetAll())
                    {
                        if (cmbCompanyName.SelectedValue.ToString() == item.ID.ToString())
                        {
                            updateProject.CustomerID = item.ID;

                            Customer customName = _customer.Get(item.ID);
                            updateProject.Customer = customName;
                        }
                    }
                    for (int i = 0; i < lstEmployee.Items.Count; i++)
                    {
                        updateProject.Employees.Add((Employee)lstEmployee.Items[i]);
                    }

                    _project.Update(updateProject);
                }
                RefreshGridProject();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        //BU Event DataGridView'de seçili olan satırımızı sayfamızda olan toolbox ürünlerimize göndermemizi sağlar.
        private void dvgProjectList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dvgProjectList.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dvgProjectList.SelectedRows[0];
                    string updateIdInput = dr.Cells[0].Value.ToString();
                    selectedID = int.Parse(updateIdInput);
                    Project updateProject = _project.Get(selectedID);



                    txtProjectName.Text = updateProject.Name;
                    txtDescription.Text = updateProject.Description;
                    dtpPlannedStartDate.Value = updateProject.PlannedStartDate;
                    dtpPlannedEndDate.Value = updateProject.PlannedEndDate;
                    dtpPlannedStartDate.Value = (DateTime)updateProject.RealStartDate;
                    dtpPlannedEndDate.Value =(DateTime)updateProject.RealEndDate;
                    txtState.Text = updateProject.State;
                    cmbCompanyName.SelectedValue = (int)updateProject.CustomerID;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
