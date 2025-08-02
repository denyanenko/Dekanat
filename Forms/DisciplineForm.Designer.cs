namespace Dekanat
{
    partial class DisciplineForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtModify = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.textfindd = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Спискок дисциплін";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(412, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 73);
            this.button1.TabIndex = 18;
            this.button1.Text = "Додати дисципліну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(412, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 73);
            this.button2.TabIndex = 19;
            this.button2.Text = "Видалити дисципліну";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(412, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 73);
            this.button3.TabIndex = 20;
            this.button3.Text = "Змінити назву";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtModify
            // 
            this.txtModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtModify.Location = new System.Drawing.Point(412, 274);
            this.txtModify.Name = "txtModify";
            this.txtModify.Size = new System.Drawing.Size(175, 27);
            this.txtModify.TabIndex = 21;
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAdd.Location = new System.Drawing.Point(412, 147);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(175, 27);
            this.txtAdd.TabIndex = 22;
            // 
            // textfindd
            // 
            this.textfindd.Location = new System.Drawing.Point(412, 496);
            this.textfindd.Name = "textfindd";
            this.textfindd.Size = new System.Drawing.Size(175, 22);
            this.textfindd.TabIndex = 24;
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnfind.Location = new System.Drawing.Point(412, 417);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(175, 73);
            this.btnfind.TabIndex = 23;
            this.btnfind.Text = "Знайти дисципліну";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // DisciplineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.textfindd);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtModify);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisciplineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дисципліни";
            this.Load += new System.EventHandler(this.DisciplineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtModify;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox textfindd;
        private System.Windows.Forms.Button btnfind;
    }
}