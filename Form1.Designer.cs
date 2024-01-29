namespace Garcia_SalesTaxCalc_project
{
    partial class TaxCalc
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
            this.CarPric = new System.Windows.Forms.TextBox();
            this.Warrants = new System.Windows.Forms.ComboBox();
            this.StateTax = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VehicleCost = new System.Windows.Forms.Label();
            this.CalculateBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarPric
            // 
            this.CarPric.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPric.Location = new System.Drawing.Point(187, 51);
            this.CarPric.Name = "CarPric";
            this.CarPric.Size = new System.Drawing.Size(121, 27);
            this.CarPric.TabIndex = 0;
            this.CarPric.TextChanged += new System.EventHandler(this.CarPric_TextChanged);
            // 
            // Warrants
            // 
            this.Warrants.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warrants.FormattingEnabled = true;
            this.Warrants.Items.AddRange(new object[] {
            "None",
            "One Year",
            "Two Years",
            "Three Years"});
            this.Warrants.Location = new System.Drawing.Point(187, 87);
            this.Warrants.Name = "Warrants";
            this.Warrants.Size = new System.Drawing.Size(121, 30);
            this.Warrants.TabIndex = 1;
            this.Warrants.SelectedIndexChanged += new System.EventHandler(this.Warrants_SelectedIndexChanged);
            // 
            // StateTax
            // 
            this.StateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTax.FormattingEnabled = true;
            this.StateTax.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.StateTax.Location = new System.Drawing.Point(187, 126);
            this.StateTax.Name = "StateTax";
            this.StateTax.Size = new System.Drawing.Size(57, 30);
            this.StateTax.TabIndex = 2;
            this.StateTax.SelectedIndexChanged += new System.EventHandler(this.StateTax_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Base Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extended Warranty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "State Sold:";
            // 
            // VehicleCost
            // 
            this.VehicleCost.AutoSize = true;
            this.VehicleCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleCost.Location = new System.Drawing.Point(54, 213);
            this.VehicleCost.Name = "VehicleCost";
            this.VehicleCost.Size = new System.Drawing.Size(245, 22);
            this.VehicleCost.TabIndex = 6;
            this.VehicleCost.Text = "Total Vehicle Cost Is: 000000";
            this.VehicleCost.Click += new System.EventHandler(this.VehicleCost_Click);
            // 
            // CalculateBTN
            // 
            this.CalculateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBTN.Location = new System.Drawing.Point(116, 171);
            this.CalculateBTN.Name = "CalculateBTN";
            this.CalculateBTN.Size = new System.Drawing.Size(109, 30);
            this.CalculateBTN.TabIndex = 7;
            this.CalculateBTN.Text = "Calculate";
            this.CalculateBTN.UseVisualStyleBackColor = true;
            this.CalculateBTN.Click += new System.EventHandler(this.CalculateBTN_Click);
            // 
            // ClearBTN
            // 
            this.ClearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBTN.Location = new System.Drawing.Point(143, 270);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 32);
            this.ClearBTN.TabIndex = 8;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(224, 270);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 32);
            this.ExitBTN.TabIndex = 9;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // TaxCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 323);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.CalculateBTN);
            this.Controls.Add(this.VehicleCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateTax);
            this.Controls.Add(this.Warrants);
            this.Controls.Add(this.CarPric);
            this.Name = "TaxCalc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarPric;
        private System.Windows.Forms.ComboBox Warrants;
        private System.Windows.Forms.ComboBox StateTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VehicleCost;
        private System.Windows.Forms.Button CalculateBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.Button ExitBTN;
    }
}

