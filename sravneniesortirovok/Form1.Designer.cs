namespace prv1
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
            this.StartSortingButtom = new System.Windows.Forms.Button();
            this.SuccessivelyRButtom = new System.Windows.Forms.RadioButton();
            this.ParallelyRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbuble = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listVBubble = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listVPerest = new System.Windows.Forms.ListView();
            this.Perestanovki = new System.Windows.Forms.Label();
            this.bPerest = new System.Windows.Forms.Button();
            this.lPerest = new System.Windows.Forms.Label();
            this.listVShell = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lShell = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartSortingButtom
            // 
            this.StartSortingButtom.Location = new System.Drawing.Point(52, 189);
            this.StartSortingButtom.Name = "StartSortingButtom";
            this.StartSortingButtom.Size = new System.Drawing.Size(128, 23);
            this.StartSortingButtom.TabIndex = 0;
            this.StartSortingButtom.Text = "Start sorting";
            this.StartSortingButtom.UseVisualStyleBackColor = true;
            this.StartSortingButtom.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuccessivelyRButtom
            // 
            this.SuccessivelyRButtom.AutoSize = true;
            this.SuccessivelyRButtom.Checked = true;
            this.SuccessivelyRButtom.Location = new System.Drawing.Point(6, 20);
            this.SuccessivelyRButtom.Name = "SuccessivelyRButtom";
            this.SuccessivelyRButtom.Size = new System.Drawing.Size(87, 17);
            this.SuccessivelyRButtom.TabIndex = 1;
            this.SuccessivelyRButtom.TabStop = true;
            this.SuccessivelyRButtom.Text = "Successively";
            this.SuccessivelyRButtom.UseVisualStyleBackColor = true;
            // 
            // ParallelyRButton
            // 
            this.ParallelyRButton.AutoSize = true;
            this.ParallelyRButton.Location = new System.Drawing.Point(6, 43);
            this.ParallelyRButton.Name = "ParallelyRButton";
            this.ParallelyRButton.Size = new System.Drawing.Size(64, 17);
            this.ParallelyRButton.TabIndex = 2;
            this.ParallelyRButton.Text = "Parallely";
            this.ParallelyRButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size of each vector";
            // 
            // lbuble
            // 
            this.lbuble.AutoSize = true;
            this.lbuble.Location = new System.Drawing.Point(222, 310);
            this.lbuble.Name = "lbuble";
            this.lbuble.Size = new System.Drawing.Size(0, 13);
            this.lbuble.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "show detailes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bubble sort";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParallelyRButton);
            this.groupBox1.Controls.Add(this.SuccessivelyRButtom);
            this.groupBox1.Location = new System.Drawing.Point(52, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // listVBubble
            // 
            this.listVBubble.HideSelection = false;
            this.listVBubble.Location = new System.Drawing.Point(216, 81);
            this.listVBubble.Name = "listVBubble";
            this.listVBubble.Size = new System.Drawing.Size(107, 196);
            this.listVBubble.TabIndex = 10;
            this.listVBubble.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100",
            "1000",
            "5000",
            "10000",
            "50000",
            "100000",
            "500000"});
            this.comboBox1.Location = new System.Drawing.Point(52, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "100";
            // 
            // listVPerest
            // 
            this.listVPerest.HideSelection = false;
            this.listVPerest.Location = new System.Drawing.Point(344, 81);
            this.listVPerest.Name = "listVPerest";
            this.listVPerest.Size = new System.Drawing.Size(107, 196);
            this.listVPerest.TabIndex = 16;
            this.listVPerest.UseCompatibleStateImageBehavior = false;
            // 
            // Perestanovki
            // 
            this.Perestanovki.AutoSize = true;
            this.Perestanovki.Location = new System.Drawing.Point(350, 54);
            this.Perestanovki.Name = "Perestanovki";
            this.Perestanovki.Size = new System.Drawing.Size(69, 13);
            this.Perestanovki.TabIndex = 15;
            this.Perestanovki.Text = "Perestanovki";
            // 
            // bPerest
            // 
            this.bPerest.Location = new System.Drawing.Point(344, 283);
            this.bPerest.Name = "bPerest";
            this.bPerest.Size = new System.Drawing.Size(107, 24);
            this.bPerest.TabIndex = 14;
            this.bPerest.Text = "show detailes";
            this.bPerest.UseVisualStyleBackColor = true;
            this.bPerest.Click += new System.EventHandler(this.bPerest_Click);
            // 
            // lPerest
            // 
            this.lPerest.AutoSize = true;
            this.lPerest.Location = new System.Drawing.Point(350, 310);
            this.lPerest.Name = "lPerest";
            this.lPerest.Size = new System.Drawing.Size(0, 13);
            this.lPerest.TabIndex = 13;
            // 
            // listVShell
            // 
            this.listVShell.HideSelection = false;
            this.listVShell.Location = new System.Drawing.Point(470, 81);
            this.listVShell.Name = "listVShell";
            this.listVShell.Size = new System.Drawing.Size(107, 196);
            this.listVShell.TabIndex = 20;
            this.listVShell.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Shell sort";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 24);
            this.button3.TabIndex = 18;
            this.button3.Text = "show detailes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lShell
            // 
            this.lShell.AutoSize = true;
            this.lShell.Location = new System.Drawing.Point(476, 310);
            this.lShell.Name = "lShell";
            this.lShell.Size = new System.Drawing.Size(0, 13);
            this.lShell.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listVShell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lShell);
            this.Controls.Add(this.listVPerest);
            this.Controls.Add(this.Perestanovki);
            this.Controls.Add(this.bPerest);
            this.Controls.Add(this.lPerest);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listVBubble);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbuble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartSortingButtom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartSortingButtom;
        private System.Windows.Forms.RadioButton SuccessivelyRButtom;
        private System.Windows.Forms.RadioButton ParallelyRButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbuble;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listVBubble;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listVPerest;
        private System.Windows.Forms.Label Perestanovki;
        private System.Windows.Forms.Button bPerest;
        private System.Windows.Forms.Label lPerest;
        private System.Windows.Forms.ListView listVShell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lShell;
    }
}

