using ReaLTaiizor.Controls;

namespace RDControl.App.Base
{
    public partial class BaseRegisterForm : BaseForm
    {
        #region Variables
        protected bool IsEditMode = false;
        #endregion

        #region Constructor Method
        public BaseRegisterForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", @"Duda RD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete?", @"Duda RD", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateGrid();
                }
            }
            else
            {
                MessageBox.Show("Please, select any row", @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tabPageList_Enter(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        #endregion

        #region Methods
        private void ClearFields() //Maybe change from materialtextbox to other control if needed
        {
            IsEditMode = false;
            foreach (var control in tabControlRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }
        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }
        protected virtual void Save()
        {

        }
        protected virtual void Delete(int id)
        {

        }
        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show("Please, select any row", @"Duda RD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        protected virtual void GridToForm(DataGridViewRow? record)
        {

        }
        protected virtual void PopulateGrid()
        {

        }
        #endregion
    }
}
