namespace restClient
{
    partial class Form1
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGO = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoBasicAuth = new System.Windows.Forms.RadioButton();
            this.rdoNTLMAuth = new System.Windows.Forms.RadioButton();
            this.rdoRollOwn = new System.Windows.Forms.RadioButton();
            this.rdoNetCred = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtURL.Location = new System.Drawing.Point(103, 17);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(448, 20);
            this.txtURL.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResponse.Location = new System.Drawing.Point(105, 212);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(527, 141);
            this.txtResponse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // cmdGO
            // 
            this.cmdGO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGO.Location = new System.Drawing.Point(557, 16);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(75, 23);
            this.cmdGO.TabIndex = 5;
            this.cmdGO.Text = "GO";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(169, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(420, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNTLMAuth);
            this.groupBox1.Controls.Add(this.rdoBasicAuth);
            this.groupBox1.Location = new System.Drawing.Point(105, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auth Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNetCred);
            this.groupBox2.Controls.Add(this.rdoRollOwn);
            this.groupBox2.Location = new System.Drawing.Point(361, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Technique";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // rdoBasicAuth
            // 
            this.rdoBasicAuth.AutoSize = true;
            this.rdoBasicAuth.Checked = true;
            this.rdoBasicAuth.Location = new System.Drawing.Point(24, 31);
            this.rdoBasicAuth.Name = "rdoBasicAuth";
            this.rdoBasicAuth.Size = new System.Drawing.Size(122, 17);
            this.rdoBasicAuth.TabIndex = 0;
            this.rdoBasicAuth.TabStop = true;
            this.rdoBasicAuth.Text = "Basic Authentication";
            this.rdoBasicAuth.UseVisualStyleBackColor = true;
            // 
            // rdoNTLMAuth
            // 
            this.rdoNTLMAuth.AutoSize = true;
            this.rdoNTLMAuth.Location = new System.Drawing.Point(24, 54);
            this.rdoNTLMAuth.Name = "rdoNTLMAuth";
            this.rdoNTLMAuth.Size = new System.Drawing.Size(105, 17);
            this.rdoNTLMAuth.TabIndex = 1;
            this.rdoNTLMAuth.TabStop = true;
            this.rdoNTLMAuth.Text = "NTLM(Windows)";
            this.rdoNTLMAuth.UseVisualStyleBackColor = true;
            // 
            // rdoRollOwn
            // 
            this.rdoRollOwn.AutoSize = true;
            this.rdoRollOwn.Checked = true;
            this.rdoRollOwn.Location = new System.Drawing.Point(30, 31);
            this.rdoRollOwn.Name = "rdoRollOwn";
            this.rdoRollOwn.Size = new System.Drawing.Size(93, 17);
            this.rdoRollOwn.TabIndex = 0;
            this.rdoRollOwn.TabStop = true;
            this.rdoRollOwn.Text = "Roll Your Own";
            this.rdoRollOwn.UseVisualStyleBackColor = true;
            // 
            // rdoNetCred
            // 
            this.rdoNetCred.AutoSize = true;
            this.rdoNetCred.Location = new System.Drawing.Point(30, 54);
            this.rdoNetCred.Name = "rdoNetCred";
            this.rdoNetCred.Size = new System.Drawing.Size(143, 17);
            this.rdoNetCred.TabIndex = 1;
            this.rdoNetCred.TabStop = true;
            this.rdoNetCred.Text = "Network Credential Class";
            this.rdoNetCred.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 375);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.cmdGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtURL);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "C# REST Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGO;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNTLMAuth;
        private System.Windows.Forms.RadioButton rdoBasicAuth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNetCred;
        private System.Windows.Forms.RadioButton rdoRollOwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

