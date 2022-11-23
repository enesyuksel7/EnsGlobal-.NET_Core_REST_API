using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http;
using Entities.Dtos.UserDtos;
using Entities.Enums;
using Business.Concrete;
using Business.Abstract;

namespace WebAPIWithWindowsForm
{
    public partial class Form1 : Form
    {
        #region Defines

        private string apiURL = "http://localhost:22421/api/";
        private int selectedID = 0;
        HttpClient httpClient = new HttpClient();
        UserAddDto userAddDto = new UserAddDto();

        private class Gender
        {
            public int Id { get; set; }
            public string GenderName { get; set; }
        }

        #endregion Defines

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DataGirdViewFill();
            CmbGenderFill();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        #region Methods
        private async Task DataGirdViewFill()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var kayitlar = await httpClient.GetFromJsonAsync<List<UserDetailDto>>(apiURL + "Users/GetList");
                dataGridView1.DataSource = kayitlar;
                //richTextBox1.Text = kayitlar.ToString();
            }
        }

        void ClearForm()
        {
            txtFirstName.Text = txtLastName.Text = txtUserName.Text = txtPassword.Text = txtEmail.Text = String.Empty;
            txtPhoneNumber.Text = txtCardLimit.Text = "";
            comboBox1.SelectedValue = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (HttpClient httpClient = new HttpClient())
            {
                var user = await httpClient.GetFromJsonAsync<UserDto>(apiURL + "Users/GetById/" + selectedID);

                txtPhoneNumber.Text = user.PhoneNumber.ToString();
                txtCardLimit.Text = user.CardLimit.ToString();
                comboBox1.SelectedValue = user.Gender == true ? 1 : 2;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtUserName.Text = user.UserName;
                txtEmail.Text = user.Email;
                txtPassword.Text = String.Empty;
                dateTimePicker1.Value = user.DateOfBirth;
            }
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void CmbGenderFill()
        {
            List<Gender> genders = new List<Gender>();
            genders.Add(new Gender() { Id = 1, GenderName = "Erkek" });
            genders.Add(new Gender() { Id = 2, GenderName = "Kadın" });
            comboBox1.DataSource = genders;
            comboBox1.DisplayMember = "GenderName";
            comboBox1.ValueMember = "Id";
        }

        #endregion Methods

        #region Crud

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            await DataGirdViewFill();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                UserAddDto userAddDto = new UserAddDto()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Gender = comboBox1.Text == "Erkek" ? true : false,
                    DateOfBirth = dateTimePicker1.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text),
                    CardLimit = float.Parse(txtCardLimit.Text)
                };
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(apiURL + "Users/Add", userAddDto);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ekleme işlemi başarılı!");
                    await DataGirdViewFill();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi başarısız!");
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                UserUpdateDto userUpdateDto = new UserUpdateDto()
                {
                    Id = selectedID,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Gender = comboBox1.Text == "Erkek" ? true : false,
                    DateOfBirth = dateTimePicker1.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text),
                    CardLimit = float.Parse(txtCardLimit.Text)
                };
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(apiURL + "Users/Update", userUpdateDto);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Düzenleme işlemi başarılı!");
                    await DataGirdViewFill();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Düzenleme işlemi başarısız!");
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                
                HttpResponseMessage response = await httpClient.DeleteAsync(apiURL + "Users/Delete/" +selectedID);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Silme işlemi başarılı!");
                    await DataGirdViewFill();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız!");
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Crud End
    }
}