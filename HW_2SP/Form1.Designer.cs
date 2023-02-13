namespace HW_2SP
{
    partial class Form1
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
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.lb_2 = new System.Windows.Forms.ListBox();
            this.l_1 = new System.Windows.Forms.Label();
            this.l_2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.FormattingEnabled = true;
            this.lb_1.ItemHeight = 16;
            this.lb_1.Location = new System.Drawing.Point(0, 63);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(245, 324);
            this.lb_1.TabIndex = 0;
            // 
            // lb_2
            // 
            this.lb_2.FormattingEnabled = true;
            this.lb_2.ItemHeight = 16;
            this.lb_2.Location = new System.Drawing.Point(370, 63);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(240, 324);
            this.lb_2.TabIndex = 1;
            // 
            // l_1
            // 
            this.l_1.AutoSize = true;
            this.l_1.Location = new System.Drawing.Point(13, 41);
            this.l_1.Name = "l_1";
            this.l_1.Size = new System.Drawing.Size(128, 16);
            this.l_1.TabIndex = 2;
            this.l_1.Text = "Доступные сборки";
            // 
            // l_2
            // 
            this.l_2.AutoSize = true;
            this.l_2.Location = new System.Drawing.Point(367, 41);
            this.l_2.Name = "l_2";
            this.l_2.Size = new System.Drawing.Size(106, 16);
            this.l_2.TabIndex = 3;
            this.l_2.Text = "Начаты сборки";
            this.l_2.Click += new System.EventHandler(this.l_2_Click);
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(267, 89);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(267, 133);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(267, 179);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Enabled = false;
            this.btn_refresh.Location = new System.Drawing.Point(267, 229);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Enabled = false;
            this.btn_run.Location = new System.Drawing.Point(267, 281);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 8;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 411);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.l_2);
            this.Controls.Add(this.l_1);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_1;
        private System.Windows.Forms.ListBox lb_2;
        private System.Windows.Forms.Label l_1;
        private System.Windows.Forms.Label l_2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_run;
    }
}

