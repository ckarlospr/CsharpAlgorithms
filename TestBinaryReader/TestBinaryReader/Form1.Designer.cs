namespace TestBinaryReader
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
            btnFile = new Button();
            txtFile = new TextBox();
            txtResult = new TextBox();
            btnRead = new Button();
            txtCnt = new TextBox();
            SuspendLayout();
            // 
            // btnFile
            // 
            btnFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFile.Location = new Point(201, 36);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(75, 23);
            btnFile.TabIndex = 0;
            btnFile.Text = "File";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // txtFile
            // 
            txtFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFile.Location = new Point(38, 36);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(148, 23);
            txtFile.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Location = new Point(95, 89);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(181, 23);
            txtResult.TabIndex = 2;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(38, 89);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(51, 23);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // txtCnt
            // 
            txtCnt.Location = new Point(38, 62);
            txtCnt.Name = "txtCnt";
            txtCnt.Size = new Size(51, 23);
            txtCnt.TabIndex = 4;
            txtCnt.Text = "5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 141);
            Controls.Add(txtCnt);
            Controls.Add(btnRead);
            Controls.Add(txtResult);
            Controls.Add(txtFile);
            Controls.Add(btnFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFile;
        private TextBox txtFile;
        private TextBox txtResult;
        private Button btnRead;
        private TextBox txtCnt;
    }
}