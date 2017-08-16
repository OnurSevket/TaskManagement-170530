using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;

namespace WinFormUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        private Employee employee;

        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(Employee employee)
        {
           
            InitializeComponent();
            this.employee = employee;
        }

        #region MainForm'da bulunan Form için oluşturulan butonların Click Eventi
        private void mtProjectForm_Click(object sender, EventArgs e)
        {
            ProjectForm projForm = new ProjectForm();
            projForm.Owner = this;
            projForm.Show();
        }

        private void mtTaskForm_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.Owner = this;
            taskForm.Show();
        }

        private void mtCustomerForm_Click(object sender, EventArgs e)
        {
            CustomerForm custForm = new CustomerForm();
            custForm.Owner = this;
            custForm.Show();
        }

        private void mtRequestForm_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            requestForm.Owner = this;
            requestForm.Show();
        } 
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Role ait kısımlardaki instance almak için kulllanıyoruz.
            _roleBLL = new RoleBusiness(employee);
            //Role kısmındaki role listesini yenileyecek
            RefleshGridRole();


            //Admin için Employee ait kısımdaki intance almak için kullanıyoruz.
            _empBLL = new EmployeeBusiness();
            //Admin kısmındaki role listesini yenileyecek
            RefleshGridEmployee();


            //Admin için State ait kısımdaki intance almak için kullanıyoruz.
            _stateBLL = new StateBusiness(employee);
            //Admin kısmındaki State listesini yenileyecek
            RefleshGridState();





            if (employee.RoleID == 1)
            {
                EmployeeNameandRole();
            }
            if (employee.RoleID == 2)
            {
                EmployeeNameandRole();
            }
            if (employee.RoleID == 3)
            {
                EmployeeNameandRole();
            }
            if (employee.RoleID == 4)
            {
                EmployeeNameandRole();
            }
            if (employee.RoleID == 5)
            {
                EmployeeNameandRole();
            }
        }
        //Bu method constructur dan gelen çalışanı role ve adını alır label a yazdırır
        public void EmployeeNameandRole()
        {
            lblEmployeeRole.Text = employee.Role.Name;
            lblEmployeeName.Text = employee.FirstName + " " + employee.LastName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #region ForRole

        RoleBusiness _roleBLL;
        int selectedID;

        public void RefleshGridRole()
        {
            try
            {
                ICollection<Role> roleList = _roleBLL.GetAll();
                dgvRoleList.DataSource = null;
                dgvRoleList.DataSource = roleList;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnRoleSave_Click(object sender, EventArgs e)
        {
            try
            {
                Role newRole = new Role();
                newRole.Name = txtRolName.Text;
                _roleBLL.Add(newRole);
                RefleshGridRole();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
         try
            {
                Role deleteRole=null;
                deleteRole = _roleBLL.Get(selectedID);
                selectedID = 0;
                _roleBLL.Remove(deleteRole);
                RefleshGridRole();
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnRoleUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Role updateRole=null;

                updateRole = _roleBLL.Get(selectedID);
                updateRole.Name = txtRolName.Text;
                _roleBLL.Update(updateRole);
                RefleshGridRole();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void dgvRoleList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvRoleList.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgvRoleList.SelectedRows[0];
                    string updateIdInput = dr.Cells[0].Value.ToString();
                    selectedID = int.Parse(updateIdInput);
                    Role updateRole = _roleBLL.Get(selectedID);
                    txtRolName.Text = updateRole.Name;
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }

        }

        #endregion

        #region ForEmployee

        EmployeeBusiness _empBLL;


        public void RefleshGridEmployee()
        {
            try
            {
                ICollection<Employee> empList = _empBLL.GetAll();
                dgvEmployeeList.DataSource = null;
                dgvEmployeeList.DataSource = empList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvEmployeeList.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgvEmployeeList.SelectedRows[0];
                    string updateIdInput = dr.Cells[0].Value.ToString();
                    selectedID = int.Parse(updateIdInput);
                    Employee updateEmployee = _empBLL.Get(selectedID);
                    txtFirstName.Text = updateEmployee.FirstName;
                    txtLastName.Text = updateEmployee.LastName;
                    txtPhone.Text = updateEmployee.Phone;
                    txtEmail.Text = updateEmployee.Mail;
                    txtUserName.Text = updateEmployee.Login.UserName;
                    txtPassword.Text = updateEmployee.Login.Password;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {

        }




        #endregion

        #region ForState

        StateBusiness _stateBLL;

        public void RefleshGridState()
        {
            try
            {
                ICollection<State> stateList = _stateBLL.GetAll();
                dgvStateList.DataSource = null;
                dgvStateList.DataSource = stateList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvStateList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnStateSave_Click(object sender, EventArgs e)
        {

        }

        private void btnStateDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnStateUpdate_Click(object sender, EventArgs e)
        {

        }




        #endregion

        
    }
}
