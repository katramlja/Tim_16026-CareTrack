namespace CareTrack
{
    partial class PatientWindow
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
            this.bttnAnamneza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAnamneza
            // 
            this.bttnAnamneza.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAnamneza.Location = new System.Drawing.Point(22, 26);
            this.bttnAnamneza.Name = "bttnAnamneza";
            this.bttnAnamneza.Size = new System.Drawing.Size(122, 45);
            this.bttnAnamneza.TabIndex = 0;
            this.bttnAnamneza.Text = "Anamneza";
            this.bttnAnamneza.UseVisualStyleBackColor = true;
            this.bttnAnamneza.Click += new System.EventHandler(this.bttnAnamneza_Click);
            // 
            // PatientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 286);
            this.Controls.Add(this.bttnAnamneza);
            this.Name = "PatientWindow";
            this.Text = "PacijentiWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAnamneza;
    }
}