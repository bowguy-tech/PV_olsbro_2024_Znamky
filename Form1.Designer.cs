using System.Collections.Generic;
using System.Windows.Forms;

namespace PV_Olsbro_2024
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.uCkurzycs1 = new PV_Olsbro_2024.UCkurzycs();
            this.uCznamky1 = new PV_Olsbro_2024.UCgrades();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.uCtrida1 = new PV_Olsbro_2024.UCtrida();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kurzy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uCkurzycs1
            // 
            this.uCkurzycs1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uCkurzycs1.Location = new System.Drawing.Point(40, 91);
            this.uCkurzycs1.Name = "uCkurzycs1";
            this.uCkurzycs1.Size = new System.Drawing.Size(800, 450);
            this.uCkurzycs1.TabIndex = 1;
            // 
            // uCznamky1
            // 
            this.uCznamky1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uCznamky1.Location = new System.Drawing.Point(40, 91);
            this.uCznamky1.Name = "uCznamky1";
            this.uCznamky1.Size = new System.Drawing.Size(800, 450);
            this.uCznamky1.TabIndex = 2;
            this.uCznamky1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Znamky";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            if (SharedVariables.User is InstanceTeacher)
            {
                this.button2.Text = "Your Class";
            }
            
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(750, 24);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 35);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // uCtrida1
            // 
            this.uCtrida1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uCtrida1.Location = new System.Drawing.Point(40, 91);
            this.uCtrida1.Name = "uCtrida1";
            this.uCtrida1.Size = new System.Drawing.Size(800, 450);
            this.uCtrida1.TabIndex = 5;
            this.uCtrida1.Visible = false;
            this.uCtrida1.Load += new System.EventHandler(this.uCtrida1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.uCtrida1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uCznamky1);
            this.Controls.Add(this.uCkurzycs1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public UCkurzycs uCkurzycs1;
        public UCgrades uCznamky1;
        private Button button2;
        private Button buttonLogout;
        public UCtrida uCtrida1;
    }
}

