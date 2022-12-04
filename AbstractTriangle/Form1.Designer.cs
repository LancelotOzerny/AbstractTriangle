namespace AbstractTriangle
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
            this.comboBox_triangleType = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_aSide = new System.Windows.Forms.TextBox();
            this.input_bSide = new System.Windows.Forms.TextBox();
            this.input_cSide = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input_angle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_perimetrResult = new System.Windows.Forms.Label();
            this.label_areaResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_triangleType
            // 
            this.comboBox_triangleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_triangleType.Items.AddRange(new object[] {
            "Прямоугольный",
            "Равнобедренный",
            "Равносторонний"});
            this.comboBox_triangleType.Location = new System.Drawing.Point(12, 49);
            this.comboBox_triangleType.Name = "comboBox_triangleType";
            this.comboBox_triangleType.Size = new System.Drawing.Size(600, 32);
            this.comboBox_triangleType.TabIndex = 0;
            this.comboBox_triangleType.SelectedIndexChanged += new System.EventHandler(this.comboBox_triangleType_SelectedIndexChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 438);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(600, 45);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Рассчитать";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Стороны треугольника";
            // 
            // input_aSide
            // 
            this.input_aSide.Location = new System.Drawing.Point(130, 147);
            this.input_aSide.Name = "input_aSide";
            this.input_aSide.Size = new System.Drawing.Size(100, 29);
            this.input_aSide.TabIndex = 3;
            this.input_aSide.Text = "0";
            this.input_aSide.TextChanged += new System.EventHandler(this.CheckIsoscelesSides);
            this.input_aSide.TextChanged += new System.EventHandler(this.CheckEqualSides);
            // 
            // input_bSide
            // 
            this.input_bSide.Location = new System.Drawing.Point(130, 182);
            this.input_bSide.Name = "input_bSide";
            this.input_bSide.Size = new System.Drawing.Size(100, 29);
            this.input_bSide.TabIndex = 3;
            this.input_bSide.Text = "0";
            this.input_bSide.TextChanged += new System.EventHandler(this.CheckIsoscelesSides);
            this.input_bSide.TextChanged += new System.EventHandler(this.CheckEqualSides);
            // 
            // input_cSide
            // 
            this.input_cSide.Location = new System.Drawing.Point(130, 217);
            this.input_cSide.Name = "input_cSide";
            this.input_cSide.Size = new System.Drawing.Size(100, 29);
            this.input_cSide.TabIndex = 3;
            this.input_cSide.Text = "0";
            this.input_cSide.TextChanged += new System.EventHandler(this.CheckEqualSides);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип треугольника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Угол AB треугольника";
            // 
            // input_angle
            // 
            this.input_angle.Location = new System.Drawing.Point(500, 147);
            this.input_angle.Name = "input_angle";
            this.input_angle.Size = new System.Drawing.Size(100, 29);
            this.input_angle.TabIndex = 3;
            this.input_angle.Text = "0";
            this.input_angle.TextChanged += new System.EventHandler(this.input_angle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "AB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Площадь треугольника:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Периметр треугольника:";
            // 
            // label_perimetrResult
            // 
            this.label_perimetrResult.AutoSize = true;
            this.label_perimetrResult.Location = new System.Drawing.Point(252, 318);
            this.label_perimetrResult.Name = "label_perimetrResult";
            this.label_perimetrResult.Size = new System.Drawing.Size(20, 24);
            this.label_perimetrResult.TabIndex = 2;
            this.label_perimetrResult.Text = "0";
            // 
            // label_areaResult
            // 
            this.label_areaResult.AutoSize = true;
            this.label_areaResult.Location = new System.Drawing.Point(252, 363);
            this.label_areaResult.Name = "label_areaResult";
            this.label_areaResult.Size = new System.Drawing.Size(20, 24);
            this.label_areaResult.TabIndex = 2;
            this.label_areaResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 495);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_cSide);
            this.Controls.Add(this.input_bSide);
            this.Controls.Add(this.input_angle);
            this.Controls.Add(this.input_aSide);
            this.Controls.Add(this.label_areaResult);
            this.Controls.Add(this.label_perimetrResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.comboBox_triangleType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_triangleType;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_aSide;
        private System.Windows.Forms.TextBox input_bSide;
        private System.Windows.Forms.TextBox input_cSide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_angle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_perimetrResult;
        private System.Windows.Forms.Label label_areaResult;
    }
}

