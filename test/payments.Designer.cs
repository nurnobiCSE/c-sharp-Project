
namespace test
{
    partial class payments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeAdd = new System.Windows.Forms.Label();
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.backpay = new System.Windows.Forms.Button();
            this.resetpay = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.payphone = new System.Windows.Forms.RichTextBox();
            this.payname = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaydateTime = new System.Windows.Forms.DateTimePicker();
            this.paymentuserPhoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.payammount = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentuserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(485, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(432, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "GOOD FITNESS";
            // 
            // closeAdd
            // 
            this.closeAdd.AutoSize = true;
            this.closeAdd.BackColor = System.Drawing.Color.Transparent;
            this.closeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeAdd.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAdd.ForeColor = System.Drawing.Color.Crimson;
            this.closeAdd.Location = new System.Drawing.Point(1032, 9);
            this.closeAdd.Name = "closeAdd";
            this.closeAdd.Size = new System.Drawing.Size(35, 33);
            this.closeAdd.TabIndex = 14;
            this.closeAdd.Text = "X";
            this.closeAdd.Click += new System.EventHandler(this.closeAdd_Click);
            // 
            // paymentGridView
            // 
            this.paymentGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.paymentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Location = new System.Drawing.Point(322, 174);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.Size = new System.Drawing.Size(547, 240);
            this.paymentGridView.TabIndex = 34;
            this.paymentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentGridView_CellContentClick);
            // 
            // backpay
            // 
            this.backpay.BackColor = System.Drawing.Color.Crimson;
            this.backpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backpay.Location = new System.Drawing.Point(208, 381);
            this.backpay.Name = "backpay";
            this.backpay.Size = new System.Drawing.Size(79, 38);
            this.backpay.TabIndex = 33;
            this.backpay.Text = "Back";
            this.backpay.UseVisualStyleBackColor = false;
            this.backpay.Click += new System.EventHandler(this.backpay_Click);
            // 
            // resetpay
            // 
            this.resetpay.BackColor = System.Drawing.Color.Crimson;
            this.resetpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetpay.Location = new System.Drawing.Point(108, 381);
            this.resetpay.Name = "resetpay";
            this.resetpay.Size = new System.Drawing.Size(93, 38);
            this.resetpay.TabIndex = 32;
            this.resetpay.Text = "Reset";
            this.resetpay.UseVisualStyleBackColor = false;
            this.resetpay.Click += new System.EventHandler(this.resetpay_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.Crimson;
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pay.Location = new System.Drawing.Point(31, 381);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(71, 38);
            this.pay.TabIndex = 31;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // payphone
            // 
            this.payphone.BulletIndent = 10;
            this.payphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payphone.Location = new System.Drawing.Point(29, 268);
            this.payphone.Name = "payphone";
            this.payphone.Size = new System.Drawing.Size(256, 31);
            this.payphone.TabIndex = 30;
            this.payphone.Text = "";
            // 
            // payname
            // 
            this.payname.BulletIndent = 10;
            this.payname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payname.Location = new System.Drawing.Point(29, 198);
            this.payname.Name = "payname";
            this.payname.Size = new System.Drawing.Size(256, 31);
            this.payname.TabIndex = 29;
            this.payname.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(25, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Member Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(25, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Member Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(25, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Payment Date";
            // 
            // PaydateTime
            // 
            this.PaydateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaydateTime.Location = new System.Drawing.Point(29, 130);
            this.PaydateTime.Name = "PaydateTime";
            this.PaydateTime.Size = new System.Drawing.Size(256, 26);
            this.PaydateTime.TabIndex = 35;
            // 
            // paymentuserPhoto
            // 
            this.paymentuserPhoto.Image = global::test.Properties.Resources.images;
            this.paymentuserPhoto.Location = new System.Drawing.Point(785, 92);
            this.paymentuserPhoto.Name = "paymentuserPhoto";
            this.paymentuserPhoto.Size = new System.Drawing.Size(84, 76);
            this.paymentuserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentuserPhoto.TabIndex = 36;
            this.paymentuserPhoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(27, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ammount";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // payammount
            // 
            this.payammount.BulletIndent = 10;
            this.payammount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payammount.Location = new System.Drawing.Point(31, 337);
            this.payammount.Name = "payammount";
            this.payammount.Size = new System.Drawing.Size(254, 31);
            this.payammount.TabIndex = 30;
            this.payammount.Text = "";
            // 
            // payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 528);
            this.Controls.Add(this.paymentuserPhoto);
            this.Controls.Add(this.PaydateTime);
            this.Controls.Add(this.paymentGridView);
            this.Controls.Add(this.backpay);
            this.Controls.Add(this.resetpay);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.payammount);
            this.Controls.Add(this.payphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payments";
            this.Load += new System.EventHandler(this.payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentuserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeAdd;
        private System.Windows.Forms.DataGridView paymentGridView;
        private System.Windows.Forms.Button backpay;
        private System.Windows.Forms.Button resetpay;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.RichTextBox payphone;
        private System.Windows.Forms.RichTextBox payname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PaydateTime;
        private System.Windows.Forms.PictureBox paymentuserPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox payammount;
    }
}