namespace HomeWork4_3_3 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            txtSearchFileName = new TextBox();
            btnSearchFile = new Button();
            label2 = new Label();
            txtSearchResult = new TextBox();
            groupBox1 = new GroupBox();
            gbFileView = new GroupBox();
            btnReadFile = new Button();
            txtFileContent = new TextBox();
            gbFileCompress = new GroupBox();
            txtCompressedFileSize = new TextBox();
            txtCompressedFilePath = new TextBox();
            txtInputFileSize = new TextBox();
            btnCompressFile = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            gbFileView.SuspendLayout();
            gbFileCompress.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(407, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть ім'я файла для пошуку (пошук буде здійснено лише на диску C:)";
            // 
            // txtSearchFileName
            // 
            txtSearchFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchFileName.Location = new Point(20, 49);
            txtSearchFileName.Name = "txtSearchFileName";
            txtSearchFileName.Size = new Size(636, 23);
            txtSearchFileName.TabIndex = 1;
            // 
            // btnSearchFile
            // 
            btnSearchFile.Location = new Point(20, 87);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(75, 23);
            btnSearchFile.TabIndex = 2;
            btnSearchFile.Text = "Пошук";
            btnSearchFile.UseVisualStyleBackColor = true;
            btnSearchFile.Click += btnSearchFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 135);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Результат пошуку:";
            // 
            // txtSearchResult
            // 
            txtSearchResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchResult.Location = new Point(20, 153);
            txtSearchResult.Name = "txtSearchResult";
            txtSearchResult.ReadOnly = true;
            txtSearchResult.Size = new Size(636, 23);
            txtSearchResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSearchResult);
            groupBox1.Controls.Add(txtSearchFileName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSearchFile);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 194);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Пошук файла";
            // 
            // gbFileView
            // 
            gbFileView.Controls.Add(btnReadFile);
            gbFileView.Controls.Add(txtFileContent);
            gbFileView.Enabled = false;
            gbFileView.Location = new Point(12, 224);
            gbFileView.Name = "gbFileView";
            gbFileView.Size = new Size(674, 177);
            gbFileView.TabIndex = 6;
            gbFileView.TabStop = false;
            gbFileView.Text = "2. Перегляд файлу";
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(20, 22);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(154, 23);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "Показати вміст файлу";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFileContent.Location = new Point(20, 58);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ReadOnly = true;
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(636, 100);
            txtFileContent.TabIndex = 0;
            // 
            // gbFileCompress
            // 
            gbFileCompress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbFileCompress.Controls.Add(txtCompressedFileSize);
            gbFileCompress.Controls.Add(txtCompressedFilePath);
            gbFileCompress.Controls.Add(txtInputFileSize);
            gbFileCompress.Controls.Add(btnCompressFile);
            gbFileCompress.Controls.Add(label4);
            gbFileCompress.Controls.Add(label5);
            gbFileCompress.Controls.Add(label3);
            gbFileCompress.Enabled = false;
            gbFileCompress.Location = new Point(12, 407);
            gbFileCompress.Name = "gbFileCompress";
            gbFileCompress.Size = new Size(674, 134);
            gbFileCompress.TabIndex = 7;
            gbFileCompress.TabStop = false;
            gbFileCompress.Text = "3. Стиснення файла";
            // 
            // txtCompressedFileSize
            // 
            txtCompressedFileSize.Location = new Point(356, 37);
            txtCompressedFileSize.Name = "txtCompressedFileSize";
            txtCompressedFileSize.ReadOnly = true;
            txtCompressedFileSize.Size = new Size(129, 23);
            txtCompressedFileSize.TabIndex = 2;
            // 
            // txtCompressedFilePath
            // 
            txtCompressedFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCompressedFilePath.Location = new Point(148, 93);
            txtCompressedFilePath.Name = "txtCompressedFilePath";
            txtCompressedFilePath.ReadOnly = true;
            txtCompressedFilePath.Size = new Size(508, 23);
            txtCompressedFilePath.TabIndex = 2;
            // 
            // txtInputFileSize
            // 
            txtInputFileSize.Location = new Point(148, 37);
            txtInputFileSize.Name = "txtInputFileSize";
            txtInputFileSize.ReadOnly = true;
            txtInputFileSize.Size = new Size(129, 23);
            txtInputFileSize.TabIndex = 2;
            // 
            // btnCompressFile
            // 
            btnCompressFile.Location = new Point(20, 32);
            btnCompressFile.Name = "btnCompressFile";
            btnCompressFile.Size = new Size(109, 23);
            btnCompressFile.TabIndex = 1;
            btnCompressFile.Text = "Стиснути файл";
            btnCompressFile.UseVisualStyleBackColor = true;
            btnCompressFile.Click += btnCompressFile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 19);
            label4.Name = "label4";
            label4.Size = new Size(181, 15);
            label4.TabIndex = 0;
            label4.Text = "Об'єм стисненого файлу (байт)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 75);
            label5.Name = "label5";
            label5.Size = new Size(157, 15);
            label5.TabIndex = 0;
            label5.Text = "Шлях до стисненого файлу";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 19);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 0;
            label3.Text = "Об'єм вхідного файлу (байт)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 556);
            Controls.Add(gbFileCompress);
            Controls.Add(gbFileView);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeWork 4_3_3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFileView.ResumeLayout(false);
            gbFileView.PerformLayout();
            gbFileCompress.ResumeLayout(false);
            gbFileCompress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtSearchFileName;
        private Button btnSearchFile;
        private Label label2;
        private TextBox txtSearchResult;
        private GroupBox groupBox1;
        private GroupBox gbFileView;
        private Button btnReadFile;
        private TextBox txtFileContent;
        private GroupBox gbFileCompress;
        private TextBox txtCompressedFileSize;
        private TextBox txtCompressedFilePath;
        private TextBox txtInputFileSize;
        private Button btnCompressFile;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}
