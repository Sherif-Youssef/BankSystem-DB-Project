﻿namespace DatabaseProject
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequested = new System.Windows.Forms.Label();
            this.txtPending = new System.Windows.Forms.Label();
            this.txtAccepted = new System.Windows.Forms.Label();
            this.txtRejected = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridStats = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(492, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 78);
            this.label1.TabIndex = 70;
            this.label1.Text = "Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 71;
            this.label2.Text = "Total Requested:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 600);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 72;
            this.label3.Text = "Total Rejected:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 73;
            this.label4.Text = "Total Accepted:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "Total Pending:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 655);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 31);
            this.label6.TabIndex = 75;
            this.label6.Text = "Total Paid:";
            // 
            // txtRequested
            // 
            this.txtRequested.AutoSize = true;
            this.txtRequested.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequested.ForeColor = System.Drawing.Color.White;
            this.txtRequested.Location = new System.Drawing.Point(226, 417);
            this.txtRequested.Name = "txtRequested";
            this.txtRequested.Size = new System.Drawing.Size(63, 31);
            this.txtRequested.TabIndex = 76;
            this.txtRequested.Text = "0.0$";
            this.txtRequested.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPending
            // 
            this.txtPending.AutoSize = true;
            this.txtPending.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPending.ForeColor = System.Drawing.Color.White;
            this.txtPending.Location = new System.Drawing.Point(226, 475);
            this.txtPending.Name = "txtPending";
            this.txtPending.Size = new System.Drawing.Size(63, 31);
            this.txtPending.TabIndex = 77;
            this.txtPending.Text = "0.0$";
            // 
            // txtAccepted
            // 
            this.txtAccepted.AutoSize = true;
            this.txtAccepted.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccepted.ForeColor = System.Drawing.Color.White;
            this.txtAccepted.Location = new System.Drawing.Point(226, 540);
            this.txtAccepted.Name = "txtAccepted";
            this.txtAccepted.Size = new System.Drawing.Size(63, 31);
            this.txtAccepted.TabIndex = 78;
            this.txtAccepted.Text = "0.0$";
            // 
            // txtRejected
            // 
            this.txtRejected.AutoSize = true;
            this.txtRejected.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRejected.ForeColor = System.Drawing.Color.White;
            this.txtRejected.Location = new System.Drawing.Point(226, 600);
            this.txtRejected.Name = "txtRejected";
            this.txtRejected.Size = new System.Drawing.Size(63, 31);
            this.txtRejected.TabIndex = 79;
            this.txtRejected.Text = "0.0$";
            // 
            // txtPaid
            // 
            this.txtPaid.AutoSize = true;
            this.txtPaid.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.ForeColor = System.Drawing.Color.White;
            this.txtPaid.Location = new System.Drawing.Point(226, 655);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(63, 31);
            this.txtPaid.TabIndex = 80;
            this.txtPaid.Text = "0.0$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(64, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 50);
            this.label12.TabIndex = 81;
            this.label12.Text = "Loan Stats";
            // 
            // dataGridStats
            // 
            this.dataGridStats.AllowUserToAddRows = false;
            this.dataGridStats.AllowUserToDeleteRows = false;
            this.dataGridStats.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStats.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridStats.Location = new System.Drawing.Point(404, 270);
            this.dataGridStats.Name = "dataGridStats";
            this.dataGridStats.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStats.RowHeadersWidth = 51;
            this.dataGridStats.RowTemplate.Height = 24;
            this.dataGridStats.Size = new System.Drawing.Size(472, 279);
            this.dataGridStats.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 48);
            this.button1.TabIndex = 83;
            this.button1.Text = "Most Popular Banks";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(404, 633);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(472, 48);
            this.button4.TabIndex = 86;
            this.button4.Text = "Most Recent Loan Requests ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(646, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 48);
            this.button2.TabIndex = 87;
            this.button2.Text = "Most Borrowing Cities";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DatabaseProject.Properties.Resources.stats;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(293, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 136);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DatabaseProject.Properties.Resources.cipher;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 109);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(925, 733);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridStats);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtRejected);
            this.Controls.Add(this.txtAccepted);
            this.Controls.Add(this.txtPending);
            this.Controls.Add(this.txtRequested);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtRequested;
        private System.Windows.Forms.Label txtPending;
        private System.Windows.Forms.Label txtAccepted;
        private System.Windows.Forms.Label txtRejected;
        private System.Windows.Forms.Label txtPaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}