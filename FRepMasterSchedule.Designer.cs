
namespace NBI
{
    partial class FRepMasterSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRepMasterSchedule));
            this.Masterschedule_DataGridView = new System.Windows.Forms.DataGridView();
            this.nameprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet1 = new NBI.nbiDataSet1();
            this.calendarTableAdapter = new NBI.nbiDataSet1TableAdapters.CalendarTableAdapter();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Masterschedule_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Masterschedule_DataGridView
            // 
            this.Masterschedule_DataGridView.AutoGenerateColumns = false;
            this.Masterschedule_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Masterschedule_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Masterschedule_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameprojectDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.datefinishDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.datebeginDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn});
            this.Masterschedule_DataGridView.DataSource = this.calendarBindingSource;
            this.Masterschedule_DataGridView.Location = new System.Drawing.Point(2, 2);
            this.Masterschedule_DataGridView.Name = "Masterschedule_DataGridView";
            this.Masterschedule_DataGridView.ReadOnly = true;
            this.Masterschedule_DataGridView.Size = new System.Drawing.Size(1058, 426);
            this.Masterschedule_DataGridView.TabIndex = 0;
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
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datefinishDataGridViewTextBoxColumn
            // 
            this.datefinishDataGridViewTextBoxColumn.DataPropertyName = "Date_finish";
            this.datefinishDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
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
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО ответственного лица";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataMember = "Calendar";
            this.calendarBindingSource.DataSource = this.nbiDataSet1;
            // 
            // nbiDataSet1
            // 
            this.nbiDataSet1.DataSetName = "nbiDataSet1";
            this.nbiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarTableAdapter
            // 
            this.calendarTableAdapter.ClearBeforeFill = true;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFormName.Location = new System.Drawing.Point(513, 441);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(547, 19);
            this.lblFormName.TabIndex = 56;
            this.lblFormName.Text = "Сводный календарный план в разрезе проектов и задач АО \"НБИ\"";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(2, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 33);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FRepMasterSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 469);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Masterschedule_DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRepMasterSchedule";
            this.Text = "Сводный календарный план";
            this.Load += new System.EventHandler(this.Form_Rep_MasterSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Masterschedule_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Masterschedule_DataGridView;
        private nbiDataSet1 nbiDataSet1;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private nbiDataSet1TableAdapters.CalendarTableAdapter calendarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefinishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnClose;
    }
}