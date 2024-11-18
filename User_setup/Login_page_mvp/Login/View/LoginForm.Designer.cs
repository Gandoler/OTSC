//using User_Interface.ExtendedTool;


namespace User_Interface.Login_page_mvp.View
{
    partial class formLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label1 = new Label();
            LoginLabel = new Label();
            buttonExit = new Button();
            buttonForgot = new Button();
            buttonRegistr = new Button();
            buttonEnter = new Button();
            checkBoxSWhowPsw = new Guna.UI2.WinForms.Guna2CheckBox();
            textBoxSecPasswordT_def = new TextBox();
            textBoxPassword_def = new TextBox();
            logoPanel = new Panel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            textBoxLoginNew = new TextBox();
            panelBackTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackTitle
            // 
            panelBackTitle.Controls.Add(label1);
            panelBackTitle.Controls.Add(LoginLabel);
            panelBackTitle.Controls.Add(buttonExit);
            panelBackTitle.CustomizableEdges = customizableEdges1;
            panelBackTitle.FillColor = Color.FromArgb(4, 32, 44);
            panelBackTitle.FillColor2 = Color.FromArgb(48, 64, 64);
            panelBackTitle.FillColor3 = Color.FromArgb(91, 112, 101);
            panelBackTitle.FillColor4 = Color.FromArgb(201, 209, 200);
            panelBackTitle.Location = new Point(0, 0);
            panelBackTitle.Name = "panelBackTitle";
            panelBackTitle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelBackTitle.Size = new Size(800, 35);
            panelBackTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 20F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(353, 1);
            label1.Name = "label1";
            label1.Size = new Size(95, 33);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top;
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Showcard Gothic", 20F);
            LoginLabel.ForeColor = SystemColors.ButtonFace;
            LoginLabel.Location = new Point(355, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(95, 33);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "LOGIN";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(201, 209, 200);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.Location = new Point(770, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(30, 35);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonForgot
            // 
            buttonForgot.BackColor = Color.FromArgb(4, 32, 44);
            buttonForgot.FlatStyle = FlatStyle.Flat;
            buttonForgot.Font = new Font("Showcard Gothic", 10F);
            buttonForgot.ForeColor = SystemColors.ButtonFace;
            buttonForgot.Location = new Point(300, 268);
            buttonForgot.Name = "buttonForgot";
            buttonForgot.Size = new Size(90, 50);
            buttonForgot.TabIndex = 5;
            buttonForgot.Text = "Forgot";
            buttonForgot.UseVisualStyleBackColor = false;
            // 
            // buttonRegistr
            // 
            buttonRegistr.BackColor = Color.FromArgb(4, 32, 44);
            buttonRegistr.FlatStyle = FlatStyle.Flat;
            buttonRegistr.Font = new Font("Showcard Gothic", 10F);
            buttonRegistr.ForeColor = SystemColors.ButtonFace;
            buttonRegistr.Location = new Point(410, 268);
            buttonRegistr.Name = "buttonRegistr";
            buttonRegistr.Size = new Size(90, 50);
            buttonRegistr.TabIndex = 6;
            buttonRegistr.Text = "Registr";
            buttonRegistr.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(4, 32, 44);
            buttonEnter.FlatStyle = FlatStyle.Flat;
            buttonEnter.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEnter.ForeColor = SystemColors.ControlLightLight;
            buttonEnter.Location = new Point(320, 324);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(150, 50);
            buttonEnter.TabIndex = 7;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.Animated = true;
            checkBoxSWhowPsw.AutoSize = true;
            checkBoxSWhowPsw.BackColor = Color.FromArgb(91, 112, 101);
            checkBoxSWhowPsw.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            checkBoxSWhowPsw.CheckedState.BorderRadius = 0;
            checkBoxSWhowPsw.CheckedState.BorderThickness = 0;
            checkBoxSWhowPsw.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            checkBoxSWhowPsw.ForeColor = SystemColors.ButtonFace;
            checkBoxSWhowPsw.Location = new Point(355, 380);
            checkBoxSWhowPsw.Name = "checkBoxSWhowPsw";
            checkBoxSWhowPsw.Size = new Size(76, 19);
            checkBoxSWhowPsw.TabIndex = 8;
            checkBoxSWhowPsw.Text = "ShowPsw";
            checkBoxSWhowPsw.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            checkBoxSWhowPsw.UncheckedState.BorderRadius = 0;
            checkBoxSWhowPsw.UncheckedState.BorderThickness = 0;
            checkBoxSWhowPsw.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            checkBoxSWhowPsw.UseVisualStyleBackColor = false;
            // 
            // textBoxSecPasswordT_def
            // 
            textBoxSecPasswordT_def.BackColor = Color.FromArgb(201, 209, 200);
            textBoxSecPasswordT_def.BorderStyle = BorderStyle.None;
            textBoxSecPasswordT_def.Enabled = false;
            textBoxSecPasswordT_def.Font = new Font("Segoe UI", 14F);
            textBoxSecPasswordT_def.ForeColor = Color.Black;
            textBoxSecPasswordT_def.Location = new Point(300, 212);
            textBoxSecPasswordT_def.MaxLength = 20;
            textBoxSecPasswordT_def.MinimumSize = new Size(200, 50);
            textBoxSecPasswordT_def.Name = "textBoxSecPasswordT_def";
            textBoxSecPasswordT_def.PasswordChar = '*';
            textBoxSecPasswordT_def.PlaceholderText = "Confirm Password";
            textBoxSecPasswordT_def.Size = new Size(200, 50);
            textBoxSecPasswordT_def.TabIndex = 13;
            // 
            // textBoxPassword_def
            // 
            textBoxPassword_def.BackColor = Color.FromArgb(201, 209, 200);
            textBoxPassword_def.BorderStyle = BorderStyle.None;
            textBoxPassword_def.Font = new Font("Segoe UI", 14F);
            textBoxPassword_def.ForeColor = Color.Black;
            textBoxPassword_def.Location = new Point(300, 156);
            textBoxPassword_def.MaxLength = 20;
            textBoxPassword_def.MinimumSize = new Size(200, 50);
            textBoxPassword_def.Name = "textBoxPassword_def";
            textBoxPassword_def.PasswordChar = '*';
            textBoxPassword_def.PlaceholderText = "Password";
            textBoxPassword_def.Size = new Size(200, 50);
            textBoxPassword_def.TabIndex = 10;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = Properties.Resources.logo_removebg_preview;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(641, 389);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(147, 99);
            logoPanel.TabIndex = 11;
            // 
            // textBoxLoginNew
            // 
            textBoxLoginNew.BackColor = Color.FromArgb(201, 209, 200);
            textBoxLoginNew.BorderStyle = BorderStyle.None;
            textBoxLoginNew.Font = new Font("Segoe UI", 14F);
            textBoxLoginNew.ForeColor = Color.Black;
            textBoxLoginNew.Location = new Point(300, 100);
            textBoxLoginNew.MaxLength = 20;
            textBoxLoginNew.MinimumSize = new Size(200, 50);
            textBoxLoginNew.Name = "textBoxLoginNew";
           
            textBoxLoginNew.PlaceholderText = "Login";
            textBoxLoginNew.Size = new Size(200, 50);
            textBoxLoginNew.TabIndex = 12;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1709693764_bogatyr_club_f06x_p_fon_dlya_prilozheniya_101;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(textBoxLoginNew);
            Controls.Add(logoPanel);
            Controls.Add(textBoxPassword_def);
            Controls.Add(textBoxSecPasswordT_def);
            Controls.Add(checkBoxSWhowPsw);
            Controls.Add(buttonEnter);
            Controls.Add(buttonRegistr);
            Controls.Add(buttonForgot);
            Controls.Add(panelBackTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelBackTitle.ResumeLayout(false);
            panelBackTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBackTitle;
        private Button buttonExit;
        private Button buttonForgot;
        private Button buttonRegistr;
        private Button buttonEnter;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSWhowPsw;
        private TextBox textBoxSecPasswordT_def;
        private TextBox textBoxPassword_def;
        private Panel logoPanel;
        private Label LoginLabel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label1;
        private TextBox textBoxLoginNew;
    }
}