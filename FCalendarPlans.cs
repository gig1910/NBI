using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FCalendarPlans : Form
    {
        public FCalendarPlans()
        {
            InitializeComponent();
        }

        private void Form_CalendarPlans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.nbiDataSet.Projects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Calendar_projects". При необходимости она может быть перемещена или удалена.
            this.calendar_projectsTableAdapter.Fill(this.nbiDataSet.Calendar_projects);

        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.calendarprojectsBindingSource.EndEdit();
                this.calendar_projectsTableAdapter.Update(this.nbiDataSet.Calendar_projects);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IDproject_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetFilePath_Click(object sender, EventArgs e)
        {
            Calendarplan_OpenFileDialog.Filter = "Docs files (*.docx, *.doc, *.rtf) | *.docx; *.doc; *.rtf";
            if (Calendarplan_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Calendarplan_TextBox.Text = Calendarplan_OpenFileDialog.FileName;
            }
        }
    }
}
