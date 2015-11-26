namespace TicTacToe
{
    partial class TicTacToe_MainForm
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
            this.R1C1 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // R1C1
            // 
            this.R1C1.Location = new System.Drawing.Point(12, 12);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(65, 65);
            this.R1C1.TabIndex = 0;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R1C2
            // 
            this.R1C2.Location = new System.Drawing.Point(83, 12);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(65, 65);
            this.R1C2.TabIndex = 1;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R1C3
            // 
            this.R1C3.Location = new System.Drawing.Point(156, 12);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(65, 65);
            this.R1C3.TabIndex = 2;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R2C1
            // 
            this.R2C1.Location = new System.Drawing.Point(12, 86);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(65, 65);
            this.R2C1.TabIndex = 3;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R2C2
            // 
            this.R2C2.Location = new System.Drawing.Point(83, 86);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(65, 65);
            this.R2C2.TabIndex = 4;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R2C3
            // 
            this.R2C3.Location = new System.Drawing.Point(154, 86);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(67, 65);
            this.R2C3.TabIndex = 5;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R3C1
            // 
            this.R3C1.Location = new System.Drawing.Point(12, 157);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(65, 65);
            this.R3C1.TabIndex = 6;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R3C2
            // 
            this.R3C2.Location = new System.Drawing.Point(83, 157);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(65, 65);
            this.R3C2.TabIndex = 7;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.toggle_pos);
            // 
            // R3C3
            // 
            this.R3C3.Location = new System.Drawing.Point(154, 157);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(67, 65);
            this.R3C3.TabIndex = 8;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.toggle_pos);
            // 
            // TicTacToe_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 233);
            this.Controls.Add(this.R3C3);
            this.Controls.Add(this.R3C2);
            this.Controls.Add(this.R3C1);
            this.Controls.Add(this.R2C3);
            this.Controls.Add(this.R2C2);
            this.Controls.Add(this.R2C1);
            this.Controls.Add(this.R1C3);
            this.Controls.Add(this.R1C2);
            this.Controls.Add(this.R1C1);
            this.MaximizeBox = false;
            this.Name = "TicTacToe_MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button R1C1;
        private System.Windows.Forms.Button R1C2;
        private System.Windows.Forms.Button R1C3;
        private System.Windows.Forms.Button R2C1;
        private System.Windows.Forms.Button R2C2;
        private System.Windows.Forms.Button R2C3;
        private System.Windows.Forms.Button R3C1;
        private System.Windows.Forms.Button R3C2;
        private System.Windows.Forms.Button R3C3;
    }
}

