
namespace NBI
{
    partial class Form_SettingTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SettingTasks));
            this.SettingTasks_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDcalendarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.calendarprojectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet = new NBI.nbiDataSet();
            this.datebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborfactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documenttaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new NBI.nbiDataSetTableAdapters.TasksTableAdapter();
            this.calendar_projectsTableAdapter = new NBI.nbiDataSetTableAdapters.Calendar_projectsTableAdapter();
            this.usersTableAdapter = new NBI.nbiDataSetTableAdapters.UsersTableAdapter();
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
            this.ChoiseDocumenttask_Button = new System.Windows.Forms.Button();
            this.Documenttask_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IDuser_ComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Laborfactor_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Datefinish_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datebegin_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDcalendar_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametask_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtask_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Documenttask_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SettingTasks_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarprojectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingTasks_DataGridView
            // 
            this.SettingTasks_DataGridView.AutoGenerateColumns = false;
            this.SettingTasks_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SettingTasks_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingTasks_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtaskDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.iDcalendarDataGridViewTextBoxColumn,
            this.datebeginDataGridViewTextBoxColumn,
            this.laborfactorDataGridViewTextBoxColumn,
            this.datefinishDataGridViewTextBoxColumn,
            this.iDuserDataGridViewTextBoxColumn,
            this.documenttaskDataGridViewTextBoxColumn});
            this.SettingTasks_DataGridView.DataSource = this.tasksBindingSource;
            this.SettingTasks_DataGridView.Location = new System.Drawing.Point(2, 27);
            this.SettingTasks_DataGridView.Name = "SettingTasks_DataGridView";
            this.SettingTasks_DataGridView.Size = new System.Drawing.Size(1085, 242);
            this.SettingTasks_DataGridView.TabIndex = 0;
            // 
            // iDtaskDataGridViewTextBoxColumn
            // 
            this.iDtaskDataGridViewTextBoxColumn.DataPropertyName = "ID_task";
            this.iDtaskDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDtaskDataGridViewTextBoxColumn.Name = "iDtaskDataGridViewTextBoxColumn";
            this.iDtaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "Name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            // 
            // iDcalendarDataGridViewTextBoxColumn
            // 
            this.iDcalendarDataGridViewTextBoxColumn.DataPropertyName = "ID_calendar";
            this.iDcalendarDataGridViewTextBoxColumn.DataSource = this.calendarprojectsBindingSource;
            this.iDcalendarDataGridViewTextBoxColumn.DisplayMember = "ID_calendar";
            this.iDcalendarDataGridViewTextBoxColumn.HeaderText = "Календарный план";
            this.iDcalendarDataGridViewTextBoxColumn.Name = "iDcalendarDataGridViewTextBoxColumn";
            this.iDcalendarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDcalendarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDcalendarDataGridViewTextBoxColumn.ValueMember = "ID_calendar";
            // 
            // calendarprojectsBindingSource
            // 
            this.calendarprojectsBindingSource.DataMember = "Calendar_projects";
            this.calendarprojectsBindingSource.DataSource = this.nbiDataSet;
            // 
            // nbiDataSet
            // 
            this.nbiDataSet.DataSetName = "nbiDataSet";
            this.nbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datebeginDataGridViewTextBoxColumn
            // 
            this.datebeginDataGridViewTextBoxColumn.DataPropertyName = "Date_begin";
            this.datebeginDataGridViewTextBoxColumn.HeaderText = "Дата старта задачи (план.)";
            this.datebeginDataGridViewTextBoxColumn.Name = "datebeginDataGridViewTextBoxColumn";
            // 
            // laborfactorDataGridViewTextBoxColumn
            // 
            this.laborfactorDataGridViewTextBoxColumn.DataPropertyName = "Labor_factor";
            this.laborfactorDataGridViewTextBoxColumn.HeaderText = "Коэффициент сложности задачи";
            this.laborfactorDataGridViewTextBoxColumn.Name = "laborfactorDataGridViewTextBoxColumn";
            // 
            // datefinishDataGridViewTextBoxColumn
            // 
            this.datefinishDataGridViewTextBoxColumn.DataPropertyName = "Date_finish";
            this.datefinishDataGridViewTextBoxColumn.HeaderText = "Дата завершения задачи (план.)";
            this.datefinishDataGridViewTextBoxColumn.Name = "datefinishDataGridViewTextBoxColumn";
            // 
            // iDuserDataGridViewTextBoxColumn
            // 
            this.iDuserDataGridViewTextBoxColumn.DataPropertyName = "ID_user";
            this.iDuserDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.iDuserDataGridViewTextBoxColumn.DisplayMember = "Name_user";
            this.iDuserDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            this.iDuserDataGridViewTextBoxColumn.Name = "iDuserDataGridViewTextBoxColumn";
            this.iDuserDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDuserDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDuserDataGridViewTextBoxColumn.ValueMember = "ID_user";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nbiDataSet;
            // 
            // documenttaskDataGridViewTextBoxColumn
            // 
            this.documenttaskDataGridViewTextBoxColumn.DataPropertyName = "Document_task";
            this.documenttaskDataGridViewTextBoxColumn.HeaderText = "Документация";
            this.documenttaskDataGridViewTextBoxColumn.Name = "documenttaskDataGridViewTextBoxColumn";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.nbiDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // calendar_projectsTableAdapter
            // 
            this.calendar_projectsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.tasksBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 2);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1084, 25);
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
            this.groupBox1.Controls.Add(this.ChoiseDocumenttask_Button);
            this.groupBox1.Controls.Add(this.Documenttask_TextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IDuser_ComboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Laborfactor_TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Datefinish_DateTimePicker);
            this.groupBox1.Controls.Add(this.Datebegin_DateTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.IDcalendar_ComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nametask_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDtask_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о поставленной задаче (ручное заполнение)";
            // 
            // ChoiseDocumenttask_Button
            // 
            this.ChoiseDocumenttask_Button.Location = new System.Drawing.Point(1039, 139);
            this.ChoiseDocumenttask_Button.Name = "ChoiseDocumenttask_Button";
            this.ChoiseDocumenttask_Button.Size = new System.Drawing.Size(36, 27);
            this.ChoiseDocumenttask_Button.TabIndex = 24;
            this.ChoiseDocumenttask_Button.Text = "...";
            this.ChoiseDocumenttask_Button.UseVisualStyleBackColor = true;
            this.ChoiseDocumenttask_Button.Click += new System.EventHandler(this.ChoiseDocumenttask_Button_Click);
            // 
            // Documenttask_TextBox
            // 
            this.Documenttask_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Document_task", true));
            this.Documenttask_TextBox.Enabled = false;
            this.Documenttask_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Documenttask_TextBox.Location = new System.Drawing.Point(641, 141);
            this.Documenttask_TextBox.Name = "Documenttask_TextBox";
            this.Documenttask_TextBox.Size = new System.Drawing.Size(235, 23);
            this.Documenttask_TextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(453, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Путь к файлу документа:";
            // 
            // IDuser_ComboBox
            // 
            this.IDuser_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tasksBindingSource, "ID_user", true));
            this.IDuser_ComboBox.DataSource = this.usersBindingSource;
            this.IDuser_ComboBox.DisplayMember = "Name_user";
            this.IDuser_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDuser_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDuser_ComboBox.FormattingEnabled = true;
            this.IDuser_ComboBox.Location = new System.Drawing.Point(641, 111);
            this.IDuser_ComboBox.Name = "IDuser_ComboBox";
            this.IDuser_ComboBox.Size = new System.Drawing.Size(434, 24);
            this.IDuser_ComboBox.TabIndex = 21;
            this.IDuser_ComboBox.ValueMember = "ID_user";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(453, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ответственный:";
            // 
            // Laborfactor_TextBox
            // 
            this.Laborfactor_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Labor_factor", true));
            this.Laborfactor_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Laborfactor_TextBox.Location = new System.Drawing.Point(207, 111);
            this.Laborfactor_TextBox.Name = "Laborfactor_TextBox";
            this.Laborfactor_TextBox.Size = new System.Drawing.Size(235, 23);
            this.Laborfactor_TextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(4, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "К-т сложности задачи:";
            // 
            // Datefinish_DateTimePicker
            // 
            this.Datefinish_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Date_finish", true));
            this.Datefinish_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datefinish_DateTimePicker.Location = new System.Drawing.Point(641, 82);
            this.Datefinish_DateTimePicker.Name = "Datefinish_DateTimePicker";
            this.Datefinish_DateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.Datefinish_DateTimePicker.TabIndex = 17;
            // 
            // Datebegin_DateTimePicker
            // 
            this.Datebegin_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Date_begin", true));
            this.Datebegin_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datebegin_DateTimePicker.Location = new System.Drawing.Point(207, 82);
            this.Datebegin_DateTimePicker.Name = "Datebegin_DateTimePicker";
            this.Datebegin_DateTimePicker.Size = new System.Drawing.Size(110, 23);
            this.Datebegin_DateTimePicker.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(400, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата завершения задачи (план.):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата старта задачи (план.):";
            // 
            // IDcalendar_ComboBox
            // 
            this.IDcalendar_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tasksBindingSource, "ID_calendar", true));
            this.IDcalendar_ComboBox.DataSource = this.calendarprojectsBindingSource;
            this.IDcalendar_ComboBox.DisplayMember = "ID_calendar";
            this.IDcalendar_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDcalendar_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDcalendar_ComboBox.FormattingEnabled = true;
            this.IDcalendar_ComboBox.Location = new System.Drawing.Point(207, 52);
            this.IDcalendar_ComboBox.Name = "IDcalendar_ComboBox";
            this.IDcalendar_ComboBox.Size = new System.Drawing.Size(351, 24);
            this.IDcalendar_ComboBox.TabIndex = 13;
            this.IDcalendar_ComboBox.ValueMember = "ID_calendar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Календарный план:";
            // 
            // Nametask_TextBox
            // 
            this.Nametask_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "Name_task", true));
            this.Nametask_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Nametask_TextBox.Location = new System.Drawing.Point(641, 23);
            this.Nametask_TextBox.Name = "Nametask_TextBox";
            this.Nametask_TextBox.Size = new System.Drawing.Size(434, 23);
            this.Nametask_TextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(453, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование:";
            // 
            // IDtask_TextBox
            // 
            this.IDtask_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "ID_task", true));
            this.IDtask_TextBox.Enabled = false;
            this.IDtask_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDtask_TextBox.Location = new System.Drawing.Point(207, 23);
            this.IDtask_TextBox.Name = "IDtask_TextBox";
            this.IDtask_TextBox.Size = new System.Drawing.Size(67, 23);
            this.IDtask_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код:";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(656, 468);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(431, 19);
            this.lblFormName.TabIndex = 60;
            this.lblFormName.Text = "Список поставленных задач предприятия АО \"НБИ\"";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(3, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Documenttask_OpenFileDialog
            // 
            this.Documenttask_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Form_SettingTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 498);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.SettingTasks_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_SettingTasks";
            this.Text = "Постановка задач";
            this.Load += new System.EventHandler(this.Form_SettingTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SettingTasks_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarprojectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SettingTasks_DataGridView;
        private nbiDataSet nbiDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private nbiDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.BindingSource calendarprojectsBindingSource;
        private nbiDataSetTableAdapters.Calendar_projectsTableAdapter calendar_projectsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private nbiDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDcalendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborfactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documenttaskDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox IDtask_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nametask_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDcalendar_ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Datebegin_DateTimePicker;
        private System.Windows.Forms.DateTimePicker Datefinish_DateTimePicker;
        private System.Windows.Forms.TextBox Laborfactor_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IDuser_ComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Documenttask_TextBox;
        private System.Windows.Forms.Button ChoiseDocumenttask_Button;
        private System.Windows.Forms.OpenFileDialog Documenttask_OpenFileDialog;
    }
}