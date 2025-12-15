namespace RDControl.App.Register
{
    partial class PlaceForm
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
            txtPlace = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboClient = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboClient);
            tabPageRegister.Controls.Add(txtAddress);
            tabPageRegister.Controls.Add(txtPlace);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtPlace, 0);
            tabPageRegister.Controls.SetChildIndex(txtAddress, 0);
            tabPageRegister.Controls.SetChildIndex(cboClient, 0);
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
            txtId.Location = new Point(381, 6);
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
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtPlace
            // 
            txtPlace.AnimateReadOnly = false;
            txtPlace.AutoCompleteMode = AutoCompleteMode.None;
            txtPlace.AutoCompleteSource = AutoCompleteSource.None;
            txtPlace.BackgroundImageLayout = ImageLayout.None;
            txtPlace.CharacterCasing = CharacterCasing.Normal;
            txtPlace.Depth = 0;
            txtPlace.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlace.HideSelection = true;
            txtPlace.Hint = "Place";
            txtPlace.LeadingIcon = null;
            txtPlace.Location = new Point(6, 6);
            txtPlace.MaxLength = 32767;
            txtPlace.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlace.Name = "txtPlace";
            txtPlace.PasswordChar = '\0';
            txtPlace.PrefixSuffixText = null;
            txtPlace.ReadOnly = false;
            txtPlace.RightToLeft = RightToLeft.No;
            txtPlace.SelectedText = "";
            txtPlace.SelectionLength = 0;
            txtPlace.SelectionStart = 0;
            txtPlace.ShortcutsEnabled = true;
            txtPlace.Size = new Size(369, 48);
            txtPlace.TabIndex = 13;
            txtPlace.TabStop = false;
            txtPlace.TextAlign = HorizontalAlignment.Left;
            txtPlace.TrailingIcon = null;
            txtPlace.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.AutoCompleteMode = AutoCompleteMode.None;
            txtAddress.AutoCompleteSource = AutoCompleteSource.None;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(6, 60);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.ReadOnly = false;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(484, 48);
            txtAddress.TabIndex = 14;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // cboClient
            // 
            cboClient.AutoResize = false;
            cboClient.BackColor = Color.FromArgb(255, 255, 255);
            cboClient.Depth = 0;
            cboClient.DrawMode = DrawMode.OwnerDrawVariable;
            cboClient.DropDownHeight = 174;
            cboClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClient.DropDownWidth = 121;
            cboClient.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboClient.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboClient.FormattingEnabled = true;
            cboClient.Hint = "Client";
            cboClient.IntegralHeight = false;
            cboClient.ItemHeight = 43;
            cboClient.Location = new Point(6, 114);
            cboClient.MaxDropDownItems = 4;
            cboClient.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboClient.Name = "cboClient";
            cboClient.Size = new Size(484, 49);
            cboClient.StartIndex = 0;
            cboClient.TabIndex = 15;
            // 
            // PlaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "PlaceForm";
            Text = "PlaceForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlace;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAddress;
        private ReaLTaiizor.Controls.MaterialComboBox cboClient;
    }
}