namespace RDControl.App.Register
{
    partial class ClientForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCNPJ = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(txtCNPJ);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtCNPJ, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
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
            txtName.Hint = "Client Name";
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
            txtName.TabIndex = 5;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtCNPJ
            // 
            txtCNPJ.AnimateReadOnly = false;
            txtCNPJ.AutoCompleteMode = AutoCompleteMode.None;
            txtCNPJ.AutoCompleteSource = AutoCompleteSource.None;
            txtCNPJ.BackgroundImageLayout = ImageLayout.None;
            txtCNPJ.CharacterCasing = CharacterCasing.Normal;
            txtCNPJ.Depth = 0;
            txtCNPJ.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCNPJ.HideSelection = true;
            txtCNPJ.Hint = "CNPJ";
            txtCNPJ.LeadingIcon = null;
            txtCNPJ.Location = new Point(8, 60);
            txtCNPJ.MaxLength = 32767;
            txtCNPJ.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PasswordChar = '\0';
            txtCNPJ.PrefixSuffixText = null;
            txtCNPJ.ReadOnly = false;
            txtCNPJ.RightToLeft = RightToLeft.No;
            txtCNPJ.SelectedText = "";
            txtCNPJ.SelectionLength = 0;
            txtCNPJ.SelectionStart = 0;
            txtCNPJ.ShortcutsEnabled = true;
            txtCNPJ.Size = new Size(318, 48);
            txtCNPJ.TabIndex = 6;
            txtCNPJ.TabStop = false;
            txtCNPJ.TextAlign = HorizontalAlignment.Left;
            txtCNPJ.TrailingIcon = null;
            txtCNPJ.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(332, 60);
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
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ClientForm";
            Text = "ClientForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCNPJ;
    }
}