namespace CareTrack
{
    partial class MainScreen
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
            this.bttnAdministrator = new System.Windows.Forms.Button();
            this.bttnPacijenti = new System.Windows.Forms.Button();
            this.bttnPomoć = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAdministrator
            // 
            this.bttnAdministrator.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAdministrator.Location = new System.Drawing.Point(35, 39);
            this.bttnAdministrator.Name = "bttnAdministrator";
            this.bttnAdministrator.Size = new System.Drawing.Size(196, 90);
            this.bttnAdministrator.TabIndex = 0;
            this.bttnAdministrator.Text = "Administrator";
            this.bttnAdministrator.UseVisualStyleBackColor = true;
            this.bttnAdministrator.Click += new System.EventHandler(this.bttnAdministrator_Click);
            // 
            // bttnPacijenti
            // 
            this.bttnPacijenti.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPacijenti.Location = new System.Drawing.Point(328, 39);
            this.bttnPacijenti.Name = "bttnPacijenti";
            this.bttnPacijenti.Size = new System.Drawing.Size(196, 90);
            this.bttnPacijenti.TabIndex = 1;
            this.bttnPacijenti.Text = "Pacijenti";
            this.bttnPacijenti.UseVisualStyleBackColor = true;
            this.bttnPacijenti.Click += new System.EventHandler(this.bttnPacijenti_Click);
            // 
            // bttnPomoć
            // 
            this.bttnPomoć.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPomoć.Location = new System.Drawing.Point(35, 163);
            this.bttnPomoć.Name = "bttnPomoć";
            this.bttnPomoć.Size = new System.Drawing.Size(196, 90);
            this.bttnPomoć.TabIndex = 2;
            this.bttnPomoć.Text = "Podrška";
            this.bttnPomoć.UseVisualStyleBackColor = true;
            this.bttnPomoć.Click += new System.EventHandler(this.bttnPomoć_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 90);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogOut.Location = new System.Drawing.Point(414, 273);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(109, 35);
            this.bttnLogOut.TabIndex = 4;
            this.bttnLogOut.Text = "Odjava";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(586, 317);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bttnPomoć);
            this.Controls.Add(this.bttnPacijenti);
            this.Controls.Add(this.bttnAdministrator);
            this.Name = "MainScreen";
            this.Text = "Care Track";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAdministrator;
        private System.Windows.Forms.Button bttnPacijenti;
        private System.Windows.Forms.Button bttnPomoć;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttnLogOut;
    }
}