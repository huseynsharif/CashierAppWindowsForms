namespace CashierApp3
{
    partial class History
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
            dgv_history = new DataGridView();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            btn_filter = new Button();
            btn_export = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_history).BeginInit();
            SuspendLayout();
            // 
            // dgv_history
            // 
            dgv_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_history.Location = new Point(141, 123);
            dgv_history.Name = "dgv_history";
            dgv_history.Size = new Size(490, 261);
            dgv_history.TabIndex = 0;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(141, 54);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(200, 23);
            dtp_start.TabIndex = 1;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(371, 54);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(200, 23);
            dtp_end.TabIndex = 2;
            // 
            // btn_filter
            // 
            btn_filter.BackColor = Color.Orange;
            btn_filter.Location = new Point(620, 54);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(75, 23);
            btn_filter.TabIndex = 3;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = false;
            btn_filter.Click += btn_filter_Click;
            // 
            // btn_export
            // 
            btn_export.BackColor = Color.SpringGreen;
            btn_export.Location = new Point(345, 406);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(93, 32);
            btn_export.TabIndex = 4;
            btn_export.Text = "Export";
            btn_export.UseVisualStyleBackColor = false;
            btn_export.Click += btn_export_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_export);
            Controls.Add(btn_filter);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(dgv_history);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_history).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_history;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private Button btn_filter;
        private Button btn_export;
    }
}