namespace FormApp
{
    partial class MyForm
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
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.mybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(80, 29);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(660, 31);
            this.myTextBox.TabIndex = 0;
            this.myTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mybutton
            // 
            this.mybutton.Location = new System.Drawing.Point(80, 102);
            this.mybutton.Name = "mybutton";
            this.mybutton.Size = new System.Drawing.Size(660, 40);
            this.mybutton.TabIndex = 1;
            this.mybutton.Text = "Say Hello";
            this.mybutton.UseVisualStyleBackColor = true;
            this.mybutton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybutton);
            this.Controls.Add(this.myTextBox);
            this.Name = "MyForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button mybutton;
    }
}

