namespace Website_Editor
{
    partial class Form2
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
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_thumbnail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_shortdesc = new System.Windows.Forms.TextBox();
            this.textbox_srcLink = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_etc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_longdesc = new System.Windows.Forms.TextBox();
            this.textbox_images = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_name
            // 
            this.textbox_name.Location = new System.Drawing.Point(83, 13);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(188, 20);
            this.textbox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Created";
            // 
            // textbox_date
            // 
            this.textbox_date.Location = new System.Drawing.Point(83, 141);
            this.textbox_date.Name = "textbox_date";
            this.textbox_date.Size = new System.Drawing.Size(188, 20);
            this.textbox_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thumbnail Src";
            // 
            // textbox_thumbnail
            // 
            this.textbox_thumbnail.Location = new System.Drawing.Point(83, 167);
            this.textbox_thumbnail.Name = "textbox_thumbnail";
            this.textbox_thumbnail.Size = new System.Drawing.Size(188, 20);
            this.textbox_thumbnail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Short Desc";
            // 
            // textbox_shortdesc
            // 
            this.textbox_shortdesc.Location = new System.Drawing.Point(83, 39);
            this.textbox_shortdesc.Multiline = true;
            this.textbox_shortdesc.Name = "textbox_shortdesc";
            this.textbox_shortdesc.Size = new System.Drawing.Size(188, 96);
            this.textbox_shortdesc.TabIndex = 7;
            // 
            // textbox_srcLink
            // 
            this.textbox_srcLink.Location = new System.Drawing.Point(83, 193);
            this.textbox_srcLink.Name = "textbox_srcLink";
            this.textbox_srcLink.Size = new System.Drawing.Size(188, 20);
            this.textbox_srcLink.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Page Link";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_shortdesc);
            this.groupBox1.Controls.Add(this.textbox_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textbox_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textbox_thumbnail);
            this.groupBox1.Controls.Add(this.textbox_srcLink);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Page";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textbox_etc);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textbox_longdesc);
            this.groupBox2.Controls.Add(this.textbox_images);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textbox_type);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 328);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project Page";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Button";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textbox_etc
            // 
            this.textbox_etc.Location = new System.Drawing.Point(445, 22);
            this.textbox_etc.Multiline = true;
            this.textbox_etc.Name = "textbox_etc";
            this.textbox_etc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox_etc.Size = new System.Drawing.Size(415, 300);
            this.textbox_etc.TabIndex = 6;
            this.textbox_etc.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Etc Downloads";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // textbox_longdesc
            // 
            this.textbox_longdesc.Location = new System.Drawing.Point(83, 171);
            this.textbox_longdesc.Multiline = true;
            this.textbox_longdesc.Name = "textbox_longdesc";
            this.textbox_longdesc.Size = new System.Drawing.Size(263, 151);
            this.textbox_longdesc.TabIndex = 6;
            // 
            // textbox_images
            // 
            this.textbox_images.Location = new System.Drawing.Point(83, 45);
            this.textbox_images.Multiline = true;
            this.textbox_images.Name = "textbox_images";
            this.textbox_images.Size = new System.Drawing.Size(263, 117);
            this.textbox_images.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Long desc";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // textbox_type
            // 
            this.textbox_type.Location = new System.Drawing.Point(83, 19);
            this.textbox_type.Name = "textbox_type";
            this.textbox_type.Size = new System.Drawing.Size(263, 20);
            this.textbox_type.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Images";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Project Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textbox_thumbnail;
        public System.Windows.Forms.TextBox textbox_date;
        public System.Windows.Forms.TextBox textbox_name;
        public System.Windows.Forms.TextBox textbox_shortdesc;
        public System.Windows.Forms.TextBox textbox_srcLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_images;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_longdesc;
        private System.Windows.Forms.TextBox textbox_etc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}