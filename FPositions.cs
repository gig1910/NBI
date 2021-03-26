using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FPositions : Form
    {
        public FPositions()
        {
            InitializeComponent();
        }

        private void Form_Positions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.nbiDataSet.Positions);

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
                this.positionsBindingSource.EndEdit();
                this.positionsTableAdapter.Update(this.nbiDataSet.Positions);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
    }
}
