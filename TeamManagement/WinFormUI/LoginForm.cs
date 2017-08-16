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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        MainForm mainForm;
        static string userName;
        static string password;
        static EmployeeBusiness _emp;


        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mpspinner.Visible = true;
            btnLogin.Visible = false;
            _emp = new BLL.EmployeeBusiness();

            userName = txtUserName.Text;
            password = txtPassword.Text;

            Employee employee = (from c in _emp.GetAll()
                                 where c.Login.UserName == userName && c.Login.Password == password
                                 select c).SingleOrDefault();

            //timer1.Start();

            if (employee != null)
            {

                this.Hide();

                mainForm = new MainForm(employee);

                mainForm.Show();
            }
            else
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Böyle bir çalışan yok\n Devam etmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    this.Show();
                }

                else
                {
                    this.Hide();
                }
            }
        }
        public static Employee EmployeeId()
        {
            Employee employee = (from c in _emp.GetAll()
                                 where c.Login.UserName == userName && c.Login.Password == password
                                 select c).SingleOrDefault();
            return employee;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int waitNumber = 0;
            if (waitNumber < 5)
            {
                mpspinner.Enabled = true;
                mpspinner.Visible = true;
                btnLogin.Visible = false;

            }
            else
            {
                timer1.Stop();
            }
            //TODO : burası bak Onur
            //for (int i = 0; i < 10; i++)
            //{
            //    mpspinner.Visible = true;
            //    btnLogin.Visible = false;
            //}

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
