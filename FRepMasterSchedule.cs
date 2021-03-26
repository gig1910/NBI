using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FRepMasterSchedule : Form
    {
        public FRepMasterSchedule()
        {
            InitializeComponent();
        }

        private void Form_Rep_MasterSchedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet1.Calendar". При необходимости она может быть перемещена или удалена.
            this.calendarTableAdapter.Fill(this.nbiDataSet1.Calendar);

        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
