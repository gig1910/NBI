using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FExecutionTasks : Form
    {
        public FExecutionTasks()
        {
            InitializeComponent();
        }

        private void Form_ExecutionTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.nbiDataSet.Tasks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Task_executions". При необходимости она может быть перемещена или удалена.
            this.task_executionsTableAdapter.Fill(this.nbiDataSet.Task_executions);

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
                this.taskexecutionsBindingSource.EndEdit();
                this.task_executionsTableAdapter.Update(this.nbiDataSet.Task_executions);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
        //===Обработка нажатия кнопки "..." (путь к документам по исполнению задачи)
        private void ChoiseAddress_Button_Click(object sender, EventArgs e)
        {
            Docs_OpenFileDialog.Filter = "Docs files (*.docx, *.doc, *.rtf) | *.docx; *.doc; *.rtf";
            if (Docs_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Docs_TextBox.Text = Docs_OpenFileDialog.FileName;
            }
        }
    }
}
