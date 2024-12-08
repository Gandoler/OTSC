//using User_Interface.ExtendedTool;


using Guna.UI2.WinForms.Suite;
using System.Resources;
using System.Windows.Forms.PropertyGridInternal;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace User_Interface.Login_page_mvp.View
{
    partial class LoginFrom
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
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges8 = new CustomizableEdges();
            CustomizableEdges customizableEdges9 = new CustomizableEdges();
            CustomizableEdges customizableEdges10 = new CustomizableEdges();
            CustomizableEdges customizableEdges11 = new CustomizableEdges();
            CustomizableEdges customizableEdges12 = new CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrom));
            panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ExitButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            LoginLabel = new Label();
            ShowPswCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            logoPanel = new Panel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            LogintextBox = new Guna.UI2.WinForms.Guna2TextBox();
            PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            RegistrButton = new Guna.UI2.WinForms.Guna2Button();
            LoginButton = new Guna.UI2.WinForms.Guna2Button();
            ForgotPasswordLink = new LinkLabel();
            panelBackTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackTitle
            // 
            panelBackTitle.Controls.Add(ExitButton);
            panelBackTitle.Controls.Add(label1);
            panelBackTitle.Controls.Add(LoginLabel);
            panelBackTitle.CustomizableEdges = customizableEdges3;
            panelBackTitle.FillColor = Color.FromArgb(4, 32, 44);
            panelBackTitle.FillColor2 = Color.FromArgb(48, 64, 64);
            panelBackTitle.FillColor3 = Color.FromArgb(91, 112, 101);
            panelBackTitle.FillColor4 = Color.FromArgb(201, 209, 200);
            panelBackTitle.Location = new Point(0, 0);
            panelBackTitle.Name = "panelBackTitle";
            panelBackTitle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelBackTitle.Size = new Size(800, 35);
            panelBackTitle.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.CustomizableEdges = customizableEdges1;
            ExitButton.DisabledState.BorderColor = Color.DarkGray;
            ExitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitButton.FillColor = Color.Transparent;
            ExitButton.Font = new Font("Arial Rounded MT Bold", 14F);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(762, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.PressedColor = Color.Transparent;
            ExitButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ExitButton.Size = new Size(35, 35);
            ExitButton.TabIndex = 40;
            ExitButton.Text = "X";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(353, 1);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top;
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Microsoft Sans Serif", 20F);
            LoginLabel.ForeColor = SystemColors.ButtonFace;
            LoginLabel.Location = new Point(355, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(99, 31);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "LOGIN";
            // 
            // ShowPswCheckBox
            // 
            ShowPswCheckBox.Animated = true;
            ShowPswCheckBox.AutoSize = true;
            ShowPswCheckBox.BackColor = Color.FromArgb(91, 112, 101);
            ShowPswCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ShowPswCheckBox.CheckedState.BorderRadius = 0;
            ShowPswCheckBox.CheckedState.BorderThickness = 0;
            ShowPswCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ShowPswCheckBox.ForeColor = SystemColors.ButtonFace;
            ShowPswCheckBox.Location = new Point(311, 326);
            ShowPswCheckBox.Name = "ShowPswCheckBox";
            ShowPswCheckBox.Size = new Size(76, 19);
            ShowPswCheckBox.TabIndex = 8;
            ShowPswCheckBox.Text = "ShowPsw";
            ShowPswCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ShowPswCheckBox.UncheckedState.BorderRadius = 0;
            ShowPswCheckBox.UncheckedState.BorderThickness = 0;
            ShowPswCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ShowPswCheckBox.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            logoPanel.Anchor = AnchorStyles.Left;
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImage = OTSC_ui.Properties.Resources.logo_withoutBackground_LOGINPAGE;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(638, 388);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(150, 100);
            logoPanel.TabIndex = 19;
            // 
            // LogintextBox
            // 
            LogintextBox.BackColor = Color.Transparent;
            LogintextBox.BorderColor = Color.FromArgb(201, 209, 200);
            LogintextBox.BorderRadius = 15;
            LogintextBox.CustomizableEdges = customizableEdges5;
            LogintextBox.DefaultText = "";
            LogintextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LogintextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LogintextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LogintextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LogintextBox.FillColor = Color.FromArgb(201, 209, 200);
            LogintextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LogintextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogintextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LogintextBox.Location = new Point(300, 97);
            LogintextBox.Margin = new Padding(6, 6, 6, 6);
            LogintextBox.MaxLength = 20;
            LogintextBox.Name = "LogintextBox";
            LogintextBox.PasswordChar = '\0';
            LogintextBox.PlaceholderForeColor = Color.DimGray;
            LogintextBox.PlaceholderText = "Login";
            LogintextBox.SelectedText = "";
            LogintextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LogintextBox.Size = new Size(200, 50);
            LogintextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.Transparent;
            PasswordTextBox.BorderColor = Color.FromArgb(201, 209, 200);
            PasswordTextBox.BorderRadius = 15;
            PasswordTextBox.CustomizableEdges = customizableEdges7;
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            PasswordTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            PasswordTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            PasswordTextBox.FillColor = Color.FromArgb(201, 209, 200);
            PasswordTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            PasswordTextBox.Location = new Point(300, 157);
            PasswordTextBox.Margin = new Padding(5, 4, 5, 4);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderForeColor = Color.DimGray;
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PasswordTextBox.Size = new Size(200, 50);
            PasswordTextBox.TabIndex = 16;
            // 
            // RegistrButton
            // 
            RegistrButton.BackColor = Color.Transparent;
            RegistrButton.BorderRadius = 15;
            RegistrButton.CustomizableEdges = customizableEdges9;
            RegistrButton.DisabledState.BorderColor = Color.DarkGray;
            RegistrButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RegistrButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RegistrButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RegistrButton.FillColor = Color.FromArgb(48, 64, 64);
            RegistrButton.Font = new Font("Microsoft Sans Serif", 10F);
            RegistrButton.ForeColor = Color.White;
            RegistrButton.Location = new Point(300, 214);
            RegistrButton.Name = "RegistrButton";
            RegistrButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            RegistrButton.Size = new Size(200, 50);
            RegistrButton.TabIndex = 17;
            RegistrButton.Text = "REGISTR";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BorderRadius = 15;
            LoginButton.CustomizableEdges = customizableEdges11;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.FromArgb(48, 64, 64);
            LoginButton.Font = new Font("Microsoft Sans Serif", 10F);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(300, 270);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            LoginButton.Size = new Size(200, 50);
            LoginButton.TabIndex = 18;
            LoginButton.Text = "LOGIN";
            // 
            // ForgotPasswordLink
            // 
            ForgotPasswordLink.AutoSize = true;
            ForgotPasswordLink.BackColor = Color.FromArgb(201, 209, 200);
            ForgotPasswordLink.Font = new Font("Segoe UI", 9F);
            ForgotPasswordLink.LinkColor = Color.Black;
            ForgotPasswordLink.Location = new Point(421, 330);
            ForgotPasswordLink.Name = "ForgotPasswordLink";
            ForgotPasswordLink.Size = new Size(69, 15);
            ForgotPasswordLink.TabIndex = 20;
            ForgotPasswordLink.TabStop = true;
            ForgotPasswordLink.Text = "Forgot PSW";
            ForgotPasswordLink.VisitedLinkColor = Color.Black;
            // 
            // LoginFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = OTSC_ui.Properties.Resources.Fon_LOGINPAGE;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(ForgotPasswordLink);
            Controls.Add(LoginButton);
            Controls.Add(RegistrButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LogintextBox);
            Controls.Add(logoPanel);
            Controls.Add(ShowPswCheckBox);
            Controls.Add(panelBackTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "LoginFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelBackTitle.ResumeLayout(false);
            panelBackTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBackTitle;
        private Guna.UI2.WinForms.Guna2CheckBox ShowPswCheckBox;
        private Panel logoPanel;
        private Label LoginLabel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2TextBox LogintextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button RegistrButton;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private LinkLabel ForgotPasswordLink;
    }
}