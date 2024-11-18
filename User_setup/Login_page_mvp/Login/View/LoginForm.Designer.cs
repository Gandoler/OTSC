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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panelBackTitle = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            buttonExit = new Button();
            textBoxLogin = new RichTextBox();
            textBoxPassword = new RichTextBox();
            textBoxSecPasswordT = new RichTextBox();
            buttonForgot = new Button();
            buttonRegistr = new Button();
            buttonEnter = new Button();
            checkBoxSWhowPsw = new Guna.UI2.WinForms.Guna2CheckBox();
            panelBackTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackTitle
            // 
            panelBackTitle.Controls.Add(buttonExit);
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
            panelBackTitle.UseWaitCursor = true;
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
            buttonExit.UseWaitCursor = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(311, 120);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(168, 51);
            textBoxLogin.TabIndex = 2;
            textBoxLogin.Text = "";
            textBoxLogin.UseWaitCursor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(311, 177);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(168, 51);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "";
            textBoxPassword.UseWaitCursor = true;
            // 
            // textBoxSecPasswordT
            // 
            textBoxSecPasswordT.Enabled = false;
            textBoxSecPasswordT.Location = new Point(311, 234);
            textBoxSecPasswordT.Name = "textBoxSecPasswordT";
            textBoxSecPasswordT.Size = new Size(168, 51);
            textBoxSecPasswordT.TabIndex = 4;
            textBoxSecPasswordT.Text = "";
            textBoxSecPasswordT.UseWaitCursor = true;
            // 
            // buttonForgot
            // 
            buttonForgot.Location = new Point(311, 291);
            buttonForgot.Name = "buttonForgot";
            buttonForgot.Size = new Size(78, 49);
            buttonForgot.TabIndex = 5;
            buttonForgot.Text = "Forgot";
            buttonForgot.UseVisualStyleBackColor = true;
            buttonForgot.UseWaitCursor = true;
            // 
            // buttonRegistr
            // 
            buttonRegistr.Location = new Point(395, 291);
            buttonRegistr.Name = "buttonRegistr";
            buttonRegistr.Size = new Size(84, 49);
            buttonRegistr.TabIndex = 6;
            buttonRegistr.Text = "Registr";
            buttonRegistr.UseVisualStyleBackColor = true;
            buttonRegistr.UseWaitCursor = true;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(311, 346);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(168, 56);
            buttonEnter.TabIndex = 7;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.UseWaitCursor = true;
            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.Animated = true;
            checkBoxSWhowPsw.AutoSize = true;
            checkBoxSWhowPsw.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            checkBoxSWhowPsw.CheckedState.BorderRadius = 0;
            checkBoxSWhowPsw.CheckedState.BorderThickness = 0;
            checkBoxSWhowPsw.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            checkBoxSWhowPsw.Location = new Point(339, 408);
            checkBoxSWhowPsw.Name = "checkBoxSWhowPsw";
            checkBoxSWhowPsw.Size = new Size(76, 19);
            checkBoxSWhowPsw.TabIndex = 8;
            checkBoxSWhowPsw.Text = "ShowPsw";
            checkBoxSWhowPsw.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            checkBoxSWhowPsw.UncheckedState.BorderRadius = 0;
            checkBoxSWhowPsw.UncheckedState.BorderThickness = 0;
            checkBoxSWhowPsw.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            checkBoxSWhowPsw.UseWaitCursor = true;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(checkBoxSWhowPsw);
            Controls.Add(buttonEnter);
            Controls.Add(buttonRegistr);
            Controls.Add(buttonForgot);
            Controls.Add(textBoxSecPasswordT);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(panelBackTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            UseWaitCursor = true;
            panelBackTitle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBackTitle;
        private Button buttonExit;
        private RichTextBox textBoxLogin;
        private RichTextBox textBoxPassword;
        private RichTextBox textBoxSecPasswordT;
        private Button buttonForgot;
        private Button buttonRegistr;
        private Button buttonEnter;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSWhowPsw;
    }
}