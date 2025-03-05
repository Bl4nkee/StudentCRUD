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
            this.labelControlYearLevel = new DevExpress.XtraEditors.LabelControl();
            this.labelControlIdNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCourse = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAge = new DevExpress.XtraEditors.LabelControl();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditAge = new DevExpress.XtraEditors.TextEdit();
            this.textEditCourse = new DevExpress.XtraEditors.TextEdit();
            this.textEditIdNumber = new DevExpress.XtraEditors.TextEdit();
            this.textEditYearLevel = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlStudent = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIdNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcYearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panelMain.Controls.Add(this.labelControlYearLevel);
            this.panelMain.Controls.Add(this.labelControlIdNumber);
            this.panelMain.Controls.Add(this.labelControlCourse);
            this.panelMain.Controls.Add(this.labelControlAge);
            this.panelMain.Controls.Add(this.labelControlName);
            this.panelMain.Controls.Add(this.textEditName);
            this.panelMain.Controls.Add(this.textEditAge);
            this.panelMain.Controls.Add(this.textEditCourse);
            this.panelMain.Controls.Add(this.textEditIdNumber);
            this.panelMain.Controls.Add(this.textEditYearLevel);
            this.panelMain.Controls.Add(this.simpleButtonAdd);
            this.panelMain.Controls.Add(this.simpleButtonUpdate);
            this.panelMain.Controls.Add(this.simpleButtonDelete);
            this.panelMain.Controls.Add(this.gridControlStudent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1098, 556);
            this.panelMain.TabIndex = 0;
            // 
            // labelControlYearLevel
            // 
            this.labelControlYearLevel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlYearLevel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.labelControlYearLevel.Appearance.Options.UseFont = true;
            this.labelControlYearLevel.Appearance.Options.UseForeColor = true;
            this.labelControlYearLevel.Location = new System.Drawing.Point(592, 21);
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
            this.labelControlIdNumber.Location = new System.Drawing.Point(448, 21);
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
            this.labelControlCourse.Location = new System.Drawing.Point(304, 21);
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
            this.labelControlAge.Location = new System.Drawing.Point(160, 21);
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
            this.labelControlName.Location = new System.Drawing.Point(16, 21);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(36, 17);
            this.labelControlName.TabIndex = 21;
            this.labelControlName.Text = "Name";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(16, 44);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditName.Properties.Appearance.Options.UseFont = true;
            this.textEditName.Properties.AutoHeight = false;
            this.textEditName.Size = new System.Drawing.Size(136, 33);
            this.textEditName.TabIndex = 1;
            // 
            // textEditAge
            // 
            this.textEditAge.Location = new System.Drawing.Point(160, 44);
            this.textEditAge.Name = "textEditAge";
            this.textEditAge.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditAge.Properties.Appearance.Options.UseFont = true;
            this.textEditAge.Properties.AutoHeight = false;
            this.textEditAge.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditAge.Properties.MaskSettings.Set("mask", "d");
            this.textEditAge.Size = new System.Drawing.Size(136, 33);
            this.textEditAge.TabIndex = 2;
            // 
            // textEditCourse
            // 
            this.textEditCourse.Location = new System.Drawing.Point(304, 44);
            this.textEditCourse.Name = "textEditCourse";
            this.textEditCourse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCourse.Properties.Appearance.Options.UseFont = true;
            this.textEditCourse.Properties.AutoHeight = false;
            this.textEditCourse.Size = new System.Drawing.Size(136, 33);
            this.textEditCourse.TabIndex = 3;
            // 
            // textEditIdNumber
            // 
            this.textEditIdNumber.Location = new System.Drawing.Point(448, 44);
            this.textEditIdNumber.Name = "textEditIdNumber";
            this.textEditIdNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditIdNumber.Properties.Appearance.Options.UseFont = true;
            this.textEditIdNumber.Properties.AutoHeight = false;
            this.textEditIdNumber.Size = new System.Drawing.Size(136, 33);
            this.textEditIdNumber.TabIndex = 4;
            // 
            // textEditYearLevel
            // 
            this.textEditYearLevel.Location = new System.Drawing.Point(592, 44);
            this.textEditYearLevel.Name = "textEditYearLevel";
            this.textEditYearLevel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.649485F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditYearLevel.Properties.Appearance.Options.UseFont = true;
            this.textEditYearLevel.Properties.AutoHeight = false;
            this.textEditYearLevel.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditYearLevel.Properties.MaskSettings.Set("mask", "d");
            this.textEditYearLevel.Size = new System.Drawing.Size(136, 33);
            this.textEditYearLevel.TabIndex = 5;
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(134)))), ((int)(((byte)(69)))));
            this.simpleButtonAdd.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.87629F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAdd.Appearance.Options.UseBackColor = true;
            this.simpleButtonAdd.Appearance.Options.UseFont = true;
            this.simpleButtonAdd.Location = new System.Drawing.Point(756, 44);
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
            this.simpleButtonUpdate.Location = new System.Drawing.Point(872, 44);
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
            this.simpleButtonDelete.Location = new System.Drawing.Point(990, 44);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(98, 33);
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // gridControlStudent
            // 
            this.gridControlStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlStudent.Location = new System.Drawing.Point(10, 98);
            this.gridControlStudent.MainView = this.gridViewStudent;
            this.gridControlStudent.Name = "gridControlStudent";
            this.gridControlStudent.Size = new System.Drawing.Size(1078, 448);
            this.gridControlStudent.TabIndex = 0;
            this.gridControlStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudent});
            // 
            // gridViewStudent
            // 
            this.gridViewStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcName,
            this.gcAge,
            this.gcCourse,
            this.gcIdNumber,
            this.gcYearLevel});
            this.gridViewStudent.GridControl = this.gridControlStudent;
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.OptionsView.ShowGroupPanel = false;
            // 
            // gcName
            // 
            this.gcName.AccessibleName = "gcName";
            this.gcName.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.gcName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcName.AppearanceCell.Options.UseBackColor = true;
            this.gcName.AppearanceCell.Options.UseFont = true;
            this.gcName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcName.AppearanceHeader.Options.UseFont = true;
            this.gcName.Caption = "Name";
            this.gcName.FieldName = "gcName";
            this.gcName.Name = "gcName";
            this.gcName.OptionsColumn.AllowEdit = false;
            this.gcName.OptionsColumn.AllowFocus = false;
            this.gcName.Visible = true;
            this.gcName.VisibleIndex = 0;
            this.gcName.Width = 76;
            // 
            // gcAge
            // 
            this.gcAge.AccessibleName = "gcAge";
            this.gcAge.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.gcAge.AppearanceCell.Options.UseFont = true;
            this.gcAge.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.gcAge.AppearanceHeader.Options.UseFont = true;
            this.gcAge.Caption = "Age";
            this.gcAge.FieldName = "gcAge";
            this.gcAge.Name = "gcAge";
            this.gcAge.OptionsColumn.AllowEdit = false;
            this.gcAge.OptionsColumn.AllowFocus = false;
            this.gcAge.Visible = true;
            this.gcAge.VisibleIndex = 1;
            this.gcAge.Width = 76;
            // 
            // gcCourse
            // 
            this.gcCourse.AccessibleName = "gcCourse";
            this.gcCourse.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.gcCourse.AppearanceCell.Options.UseFont = true;
            this.gcCourse.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.gcCourse.AppearanceHeader.Options.UseFont = true;
            this.gcCourse.Caption = "Course";
            this.gcCourse.FieldName = "gcCourse";
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.OptionsColumn.AllowEdit = false;
            this.gcCourse.OptionsColumn.AllowFocus = false;
            this.gcCourse.Visible = true;
            this.gcCourse.VisibleIndex = 2;
            this.gcCourse.Width = 76;
            // 
            // gcIdNumber
            // 
            this.gcIdNumber.AccessibleName = "gcIdNumber";
            this.gcIdNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.gcIdNumber.AppearanceCell.Options.UseFont = true;
            this.gcIdNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.gcIdNumber.AppearanceHeader.Options.UseFont = true;
            this.gcIdNumber.Caption = "ID Number";
            this.gcIdNumber.FieldName = "gcIdNumber";
            this.gcIdNumber.Name = "gcIdNumber";
            this.gcIdNumber.OptionsColumn.AllowEdit = false;
            this.gcIdNumber.OptionsColumn.AllowFocus = false;
            this.gcIdNumber.Visible = true;
            this.gcIdNumber.VisibleIndex = 3;
            this.gcIdNumber.Width = 76;
            // 
            // gcYearLevel
            // 
            this.gcYearLevel.AccessibleName = "gcYearLevel";
            this.gcYearLevel.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9.649485F);
            this.gcYearLevel.AppearanceCell.Options.UseFont = true;
            this.gcYearLevel.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.gcYearLevel.AppearanceHeader.Options.UseFont = true;
            this.gcYearLevel.Caption = "Year Level";
            this.gcYearLevel.FieldName = "gcYearLevel";
            this.gcYearLevel.Name = "gcYearLevel";
            this.gcYearLevel.OptionsColumn.AllowEdit = false;
            this.gcYearLevel.OptionsColumn.AllowFocus = false;
            this.gcYearLevel.Visible = true;
            this.gcYearLevel.VisibleIndex = 4;
            this.gcYearLevel.Width = 76;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 556);
            this.Controls.Add(this.panelMain);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditYearLevel.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEditYearLevel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.LabelControl labelControlYearLevel;
        private DevExpress.XtraEditors.LabelControl labelControlIdNumber;
        private DevExpress.XtraEditors.LabelControl labelControlCourse;
        private DevExpress.XtraEditors.LabelControl labelControlAge;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraGrid.Columns.GridColumn gcName;
        private DevExpress.XtraGrid.Columns.GridColumn gcAge;
        private DevExpress.XtraGrid.Columns.GridColumn gcCourse;
        private DevExpress.XtraGrid.Columns.GridColumn gcIdNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gcYearLevel;
    }
}

