namespace EnergyCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAppliance = new System.Windows.Forms.Button();
            this.txtApplianceWatts = new System.Windows.Forms.NumericUpDown();
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAppliances = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtRoundedYearlyCost = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtRoundedMonthlyCost = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtRoundedWeeklyCost = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtRoundedDailyCost = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtYearlyCost = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMonthlyCost = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWeeklyCost = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDailyCost = new System.Windows.Forms.TextBox();
            this.btnRemoveAppliance = new System.Windows.Forms.Button();
            this.txtApplianceUsageWatts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplianceWatts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplianceUsageWatts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApplianceUsageWatts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApplianceWatts);
            this.groupBox1.Controls.Add(this.txtApplianceName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance Details";
            // 
            // btnAddAppliance
            // 
            this.btnAddAppliance.Location = new System.Drawing.Point(480, 108);
            this.btnAddAppliance.Name = "btnAddAppliance";
            this.btnAddAppliance.Size = new System.Drawing.Size(120, 23);
            this.btnAddAppliance.TabIndex = 4;
            this.btnAddAppliance.Text = "Add Appliance";
            this.btnAddAppliance.UseVisualStyleBackColor = true;
            this.btnAddAppliance.Click += new System.EventHandler(this.btnAddAppliance_Click);
            // 
            // txtApplianceWatts
            // 
            this.txtApplianceWatts.DecimalPlaces = 1;
            this.txtApplianceWatts.Location = new System.Drawing.Point(153, 54);
            this.txtApplianceWatts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtApplianceWatts.Name = "txtApplianceWatts";
            this.txtApplianceWatts.Size = new System.Drawing.Size(120, 23);
            this.txtApplianceWatts.TabIndex = 3;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(107, 25);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(232, 23);
            this.txtApplianceName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Standby Watts (Per Hour)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appliance Name";
            // 
            // lstAppliances
            // 
            this.lstAppliances.DisplayMember = "Name";
            this.lstAppliances.FormattingEnabled = true;
            this.lstAppliances.ItemHeight = 15;
            this.lstAppliances.Location = new System.Drawing.Point(12, 138);
            this.lstAppliances.Name = "lstAppliances";
            this.lstAppliances.Size = new System.Drawing.Size(588, 154);
            this.lstAppliances.TabIndex = 1;
            this.lstAppliances.ValueMember = "Name";
            this.lstAppliances.SelectedIndexChanged += new System.EventHandler(this.lstAppliances_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Energy Information";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtRoundedYearlyCost);
            this.groupBox7.Location = new System.Drawing.Point(212, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 54);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Yearly Cost (Rounded)";
            // 
            // txtRoundedYearlyCost
            // 
            this.txtRoundedYearlyCost.Location = new System.Drawing.Point(6, 22);
            this.txtRoundedYearlyCost.Name = "txtRoundedYearlyCost";
            this.txtRoundedYearlyCost.ReadOnly = true;
            this.txtRoundedYearlyCost.Size = new System.Drawing.Size(188, 23);
            this.txtRoundedYearlyCost.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtRoundedMonthlyCost);
            this.groupBox8.Location = new System.Drawing.Point(212, 142);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 54);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Monthly Cost (Rounded)";
            // 
            // txtRoundedMonthlyCost
            // 
            this.txtRoundedMonthlyCost.Location = new System.Drawing.Point(6, 22);
            this.txtRoundedMonthlyCost.Name = "txtRoundedMonthlyCost";
            this.txtRoundedMonthlyCost.ReadOnly = true;
            this.txtRoundedMonthlyCost.Size = new System.Drawing.Size(188, 23);
            this.txtRoundedMonthlyCost.TabIndex = 2;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtRoundedWeeklyCost);
            this.groupBox9.Location = new System.Drawing.Point(212, 82);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 54);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Weekly Cost (Rounded)";
            // 
            // txtRoundedWeeklyCost
            // 
            this.txtRoundedWeeklyCost.Location = new System.Drawing.Point(6, 22);
            this.txtRoundedWeeklyCost.Name = "txtRoundedWeeklyCost";
            this.txtRoundedWeeklyCost.ReadOnly = true;
            this.txtRoundedWeeklyCost.Size = new System.Drawing.Size(188, 23);
            this.txtRoundedWeeklyCost.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtRoundedDailyCost);
            this.groupBox10.Location = new System.Drawing.Point(212, 22);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 54);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Daily Cost (Rounded)";
            // 
            // txtRoundedDailyCost
            // 
            this.txtRoundedDailyCost.Location = new System.Drawing.Point(6, 22);
            this.txtRoundedDailyCost.Name = "txtRoundedDailyCost";
            this.txtRoundedDailyCost.ReadOnly = true;
            this.txtRoundedDailyCost.Size = new System.Drawing.Size(188, 23);
            this.txtRoundedDailyCost.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtYearlyCost);
            this.groupBox6.Location = new System.Drawing.Point(6, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 54);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Yearly Cost";
            // 
            // txtYearlyCost
            // 
            this.txtYearlyCost.Location = new System.Drawing.Point(6, 22);
            this.txtYearlyCost.Name = "txtYearlyCost";
            this.txtYearlyCost.ReadOnly = true;
            this.txtYearlyCost.Size = new System.Drawing.Size(188, 23);
            this.txtYearlyCost.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMonthlyCost);
            this.groupBox5.Location = new System.Drawing.Point(6, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 54);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthly Cost";
            // 
            // txtMonthlyCost
            // 
            this.txtMonthlyCost.Location = new System.Drawing.Point(6, 22);
            this.txtMonthlyCost.Name = "txtMonthlyCost";
            this.txtMonthlyCost.ReadOnly = true;
            this.txtMonthlyCost.Size = new System.Drawing.Size(188, 23);
            this.txtMonthlyCost.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWeeklyCost);
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 54);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Weekly Cost";
            // 
            // txtWeeklyCost
            // 
            this.txtWeeklyCost.Location = new System.Drawing.Point(6, 22);
            this.txtWeeklyCost.Name = "txtWeeklyCost";
            this.txtWeeklyCost.ReadOnly = true;
            this.txtWeeklyCost.Size = new System.Drawing.Size(188, 23);
            this.txtWeeklyCost.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDailyCost);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 54);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daily Cost";
            // 
            // txtDailyCost
            // 
            this.txtDailyCost.Location = new System.Drawing.Point(6, 22);
            this.txtDailyCost.Name = "txtDailyCost";
            this.txtDailyCost.ReadOnly = true;
            this.txtDailyCost.Size = new System.Drawing.Size(188, 23);
            this.txtDailyCost.TabIndex = 0;
            // 
            // btnRemoveAppliance
            // 
            this.btnRemoveAppliance.Enabled = false;
            this.btnRemoveAppliance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveAppliance.Location = new System.Drawing.Point(525, 298);
            this.btnRemoveAppliance.Name = "btnRemoveAppliance";
            this.btnRemoveAppliance.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAppliance.TabIndex = 3;
            this.btnRemoveAppliance.Text = "Remove Selected";
            this.btnRemoveAppliance.UseVisualStyleBackColor = true;
            // 
            // txtApplianceUsageWatts
            // 
            this.txtApplianceUsageWatts.DecimalPlaces = 1;
            this.txtApplianceUsageWatts.Location = new System.Drawing.Point(425, 55);
            this.txtApplianceUsageWatts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtApplianceUsageWatts.Name = "txtApplianceUsageWatts";
            this.txtApplianceUsageWatts.Size = new System.Drawing.Size(120, 23);
            this.txtApplianceUsageWatts.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usage Watts (Per Hour)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 606);
            this.Controls.Add(this.btnAddAppliance);
            this.Controls.Add(this.btnRemoveAppliance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstAppliances);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Device Energy Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplianceWatts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApplianceUsageWatts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown txtApplianceWatts;
        private TextBox txtApplianceName;
        private Label label2;
        private Label label1;
        private Button btnAddAppliance;
        private ListBox lstAppliances;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private TextBox txtYearlyCost;
        private GroupBox groupBox5;
        private TextBox txtMonthlyCost;
        private GroupBox groupBox4;
        private TextBox txtWeeklyCost;
        private GroupBox groupBox3;
        private TextBox txtDailyCost;
        private Button btnRemoveAppliance;
        private GroupBox groupBox7;
        private TextBox txtRoundedYearlyCost;
        private GroupBox groupBox8;
        private TextBox txtRoundedMonthlyCost;
        private GroupBox groupBox9;
        private TextBox txtRoundedWeeklyCost;
        private GroupBox groupBox10;
        private TextBox txtRoundedDailyCost;
        private NumericUpDown txtApplianceUsageWatts;
        private Label label3;
    }
}