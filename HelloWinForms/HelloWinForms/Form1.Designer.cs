namespace HelloWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloLabel = new System.Windows.Forms.Label();
            this.nsmeTextBox = new System.Windows.Forms.TextBox();
            this.sayHelloBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(303, 87);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(171, 18);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello WIndows Forms";
            // 
            // nsmeTextBox
            // 
            this.nsmeTextBox.Location = new System.Drawing.Point(335, 148);
            this.nsmeTextBox.Name = "nsmeTextBox";
            this.nsmeTextBox.Size = new System.Drawing.Size(100, 23);
            this.nsmeTextBox.TabIndex = 1;
            // 
            // sayHelloBtn
            // 
            this.sayHelloBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sayHelloBtn.Location = new System.Drawing.Point(345, 186);
            this.sayHelloBtn.Name = "sayHelloBtn";
            this.sayHelloBtn.Size = new System.Drawing.Size(75, 23);
            this.sayHelloBtn.TabIndex = 2;
            this.sayHelloBtn.Text = "Say Hello";
            this.sayHelloBtn.UseVisualStyleBackColor = false;
            this.sayHelloBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 360);
            this.Controls.Add(this.sayHelloBtn);
            this.Controls.Add(this.nsmeTextBox);
            this.Controls.Add(this.helloLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label helloLabel;
        private TextBox nsmeTextBox;
        private Button sayHelloBtn;
    }
}