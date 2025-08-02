namespace Dekanat
{
    partial class StudentsGrupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.brnStarosta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtVlastivosty = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lstDiscipline = new System.Windows.Forms.ListBox();
            this.btnAddDiscipline = new System.Windows.Forms.Button();
            this.lstFind = new System.Windows.Forms.ListBox();
            this.btnDelDiscipline = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 33);
            this.label1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати студентів";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(337, 306);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 41);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Видалити студента з групи";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // brnStarosta
            // 
            this.brnStarosta.Location = new System.Drawing.Point(337, 353);
            this.brnStarosta.Name = "brnStarosta";
            this.brnStarosta.Size = new System.Drawing.Size(150, 41);
            this.brnStarosta.TabIndex = 6;
            this.brnStarosta.Text = "Назначити старостою";
            this.brnStarosta.UseVisualStyleBackColor = true;
            this.brnStarosta.Click += new System.EventHandler(this.brnStarosta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Знайти студента\r\n(Ведіть повне ім\'я)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(524, 289);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(233, 22);
            this.txtFind.TabIndex = 9;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // txtVlastivosty
            // 
            this.txtVlastivosty.Location = new System.Drawing.Point(328, 74);
            this.txtVlastivosty.Multiline = true;
            this.txtVlastivosty.Name = "txtVlastivosty";
            this.txtVlastivosty.ReadOnly = true;
            this.txtVlastivosty.Size = new System.Drawing.Size(159, 179);
            this.txtVlastivosty.TabIndex = 10;
            this.txtVlastivosty.TextChanged += new System.EventHandler(this.txtVlastivosty_TextChanged);
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 22;
            this.lstStudents.Location = new System.Drawing.Point(12, 74);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(310, 466);
            this.lstStudents.TabIndex = 11;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Видалити всіх студентів з групи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstDiscipline
            // 
            this.lstDiscipline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstDiscipline.FormattingEnabled = true;
            this.lstDiscipline.ItemHeight = 22;
            this.lstDiscipline.Location = new System.Drawing.Point(499, 74);
            this.lstDiscipline.Name = "lstDiscipline";
            this.lstDiscipline.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDiscipline.Size = new System.Drawing.Size(258, 136);
            this.lstDiscipline.TabIndex = 13;
            // 
            // btnAddDiscipline
            // 
            this.btnAddDiscipline.Location = new System.Drawing.Point(524, 383);
            this.btnAddDiscipline.Name = "btnAddDiscipline";
            this.btnAddDiscipline.Size = new System.Drawing.Size(173, 41);
            this.btnAddDiscipline.TabIndex = 14;
            this.btnAddDiscipline.Text = "Додати дисципліни";
            this.btnAddDiscipline.UseVisualStyleBackColor = true;
            this.btnAddDiscipline.Click += new System.EventHandler(this.btnAddDiscipline_Click);
            // 
            // lstFind
            // 
            this.lstFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstFind.FormattingEnabled = true;
            this.lstFind.ItemHeight = 22;
            this.lstFind.Location = new System.Drawing.Point(524, 317);
            this.lstFind.Name = "lstFind";
            this.lstFind.Size = new System.Drawing.Size(233, 48);
            this.lstFind.TabIndex = 15;
            this.lstFind.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // btnDelDiscipline
            // 
            this.btnDelDiscipline.Location = new System.Drawing.Point(524, 447);
            this.btnDelDiscipline.Name = "btnDelDiscipline";
            this.btnDelDiscipline.Size = new System.Drawing.Size(173, 45);
            this.btnDelDiscipline.TabIndex = 16;
            this.btnDelDiscipline.Text = "Видалити дисципліни\r\n(можна обрати більше 1)";
            this.btnDelDiscipline.UseVisualStyleBackColor = true;
            this.btnDelDiscipline.Click += new System.EventHandler(this.btnDelDiscipline_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 29;
            this.button3.Text = "Редагувати студента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentsGrupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelDiscipline);
            this.Controls.Add(this.lstFind);
            this.Controls.Add(this.btnAddDiscipline);
            this.Controls.Add(this.lstDiscipline);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.txtVlastivosty);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brnStarosta);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentsGrupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентів групи";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button brnStarosta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtVlastivosty;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstDiscipline;
        private System.Windows.Forms.Button btnAddDiscipline;
        private System.Windows.Forms.ListBox lstFind;
        private System.Windows.Forms.Button btnDelDiscipline;
        private System.Windows.Forms.Button button3;
    }
}