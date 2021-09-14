
namespace signature_card_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cellphone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome completo";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(449, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(339, 23);
            this.name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo";
            // 
            // jobTitle
            // 
            this.jobTitle.Location = new System.Drawing.Point(449, 131);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(339, 23);
            this.jobTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departamento";
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(449, 208);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(339, 23);
            this.department.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 0;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(449, 281);
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Size = new System.Drawing.Size(339, 23);
            this.phone.TabIndex = 8;
            this.phone.Text = "+55 (31) 2531-0961";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone - Geonew";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone celular";
            // 
            // cellphone
            // 
            this.cellphone.Location = new System.Drawing.Point(449, 353);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(339, 23);
            this.cellphone.TabIndex = 10;
            this.cellphone.Text = "+55 (XX) XXXX-XXXX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 206);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gerar assinatura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cellphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Gerador de Assinatures - Geonew";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cellphone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

