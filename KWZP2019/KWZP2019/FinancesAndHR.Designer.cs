﻿namespace KWZP2019
{
    partial class FinancesAndHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancesAndHR));
            this.btnHR = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHR
            // 
            this.btnHR.AutoSize = true;
            this.btnHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnHR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHR.FlatAppearance.BorderSize = 3;
            this.btnHR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHR.Image = global::KWZP2019.Properties.Resources.icons8_user_groups_80__1_;
            this.btnHR.Location = new System.Drawing.Point(1087, 362);
            this.btnHR.Margin = new System.Windows.Forms.Padding(0);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(387, 197);
            this.btnHR.TabIndex = 3;
            this.btnHR.Text = "Kadry";
            this.btnHR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(119, 362);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(387, 197);
            this.btnReturnMain.TabIndex = 1;
            this.btnReturnMain.Text = "Powrót do menu";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // FinancesAndHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 922);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnHR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinancesAndHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finanse i Kadry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnReturnMain;
    }
}