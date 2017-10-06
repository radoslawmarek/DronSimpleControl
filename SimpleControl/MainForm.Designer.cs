namespace SimpleControl
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PortNumberTextBox = new System.Windows.Forms.TextBox();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IconUp = new System.Windows.Forms.PictureBox();
            this.IconStop = new System.Windows.Forms.PictureBox();
            this.IconDown = new System.Windows.Forms.PictureBox();
            this.IconLeft = new System.Windows.Forms.PictureBox();
            this.IconRight = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PortNumberTextBox);
            this.panel1.Controls.Add(this.IpAddressTextBox);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 73);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PortNumberTextBox
            // 
            this.PortNumberTextBox.Location = new System.Drawing.Point(175, 31);
            this.PortNumberTextBox.Name = "PortNumberTextBox";
            this.PortNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.PortNumberTextBox.TabIndex = 2;
            this.PortNumberTextBox.Text = "7777";
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(3, 31);
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(165, 26);
            this.IpAddressTextBox.TabIndex = 1;
            this.IpAddressTextBox.Text = "192.168.1.71";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(297, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(168, 54);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.IconUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.IconStop, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.IconDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IconLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IconRight, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 257);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // IconUp
            // 
            this.IconUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconUp.Location = new System.Drawing.Point(161, 3);
            this.IconUp.Name = "IconUp";
            this.IconUp.Size = new System.Drawing.Size(152, 79);
            this.IconUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconUp.TabIndex = 0;
            this.IconUp.TabStop = false;
            // 
            // IconStop
            // 
            this.IconStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconStop.Location = new System.Drawing.Point(161, 88);
            this.IconStop.Name = "IconStop";
            this.IconStop.Size = new System.Drawing.Size(152, 79);
            this.IconStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconStop.TabIndex = 1;
            this.IconStop.TabStop = false;
            // 
            // IconDown
            // 
            this.IconDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconDown.Location = new System.Drawing.Point(161, 173);
            this.IconDown.Name = "IconDown";
            this.IconDown.Size = new System.Drawing.Size(152, 81);
            this.IconDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconDown.TabIndex = 2;
            this.IconDown.TabStop = false;
            // 
            // IconLeft
            // 
            this.IconLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconLeft.Location = new System.Drawing.Point(3, 88);
            this.IconLeft.Name = "IconLeft";
            this.IconLeft.Size = new System.Drawing.Size(152, 79);
            this.IconLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconLeft.TabIndex = 3;
            this.IconLeft.TabStop = false;
            // 
            // IconRight
            // 
            this.IconRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconRight.Location = new System.Drawing.Point(319, 88);
            this.IconRight.Name = "IconRight";
            this.IconRight.Size = new System.Drawing.Size(154, 79);
            this.IconRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconRight.TabIndex = 4;
            this.IconRight.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dron Remote Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortNumberTextBox;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox IconUp;
        private System.Windows.Forms.PictureBox IconStop;
        private System.Windows.Forms.PictureBox IconDown;
        private System.Windows.Forms.PictureBox IconLeft;
        private System.Windows.Forms.PictureBox IconRight;
    }
}

