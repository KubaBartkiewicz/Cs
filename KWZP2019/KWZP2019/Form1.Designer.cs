namespace KWZP2019
{
    partial class StartForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnHR = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHR
            // 
            resources.ApplyResources(this.btnHR, "btnHR");
            this.btnHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnHR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHR.FlatAppearance.BorderSize = 3;
            this.btnHR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnHR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHR.Image = global::KWZP2019.Properties.Resources.icons8_duration_finance_80;
            this.btnHR.Name = "btnHR";
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnHR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Label lblWelcome;
    }
}

