using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ParkingSecurityAndManagement
{
    public partial class FrmSearchAccount : Form
    {
        public FrmSearchAccount()
        {
            InitializeComponent();
        }

        private void FrmSearchAccount_Load(object sender, EventArgs e)
        {

        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await searchOwner();
        }

        private async Task searchOwner()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {

                try
                {
                    await conn.OpenAsync();
                    string query = "SELECT VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",VEHICLE_OWNER.Department" +
                                         ",CREDENTIALS.Vehicle_Type" +
                                         ",CREDENTIALS.PlateNumber" +
                                         ",CREDENTIALS.Face_Image " +
                                         "FROM VEHICLE_OWNER INNER JOIN CREDENTIALS ON VEHICLE_OWNER.Id_Number = CREDENTIALS.Id_Number " +
                                         "WHERE VEHICLE_OWNER.Id_Number = '"+txtId_Number.Text+"' ";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            await Task.Delay(100);
                            while (reader.Read())
                            {

                                pnlContainer.Visible = true;
                                pnlfooter.Visible = true;
                                lblIdNumber.Text = reader.GetValue(0).ToString();
                                lblName.Text = reader.GetValue(1) + " " + reader.GetValue(2);
                                lblPosition.Text = reader.GetValue(3).ToString();
                                lblDepartment.Text = reader.GetValue(4).ToString();
                                lblVehicleType.Text = reader.GetValue(5).ToString();
                                lblPlatenumber.Text = reader.GetValue(6).ToString();

                                byte[] img = (byte[])(reader[7]);
                                if (img == null)
                                {
                                    pictureBox1.Image = null;
                                }
                                else
                                {
                                    MemoryStream ms = new MemoryStream(img);
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Id Number does not exist!");
                         
                        }
                        conn.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                    
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

        }

        private void pnlfooter_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlContainer.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
    }
}
