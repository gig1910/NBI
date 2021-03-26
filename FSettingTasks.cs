using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class Form_SettingTasks : Form
    {
        public Form_SettingTasks()
        {
            InitializeComponent();
        }

        private void Form_SettingTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.nbiDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Calendar_projects". При необходимости она может быть перемещена или удалена.
            this.calendar_projectsTableAdapter.Fill(this.nbiDataSet.Calendar_projects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.nbiDataSet.Tasks);

        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tasksBindingSource.EndEdit();
                this.tasksTableAdapter.Update(this.nbiDataSet.Tasks);
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
        //===Обработка нажатия кнопки "..." (выбор файла постановки задачи)
        private void ChoiseDocumenttask_Button_Click(object sender, EventArgs e)
        {
            Documenttask_OpenFileDialog.Filter = "Docs files (*.docx, *.doc, *.rtf) | *.docx; *.doc; *.rtf";
            if (Documenttask_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Documenttask_TextBox.Text = Documenttask_OpenFileDialog.FileName;
            }
        }
    }
}
