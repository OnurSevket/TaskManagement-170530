using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class TaskForm : MetroFramework.Forms.MetroForm
    {

        WorkBusiness _workBLL;
        ProjectBusiness _proBLL;
        StateBusiness _stateBLL;
        EmployeeBusiness _empBLL;

        public TaskForm()
        {
            InitializeComponent();
            _workBLL = new WorkBusiness(LoginForm.EmployeeId());
            _proBLL = new ProjectBusiness(LoginForm.EmployeeId());
            _stateBLL = new StateBusiness(LoginForm.EmployeeId());
            _empBLL = new EmployeeBusiness(LoginForm.EmployeeId());
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            try
            {
                // DataGridView ' e liste yükleniyor.
                //  dgvTaskList.DataSource = _workBLL.GetAll();

                // Comboboxlara listeler yükleniyor.
                //cmbProjectName.DataSource = _proBLL.GetAll()
                //    .Where(o => o.Employees.Any(t => t.ID == LoginForm.EmployeeId().ID)).ToList();


                //cmbProjectName.DisplayMember = "Name";
                //cmbProjectName.ValueMember = "ID";

                //cmbProjectName.DataSource = _proBLL.GetAll().ToList();
                cmbState.DataSource = (from s in _stateBLL.GetAll()
                                       select s).ToList();
                cmbState.DisplayMember = "StateName";
                cmbState.ValueMember = "ID";

                var r =(from p in _proBLL.GetAll()
                .Where(o => o.Employees.Any( t => t.ID == LoginForm.EmployeeId().ID)) select p).ToList();


                cmbProjectName.DisplayMember = "Name";
                cmbProjectName.ValueMember = "ID";


                cmbJobAnalyst.DataSource = (from em in _empBLL.GetAll()
                                            where em.RoleID == 3
                                            select em).ToList();
                cmbJobAnalyst.DisplayMember = "FullName";
                cmbJobAnalyst.ValueMember = "ID";

                cmbSoftwareDeveloper.DataSource = (from em in _empBLL.GetAll()
                                                   where em.RoleID == 4
                                                   select em).ToList();
                cmbSoftwareDeveloper.DisplayMember = "FullName";
                cmbSoftwareDeveloper.ValueMember = "ID";

                cmbTester.DataSource = (from em in _empBLL.GetAll()
                                        where em.RoleID == 5
                                        select em).ToList();
                cmbTester.DisplayMember = "FullName";
                cmbTester.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddJobAnalist_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_empBLL.Get((int)cmbJobAnalyst.SelectedValue));
        }

        private void btnAddSoftwareDevelepor_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_empBLL.Get((int)cmbSoftwareDeveloper.SelectedValue));
        }

        private void btnAddTester_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Add(_empBLL.Get((int)cmbTester.SelectedValue));
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.RemoveAt(lstEmployee.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            work.Name = txtTaskName.Text;
            work.Description = txtDescription.Text;
            work.StartDate = Convert.ToDateTime(dtpStartDate.Text);
            work.EndDate = Convert.ToDateTime(dtpEndDate.Text);
            work.ProjectID = Convert.ToInt32(cmbProjectName.SelectedValue);
            work.StateID = Convert.ToInt32(cmbProjectName.SelectedValue);
            work.Employees = ((List<Employee>)lstEmployee.DataSource);

            _workBLL.Add(work);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            _workBLL = new WorkBusiness(LoginForm.EmployeeId());


        }
    }
}
