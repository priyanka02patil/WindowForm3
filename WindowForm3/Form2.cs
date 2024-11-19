using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace WindowForm3
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnBinWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\binaryempDemo.dat", FileMode.Create,FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(textEmpId.Text);
                emp.Name = textEmpName.Text;
                emp.Salary = Convert.ToDouble(textEmpSal.Text);
                bf.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\binaryempDemo.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Employee emp = new Employee();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                textEmpId.Text=emp.ID.ToString();
                textEmpName.Text = emp.Name;
                textEmpSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\xmlempDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(textEmpId.Text);
                emp.Name = textEmpName.Text;
                emp.Salary = Convert.ToDouble(textEmpSal.Text);
                xmlSerializer.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRaed_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\xmlempDemo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Employee emp = new Employee();
                emp = (Employee)xmlSerializer.Deserialize(fs);
                textEmpId.Text= emp.ID.ToString();
                textEmpName.Text = emp.Name;
                textEmpSal.Text = Convert.ToString(emp.Salary);
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textEmpId.Clear();
            textEmpName.Clear();
            textEmpSal.Clear();
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\soapempDemo.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(textEmpId.Text);
                emp.Name = textEmpName.Text;
                emp.Salary = Convert.ToDouble(textEmpSal.Text);
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\soapempDemo.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Employee emp = new Employee();
                emp = (Employee)soapFormatter.Deserialize(fs);
                textEmpId.Text = emp.ID.ToString();
                textEmpName.Text = emp.Name;
                textEmpSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\jsonempDemo.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(textEmpId.Text);
                emp.Name = textEmpName.Text;
                emp.Salary = Convert.ToDouble(textEmpSal.Text);
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\DotNetTraining-oct\jsonempDemo.json", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                emp = JsonSerializer.Deserialize<Employee>(fs);
                textEmpId.Text = emp.ID.ToString();
                textEmpName.Text = emp.Name;
                textEmpSal.Text = emp.Salary.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
