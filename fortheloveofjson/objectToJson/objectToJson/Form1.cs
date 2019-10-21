using System;
using System.Collections.Generic; //Responsible for List
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; //wag forget

namespace objectToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        List<Student> KuleksyonNgPasaway = new List<Student>();
        private void btnConvertTOJson_Click(object sender, EventArgs e)
        {
         
            Student studyantengPasaway = new Student();
            //how to generate random ekek
            studyantengPasaway.StudentID = txtStudentID.Text;
            studyantengPasaway.LastName = txtLastname.Text;
            studyantengPasaway.FirstName = txtFirstName.Text;

            KuleksyonNgPasaway.Add(studyantengPasaway);

            string studentToJson = JsonConvert.SerializeObject(KuleksyonNgPasaway);

            txtJsonResult.Text = studentToJson;


            //ListViewSettings/Property
            //- View = Detail

            //Adding To ListView
            ListViewItem lvi = new ListViewItem(txtStudentID.Text); //firstcolumn
            lvi.SubItems.Add(txtLastname.Text);//second and so on....
            lvi.SubItems.Add(txtFirstName.Text);

            //
            lstStudent.Items.Add(lvi); //listviewname

        }

        private void txtStudentID_Click(object sender, EventArgs e)
        {
            //Generate Whatever ID.
            txtStudentID.Text = Guid.NewGuid().ToString();
        }
    }
}
