
namespace ScheduleApp
{
    partial class loginForm
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
            this.logExitButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.menuBarPanel = new System.Windows.Forms.Panel();
            this.loginPanelMain = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.menuBarPanel.SuspendLayout();
            this.loginPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // logExitButton
            // 
            this.logExitButton.BackColor = System.Drawing.Color.Black;
            this.logExitButton.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logExitButton.ForeColor = System.Drawing.Color.LightCoral;
            this.logExitButton.Location = new System.Drawing.Point(452, 2);
            this.logExitButton.Name = "logExitButton";
            this.logExitButton.Size = new System.Drawing.Size(43, 35);
            this.logExitButton.TabIndex = 0;
            this.logExitButton.Text = "X";
            this.logExitButton.UseVisualStyleBackColor = false;
            this.logExitButton.Click += new System.EventHandler(this.logExitButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginLabel.Location = new System.Drawing.Point(208, 2);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 37);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "LOGIN";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuBarPanel.Controls.Add(this.logExitButton);
            this.menuBarPanel.Controls.Add(this.loginLabel);
            this.menuBarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBarPanel.Location = new System.Drawing.Point(0, 1);
            this.menuBarPanel.Name = "menuBarPanel";
            this.menuBarPanel.Size = new System.Drawing.Size(508, 45);
            this.menuBarPanel.TabIndex = 2;
            // 
            // loginPanelMain
            // 
            this.loginPanelMain.AutoSize = true;
            this.loginPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.loginPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanelMain.Controls.Add(this.loginButton);
            this.loginPanelMain.Controls.Add(this.passwordInput);
            this.loginPanelMain.Controls.Add(this.userInput);
            this.loginPanelMain.Controls.Add(this.passwordLabel);
            this.loginPanelMain.Controls.Add(this.userLabel);
            this.loginPanelMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginPanelMain.Location = new System.Drawing.Point(0, 45);
            this.loginPanelMain.Name = "loginPanelMain";
            this.loginPanelMain.Size = new System.Drawing.Size(508, 490);
            this.loginPanelMain.TabIndex = 3;
            this.loginPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanelMain_Paint);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginButton.Location = new System.Drawing.Point(95, 282);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(333, 54);
            this.loginButton.TabIndex = 4;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.AcceptsReturn = true;
            this.passwordInput.AcceptsTab = true;
            this.passwordInput.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(215, 172);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(213, 38);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            // 
            // userInput
            // 
            this.userInput.AcceptsReturn = true;
            this.userInput.AcceptsTab = true;
            this.userInput.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(215, 108);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(213, 38);
            this.userInput.TabIndex = 2;
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordLabel.Location = new System.Drawing.Point(90, 176);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(105, 34);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.userLabel.Location = new System.Drawing.Point(89, 108);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(109, 34);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Username:";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(508, 534);
            this.Controls.Add(this.loginPanelMain);
            this.Controls.Add(this.menuBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Text = "Form1";
            this.menuBarPanel.ResumeLayout(false);
            this.menuBarPanel.PerformLayout();
            this.loginPanelMain.ResumeLayout(false);
            this.loginPanelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logExitButton;
        private System.Windows.Forms.Panel menuBarPanel;
        private System.Windows.Forms.Panel loginPanelMain;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordInput;
        public System.Windows.Forms.Label loginLabel;
        public System.Windows.Forms.Label passwordLabel;
        public System.Windows.Forms.Label userLabel;
    }
}

