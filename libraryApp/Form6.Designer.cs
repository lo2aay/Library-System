﻿namespace libraryApp
{
    partial class Form6
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
            this.bkid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buyname = new System.Windows.Forms.TextBox();
            this.buy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdrid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bkid
            // 
            this.bkid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bkid.Location = new System.Drawing.Point(698, 517);
            this.bkid.Name = "bkid";
            this.bkid.Size = new System.Drawing.Size(263, 28);
            this.bkid.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(534, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 133;
            this.label4.Text = "Book ID : ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1027, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 132;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1040, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 48);
            this.button2.TabIndex = 131;
            this.button2.Text = "log out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(621, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 34);
            this.button1.TabIndex = 130;
            this.button1.Text = "Add comment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comment.Location = new System.Drawing.Point(698, 467);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(263, 28);
            this.comment.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(534, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 128;
            this.label2.Text = "Comment :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(57, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 34);
            this.label9.TabIndex = 127;
            this.label9.Text = "Available books :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 392);
            this.dataGridView1.TabIndex = 126;
            // 
            // buyname
            // 
            this.buyname.Font = new System.Drawing.Font("Tahoma", 10F);
            this.buyname.Location = new System.Drawing.Point(253, 538);
            this.buyname.Name = "buyname";
            this.buyname.Size = new System.Drawing.Size(196, 28);
            this.buyname.TabIndex = 123;
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buy.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buy.Location = new System.Drawing.Point(170, 603);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(121, 40);
            this.buy.TabIndex = 122;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(58, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 121;
            this.label6.Text = "Book  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 120;
            this.label1.Text = "Buy Book";
            // 
            // rdrid
            // 
            this.rdrid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rdrid.Location = new System.Drawing.Point(698, 568);
            this.rdrid.Name = "rdrid";
            this.rdrid.Size = new System.Drawing.Size(263, 28);
            this.rdrid.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(534, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 135;
            this.label5.Text = "Reader ID : ";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1199, 724);
            this.Controls.Add(this.rdrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bkid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buyname);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bkid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox buyname;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rdrid;
        private System.Windows.Forms.Label label5;
    }
}