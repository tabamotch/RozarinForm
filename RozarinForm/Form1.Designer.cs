namespace RozarinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.kaisekiResultFilePathTextbox = new System.Windows.Forms.TextBox();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.kaisekiButton = new System.Windows.Forms.Button();
            this.treeOutputButton = new System.Windows.Forms.Button();
            this.doubleBufferedDataGridView1 = new RozarinForm.DoubleBufferedDataGridView();
            this.methodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodCallingTreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.doubleBufferedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCallingTreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "解析結果ファイル";
            // 
            // kaisekiResultFilePathTextbox
            // 
            this.kaisekiResultFilePathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kaisekiResultFilePathTextbox.Location = new System.Drawing.Point(105, 12);
            this.kaisekiResultFilePathTextbox.Name = "kaisekiResultFilePathTextbox";
            this.kaisekiResultFilePathTextbox.Size = new System.Drawing.Size(642, 19);
            this.kaisekiResultFilePathTextbox.TabIndex = 1;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectButton.Location = new System.Drawing.Point(753, 10);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(35, 23);
            this.fileSelectButton.TabIndex = 2;
            this.fileSelectButton.Text = "…";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // kaisekiButton
            // 
            this.kaisekiButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kaisekiButton.Location = new System.Drawing.Point(12, 39);
            this.kaisekiButton.Name = "kaisekiButton";
            this.kaisekiButton.Size = new System.Drawing.Size(776, 23);
            this.kaisekiButton.TabIndex = 3;
            this.kaisekiButton.Text = "解析結果ファイルを読み込む";
            this.kaisekiButton.UseVisualStyleBackColor = true;
            this.kaisekiButton.Click += new System.EventHandler(this.kaisekiButton_Click);
            // 
            // treeOutputButton
            // 
            this.treeOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeOutputButton.Location = new System.Drawing.Point(12, 415);
            this.treeOutputButton.Name = "treeOutputButton";
            this.treeOutputButton.Size = new System.Drawing.Size(776, 23);
            this.treeOutputButton.TabIndex = 5;
            this.treeOutputButton.Text = "ツリー構造出力";
            this.treeOutputButton.UseVisualStyleBackColor = true;
            this.treeOutputButton.Click += new System.EventHandler(this.treeOutputButton_Click);
            // 
            // doubleBufferedDataGridView1
            // 
            this.doubleBufferedDataGridView1.AllowUserToAddRows = false;
            this.doubleBufferedDataGridView1.AllowUserToDeleteRows = false;
            this.doubleBufferedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedDataGridView1.AutoGenerateColumns = false;
            this.doubleBufferedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.doubleBufferedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doubleBufferedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.methodNameDataGridViewTextBoxColumn,
            this.linesDataGridViewTextBoxColumn});
            this.doubleBufferedDataGridView1.DataSource = this.methodCallingTreeBindingSource;
            this.doubleBufferedDataGridView1.Location = new System.Drawing.Point(12, 68);
            this.doubleBufferedDataGridView1.Name = "doubleBufferedDataGridView1";
            this.doubleBufferedDataGridView1.ReadOnly = true;
            this.doubleBufferedDataGridView1.RowTemplate.Height = 21;
            this.doubleBufferedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doubleBufferedDataGridView1.Size = new System.Drawing.Size(776, 341);
            this.doubleBufferedDataGridView1.TabIndex = 6;
            this.doubleBufferedDataGridView1.SelectionChanged += new System.EventHandler(this.doubleBufferedDataGridView1_SelectionChanged);
            // 
            // methodNameDataGridViewTextBoxColumn
            // 
            this.methodNameDataGridViewTextBoxColumn.DataPropertyName = "MethodName";
            this.methodNameDataGridViewTextBoxColumn.HeaderText = "メソッド名";
            this.methodNameDataGridViewTextBoxColumn.Name = "methodNameDataGridViewTextBoxColumn";
            this.methodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.methodNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // linesDataGridViewTextBoxColumn
            // 
            this.linesDataGridViewTextBoxColumn.DataPropertyName = "Lines";
            this.linesDataGridViewTextBoxColumn.HeaderText = "行数";
            this.linesDataGridViewTextBoxColumn.Name = "linesDataGridViewTextBoxColumn";
            this.linesDataGridViewTextBoxColumn.ReadOnly = true;
            this.linesDataGridViewTextBoxColumn.Width = 54;
            // 
            // methodCallingTreeBindingSource
            // 
            this.methodCallingTreeBindingSource.DataSource = typeof(RozarinForm.MethodCallingTree);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doubleBufferedDataGridView1);
            this.Controls.Add(this.treeOutputButton);
            this.Controls.Add(this.kaisekiButton);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.kaisekiResultFilePathTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ろざりん";
            ((System.ComponentModel.ISupportInitialize)(this.doubleBufferedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCallingTreeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kaisekiResultFilePathTextbox;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Button kaisekiButton;
        private System.Windows.Forms.Button treeOutputButton;
        private System.Windows.Forms.BindingSource methodCallingTreeBindingSource;
        private DoubleBufferedDataGridView doubleBufferedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linesDataGridViewTextBoxColumn;
    }
}

