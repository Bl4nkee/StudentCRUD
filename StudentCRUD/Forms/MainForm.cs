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
        private int selectedRowIndex = -1; // para ni mahibalhan nga wala pay gi select nga row

        public MainForm()
        {
            InitializeComponent();
            LoadGrid();
        }

        #region Event Handlers

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (AreTextFieldsEmpty()) return; // icheck if walay gi input

            if (IsStudentDuplicate(textEditIdNumber.Text)) // para di ka add if naay duplicate
            {
                XtraMessageBox.Show("A student this ID number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            // create student object
            Student newStudent = new Student
            {
                Name = textEditName.Text,
                Age = Convert.ToInt32(textEditAge.Text),
                Course = textEditCourse.Text,
                IdNumber = textEditIdNumber.Text,
                YearLevel = Convert.ToInt32(comboBoxEditYearLevel.SelectedItem) // Retrieve selected year level
            };

            // iadd to list and refresh grid
            students.Add(newStudent);
            LoadGrid();

            ClearInputFields();
        }


        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0 || selectedRowIndex >= students.Count) //icheck if naay gipislit nga cell
            {
                XtraMessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AreTextFieldsEmpty()) return; // icheck if walay gi input

            // update student details
            students[selectedRowIndex].Name = textEditName.Text;
            students[selectedRowIndex].Age = Convert.ToInt32(textEditAge.Text);
            students[selectedRowIndex].Course = textEditCourse.Text;
            students[selectedRowIndex].IdNumber = textEditIdNumber.Text;
            students[selectedRowIndex].YearLevel = Convert.ToInt32(comboBoxEditYearLevel.SelectedItem);

            // refresh grid
            LoadGrid();
            ClearInputFields();
            XtraMessageBox.Show("Student details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            // kwaon ang row index nga gipili
            int selectedRowIndex = gridViewStudent.FocusedRowHandle;
            if (selectedRowIndex < 0)
            {
                XtraMessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // confirm deletion
            DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to delete this student?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // remove from the list
                students.RemoveAt(selectedRowIndex);
                LoadGrid();
                XtraMessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void gridViewStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // kwaon ang row index nga gipili
            selectedRowIndex = e.RowHandle;
            if (selectedRowIndex < 0) return;

            // kwaon ang selected student
            Student selectedStudent = students[selectedRowIndex];

            // ibutang sa mga text fields ang value sa imong row nga gipislit sa grid control
            textEditName.Text = selectedStudent.Name;
            textEditAge.Text = selectedStudent.Age.ToString();
            textEditCourse.Text = selectedStudent.Course;
            textEditIdNumber.Text = selectedStudent.IdNumber;
            comboBoxEditYearLevel.SelectedItem = selectedStudent.YearLevel.ToString();
        }

        #endregion


        #region Functions

        private void LoadGrid()
        {
            gridControlStudent.DataSource = null;
            gridControlStudent.DataSource = students;
            gridViewStudent.RefreshData(); 
        }


        private bool AreTextFieldsEmpty()
        {
            // icheck if ang mga text fields kay empty or naay mga space
            if (string.IsNullOrWhiteSpace(textEditName.Text) ||
            string.IsNullOrWhiteSpace(textEditAge.Text) ||
            string.IsNullOrWhiteSpace(textEditCourse.Text) ||
            string.IsNullOrWhiteSpace(textEditIdNumber.Text) ||
            comboBoxEditYearLevel.SelectedItem == null)
            {
                XtraMessageBox.Show("Please enter valid student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }


        private void ClearInputFields()
        {
            textEditName.Text = "";
            textEditAge.Text = "";
            textEditCourse.Text = "";
            textEditIdNumber.Text = "";
            comboBoxEditYearLevel.SelectedIndex = -1;
        }


        private bool IsStudentDuplicate(string idNumber) // kwaon ang idNumber para ma check if naay duplicate
        {
            // icheck nya if naay kapareho ug idNumber tas return true if naa tas false ug wla
            // students.any i loop niya tanan ang sulod sa student pero taman ra if ma true ang condition
            /* s => s.IdNumber.Equals(idNumber, StringComparison.OrdinalIgnoreCase)
               icheck niya tanan IdNumber sulod sa students if parehas ba sya sa idNumber sa textEdit nga imong i add
               bahalag naka capital bana or wala kay iignore rana niya
             */
            return students.Any(s => s.IdNumber.Equals(idNumber, StringComparison.OrdinalIgnoreCase));
        }

        #endregion
    }
}
