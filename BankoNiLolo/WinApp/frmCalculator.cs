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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            /**TODOS
             * 1. Declare 2 variables.. for val1 and val2
             * 2. Connect val1 to textbox1
             * 2.1 convert stringtype text to integer for val1
             * 3. Connect val2 to textbox2
             * 4. Create another variable for Total
             * 5. Show the Total in MessageBox.
             * 
             * */
           
            //this is how you declare variable in C#
            int val1, val2, total;

            //int.parse is how you convert string or any value to integer..

            val1 = int.Parse(txtVal1.Text);
            val2 = int.Parse(txtVal2.Text);

            total = val1 + val2;

            //to convert any value to string.
            //use .ToString() method
            MessageBox.Show(total.ToString());


        }
    }
}
