
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
            this.label_timer = new System.Windows.Forms.Label();
            this.label_left = new System.Windows.Forms.Label();
            this.label_right = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_startGame = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // label_timer
            // 
            this.label_timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_timer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_timer.Location = new System.Drawing.Point(278, 16);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(167, 44);
            this.label_timer.TabIndex = 1;
            this.label_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_left
            // 
            this.label_left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_left.Location = new System.Drawing.Point(24, 90);
            this.label_left.Name = "label_left";
            this.label_left.Size = new System.Drawing.Size(50, 50);
            this.label_left.TabIndex = 2;
            this.label_left.Text = "?";
            this.label_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_right
            // 
            this.label_right.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_right.Location = new System.Drawing.Point(188, 90);
            this.label_right.Name = "label_right";
            this.label_right.Size = new System.Drawing.Size(50, 50);
            this.label_right.TabIndex = 4;
            this.label_right.Text = "?";
            this.label_right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(266, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(345, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 50);
            this.label6.TabIndex = 7;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_startGame
            // 
            this.button_startGame.Location = new System.Drawing.Point(114, 296);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(284, 29);
            this.button_startGame.TabIndex = 8;
            this.button_startGame.Text = "I wanna play a game";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 353);
            this.Controls.Add(this.button_startGame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_right);
            this.Controls.Add(this.label_left);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Quiz";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_left;
        private System.Windows.Forms.Label label_right;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Timer timer;
    }
}

