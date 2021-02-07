using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLinqToSql
{
    public partial class Form1 : Form
    {
        EmpDataContextDataContext dbml = new EmpDataContextDataContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowEmployee()
        {
            var emptab = from e1 in dbml.EmpTabs
                         select e1;
            dataGridView1.DataSource = emptab;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployee();

            //var emptab = dbml.EmpTabs.
            //    Where(e1 => e1.EmpName.StartsWith("P") && e1.Salary > 2000).
            //    OrderByDescending(e1 => e1.EmpName);
            //dataGridView1.DataSource = emptab;

        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            var empDetails = dbml.sp_ShowEmpDetails(Convert.ToInt32(txtEmpId.Text));
            dataGridView1.DataSource = empDetails;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            int? count = 0; //below ref wants a nullable count hence we initilize it before

            //all SP's with output parameters in stored proc will come here as ref keyword as shown below
            var empCount = dbml.sp_WithOutputParameter(ref count);
            lblCount.Text += ": " + count.ToString();

        }

        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var insertEmp = dbml.sp_InsertEmpTab(Convert.ToString(txtEmpName.Text),
                Convert.ToSingle(txtSalary.Text), Convert.ToInt32(txtDept.Text));
            dataGridView1.DataSource = insertEmp;
            ShowEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateEmp = dbml.sp_UpdateEmpTab(Convert.ToInt32(txtEmpId.Text),
                                                 Convert.ToString(txtEmpName.Text),
                                                 Convert.ToSingle(txtSalary.Text),
                                                 Convert.ToInt32(txtDept.Text));

            dataGridView1.DataSource = updateEmp;
            ShowEmployee();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var delEmp = dbml.EmpTabs.Single(p => p.EmpId == Convert.ToInt32
            (txtEmpId.Text));
            dbml.EmpTabs.DeleteOnSubmit(delEmp);
            //whenever we do dbml cmds the below lines are imp (Submit changes) and calling the method()
            dbml.SubmitChanges();
            ShowEmployee();

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

       
    }
}
