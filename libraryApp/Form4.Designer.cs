using System.Data;
using System.Data.SqlClient;
namespace libraryApp
{
    partial class Form4
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
            this.price = new System.Windows.Forms.TextBox();
            this.quan = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.authid = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Tahoma", 10F);
            this.price.Location = new System.Drawing.Point(141, 237);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(196, 28);
            this.price.TabIndex = 46;
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.quan.Location = new System.Drawing.Point(590, 167);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(196, 28);
            this.quan.TabIndex = 45;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Tahoma", 10F);
            this.year.Location = new System.Drawing.Point(590, 236);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(196, 28);
            this.year.TabIndex = 44;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Tahoma", 10F);
            this.title.Location = new System.Drawing.Point(141, 163);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 28);
            this.title.TabIndex = 43;
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.admin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin.Location = new System.Drawing.Point(51, 481);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(170, 61);
            this.admin.TabIndex = 39;
            this.admin.Text = "Upload ";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(7, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 34);
            this.label9.TabIndex = 36;
            this.label9.Text = "Book INFO.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(451, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantity : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(451, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Year  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Title : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 49);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add Book";
            // 
            // bookid
            // 
            this.bookid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bookid.Location = new System.Drawing.Point(200, 303);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(137, 28);
            this.bookid.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Book ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(442, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Category : ";
            // 
            // cat
            // 
            this.cat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cat.Location = new System.Drawing.Point(590, 299);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(196, 28);
            this.cat.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(46, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 51;
            this.label8.Text = "Author ID : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // authid
            // 
            this.authid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.authid.Location = new System.Drawing.Point(200, 364);
            this.authid.Name = "authid";
            this.authid.Size = new System.Drawing.Size(137, 28);
            this.authid.TabIndex = 52;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Location = new System.Drawing.Point(910, 481);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(153, 61);
            this.logout.TabIndex = 53;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1077, 554);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.authid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.year);
            this.Controls.Add(this.title);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quan;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox authid;
        private System.Windows.Forms.Button logout;
    }
}