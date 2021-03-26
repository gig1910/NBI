
namespace NBI
{
    partial class FExecutionTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExecutionTasks));
            this.TaskExecutions_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDtaskexecutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet = new NBI.nbiDataSet();
            this.datestartfactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishfactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adjustedfactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documenttaskexecutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskexecutionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_executionsTableAdapter = new NBI.nbiDataSetTableAdapters.Task_executionsTableAdapter();
            this.tasksTableAdapter = new NBI.nbiDataSetTableAdapters.TasksTableAdapter();
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
            this.label9 = new System.Windows.Forms.Label();
            this.Adjustedfactor_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Datefinishfact_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Datestartfact_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDtask_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtaskexecution_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChoiseAddress_Button = new System.Windows.Forms.Button();
            this.Docs_TextBox = new System.Windows.Forms.TextBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Docs_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TaskExecutions_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskexecutionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskExecutions_DataGridView
            // 
            this.TaskExecutions_DataGridView.AutoGenerateColumns = false;
            this.TaskExecutions_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskExecutions_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskExecutions_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtaskexecutionDataGridViewTextBoxColumn,
            this.iDtaskDataGridViewTextBoxColumn,
            this.datestartfactDataGridViewTextBoxColumn,
            this.datefinishfactDataGridViewTextBoxColumn,
            this.adjustedfactorDataGridViewTextBoxColumn,
            this.documenttaskexecutionDataGridViewTextBoxColumn});
            this.TaskExecutions_DataGridView.DataSource = this.taskexecutionsBindingSource;
            this.TaskExecutions_DataGridView.Location = new System.Drawing.Point(2, 28);
            this.TaskExecutions_DataGridView.Name = "TaskExecutions_DataGridView";
            this.TaskExecutions_DataGridView.Size = new System.Drawing.Size(1230, 246);
            this.TaskExecutions_DataGridView.TabIndex = 0;
            // 
            // iDtaskexecutionDataGridViewTextBoxColumn
            // 
            this.iDtaskexecutionDataGridViewTextBoxColumn.DataPropertyName = "ID_task_execution";
            this.iDtaskexecutionDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDtaskexecutionDataGridViewTextBoxColumn.Name = "iDtaskexecutionDataGridViewTextBoxColumn";
            this.iDtaskexecutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDtaskDataGridViewTextBoxColumn
            // 
            this.iDtaskDataGridViewTextBoxColumn.DataPropertyName = "ID_task";
            this.iDtaskDataGridViewTextBoxColumn.DataSource = this.tasksBindingSource;
            this.iDtaskDataGridViewTextBoxColumn.DisplayMember = "Name_task";
            this.iDtaskDataGridViewTextBoxColumn.HeaderText = "Задача";
            this.iDtaskDataGridViewTextBoxColumn.Name = "iDtaskDataGridViewTextBoxColumn";
            this.iDtaskDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDtaskDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDtaskDataGridViewTextBoxColumn.ValueMember = "ID_task";
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.nbiDataSet;
            // 
            // nbiDataSet
            // 
            this.nbiDataSet.DataSetName = "nbiDataSet";
            this.nbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datestartfactDataGridViewTextBoxColumn
            // 
            this.datestartfactDataGridViewTextBoxColumn.DataPropertyName = "Date_start_fact";
            this.datestartfactDataGridViewTextBoxColumn.HeaderText = "Дата старта задачи (факт.)";
            this.datestartfactDataGridViewTextBoxColumn.Name = "datestartfactDataGridViewTextBoxColumn";
            // 
            // datefinishfactDataGridViewTextBoxColumn
            // 
            this.datefinishfactDataGridViewTextBoxColumn.DataPropertyName = "Date_finish_fact";
            this.datefinishfactDataGridViewTextBoxColumn.HeaderText = "Дата завершения задачи (факт.)";
            this.datefinishfactDataGridViewTextBoxColumn.Name = "datefinishfactDataGridViewTextBoxColumn";
            // 
            // adjustedfactorDataGridViewTextBoxColumn
            // 
            this.adjustedfactorDataGridViewTextBoxColumn.DataPropertyName = "Adjusted_factor";
            this.adjustedfactorDataGridViewTextBoxColumn.HeaderText = "Коэффициент сложности задачи (корр.)";
            this.adjustedfactorDataGridViewTextBoxColumn.Name = "adjustedfactorDataGridViewTextBoxColumn";
            // 
            // documenttaskexecutionDataGridViewTextBoxColumn
            // 
            this.documenttaskexecutionDataGridViewTextBoxColumn.DataPropertyName = "Document_task_execution";
            this.documenttaskexecutionDataGridViewTextBoxColumn.HeaderText = "Документация по выполнению задачи";
            this.documenttaskexecutionDataGridViewTextBoxColumn.Name = "documenttaskexecutionDataGridViewTextBoxColumn";
            // 
            // taskexecutionsBindingSource
            // 
            this.taskexecutionsBindingSource.DataMember = "Task_executions";
            this.taskexecutionsBindingSource.DataSource = this.nbiDataSet;
            // 
            // task_executionsTableAdapter
            // 
            this.task_executionsTableAdapter.ClearBeforeFill = true;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.taskexecutionsBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1229, 25);
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
            this.toolStripButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Adjustedfactor_TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Datefinishfact_DateTimePicker);
            this.groupBox1.Controls.Add(this.Datestartfact_DateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.IDtask_ComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IDtaskexecution_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ChoiseAddress_Button);
            this.groupBox1.Controls.Add(this.Docs_TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о выполненной задаче (ручное заполнение)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(637, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Путь к файлу документа:";
            // 
            // Adjustedfactor_TextBox
            // 
            this.Adjustedfactor_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskexecutionsBindingSource, "Adjusted_factor", true));
            this.Adjustedfactor_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Adjustedfactor_TextBox.Location = new System.Drawing.Point(254, 93);
            this.Adjustedfactor_TextBox.Name = "Adjustedfactor_TextBox";
            this.Adjustedfactor_TextBox.Size = new System.Drawing.Size(377, 23);
            this.Adjustedfactor_TextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "К-т сложности задачи (корр.):";
            // 
            // Datefinishfact_DateTimePicker
            // 
            this.Datefinishfact_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskexecutionsBindingSource, "Date_finish_fact", true));
            this.Datefinishfact_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datefinishfact_DateTimePicker.Location = new System.Drawing.Point(637, 64);
            this.Datefinishfact_DateTimePicker.Name = "Datefinishfact_DateTimePicker";
            this.Datefinishfact_DateTimePicker.Size = new System.Drawing.Size(114, 23);
            this.Datefinishfact_DateTimePicker.TabIndex = 21;
            // 
            // Datestartfact_DateTimePicker
            // 
            this.Datestartfact_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskexecutionsBindingSource, "Date_start_fact", true));
            this.Datestartfact_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datestartfact_DateTimePicker.Location = new System.Drawing.Point(254, 62);
            this.Datestartfact_DateTimePicker.Name = "Datestartfact_DateTimePicker";
            this.Datestartfact_DateTimePicker.Size = new System.Drawing.Size(114, 23);
            this.Datestartfact_DateTimePicker.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(392, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата завершения задачи (факт.):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата старта задачи (факт.):";
            // 
            // IDtask_ComboBox
            // 
            this.IDtask_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taskexecutionsBindingSource, "ID_task", true));
            this.IDtask_ComboBox.DataSource = this.tasksBindingSource;
            this.IDtask_ComboBox.DisplayMember = "Name_task";
            this.IDtask_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDtask_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDtask_ComboBox.FormattingEnabled = true;
            this.IDtask_ComboBox.Location = new System.Drawing.Point(637, 27);
            this.IDtask_ComboBox.Name = "IDtask_ComboBox";
            this.IDtask_ComboBox.Size = new System.Drawing.Size(586, 24);
            this.IDtask_ComboBox.TabIndex = 14;
            this.IDtask_ComboBox.ValueMember = "ID_task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(392, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Наименование:";
            // 
            // IDtaskexecution_TextBox
            // 
            this.IDtaskexecution_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskexecutionsBindingSource, "ID_task_execution", true));
            this.IDtaskexecution_TextBox.Enabled = false;
            this.IDtaskexecution_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDtaskexecution_TextBox.Location = new System.Drawing.Point(253, 28);
            this.IDtaskexecution_TextBox.Name = "IDtaskexecution_TextBox";
            this.IDtaskexecution_TextBox.Size = new System.Drawing.Size(67, 23);
            this.IDtaskexecution_TextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Код:";
            // 
            // ChoiseAddress_Button
            // 
            this.ChoiseAddress_Button.Location = new System.Drawing.Point(1184, 91);
            this.ChoiseAddress_Button.Name = "ChoiseAddress_Button";
            this.ChoiseAddress_Button.Size = new System.Drawing.Size(39, 27);
            this.ChoiseAddress_Button.TabIndex = 10;
            this.ChoiseAddress_Button.Text = "...";
            this.ChoiseAddress_Button.UseVisualStyleBackColor = true;
            this.ChoiseAddress_Button.Click += new System.EventHandler(this.ChoiseAddress_Button_Click);
            // 
            // Docs_TextBox
            // 
            this.Docs_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskexecutionsBindingSource, "Document_task_execution", true));
            this.Docs_TextBox.Enabled = false;
            this.Docs_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Docs_TextBox.Location = new System.Drawing.Point(825, 93);
            this.Docs_TextBox.Name = "Docs_TextBox";
            this.Docs_TextBox.Size = new System.Drawing.Size(353, 23);
            this.Docs_TextBox.TabIndex = 8;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(784, 424);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(448, 19);
            this.lblFormName.TabIndex = 54;
            this.lblFormName.Text = "Перечень выполненных задач предприятия АО \"НБИ\"";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(3, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Docs_OpenFileDialog
            // 
            this.Docs_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // FExecutionTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1238, 455);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.TaskExecutions_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FExecutionTasks";
            this.Text = "Исполнение задач";
            this.Load += new System.EventHandler(this.Form_ExecutionTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskExecutions_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskexecutionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskExecutions_DataGridView;
        private nbiDataSet nbiDataSet;
        private System.Windows.Forms.BindingSource taskexecutionsBindingSource;
        private nbiDataSetTableAdapters.Task_executionsTableAdapter task_executionsTableAdapter;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private nbiDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
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
        private System.Windows.Forms.Button ChoiseAddress_Button;
        private System.Windows.Forms.TextBox Docs_TextBox;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog Docs_OpenFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtaskexecutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartfactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishfactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adjustedfactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documenttaskexecutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox IDtaskexecution_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDtask_ComboBox;
        private System.Windows.Forms.DateTimePicker Datefinishfact_DateTimePicker;
        private System.Windows.Forms.DateTimePicker Datestartfact_DateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Adjustedfactor_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}