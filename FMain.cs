using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        //===Обработка события закрытия формы (закрытие всего приложения)
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            FAuth Form_Auth = new FAuth();
            Form_Auth.Close();
            Application.Exit();
        }
        //===Обработка выбора пункта меню "Справочники -> Физические лица"
        private void физическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIndividuals Form_Individuals = new FIndividuals();
            Form_Individuals.ShowDialog();
        }
        //===Обработка выбора пункта меню "Документы -> Исполнение задач"
        private void исполнениеЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FExecutionTasks Form_ExecutionTasks = new FExecutionTasks();
            Form_ExecutionTasks.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Подразделения"
        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDepartments Form_Departments = new FDepartments();
            Form_Departments.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Должности"
        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPositions Form_Positions = new FPositions();
            Form_Positions.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Сотрудники"
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Users Form_Users = new Form_Users();
            Form_Users.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Контрагенты"
        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPartners Form_Partners = new FPartners();
            Form_Partners.ShowDialog();
        }
        //===Обработка выбора пункта меню "Документы -> Календарные планы"
        private void календарныеПланыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCalendarPlans Form_CalendarPlans = new FCalendarPlans();
            Form_CalendarPlans.ShowDialog();
        }
        //===Обработка выбора пункта меню "Документы -> Проекты"
        private void проектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProjects Form_Projects = new FProjects();
            Form_Projects.ShowDialog();
        }
        //===Обработка выбора пункта меню "Документы -> Постановка задач"
        private void постановкаЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SettingTasks Form_SettingTasks = new Form_SettingTasks();
            Form_SettingTasks.ShowDialog();
        }
        //===Обработка выбора пункта меню "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAbout Form_About = new FAbout();
            Form_About.ShowDialog();
        }
        //===Обработка выбора пункта меню "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //===Обработка выбора пункта меню "Отчеты -> Сводный календарный план"
        private void сводныйКалендарныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRepMasterSchedule Form_Rep_MasterSchedule = new FRepMasterSchedule();
            Form_Rep_MasterSchedule.ShowDialog();
        }
        //===Обработка выбора пункта меню "Отчеты -> Анализ выполнения задач (план/факт)"
        private void анализВыполненияЗадачпланфактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Rep_TaskPerformance Form_Rep_TaskPerformance = new Form_Rep_TaskPerformance();
            Form_Rep_TaskPerformance.ShowDialog();
        }
        //===Обработка события загрузки формы
        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (FAuth.User_Rights != 1)
            {
                справочникиToolStripMenuItem.Enabled = false;
                groupBox1.Enabled = false;
            }
        }
    }
}
