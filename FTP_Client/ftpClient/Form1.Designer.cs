
namespace ftpClient
{
    partial class Form1
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
            this.cBoxDrivers = new System.Windows.Forms.ComboBox();
            this.tBoxL = new System.Windows.Forms.TextBox();
            this.lBoxL = new System.Windows.Forms.ListBox();
            this.btnL = new System.Windows.Forms.Button();
            this.btnRConnect = new System.Windows.Forms.Button();
            this.lBoxR = new System.Windows.Forms.ListBox();
            this.tBoxR = new System.Windows.Forms.TextBox();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.btnNewDir = new System.Windows.Forms.Button();
            this.tBoxNew = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxDrivers
            // 
            this.cBoxDrivers.FormattingEnabled = true;
            this.cBoxDrivers.Location = new System.Drawing.Point(12, 21);
            this.cBoxDrivers.Name = "cBoxDrivers";
            this.cBoxDrivers.Size = new System.Drawing.Size(121, 21);
            this.cBoxDrivers.TabIndex = 0;
            this.cBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.cBoxDrivers_SelectedIndexChanged);
            // 
            // tBoxL
            // 
            this.tBoxL.Location = new System.Drawing.Point(11, 48);
            this.tBoxL.Name = "tBoxL";
            this.tBoxL.Size = new System.Drawing.Size(259, 20);
            this.tBoxL.TabIndex = 1;
            // 
            // lBoxL
            // 
            this.lBoxL.FormattingEnabled = true;
            this.lBoxL.Location = new System.Drawing.Point(12, 74);
            this.lBoxL.Name = "lBoxL";
            this.lBoxL.Size = new System.Drawing.Size(339, 329);
            this.lBoxL.TabIndex = 2;
            this.lBoxL.Click += new System.EventHandler(this.lBoxL_Click);
            this.lBoxL.DoubleClick += new System.EventHandler(this.lBoxL_DoubleClick);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(276, 45);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "Перейти";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnRConnect
            // 
            this.btnRConnect.Location = new System.Drawing.Point(667, 45);
            this.btnRConnect.Name = "btnRConnect";
            this.btnRConnect.Size = new System.Drawing.Size(104, 75);
            this.btnRConnect.TabIndex = 6;
            this.btnRConnect.Text = "Подключить";
            this.btnRConnect.UseVisualStyleBackColor = true;
            this.btnRConnect.Click += new System.EventHandler(this.btnRConnect_Click);
            // 
            // lBoxR
            // 
            this.lBoxR.FormattingEnabled = true;
            this.lBoxR.Location = new System.Drawing.Point(432, 139);
            this.lBoxR.Name = "lBoxR";
            this.lBoxR.Size = new System.Drawing.Size(339, 264);
            this.lBoxR.TabIndex = 5;
            this.lBoxR.Click += new System.EventHandler(this.lBoxR_Click);
            // 
            // tBoxR
            // 
            this.tBoxR.Location = new System.Drawing.Point(431, 48);
            this.tBoxR.Name = "tBoxR";
            this.tBoxR.Size = new System.Drawing.Size(230, 20);
            this.tBoxR.TabIndex = 4;
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Location = new System.Drawing.Point(488, 74);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(173, 20);
            this.tBoxLogin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // tBoxPass
            // 
            this.tBoxPass.Location = new System.Drawing.Point(488, 100);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.Size = new System.Drawing.Size(173, 20);
            this.tBoxPass.TabIndex = 9;
            // 
            // btnNewDir
            // 
            this.btnNewDir.Location = new System.Drawing.Point(102, 410);
            this.btnNewDir.Name = "btnNewDir";
            this.btnNewDir.Size = new System.Drawing.Size(119, 23);
            this.btnNewDir.TabIndex = 12;
            this.btnNewDir.Text = "Создать папку";
            this.btnNewDir.UseVisualStyleBackColor = true;
            this.btnNewDir.Click += new System.EventHandler(this.btnNewDir_Click);
            // 
            // tBoxNew
            // 
            this.tBoxNew.Location = new System.Drawing.Point(11, 412);
            this.tBoxNew.Name = "tBoxNew";
            this.tBoxNew.Size = new System.Drawing.Size(85, 20);
            this.tBoxNew.TabIndex = 11;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(227, 412);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(94, 23);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(427, 409);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "переместить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnNewDir);
            this.Controls.Add(this.tBoxNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxLogin);
            this.Controls.Add(this.btnRConnect);
            this.Controls.Add(this.lBoxR);
            this.Controls.Add(this.tBoxR);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.lBoxL);
            this.Controls.Add(this.tBoxL);
            this.Controls.Add(this.cBoxDrivers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxDrivers;
        private System.Windows.Forms.TextBox tBoxL;
        private System.Windows.Forms.ListBox lBoxL;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnRConnect;
        private System.Windows.Forms.ListBox lBoxR;
        private System.Windows.Forms.TextBox tBoxR;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.Button btnNewDir;
        private System.Windows.Forms.TextBox tBoxNew;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button6;
    }
}

