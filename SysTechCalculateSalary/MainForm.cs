using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTechCalculateSalary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            try 
            {
                STDemoSqlData.CreateDemoDataBase();
                RefreshData();
                LoadComboBoxBossesData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(string.Format("Error loading data:{0}", ex.Message));
            }


        }

        private void RefreshData() {
            STSysTechEmployeesData.AllEmployees.Clear();
            DataTable dt = STDemoSqlData.GetDataFromDataBase();


            List<STSysTechEmployee> employees = (from d in dt.AsEnumerable()
                                                 where (d.Field<Int64>("group") == 1)
                                                 select new STEmployee() {
                                                     ID = Convert.ToInt32(d["id"]),
                                                     Name = d["name"].ToString(),
                                                     Group = Convert.ToInt32(d["group"]),
                                                     BaseRate = Convert.ToDouble(d["baserate"]),
                                                     DateStart = Convert.ToDateTime(d["datestart"]),
                                                     ParentId = ConvertNullableInt(d["parent_id"])
                                                 }).ToList<STSysTechEmployee>();

            STSysTechEmployeesData.AddEmployees(employees);

            List<STSysTechEmployee> managers = (from d in dt.AsEnumerable()
                                                where (d.Field<Int64>("group") == 2)
                                                select new STManager() {
                                                    ID = Convert.ToInt32(d["id"]),
                                                    Name = d["name"].ToString(),
                                                    Group = Convert.ToInt32(d["group"]),
                                                    BaseRate = Convert.ToDouble(d["baserate"]),
                                                    DateStart = Convert.ToDateTime(d["datestart"]),
                                                    ParentId = ConvertNullableInt(d["parent_id"])
                                                }).ToList<STSysTechEmployee>();

            STSysTechEmployeesData.AddEmployees(managers);

            List<STSysTechEmployee> salesmans = (from d in dt.AsEnumerable()
                                                 where (d.Field<Int64>("group") == 3)
                                                 select new STSalesMan() {
                                                     ID = Convert.ToInt32(d["id"]),
                                                     Name = d["name"].ToString(),
                                                     Group = Convert.ToInt32(d["group"]),
                                                     BaseRate = Convert.ToDouble(d["baserate"]),
                                                     DateStart = Convert.ToDateTime(d["datestart"]),
                                                     ParentId = ConvertNullableInt(d["parent_id"])
                                                 }).ToList<STSysTechEmployee>();

            STSysTechEmployeesData.AddEmployees(salesmans);
        }

        private int? ConvertNullableInt(object v) {
            if (string.IsNullOrEmpty(v.ToString())) {
                return null;
            }
            return Convert.ToInt32(v);
        }

        private void LoadComboBoxBossesData() 
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            items.Add(new ComboBoxItem() { ID = 0, Name = " " });
            foreach(STSysTechEmployee emp in STSysTechEmployeesData.AllEmployees) {
                if (emp.Group > 1) {
                    items.Add(new ComboBoxItem() { ID = emp.ID, Name = emp.Name });
                }
            }
            cmbBosses.DisplayMember = "Name";
            cmbBosses.ValueMember = "ID";
            cmbBosses.DataSource = items;

        }

        private void btnCalculateSalary_Click(object sender, EventArgs e) {
            try 
            {
                BindNewDataToGridView();
                MessageBox.Show("Готово");
            }
            catch(Exception ex) {
                MessageBox.Show(string.Format("Unexpected error:{0}", ex.Message));
            }
        }

        private void BindNewDataToGridView() {
            RefreshData();
            DateTime dateEnd = dateTimePicker1.Value;
            string columnName = string.Format("Зарплата на {0}", dateEnd.ToShortDateString());
            DataTable gridData = new DataTable();

            DataColumn name = new DataColumn("Имя сотрудника", typeof(string));
            DataColumn group = new DataColumn("Группа", typeof(string));
            DataColumn dateStart = new DataColumn("Дата начала работы", typeof(string));
            DataColumn baseRate = new DataColumn("Базовая ставка", typeof(string));
            DataColumn salary = new DataColumn(columnName, typeof(double));

            gridData.Columns.Add(name);
            gridData.Columns.Add(group);
            gridData.Columns.Add(dateStart);
            gridData.Columns.Add(baseRate);
            gridData.Columns.Add(salary);

            double total = 0.0;
            foreach (STSysTechEmployee emp in STSysTechEmployeesData.AllEmployees) {
                DataRow dr = gridData.NewRow();
                dr[name] = emp.Name;
                dr[group] = (emp is STEmployee ? "Employee" : (emp is STManager ? "Manager" : "Salesman"));
                dr[dateStart] = emp.DateStart.ToShortDateString();
                dr[baseRate] = emp.BaseRate.ToString();
                dr[salary] = Math.Round(emp.GetRate(dateEnd), 2);
                gridData.Rows.Add(dr);
                total += (double)dr[salary];
            }

            DataRow totalRow = gridData.NewRow();
            totalRow[name] = "Итого: ";
            totalRow[salary] = Math.Round(total, 2);
            this.lblTotal.Text = "Итого: "+ Math.Round(total, 2);
            gridData.Rows.Add(totalRow);


            dataGridView1.DataSource = gridData;
        }

        private void btnAdd_Click(object sender, EventArgs e) 
        {
            string name = tbName.Text;
            int group = cmbGroup.SelectedIndex+1;
            double baserate = System.Convert.ToDouble(tbBaseRate.Text);
            DateTime datestart = datePickerDateStart.Value;
                        
            int? parent_id = (int)cmbBosses.SelectedValue;
            if ((int)cmbBosses.SelectedValue == 0)
                parent_id = null;

            try 
            {
                STDemoSqlData.InsertEmployeeInDataBase(name, group, baserate, datestart, parent_id);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(string.Format("Error adding data:{0}", ex.Message));
            }
            BindNewDataToGridView();
            MessageBox.Show("Данные успешно добавлены.");
        }

    }
}
