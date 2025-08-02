namespace Dekanat
{
    partial class GrupForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gruplst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.textfindg = new System.Windows.Forms.TextBox();
            this.textnew = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnCursUp = new System.Windows.Forms.Button();
            this.btndelgrup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gruplst
            // 
            this.gruplst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gruplst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gruplst.FormattingEnabled = true;
            this.gruplst.ItemHeight = 22;
            this.gruplst.Location = new System.Drawing.Point(36, 76);
            this.gruplst.Name = "gruplst";
            this.gruplst.Size = new System.Drawing.Size(191, 444);
            this.gruplst.TabIndex = 0;
            this.gruplst.SelectedIndexChanged += new System.EventHandler(this.gruplst_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список груп";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGroup.Location = new System.Drawing.Point(259, 76);
            this.txtGroup.Multiline = true;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(229, 112);
            this.txtGroup.TabIndex = 3;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(259, 194);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(147, 29);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Знайти групу";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.button1_Click);
            // 
            // textfindg
            // 
            this.textfindg.Location = new System.Drawing.Point(259, 229);
            this.textfindg.Name = "textfindg";
            this.textfindg.Size = new System.Drawing.Size(147, 22);
            this.textfindg.TabIndex = 5;
            this.textfindg.TextChanged += new System.EventHandler(this.textfindg_TextChanged);
            // 
            // textnew
            // 
            this.textnew.Location = new System.Drawing.Point(259, 305);
            this.textnew.Name = "textnew";
            this.textnew.Size = new System.Drawing.Size(147, 22);
            this.textnew.TabIndex = 7;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(259, 270);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(147, 29);
            this.btnnew.TabIndex = 6;
            this.btnnew.Text = "Створити групу";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // btnCursUp
            // 
            this.btnCursUp.Location = new System.Drawing.Point(259, 345);
            this.btnCursUp.Name = "btnCursUp";
            this.btnCursUp.Size = new System.Drawing.Size(147, 53);
            this.btnCursUp.TabIndex = 8;
            this.btnCursUp.Text = "Перевести групу на наступний курс";
            this.btnCursUp.UseVisualStyleBackColor = true;
            this.btnCursUp.Click += new System.EventHandler(this.btnCursUp_Click);
            // 
            // btndelgrup
            // 
            this.btndelgrup.Location = new System.Drawing.Point(259, 418);
            this.btndelgrup.Name = "btndelgrup";
            this.btndelgrup.Size = new System.Drawing.Size(147, 48);
            this.btndelgrup.TabIndex = 9;
            this.btndelgrup.Text = "Видалити групу";
            this.btndelgrup.UseVisualStyleBackColor = true;
            this.btndelgrup.Click += new System.EventHandler(this.btndelgrup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Редагувати групу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 66);
            this.button2.TabIndex = 11;
            this.button2.Text = "Відкрити список студентів групи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Додати дисципліни до групи";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GrupForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(778, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndelgrup);
            this.Controls.Add(this.btnCursUp);
            this.Controls.Add(this.textnew);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.textfindg);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gruplst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список груп";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox textfindg;
        private System.Windows.Forms.TextBox textnew;
        private System.Windows.Forms.Button btnnew;
        public System.Windows.Forms.ListBox gruplst;
        private System.Windows.Forms.Button btnCursUp;
        private System.Windows.Forms.Button btndelgrup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

