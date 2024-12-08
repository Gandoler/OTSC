namespace User_Interface.ExtendedTool
{
    partial class CustomShowBox
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            buttonExit = new Button();
            pathExceptionlabbel = new Label();
            guna2TextBoxFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2ButtonOk = new Guna.UI2.WinForms.Guna2Button();
            panelBackTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackTitle
            // 
            panelBackTitle.Controls.Add(buttonExit);
            panelBackTitle.Controls.Add(pathExceptionlabbel);
            panelBackTitle.CustomizableEdges = customizableEdges1;
            panelBackTitle.Dock = DockStyle.Top;
            panelBackTitle.FillColor = Color.FromArgb(4, 32, 44);
            panelBackTitle.FillColor2 = Color.FromArgb(48, 64, 64);
            panelBackTitle.FillColor3 = Color.FromArgb(91, 112, 101);
            panelBackTitle.FillColor4 = Color.FromArgb(201, 209, 200);
            panelBackTitle.Location = new Point(0, 0);
            panelBackTitle.Name = "panelBackTitle";
            panelBackTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelBackTitle.Size = new Size(300, 35);
            panelBackTitle.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(201, 209, 200);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.Location = new Point(270, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(30, 35);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // pathExceptionlabbel
            // 
            pathExceptionlabbel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pathExceptionlabbel.AutoSize = true;
            pathExceptionlabbel.BackColor = Color.Transparent;
            pathExceptionlabbel.Font = new Font("Microsoft Sans Serif", 16F);
            pathExceptionlabbel.ForeColor = SystemColors.ButtonFace;
            pathExceptionlabbel.Location = new Point(72, 0);
            pathExceptionlabbel.Name = "pathExceptionlabbel";
            pathExceptionlabbel.Size = new Size(159, 26);
            pathExceptionlabbel.TabIndex = 0;
            pathExceptionlabbel.Text = "Path Exception";
            // 
            // guna2TextBoxFilePath
            // 
            guna2TextBoxFilePath.BackColor = Color.Transparent;
            guna2TextBoxFilePath.BorderColor = Color.Transparent;
            guna2TextBoxFilePath.BorderRadius = 15;
            guna2TextBoxFilePath.CustomizableEdges = customizableEdges3;
            guna2TextBoxFilePath.DefaultText = "";
            guna2TextBoxFilePath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBoxFilePath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBoxFilePath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxFilePath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBoxFilePath.FillColor = SystemColors.WindowFrame;
            guna2TextBoxFilePath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxFilePath.Font = new Font("Segoe UI", 9F);
            guna2TextBoxFilePath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBoxFilePath.Location = new Point(52, 96);
            guna2TextBoxFilePath.Name = "guna2TextBoxFilePath";
            guna2TextBoxFilePath.PasswordChar = '\0';
            guna2TextBoxFilePath.PlaceholderForeColor = Color.Gainsboro;
            guna2TextBoxFilePath.PlaceholderText = "C:\\Documents\\file.json\"";
            guna2TextBoxFilePath.SelectedText = "";
            guna2TextBoxFilePath.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBoxFilePath.Size = new Size(200, 36);
            guna2TextBoxFilePath.TabIndex = 3;
            guna2TextBoxFilePath.Enter += Guna2TextBoxFilePath_Enter;
            guna2TextBoxFilePath.MouseEnter += Guna2TextBoxFilePath_MouseEnter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(52, 67);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 1;
            label1.Text = "Enter Json Fpath";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2ButtonOk
            // 
            guna2ButtonOk.BackColor = Color.Transparent;
            guna2ButtonOk.BorderRadius = 15;
            guna2ButtonOk.CustomizableEdges = customizableEdges5;
            guna2ButtonOk.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonOk.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonOk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonOk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonOk.FillColor = Color.FromArgb(91, 112, 101);
            guna2ButtonOk.Font = new Font("Microsoft Sans Serif", 16F);
            guna2ButtonOk.ForeColor = Color.Black;
            guna2ButtonOk.Location = new Point(216, 155);
            guna2ButtonOk.Name = "guna2ButtonOk";
            guna2ButtonOk.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ButtonOk.Size = new Size(72, 33);
            guna2ButtonOk.TabIndex = 4;
            guna2ButtonOk.Text = "OK";
            guna2ButtonOk.Click += Guna2ButtonOk_Click;
            // 
            // CustomShowBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = OTSC_ui.Properties.Resources.OnlyReflenniy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(300, 200);
            Controls.Add(guna2ButtonOk);
            Controls.Add(label1);
            Controls.Add(guna2TextBoxFilePath);
            Controls.Add(panelBackTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomShowBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PathError";
            panelBackTitle.ResumeLayout(false);
            panelBackTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBackTitle;
        private Label pathExceptionlabbel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxFilePath;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonOk;
        private Button buttonExit;
    }
}