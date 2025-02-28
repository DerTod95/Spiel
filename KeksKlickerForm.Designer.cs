namespace KeksKlicker
{
    partial class KeksKlickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeksKlickerForm));
            this.pcbKeks = new System.Windows.Forms.PictureBox();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblKekse = new System.Windows.Forms.Label();
            this.libUpgrades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbKeks
            // 
            this.pcbKeks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbKeks.BackColor = System.Drawing.Color.Transparent;
            this.pcbKeks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbKeks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbKeks.Image = ((System.Drawing.Image)(resources.GetObject("pcbKeks.Image")));
            this.pcbKeks.InitialImage = ((System.Drawing.Image)(resources.GetObject("pcbKeks.InitialImage")));
            this.pcbKeks.Location = new System.Drawing.Point(284, 242);
            this.pcbKeks.Name = "pcbKeks";
            this.pcbKeks.Size = new System.Drawing.Size(120, 106);
            this.pcbKeks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKeks.TabIndex = 0;
            this.pcbKeks.TabStop = false;
            this.pcbKeks.WaitOnLoad = true;
            this.pcbKeks.Click += new System.EventHandler(this.pcbKeks_Click_1);
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.BackColor = System.Drawing.Color.Transparent;
            this.lblBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzername.Location = new System.Drawing.Point(67, 12);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(35, 13);
            this.lblBenutzername.TabIndex = 2;
            this.lblBenutzername.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblKekse
            // 
            this.lblKekse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKekse.AutoSize = true;
            this.lblKekse.BackColor = System.Drawing.Color.SandyBrown;
            this.lblKekse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKekse.Location = new System.Drawing.Point(8, 592);
            this.lblKekse.Name = "lblKekse";
            this.lblKekse.Size = new System.Drawing.Size(70, 20);
            this.lblKekse.TabIndex = 4;
            this.lblKekse.Text = "Kekse: 0";
            // 
            // libUpgrades
            // 
            this.libUpgrades.BackColor = System.Drawing.Color.SandyBrown;
            this.libUpgrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.libUpgrades.Dock = System.Windows.Forms.DockStyle.Right;
            this.libUpgrades.FormattingEnabled = true;
            this.libUpgrades.Location = new System.Drawing.Point(563, 0);
            this.libUpgrades.Name = "libUpgrades";
            this.libUpgrades.Size = new System.Drawing.Size(121, 621);
            this.libUpgrades.TabIndex = 5;
            this.libUpgrades.SelectedIndexChanged += new System.EventHandler(this.libUpgrades_SelectedIndexChanged);
            // 
            // KeksKlickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 621);
            this.Controls.Add(this.libUpgrades);
            this.Controls.Add(this.lblKekse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.pcbKeks);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeksKlickerForm";
            this.Text = "KeksKlickerForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcbKeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbKeks;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblKekse;
        private System.Windows.Forms.ListBox libUpgrades;
    }
}