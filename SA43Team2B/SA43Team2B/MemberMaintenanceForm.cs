using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SA43Team2B
{
    public partial class MemberMaintenanceForm : SA43Team2B.BaseForm
    {
        Sa43Team2bDBEntities context;
        List<Member> mList;
        Member m;
        int position;
        bool validName, validID, validPhone, validEmail, validAddress;

        public MemberMaintenanceForm()
        {
            InitializeComponent();
            context = new Sa43Team2bDBEntities();
            mList = context.Members.ToList();
            m = context.Members.First();
            position = 0;
            validName = true;
            validID = true;
            validPhone = true;
            validEmail = true;
            validAddress = true;
        }

        private void populateTextBoxes()
        {
            try
            {
                for (int i = 0; i < mList.Count; i++)
                {
                    if (mList[i].MemberID == Convert.ToInt16(txtSearch.Text))
                    {
                        position = i;
                        break;
                    }
                }

                if (mList[position].MemberType == "premium")
                {
                    radioPremiumType.Checked = true;

                }
                else
                {
                    radioRegularType.Checked = true;
                }

                txtMemberID.Text = mList[position].MemberID.ToString();
                txtMemberName.Text = mList[position].MemberName;
                txtPhone.Text = mList[position].MemberPhone;
                txtEmail.Text = mList[position].MemberEmail;
                txtAddress.Text = mList[position].MemberAddress;
            }

            catch (Exception)
            {
                validName = false;
                validID = false;
                validPhone = false;
                validEmail = false;
                validAddress = false;
            }
            
        }

        private void retrieveTextBoxes()
        {

            try
            {
                if (radioPremiumType.Checked == true)
                {
                    mList[position].MemberType = "premium";
                }
                else if (radioRegularType.Checked == true)
                {
                    mList[position].MemberType = "regular";
                }

                txtMemberID.Text = Convert.ToString(mList[position].MemberID);
                mList[position].MemberName = txtMemberName.Text;
                mList[position].MemberPhone = txtPhone.Text;
                mList[position].MemberEmail = txtEmail.Text;
                mList[position].MemberAddress = txtAddress.Text;
            }
            catch (Exception)
            {
                validName = false;
                validID = false;
                validPhone = false;
                validEmail = false;
                validAddress = false;
            }





        }

        private bool IsValidMemberName()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMemberName.Text))
                {
                    validName = false;

                }
            }
            catch (Exception)
            {
                validName = false;
            }

            return validName;
        }

        private bool IsValidMemberID()
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text) || string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    validID = false;
                }

                if (Regex.IsMatch(txtSearch.Text, @"(?i)^[a-z]+$"))
                {
                    validID = false;
                }
            }
            catch (Exception)
            {
                validID = false;
            }

            return validID;
        }
        private bool IsValidMemberPhone()
        {
            try
            {
                if (string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    validPhone = false;
                }

                if (Regex.IsMatch(txtPhone.Text, @"(?i)^[a-z]+$"))
                {
                    validPhone = false;
                }
            }
            catch (Exception)
            {
                validPhone = false;
            }

            return validPhone;
        }

        private bool IsValidMemberEmail()
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    validEmail = false;
                }

                if (Regex.IsMatch(txtEmail.Text, expresion))
                {
                    if (Regex.Replace(txtEmail.Text, expresion, string.Empty).Length == 0)
                    {
                        validEmail = true;
                    }
                    else
                    {
                        validEmail = false;
                    }
                }
                else
                {
                    validEmail = false;
                }
            }

            catch (Exception)
            {
                validEmail = false;
            }

            return validEmail;
        }

        private bool IsValidMemberAddress()
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    validAddress = false;
                }
            }
            catch (Exception)
            {
                validAddress = false;
            }

            return validAddress;
        }

        private void gridCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gridCustomerList.SelectedRows.Count > 0)
            {
                string vMemberID, vMemberName, vMemberType, vMemberPhone, vMemberEmail, vMemberAddress;

                vMemberID = gridCustomerList.CurrentRow.Cells[0].Value + string.Empty;
                vMemberName = gridCustomerList.CurrentRow.Cells[1].Value + string.Empty;
                vMemberType = gridCustomerList.CurrentRow.Cells[2].Value + string.Empty;
                vMemberPhone = gridCustomerList.CurrentRow.Cells[3].Value + string.Empty;
                vMemberEmail = gridCustomerList.CurrentRow.Cells[4].Value + string.Empty;
                vMemberAddress = gridCustomerList.CurrentRow.Cells[5].Value + string.Empty;

                txtMemberID.Text = vMemberID;
                txtMemberName.Text = vMemberName;
                txtPhone.Text = vMemberPhone;
                txtEmail.Text = vMemberEmail;
                txtAddress.Text = vMemberAddress;

                if (vMemberType == "regular")
                {
                    radioRegularType.Checked = true;

                }
                else if (vMemberType == "premium")
                {
                    radioPremiumType.Checked = true;
                }
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnInsert.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            position = mList.Count-1;

            m = new Member();

            IsValidMemberName();
            IsValidMemberPhone();
            IsValidMemberEmail();
            IsValidMemberAddress();

            if (radioPremiumType.Checked == true)
            {
                m.MemberType = "premium";
            }
            else if (radioRegularType.Checked == true)
            {
                m.MemberType = "regular";
            }

            if (validName == false || validPhone == false || validEmail == false || validAddress == false)
            {
                lblStatusStrip.Text = "Invalid Input! Please try again!";
            }
            else
            {
                m.MemberID = (mList[position].MemberID + 1);
                txtMemberID.Text = m.MemberID.ToString();
                m.MemberName = txtMemberName.Text;
                m.MemberPhone = txtPhone.Text;
                m.MemberEmail = txtEmail.Text;
                m.MemberAddress = txtAddress.Text;

                context.Members.Add(m);
                context.SaveChanges();
                lblStatusStrip.Text = "New member created!";
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            retrieveTextBoxes();

            IsValidMemberName();
            IsValidMemberPhone();
            IsValidMemberEmail();
            IsValidMemberAddress();

            
            if (validName == false || validPhone == false || validEmail == false || validAddress == false)
            {
                lblStatusStrip.Text = "Invalid Input! Please try again!";
            }
            else
            {
                if (radioPremiumType.Checked == true)
                {
                    m.MemberType = "premium";
                }
                else
                {
                    m.MemberType = "regular";
                }
                context.SaveChanges();
                lblStatusStrip.Text = "Member updated!";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(radioMemberID.Checked==true){
                for (int i = 0; i < mList.Count; i++)
                {
                    if (mList[i].MemberID == Convert.ToInt16(txtSearch.Text))
                    {
                        position = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < mList.Count; i++)
                {
                    if (mList[i].MemberName == txtSearch.Text)
                    {
                        position = i;
                        break;
                    }
                }
            }
            

            context.Members.Remove(mList[position]);
            context.SaveChanges();
            lblStatusStrip.Text = "Member deleted!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridCustomerList.DataSource = null;
            gridCustomerList.Rows.Clear();
            if (radioMemberID.Checked)
            {
                populateTextBoxes();
                IsValidMemberID();
                //lblStatusStrip.Text = "Member ID successfully selected!";
                
                if (validID == false)
                {
                    lblStatusStrip.Text = "Invalid Member ID! Please try again!";
                }
                else
                {
                    lblStatusStrip.Text = "";
                    var input = Convert.ToInt16(txtSearch.Text);
                    gridCustomerList.DataSource = context.Members.Where(x => x.MemberID == input).Select(x => new { x.MemberID, x.MemberName, x.MemberType, x.MemberPhone, x.MemberEmail, x.MemberAddress }).ToList();

                    DataGridViewColumn column = gridCustomerList.Columns[0];
                    column.Width = 20;

                    gridCustomerList.Columns[0].HeaderText = "ID";
                    gridCustomerList.Columns[1].HeaderText = "Name";
                    gridCustomerList.Columns[2].HeaderText = "Type";
                    gridCustomerList.Columns[3].HeaderText = "Phone";
                    gridCustomerList.Columns[4].HeaderText = "Email";
                    gridCustomerList.Columns[5].HeaderText = "Address";

                    lblStatusStrip.Text = "Member ID successfully selected!";
                    btnDelete.Enabled = true;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                }
                
            }
            else if(radioMemberName.Checked)
            {
                lblStatusStrip.Text = "";
                gridCustomerList.DataSource = context.Members.Where(x => x.MemberName.Contains(txtSearch.Text)).Select(x => new { x.MemberID, x.MemberName, x.MemberType, x.MemberPhone, x.MemberEmail, x.MemberAddress }).ToList();

                DataGridViewColumn column = gridCustomerList.Columns[0];
                column.Width = 20;

                gridCustomerList.Columns[0].HeaderText = "ID";
                gridCustomerList.Columns[1].HeaderText = "Name";
                gridCustomerList.Columns[2].HeaderText = "Type";
                gridCustomerList.Columns[3].HeaderText = "Phone";
                gridCustomerList.Columns[4].HeaderText = "Email";
                gridCustomerList.Columns[5].HeaderText = "Address";

                if (gridCustomerList.Rows.Count == 0)
                {
                    lblStatusStrip.Text = "No Results Found";
                }
                else
                {
                    lblStatusStrip.Text = "Search is Successful!";

                }
            }



        }

        private void MemberMaintenanceForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void clear()
        {
            txtMemberID.Text = "";
            txtMemberName.Text = "";
            txtPhone.Text = "";
            txtSearch.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            btnInsert.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
