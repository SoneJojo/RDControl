namespace RDControl.App.Register
{
    partial class TechnicianForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCPF = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTechType = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboTechType);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtCPF);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtCPF, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(cboTechType, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(447, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(109, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            txtCPF.AnimateReadOnly = false;
            txtCPF.AutoCompleteMode = AutoCompleteMode.None;
            txtCPF.AutoCompleteSource = AutoCompleteSource.None;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.CharacterCasing = CharacterCasing.Normal;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(8, 60);
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.ReadOnly = false;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(318, 48);
            txtCPF.TabIndex = 9;
            txtCPF.TabStop = false;
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Technician Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(8, 6);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(433, 48);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // cboTechType
            // 
            cboTechType.AutoResize = false;
            cboTechType.BackColor = Color.FromArgb(255, 255, 255);
            cboTechType.Depth = 0;
            cboTechType.DrawMode = DrawMode.OwnerDrawVariable;
            cboTechType.DropDownHeight = 174;
            cboTechType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTechType.DropDownWidth = 121;
            cboTechType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTechType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTechType.FormattingEnabled = true;
            cboTechType.Hint = "Type";
            cboTechType.IntegralHeight = false;
            cboTechType.ItemHeight = 43;
            cboTechType.Location = new Point(332, 60);
            cboTechType.MaxDropDownItems = 4;
            cboTechType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTechType.Name = "cboTechType";
            cboTechType.Size = new Size(224, 49);
            cboTechType.StartIndex = 0;
            cboTechType.TabIndex = 11;
            // 
            // TechnicianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "TechnicianForm";
            Text = "TechnicianForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialComboBox cboTechType;
    }
}