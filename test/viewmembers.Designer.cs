
namespace test
{
    partial class viewmembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGridView = new System.Windows.Forms.DataGridView();
            this.searchview = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.RichTextBox();
            this.backview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clears = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewGridView)).BeginInit();
            this.SuspendLayout();
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
            this.closeAdd.TabIndex = 12;
            this.closeAdd.Text = "X";
            this.closeAdd.Click += new System.EventHandler(this.closeAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(441, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "List Members";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(408, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "GOOD FITNESS";
            // 
            // viewGridView
            // 
            this.viewGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            this.viewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGridView.Location = new System.Drawing.Point(108, 167);
            this.viewGridView.Name = "viewGridView";
            this.viewGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGridView.Size = new System.Drawing.Size(847, 326);
            this.viewGridView.TabIndex = 27;
            this.viewGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGridView_CellContentClick);
            // 
            // searchview
            // 
            this.searchview.BackColor = System.Drawing.Color.Crimson;
            this.searchview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchview.Location = new System.Drawing.Point(761, 124);
            this.searchview.Name = "searchview";
            this.searchview.Size = new System.Drawing.Size(89, 32);
            this.searchview.TabIndex = 29;
            this.searchview.Text = "Search";
            this.searchview.UseVisualStyleBackColor = false;
            this.searchview.Click += new System.EventHandler(this.searchview_Click);
            // 
            // search
            // 
            this.search.BulletIndent = 10;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(562, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(198, 31);
            this.search.TabIndex = 28;
            this.search.Text = "";
            // 
            // backview
            // 
            this.backview.BackColor = System.Drawing.Color.Crimson;
            this.backview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backview.Location = new System.Drawing.Point(108, 66);
            this.backview.Name = "backview";
            this.backview.Size = new System.Drawing.Size(104, 32);
            this.backview.TabIndex = 30;
            this.backview.Text = "Back";
            this.backview.UseVisualStyleBackColor = false;
            this.backview.Click += new System.EventHandler(this.backview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 14.75F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(105, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the member ID or phone number for searching\r\n";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // clears
            // 
            this.clears.BackColor = System.Drawing.Color.Crimson;
            this.clears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clears.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clears.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clears.Location = new System.Drawing.Point(853, 124);
            this.clears.Name = "clears";
            this.clears.Size = new System.Drawing.Size(104, 32);
            this.clears.TabIndex = 31;
            this.clears.Text = "Refresh";
            this.clears.UseVisualStyleBackColor = false;
            this.clears.Click += new System.EventHandler(this.clears_Click);
            // 
            // viewmembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 528);
            this.Controls.Add(this.clears);
            this.Controls.Add(this.backview);
            this.Controls.Add(this.searchview);
            this.Controls.Add(this.search);
            this.Controls.Add(this.viewGridView);
            this.Controls.Add(this.closeAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewmembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewmembers";
            this.Load += new System.EventHandler(this.viewmembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewGridView;
        private System.Windows.Forms.Button searchview;
        private System.Windows.Forms.RichTextBox search;
        private System.Windows.Forms.Button backview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clears;
    }
}