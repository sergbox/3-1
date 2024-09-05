using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_1.DBContext;

namespace _3_1
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }
        Model1 model = new Model1();

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            bindingSourceRole.DataSource = model.Roles.ToList();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
RegexOptions.IgnoreCase);
            if (!reg.IsMatch(emailtextbox.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!passwordtextbox.Text.Equals(passwordtextbox2.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(logintextbox.Text) ||
            String.IsNullOrWhiteSpace(passwordtextbox.Text) ||
            String.IsNullOrWhiteSpace(first_nametextbox.Text) ||
            String.IsNullOrWhiteSpace(second_nametextbox.Text) ||
            !phonemaskedtextbox.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Заполнение данных о новом пользователе
            Users users = new Users();
            users.ID = 0;
            users.Login = logintextbox.Text;
            users.Password = passwordtextbox.Text;
            users.Email = emailtextbox.Text;
            users.Phone = phonemaskedtextbox.Text;
            users.First_Name = first_nametextbox.Text;
            users.Second_Name = second_nametextbox.Text;
            users.RoleID = (int)roleidcombobox.SelectedValue;
            users.Gender = radioButtonmen.Checked ? "Мужской" : "Женский";
            try
            {
                //сохранение данных в БД
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавленны!");
            Close();

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
