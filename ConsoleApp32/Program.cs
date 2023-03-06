using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApp32
{
    public partial class Form1 : Form
    {

        IList<Ludi> list_ludi = new List<Ludi>();

        public Form1()
        {
            InitializeComponent();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();

            DataTable table1 = new DataTable();

            DataColumn column_familia = new DataColumn("Фамилия", Type.GetType("System.String"));
            DataColumn column_imy = new DataColumn("Имя", Type.GetType("System.String"));
            DataColumn column_otchestvo = new DataColumn("Отчество", Type.GetType("System.String"));
            DataColumn column_pol = new DataColumn("Пол", Type.GetType("System.String"));
            DataColumn column_pasport = new DataColumn("Паспорт", Type.GetType("System.String"));
            DataColumn column_prozivanie = new DataColumn("Место жительство", Type.GetType("System.String"));

            table1.Columns.Add(column_familia);
            table1.Columns.Add(column_imy);
            table1.Columns.Add(column_otchestvo);
            table1.Columns.Add(column_pol);
            table1.Columns.Add(column_pasport);
            table1.Columns.Add(column_prozivanie);
            foreach (Ludi ludi in list_ludi)
            {
                DataRow new_row = table1.NewRow();
                new_row["Фамилия"] = ludi.Familia;
                new_row["Имя"] = ludi.Imy;
                new_row["Отчество"] = ludi.Otchestvo;
                new_row["Пол"] = ludi.Pol;
                new_row["Паспорт"] = ludi.Pasport;
                new_row["жительство"] = ludi.Prozivanie;
                table1.Rows.Add(new_row);
            }

            dataGridView1.DataSource = table1;
        }

        private void Init()
        {
            Random rand = new Random();


            for (int i = 0; i < 40; i++)
            {
                Ludi new_student = new Ludi();
                list_ludi.Add(new_student);
            }
        }
    }
}