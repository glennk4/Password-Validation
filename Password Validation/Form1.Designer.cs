namespace Password_Validation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassInput = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EyeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EyeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a password: ";
            // 
            // PassInput
            // 
            this.PassInput.Location = new System.Drawing.Point(625, 309);
            this.PassInput.Name = "PassInput";
            this.PassInput.Size = new System.Drawing.Size(250, 20);
            this.PassInput.TabIndex = 2;
            this.PassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassInput.UseSystemPasswordChar = true;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(625, 365);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 42);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Check Password";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(822, 365);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 42);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EyeButton
            // 
            this.EyeButton.Image = ((System.Drawing.Image)(resources.GetObject("EyeButton.Image")));
            this.EyeButton.Location = new System.Drawing.Point(889, 309);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(33, 20);
            this.EyeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeButton.TabIndex = 5;
            this.EyeButton.TabStop = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1452, 531);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PassInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Validation";
            ((System.ComponentModel.ISupportInitialize)(this.EyeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassInput;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox EyeButton;
    }
}

