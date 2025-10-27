namespace ReadingFile
{
    partial class FrmStudentRecord
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
            label1 = new Label();
            lvShowText = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(177, 39);
            label1.TabIndex = 0;
            label1.Text = "View Record";
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(19, 75);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(582, 264);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Impact", 12F);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(442, 357);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(99, 41);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Black;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Impact", 12F);
            btnFind.ForeColor = SystemColors.ButtonFace;
            btnFind.Location = new Point(265, 358);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(99, 40);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Black;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Impact", 12F);
            btnUpload.ForeColor = SystemColors.ButtonFace;
            btnUpload.Location = new Point(65, 361);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(99, 37);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(619, 422);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvShowText;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
        private OpenFileDialog openFileDialog1;
    }
}