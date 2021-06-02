using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			clear();
		
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		
			if (textBox1.Text.Length != 0)
			{
				if(textBox2.Text.Length != 0)
				{
					if (textBox3.Text.Length != 0)
					{
						if (textBox5.Text.Length != 0)
						{
							if (textBox6.Text.Length != 0)
							{
								salaryCalculate();
							}
							else
							{
								showMessage("Please Enter OT Hours");
							}

						}
						else
						{
							showMessage("Please Enter OT Rate");
						}
					}
					else
					{
						showMessage("Please Enter Basic Salary");
					}
				}
				else
				{
					showMessage("Please Enter Employee Name");
				}

			}
			else {
				showMessage("Please Enter Employee Number");
			}

			
		}
		private void showMessage(string message) {
			DialogResult dialogResult = MessageBox.Show(message, "Salary Summary");
		}
		private void salaryCalculate() {

			//calculate the bonus amount
			double basicSalary;
			if (Double.TryParse(textBox3.Text, out basicSalary))
			{
				double bonus = (basicSalary / 50);
				label9.Text = bonus.ToString();

				//calculate OT amount
				double OT_Rate;
				double OT_Hours;
				if (Double.TryParse(textBox5.Text, out OT_Rate))
				{
					if (Double.TryParse(textBox6.Text, out OT_Hours))
					{
						double OT_Amount = OT_Rate * OT_Hours;
						label10.Text = OT_Amount.ToString();

						//calculate net salary
						double netSalary = basicSalary + OT_Amount + bonus;
						label11.Text = netSalary.ToString();

						//show message
						string message = "Employee Number: " + textBox1.Text + "\nEmployee Name: " + textBox2.Text + "\nNet Salary: " + netSalary;
						showMessage(message);
					}
					else
					{
						showMessage("Invalid OT Hours");
					}
				}
				else
				{
					showMessage("Invalid OT Rate");
				}
			}
			else {
				showMessage("Invalid Salary type");
			}

			
			

			

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			clear();


		}
		private void clear() {
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			label9.Text = "";
			label10.Text = "";
			label11.Text = "";
			
		}
	}
}
