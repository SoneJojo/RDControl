namespace RDControl.App.Register
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            cboTechnician = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox2 = new PictureBox();
            txtDescription = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cboUser = new ReaLTaiizor.Controls.MaterialComboBox();
            cboEquipment = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSituation = new ReaLTaiizor.Controls.MaterialComboBox();
            txtObservation = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            cboPayment = new ReaLTaiizor.Controls.MaterialComboBox();
            txtTicket = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHours = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHourlyRate = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dtpDate = new ReaLTaiizor.Controls.PoisonDateTime();
            lblDate = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(lblDate);
            tabPageRegister.Controls.Add(dtpDate);
            tabPageRegister.Controls.Add(txtHourlyRate);
            tabPageRegister.Controls.Add(txtHours);
            tabPageRegister.Controls.Add(txtTicket);
            tabPageRegister.Controls.Add(cboPayment);
            tabPageRegister.Controls.Add(txtObservation);
            tabPageRegister.Controls.Add(cboSituation);
            tabPageRegister.Controls.Add(cboEquipment);
            tabPageRegister.Controls.Add(cboUser);
            tabPageRegister.Controls.Add(txtDescription);
            tabPageRegister.Controls.Add(pictureBox2);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(cboTechnician);
            tabPageRegister.Controls.SetChildIndex(cboTechnician, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(pictureBox2, 0);
            tabPageRegister.Controls.SetChildIndex(txtDescription, 0);
            tabPageRegister.Controls.SetChildIndex(cboUser, 0);
            tabPageRegister.Controls.SetChildIndex(cboEquipment, 0);
            tabPageRegister.Controls.SetChildIndex(cboSituation, 0);
            tabPageRegister.Controls.SetChildIndex(txtObservation, 0);
            tabPageRegister.Controls.SetChildIndex(cboPayment, 0);
            tabPageRegister.Controls.SetChildIndex(txtTicket, 0);
            tabPageRegister.Controls.SetChildIndex(txtHours, 0);
            tabPageRegister.Controls.SetChildIndex(txtHourlyRate, 0);
            tabPageRegister.Controls.SetChildIndex(dtpDate, 0);
            tabPageRegister.Controls.SetChildIndex(lblDate, 0);
            // 
            // cboTechnician
            // 
            cboTechnician.AutoResize = false;
            cboTechnician.BackColor = Color.FromArgb(255, 255, 255);
            cboTechnician.Depth = 0;
            cboTechnician.DrawMode = DrawMode.OwnerDrawVariable;
            cboTechnician.DropDownHeight = 174;
            cboTechnician.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTechnician.DropDownWidth = 121;
            cboTechnician.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTechnician.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTechnician.FormattingEnabled = true;
            cboTechnician.Hint = "Technician";
            cboTechnician.IntegralHeight = false;
            cboTechnician.ItemHeight = 43;
            cboTechnician.Location = new Point(6, 60);
            cboTechnician.MaxDropDownItems = 4;
            cboTechnician.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTechnician.Name = "cboTechnician";
            cboTechnician.Size = new Size(239, 49);
            cboTechnician.StartIndex = 0;
            cboTechnician.TabIndex = 16;
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
            txtId.Location = new Point(60, 6);
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
            txtId.Size = new Size(131, 48);
            txtId.TabIndex = 17;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.AnimateReadOnly = false;
            txtDescription.BackgroundImageLayout = ImageLayout.None;
            txtDescription.CharacterCasing = CharacterCasing.Normal;
            txtDescription.Depth = 0;
            txtDescription.HideSelection = true;
            txtDescription.Hint = "Description";
            txtDescription.Location = new Point(496, 6);
            txtDescription.MaxLength = 32767;
            txtDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ReadOnly = false;
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.ShortcutsEnabled = true;
            txtDescription.Size = new Size(250, 158);
            txtDescription.TabIndex = 20;
            txtDescription.TabStop = false;
            txtDescription.TextAlign = HorizontalAlignment.Left;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // cboUser
            // 
            cboUser.AutoResize = false;
            cboUser.BackColor = Color.FromArgb(255, 255, 255);
            cboUser.Depth = 0;
            cboUser.DrawMode = DrawMode.OwnerDrawVariable;
            cboUser.DropDownHeight = 174;
            cboUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUser.DropDownWidth = 121;
            cboUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUser.FormattingEnabled = true;
            cboUser.Hint = "User";
            cboUser.IntegralHeight = false;
            cboUser.ItemHeight = 43;
            cboUser.Location = new Point(6, 115);
            cboUser.MaxDropDownItems = 4;
            cboUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUser.Name = "cboUser";
            cboUser.Size = new Size(239, 49);
            cboUser.StartIndex = 0;
            cboUser.TabIndex = 21;
            // 
            // cboEquipment
            // 
            cboEquipment.AutoResize = false;
            cboEquipment.BackColor = Color.FromArgb(255, 255, 255);
            cboEquipment.Depth = 0;
            cboEquipment.DrawMode = DrawMode.OwnerDrawVariable;
            cboEquipment.DropDownHeight = 174;
            cboEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipment.DropDownWidth = 121;
            cboEquipment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEquipment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEquipment.FormattingEnabled = true;
            cboEquipment.Hint = "Equipment ID";
            cboEquipment.IntegralHeight = false;
            cboEquipment.ItemHeight = 43;
            cboEquipment.Location = new Point(197, 6);
            cboEquipment.MaxDropDownItems = 4;
            cboEquipment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEquipment.Name = "cboEquipment";
            cboEquipment.Size = new Size(136, 49);
            cboEquipment.StartIndex = 0;
            cboEquipment.TabIndex = 22;
            // 
            // cboSituation
            // 
            cboSituation.AutoResize = false;
            cboSituation.BackColor = Color.FromArgb(255, 255, 255);
            cboSituation.Depth = 0;
            cboSituation.DrawMode = DrawMode.OwnerDrawVariable;
            cboSituation.DropDownHeight = 174;
            cboSituation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituation.DropDownWidth = 121;
            cboSituation.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSituation.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSituation.FormattingEnabled = true;
            cboSituation.Hint = "Situation";
            cboSituation.IntegralHeight = false;
            cboSituation.ItemHeight = 43;
            cboSituation.Location = new Point(251, 61);
            cboSituation.MaxDropDownItems = 4;
            cboSituation.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSituation.Name = "cboSituation";
            cboSituation.Size = new Size(239, 49);
            cboSituation.StartIndex = 0;
            cboSituation.TabIndex = 23;
            // 
            // txtObservation
            // 
            txtObservation.AnimateReadOnly = false;
            txtObservation.BackgroundImageLayout = ImageLayout.None;
            txtObservation.CharacterCasing = CharacterCasing.Normal;
            txtObservation.Depth = 0;
            txtObservation.HideSelection = true;
            txtObservation.Hint = "Observation";
            txtObservation.Location = new Point(496, 170);
            txtObservation.MaxLength = 32767;
            txtObservation.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservation.Name = "txtObservation";
            txtObservation.PasswordChar = '\0';
            txtObservation.ReadOnly = false;
            txtObservation.ScrollBars = ScrollBars.None;
            txtObservation.SelectedText = "";
            txtObservation.SelectionLength = 0;
            txtObservation.SelectionStart = 0;
            txtObservation.ShortcutsEnabled = true;
            txtObservation.Size = new Size(250, 158);
            txtObservation.TabIndex = 24;
            txtObservation.TabStop = false;
            txtObservation.TextAlign = HorizontalAlignment.Left;
            txtObservation.UseSystemPasswordChar = false;
            // 
            // cboPayment
            // 
            cboPayment.AutoResize = false;
            cboPayment.BackColor = Color.FromArgb(255, 255, 255);
            cboPayment.Depth = 0;
            cboPayment.DrawMode = DrawMode.OwnerDrawVariable;
            cboPayment.DropDownHeight = 174;
            cboPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPayment.DropDownWidth = 121;
            cboPayment.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPayment.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPayment.FormattingEnabled = true;
            cboPayment.Hint = "Payment Type";
            cboPayment.IntegralHeight = false;
            cboPayment.ItemHeight = 43;
            cboPayment.Location = new Point(6, 170);
            cboPayment.MaxDropDownItems = 4;
            cboPayment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(239, 49);
            cboPayment.StartIndex = 0;
            cboPayment.TabIndex = 25;
            // 
            // txtTicket
            // 
            txtTicket.AnimateReadOnly = false;
            txtTicket.AutoCompleteMode = AutoCompleteMode.None;
            txtTicket.AutoCompleteSource = AutoCompleteSource.None;
            txtTicket.BackgroundImageLayout = ImageLayout.None;
            txtTicket.CharacterCasing = CharacterCasing.Normal;
            txtTicket.Depth = 0;
            txtTicket.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTicket.HideSelection = true;
            txtTicket.Hint = "Ticket Reason";
            txtTicket.LeadingIcon = null;
            txtTicket.Location = new Point(6, 225);
            txtTicket.MaxLength = 32767;
            txtTicket.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTicket.Name = "txtTicket";
            txtTicket.PasswordChar = '\0';
            txtTicket.PrefixSuffixText = null;
            txtTicket.ReadOnly = false;
            txtTicket.RightToLeft = RightToLeft.No;
            txtTicket.SelectedText = "";
            txtTicket.SelectionLength = 0;
            txtTicket.SelectionStart = 0;
            txtTicket.ShortcutsEnabled = true;
            txtTicket.Size = new Size(484, 48);
            txtTicket.TabIndex = 26;
            txtTicket.TabStop = false;
            txtTicket.TextAlign = HorizontalAlignment.Left;
            txtTicket.TrailingIcon = null;
            txtTicket.UseSystemPasswordChar = false;
            // 
            // txtHours
            // 
            txtHours.AnimateReadOnly = false;
            txtHours.AutoCompleteMode = AutoCompleteMode.None;
            txtHours.AutoCompleteSource = AutoCompleteSource.None;
            txtHours.BackgroundImageLayout = ImageLayout.None;
            txtHours.CharacterCasing = CharacterCasing.Normal;
            txtHours.Depth = 0;
            txtHours.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHours.HideSelection = true;
            txtHours.Hint = "Hours";
            txtHours.LeadingIcon = null;
            txtHours.Location = new Point(251, 116);
            txtHours.MaxLength = 32767;
            txtHours.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHours.Name = "txtHours";
            txtHours.PasswordChar = '\0';
            txtHours.PrefixSuffixText = null;
            txtHours.ReadOnly = false;
            txtHours.RightToLeft = RightToLeft.No;
            txtHours.SelectedText = "";
            txtHours.SelectionLength = 0;
            txtHours.SelectionStart = 0;
            txtHours.ShortcutsEnabled = true;
            txtHours.Size = new Size(239, 48);
            txtHours.TabIndex = 27;
            txtHours.TabStop = false;
            txtHours.TextAlign = HorizontalAlignment.Left;
            txtHours.TrailingIcon = null;
            txtHours.UseSystemPasswordChar = false;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.AnimateReadOnly = false;
            txtHourlyRate.AutoCompleteMode = AutoCompleteMode.None;
            txtHourlyRate.AutoCompleteSource = AutoCompleteSource.None;
            txtHourlyRate.BackgroundImageLayout = ImageLayout.None;
            txtHourlyRate.CharacterCasing = CharacterCasing.Normal;
            txtHourlyRate.Depth = 0;
            txtHourlyRate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHourlyRate.HideSelection = true;
            txtHourlyRate.Hint = "Hourly Rate";
            txtHourlyRate.LeadingIcon = null;
            txtHourlyRate.Location = new Point(251, 170);
            txtHourlyRate.MaxLength = 32767;
            txtHourlyRate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.PasswordChar = '\0';
            txtHourlyRate.PrefixSuffixText = null;
            txtHourlyRate.ReadOnly = false;
            txtHourlyRate.RightToLeft = RightToLeft.No;
            txtHourlyRate.SelectedText = "";
            txtHourlyRate.SelectionLength = 0;
            txtHourlyRate.SelectionStart = 0;
            txtHourlyRate.ShortcutsEnabled = true;
            txtHourlyRate.Size = new Size(239, 48);
            txtHourlyRate.TabIndex = 28;
            txtHourlyRate.TabStop = false;
            txtHourlyRate.TextAlign = HorizontalAlignment.Left;
            txtHourlyRate.TrailingIcon = null;
            txtHourlyRate.UseSystemPasswordChar = false;
            // 
            // dtpDate
            // 
            dtpDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpDate.Location = new Point(339, 26);
            dtpDate.MinimumSize = new Size(0, 29);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(151, 29);
            dtpDate.TabIndex = 31;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Depth = 0;
            lblDate.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDate.Location = new Point(339, 6);
            lblDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(89, 19);
            lblDate.TabIndex = 32;
            lblDate.Text = "Service Date";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ReportForm";
            Text = "ReportForm";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboTechnician;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDescription;
        private ReaLTaiizor.Controls.MaterialComboBox cboUser;
        private ReaLTaiizor.Controls.MaterialComboBox cboSituation;
        private ReaLTaiizor.Controls.MaterialComboBox cboEquipment;
        private ReaLTaiizor.Controls.MaterialComboBox cboPayment;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtObservation;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHourlyRate;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHours;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTicket;
        private ReaLTaiizor.Controls.PoisonDateTime dtpDate;
        private ReaLTaiizor.Controls.MaterialLabel lblDate;
    }
}