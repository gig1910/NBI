
namespace NBI
{
    partial class FAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAuth));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nbiDataSet = new NBI.nbiDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new NBI.nbiDataSetTableAdapters.UsersTableAdapter();
            this.Users_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDindividualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(187, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 32);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLogin.Location = new System.Drawing.Point(12, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 19);
            this.lblLogin.TabIndex = 52;
            this.lblLogin.Text = "Логин :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(12, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 19);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Пароль :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(16, 124);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 32);
            this.btnLogin.TabIndex = 55;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(116, 61);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(215, 26);
            this.tbPassword.TabIndex = 54;
            // 
            // cbLogin
            // 
            this.cbLogin.BackColor = System.Drawing.Color.Silver;
            this.cbLogin.DataSource = this.usersBindingSource1;
            this.cbLogin.DisplayMember = "Name_user";
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(116, 12);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(215, 27);
            this.cbLogin.TabIndex = 53;
            this.cbLogin.ValueMember = "ID_user";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.nbiDataSet;
            // 
            // nbiDataSet
            // 
            this.nbiDataSet.DataSetName = "nbiDataSet";
            this.nbiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.nbiDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Users_DataGridView
            // 
            this.Users_DataGridView.AllowUserToOrderColumns = true;
            this.Users_DataGridView.AutoGenerateColumns = false;
            this.Users_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDuserDataGridViewTextBoxColumn,
            this.nameuserDataGridViewTextBoxColumn,
            this.iDindividualDataGridViewTextBoxColumn,
            this.iDdepartmentDataGridViewTextBoxColumn,
            this.iDpositionDataGridViewTextBoxColumn});
            this.Users_DataGridView.DataSource = this.usersBindingSource1;
            this.Users_DataGridView.Location = new System.Drawing.Point(16, 93);
            this.Users_DataGridView.Name = "Users_DataGridView";
            this.Users_DataGridView.Size = new System.Drawing.Size(315, 26);
            this.Users_DataGridView.TabIndex = 59;
            this.Users_DataGridView.Visible = false;
            // 
            // iDuserDataGridViewTextBoxColumn
            // 
            this.iDuserDataGridViewTextBoxColumn.DataPropertyName = "ID_user";
            this.iDuserDataGridViewTextBoxColumn.HeaderText = "ID_user";
            this.iDuserDataGridViewTextBoxColumn.Name = "iDuserDataGridViewTextBoxColumn";
            this.iDuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameuserDataGridViewTextBoxColumn
            // 
            this.nameuserDataGridViewTextBoxColumn.DataPropertyName = "Name_user";
            this.nameuserDataGridViewTextBoxColumn.HeaderText = "Name_user";
            this.nameuserDataGridViewTextBoxColumn.Name = "nameuserDataGridViewTextBoxColumn";
            // 
            // iDindividualDataGridViewTextBoxColumn
            // 
            this.iDindividualDataGridViewTextBoxColumn.DataPropertyName = "ID_individual";
            this.iDindividualDataGridViewTextBoxColumn.HeaderText = "ID_individual";
            this.iDindividualDataGridViewTextBoxColumn.Name = "iDindividualDataGridViewTextBoxColumn";
            // 
            // iDdepartmentDataGridViewTextBoxColumn
            // 
            this.iDdepartmentDataGridViewTextBoxColumn.DataPropertyName = "ID_department";
            this.iDdepartmentDataGridViewTextBoxColumn.HeaderText = "ID_department";
            this.iDdepartmentDataGridViewTextBoxColumn.Name = "iDdepartmentDataGridViewTextBoxColumn";
            // 
            // iDpositionDataGridViewTextBoxColumn
            // 
            this.iDpositionDataGridViewTextBoxColumn.DataPropertyName = "ID_position";
            this.iDpositionDataGridViewTextBoxColumn.HeaderText = "ID_position";
            this.iDpositionDataGridViewTextBoxColumn.Name = "iDpositionDataGridViewTextBoxColumn";
            // 
            // FAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 163);
            this.Controls.Add(this.Users_DataGridView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAuth";
            this.Text = "Авторизация в системе";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.Label lblLogin;
        private nbiDataSet nbiDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private nbiDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView Users_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDindividualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDpositionDataGridViewTextBoxColumn;
    }
}
