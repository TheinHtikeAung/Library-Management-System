using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Team08B_LibraryManagementSystem
{
    public partial class frmMember : Form
    {
        LibraryEntities context;
        MemberController MC = new MemberController();
       
        public frmMember()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            context = new LibraryEntities();
            FirstName.DataBindings.Add("Text", context.Members, "FirstName");

            LastName.DataBindings.Add("Text", context.Members, "LastName");

            MemberID.DataBindings.Add("Text", context.Members, "MemberID");

            Email.DataBindings.Add("Text", context.Members, "Email");

            PhoneNo.DataBindings.Add("Text", context.Members, "PhoneNo");

            Address.DataBindings.Add("Text", context.Members, "Address");
            dataGridView1.DataSource=context.Members;
            

           }

        private void btnAdd_Click(object sender, EventArgs e)   
        {

            BindingContext[context.Members].AddNew();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (this.FirstName.Text == string.Empty)                     //  Empty Check
            {
                MessageBox.Show("Please Enter Your First Name");
                return;
            }

             if (this.LastName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Last Name");
                return;
            }

             if (this.Email.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Email ");
                return;
            }

             if (this.Address.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Address");
                return;
            }

             if (this.PhoneNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Phone No.");
                return;
            }


             if (!MC.IsEnglishletters(this.FirstName.Text))// Using bool for First Name Check
             {

                 MessageBox.Show("Please Enter English Letters");
                 return;

             }
             if (!MC.IsEnglishletters(this.LastName.Text))// Using bool for Last Name Check
             {

                 MessageBox.Show("Please Enter English Letters");
                 return;

             }

            if (!MC.IsNumeric(this.PhoneNo.Text))      //   Using bool for PhoneNo. Check
            {
                MessageBox.Show("Please Type Numbers as Your PhoneNo.");
                return;
            }

            int index = Email.Text.IndexOf("@");    //   Email Address should include "@"
            if (index < 1)
            {
                MessageBox.Show("Wrong Email Address");
                return;
            }

 

            BindingContext[context.Members].EndCurrentEdit();

            context.SaveChanges();
            MessageBox.Show("Successfully Update !");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure To Delete", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
 
            {
                try
                {
                    BindingContext[context.Members].RemoveAt(BindingContext[context.Members].Position);

                    context.SaveChanges();
                }catch(Exception ea)
                {
                    MessageBox.Show("You can't delete this record because of security issue.");
                }
            }
            else
            {
                return;
            }
                       
        }
        //Deleate Botton -  Comfirm Message Box

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memberReport fr = new memberReport();
            fr.ShowDialog();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Add(object sender, EventArgs e)
        {
            context = new LibraryEntities();
            FirstName.DataBindings.Add("Text", context.Members, "FirstName");

            LastName.DataBindings.Add("Text", context.Members, "LastName");

            MemberID.DataBindings.Add("Text", context.Members, "MemberID");

            Email.DataBindings.Add("Text", context.Members, "Email");

            PhoneNo.DataBindings.Add("Text", context.Members, "PhoneNo");

            Address.DataBindings.Add("Text", context.Members, "Address");
            dataGridView1.DataSource = context.Members;
            dataGridView1.Refresh();
        }

        
        
    }
}
