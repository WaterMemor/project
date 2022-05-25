namespace kursovaya_rabota
{
    partial class publishing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publishing));
            this.code_pub = new System.Windows.Forms.TextBox();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOST_OFFICEDataSet = new kursovaya_rabota.POST_OFFICEDataSet();
            this.code_news = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.TextBox();
            this.printed_news = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codepublishingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresshouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printednewspapersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codenewspaperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_2TableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.View_2TableAdapter();
            this.btn_title = new System.Windows.Forms.ComboBox();
            this.newspapersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newspapersTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.newspapersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // code_pub
            // 
            this.code_pub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view2BindingSource, "code_publish_house", true));
            this.code_pub.Location = new System.Drawing.Point(603, 319);
            this.code_pub.Name = "code_pub";
            this.code_pub.Size = new System.Drawing.Size(100, 22);
            this.code_pub.TabIndex = 38;
            this.code_pub.Visible = false;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // pOST_OFFICEDataSet
            // 
            this.pOST_OFFICEDataSet.DataSetName = "POST_OFFICEDataSet";
            this.pOST_OFFICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // code_news
            // 
            this.code_news.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view2BindingSource, "code_newspaper", true));
            this.code_news.Location = new System.Drawing.Point(497, 319);
            this.code_news.Name = "code_news";
            this.code_news.Size = new System.Drawing.Size(100, 22);
            this.code_news.TabIndex = 37;
            this.code_news.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Фильтровать по";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "поставленным газетам";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "адресу почтового отделения";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Коду издания";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(356, 319);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(137, 23);
            this.filter.TabIndex = 32;
            this.filter.Text = "Изменить данные";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // btn_address
            // 
            this.btn_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view2BindingSource, "address_house", true));
            this.btn_address.Location = new System.Drawing.Point(144, 319);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(100, 22);
            this.btn_address.TabIndex = 31;
            // 
            // printed_news
            // 
            this.printed_news.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view2BindingSource, "printed_newspapers", true));
            this.printed_news.Location = new System.Drawing.Point(250, 319);
            this.printed_news.Name = "printed_news";
            this.printed_news.Size = new System.Drawing.Size(100, 22);
            this.printed_news.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Список поставок газет";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 27;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepublishingDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.addresshouseDataGridViewTextBoxColumn,
            this.printednewspapersDataGridViewTextBoxColumn,
            this.codenewspaperDataGridViewTextBoxColumn,
            this.codepublishhouseDataGridViewTextBoxColumn,
            this.expr4DataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // codepublishingDataGridViewTextBoxColumn
            // 
            this.codepublishingDataGridViewTextBoxColumn.DataPropertyName = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.HeaderText = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepublishingDataGridViewTextBoxColumn.Name = "codepublishingDataGridViewTextBoxColumn";
            this.codepublishingDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // addresshouseDataGridViewTextBoxColumn
            // 
            this.addresshouseDataGridViewTextBoxColumn.DataPropertyName = "address_house";
            this.addresshouseDataGridViewTextBoxColumn.HeaderText = "address_house";
            this.addresshouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addresshouseDataGridViewTextBoxColumn.Name = "addresshouseDataGridViewTextBoxColumn";
            this.addresshouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // printednewspapersDataGridViewTextBoxColumn
            // 
            this.printednewspapersDataGridViewTextBoxColumn.DataPropertyName = "printed_newspapers";
            this.printednewspapersDataGridViewTextBoxColumn.HeaderText = "printed_newspapers";
            this.printednewspapersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.printednewspapersDataGridViewTextBoxColumn.Name = "printednewspapersDataGridViewTextBoxColumn";
            this.printednewspapersDataGridViewTextBoxColumn.Width = 125;
            // 
            // codenewspaperDataGridViewTextBoxColumn
            // 
            this.codenewspaperDataGridViewTextBoxColumn.DataPropertyName = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn.HeaderText = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codenewspaperDataGridViewTextBoxColumn.Name = "codenewspaperDataGridViewTextBoxColumn";
            this.codenewspaperDataGridViewTextBoxColumn.Visible = false;
            this.codenewspaperDataGridViewTextBoxColumn.Width = 125;
            // 
            // codepublishhouseDataGridViewTextBoxColumn
            // 
            this.codepublishhouseDataGridViewTextBoxColumn.DataPropertyName = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn.HeaderText = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepublishhouseDataGridViewTextBoxColumn.Name = "codepublishhouseDataGridViewTextBoxColumn";
            this.codepublishhouseDataGridViewTextBoxColumn.Visible = false;
            this.codepublishhouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // expr4DataGridViewTextBoxColumn
            // 
            this.expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4";
            this.expr4DataGridViewTextBoxColumn.HeaderText = "Expr4";
            this.expr4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr4DataGridViewTextBoxColumn.Name = "expr4DataGridViewTextBoxColumn";
            this.expr4DataGridViewTextBoxColumn.Visible = false;
            this.expr4DataGridViewTextBoxColumn.Width = 125;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // btn_title
            // 
            this.btn_title.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.view2BindingSource, "code_newspaper", true));
            this.btn_title.DataSource = this.view2BindingSource;
            this.btn_title.DisplayMember = "title";
            this.btn_title.FormattingEnabled = true;
            this.btn_title.Location = new System.Drawing.Point(17, 317);
            this.btn_title.Name = "btn_title";
            this.btn_title.Size = new System.Drawing.Size(121, 24);
            this.btn_title.TabIndex = 39;
            this.btn_title.ValueMember = "code_newspaper";
            // 
            // newspapersBindingSource
            // 
            this.newspapersBindingSource.DataMember = "newspapers";
            this.newspapersBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // newspapersTableAdapter
            // 
            this.newspapersTableAdapter.ClearBeforeFill = true;
            // 
            // publishing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_title);
            this.Controls.Add(this.code_pub);
            this.Controls.Add(this.code_news);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.printed_news);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "publishing";
            this.Text = "publishing";
            this.Load += new System.EventHandler(this.publishing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code_pub;
        private System.Windows.Forms.TextBox code_news;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox btn_address;
        private System.Windows.Forms.TextBox printed_news;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private POST_OFFICEDataSet pOST_OFFICEDataSet;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private POST_OFFICEDataSetTableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresshouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printednewspapersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codenewspaperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox btn_title;
        private System.Windows.Forms.BindingSource newspapersBindingSource;
        private POST_OFFICEDataSetTableAdapters.newspapersTableAdapter newspapersTableAdapter;
    }
}