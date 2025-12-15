namespace RDControl.App.Base
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            pnlBorderStyle = new Panel();
            pictureBox1 = new PictureBox();
            btnWinClose = new Button();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pnlBorderStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlBorderStyle
            // 
            pnlBorderStyle.BackColor = Color.FromArgb(230, 0, 0);
            pnlBorderStyle.Controls.Add(pictureBox1);
            pnlBorderStyle.Controls.Add(btnWinClose);
            pnlBorderStyle.Controls.Add(btnMinimize);
            pnlBorderStyle.Controls.Add(btnMaximize);
            pnlBorderStyle.Dock = DockStyle.Top;
            pnlBorderStyle.Location = new Point(0, 0);
            pnlBorderStyle.Name = "pnlBorderStyle";
            pnlBorderStyle.Size = new Size(800, 31);
            pnlBorderStyle.TabIndex = 3;
            pnlBorderStyle.MouseDown += MoverFormulario;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnWinClose
            // 
            btnWinClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWinClose.BackColor = Color.Transparent;
            btnWinClose.BackgroundImage = (Image)resources.GetObject("btnWinClose.BackgroundImage");
            btnWinClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnWinClose.FlatAppearance.BorderSize = 0;
            btnWinClose.FlatStyle = FlatStyle.Flat;
            btnWinClose.ForeColor = Color.Transparent;
            btnWinClose.Location = new Point(771, 2);
            btnWinClose.Name = "btnWinClose";
            btnWinClose.Size = new Size(26, 26);
            btnWinClose.TabIndex = 4;
            btnWinClose.UseCompatibleTextRendering = true;
            btnWinClose.UseVisualStyleBackColor = false;
            btnWinClose.Click += btnWinClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Transparent;
            btnMinimize.Location = new Point(707, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(26, 26);
            btnMinimize.TabIndex = 8;
            btnMinimize.UseCompatibleTextRendering = true;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.Transparent;
            btnMaximize.Location = new Point(739, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(26, 26);
            btnMaximize.TabIndex = 7;
            btnMaximize.UseCompatibleTextRendering = true;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlBorderStyle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            Text = "BaseForm";
            pnlBorderStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlBorderStyle;
        
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnWinClose;
        private PictureBox pictureBox1;
    }
}