namespace RDControl.App.Base
{
    partial class BaseRegisterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseRegisterForm));
            tabControlRegister = new TabControl();
            tabPageRegister = new TabPage();
            panel2 = new Panel();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnSave = new ReaLTaiizor.Controls.CyberButton();
            tabPageList = new TabPage();
            dataGridViewList = new DataGridView();
            panel1 = new Panel();
            btnDelete = new ReaLTaiizor.Controls.CyberButton();
            btnEdit = new ReaLTaiizor.Controls.CyberButton();
            btnNew = new ReaLTaiizor.Controls.CyberButton();
            imageList1 = new ImageList(components);
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel2.SuspendLayout();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Alignment = TabAlignment.Left;
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.ImageList = imageList1;
            tabControlRegister.Location = new Point(0, 31);
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(800, 419);
            tabControlRegister.TabIndex = 4;
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(panel2);
            tabPageRegister.ImageKey = "register-svgrepo-com.png";
            tabPageRegister.Location = new Point(31, 4);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(765, 411);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 38);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Alpha = 20;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Background = true;
            btnCancel.Background_WidthPen = 4F;
            btnCancel.BackgroundPen = true;
            btnCancel.ColorBackground = Color.FromArgb(230, 0, 0);
            btnCancel.ColorBackground_1 = Color.FromArgb(230, 0, 0);
            btnCancel.ColorBackground_2 = Color.FromArgb(230, 0, 0);
            btnCancel.ColorBackground_Pen = Color.Black;
            btnCancel.ColorLighting = Color.Black;
            btnCancel.ColorPen_1 = Color.FromArgb(230, 0, 0);
            btnCancel.ColorPen_2 = Color.FromArgb(230, 0, 0);
            btnCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancel.Effect_1 = true;
            btnCancel.Effect_1_ColorBackground = Color.Black;
            btnCancel.Effect_1_Transparency = 25;
            btnCancel.Effect_2 = true;
            btnCancel.Effect_2_ColorBackground = Color.White;
            btnCancel.Effect_2_Transparency = 20;
            btnCancel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Lighting = false;
            btnCancel.LinearGradient_Background = false;
            btnCancel.LinearGradientPen = false;
            btnCancel.Location = new Point(576, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 70;
            btnCancel.Size = new Size(86, 32);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 12;
            btnCancel.Tag = "Cyber";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Alpha = 20;
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Transparent;
            btnSave.Background = true;
            btnSave.Background_WidthPen = 4F;
            btnSave.BackgroundPen = true;
            btnSave.ColorBackground = Color.FromArgb(230, 0, 0);
            btnSave.ColorBackground_1 = Color.FromArgb(230, 0, 0);
            btnSave.ColorBackground_2 = Color.FromArgb(230, 0, 0);
            btnSave.ColorBackground_Pen = Color.Black;
            btnSave.ColorLighting = Color.Black;
            btnSave.ColorPen_1 = Color.FromArgb(230, 0, 0);
            btnSave.ColorPen_2 = Color.FromArgb(230, 0, 0);
            btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSave.Effect_1 = true;
            btnSave.Effect_1_ColorBackground = Color.Black;
            btnSave.Effect_1_Transparency = 25;
            btnSave.Effect_2 = true;
            btnSave.Effect_2_ColorBackground = Color.White;
            btnSave.Effect_2_Transparency = 20;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Lighting = false;
            btnSave.LinearGradient_Background = false;
            btnSave.LinearGradientPen = false;
            btnSave.Location = new Point(668, 3);
            btnSave.Name = "btnSave";
            btnSave.PenWidth = 15;
            btnSave.Rounding = true;
            btnSave.RoundingInt = 70;
            btnSave.Size = new Size(86, 32);
            btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 11;
            btnSave.Tag = "Cyber";
            btnSave.TextButton = "Save";
            btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Timer_Effect_1 = 5;
            btnSave.Timer_RGB = 300;
            btnSave.Click += btnSave_Click;
            // 
            // tabPageList
            // 
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.Controls.Add(panel1);
            tabPageList.ImageKey = "search-alt-2-svgrepo-com.png";
            tabPageList.Location = new Point(31, 4);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(765, 411);
            tabPageList.TabIndex = 1;
            tabPageList.UseVisualStyleBackColor = true;
            tabPageList.Enter += tabPageList_Enter;
            // 
            // dataGridViewList
            // 
            dataGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(6, 2);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.Size = new Size(756, 358);
            dataGridViewList.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnNew);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 38);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Alpha = 20;
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Background = true;
            btnDelete.Background_WidthPen = 4F;
            btnDelete.BackgroundPen = true;
            btnDelete.ColorBackground = Color.FromArgb(230, 0, 0);
            btnDelete.ColorBackground_1 = Color.FromArgb(230, 0, 0);
            btnDelete.ColorBackground_2 = Color.FromArgb(230, 0, 0);
            btnDelete.ColorBackground_Pen = Color.Black;
            btnDelete.ColorLighting = Color.Black;
            btnDelete.ColorPen_1 = Color.FromArgb(230, 0, 0);
            btnDelete.ColorPen_2 = Color.FromArgb(230, 0, 0);
            btnDelete.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDelete.Effect_1 = true;
            btnDelete.Effect_1_ColorBackground = Color.Black;
            btnDelete.Effect_1_Transparency = 25;
            btnDelete.Effect_2 = true;
            btnDelete.Effect_2_ColorBackground = Color.White;
            btnDelete.Effect_2_Transparency = 20;
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Lighting = false;
            btnDelete.LinearGradient_Background = false;
            btnDelete.LinearGradientPen = false;
            btnDelete.Location = new Point(482, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.PenWidth = 15;
            btnDelete.Rounding = true;
            btnDelete.RoundingInt = 70;
            btnDelete.Size = new Size(86, 32);
            btnDelete.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDelete.TabIndex = 12;
            btnDelete.Tag = "Cyber";
            btnDelete.TextButton = "Delete";
            btnDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDelete.Timer_Effect_1 = 5;
            btnDelete.Timer_RGB = 300;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Alpha = 20;
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Background = true;
            btnEdit.Background_WidthPen = 4F;
            btnEdit.BackgroundPen = true;
            btnEdit.ColorBackground = Color.FromArgb(230, 0, 0);
            btnEdit.ColorBackground_1 = Color.FromArgb(230, 0, 0);
            btnEdit.ColorBackground_2 = Color.FromArgb(230, 0, 0);
            btnEdit.ColorBackground_Pen = Color.Black;
            btnEdit.ColorLighting = Color.Black;
            btnEdit.ColorPen_1 = Color.FromArgb(230, 0, 0);
            btnEdit.ColorPen_2 = Color.FromArgb(230, 0, 0);
            btnEdit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEdit.Effect_1 = true;
            btnEdit.Effect_1_ColorBackground = Color.Black;
            btnEdit.Effect_1_Transparency = 25;
            btnEdit.Effect_2 = true;
            btnEdit.Effect_2_ColorBackground = Color.White;
            btnEdit.Effect_2_Transparency = 20;
            btnEdit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Lighting = false;
            btnEdit.LinearGradient_Background = false;
            btnEdit.LinearGradientPen = false;
            btnEdit.Location = new Point(574, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.PenWidth = 15;
            btnEdit.Rounding = true;
            btnEdit.RoundingInt = 70;
            btnEdit.Size = new Size(86, 32);
            btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEdit.TabIndex = 11;
            btnEdit.Tag = "Cyber";
            btnEdit.TextButton = "Edit";
            btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEdit.Timer_Effect_1 = 5;
            btnEdit.Timer_RGB = 300;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Alpha = 20;
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.BackColor = Color.Transparent;
            btnNew.Background = true;
            btnNew.Background_WidthPen = 4F;
            btnNew.BackgroundPen = true;
            btnNew.ColorBackground = Color.FromArgb(230, 0, 0);
            btnNew.ColorBackground_1 = Color.FromArgb(230, 0, 0);
            btnNew.ColorBackground_2 = Color.FromArgb(230, 0, 0);
            btnNew.ColorBackground_Pen = Color.Black;
            btnNew.ColorLighting = Color.Black;
            btnNew.ColorPen_1 = Color.FromArgb(230, 0, 0);
            btnNew.ColorPen_2 = Color.FromArgb(230, 0, 0);
            btnNew.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNew.Effect_1 = true;
            btnNew.Effect_1_ColorBackground = Color.Black;
            btnNew.Effect_1_Transparency = 25;
            btnNew.Effect_2 = true;
            btnNew.Effect_2_ColorBackground = Color.White;
            btnNew.Effect_2_Transparency = 20;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Black;
            btnNew.Lighting = false;
            btnNew.LinearGradient_Background = false;
            btnNew.LinearGradientPen = false;
            btnNew.Location = new Point(666, 3);
            btnNew.Name = "btnNew";
            btnNew.PenWidth = 15;
            btnNew.Rounding = true;
            btnNew.RoundingInt = 70;
            btnNew.Size = new Size(86, 32);
            btnNew.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNew.TabIndex = 10;
            btnNew.Tag = "Cyber";
            btnNew.TextButton = "New";
            btnNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNew.Timer_Effect_1 = 5;
            btnNew.Timer_RGB = 300;
            btnNew.Click += btnNew_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "register-svgrepo-com.png");
            imageList1.Images.SetKeyName(1, "search-alt-2-svgrepo-com.png");
            // 
            // BaseRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlRegister);
            Location = new Point(0, 0);
            Name = "BaseRegisterForm";
            Text = "BaseRegisterForm";
            Controls.SetChildIndex(tabControlRegister, 0);
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageList;
        private ImageList imageList1;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton btnNew;
        private Panel panel2;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnDelete;
        private ReaLTaiizor.Controls.CyberButton btnEdit;
        protected TabPage tabPageRegister;
        protected TabControl tabControlRegister;
        protected DataGridView dataGridViewList;
    }
}