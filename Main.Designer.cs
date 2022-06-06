namespace CustomControls
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelPasswordCharCount = new System.Windows.Forms.Label();
            this.labelPasswordCharDigit = new System.Windows.Forms.Label();
            this.labelPasswordCharCapital = new System.Windows.Forms.Label();
            this.labelPasswordCharSpecial = new System.Windows.Forms.Label();
            this.labelLoginCharSpecial = new System.Windows.Forms.Label();
            this.labelLoginCharCount = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLoginCharSpecial = new System.Windows.Forms.Panel();
            this.panelPasswordCharSpecial = new System.Windows.Forms.Panel();
            this.panelPasswordCharCapital = new System.Windows.Forms.Panel();
            this.panelPasswordCharDigit = new System.Windows.Forms.Panel();
            this.panelLoginCharCount = new System.Windows.Forms.Panel();
            this.panelPasswordCharCount = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.customTextBoxLogin1 = new CustomControls.Controls.CustomTextBoxLogin();
            this.customTextBoxPassword1 = new CustomControls.Controls.CustomTextBoxPassword();
            this.panelLoginContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLoginContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPasswordCharCount
            // 
            this.labelPasswordCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharCount.Location = new System.Drawing.Point(28, 117);
            this.labelPasswordCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharCount.Name = "labelPasswordCharCount";
            this.labelPasswordCharCount.Size = new System.Drawing.Size(124, 13);
            this.labelPasswordCharCount.TabIndex = 8;
            this.labelPasswordCharCount.Text = "at least 8 characters";
            // 
            // labelPasswordCharDigit
            // 
            this.labelPasswordCharDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharDigit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharDigit.Location = new System.Drawing.Point(31, 147);
            this.labelPasswordCharDigit.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharDigit.Name = "labelPasswordCharDigit";
            this.labelPasswordCharDigit.Size = new System.Drawing.Size(102, 13);
            this.labelPasswordCharDigit.TabIndex = 9;
            this.labelPasswordCharDigit.Text = "at least one digit";
            // 
            // labelPasswordCharCapital
            // 
            this.labelPasswordCharCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharCapital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharCapital.Location = new System.Drawing.Point(186, 117);
            this.labelPasswordCharCapital.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharCapital.Name = "labelPasswordCharCapital";
            this.labelPasswordCharCapital.Size = new System.Drawing.Size(149, 13);
            this.labelPasswordCharCapital.TabIndex = 10;
            this.labelPasswordCharCapital.Text = "at least one capital letter";
            // 
            // labelPasswordCharSpecial
            // 
            this.labelPasswordCharSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharSpecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharSpecial.Location = new System.Drawing.Point(186, 147);
            this.labelPasswordCharSpecial.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharSpecial.Name = "labelPasswordCharSpecial";
            this.labelPasswordCharSpecial.Size = new System.Drawing.Size(176, 13);
            this.labelPasswordCharSpecial.TabIndex = 11;
            this.labelPasswordCharSpecial.Text = "at least one special character";
            // 
            // labelLoginCharSpecial
            // 
            this.labelLoginCharSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginCharSpecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelLoginCharSpecial.Location = new System.Drawing.Point(186, 178);
            this.labelLoginCharSpecial.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginCharSpecial.Name = "labelLoginCharSpecial";
            this.labelLoginCharSpecial.Size = new System.Drawing.Size(142, 13);
            this.labelLoginCharSpecial.TabIndex = 17;
            this.labelLoginCharSpecial.Text = "don\'t use ?),+!#@$%^&/(";
            // 
            // labelLoginCharCount
            // 
            this.labelLoginCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelLoginCharCount.Location = new System.Drawing.Point(31, 177);
            this.labelLoginCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginCharCount.Name = "labelLoginCharCount";
            this.labelLoginCharCount.Size = new System.Drawing.Size(104, 13);
            this.labelLoginCharCount.TabIndex = 14;
            this.labelLoginCharCount.Text = "8 - 16 characters";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPassword.Location = new System.Drawing.Point(0, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 16);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(0, 0);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(75, 16);
            this.labelLogin.TabIndex = 23;
            this.labelLogin.Text = "Login";
            // 
            // panelLoginCharSpecial
            // 
            this.panelLoginCharSpecial.BackgroundImage = global::CustomControls.Properties.Resources.ok;
            this.panelLoginCharSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLoginCharSpecial.Location = new System.Drawing.Point(160, 171);
            this.panelLoginCharSpecial.Name = "panelLoginCharSpecial";
            this.panelLoginCharSpecial.Size = new System.Drawing.Size(25, 25);
            this.panelLoginCharSpecial.TabIndex = 19;
            // 
            // panelPasswordCharSpecial
            // 
            this.panelPasswordCharSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharSpecial.BackgroundImage")));
            this.panelPasswordCharSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharSpecial.Location = new System.Drawing.Point(160, 140);
            this.panelPasswordCharSpecial.Name = "panelPasswordCharSpecial";
            this.panelPasswordCharSpecial.Size = new System.Drawing.Size(25, 25);
            this.panelPasswordCharSpecial.TabIndex = 13;
            // 
            // panelPasswordCharCapital
            // 
            this.panelPasswordCharCapital.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharCapital.BackgroundImage")));
            this.panelPasswordCharCapital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharCapital.Location = new System.Drawing.Point(160, 110);
            this.panelPasswordCharCapital.Name = "panelPasswordCharCapital";
            this.panelPasswordCharCapital.Size = new System.Drawing.Size(25, 25);
            this.panelPasswordCharCapital.TabIndex = 13;
            // 
            // panelPasswordCharDigit
            // 
            this.panelPasswordCharDigit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharDigit.BackgroundImage")));
            this.panelPasswordCharDigit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharDigit.Location = new System.Drawing.Point(0, 140);
            this.panelPasswordCharDigit.Name = "panelPasswordCharDigit";
            this.panelPasswordCharDigit.Size = new System.Drawing.Size(25, 25);
            this.panelPasswordCharDigit.TabIndex = 13;
            // 
            // panelLoginCharCount
            // 
            this.panelLoginCharCount.BackgroundImage = global::CustomControls.Properties.Resources.warning;
            this.panelLoginCharCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLoginCharCount.Location = new System.Drawing.Point(0, 170);
            this.panelLoginCharCount.Name = "panelLoginCharCount";
            this.panelLoginCharCount.Size = new System.Drawing.Size(25, 25);
            this.panelLoginCharCount.TabIndex = 18;
            // 
            // panelPasswordCharCount
            // 
            this.panelPasswordCharCount.BackgroundImage = global::CustomControls.Properties.Resources.error;
            this.panelPasswordCharCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharCount.Location = new System.Drawing.Point(0, 110);
            this.panelPasswordCharCount.Name = "panelPasswordCharCount";
            this.panelPasswordCharCount.Size = new System.Drawing.Size(25, 25);
            this.panelPasswordCharCount.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.button1.Location = new System.Drawing.Point(0, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign in!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customTextBoxLogin1
            // 
            this.customTextBoxLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(145)))));
            this.customTextBoxLogin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customTextBoxLogin1.BorderSize = 2;
            this.customTextBoxLogin1.CustomText = "";
            this.customTextBoxLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Bold);
            this.customTextBoxLogin1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customTextBoxLogin1.IsCharCountPassed = false;
            this.customTextBoxLogin1.IsCharSpecialPassed = false;
            this.customTextBoxLogin1.Location = new System.Drawing.Point(0, 20);
            this.customTextBoxLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxLogin1.Multiline = false;
            this.customTextBoxLogin1.Name = "customTextBoxLogin1";
            this.customTextBoxLogin1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxLogin1.Size = new System.Drawing.Size(379, 25);
            this.customTextBoxLogin1.TabIndex = 1;
            this.customTextBoxLogin1.UnderlinedStyle = true;
            this.customTextBoxLogin1._TextChanged += new System.EventHandler(this.CustomTextBoxLogin1__TextChanged);
            // 
            // customTextBoxPassword1
            // 
            this.customTextBoxPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(145)))));
            this.customTextBoxPassword1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customTextBoxPassword1.BorderSize = 2;
            this.customTextBoxPassword1.CustomText = "";
            this.customTextBoxPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Bold);
            this.customTextBoxPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customTextBoxPassword1.IsCharCapitalPassed = false;
            this.customTextBoxPassword1.IsCharCountPassed = false;
            this.customTextBoxPassword1.IsCharDigitPassed = false;
            this.customTextBoxPassword1.IsCharSpecialPassed = false;
            this.customTextBoxPassword1.Location = new System.Drawing.Point(0, 78);
            this.customTextBoxPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxPassword1.Multiline = false;
            this.customTextBoxPassword1.Name = "customTextBoxPassword1";
            this.customTextBoxPassword1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxPassword1.PasswordChar = true;
            this.customTextBoxPassword1.Size = new System.Drawing.Size(379, 25);
            this.customTextBoxPassword1.TabIndex = 2;
            this.customTextBoxPassword1.UnderlinedStyle = true;
            this.customTextBoxPassword1._TextChanged += new System.EventHandler(this.CustomTextBoxPassword1__TextChanged);
            // 
            // panelLoginContainer
            // 
            this.panelLoginContainer.Controls.Add(this.labelLogin);
            this.panelLoginContainer.Controls.Add(this.button1);
            this.panelLoginContainer.Controls.Add(this.customTextBoxPassword1);
            this.panelLoginContainer.Controls.Add(this.customTextBoxLogin1);
            this.panelLoginContainer.Controls.Add(this.labelPassword);
            this.panelLoginContainer.Controls.Add(this.labelPasswordCharCount);
            this.panelLoginContainer.Controls.Add(this.panelLoginCharSpecial);
            this.panelLoginContainer.Controls.Add(this.labelPasswordCharDigit);
            this.panelLoginContainer.Controls.Add(this.panelPasswordCharSpecial);
            this.panelLoginContainer.Controls.Add(this.labelLoginCharCount);
            this.panelLoginContainer.Controls.Add(this.panelPasswordCharCapital);
            this.panelLoginContainer.Controls.Add(this.labelPasswordCharCapital);
            this.panelLoginContainer.Controls.Add(this.panelPasswordCharDigit);
            this.panelLoginContainer.Controls.Add(this.labelPasswordCharSpecial);
            this.panelLoginContainer.Controls.Add(this.panelLoginCharCount);
            this.panelLoginContainer.Controls.Add(this.panelPasswordCharCount);
            this.panelLoginContainer.Controls.Add(this.labelLoginCharSpecial);
            this.panelLoginContainer.Location = new System.Drawing.Point(10, 39);
            this.panelLoginContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoginContainer.Name = "panelLoginContainer";
            this.panelLoginContainer.Size = new System.Drawing.Size(380, 250);
            this.panelLoginContainer.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(166)))));
            this.flowLayoutPanel1.Controls.Add(this.labelTitle);
            this.flowLayoutPanel1.Controls.Add(this.panelLoginContainer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(75, 50);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 300);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(166)))));
            this.labelTitle.Location = new System.Drawing.Point(13, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(377, 29);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Welcome !";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(131)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.Name = "Main";
            this.Text = "Form1";
            this.panelLoginContainer.ResumeLayout(false);
            this.panelLoginContainer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.CustomTextBoxPassword customTextBoxPassword1;
        private Controls.CustomTextBoxLogin customTextBoxLogin1;
        private System.Windows.Forms.Label labelPasswordCharCount;
        private System.Windows.Forms.Label labelPasswordCharDigit;
        private System.Windows.Forms.Label labelPasswordCharCapital;
        private System.Windows.Forms.Label labelPasswordCharSpecial;
        private System.Windows.Forms.Panel panelPasswordCharCount;
        private System.Windows.Forms.Panel panelPasswordCharDigit;
        private System.Windows.Forms.Panel panelPasswordCharCapital;
        private System.Windows.Forms.Panel panelPasswordCharSpecial;
        private System.Windows.Forms.Panel panelLoginCharSpecial;
        private System.Windows.Forms.Panel panelLoginCharCount;
        private System.Windows.Forms.Label labelLoginCharSpecial;
        private System.Windows.Forms.Label labelLoginCharCount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLoginContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
    }
}

