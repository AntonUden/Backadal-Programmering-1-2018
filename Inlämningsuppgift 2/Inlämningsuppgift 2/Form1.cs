using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Inlämningsuppgift_2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			updateTemperature();
			u2_validateInput();
		}

		/* Code for Is-Vatten-Gas */
		private void u1_temperature_ValueChanged(object sender, EventArgs e) {
			updateTemperature();
		}

		private void updateTemperature() {
			try {
				double temperature = (double)u1_temperature.Value;
				if (temperature >= 99.63) {
					u1_result.ForeColor = Color.Gray;
					u1_result.Text = "Gas";
				} else if (temperature <= 0) {
					u1_result.ForeColor = Color.Aqua;
					u1_result.Text = "Is";
				} else {
					u1_result.ForeColor = Color.Blue;
					u1_result.Text = "Vatten";
				}
			} catch (Exception ex) {
				u1_result.ForeColor = Color.Red;
				u1_result.Text = "Error";
			}
		}

		/* Code for Namnuppgifter */
		private void u2_name_TextChanged(object sender, EventArgs e) {
			u2_validateInput();
		}

		private void u2_age_ValueChanged(object sender, EventArgs e) {
			u2_validateInput();
		}

		private void u2_interest_TextChanged(object sender, EventArgs e) {
			u2_validateInput();
		}

		private bool u2_validateInput() {
			bool isValid = true;

			if (u2_name.Text.Length == 0) {
				isValid = false;
			}

			if (u2_age.Value < 0 || u2_age.Value > 200) {
				isValid = false;
			}

			if (u2_interest.Text.Length == 0) {
				isValid = false;
			}
			u2_btn_send.Enabled = isValid;
			return isValid;
		}

		private void u2_btn_send_Click(object sender, EventArgs e) {
			String text = "Namn: " + u2_name.Text + ".\nÅlder: " + u2_age.Value + " år.\nIntresse: " + u2_interest.Text;
			MessageBox.Show(text, "resultat", MessageBoxButtons.OK);
		}
	}
}
