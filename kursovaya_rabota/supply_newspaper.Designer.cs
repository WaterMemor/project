namespace kursovaya_rabota
{
    partial class supply_newspaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supply_newspaper));
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.TextBox();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOST_OFFICEDataSet = new kursovaya_rabota.POST_OFFICEDataSet();
            this.btn_code = new System.Windows.Forms.TextBox();
            this.btn_sup = new System.Windows.Forms.TextBox();
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
            this.codesupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliednewspapersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresspostofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_1TableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.View_1TableAdapter();
            this.btn_code_post_office = new System.Windows.Forms.TextBox();
            this.code_sup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Фильтровать по";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "поставленным газетам";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "адресу почтового отделения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Коду издания";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(337, 310);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(137, 23);
            this.filter.TabIndex = 18;
            this.filter.Text = "Изменить данные";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // btn_address
            // 
            this.btn_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "address_post_office", true));
            this.btn_address.Location = new System.Drawing.Point(125, 310);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(100, 22);
            this.btn_address.TabIndex = 17;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // pOST_OFFICEDataSet
            // 
            this.pOST_OFFICEDataSet.DataSetName = "POST_OFFICEDataSet";
            this.pOST_OFFICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_code
            // 
            this.btn_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "code_publishing", true));
            this.btn_code.Location = new System.Drawing.Point(19, 310);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(100, 22);
            this.btn_code.TabIndex = 16;
            // 
            // btn_sup
            // 
            this.btn_sup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "supplied_newspapers", true));
            this.btn_sup.Location = new System.Drawing.Point(231, 310);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(100, 22);
            this.btn_sup.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 39);
            this.label1.TabIndex = 14;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            this.codesupplyDataGridViewTextBoxColumn,
            this.codepublishingDataGridViewTextBoxColumn,
            this.suppliednewspapersDataGridViewTextBoxColumn,
            this.addresspostofficeDataGridViewTextBoxColumn,
            this.codepostofficeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codesupplyDataGridViewTextBoxColumn
            // 
            this.codesupplyDataGridViewTextBoxColumn.DataPropertyName = "code_supply";
            this.codesupplyDataGridViewTextBoxColumn.HeaderText = "code_supply";
            this.codesupplyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codesupplyDataGridViewTextBoxColumn.Name = "codesupplyDataGridViewTextBoxColumn";
            this.codesupplyDataGridViewTextBoxColumn.Width = 125;
            // 
            // codepublishingDataGridViewTextBoxColumn
            // 
            this.codepublishingDataGridViewTextBoxColumn.DataPropertyName = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.HeaderText = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepublishingDataGridViewTextBoxColumn.Name = "codepublishingDataGridViewTextBoxColumn";
            this.codepublishingDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliednewspapersDataGridViewTextBoxColumn
            // 
            this.suppliednewspapersDataGridViewTextBoxColumn.DataPropertyName = "supplied_newspapers";
            this.suppliednewspapersDataGridViewTextBoxColumn.HeaderText = "supplied_newspapers";
            this.suppliednewspapersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliednewspapersDataGridViewTextBoxColumn.Name = "suppliednewspapersDataGridViewTextBoxColumn";
            this.suppliednewspapersDataGridViewTextBoxColumn.Width = 125;
            // 
            // addresspostofficeDataGridViewTextBoxColumn
            // 
            this.addresspostofficeDataGridViewTextBoxColumn.DataPropertyName = "address_post_office";
            this.addresspostofficeDataGridViewTextBoxColumn.HeaderText = "address_post_office";
            this.addresspostofficeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addresspostofficeDataGridViewTextBoxColumn.Name = "addresspostofficeDataGridViewTextBoxColumn";
            this.addresspostofficeDataGridViewTextBoxColumn.Width = 125;
            // 
            // codepostofficeDataGridViewTextBoxColumn
            // 
            this.codepostofficeDataGridViewTextBoxColumn.DataPropertyName = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn.HeaderText = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepostofficeDataGridViewTextBoxColumn.Name = "codepostofficeDataGridViewTextBoxColumn";
            this.codepostofficeDataGridViewTextBoxColumn.Width = 125;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // btn_code_post_office
            // 
            this.btn_code_post_office.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "code_post_office", true));
            this.btn_code_post_office.Location = new System.Drawing.Point(478, 310);
            this.btn_code_post_office.Name = "btn_code_post_office";
            this.btn_code_post_office.Size = new System.Drawing.Size(100, 22);
            this.btn_code_post_office.TabIndex = 24;
            this.btn_code_post_office.Visible = false;
            // 
            // code_sup
            // 
            this.code_sup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view1BindingSource, "code_post_office", true));
            this.code_sup.Location = new System.Drawing.Point(584, 310);
            this.code_sup.Name = "code_sup";
            this.code_sup.Size = new System.Drawing.Size(100, 22);
            this.code_sup.TabIndex = 25;
            this.code_sup.Visible = false;
            // 
            // supply_newspaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.code_sup);
            this.Controls.Add(this.btn_code_post_office);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.btn_code);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "supply_newspaper";
            this.Text = "supply_newspaper";
            this.Load += new System.EventHandler(this.supply_newspaper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox btn_address;
        private System.Windows.Forms.TextBox btn_code;
        private System.Windows.Forms.TextBox btn_sup;
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
        private System.Windows.Forms.BindingSource view1BindingSource;
        private POST_OFFICEDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.TextBox btn_code_post_office;
        private System.Windows.Forms.DataGridViewTextBoxColumn codesupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliednewspapersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresspostofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox code_sup;
    }
}