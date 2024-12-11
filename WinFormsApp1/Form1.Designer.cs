namespace WinFormsApp1
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
            txtWorkerName = new TextBox();
            btnAddWorker = new Button();
            lstWorkers = new ListBox();
            btnDeleteWorker = new Button();
            SuspendLayout();
            // 
            // txtWorkerName
            // 
            txtWorkerName.Location = new Point(21, 38);
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.Size = new Size(125, 27);
            txtWorkerName.TabIndex = 0;
            txtWorkerName.KeyDown += txtWorkerName_KeyDown;
            // 
            // btnAddWorker
            // 
            btnAddWorker.Location = new Point(21, 80);
            btnAddWorker.Name = "btnAddWorker";
            btnAddWorker.Size = new Size(94, 29);
            btnAddWorker.TabIndex = 1;
            btnAddWorker.Text = "Ekle";
            btnAddWorker.UseVisualStyleBackColor = true;
            btnAddWorker.Click += btnAddWorker_Click;
            // 
            // lstWorkers
            // 
            lstWorkers.FormattingEnabled = true;
            lstWorkers.Location = new Point(205, 38);
            lstWorkers.Name = "lstWorkers";
            lstWorkers.Size = new Size(125, 344);
            lstWorkers.TabIndex = 2;
            // 
            // btnDeleteWorker
            // 
            btnDeleteWorker.Location = new Point(336, 36);
            btnDeleteWorker.Name = "btnDeleteWorker";
            btnDeleteWorker.Size = new Size(94, 29);
            btnDeleteWorker.TabIndex = 3;
            btnDeleteWorker.Text = "Sil";
            btnDeleteWorker.UseVisualStyleBackColor = true;
            btnDeleteWorker.Click += btnDeleteWorker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteWorker);
            Controls.Add(lstWorkers);
            Controls.Add(btnAddWorker);
            Controls.Add(txtWorkerName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWorkerName;
        private Button btnAddWorker;
        private ListBox lstWorkers;
        private Button btnDeleteWorker;
    }
}
