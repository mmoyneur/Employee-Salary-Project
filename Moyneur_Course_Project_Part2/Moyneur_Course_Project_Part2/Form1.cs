using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moyneur_Course_Project_Part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            
            EmployeesListBox.Items.Clear();
            ReadEmpsFromFile();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add item to the employee list box from the form
            InputForm frmInput = new InputForm();
            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();
                //see if the form was canceled
                if (result == DialogResult.Cancel)
                    return;
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthInsurance = frmInput.HeathInsTextBox.Text;
                double lifeIns = Double.Parse(frmInput.LifeInsTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthInsurance, lifeIns, vacation);


                Employee emp;
                if(frmInput.HourlyRadioButton.Checked)
                {
                    float hourlyRate = float.Parse(frmInput.Pay1TextBox.Text);
                    float hoursworked = float.Parse(frmInput.Pay2TextBox.Text);
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursworked);
                }
                else if (frmInput.SalaryRadioButton.Checked)
                {
                    double annualSalary = Double.Parse(frmInput.Pay1TextBox.Text);
                    emp = new Salary(fName, lName, ssn, hireDate, benefits, annualSalary);
                }
                else
                {
                    return;
                }


                EmployeesListBox.Items.Add(emp);

                WriteEmpsToFile();
            }
        
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int itemNumber = EmployeesListBox.SelectedIndex;
            //only remove it if it exists
            if (itemNumber >-1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select an employee to remove");
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees");
        }
        private void WriteEmpsToFile()
        {
            string fileName = "Employees.csv";
            StreamWriter sw = new StreamWriter(fileName);
            for(int i=0; i<EmployeesListBox.Items.Count; i++)
            {
                Employee temp = (Employee)EmployeesListBox.Items[i];
                sw.WriteLine(temp.FirstName + "," + temp.LastName + "," + temp.SSN + "," + temp.HireDate.ToShortDateString() + "," + temp.BenefitsPackage.HealthInsurance + "," + temp.BenefitsPackage.LifeInsurance + "," + temp.BenefitsPackage.Vacation);
            }
            sw.Close();
            MessageBox.Show("Employees were written to the file");
        }

        private void ReadEmpsFromFile()
        {
            string fileName = "Employees.csv";
            StreamReader sr = new StreamReader(fileName);
            using (sr)
            {
                while(sr.Peek() > -1)
                {
                    // read in the line of code and then break it up\
                    string line = sr.ReadLine();
                    string[] parts = line.Split(',');
                    string fName = parts[0];
                    string lName = parts[1];
                    string ssn = parts[2];
                    DateTime hiredate = DateTime.Parse(parts[3]);
                    string healthIns = parts[4];
                    double lifeIns = Double.Parse(parts[5]);
                    int vacation = Int32.Parse(parts[6]);

                    Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                    Employee emp = new Employee(fName, lName, ssn, hiredate, benefits);
                    EmployeesListBox.Items.Add(emp);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.ReadEmpsFromfile();
        }

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            //edit employee in the listbox
            InputForm frmUpdate = new InputForm();
            using (frmUpdate)
            {
                frmUpdate.Text = "Employee Update form";
                frmUpdate.SubmitButton.Text = "Update";
                int itemNumber = EmployeesListBox.SelectedIndex;
                if(itemNumber <0)
                {
                    MessageBox.Show("Error. Invalide employee");
                    return;
                }
                Employee emp = (Employee)EmployeesListBox.Items[itemNumber];
                frmUpdate.FirstNameTextBox.Text = emp.FirstName;
                frmUpdate.LastNameTextBox.Text = emp.LastName;
                frmUpdate.SSNTextBox.Text = emp.SSN;
                frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
                frmUpdate.HeathInsTextBox.Text = emp.BenefitsPackage.HealthInsurance;
                frmUpdate.LifeInsTextBox.Text = emp.BenefitsPackage.LifeInsurance.ToString("C2");
                frmUpdate.VacationTextBox.Text = emp.BenefitsPackage.Vacation.ToString();


                DialogResult result = frmUpdate.ShowDialog();
                if (result == DialogResult.Cancel)
                    return;

                EmployeesListBox.Items.RemoveAt(itemNumber);


                string fName = frmUpdate.FirstNameTextBox.Text;
                string lName = frmUpdate.LastNameTextBox.Text;
                string ssn = frmUpdate.SSNTextBox.Text;
                string date = frmUpdate.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthInsurance = frmUpdate.HeathInsTextBox.Text;
                string lifeInsString = frmUpdate.LifeInsTextBox.Text;
                lifeInsString = lifeInsString.Substring(1);
                double lifeIns = Double.Parse(lifeInsString);
                int vacation = Int32.Parse(frmUpdate.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthInsurance, lifeIns, vacation);

                emp = new Employee(fName, lName, ssn, hireDate, benefits);
                EmployeesListBox.Items.Add(emp);
                WriteEmpsToFile();
            }
        }
    }
}
