using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FPartners : Form
    {
        public FPartners()
        {
            InitializeComponent();
        }

        private void Form_Partners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.nbiDataSet.Partners);

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
                this.partnersBindingSource.EndEdit();
                this.partnersTableAdapter.Update(this.nbiDataSet.Partners);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
    }
}
