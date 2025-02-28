namespace KeksKlicker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IblFehler = new System.Windows.Forms.Label();
            this.btnAnmelden = new System.Windows.Forms.Button();
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.btnRegestrieren = new System.Windows.Forms.Button();
            this.IblRegestriert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // IblFehler
            // 
            this.IblFehler.AutoSize = true;
            this.IblFehler.Location = new System.Drawing.Point(345, 212);
            this.IblFehler.MaximumSize = new System.Drawing.Size(120, 0);
            this.IblFehler.Name = "IblFehler";
            this.IblFehler.Size = new System.Drawing.Size(97, 65);
            this.IblFehler.TabIndex = 2;
            this.IblFehler.Text = "Passwort oder Benutzername ist falsch.\r\nHast du dich denn schon regestriert?";
            this.IblFehler.Visible = false;
            // 
            // btnAnmelden
            // 
            this.btnAnmelden.Location = new System.Drawing.Point(261, 212);
            this.btnAnmelden.Name = "btnAnmelden";
            this.btnAnmelden.Size = new System.Drawing.Size(75, 23);
            this.btnAnmelden.TabIndex = 3;
            this.btnAnmelden.Text = "Anmelden";
            this.btnAnmelden.UseVisualStyleBackColor = true;
            this.btnAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Location = new System.Drawing.Point(348, 163);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(100, 20);
            this.txtBenutzername.TabIndex = 4;
            this.txtBenutzername.TextChanged += new System.EventHandler(this.txtBenutzername_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(348, 189);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = 'X';
            this.txtPasswort.Size = new System.Drawing.Size(100, 20);
            this.txtPasswort.TabIndex = 5;
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // btnRegestrieren
            // 
            this.btnRegestrieren.Location = new System.Drawing.Point(457, 212);
            this.btnRegestrieren.Name = "btnRegestrieren";
            this.btnRegestrieren.Size = new System.Drawing.Size(75, 23);
            this.btnRegestrieren.TabIndex = 6;
            this.btnRegestrieren.Text = "Regestrieren";
            this.btnRegestrieren.UseVisualStyleBackColor = true;
            this.btnRegestrieren.Click += new System.EventHandler(this.btnRegestrieren_Click);
            // 
            // IblRegestriert
            // 
            this.IblRegestriert.AutoSize = true;
            this.IblRegestriert.Location = new System.Drawing.Point(454, 163);
            this.IblRegestriert.Name = "IblRegestriert";
            this.IblRegestriert.Size = new System.Drawing.Size(195, 26);
            this.IblRegestriert.TabIndex = 7;
            this.IblRegestriert.Text = "Dieser Benutzer ist bereits regestriert.\r\nVersuche es mit einem anderen Namen.";
            this.IblRegestriert.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IblRegestriert);
            this.Controls.Add(this.btnRegestrieren);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtBenutzername);
            this.Controls.Add(this.btnAnmelden);
            this.Controls.Add(this.IblFehler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IblFehler;
        private System.Windows.Forms.Button btnAnmelden;
        private System.Windows.Forms.TextBox txtBenutzername;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Button btnRegestrieren;
        private System.Windows.Forms.Label IblRegestriert;
    }
}

