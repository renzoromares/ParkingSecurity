using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace ParkingSecurityAndManagement
{
    public partial class FrmRegister : Form
    {
        public bool isDone = false;
        public FrmRegister()
        {
            InitializeComponent();
        }



        private void FrmRegister_Load(object sender, EventArgs e)
        {
        }
        private void btnAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png; )| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtFaceImage.Text = open.FileName;
                    MessageBox.Show(txtFaceImage.Text);
                }
            }
            catch
            {
                MessageBox.Show("Invalid File!");
            }
        }
        private void btnAddFileOR_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOfficialReceipt.Text = open.FileName;
                    MessageBox.Show(txtOfficialReceipt.Text);
                }
            }
            catch
            {
                MessageBox.Show("Invalid File!");
            }
           
        }

        private void btnAddFileCR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "(*.jpg; *.jpeg; )| *.*.png;; *.jpeg; *.png;";
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtCR.Text = open.FileName;
                    MessageBox.Show(txtCR.Text);
                }
            }
            catch
            {
                MessageBox.Show("Invalid File!");
            }
            
        }

       

        private  void btnRegister_Click(object sender, EventArgs e)
        {

            save2Registration();
            save2Credential();
            MessageBox.Show("Registration Successful!");
            refresh();
            /*   bool checker = checkValidation();
               if(checker == true)
               {

               }
               else
               {
                   MessageBox.Show("Please complete the registration!");
               } */



        }

        private bool checkValidation()
        {

            bool isValidator = false;
            if(!string.Equals(txtIdNumber.Text,"ID Number") && !string.Equals(txtIdNumber.Text,""))
            {
                if (string.Equals(txtPassword.Text, txtConfirmPass.Text))
                {
                    if (!string.Equals(txtfname.Text, "First Name") && !string.Equals(txtfname.Text, ""))
                    {
                        if (!string.Equals(txtlname.Text, "Surname") && !string.Equals(txtlname.Text, ""))
                        {
                            if (!string.Equals(txtContact.Text, "Phone No.") && !string.Equals(txtContact.Text, ""))
                            {
                                if (!string.Equals(txtPlateNumber.Text, "Plate Number") && !string.Equals(txtPlateNumber.Text, ""))
                                {
                                    if (!string.Equals(txtDepartment.Text, "Department") && !string.Equals(txtDepartment.Text, ""))
                                    {
                                        if (cmbPosition.selectedIndex != -1)
                                        {
                                            if (cmbVehicleType.selectedIndex != -1)
                                            {
                                                if (!string.Equals(txtFaceImage.Text, "Face Image"))
                                                {
                                                    if (!string.Equals(txtOfficialReceipt.Text, "Official Receipt") && !string.Equals(txtOfficialReceipt.Text, ""))
                                                    {
                                                        if (!string.Equals(txtCR.Text, "Certificate of Registration"))
                                                        {
                                                            isValidator = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password don't match!");
                    isValidator = false;
                }
            }
            else
            {

                isValidator = false ;
               
            }
            return isValidator;
            
            
        }

        private void refresh()
        {
            txtIdNumber.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtDepartment.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            txtConfirmPass.Text = "";
            txtPlateNumber.Text = "";
            cmbPosition.selectedIndex = 0;
            cmbVehicleType.selectedIndex = 0;
            txtFaceImage.Text = "";
            txtOfficialReceipt.Text = "";
            txtCR.Text = "";
        }

        private void save2Registration()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE_OWNER VALUES(@Id_Number," +
                                                                                        "@FirstName," +
                                                                                        "@LastName," +
                                                                                        "@Position," +
                                                                                        "@Contacts," +
                                                                                        "@Department," +
                                                                                        "@Password)", conn))
                {

                    int id = Convert.ToInt32(txtIdNumber.Text);

                    cmd.Parameters.AddWithValue("@Id_Number", id);
                    cmd.Parameters.AddWithValue("@FirstName", txtfname.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtlname.Text) ;
                    cmd.Parameters.AddWithValue("@Position", cmbPosition.selectedValue.ToString()); ;
                    cmd.Parameters.AddWithValue("@Contacts", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   
                }
            }
            
        }

        private void save2Credential()
        {
            
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CREDENTIALS VALUES(@PlateNumber," +
                                                           "@Vehicle_Type," +
                                                           "@Official_Receipt," +
                                                           "@Cert_Registration," +
                                                           "@Face_Image," +
                                                           "@Status," +
                                                           "@Id_Number)", conn))
                {
                    conn.Open();

                    int id = Convert.ToInt32(txtIdNumber.Text);

                    byte[] img = null;
                    FileStream fs = new FileStream(txtFaceImage.Text.ToString(), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    byte[] img1 = null;
                    FileStream fs1 = new FileStream(txtOfficialReceipt.Text.ToString(), FileMode.Open, FileAccess.Read);
                    BinaryReader br1 = new BinaryReader(fs1);
                    img1 = br1.ReadBytes((int)fs1.Length);


                    byte[] img2 = null;
                    FileStream fs2 = new FileStream(txtOfficialReceipt.Text.ToString(), FileMode.Open, FileAccess.Read);
                    BinaryReader br2 = new BinaryReader(fs2);
                    img2 = br2.ReadBytes((int)fs2.Length);

                

                    cmd.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Vehicle_Type", cmbVehicleType.selectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Official_Receipt", img1);
                    cmd.Parameters.AddWithValue("@Cert_Registration", img2);
                    cmd.Parameters.AddWithValue("@Face_Image", img);
                    cmd.Parameters.AddWithValue("@Status", 0);
                    cmd.Parameters.AddWithValue("@Id_Number", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void offline()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))

            {

               try
               {
                    conn.Open(); 
                    
                    byte[] img = null;
                    FileStream fs = new FileStream(txtFaceImage.Text.ToString(), FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string query = "INSERT INTO TEST VALUES(@Id_Number," +
                                                           "@Face)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id_Number",2);
                        cmd.Parameters.AddWithValue("@Face", img);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Saved!");
                    }
               }

               catch
               {
                    MessageBox.Show("ERROR");
                    conn.Close();
               }
               
            }
        }


        private void txtIdNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtConfirmPass.isPassword = true;
        }

        /* Renzo Romares C++\C# Developer  */
    }
}
