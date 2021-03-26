using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class Form_Users : Form
    {
        public Form_Users()
        {
            InitializeComponent();
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.nbiDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.nbiDataSet.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Individuals". При необходимости она может быть перемещена или удалена.
            this.individualsTableAdapter.Fill(this.nbiDataSet.Individuals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.nbiDataSet.Users);

        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this.nbiDataSet.Users);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
    }
}
