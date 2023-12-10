
namespace SwimmingSchedule
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelClassDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelSchoolFees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonIndication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(82, 22);
            this.numericUpDownYear.TabIndex = 0;
            this.numericUpDownYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(140, 12);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(82, 22);
            this.numericUpDownMonth.TabIndex = 1;
            this.numericUpDownMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "授業日　　：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "開始時間 ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "授業料　　：";
            // 
            // labelClassDay
            // 
            this.labelClassDay.AutoSize = true;
            this.labelClassDay.Location = new System.Drawing.Point(98, 60);
            this.labelClassDay.Name = "labelClassDay";
            this.labelClassDay.Size = new System.Drawing.Size(30, 15);
            this.labelClassDay.TabIndex = 5;
            this.labelClassDay.Text = "7日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 6;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(99, 101);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(38, 15);
            this.labelStartTime.TabIndex = 11;
            this.labelStartTime.Text = "10時";
            // 
            // labelSchoolFees
            // 
            this.labelSchoolFees.AutoSize = true;
            this.labelSchoolFees.Location = new System.Drawing.Point(99, 144);
            this.labelSchoolFees.Name = "labelSchoolFees";
            this.labelSchoolFees.Size = new System.Drawing.Size(54, 15);
            this.labelSchoolFees.TabIndex = 12;
            this.labelSchoolFees.Text = "4500円";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 14;
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 15;
            this.listBoxCourse.Items.AddRange(new object[] {
            "ベビーコース",
            "幼児コース",
            "小学生コース",
            "中学生コース",
            "レディコース",
            "一般コース",
            "家族コース"});
            this.listBoxCourse.Location = new System.Drawing.Point(266, 12);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(115, 109);
            this.listBoxCourse.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "年";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "月";
            // 
            // buttonIndication
            // 
            this.buttonIndication.Location = new System.Drawing.Point(12, 174);
            this.buttonIndication.Name = "buttonIndication";
            this.buttonIndication.Size = new System.Drawing.Size(369, 30);
            this.buttonIndication.TabIndex = 20;
            this.buttonIndication.Text = "表示";
            this.buttonIndication.UseVisualStyleBackColor = true;
            this.buttonIndication.Click += new System.EventHandler(this.buttonIndication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 216);
            this.Controls.Add(this.buttonIndication);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelSchoolFees);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelClassDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Name = "Form1";
            this.Text = "CSスイミングスクール";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClassDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelSchoolFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonIndication;
    }
}

