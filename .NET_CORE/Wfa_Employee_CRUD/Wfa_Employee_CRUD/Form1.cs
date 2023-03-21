using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wfa_Employee_CRUD.Classes;

namespace Wfa_Employee_CRUD
{
    public partial class Form1 : Form
    {
        int selectedIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            selectedIndex = lstPersonel.SelectedIndex;

            Employee employee = new Employee();
            SetUser(employee);
            Add(employee);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            selectedIndex = lstPersonel.SelectedIndex;
            Employee employee = new Employee();
            SetUser(employee);
            RemoveAt(selectedIndex);
            Insert(selectedIndex, employee);


        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            selectedIndex = lstPersonel.SelectedIndex;
            RemoveAt(selectedIndex);
        }
        private void SetUser(Employee employee)
        {
            employee.Name = txtAd.Text;
            employee.Surname = txtSoyad.Text;
            employee.Age = Convert.ToInt32(txtYas.Text);
            foreach (RadioButton rdb in grpMedeniHal.Controls)
            {
                if (rdb.Checked)
                {
                    employee.MedeniHal = (MedeniHali)(Enum.Parse(typeof(MedeniHali), rdb.Text.ToLower()));
                }
            }
            if (rdbEvet.Checked)
            {
                employee.isWorking = true;
            }
            else if (rdbHayir.Checked)
            {
                employee.isWorking = false;
            }

        }
        private void Add(Employee employee)
        {
            string isWorking = "Hayır";
            if (employee.isWorking)
            {
                isWorking = "Evet";
            }
            lstPersonel.Items.Add($"{employee.Name} {employee.Surname} {employee.Age} {employee.MedeniHal} {isWorking} ");
            Employees.list.Add(employee);
        }
        private void RemoveAt(int selectedIndex)
        {
            lstPersonel.Items.RemoveAt(selectedIndex);
            Employees.list.RemoveAt(selectedIndex);
        }
        private void Insert(int selectedIndex, Employee employee)
        {
            string isWorking = "Hayır";
            if (employee.isWorking)
            {
                isWorking = "Evet";
            }
            lstPersonel.Items.Insert(selectedIndex,$"{employee.Name} {employee.Surname} {employee.Age} {employee.MedeniHal} {isWorking}");
            Employees.list.Insert(selectedIndex, employee);
        }
    }
}
