namespace GoogleUploadFromCSharp
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
            btnUpload = new Button();
            txtFile = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtfileList = new TextBox();
            label3 = new Label();
            btnDelete = new Button();
            btnFileList = new Button();
            label4 = new Label();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(155, 134);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(93, 29);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload File";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(155, 62);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(411, 23);
            txtFile.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 65);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Local File";
            // 
            // txtID
            // 
            txtID.Location = new Point(155, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(411, 23);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 98);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "File Key";
            // 
            // txtfileList
            // 
            txtfileList.Location = new Point(155, 187);
            txtfileList.Multiline = true;
            txtfileList.Name = "txtfileList";
            txtfileList.Size = new Size(633, 210);
            txtfileList.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 190);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "File Key";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete File";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFileList
            // 
            btnFileList.Location = new Point(364, 134);
            btnFileList.Name = "btnFileList";
            btnFileList.Size = new Size(202, 29);
            btnFileList.TabIndex = 0;
            btnFileList.Text = "Get Files List";
            btnFileList.UseVisualStyleBackColor = true;
            btnFileList.Click += btnFileList_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(211, 19);
            label4.Name = "label4";
            label4.Size = new Size(396, 25);
            label4.TabIndex = 3;
            label4.Text = "File Upload / Download From Google Drive";
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSelect.Location = new Point(571, 62);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtfileList);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(txtFile);
            Controls.Add(btnFileList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpload);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpload;
        private TextBox txtFile;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtfileList;
        private Label label3;
        private Button btnDelete;
        private Button btnFileList;
        private Label label4;
        private Button btnSelect;
    }
}
