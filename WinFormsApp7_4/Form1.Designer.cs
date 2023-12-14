namespace WinFormsApp7_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            addButton = new Button();
            removeButton = new Button();
            price = new MaskedTextBox();
            bookName = new TextBox();
            author = new TextBox();
            bookDataGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bookDataSetBindingSource = new BindingSource(components);
            bookDataTableBindingSource = new BindingSource(components);
            書名DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            著者DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            値段DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookDataTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(354, 302);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 45);
            addButton.TabIndex = 0;
            addButton.Text = "登録";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButtonClicked;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(354, 410);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(88, 45);
            removeButton.TabIndex = 1;
            removeButton.Text = "削除";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += RemoveButtonClicked;
            // 
            // price
            // 
            price.Location = new Point(80, 428);
            price.Mask = "00000";
            price.Name = "price";
            price.Size = new Size(244, 27);
            price.TabIndex = 2;
            price.ValidatingType = typeof(DateTime);
            // 
            // bookName
            // 
            bookName.Location = new Point(80, 302);
            bookName.Name = "bookName";
            bookName.Size = new Size(244, 27);
            bookName.TabIndex = 3;
            // 
            // author
            // 
            author.Location = new Point(80, 369);
            author.Name = "author";
            author.Size = new Size(244, 27);
            author.TabIndex = 4;
            // 
            // bookDataGrid
            // 
            bookDataGrid.AutoGenerateColumns = false;
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Columns.AddRange(new DataGridViewColumn[] { 書名DataGridViewTextBoxColumn, 著者DataGridViewTextBoxColumn, 値段DataGridViewTextBoxColumn });
            bookDataGrid.DataSource = bookDataTableBindingSource;
            bookDataGrid.Location = new Point(17, 12);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.RowHeadersWidth = 51;
            bookDataGrid.RowTemplate.Height = 29;
            bookDataGrid.Size = new Size(440, 265);
            bookDataGrid.TabIndex = 5;
            bookDataGrid.CellContentClick += bookDataGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 309);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "書名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 372);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 7;
            label2.Text = "著者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 435);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "値段";
            // 
            // bookDataSetBindingSource
            // 
            bookDataSetBindingSource.DataSource = typeof(BookDataSet);
            bookDataSetBindingSource.Position = 0;
            // 
            // bookDataTableBindingSource
            // 
            bookDataTableBindingSource.DataMember = "BookDataTable";
            bookDataTableBindingSource.DataSource = typeof(BookDataSet);
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            書名DataGridViewTextBoxColumn.HeaderText = "書名";
            書名DataGridViewTextBoxColumn.MinimumWidth = 6;
            書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            書名DataGridViewTextBoxColumn.Width = 125;
            // 
            // 著者DataGridViewTextBoxColumn
            // 
            著者DataGridViewTextBoxColumn.DataPropertyName = "著者";
            著者DataGridViewTextBoxColumn.HeaderText = "著者";
            著者DataGridViewTextBoxColumn.MinimumWidth = 6;
            著者DataGridViewTextBoxColumn.Name = "著者DataGridViewTextBoxColumn";
            著者DataGridViewTextBoxColumn.Width = 125;
            // 
            // 値段DataGridViewTextBoxColumn
            // 
            値段DataGridViewTextBoxColumn.DataPropertyName = "値段";
            値段DataGridViewTextBoxColumn.HeaderText = "値段";
            値段DataGridViewTextBoxColumn.MinimumWidth = 6;
            値段DataGridViewTextBoxColumn.Name = "値段DataGridViewTextBoxColumn";
            値段DataGridViewTextBoxColumn.ReadOnly = true;
            値段DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 480);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookDataGrid);
            Controls.Add(author);
            Controls.Add(bookName);
            Controls.Add(price);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookDataTableBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private MaskedTextBox price;
        private TextBox bookName;
        private TextBox author;
        private DataGridView bookDataGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn 著者DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn 値段DataGridViewTextBoxColumn;
        private BindingSource bookDataTableBindingSource;
        private BindingSource bookDataSetBindingSource;
    }
}