namespace DesktopCLient
{
    partial class Kisokos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.addContactName = new System.Windows.Forms.TextBox();
            this.addContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteContact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete contact";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 20);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show all contact";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(66, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(41, 176);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 4;
            // 
            // addContactName
            // 
            this.addContactName.Location = new System.Drawing.Point(105, 30);
            this.addContactName.MaxLength = 20;
            this.addContactName.Name = "addContactName";
            this.addContactName.Size = new System.Drawing.Size(100, 20);
            this.addContactName.TabIndex = 5;
            // 
            // addContactNumber
            // 
            this.addContactNumber.Location = new System.Drawing.Point(327, 30);
            this.addContactNumber.MaxLength = 15;
            this.addContactNumber.Name = "addContactNumber";
            this.addContactNumber.Size = new System.Drawing.Size(100, 20);
            this.addContactNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contact name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact name";
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(327, 71);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(100, 20);
            this.deleteContact.TabIndex = 10;
            // 
            // Kisokos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 218);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addContactNumber);
            this.Controls.Add(this.addContactName);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Kisokos";
            this.Text = "Kisokos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox addContactName;
        private System.Windows.Forms.TextBox addContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteContact;
    }
}