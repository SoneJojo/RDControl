using Microsoft.Extensions.DependencyInjection;
using RDControl.App.Base;
using RDControl.App.Infra;
using RDControl.App.Register;

namespace RDControl.App
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region events
        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<EquipmentForm>();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<ReportForm>();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<ClientForm>();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<UserForm>();
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<PlaceForm>();
        }

        private void technicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<TechnicianForm>();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
        #endregion
        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
