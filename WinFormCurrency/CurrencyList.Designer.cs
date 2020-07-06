namespace WinFormCurrency
{
    partial class CurrencyList
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_currencyD = new System.Windows.Forms.Label();
            this.list_currencyM = new System.Windows.Forms.Label();
            this.list_currencyC = new System.Windows.Forms.Label();
            this.list_currencyN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_currencyD
            // 
            this.list_currencyD.AutoSize = true;
            this.list_currencyD.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_currencyD.ForeColor = System.Drawing.Color.Gray;
            this.list_currencyD.Location = new System.Drawing.Point(620, 15);
            this.list_currencyD.Name = "list_currencyD";
            this.list_currencyD.Size = new System.Drawing.Size(31, 13);
            this.list_currencyD.TabIndex = 7;
            this.list_currencyD.Text = "Data";
            // 
            // list_currencyM
            // 
            this.list_currencyM.AutoSize = true;
            this.list_currencyM.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_currencyM.ForeColor = System.Drawing.Color.Gray;
            this.list_currencyM.Location = new System.Drawing.Point(423, 15);
            this.list_currencyM.Name = "list_currencyM";
            this.list_currencyM.Size = new System.Drawing.Size(63, 13);
            this.list_currencyM.TabIndex = 6;
            this.list_currencyM.Text = "Średni kurs";
            // 
            // list_currencyC
            // 
            this.list_currencyC.AutoSize = true;
            this.list_currencyC.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_currencyC.ForeColor = System.Drawing.Color.Gray;
            this.list_currencyC.Location = new System.Drawing.Point(213, 15);
            this.list_currencyC.Name = "list_currencyC";
            this.list_currencyC.Size = new System.Drawing.Size(67, 13);
            this.list_currencyC.TabIndex = 5;
            this.list_currencyC.Text = "Kod Waluty";
            // 
            // list_currencyN
            // 
            this.list_currencyN.AutoSize = true;
            this.list_currencyN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_currencyN.ForeColor = System.Drawing.Color.Gray;
            this.list_currencyN.Location = new System.Drawing.Point(39, 15);
            this.list_currencyN.Name = "list_currencyN";
            this.list_currencyN.Size = new System.Drawing.Size(43, 13);
            this.list_currencyN.TabIndex = 4;
            this.list_currencyN.Text = "Waluta";
            this.list_currencyN.Click += new System.EventHandler(this.list_currencyN_Click);
            // 
            // CurrencyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.list_currencyD);
            this.Controls.Add(this.list_currencyM);
            this.Controls.Add(this.list_currencyC);
            this.Controls.Add(this.list_currencyN);
            this.Name = "CurrencyList";
            this.Size = new System.Drawing.Size(714, 50);
            this.Load += new System.EventHandler(this.CurrencyList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label list_currencyD;
        private System.Windows.Forms.Label list_currencyM;
        private System.Windows.Forms.Label list_currencyC;
        private System.Windows.Forms.Label list_currencyN;
    }
}
