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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentRecord));
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 30F);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 48);
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
            btnRegister.BackColor = Color.DodgerBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Impact", 12F);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(458, 361);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(99, 41);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.DodgerBlue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Impact", 12F);
            btnFind.ForeColor = SystemColors.ButtonFace;
            btnFind.Location = new Point(268, 361);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(99, 40);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.DodgerBlue;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Impact", 12F);
            btnUpload.ForeColor = SystemColors.ButtonFace;
            btnUpload.Location = new Point(66, 365);
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
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
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