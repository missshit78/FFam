namespace WindowsFormsApp1
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
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.dateOpenDate = new System.Windows.Forms.Label();
            this.lblFormVersionVal = new System.Windows.Forms.Label();
            this.btnFormClose = new System.Windows.Forms.Button();
            this.tabTask2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblFormVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabTask2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenDate.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOpenDate.Image = global::WindowsFormsApp1.Properties.Resources.Title_logo;
            this.lblOpenDate.Location = new System.Drawing.Point(13, 43);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(99, 25);
            this.lblOpenDate.TabIndex = 0;
            this.lblOpenDate.Text = "現在日時 :";
            // 
            // dateOpenDate
            // 
            this.dateOpenDate.AutoSize = true;
            this.dateOpenDate.BackColor = System.Drawing.Color.Transparent;
            this.dateOpenDate.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateOpenDate.Image = global::WindowsFormsApp1.Properties.Resources.Title_logo;
            this.dateOpenDate.Location = new System.Drawing.Point(113, 43);
            this.dateOpenDate.Name = "dateOpenDate";
            this.dateOpenDate.Size = new System.Drawing.Size(229, 25);
            this.dateOpenDate.TabIndex = 2;
            this.dateOpenDate.Text = "yyyy/ＭＭ/dd hh:mm:ss";
            // 
            // lblFormVersionVal
            // 
            this.lblFormVersionVal.AutoSize = true;
            this.lblFormVersionVal.BackColor = System.Drawing.Color.Transparent;
            this.lblFormVersionVal.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFormVersionVal.Image = global::WindowsFormsApp1.Properties.Resources.Title_logo;
            this.lblFormVersionVal.Location = new System.Drawing.Point(113, 9);
            this.lblFormVersionVal.Name = "lblFormVersionVal";
            this.lblFormVersionVal.Size = new System.Drawing.Size(55, 25);
            this.lblFormVersionVal.TabIndex = 3;
            this.lblFormVersionVal.Text = "0.0.1";
            // 
            // btnFormClose
            // 
            this.btnFormClose.Font = new System.Drawing.Font("游ゴシック", 9F);
            this.btnFormClose.Location = new System.Drawing.Point(713, 415);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(75, 23);
            this.btnFormClose.TabIndex = 4;
            this.btnFormClose.Text = "終了";
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // tabTask2
            // 
            this.tabTask2.Controls.Add(this.tabPage1);
            this.tabTask2.Controls.Add(this.tabPage2);
            this.tabTask2.Location = new System.Drawing.Point(18, 247);
            this.tabTask2.Name = "tabTask2";
            this.tabTask2.SelectedIndex = 0;
            this.tabTask2.Size = new System.Drawing.Size(770, 152);
            this.tabTask2.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "mtys/C";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "missshit78/Ffam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(96, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(666, 208);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(585, 94);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // lblFormVersion
            // 
            this.lblFormVersion.AutoSize = true;
            this.lblFormVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblFormVersion.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFormVersion.Image = global::WindowsFormsApp1.Properties.Resources.Title_logo;
            this.lblFormVersion.Location = new System.Drawing.Point(13, 9);
            this.lblFormVersion.Name = "lblFormVersion";
            this.lblFormVersion.Size = new System.Drawing.Size(98, 25);
            this.lblFormVersion.TabIndex = 1;
            this.lblFormVersion.Text = "Ver          :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Title_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tabTask2);
            this.Controls.Add(this.btnFormClose);
            this.Controls.Add(this.lblFormVersionVal);
            this.Controls.Add(this.dateOpenDate);
            this.Controls.Add(this.lblFormVersion);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "C#フォームアプリケーションテスト";
            this.tabTask2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblFormVersion;
        private System.Windows.Forms.Label dateOpenDate;
        private System.Windows.Forms.Label lblFormVersionVal;
        private System.Windows.Forms.Button btnFormClose;
        private System.Windows.Forms.TabControl tabTask2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

