using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FProjects : Form
    {
        public FProjects()
        {
            InitializeComponent();
        }

        private void Form_Projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.nbiDataSet.Partners);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nbiDataSet.Projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.nbiDataSet.Projects);

        }
        //===Обработка нажатия кнопки "Записать" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.projectsBindingSource.EndEdit();
                this.projectsTableAdapter.Update(this.nbiDataSet.Projects);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
        //===Обработка нажатия кнопки "..." (выбор файла проекта)
        private void ChoiseDocumentsproject_Button_Click(object sender, EventArgs e)
        {
            Documentsproject_OpenFileDialog.Filter = "Docs files (*.docx, *.doc, *.rtf) | *.docx; *.doc; *.rtf";
            if (Documentsproject_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Documentsproject_TextBox.Text = Documentsproject_OpenFileDialog.FileName;
            }
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
