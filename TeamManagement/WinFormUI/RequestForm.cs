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
    public partial class RequestForm : MetroFramework.Forms.MetroForm
    {
        //TODO: Yarım kaldı buraya bakılacak.

        RequestBusiness _requestBLL;
        ProjectBusiness _projectBLL;

        int selectedID;

        public RequestForm()
        {
            InitializeComponent();
            _requestBLL = new RequestBusiness(LoginForm.EmployeeId());
            _projectBLL = new ProjectBusiness(LoginForm.EmployeeId());

        }
        private void RequestForm_Load(object sender, EventArgs e)
        {
            RefleshGridRequest();

            //Combobox'a Projeisimlerini gönderir.
            ProjectBusiness _project = new ProjectBusiness(LoginForm.EmployeeId());
            cmbProjectName.DataSource = _project.GetAll();
            cmbProjectName.ValueMember = "ID";
            cmbProjectName.DisplayMember = "Name";

        }

        public void RefleshGridRequest()
        {
            try
            {
                ICollection<Request> requestList = _requestBLL.GetAll();
                dgvRequestList.DataSource = null;
                dgvRequestList.DataSource = requestList;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Request newRequest = new Request();

                newRequest.Type = txtRequestType.Text;
                newRequest.Description = txtDescription.Text;

                if (cmbProjectName.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Her Talep'in bir Projesi olmak zorundadır.Lütfen bir Proje Seçiniz  ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    foreach (Project item in _projectBLL.GetAll())
                    {
                        if (cmbProjectName.SelectedValue.ToString() == item.ID.ToString())
                        {
                            newRequest.ProjectId = item.ID;

                            
                            Project projectEntity = _projectBLL.Get(item.ID);
                            newRequest.Project = projectEntity;
                        }
                    }
                    _requestBLL.Add(newRequest);
                }
               
                RefleshGridRequest();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Request deleteRequest = null;
                deleteRequest = _requestBLL.Get(selectedID);
                selectedID = 0;
                _requestBLL.Remove(deleteRequest);
                RefleshGridRequest();
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
                Request updateRequest = null;
                updateRequest = _requestBLL.Get(selectedID);
                updateRequest.Type = txtRequestType.Text;
                updateRequest.Description = txtDescription.Text;
                if (cmbProjectName.SelectedValue == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Her Talep'in bir Projesi olmak zorundadır.Lütfen bir Proje Seçiniz  ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    foreach (Project item in _projectBLL.GetAll())
                    {
                        if (cmbProjectName.SelectedValue.ToString() == item.ID.ToString())
                        {
                            updateRequest.ProjectId = item.ID;

                            Project projectEntity = _projectBLL.Get(item.ID);
                            updateRequest.Project = projectEntity;
                        }
                    }
                    _requestBLL.Update(updateRequest);
                }
 
                RefleshGridRequest();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void dgvRequestList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvRequestList.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgvRequestList.SelectedRows[0];
                    string updateIdInput = dr.Cells[0].Value.ToString();
                    selectedID = int.Parse(updateIdInput);
                    Request selectRequest = _requestBLL.Get(selectedID);
                    txtRequestType.Text = selectRequest.Type;
                    txtDescription.Text = selectRequest.Description;                
                    cmbProjectName.SelectedValue = (int)selectRequest.ProjectId;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
