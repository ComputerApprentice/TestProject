namespace CSC240_06_01_BedAndBreakfast_DG
{
    public partial class UxBaileysForm : Form
    {
        public UxBaileysForm()
        {
            InitializeComponent();
        }

        private void belleaireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleaireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleaireCheckBox.Checked = false;
            }
        }

        private void lincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckBox.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                lincolnCheckBox.Checked = false;
            }
        }
    }
}
