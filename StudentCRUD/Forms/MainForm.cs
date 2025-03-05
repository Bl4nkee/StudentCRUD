using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentCRUD.Models;

namespace StudentCRUD
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            gridControlStudent.DataSource = null; 
            gridControlStudent.DataSource = students;
            gridViewStudent.RefreshData(); // refresh the grid display
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            // icheck if naa wala na input
            if (string.IsNullOrWhiteSpace(textEditName.Text) ||
                string.IsNullOrWhiteSpace(textEditAge.Text) ||
                string.IsNullOrWhiteSpace(textEditCourse.Text) ||
                string.IsNullOrWhiteSpace(textEditIdNumber.Text) ||
                string.IsNullOrWhiteSpace(textEditYearLevel.Text))
            {
                XtraMessageBox.Show("Please enter valid student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ga create ug student object
            Student newStudent = new Student
            {
                Name = textEditName.Text,
                Age = Convert.ToInt32(textEditAge.Text),
                Course = textEditCourse.Text,
                IdNumber = textEditIdNumber.Text,
                YearLevel = Convert.ToInt32(textEditYearLevel.Text)
            };

            // iadd to list and refresh grid
            students.Add(newStudent);
            LoadGrid(); // refresh ang grid with the updated list

            // clear ang mga textEdit after maka add
            textEditName.Text = "";
            textEditAge.Text = "";
            textEditCourse.Text = "";
            textEditIdNumber.Text = "";
            textEditYearLevel.Text = "";
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
