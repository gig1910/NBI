using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FIndividuals : Form
    {
        public FIndividuals()
        {
            InitializeComponent();
        }

        private void Form_Individuals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Individuals". При необходимости она может быть перемещена или удалена.
            this.individualsTableAdapter.Fill(this.nbiDataSet.Individuals);

        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.individualsBindingSource.EndEdit();
                this.individualsTableAdapter.Update(this.nbiDataSet.Individuals);
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
