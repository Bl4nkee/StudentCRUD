namespace StudentCRUD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboBoxEditYearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlYearLevel = new DevExpress.XtraEditors.LabelControl();
            this.labelControlIdNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCourse = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAge = new DevExpress.XtraEditors.LabelControl();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditAge = new DevExpress.XtraEditors.TextEdit();
            this.textEditCourse = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdNumber = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlStudent = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panelMain.Controls.Add(this.comboBoxEditYearLevel);
            this.panelMain.Controls.Add(this.labelControlYearLevel);
            this.panelMain.Controls.Add(this.labelControlIdNumber);
            this.panelMain.Controls.Add(this.labelControlCourse);
            this.panelMain.Controls.Add(this.labelControlAge);
            this.panelMain.Controls.Add(this.labelControlName);
            this.panelMain.Controls.Add(this.textEditName);
            this.panelMain.Controls.Add(this.textEditAge);
            this.panelMain.Controls.Add(this.textEditCourse);
            this.panelMain.Controls.Add(this.textEditIdNumber);
            this.panelMain.Controls.Add(this.simpleButtonAdd);
            this.panelMain.Controls.Add(this.simpleButtonUpdate);
            this.panelMain.Controls.Add(this.simpleButtonDelete);
            this.panelMain.Controls.Add(this.gridControlStudent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1098, 556);
            this.panelMain.TabIndex = 0;
            // 
            // comboBoxEditYearLevel
            // 
            this.comboBoxEditYearLevel.Location = new System.Drawing.Point(609, 38);
            this.comboBoxEditYearLevel.Name = "comboBoxEditYearLevel";
            this.comboBoxEditYearLevel.Properties.AutoHeight = false;
            this.comboBoxEditYearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditYearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEditYearLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditYearLevel.Size = new System.Drawing.Size(136, 34);
            this.comboBoxEditYearLevel.TabIndex = 26;
            // 
            // labelControlYearLevel
            // 
            this.labelControlYearLevel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlYearLevel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlYearLevel.Appearance.Options.UseFont = true;
            this.labelControlYearLevel.Appearance.Options.UseForeColor = true;
            this.labelControlYearLevel.Location = new System.Drawing.Point(609, 17);
            this.labelControlYearLevel.Name = "labelControlYearLevel";
            this.labelControlYearLevel.Size = new System.Drawing.Size(61, 17);
            this.labelControlYearLevel.TabIndex = 25;
            this.labelControlYearLevel.Text = "Year Level";
            // 
            // labelControlIdNumber
            // 
            this.labelControlIdNumber.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlIdNumber.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlIdNumber.Appearance.Options.UseFont = true;
            this.labelControlIdNumber.Appearance.Options.UseForeColor = true;
            this.labelControlIdNumber.Location = new System.Drawing.Point(463, 17);
            this.labelControlIdNumber.Name = "labelControlIdNumber";
            this.labelControlIdNumber.Size = new System.Drawing.Size(67, 17);
            this.labelControlIdNumber.TabIndex = 24;
            this.labelControlIdNumber.Text = "ID Number";
            // 
            // labelControlCourse
            // 
            this.labelControlCourse.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCourse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlCourse.Appearance.Options.UseFont = true;
            this.labelControlCourse.Appearance.Options.UseForeColor = true;
            this.labelControlCourse.Location = new System.Drawing.Point(315, 17);
            this.labelControlCourse.Name = "labelControlCourse";
            this.labelControlCourse.Size = new System.Drawing.Size(42, 17);
            this.labelControlCourse.TabIndex = 23;
            this.labelControlCourse.Text = "Course";
            // 
            // labelControlAge
            // 
            this.labelControlAge.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAge.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlAge.Appearance.Options.UseFont = true;
            this.labelControlAge.Appearance.Options.UseForeColor = true;
            this.labelControlAge.Location = new System.Drawing.Point(168, 17);
            this.labelControlAge.Name = "labelControlAge";
            this.labelControlAge.Size = new System.Drawing.Size(24, 17);
            this.labelControlAge.TabIndex = 22;
            this.labelControlAge.Text = "Age";
            // 
            // labelControlName
            // 
            this.labelControlName.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlName.Appearance.Options.UseFont = true;
            this.labelControlName.Appearance.Options.UseForeColor = true;
            this.labelControlName.Location = new System.Drawing.Point(23, 17);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(36, 17);
            this.labelControlName.TabIndex = 21;
            this.labelControlName.Text = "Name";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(20, 38);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Properties.AutoHeight = false;
            this.textEditName.Properties.MaxLength = 50;
            this.textEditName.Size = new System.Drawing.Size(136, 33);
            this.textEditName.TabIndex = 1;
            // 
            // textEditAge
            // 
            this.textEditAge.Location = new System.Drawing.Point(168, 38);
            this.textEditAge.Name = "textEditAge";
            this.textEditAge.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAge.Properties.Appearance.Options.UseFont = true;
            this.textEditAge.Properties.AutoHeight = false;
            this.textEditAge.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditAge.Properties.MaskSettings.Set("mask", "d");
            this.textEditAge.Properties.MaxLength = 2;
            this.textEditAge.Size = new System.Drawing.Size(136, 33);
            this.textEditAge.TabIndex = 2;
            // 
            // textEditCourse
            // 
            this.textEditCourse.Location = new System.Drawing.Point(315, 38);
            this.textEditCourse.Name = "textEditCourse";
            this.textEditCourse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCourse.Properties.Appearance.Options.UseFont = true;
            this.textEditCourse.Properties.AutoHeight = false;
            this.textEditCourse.Properties.MaxLength = 50;
            this.textEditCourse.Size = new System.Drawing.Size(136, 33);
            this.textEditCourse.TabIndex = 3;
            // 
            // textEditIdNumber
            // 
            this.textEditIdNumber.Location = new System.Drawing.Point(463, 38);
            this.textEditIdNumber.Name = "textEditIdNumber";
            this.textEditIdNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditIdNumber.Properties.Appearance.Options.UseFont = true;
            this.textEditIdNumber.Properties.AutoHeight = false;
            this.textEditIdNumber.Properties.MaxLength = 20;
            this.textEditIdNumber.Size = new System.Drawing.Size(136, 33);
            this.textEditIdNumber.TabIndex = 4;
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.simpleButtonAdd.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAdd.Appearance.Options.UseBackColor = true;
            this.simpleButtonAdd.Appearance.Options.UseFont = true;
            this.simpleButtonAdd.Location = new System.Drawing.Point(772, 38);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(98, 33);
            this.simpleButtonAdd.TabIndex = 6;
            this.simpleButtonAdd.Text = "Add\r\n";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.simpleButtonUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonUpdate.Appearance.Options.UseBackColor = true;
            this.simpleButtonUpdate.Appearance.Options.UseFont = true;
            this.simpleButtonUpdate.Location = new System.Drawing.Point(876, 38);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(98, 33);
            this.simpleButtonUpdate.TabIndex = 7;
            this.simpleButtonUpdate.Text = "Update";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.simpleButtonDelete.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonDelete.Appearance.Options.UseBackColor = true;
            this.simpleButtonDelete.Appearance.Options.UseFont = true;
            this.simpleButtonDelete.Location = new System.Drawing.Point(980, 39);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(98, 33);
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // gridControlStudent
            // 
            this.gridControlStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlStudent.Location = new System.Drawing.Point(20, 88);
            this.gridControlStudent.MainView = this.gridViewStudent;
            this.gridControlStudent.Name = "gridControlStudent";
            this.gridControlStudent.Size = new System.Drawing.Size(1058, 448);
            this.gridControlStudent.TabIndex = 0;
            this.gridControlStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudent});
            // 
            // gridViewStudent
            // 
            this.gridViewStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Name,
            this.Age,
            this.Course,
            this.IdNumber,
            this.YearLevel});
            this.gridViewStudent.GridControl = this.gridControlStudent;
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.OptionsView.ShowGroupPanel = false;
            this.gridViewStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewStudent_RowClick);
            // 
            // Name
            // 
            this.Name.AccessibleName = "Name";
            this.Name.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.Name.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.AppearanceCell.Options.UseBackColor = true;
            this.Name.AppearanceCell.Options.UseFont = true;
            this.Name.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.AppearanceHeader.Options.UseFont = true;
            this.Name.Caption = "Name";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.OptionsColumn.AllowEdit = false;
            this.Name.OptionsColumn.AllowFocus = false;
            this.Name.Visible = true;
            this.Name.VisibleIndex = 0;
            this.Name.Width = 76;
            // 
            // Age
            // 
            this.Age.AccessibleName = "Age";
            this.Age.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.Age.AppearanceCell.Options.UseFont = true;
            this.Age.AppearanceCell.Options.UseTextOptions = true;
            this.Age.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Age.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.Age.AppearanceHeader.Options.UseFont = true;
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.Name = "Age";
            this.Age.OptionsColumn.AllowEdit = false;
            this.Age.OptionsColumn.AllowFocus = false;
            this.Age.Visible = true;
            this.Age.VisibleIndex = 1;
            this.Age.Width = 76;
            // 
            // Course
            // 
            this.Course.AccessibleName = "Course";
            this.Course.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.Course.AppearanceCell.Options.UseFont = true;
            this.Course.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.Course.AppearanceHeader.Options.UseFont = true;
            this.Course.Caption = "Course";
            this.Course.FieldName = "Course";
            this.Course.Name = "Course";
            this.Course.OptionsColumn.AllowEdit = false;
            this.Course.OptionsColumn.AllowFocus = false;
            this.Course.Visible = true;
            this.Course.VisibleIndex = 2;
            this.Course.Width = 76;
            // 
            // IdNumber
            // 
            this.IdNumber.AccessibleName = "IdNumber";
            this.IdNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.IdNumber.AppearanceCell.Options.UseFont = true;
            this.IdNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.IdNumber.AppearanceHeader.Options.UseFont = true;
            this.IdNumber.Caption = "ID Number";
            this.IdNumber.FieldName = "IdNumber";
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.OptionsColumn.AllowEdit = false;
            this.IdNumber.OptionsColumn.AllowFocus = false;
            this.IdNumber.Visible = true;
            this.IdNumber.VisibleIndex = 3;
            this.IdNumber.Width = 76;
            // 
            // YearLevel
            // 
            this.YearLevel.AccessibleName = "YearLevel";
            this.YearLevel.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.YearLevel.AppearanceCell.Options.UseFont = true;
            this.YearLevel.AppearanceCell.Options.UseTextOptions = true;
            this.YearLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.YearLevel.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.YearLevel.AppearanceHeader.Options.UseFont = true;
            this.YearLevel.Caption = "Year Level";
            this.YearLevel.FieldName = "YearLevel";
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.OptionsColumn.AllowEdit = false;
            this.YearLevel.OptionsColumn.AllowFocus = false;
            this.YearLevel.Visible = true;
            this.YearLevel.VisibleIndex = 4;
            this.YearLevel.Width = 76;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 556);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudent;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditAge;
        private DevExpress.XtraEditors.TextEdit textEditCourse;
        private DevExpress.XtraEditors.TextEdit textEditIdNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.LabelControl labelControlYearLevel;
        private DevExpress.XtraEditors.LabelControl labelControlIdNumber;
        private DevExpress.XtraEditors.LabelControl labelControlCourse;
        private DevExpress.XtraEditors.LabelControl labelControlAge;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn IdNumber;
        private DevExpress.XtraGrid.Columns.GridColumn YearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditYearLevel;
    }
}

