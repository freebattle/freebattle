namespace FreeBattle
{
    partial class ucControlPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.dgridAttach = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.window = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridAttach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(416, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttach.Location = new System.Drawing.Point(335, 236);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 21);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "&Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // dgridAttach
            // 
            this.dgridAttach.AllowUserToAddRows = false;
            this.dgridAttach.AllowUserToDeleteRows = false;
            this.dgridAttach.AllowUserToOrderColumns = true;
            this.dgridAttach.AllowUserToResizeRows = false;
            this.dgridAttach.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgridAttach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridAttach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridAttach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAttach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.window,
            this.path});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridAttach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgridAttach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgridAttach.Location = new System.Drawing.Point(9, 11);
            this.dgridAttach.Margin = new System.Windows.Forms.Padding(0);
            this.dgridAttach.MultiSelect = false;
            this.dgridAttach.Name = "dgridAttach";
            this.dgridAttach.ReadOnly = true;
            this.dgridAttach.RowHeadersVisible = false;
            this.dgridAttach.RowTemplate.Height = 18;
            this.dgridAttach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridAttach.ShowCellErrors = false;
            this.dgridAttach.ShowCellToolTips = false;
            this.dgridAttach.ShowEditingIcon = false;
            this.dgridAttach.Size = new System.Drawing.Size(516, 220);
            this.dgridAttach.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Format = "00000000";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "pID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 49;
            // 
            // name
            // 
            this.name.HeaderText = "Proccess Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // window
            // 
            this.window.FillWeight = 175.6098F;
            this.window.HeaderText = "Window";
            this.window.Name = "window";
            this.window.ReadOnly = true;
            this.window.Width = 60;
            // 
            // path
            // 
            this.path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.path.FillWeight = 24.39024F;
            this.path.HeaderText = "Path";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            // 
            // ucControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.dgridAttach);
            this.Name = "ucControlPanel";
            this.Size = new System.Drawing.Size(536, 268);
            this.Load += new System.EventHandler(this.ucControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAttach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.DataGridView dgridAttach;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewTextBoxColumn window;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
