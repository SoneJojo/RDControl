namespace RDControl.App.Register
{
    partial class EquipmentForm
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
            txtSerial = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtModel = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtID = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPlace = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboPlace);
            tabPageRegister.Controls.Add(txtID);
            tabPageRegister.Controls.Add(txtModel);
            tabPageRegister.Controls.Add(txtSerial);
            tabPageRegister.Controls.SetChildIndex(txtSerial, 0);
            tabPageRegister.Controls.SetChildIndex(txtModel, 0);
            tabPageRegister.Controls.SetChildIndex(txtID, 0);
            tabPageRegister.Controls.SetChildIndex(cboPlace, 0);
            // 
            // txtSerial
            // 
            txtSerial.AnimateReadOnly = false;
            txtSerial.AutoCompleteMode = AutoCompleteMode.None;
            txtSerial.AutoCompleteSource = AutoCompleteSource.None;
            txtSerial.BackgroundImageLayout = ImageLayout.None;
            txtSerial.CharacterCasing = CharacterCasing.Normal;
            txtSerial.Depth = 0;
            txtSerial.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSerial.HideSelection = true;
            txtSerial.Hint = "Serial Number";
            txtSerial.LeadingIcon = null;
            txtSerial.Location = new Point(8, 6);
            txtSerial.MaxLength = 32767;
            txtSerial.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSerial.Name = "txtSerial";
            txtSerial.PasswordChar = '\0';
            txtSerial.PrefixSuffixText = null;
            txtSerial.ReadOnly = false;
            txtSerial.RightToLeft = RightToLeft.No;
            txtSerial.SelectedText = "";
            txtSerial.SelectionLength = 0;
            txtSerial.SelectionStart = 0;
            txtSerial.ShortcutsEnabled = true;
            txtSerial.Size = new Size(317, 48);
            txtSerial.TabIndex = 2;
            txtSerial.TabStop = false;
            txtSerial.TextAlign = HorizontalAlignment.Left;
            txtSerial.TrailingIcon = null;
            txtSerial.UseSystemPasswordChar = false;
            // 
            // txtModel
            // 
            txtModel.AnimateReadOnly = false;
            txtModel.AutoCompleteMode = AutoCompleteMode.None;
            txtModel.AutoCompleteSource = AutoCompleteSource.None;
            txtModel.BackgroundImageLayout = ImageLayout.None;
            txtModel.CharacterCasing = CharacterCasing.Normal;
            txtModel.Depth = 0;
            txtModel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModel.HideSelection = true;
            txtModel.Hint = "Model";
            txtModel.LeadingIcon = null;
            txtModel.Location = new Point(331, 6);
            txtModel.MaxLength = 32767;
            txtModel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PrefixSuffixText = null;
            txtModel.ReadOnly = false;
            txtModel.RightToLeft = RightToLeft.No;
            txtModel.SelectedText = "";
            txtModel.SelectionLength = 0;
            txtModel.SelectionStart = 0;
            txtModel.ShortcutsEnabled = true;
            txtModel.Size = new Size(278, 48);
            txtModel.TabIndex = 3;
            txtModel.TabStop = false;
            txtModel.TextAlign = HorizontalAlignment.Left;
            txtModel.TrailingIcon = null;
            txtModel.UseSystemPasswordChar = false;
            // 
            // txtID
            // 
            txtID.AnimateReadOnly = false;
            txtID.AutoCompleteMode = AutoCompleteMode.None;
            txtID.AutoCompleteSource = AutoCompleteSource.None;
            txtID.BackgroundImageLayout = ImageLayout.None;
            txtID.CharacterCasing = CharacterCasing.Normal;
            txtID.Depth = 0;
            txtID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtID.HideSelection = true;
            txtID.Hint = "ID";
            txtID.LeadingIcon = null;
            txtID.Location = new Point(478, 60);
            txtID.MaxLength = 32767;
            txtID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtID.Name = "txtID";
            txtID.PasswordChar = '\0';
            txtID.PrefixSuffixText = null;
            txtID.ReadOnly = false;
            txtID.RightToLeft = RightToLeft.No;
            txtID.SelectedText = "";
            txtID.SelectionLength = 0;
            txtID.SelectionStart = 0;
            txtID.ShortcutsEnabled = true;
            txtID.Size = new Size(131, 48);
            txtID.TabIndex = 5;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.TrailingIcon = null;
            txtID.UseSystemPasswordChar = false;
            // 
            // cboPlace
            // 
            cboPlace.AutoResize = false;
            cboPlace.BackColor = Color.FromArgb(255, 255, 255);
            cboPlace.Depth = 0;
            cboPlace.DrawMode = DrawMode.OwnerDrawVariable;
            cboPlace.DropDownHeight = 174;
            cboPlace.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlace.DropDownWidth = 121;
            cboPlace.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPlace.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPlace.FormattingEnabled = true;
            cboPlace.Hint = "Place";
            cboPlace.IntegralHeight = false;
            cboPlace.ItemHeight = 43;
            cboPlace.Location = new Point(8, 60);
            cboPlace.MaxDropDownItems = 4;
            cboPlace.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPlace.Name = "cboPlace";
            cboPlace.Size = new Size(464, 49);
            cboPlace.StartIndex = 0;
            cboPlace.TabIndex = 6;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "EquipmentForm";
            Text = "EquipmentForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSerial;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtID;
        private ReaLTaiizor.Controls.MaterialComboBox cboPlace;
    }
}