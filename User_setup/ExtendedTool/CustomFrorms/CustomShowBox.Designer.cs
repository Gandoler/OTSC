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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomShowBox));
            pathExceptionlabbel = new Label();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pathExceptionlabbel
            // 
            pathExceptionlabbel.AutoSize = true;
            pathExceptionlabbel.Location = new Point(95, 110);
            pathExceptionlabbel.Name = "pathExceptionlabbel";
            pathExceptionlabbel.Size = new Size(86, 15);
            pathExceptionlabbel.TabIndex = 0;
            pathExceptionlabbel.Text = "Path Exception";
         
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Dock = DockStyle.Top;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(300, 30);
            guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // CustomShowBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(300, 200);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pathExceptionlabbel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomShowBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PathError";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pathExceptionlabbel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}