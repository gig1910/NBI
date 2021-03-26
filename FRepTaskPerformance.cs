using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class Form_Rep_TaskPerformance : Form
    {
        public Form_Rep_TaskPerformance()
        {
            InitializeComponent();
        }

        private void Form_Rep_TaskPerformance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet1.Plan_fact". При необходимости она может быть перемещена или удалена.
            this.plan_factTableAdapter.Fill(this.nbiDataSet1.Plan_fact);

        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
