namespace ParkingSecurityAndManagement
{
    partial class FrmSearchAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId_Number = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVehicleType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPlatenumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPosition = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIdNumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDepartment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId_Number
            // 
            this.txtId_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId_Number.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId_Number.HintForeColor = System.Drawing.Color.Empty;
            this.txtId_Number.HintText = "Search Plate Number";
            this.txtId_Number.isPassword = false;
            this.txtId_Number.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtId_Number.LineIdleColor = System.Drawing.Color.Gray;
            this.txtId_Number.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.txtId_Number.LineThickness = 3;
            this.txtId_Number.Location = new System.Drawing.Point(29, 36);
            this.txtId_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Number.Name = "txtId_Number";
            this.txtId_Number.Size = new System.Drawing.Size(255, 44);
            this.txtId_Number.TabIndex = 4;
            this.txtId_Number.TabStop = false;
            this.txtId_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Silver;
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 2;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(291, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(92, 29);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.pnlfooter);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.pictureBox1);
            this.pnlContainer.Location = new System.Drawing.Point(216, 99);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(321, 413);
            this.pnlContainer.TabIndex = 20;
            this.pnlContainer.Visible = false;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.pnlfooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlfooter.Location = new System.Drawing.Point(-1, 370);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(321, 42);
            this.pnlfooter.TabIndex = 21;
            this.pnlfooter.Visible = false;
            this.pnlfooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfooter_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVehicleType);
            this.panel2.Controls.Add(this.lbl6);
            this.panel2.Controls.Add(this.lblPlatenumber);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Controls.Add(this.lblPosition);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lblIdNumber);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblDepartment);
            this.panel2.Location = new System.Drawing.Point(25, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 217);
            this.panel2.TabIndex = 21;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(116, 170);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(46, 17);
            this.lblVehicleType.TabIndex = 28;
            this.lblVehicleType.Text = "Motor";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(16, 170);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(95, 17);
            this.lbl6.TabIndex = 27;
            this.lbl6.Text = "Vehicle Type: ";
            // 
            // lblPlatenumber
            // 
            this.lblPlatenumber.AutoSize = true;
            this.lblPlatenumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatenumber.Location = new System.Drawing.Point(127, 142);
            this.lblPlatenumber.Name = "lblPlatenumber";
            this.lblPlatenumber.Size = new System.Drawing.Size(54, 17);
            this.lblPlatenumber.TabIndex = 26;
            this.lblPlatenumber.Text = "MNO11";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(16, 142);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(105, 17);
            this.lbl5.TabIndex = 25;
            this.lbl5.Text = "Plate Number: ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(84, 85);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(53, 17);
            this.lblPosition.TabIndex = 24;
            this.lblPosition.Text = "Faculty";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 17);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "ID Number: ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(16, 85);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 17);
            this.lbl3.TabIndex = 23;
            this.lbl3.Text = "Position:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(16, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 17);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Name: ";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNumber.Location = new System.Drawing.Point(107, 29);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(78, 17);
            this.lblIdNumber.TabIndex = 22;
            this.lblIdNumber.Text = "2016019590";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(16, 115);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(91, 17);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "Department:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(78, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Renzo Romares";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(113, 115);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(154, 17);
            this.lblDepartment.TabIndex = 20;
            this.lblDepartment.Text = "Computer Engineering";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSearchAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId_Number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSearchAccount";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmSearchAccount_Load);
            this.pnlContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId_Number;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Panel pnlContainer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDepartment;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl4;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPosition;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIdNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVehicleType;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl6;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPlatenumber;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl5;
        private System.Windows.Forms.Panel pnlfooter;
    }
}