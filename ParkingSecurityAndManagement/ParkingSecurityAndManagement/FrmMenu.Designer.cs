namespace ParkingSecurityAndManagement
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnAddAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearchAcc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecords = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.pnlSide.Controls.Add(this.btnAddAccount);
            this.pnlSide.Controls.Add(this.lblStatus);
            this.pnlSide.Controls.Add(this.pictureBox1);
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Controls.Add(this.btnSearchAcc);
            this.pnlSide.Controls.Add(this.btnRecords);
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(171, 570);
            this.pnlSide.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccount.BorderRadius = 0;
            this.btnAddAccount.ButtonText = "Add Account";
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Iconimage")));
            this.btnAddAccount.Iconimage_right = null;
            this.btnAddAccount.Iconimage_right_Selected = null;
            this.btnAddAccount.Iconimage_Selected = null;
            this.btnAddAccount.IconMarginLeft = 0;
            this.btnAddAccount.IconMarginRight = 0;
            this.btnAddAccount.IconRightVisible = true;
            this.btnAddAccount.IconRightZoom = 0D;
            this.btnAddAccount.IconVisible = true;
            this.btnAddAccount.IconZoom = 50D;
            this.btnAddAccount.IsTab = false;
            this.btnAddAccount.Location = new System.Drawing.Point(2, 179);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnAddAccount.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddAccount.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnAddAccount.selected = false;
            this.btnAddAccount.Size = new System.Drawing.Size(170, 59);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAccount.Textcolor = System.Drawing.Color.Linen;
            this.btnAddAccount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(40, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Security Guard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 0;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 50D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(1, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(169, 59);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.Color.Linen;
            this.btnLogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchAcc
            // 
            this.btnSearchAcc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnSearchAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSearchAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAcc.BorderRadius = 0;
            this.btnSearchAcc.ButtonText = "Search Account";
            this.btnSearchAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAcc.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchAcc.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchAcc.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchAcc.Iconimage")));
            this.btnSearchAcc.Iconimage_right = null;
            this.btnSearchAcc.Iconimage_right_Selected = null;
            this.btnSearchAcc.Iconimage_Selected = null;
            this.btnSearchAcc.IconMarginLeft = 0;
            this.btnSearchAcc.IconMarginRight = 0;
            this.btnSearchAcc.IconRightVisible = true;
            this.btnSearchAcc.IconRightZoom = 0D;
            this.btnSearchAcc.IconVisible = true;
            this.btnSearchAcc.IconZoom = 50D;
            this.btnSearchAcc.IsTab = false;
            this.btnSearchAcc.Location = new System.Drawing.Point(1, 309);
            this.btnSearchAcc.Name = "btnSearchAcc";
            this.btnSearchAcc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnSearchAcc.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSearchAcc.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnSearchAcc.selected = false;
            this.btnSearchAcc.Size = new System.Drawing.Size(170, 59);
            this.btnSearchAcc.TabIndex = 3;
            this.btnSearchAcc.Text = "Search Account";
            this.btnSearchAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchAcc.Textcolor = System.Drawing.Color.Linen;
            this.btnSearchAcc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAcc.Click += new System.EventHandler(this.btnSearchAcc_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(49)))));
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecords.BorderRadius = 0;
            this.btnRecords.ButtonText = "Records";
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecords.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecords.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecords.Iconimage")));
            this.btnRecords.Iconimage_right = null;
            this.btnRecords.Iconimage_right_Selected = null;
            this.btnRecords.Iconimage_Selected = null;
            this.btnRecords.IconMarginLeft = 0;
            this.btnRecords.IconMarginRight = 0;
            this.btnRecords.IconRightVisible = true;
            this.btnRecords.IconRightZoom = 0D;
            this.btnRecords.IconVisible = true;
            this.btnRecords.IconZoom = 50D;
            this.btnRecords.IsTab = false;
            this.btnRecords.Location = new System.Drawing.Point(2, 244);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(15)))));
            this.btnRecords.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRecords.OnHoverTextColor = System.Drawing.Color.Yellow;
            this.btnRecords.selected = false;
            this.btnRecords.Size = new System.Drawing.Size(168, 59);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecords.Textcolor = System.Drawing.Color.Linen;
            this.btnRecords.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(178, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(771, 537);
            this.mainPanel.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.mainPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 569);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchAcc;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAccount;
        public System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

