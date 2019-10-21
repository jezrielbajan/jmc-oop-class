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
using System.Security.Cryptography;
using System.IO;

namespace objectToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creepy
        public const string PASSWORD_HASH = "eAp@$$w!";
        public const string ASIN_KEY = "EaS1tK3y";
        public const string VI_KEY = "@1B2c3D4e5F6g7H8";


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

        private void txtLastname_Click(object sender, EventArgs e)
        {   
            txtLastname.Text = this.Encrypt(txtLastname.Text);
        }

        private void txtLastname_DoubleClick(object sender, EventArgs e)
        {
            txtLastname.Text = this.Decrypt(txtLastname.Text);
        }


        public string Encrypt(string clearText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(clearText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PASSWORD_HASH, Encoding.ASCII.GetBytes(ASIN_KEY)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VI_KEY));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    //cryptoStream.Close();
                }
                // memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }


        public string Decrypt(string cipherText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PASSWORD_HASH, Encoding.ASCII.GetBytes(ASIN_KEY)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VI_KEY));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            //memoryStream.Close();
            //cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Decrypt(txtLastname.Text));
        }
    }
}
