namespace PV_Olsbro_2024
{
    partial class UCkurzycs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKurzy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKurzy
            // 
            this.labelKurzy.AutoSize = true;
            this.labelKurzy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKurzy.Location = new System.Drawing.Point(30, 31);
            this.labelKurzy.Name = "labelKurzy";
            this.labelKurzy.Size = new System.Drawing.Size(86, 32);
            this.labelKurzy.TabIndex = 0;
            this.labelKurzy.Text = "Kurzy";
            // 
            // UCkurzycs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelKurzy);
            this.Name = "UCkurzycs";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UCkurzycs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKurzy;
    }
}
