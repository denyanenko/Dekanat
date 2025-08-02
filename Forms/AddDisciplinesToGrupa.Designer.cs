namespace Dekanat
{
    partial class AddDisciplinesToGrupa
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(23, 335);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(229, 22);
            this.txtFind.TabIndex = 21;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(23, 277);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(229, 52);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Знайти дисципліну";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(206, 404);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(243, 34);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(584, 259);
            this.checkedListBox1.TabIndex = 18;
            // 
            // AddDisciplinesToGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 449);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDisciplinesToGrupa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати дисципліни";
            this.Load += new System.EventHandler(this.AddDisciplinesToGrupa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}