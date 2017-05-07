using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Team2B
{
    
    public partial class LoginForm : Form
    {
        Sa43Team2bDBEntities context;
        List<UserMaster> userList;
        static string userName;

        public static string UserName
        {
            get
            {
                return userName;
            }

        }
        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            context = new Sa43Team2bDBEntities();
            userList = context.UserMasters.ToList();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
             try
            {
                UserMaster s = context.UserMasters.Where(x => txtEmployeeID.Text == x.EmployeeID).FirstOrDefault();
                if (s == null)
                {
                    MessageBox.Show("User Id Not Found");
                }
                else
                {
                    if (s.EmployeePassword == txtPassword.Text)
                    {
                        Employee m = context.Employees.Where(x => x.EmployeeID == s.EmployeeID).First();
                        userName = m.EmployeeName;
                        BookSearchForm bsf = new BookSearchForm();
                        this.Hide();
                        bsf.ShowDialog();
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("There is some issue with the system. Please restart or contact system administrator");
            }
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            if (txtEmployeeID.Text.Trim().Length > 0)
            {
                if (txtPassword.Text.Trim().Length > 0)
                {
                    btnLogin.Enabled = true;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtEmployeeID_TextChanged(sender, e);
        }

      
    }
}
