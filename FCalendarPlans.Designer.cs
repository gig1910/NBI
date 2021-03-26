
namespace NBI
{
    partial class FCalendarPlans
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalendarPlans));
            this.CalendarPlans_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDcalendarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet = new NBI.nbiDataSet();
            this.datecreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarprojectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendar_projectsTableAdapter = new NBI.nbiDataSetTableAdapters.Calendar_projectsTableAdapter();
            this.projectsTableAdapter = new NBI.nbiDataSetTableAdapters.ProjectsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetFilePath = new System.Windows.Forms.Button();
            this.Calendarplan_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_DateCreation = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.tb_IDCalendar = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.Calendarplan_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarPlans_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarprojectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarPlans_DataGridView
            // 
            this.CalendarPlans_DataGridView.AutoGenerateColumns = false;
            this.CalendarPlans_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CalendarPlans_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarPlans_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcalendarDataGridViewTextBoxColumn,
            this.iDprojectDataGridViewTextBoxColumn,
            this.datecreationDataGridViewTextBoxColumn,
            this.calendarplanDataGridViewTextBoxColumn});
            this.CalendarPlans_DataGridView.DataSource = this.calendarprojectsBindingSource;
            this.CalendarPlans_DataGridView.Location = new System.Drawing.Point(2, 27);
            this.CalendarPlans_DataGridView.Name = "CalendarPlans_DataGridView";
            this.CalendarPlans_DataGridView.Size = new System.Drawing.Size(968, 262);
            this.CalendarPlans_DataGridView.TabIndex = 0;
            // 
            // iDcalendarDataGridViewTextBoxColumn
            // 
            this.iDcalendarDataGridViewTextBoxColumn.DataPropertyName = "ID_calendar";
            this.iDcalendarDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDcalendarDataGridViewTextBoxColumn.Name = "iDcalendarDataGridViewTextBoxColumn";
            this.iDcalendarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDprojectDataGridViewTextBoxColumn
            // 
            this.iDprojectDataGridViewTextBoxColumn.DataPropertyName = "ID_project";
            this.iDprojectDataGridViewTextBoxColumn.DataSource = this.projectsBindingSource;
            this.iDprojectDataGridViewTextBoxColumn.DisplayMember = "Name_project";
            this.iDprojectDataGridViewTextBoxColumn.HeaderText = "Наименование проекта";
            this.iDprojectDataGridViewTextBoxColumn.Name = "iDprojectDataGridViewTextBoxColumn";
            this.iDprojectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDprojectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDprojectDataGridViewTextBoxColumn.ValueMember = "ID_project";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.nbiDataSet;
            // 
            // nbiDataSet
            // 
            this.nbiDataSet.DataSetName = "nbiDataSet";
            this.nbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datecreationDataGridViewTextBoxColumn
            // 
            this.datecreationDataGridViewTextBoxColumn.DataPropertyName = "Date_creation";
            this.datecreationDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.datecreationDataGridViewTextBoxColumn.Name = "datecreationDataGridViewTextBoxColumn";
            // 
            // calendarplanDataGridViewTextBoxColumn
            // 
            this.calendarplanDataGridViewTextBoxColumn.DataPropertyName = "Calendar_plan";
            this.calendarplanDataGridViewTextBoxColumn.HeaderText = "Путь к файлу календарного плана";
            this.calendarplanDataGridViewTextBoxColumn.Name = "calendarplanDataGridViewTextBoxColumn";
            // 
            // calendarprojectsBindingSource
            // 
            this.calendarprojectsBindingSource.DataMember = "Calendar_projects";
            this.calendarprojectsBindingSource.DataSource = this.nbiDataSet;
            // 
            // calendar_projectsTableAdapter
            // 
            this.calendar_projectsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.calendarprojectsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 2);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(968, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton1.Text = "Записать";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetFilePath);
            this.groupBox1.Controls.Add(this.Calendarplan_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DTP_DateCreation);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.cbProject);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.tb_IDCalendar);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о календарных планах (ручное заполнение)";
            // 
            // btnGetFilePath
            // 
            this.btnGetFilePath.Location = new System.Drawing.Point(924, 64);
            this.btnGetFilePath.Name = "btnGetFilePath";
            this.btnGetFilePath.Size = new System.Drawing.Size(36, 27);
            this.btnGetFilePath.TabIndex = 11;
            this.btnGetFilePath.Text = "...";
            this.btnGetFilePath.UseVisualStyleBackColor = true;
            this.btnGetFilePath.Click += new System.EventHandler(this.btnGetFilePath_Click);
            // 
            // Calendarplan_TextBox
            // 
            this.Calendarplan_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calendarprojectsBindingSource, "Calendar_plan", true));
            this.Calendarplan_TextBox.Enabled = false;
            this.Calendarplan_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Calendarplan_TextBox.Location = new System.Drawing.Point(383, 66);
            this.Calendarplan_TextBox.Name = "Calendarplan_TextBox";
            this.Calendarplan_TextBox.Size = new System.Drawing.Size(535, 23);
            this.Calendarplan_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(263, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Путь к файлу:";
            // 
            // DTP_DateCreation
            // 
            this.DTP_DateCreation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calendarprojectsBindingSource, "Date_creation", true));
            this.DTP_DateCreation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DateCreation.Location = new System.Drawing.Point(126, 59);
            this.DTP_DateCreation.Name = "DTP_DateCreation";
            this.DTP_DateCreation.Size = new System.Drawing.Size(110, 23);
            this.DTP_DateCreation.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(6, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Дата создания:";
            // 
            // cbProject
            // 
            this.cbProject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.calendarprojectsBindingSource, "ID_project", true));
            this.cbProject.DataSource = this.projectsBindingSource;
            this.cbProject.DisplayMember = "Name_project";
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(383, 25);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(577, 24);
            this.cbProject.TabIndex = 3;
            this.cbProject.ValueMember = "ID_project";
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.IDproject_ComboBox_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.ForeColor = System.Drawing.Color.Maroon;
            this.lblProject.Location = new System.Drawing.Point(263, 33);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(62, 16);
            this.lblProject.TabIndex = 2;
            this.lblProject.Text = "Проект:";
            this.lblProject.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_IDCalendar
            // 
            this.tb_IDCalendar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.calendarprojectsBindingSource, "ID_calendar", true));
            this.tb_IDCalendar.Enabled = false;
            this.tb_IDCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tb_IDCalendar.Location = new System.Drawing.Point(126, 30);
            this.tb_IDCalendar.Name = "tb_IDCalendar";
            this.tb_IDCalendar.Size = new System.Drawing.Size(67, 23);
            this.tb_IDCalendar.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Maroon;
            this.lblCode.Location = new System.Drawing.Point(6, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(39, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Код:";
            // 
            // Calendarplan_OpenFileDialog
            // 
            this.Calendarplan_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(727, 417);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(243, 19);
            this.lblFormName.TabIndex = 56;
            this.lblFormName.Text = "Список календарных планов";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(5, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FCalendarPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 449);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.CalendarPlans_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FCalendarPlans";
            this.Text = "Календарные планы";
            this.Load += new System.EventHandler(this.Form_CalendarPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarPlans_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarprojectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CalendarPlans_DataGridView;
        private nbiDataSet nbiDataSet;
        private System.Windows.Forms.BindingSource calendarprojectsBindingSource;
        private nbiDataSetTableAdapters.Calendar_projectsTableAdapter calendar_projectsTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private nbiDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcalendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_IDCalendar;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.DateTimePicker DTP_DateCreation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox Calendarplan_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetFilePath;
        private System.Windows.Forms.OpenFileDialog Calendarplan_OpenFileDialog;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
    }
}