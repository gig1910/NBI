using System;
using System.Windows.Forms;

namespace NBI
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
