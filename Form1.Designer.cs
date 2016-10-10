namespace ChatClientApp
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
            this.client1 = new System.Windows.Forms.GroupBox();
            this.client2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.client1Ip = new System.Windows.Forms.Label();
            this.client1Port = new System.Windows.Forms.Label();
            this.client2Ip = new System.Windows.Forms.Label();
            this.client2Port = new System.Windows.Forms.Label();
            this.client1.SuspendLayout();
            this.client2.SuspendLayout();
            this.SuspendLayout();
            // 
            // client1
            // 
            this.client1.Controls.Add(this.client1Port);
            this.client1.Controls.Add(this.client1Ip);
            this.client1.Controls.Add(this.textBox2);
            this.client1.Controls.Add(this.textBox1);
            this.client1.Location = new System.Drawing.Point(6, 0);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(200, 100);
            this.client1.TabIndex = 0;
            this.client1.TabStop = false;
            this.client1.Text = "Client1";
            // 
            // client2
            // 
            this.client2.Controls.Add(this.client2Port);
            this.client2.Controls.Add(this.client2Ip);
            this.client2.Controls.Add(this.textBox4);
            this.client2.Controls.Add(this.textBox3);
            this.client2.Location = new System.Drawing.Point(212, 0);
            this.client2.Name = "client2";
            this.client2.Size = new System.Drawing.Size(200, 100);
            this.client2.TabIndex = 1;
            this.client2.TabStop = false;
            this.client2.Text = "Client2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(6, 216);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(325, 20);
            this.textMessage.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(6, 102);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(406, 108);
            this.listMessage.TabIndex = 3;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(418, 30);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(337, 216);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // client1Ip
            // 
            this.client1Ip.AutoSize = true;
            this.client1Ip.Location = new System.Drawing.Point(7, 30);
            this.client1Ip.Name = "client1Ip";
            this.client1Ip.Size = new System.Drawing.Size(17, 13);
            this.client1Ip.TabIndex = 2;
            this.client1Ip.Text = "IP";
            // 
            // client1Port
            // 
            this.client1Port.AutoSize = true;
            this.client1Port.Location = new System.Drawing.Point(7, 74);
            this.client1Port.Name = "client1Port";
            this.client1Port.Size = new System.Drawing.Size(26, 13);
            this.client1Port.TabIndex = 3;
            this.client1Port.Text = "Port";
            // 
            // client2Ip
            // 
            this.client2Ip.AutoSize = true;
            this.client2Ip.Location = new System.Drawing.Point(7, 30);
            this.client2Ip.Name = "client2Ip";
            this.client2Ip.Size = new System.Drawing.Size(17, 13);
            this.client2Ip.TabIndex = 2;
            this.client2Ip.Text = "IP";
            // 
            // client2Port
            // 
            this.client2Port.AutoSize = true;
            this.client2Port.Location = new System.Drawing.Point(7, 74);
            this.client2Port.Name = "client2Port";
            this.client2Port.Size = new System.Drawing.Size(26, 13);
            this.client2Port.TabIndex = 3;
            this.client2Port.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 249);
            this.Controls.Add(this.send);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.client2);
            this.Controls.Add(this.client1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.client1.ResumeLayout(false);
            this.client1.PerformLayout();
            this.client2.ResumeLayout(false);
            this.client2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox client1;
        private System.Windows.Forms.Label client1Port;
        private System.Windows.Forms.Label client1Ip;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox client2;
        private System.Windows.Forms.Label client2Port;
        private System.Windows.Forms.Label client2Ip;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button send;
    }
}

