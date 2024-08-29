
namespace libraryApp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reader = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 22);
            this.textBox2.TabIndex = 4;
            // 
            // reader
            // 
            this.reader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.reader.Location = new System.Drawing.Point(250, 489);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(174, 52);
            this.reader.TabIndex = 19;
            this.reader.Text = "Sign in as Reader";
            this.reader.UseVisualStyleBackColor = false;
            this.reader.Click += new System.EventHandler(this.reader_Click);
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.student.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.student.Location = new System.Drawing.Point(248, 400);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(176, 52);
            this.student.TabIndex = 18;
            this.student.Text = "Sign in as Student";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.author.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.author.Location = new System.Drawing.Point(21, 400);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(181, 52);
            this.author.TabIndex = 17;
            this.author.Text = "Sign in as Author";
            this.author.UseVisualStyleBackColor = false;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin.Location = new System.Drawing.Point(21, 489);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(181, 52);
            this.admin.TabIndex = 16;
            this.admin.Text = "Sign in as Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(709, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.student);
            this.Controls.Add(this.author);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button reader;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button button1;
    }
}