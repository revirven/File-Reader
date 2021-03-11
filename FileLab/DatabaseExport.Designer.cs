
namespace FileLab
{
    partial class DatabaseExport
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
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ExportToExcel = new System.Windows.Forms.Button();
            this.btn_ConnectionClose = new System.Windows.Forms.Button();
            this.ExcelSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(12, 12);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(706, 141);
            this.QueryTextBox.TabIndex = 1;
            this.QueryTextBox.TextChanged += new System.EventHandler(this.QueryTextBox_TextChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(761, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(136, 141);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 183);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(885, 350);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ExportToExcel
            // 
            this.ExportToExcel.Location = new System.Drawing.Point(688, 551);
            this.ExportToExcel.Name = "ExportToExcel";
            this.ExportToExcel.Size = new System.Drawing.Size(209, 45);
            this.ExportToExcel.TabIndex = 4;
            this.ExportToExcel.Text = "Export to Excel";
            this.ExportToExcel.UseVisualStyleBackColor = true;
            this.ExportToExcel.Click += new System.EventHandler(this.ExportToExcel_Click);
            // 
            // btn_ConnectionClose
            // 
            this.btn_ConnectionClose.Location = new System.Drawing.Point(12, 551);
            this.btn_ConnectionClose.Name = "btn_ConnectionClose";
            this.btn_ConnectionClose.Size = new System.Drawing.Size(158, 45);
            this.btn_ConnectionClose.TabIndex = 5;
            this.btn_ConnectionClose.Text = "Close connection";
            this.btn_ConnectionClose.UseVisualStyleBackColor = true;
            this.btn_ConnectionClose.Click += new System.EventHandler(this.btn_ConnectionClose_Click);
            // 
            // ExcelSave
            // 
            this.ExcelSave.FileOk += new System.ComponentModel.CancelEventHandler(this.ExcelSave_FileOk);
            // 
            // DatabaseExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 608);
            this.Controls.Add(this.btn_ConnectionClose);
            this.Controls.Add(this.ExportToExcel);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.QueryTextBox);
            this.Name = "DatabaseExport";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.DatabaseExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ExportToExcel;
        private System.Windows.Forms.Button btn_ConnectionClose;
        private System.Windows.Forms.SaveFileDialog ExcelSave;
    }
}