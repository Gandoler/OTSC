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
            panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ExitButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            LoginLabel = new Label();
            checkBoxSWhowPsw = new Guna.UI2.WinForms.Guna2CheckBox();
            logoPanel = new Panel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            labelOnlyDigits = new Label();
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            textBoxLoginGuna = new Guna.UI2.WinForms.Guna2TextBox();
            textBoxPasswordGuna = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ButtonRegistr = new Guna.UI2.WinForms.Guna2Button();
            guna2ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
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
            checkBoxSWhowPsw.Location = new Point(311, 326);
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
            // logoPanel
            // 
            logoPanel.Anchor = AnchorStyles.Left;
            logoPanel.BackColor = Color.Transparent;
            logoPanel.BackgroundImageLayout = ImageLayout.Zoom;
            logoPanel.Location = new Point(638, 388);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(150, 100);
            logoPanel.TabIndex = 19;
            // 
            // labelOnlyDigits
            // 
            labelOnlyDigits.AutoSize = true;
            labelOnlyDigits.BackColor = Color.Transparent;
            labelOnlyDigits.Font = new Font("Verdana", 20F, FontStyle.Bold | FontStyle.Italic);
            labelOnlyDigits.ForeColor = Color.Red;
            labelOnlyDigits.Location = new Point(311, 65);
            labelOnlyDigits.Name = "labelOnlyDigits";
            labelOnlyDigits.Size = new Size(179, 32);
            labelOnlyDigits.TabIndex = 14;
            labelOnlyDigits.Text = "Only Digits";
            labelOnlyDigits.Visible = false;
            // 
            // textBoxLoginGuna
            // 
            textBoxLoginGuna.BackColor = Color.Transparent;
            textBoxLoginGuna.BorderColor = Color.FromArgb(201, 209, 200);
            textBoxLoginGuna.BorderRadius = 15;
            textBoxLoginGuna.CustomizableEdges = customizableEdges5;
            textBoxLoginGuna.DefaultText = "";
            textBoxLoginGuna.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxLoginGuna.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxLoginGuna.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxLoginGuna.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxLoginGuna.FillColor = Color.FromArgb(201, 209, 200);
            textBoxLoginGuna.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxLoginGuna.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLoginGuna.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxLoginGuna.Location = new Point(300, 99);
            textBoxLoginGuna.Margin = new Padding(5, 4, 5, 4);
            textBoxLoginGuna.MaxLength = 20;
            textBoxLoginGuna.Name = "textBoxLoginGuna";
            textBoxLoginGuna.PasswordChar = '\0';
            textBoxLoginGuna.PlaceholderForeColor = Color.DimGray;
            textBoxLoginGuna.PlaceholderText = "Login";
            textBoxLoginGuna.SelectedText = "";
            textBoxLoginGuna.ShadowDecoration.CustomizableEdges = customizableEdges6;
            textBoxLoginGuna.Size = new Size(200, 50);
            textBoxLoginGuna.TabIndex = 15;
            // 
            // textBoxPasswordGuna
            // 
            textBoxPasswordGuna.BackColor = Color.Transparent;
            textBoxPasswordGuna.BorderColor = Color.FromArgb(201, 209, 200);
            textBoxPasswordGuna.BorderRadius = 15;
            textBoxPasswordGuna.CustomizableEdges = customizableEdges7;
            textBoxPasswordGuna.DefaultText = "";
            textBoxPasswordGuna.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxPasswordGuna.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxPasswordGuna.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxPasswordGuna.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxPasswordGuna.FillColor = Color.FromArgb(201, 209, 200);
            textBoxPasswordGuna.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPasswordGuna.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPasswordGuna.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxPasswordGuna.Location = new Point(300, 157);
            textBoxPasswordGuna.Margin = new Padding(5, 4, 5, 4);
            textBoxPasswordGuna.MaxLength = 20;
            textBoxPasswordGuna.Name = "textBoxPasswordGuna";
            textBoxPasswordGuna.PasswordChar = '*';
            textBoxPasswordGuna.PlaceholderForeColor = Color.DimGray;
            textBoxPasswordGuna.PlaceholderText = "Password";
            textBoxPasswordGuna.SelectedText = "";
            textBoxPasswordGuna.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textBoxPasswordGuna.Size = new Size(200, 50);
            textBoxPasswordGuna.TabIndex = 16;
            // 
            // guna2ButtonRegistr
            // 
            guna2ButtonRegistr.BackColor = Color.Transparent;
            guna2ButtonRegistr.BorderRadius = 15;
            guna2ButtonRegistr.CustomizableEdges = customizableEdges9;
            guna2ButtonRegistr.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonRegistr.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonRegistr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonRegistr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonRegistr.FillColor = Color.FromArgb(48, 64, 64);
            guna2ButtonRegistr.Font = new Font("Microsoft Sans Serif", 10F);
            guna2ButtonRegistr.ForeColor = Color.White;
            guna2ButtonRegistr.Location = new Point(300, 214);
            guna2ButtonRegistr.Name = "guna2ButtonRegistr";
            guna2ButtonRegistr.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ButtonRegistr.Size = new Size(200, 50);
            guna2ButtonRegistr.TabIndex = 17;
            guna2ButtonRegistr.Text = "REGISTR";
            // 
            // guna2ButtonLogin
            // 
            guna2ButtonLogin.BackColor = Color.Transparent;
            guna2ButtonLogin.BorderRadius = 15;
            guna2ButtonLogin.CustomizableEdges = customizableEdges11;
            guna2ButtonLogin.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonLogin.FillColor = Color.FromArgb(48, 64, 64);
            guna2ButtonLogin.Font = new Font("Microsoft Sans Serif", 10F);
            guna2ButtonLogin.ForeColor = Color.White;
            guna2ButtonLogin.Location = new Point(300, 270);
            guna2ButtonLogin.Name = "guna2ButtonLogin";
            guna2ButtonLogin.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2ButtonLogin.Size = new Size(200, 50);
            guna2ButtonLogin.TabIndex = 18;
            guna2ButtonLogin.Text = "LOGIN";
            // 
            // LoginFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 500);
            Controls.Add(guna2ButtonLogin);
            Controls.Add(guna2ButtonRegistr);
            Controls.Add(textBoxPasswordGuna);
            Controls.Add(textBoxLoginGuna);
            Controls.Add(labelOnlyDigits);
            Controls.Add(logoPanel);
            Controls.Add(checkBoxSWhowPsw);
            Controls.Add(panelBackTitle);
            FormBorderStyle = FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSWhowPsw;
        private Panel logoPanel;
        private Label LoginLabel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label label1;
        private Label labelOnlyDigits;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxLoginGuna;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPasswordGuna;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonRegistr;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLogin;
        private Guna.UI2.WinForms.Guna2Button ExitButton;
    }
}