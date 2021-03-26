
namespace NBI
{
    partial class Form_Rep_TaskPerformance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rep_TaskPerformance));
            this.TaskPerformance_DataGridView = new System.Windows.Forms.DataGridView();
            this.nameprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborfactorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartfactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishfactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planfactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet1 = new NBI.nbiDataSet1();
            this.plan_factTableAdapter = new NBI.nbiDataSet1TableAdapters.Plan_factTableAdapter();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPerformance_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planfactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskPerformance_DataGridView
            // 
            this.TaskPerformance_DataGridView.AutoGenerateColumns = false;
            this.TaskPerformance_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskPerformance_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskPerformance_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameprojectDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.datefinishDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.laborfactorDataGridViewTextBoxColumn,
            this.datebeginDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.datestartfactDataGridViewTextBoxColumn,
            this.datefinishfactDataGridViewTextBoxColumn});
            this.TaskPerformance_DataGridView.DataSource = this.planfactBindingSource;
            this.TaskPerformance_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaskPerformance_DataGridView.Name = "TaskPerformance_DataGridView";
            this.TaskPerformance_DataGridView.ReadOnly = true;
            this.TaskPerformance_DataGridView.Size = new System.Drawing.Size(1093, 375);
            this.TaskPerformance_DataGridView.TabIndex = 0;
            // 
            // nameprojectDataGridViewTextBoxColumn
            // 
            this.nameprojectDataGridViewTextBoxColumn.DataPropertyName = "Name_project";
            this.nameprojectDataGridViewTextBoxColumn.HeaderText = "Наименование проекта";
            this.nameprojectDataGridViewTextBoxColumn.Name = "nameprojectDataGridViewTextBoxColumn";
            this.nameprojectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "Date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата начала проекта";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datefinishDataGridViewTextBoxColumn
            // 
            this.datefinishDataGridViewTextBoxColumn.DataPropertyName = "Date_finish";
            this.datefinishDataGridViewTextBoxColumn.HeaderText = "Дата завершения проекта";
            this.datefinishDataGridViewTextBoxColumn.Name = "datefinishDataGridViewTextBoxColumn";
            this.datefinishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "Name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Наименование задачи";
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            this.nametaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laborfactorDataGridViewTextBoxColumn
            // 
            this.laborfactorDataGridViewTextBoxColumn.DataPropertyName = "Labor_factor";
            this.laborfactorDataGridViewTextBoxColumn.HeaderText = "Коэффициент сложности задачи";
            this.laborfactorDataGridViewTextBoxColumn.Name = "laborfactorDataGridViewTextBoxColumn";
            this.laborfactorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datebeginDataGridViewTextBoxColumn
            // 
            this.datebeginDataGridViewTextBoxColumn.DataPropertyName = "Date_begin";
            this.datebeginDataGridViewTextBoxColumn.HeaderText = "Дата начала задачи (план.)";
            this.datebeginDataGridViewTextBoxColumn.Name = "datebeginDataGridViewTextBoxColumn";
            this.datebeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "Date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "Дата завершения задачи (план.)";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            this.dateendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datestartfactDataGridViewTextBoxColumn
            // 
            this.datestartfactDataGridViewTextBoxColumn.DataPropertyName = "Date_start_fact";
            this.datestartfactDataGridViewTextBoxColumn.HeaderText = "Дата начала задачи (факт.)";
            this.datestartfactDataGridViewTextBoxColumn.Name = "datestartfactDataGridViewTextBoxColumn";
            this.datestartfactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datefinishfactDataGridViewTextBoxColumn
            // 
            this.datefinishfactDataGridViewTextBoxColumn.DataPropertyName = "Date_finish_fact";
            this.datefinishfactDataGridViewTextBoxColumn.HeaderText = "Дата завершения задачи (факт.)";
            this.datefinishfactDataGridViewTextBoxColumn.Name = "datefinishfactDataGridViewTextBoxColumn";
            this.datefinishfactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planfactBindingSource
            // 
            this.planfactBindingSource.DataMember = "Plan_fact";
            this.planfactBindingSource.DataSource = this.nbiDataSet1;
            // 
            // nbiDataSet1
            // 
            this.nbiDataSet1.DataSetName = "nbiDataSet1";
            this.nbiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plan_factTableAdapter
            // 
            this.plan_factTableAdapter.ClearBeforeFill = true;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(695, 391);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(401, 19);
            this.lblFormName.TabIndex = 58;
            this.lblFormName.Text = "Анализ выполнения задач (план/факт) АО \"НБИ\"";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(3, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Rep_TaskPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 420);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TaskPerformance_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Rep_TaskPerformance";
            this.Text = "Анализ выполнения задач (план/факт)";
            this.Load += new System.EventHandler(this.Form_Rep_TaskPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskPerformance_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planfactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskPerformance_DataGridView;
        private nbiDataSet1 nbiDataSet1;
        private System.Windows.Forms.BindingSource planfactBindingSource;
        private nbiDataSet1TableAdapters.Plan_factTableAdapter plan_factTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborfactorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartfactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishfactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
    }
}