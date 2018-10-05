namespace Inlämningsuppgift_2 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.u1_result = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.u1_temperature = new System.Windows.Forms.NumericUpDown();
			this.u2_name = new System.Windows.Forms.TextBox();
			this.u2_interest = new System.Windows.Forms.TextBox();
			this.u2_age = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.u2_btn_send = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.u1_temperature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.u2_age)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(381, 224);
			this.tabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.u1_result);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.u1_temperature);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(373, 198);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Is-Vatten-Gas";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.u2_btn_send);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.u2_age);
			this.tabPage2.Controls.Add(this.u2_interest);
			this.tabPage2.Controls.Add(this.u2_name);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(373, 198);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Namnuppgifter";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// u1_result
			// 
			this.u1_result.AutoSize = true;
			this.u1_result.ForeColor = System.Drawing.Color.Red;
			this.u1_result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.u1_result.Location = new System.Drawing.Point(58, 38);
			this.u1_result.Name = "u1_result";
			this.u1_result.Size = new System.Drawing.Size(23, 13);
			this.u1_result.TabIndex = 7;
			this.u1_result.Text = "null";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Resultat:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ange temperatur";
			// 
			// u1_temperature
			// 
			this.u1_temperature.DecimalPlaces = 2;
			this.u1_temperature.Location = new System.Drawing.Point(99, 6);
			this.u1_temperature.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.u1_temperature.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.u1_temperature.Name = "u1_temperature";
			this.u1_temperature.Size = new System.Drawing.Size(268, 20);
			this.u1_temperature.TabIndex = 4;
			this.u1_temperature.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.u1_temperature.ValueChanged += new System.EventHandler(this.u1_temperature_ValueChanged);
			// 
			// u2_name
			// 
			this.u2_name.Location = new System.Drawing.Point(96, 6);
			this.u2_name.Name = "u2_name";
			this.u2_name.Size = new System.Drawing.Size(271, 20);
			this.u2_name.TabIndex = 0;
			this.u2_name.TextChanged += new System.EventHandler(this.u2_name_TextChanged);
			// 
			// u2_interest
			// 
			this.u2_interest.Location = new System.Drawing.Point(96, 58);
			this.u2_interest.Name = "u2_interest";
			this.u2_interest.Size = new System.Drawing.Size(271, 20);
			this.u2_interest.TabIndex = 1;
			this.u2_interest.TextChanged += new System.EventHandler(this.u2_interest_TextChanged);
			// 
			// u2_age
			// 
			this.u2_age.Location = new System.Drawing.Point(96, 32);
			this.u2_age.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.u2_age.Name = "u2_age";
			this.u2_age.Size = new System.Drawing.Size(271, 20);
			this.u2_age.TabIndex = 2;
			this.u2_age.ValueChanged += new System.EventHandler(this.u2_age_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ange namn:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ange ålder:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Ange intresse:";
			// 
			// u2_btn_send
			// 
			this.u2_btn_send.Location = new System.Drawing.Point(6, 140);
			this.u2_btn_send.Name = "u2_btn_send";
			this.u2_btn_send.Size = new System.Drawing.Size(361, 52);
			this.u2_btn_send.TabIndex = 7;
			this.u2_btn_send.Text = "Skicka";
			this.u2_btn_send.UseVisualStyleBackColor = true;
			this.u2_btn_send.Click += new System.EventHandler(this.u2_btn_send_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 221);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(395, 260);
			this.MinimumSize = new System.Drawing.Size(395, 260);
			this.Name = "Form1";
			this.Text = "Inlämningsuppgift 2";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.u1_temperature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.u2_age)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label u1_result;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown u1_temperature;
		private System.Windows.Forms.Button u2_btn_send;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown u2_age;
		private System.Windows.Forms.TextBox u2_interest;
		private System.Windows.Forms.TextBox u2_name;
	}
}

