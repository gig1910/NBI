
namespace NBI
{
    partial class FProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProjects));
            this.Projects_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet = new NBI.nbiDataSet();
            this.documentsprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new NBI.nbiDataSetTableAdapters.ProjectsTableAdapter();
            this.partnersTableAdapter = new NBI.nbiDataSetTableAdapters.PartnersTableAdapter();
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
            this.ChoiseDocumentsproject_Button = new System.Windows.Forms.Button();
            this.Documentsproject_TextBox = new System.Windows.Forms.TextBox();
            this.IDpartner_ComboBox = new System.Windows.Forms.ComboBox();
            this.Datefinish_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateStart_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameProject_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDproject_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Documentsproject_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Projects_DataGridView
            // 
            this.Projects_DataGridView.AutoGenerateColumns = false;
            this.Projects_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Projects_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Projects_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDprojectDataGridViewTextBoxColumn,
            this.nameprojectDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.datefinishDataGridViewTextBoxColumn,
            this.iDpartnerDataGridViewTextBoxColumn,
            this.documentsprojectDataGridViewTextBoxColumn});
            this.Projects_DataGridView.DataSource = this.projectsBindingSource;
            this.Projects_DataGridView.Location = new System.Drawing.Point(1, 29);
            this.Projects_DataGridView.Name = "Projects_DataGridView";
            this.Projects_DataGridView.Size = new System.Drawing.Size(1083, 302);
            this.Projects_DataGridView.TabIndex = 0;
            // 
            // iDprojectDataGridViewTextBoxColumn
            // 
            this.iDprojectDataGridViewTextBoxColumn.DataPropertyName = "ID_project";
            this.iDprojectDataGridViewTextBoxColumn.HeaderText = "Код";
            this.iDprojectDataGridViewTextBoxColumn.Name = "iDprojectDataGridViewTextBoxColumn";
            this.iDprojectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameprojectDataGridViewTextBoxColumn
            // 
            this.nameprojectDataGridViewTextBoxColumn.DataPropertyName = "Name_project";
            this.nameprojectDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameprojectDataGridViewTextBoxColumn.Name = "nameprojectDataGridViewTextBoxColumn";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "Date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // datefinishDataGridViewTextBoxColumn
            // 
            this.datefinishDataGridViewTextBoxColumn.DataPropertyName = "Date_finish";
            this.datefinishDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.datefinishDataGridViewTextBoxColumn.Name = "datefinishDataGridViewTextBoxColumn";
            // 
            // iDpartnerDataGridViewTextBoxColumn
            // 
            this.iDpartnerDataGridViewTextBoxColumn.DataPropertyName = "ID_partner";
            this.iDpartnerDataGridViewTextBoxColumn.DataSource = this.partnersBindingSource;
            this.iDpartnerDataGridViewTextBoxColumn.DisplayMember = "Name_partner";
            this.iDpartnerDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.iDpartnerDataGridViewTextBoxColumn.Name = "iDpartnerDataGridViewTextBoxColumn";
            this.iDpartnerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDpartnerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDpartnerDataGridViewTextBoxColumn.ValueMember = "ID_partner";
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.nbiDataSet;
            // 
            // nbiDataSet
            // 
            this.nbiDataSet.DataSetName = "nbiDataSet";
            this.nbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsprojectDataGridViewTextBoxColumn
            // 
            this.documentsprojectDataGridViewTextBoxColumn.DataPropertyName = "Documents_project";
            this.documentsprojectDataGridViewTextBoxColumn.HeaderText = "Документация";
            this.documentsprojectDataGridViewTextBoxColumn.Name = "documentsprojectDataGridViewTextBoxColumn";
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this.nbiDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BindingSource = this.projectsBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(1, 4);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1083, 25);
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
            this.groupBox1.Controls.Add(this.ChoiseDocumentsproject_Button);
            this.groupBox1.Controls.Add(this.Documentsproject_TextBox);
            this.groupBox1.Controls.Add(this.IDpartner_ComboBox);
            this.groupBox1.Controls.Add(this.Datefinish_DateTimePicker);
            this.groupBox1.Controls.Add(this.DateStart_DateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameProject_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IDproject_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(1, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о проектах (ручное заполнение)";
            // 
            // ChoiseDocumentsproject_Button
            // 
            this.ChoiseDocumentsproject_Button.Location = new System.Drawing.Point(1044, 85);
            this.ChoiseDocumentsproject_Button.Name = "ChoiseDocumentsproject_Button";
            this.ChoiseDocumentsproject_Button.Size = new System.Drawing.Size(33, 27);
            this.ChoiseDocumentsproject_Button.TabIndex = 14;
            this.ChoiseDocumentsproject_Button.Text = "...";
            this.ChoiseDocumentsproject_Button.UseVisualStyleBackColor = true;
            this.ChoiseDocumentsproject_Button.Click += new System.EventHandler(this.ChoiseDocumentsproject_Button_Click);
            // 
            // Documentsproject_TextBox
            // 
            this.Documentsproject_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Documents_project", true));
            this.Documentsproject_TextBox.Enabled = false;
            this.Documentsproject_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Documentsproject_TextBox.Location = new System.Drawing.Point(576, 87);
            this.Documentsproject_TextBox.Name = "Documentsproject_TextBox";
            this.Documentsproject_TextBox.Size = new System.Drawing.Size(462, 23);
            this.Documentsproject_TextBox.TabIndex = 13;
            // 
            // IDpartner_ComboBox
            // 
            this.IDpartner_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectsBindingSource, "ID_partner", true));
            this.IDpartner_ComboBox.DataSource = this.partnersBindingSource;
            this.IDpartner_ComboBox.DisplayMember = "Name_partner";
            this.IDpartner_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDpartner_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDpartner_ComboBox.FormattingEnabled = true;
            this.IDpartner_ComboBox.Location = new System.Drawing.Point(177, 86);
            this.IDpartner_ComboBox.Name = "IDpartner_ComboBox";
            this.IDpartner_ComboBox.Size = new System.Drawing.Size(222, 24);
            this.IDpartner_ComboBox.TabIndex = 12;
            this.IDpartner_ComboBox.ValueMember = "ID_partner";
            // 
            // Datefinish_DateTimePicker
            // 
            this.Datefinish_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Date_finish", true));
            this.Datefinish_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datefinish_DateTimePicker.Location = new System.Drawing.Point(574, 58);
            this.Datefinish_DateTimePicker.Name = "Datefinish_DateTimePicker";
            this.Datefinish_DateTimePicker.Size = new System.Drawing.Size(106, 23);
            this.Datefinish_DateTimePicker.TabIndex = 11;
            // 
            // DateStart_DateTimePicker
            // 
            this.DateStart_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Date_start", true));
            this.DateStart_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStart_DateTimePicker.Location = new System.Drawing.Point(177, 58);
            this.DateStart_DateTimePicker.Name = "DateStart_DateTimePicker";
            this.DateStart_DateTimePicker.Size = new System.Drawing.Size(106, 23);
            this.DateStart_DateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(405, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Путь к файлу проекта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Контрагент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(403, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата завершения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата начала:";
            // 
            // NameProject_TextBox
            // 
            this.NameProject_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "Name_project", true));
            this.NameProject_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NameProject_TextBox.Location = new System.Drawing.Point(574, 25);
            this.NameProject_TextBox.Name = "NameProject_TextBox";
            this.NameProject_TextBox.Size = new System.Drawing.Size(503, 23);
            this.NameProject_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(403, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование:";
            // 
            // IDproject_TextBox
            // 
            this.IDproject_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsBindingSource, "ID_project", true));
            this.IDproject_TextBox.Enabled = false;
            this.IDproject_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IDproject_TextBox.Location = new System.Drawing.Point(177, 25);
            this.IDproject_TextBox.Name = "IDproject_TextBox";
            this.IDproject_TextBox.Size = new System.Drawing.Size(67, 23);
            this.IDproject_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код:";
            // 
            // Documentsproject_OpenFileDialog
            // 
            this.Documentsproject_OpenFileDialog.FileName = "openFileDialog1";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(745, 474);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(339, 19);
            this.lblFormName.TabIndex = 58;
            this.lblFormName.Text = "Список проектов предприятия АО \"НБИ\"";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 509);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.Projects_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FProjects";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Form_Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Projects_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Projects_DataGridView;
        private nbiDataSet nbiDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private nbiDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private nbiDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
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
        private System.Windows.Forms.TextBox IDproject_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameProject_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateStart_DateTimePicker;
        private System.Windows.Forms.DateTimePicker Datefinish_DateTimePicker;
        private System.Windows.Forms.ComboBox IDpartner_ComboBox;
        private System.Windows.Forms.TextBox Documentsproject_TextBox;
        private System.Windows.Forms.Button ChoiseDocumentsproject_Button;
        private System.Windows.Forms.OpenFileDialog Documentsproject_OpenFileDialog;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDpartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsprojectDataGridViewTextBoxColumn;
    }
}