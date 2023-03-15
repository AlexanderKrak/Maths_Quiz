
namespace Maths_Quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.label_symbol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left";
            // 
            // label_left
            // 
            this.label_left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_left.Location = new System.Drawing.Point(20, 1);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(50, 50);
            this.label_left.TabIndex = 2;
            this.label_left.Text = "?";
            this.label_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_right
            // 
            this.label_right.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_right.Location = new System.Drawing.Point(176, 1);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(50, 50);
            this.label_right.TabIndex = 4;
            this.label_right.Text = "?";
            this.label_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_symbol
            // 
            this.label_symbol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_symbol.Location = new System.Drawing.Point(99, 1);
            this.label_symbol.Name = "label_symbol";
            this.label_symbol.Size = new System.Drawing.Size(50, 50);
            this.label_symbol.TabIndex = 5;
            this.label_symbol.Text = "?";
            this.label_symbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(232, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 125);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_total);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label_left);
            this.panel2.Controls.Add(this.label_symbol);
            this.panel2.Controls.Add(this.label_right);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 51);
            this.panel2.TabIndex = 12;
            // 
            // label_total
            // 
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_total.Location = new System.Drawing.Point(309, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(50, 50);
            this.label_total.TabIndex = 7;
            this.label_total.Text = "?";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Press Q for +, W for - and E for x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_time.Location = new System.Drawing.Point(314, 27);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(41, 29);
            this.label_time.TabIndex = 12;
            this.label_time.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 353);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Quiz";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.Label label_symbol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
    }
}

