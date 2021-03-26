using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FDepartments : Form
    {
        public FDepartments()
        {
            InitializeComponent();
        }

        private void Form_Departments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.nbiDataSet.Departments);

        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.departmentsBindingSource.EndEdit();
                this.departmentsTableAdapter.Update(this.nbiDataSet.Departments);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
