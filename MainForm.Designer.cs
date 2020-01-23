namespace Reflector_Keygen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.serialTextbox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.requestTextbox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.responseTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AutoSize = true;
            this.minimizeBtn.Location = new System.Drawing.Point(586, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(17, 21);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Location = new System.Drawing.Point(605, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 21);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // serialTextbox
            // 
            this.serialTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialTextbox.Location = new System.Drawing.Point(24, 92);
            this.serialTextbox.Name = "serialTextbox";
            this.serialTextbox.ReadOnly = true;
            this.serialTextbox.Size = new System.Drawing.Size(482, 29);
            this.serialTextbox.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(525, 92);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(76, 29);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // requestTextbox
            // 
            this.requestTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTextbox.Location = new System.Drawing.Point(24, 160);
            this.requestTextbox.Name = "requestTextbox";
            this.requestTextbox.Size = new System.Drawing.Size(482, 124);
            this.requestTextbox.TabIndex = 4;
            this.requestTextbox.Text = "";
            this.requestTextbox.TextChanged += new System.EventHandler(this.requestTextbox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(24, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 30);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = ".NET Reflector Keygen";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(20, 68);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(151, 21);
            this.serialLabel.TabIndex = 6;
            this.serialLabel.Text = "Generated serial key";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(20, 136);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(66, 21);
            this.requestLabel.TabIndex = 7;
            this.requestLabel.Text = "Request";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(20, 302);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(149, 21);
            this.responseLabel.TabIndex = 9;
            this.responseLabel.Text = "Generated response";
            // 
            // responseTextbox
            // 
            this.responseTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.responseTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTextbox.Location = new System.Drawing.Point(24, 326);
            this.responseTextbox.Name = "responseTextbox";
            this.responseTextbox.ReadOnly = true;
            this.responseTextbox.Size = new System.Drawing.Size(482, 131);
            this.responseTextbox.TabIndex = 8;
            this.responseTextbox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(625, 480);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.responseTextbox);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.requestTextbox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.serialTextbox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = ".NET Reflector Keygen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox serialTextbox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RichTextBox requestTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.RichTextBox responseTextbox;
    }
}

