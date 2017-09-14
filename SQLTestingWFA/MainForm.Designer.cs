namespace SQLTestingWFA
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
            this.SQLConnDisconn = new System.Windows.Forms.Button();
            this.ConnStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentDatabase = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrentTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLConnDisconn
            // 
            this.SQLConnDisconn.Location = new System.Drawing.Point(12, 12);
            this.SQLConnDisconn.Name = "SQLConnDisconn";
            this.SQLConnDisconn.Size = new System.Drawing.Size(76, 33);
            this.SQLConnDisconn.TabIndex = 0;
            this.SQLConnDisconn.Text = "Connect";
            this.SQLConnDisconn.UseVisualStyleBackColor = true;
            this.SQLConnDisconn.Click += new System.EventHandler(this.SQLConnDisconn_Click);
            // 
            // ConnStatus
            // 
            this.ConnStatus.AutoSize = true;
            this.ConnStatus.Location = new System.Drawing.Point(200, 22);
            this.ConnStatus.Name = "ConnStatus";
            this.ConnStatus.Size = new System.Drawing.Size(73, 13);
            this.ConnStatus.TabIndex = 1;
            this.ConnStatus.Text = "Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database:";
            // 
            // CurrentDatabase
            // 
            this.CurrentDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentDatabase.FormattingEnabled = true;
            this.CurrentDatabase.Location = new System.Drawing.Point(411, 19);
            this.CurrentDatabase.Name = "CurrentDatabase";
            this.CurrentDatabase.Size = new System.Drawing.Size(179, 21);
            this.CurrentDatabase.TabIndex = 4;
            this.CurrentDatabase.SelectionChangeCommitted += new System.EventHandler(this.CurrentDatabase_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 198);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CurrentTable
            // 
            this.CurrentTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentTable.FormattingEnabled = true;
            this.CurrentTable.Location = new System.Drawing.Point(658, 19);
            this.CurrentTable.Name = "CurrentTable";
            this.CurrentTable.Size = new System.Drawing.Size(179, 21);
            this.CurrentTable.TabIndex = 7;
            this.CurrentTable.SelectionChangeCommitted += new System.EventHandler(this.CurrentTable_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Table:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.CurrentTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CurrentDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnStatus);
            this.Controls.Add(this.SQLConnDisconn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SQL Server Toybox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SQLConnDisconn;
        private System.Windows.Forms.Label ConnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CurrentDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CurrentTable;
        private System.Windows.Forms.Label label3;
    }
}

