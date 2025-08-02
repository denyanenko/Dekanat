namespace Dekanat
{
    partial class AddStudentToGrupa
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lstFind = new System.Windows.Forms.ListBox();
            this.txtVlastivosty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(344, 361);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(153, 381);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(243, 34);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(350, 58);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(229, 22);
            this.txtFind.TabIndex = 11;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(350, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(229, 52);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Знайти студента\r\n(Ведіть повне ім\'я)";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstFind
            // 
            this.lstFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstFind.FormattingEnabled = true;
            this.lstFind.ItemHeight = 22;
            this.lstFind.Location = new System.Drawing.Point(350, 77);
            this.lstFind.Name = "lstFind";
            this.lstFind.Size = new System.Drawing.Size(233, 70);
            this.lstFind.TabIndex = 12;
            this.lstFind.SelectedIndexChanged += new System.EventHandler(this.lstFind_SelectedIndexChanged);
            // 
            // txtVlastivosty
            // 
            this.txtVlastivosty.Location = new System.Drawing.Point(350, 153);
            this.txtVlastivosty.Multiline = true;
            this.txtVlastivosty.Name = "txtVlastivosty";
            this.txtVlastivosty.ReadOnly = true;
            this.txtVlastivosty.Size = new System.Drawing.Size(233, 131);
            this.txtVlastivosty.TabIndex = 13;
            // 
            // AddStudentToGrupa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.Controls.Add(this.txtVlastivosty);
            this.Controls.Add(this.lstFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentToGrupa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентів з непризначеною групою";
            this.Load += new System.EventHandler(this.StudentWithoutGrupa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstFind;
        private System.Windows.Forms.TextBox txtVlastivosty;
    }
}