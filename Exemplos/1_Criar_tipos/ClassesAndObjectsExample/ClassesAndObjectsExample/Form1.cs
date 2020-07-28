using System;
using System.Windows.Forms;

namespace ClassesAndObjectsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = "Mark";
            e1.LastName = "Long";
            e1.Seniority = 5;

            string p = e1.Promote();
            MessageBox.Show(p);

            Employee e2 = new Employee();
            e2.FirstName = "Alice";
            e2.LastName = "Jones";
        }
    }


    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Seniority { get; set; }

        public string Promote()
        {
            return "Employee has been promoted...";
        }

        public string AnnualReview()
        {
            return "Annual review completed...";
        }
    }


}
