using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            BankAccount mb = new BankAccount();

            if(MessageBox.Show("Are you Sure?", "Bank", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
         
        }

        private void labelAge_Click(object sender, EventArgs e)
        {
            //TODOS
            //Call the Dialog form
            //when the user click OK it will compute the year value from textbox
            //then return that value in "Age" Label in frmRegister
            frmDialogBirthday getBdayForm = new frmDialogBirthday();

            //to get age use.. Current Year - BirthYear.
            DateTime theCalendar = DateTime.Today;
            int currentYear = int.Parse(theCalendar.ToString("yyyy"));

            if(getBdayForm.ShowDialog() == DialogResult.OK)
            {
                int birthYear = int.Parse(getBdayForm.txtBirthday.Text);
                int Edad = currentYear - birthYear;
                labelAge.Text = Edad.ToString() + " years old.";
            }

        }
    }
}
