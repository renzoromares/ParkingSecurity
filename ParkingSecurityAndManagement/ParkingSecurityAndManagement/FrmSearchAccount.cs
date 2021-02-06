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
                    string query = "SELECT VEHICLE_OWNER.PlateID" +
                                         ",VEHICLE_OWNER.Id_Number" +
                                         ",VEHICLE_OWNER.FirstName" +
                                         ",VEHICLE_OWNER.LastName" +
                                         ",VEHICLE_OWNER.Position" +
                                         ",VEHICLE_OWNER.Department" +
                                         ",CREDENTIALS.Vehicle_Type" +
                                         ",CREDENTIALS.Vehicle_Model" +
                                         ",CREDENTIALS.Vehicle_Carmake" +
                                         ",CREDENTIALS.Vehicle_Color" +
                                         ",CREDENTIALS.Face_Image " +
                                         "FROM VEHICLE_OWNER INNER JOIN CREDENTIALS ON VEHICLE_OWNER.PlateID = CREDENTIALS.PlateID " +
                                         "WHERE VEHICLE_OWNER.PlateID = '"+txtPlateNumber.Text+"' ";


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

                                lblPlatenumber.Text = reader.GetValue(0).ToString();
                                lblIdNumber.Text = reader.GetValue(1).ToString();
                                lblName.Text = reader.GetValue(2) + " " + reader.GetValue(3);
                                lblPosition.Text = reader.GetValue(4).ToString();
                                lblDepartment.Text = reader.GetValue(5).ToString();
                                lblVehicleType.Text = reader.GetValue(6).ToString();
                                lblVehicleModel.Text = reader.GetValue(7).ToString();
                                lblCarmake.Text = reader.GetValue(8).ToString();
                                lblVehicleColor.Text = reader.GetValue(9).ToString();
                                

                                byte[] img = (byte[])(reader[10]);
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
