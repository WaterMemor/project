namespace kursovaya_rabota
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_post_office = new System.Windows.Forms.DataGridView();
            this.codepostofficeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresspostofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postofficeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOST_OFFICEDataSet = new kursovaya_rabota.POST_OFFICEDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_newspapers = new System.Windows.Forms.DataGridView();
            this.codenewspaperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameeditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newspapersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_supply_newspapers = new System.Windows.Forms.DataGridView();
            this.codesupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepostofficeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliednewspapersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplynewspapersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_publishing = new System.Windows.Forms.DataGridView();
            this.codepublishingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codenewspaperDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishhouseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printednewspapersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_publish_houses = new System.Windows.Forms.DataGridView();
            this.codepublishhouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresshouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishhousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newspapersTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.newspapersTableAdapter();
            this.publish_housesTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.publish_housesTableAdapter();
            this.publishingTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.publishingTableAdapter();
            this.supply_newspapersTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.supply_newspapersTableAdapter();
            this.post_officeTableAdapter = new kursovaya_rabota.POST_OFFICEDataSetTableAdapters.post_officeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.газетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типографииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.почтовыеОтделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поступленияГазетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьТипографииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьПочтовоеОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_post_office)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postofficeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_newspapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supply_newspapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplynewspapersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publishing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publish_houses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishhousesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_post_office
            // 
            this.dataGridView_post_office.AutoGenerateColumns = false;
            this.dataGridView_post_office.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_post_office.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepostofficeDataGridViewTextBoxColumn1,
            this.addresspostofficeDataGridViewTextBoxColumn});
            this.dataGridView_post_office.DataSource = this.postofficeBindingSource;
            this.dataGridView_post_office.Location = new System.Drawing.Point(463, 267);
            this.dataGridView_post_office.Name = "dataGridView_post_office";
            this.dataGridView_post_office.RowHeadersWidth = 51;
            this.dataGridView_post_office.RowTemplate.Height = 24;
            this.dataGridView_post_office.Size = new System.Drawing.Size(303, 150);
            this.dataGridView_post_office.TabIndex = 0;
            // 
            // codepostofficeDataGridViewTextBoxColumn1
            // 
            this.codepostofficeDataGridViewTextBoxColumn1.DataPropertyName = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn1.HeaderText = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codepostofficeDataGridViewTextBoxColumn1.Name = "codepostofficeDataGridViewTextBoxColumn1";
            this.codepostofficeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // addresspostofficeDataGridViewTextBoxColumn
            // 
            this.addresspostofficeDataGridViewTextBoxColumn.DataPropertyName = "address_post_office";
            this.addresspostofficeDataGridViewTextBoxColumn.HeaderText = "address_post_office";
            this.addresspostofficeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addresspostofficeDataGridViewTextBoxColumn.Name = "addresspostofficeDataGridViewTextBoxColumn";
            this.addresspostofficeDataGridViewTextBoxColumn.Width = 125;
            // 
            // postofficeBindingSource
            // 
            this.postofficeBindingSource.DataMember = "post_office";
            this.postofficeBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // pOST_OFFICEDataSet
            // 
            this.pOST_OFFICEDataSet.DataSetName = "POST_OFFICEDataSet";
            this.pOST_OFFICEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.12F);
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая информация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView_newspapers
            // 
            this.dataGridView_newspapers.AutoGenerateColumns = false;
            this.dataGridView_newspapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_newspapers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codenewspaperDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.fullnameeditorDataGridViewTextBoxColumn});
            this.dataGridView_newspapers.DataSource = this.newspapersBindingSource;
            this.dataGridView_newspapers.Location = new System.Drawing.Point(33, 100);
            this.dataGridView_newspapers.Name = "dataGridView_newspapers";
            this.dataGridView_newspapers.RowHeadersWidth = 51;
            this.dataGridView_newspapers.RowTemplate.Height = 24;
            this.dataGridView_newspapers.Size = new System.Drawing.Size(554, 150);
            this.dataGridView_newspapers.TabIndex = 2;
            // 
            // codenewspaperDataGridViewTextBoxColumn
            // 
            this.codenewspaperDataGridViewTextBoxColumn.DataPropertyName = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn.HeaderText = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codenewspaperDataGridViewTextBoxColumn.Name = "codenewspaperDataGridViewTextBoxColumn";
            this.codenewspaperDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameeditorDataGridViewTextBoxColumn
            // 
            this.fullnameeditorDataGridViewTextBoxColumn.DataPropertyName = "full_name_editor";
            this.fullnameeditorDataGridViewTextBoxColumn.HeaderText = "full_name_editor";
            this.fullnameeditorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameeditorDataGridViewTextBoxColumn.Name = "fullnameeditorDataGridViewTextBoxColumn";
            this.fullnameeditorDataGridViewTextBoxColumn.Width = 125;
            // 
            // newspapersBindingSource
            // 
            this.newspapersBindingSource.DataMember = "newspapers";
            this.newspapersBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // dataGridView_supply_newspapers
            // 
            this.dataGridView_supply_newspapers.AutoGenerateColumns = false;
            this.dataGridView_supply_newspapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_supply_newspapers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codesupplyDataGridViewTextBoxColumn,
            this.codepublishingDataGridViewTextBoxColumn1,
            this.codepostofficeDataGridViewTextBoxColumn,
            this.suppliednewspapersDataGridViewTextBoxColumn});
            this.dataGridView_supply_newspapers.DataSource = this.supplynewspapersBindingSource;
            this.dataGridView_supply_newspapers.Location = new System.Drawing.Point(33, 593);
            this.dataGridView_supply_newspapers.Name = "dataGridView_supply_newspapers";
            this.dataGridView_supply_newspapers.RowHeadersWidth = 51;
            this.dataGridView_supply_newspapers.RowTemplate.Height = 24;
            this.dataGridView_supply_newspapers.Size = new System.Drawing.Size(554, 139);
            this.dataGridView_supply_newspapers.TabIndex = 3;
            // 
            // codesupplyDataGridViewTextBoxColumn
            // 
            this.codesupplyDataGridViewTextBoxColumn.DataPropertyName = "code_supply";
            this.codesupplyDataGridViewTextBoxColumn.HeaderText = "code_supply";
            this.codesupplyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codesupplyDataGridViewTextBoxColumn.Name = "codesupplyDataGridViewTextBoxColumn";
            this.codesupplyDataGridViewTextBoxColumn.Width = 125;
            // 
            // codepublishingDataGridViewTextBoxColumn1
            // 
            this.codepublishingDataGridViewTextBoxColumn1.DataPropertyName = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn1.HeaderText = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codepublishingDataGridViewTextBoxColumn1.Name = "codepublishingDataGridViewTextBoxColumn1";
            this.codepublishingDataGridViewTextBoxColumn1.Width = 125;
            // 
            // codepostofficeDataGridViewTextBoxColumn
            // 
            this.codepostofficeDataGridViewTextBoxColumn.DataPropertyName = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn.HeaderText = "code_post_office";
            this.codepostofficeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepostofficeDataGridViewTextBoxColumn.Name = "codepostofficeDataGridViewTextBoxColumn";
            this.codepostofficeDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliednewspapersDataGridViewTextBoxColumn
            // 
            this.suppliednewspapersDataGridViewTextBoxColumn.DataPropertyName = "supplied_newspapers";
            this.suppliednewspapersDataGridViewTextBoxColumn.HeaderText = "supplied_newspapers";
            this.suppliednewspapersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliednewspapersDataGridViewTextBoxColumn.Name = "suppliednewspapersDataGridViewTextBoxColumn";
            this.suppliednewspapersDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplynewspapersBindingSource
            // 
            this.supplynewspapersBindingSource.DataMember = "supply_newspapers";
            this.supplynewspapersBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // dataGridView_publishing
            // 
            this.dataGridView_publishing.AutoGenerateColumns = false;
            this.dataGridView_publishing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_publishing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepublishingDataGridViewTextBoxColumn,
            this.codenewspaperDataGridViewTextBoxColumn1,
            this.codepublishhouseDataGridViewTextBoxColumn1,
            this.printednewspapersDataGridViewTextBoxColumn});
            this.dataGridView_publishing.DataSource = this.publishingBindingSource;
            this.dataGridView_publishing.Location = new System.Drawing.Point(33, 437);
            this.dataGridView_publishing.Name = "dataGridView_publishing";
            this.dataGridView_publishing.RowHeadersWidth = 51;
            this.dataGridView_publishing.RowTemplate.Height = 24;
            this.dataGridView_publishing.Size = new System.Drawing.Size(554, 136);
            this.dataGridView_publishing.TabIndex = 4;
            // 
            // codepublishingDataGridViewTextBoxColumn
            // 
            this.codepublishingDataGridViewTextBoxColumn.DataPropertyName = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.HeaderText = "code_publishing";
            this.codepublishingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepublishingDataGridViewTextBoxColumn.Name = "codepublishingDataGridViewTextBoxColumn";
            this.codepublishingDataGridViewTextBoxColumn.Width = 125;
            // 
            // codenewspaperDataGridViewTextBoxColumn1
            // 
            this.codenewspaperDataGridViewTextBoxColumn1.DataPropertyName = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn1.HeaderText = "code_newspaper";
            this.codenewspaperDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codenewspaperDataGridViewTextBoxColumn1.Name = "codenewspaperDataGridViewTextBoxColumn1";
            this.codenewspaperDataGridViewTextBoxColumn1.Width = 125;
            // 
            // codepublishhouseDataGridViewTextBoxColumn1
            // 
            this.codepublishhouseDataGridViewTextBoxColumn1.DataPropertyName = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn1.HeaderText = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codepublishhouseDataGridViewTextBoxColumn1.Name = "codepublishhouseDataGridViewTextBoxColumn1";
            this.codepublishhouseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // printednewspapersDataGridViewTextBoxColumn
            // 
            this.printednewspapersDataGridViewTextBoxColumn.DataPropertyName = "printed_newspapers";
            this.printednewspapersDataGridViewTextBoxColumn.HeaderText = "printed_newspapers";
            this.printednewspapersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.printednewspapersDataGridViewTextBoxColumn.Name = "printednewspapersDataGridViewTextBoxColumn";
            this.printednewspapersDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishingBindingSource
            // 
            this.publishingBindingSource.DataMember = "publishing";
            this.publishingBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // dataGridView_publish_houses
            // 
            this.dataGridView_publish_houses.AutoGenerateColumns = false;
            this.dataGridView_publish_houses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_publish_houses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepublishhouseDataGridViewTextBoxColumn,
            this.addresshouseDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_publish_houses.DataSource = this.publishhousesBindingSource;
            this.dataGridView_publish_houses.Location = new System.Drawing.Point(33, 267);
            this.dataGridView_publish_houses.Name = "dataGridView_publish_houses";
            this.dataGridView_publish_houses.RowHeadersWidth = 51;
            this.dataGridView_publish_houses.RowTemplate.Height = 24;
            this.dataGridView_publish_houses.Size = new System.Drawing.Size(424, 150);
            this.dataGridView_publish_houses.TabIndex = 5;
            // 
            // codepublishhouseDataGridViewTextBoxColumn
            // 
            this.codepublishhouseDataGridViewTextBoxColumn.DataPropertyName = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn.HeaderText = "code_publish_house";
            this.codepublishhouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codepublishhouseDataGridViewTextBoxColumn.Name = "codepublishhouseDataGridViewTextBoxColumn";
            this.codepublishhouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // addresshouseDataGridViewTextBoxColumn
            // 
            this.addresshouseDataGridViewTextBoxColumn.DataPropertyName = "address_house";
            this.addresshouseDataGridViewTextBoxColumn.HeaderText = "address_house";
            this.addresshouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addresshouseDataGridViewTextBoxColumn.Name = "addresshouseDataGridViewTextBoxColumn";
            this.addresshouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishhousesBindingSource
            // 
            this.publishhousesBindingSource.DataMember = "publish_houses";
            this.publishhousesBindingSource.DataSource = this.pOST_OFFICEDataSet;
            // 
            // newspapersTableAdapter
            // 
            this.newspapersTableAdapter.ClearBeforeFill = true;
            // 
            // publish_housesTableAdapter
            // 
            this.publish_housesTableAdapter.ClearBeforeFill = true;
            // 
            // publishingTableAdapter
            // 
            this.publishingTableAdapter.ClearBeforeFill = true;
            // 
            // supply_newspapersTableAdapter
            // 
            this.supply_newspapersTableAdapter.ClearBeforeFill = true;
            // 
            // post_officeTableAdapter
            // 
            this.post_officeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.газетыToolStripMenuItem,
            this.типографииToolStripMenuItem,
            this.почтовыеОтделенияToolStripMenuItem,
            this.изданияToolStripMenuItem,
            this.поступленияГазетToolStripMenuItem});
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            // 
            // газетыToolStripMenuItem
            // 
            this.газетыToolStripMenuItem.Name = "газетыToolStripMenuItem";
            this.газетыToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.газетыToolStripMenuItem.Text = "Газеты";
            this.газетыToolStripMenuItem.Click += new System.EventHandler(this.газетыToolStripMenuItem_Click);
            // 
            // типографииToolStripMenuItem
            // 
            this.типографииToolStripMenuItem.Name = "типографииToolStripMenuItem";
            this.типографииToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.типографииToolStripMenuItem.Text = "Типографии";
            this.типографииToolStripMenuItem.Click += new System.EventHandler(this.типографииToolStripMenuItem_Click);
            // 
            // почтовыеОтделенияToolStripMenuItem
            // 
            this.почтовыеОтделенияToolStripMenuItem.Name = "почтовыеОтделенияToolStripMenuItem";
            this.почтовыеОтделенияToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.почтовыеОтделенияToolStripMenuItem.Text = "Почтовые отделения";
            this.почтовыеОтделенияToolStripMenuItem.Click += new System.EventHandler(this.почтовыеОтделенияToolStripMenuItem_Click);
            // 
            // изданияToolStripMenuItem
            // 
            this.изданияToolStripMenuItem.Name = "изданияToolStripMenuItem";
            this.изданияToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.изданияToolStripMenuItem.Text = "Издания";
            this.изданияToolStripMenuItem.Click += new System.EventHandler(this.изданияToolStripMenuItem_Click);
            // 
            // поступленияГазетToolStripMenuItem
            // 
            this.поступленияГазетToolStripMenuItem.Name = "поступленияГазетToolStripMenuItem";
            this.поступленияГазетToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.поступленияГазетToolStripMenuItem.Text = "Поступления газет";
            this.поступленияГазетToolStripMenuItem.Click += new System.EventHandler(this.поступленияГазетToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьТипографииToolStripMenuItem,
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem,
            this.получитьПочтовоеОтделениеToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // получитьТипографииToolStripMenuItem
            // 
            this.получитьТипографииToolStripMenuItem.Name = "получитьТипографииToolStripMenuItem";
            this.получитьТипографииToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.получитьТипографииToolStripMenuItem.Text = "Получить типографии";
            this.получитьТипографииToolStripMenuItem.Click += new System.EventHandler(this.получитьТипографииToolStripMenuItem_Click);
            // 
            // получитьГазетыВМеньшемКоличествеToolStripMenuItem
            // 
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem.Name = "получитьГазетыВМеньшемКоличествеToolStripMenuItem";
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem.Text = "Получить газеты в меньшем количестве";
            this.получитьГазетыВМеньшемКоличествеToolStripMenuItem.Click += new System.EventHandler(this.получитьГазетыВМеньшемКоличествеToolStripMenuItem_Click);
            // 
            // получитьПочтовоеОтделениеToolStripMenuItem
            // 
            this.получитьПочтовоеОтделениеToolStripMenuItem.Name = "получитьПочтовоеОтделениеToolStripMenuItem";
            this.получитьПочтовоеОтделениеToolStripMenuItem.Size = new System.Drawing.Size(373, 26);
            this.получитьПочтовоеОтделениеToolStripMenuItem.Text = "Получить почтовое отделение";
            this.получитьПочтовоеОтделениеToolStripMenuItem.Click += new System.EventHandler(this.получитьПочтовоеОтделениеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 778);
            this.Controls.Add(this.dataGridView_publish_houses);
            this.Controls.Add(this.dataGridView_publishing);
            this.Controls.Add(this.dataGridView_supply_newspapers);
            this.Controls.Add(this.dataGridView_newspapers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_post_office);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_post_office)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postofficeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOST_OFFICEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_newspapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supply_newspapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplynewspapersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publishing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_publish_houses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishhousesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_post_office;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_newspapers;
        private System.Windows.Forms.DataGridView dataGridView_supply_newspapers;
        private System.Windows.Forms.DataGridView dataGridView_publishing;
        private System.Windows.Forms.DataGridView dataGridView_publish_houses;
        private POST_OFFICEDataSet pOST_OFFICEDataSet;
        private System.Windows.Forms.BindingSource newspapersBindingSource;
        private POST_OFFICEDataSetTableAdapters.newspapersTableAdapter newspapersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codenewspaperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameeditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publishhousesBindingSource;
        private POST_OFFICEDataSetTableAdapters.publish_housesTableAdapter publish_housesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishhouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresshouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource publishingBindingSource;
        private POST_OFFICEDataSetTableAdapters.publishingTableAdapter publishingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codenewspaperDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishhouseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn printednewspapersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplynewspapersBindingSource;
        private POST_OFFICEDataSetTableAdapters.supply_newspapersTableAdapter supply_newspapersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codesupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliednewspapersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource postofficeBindingSource;
        private POST_OFFICEDataSetTableAdapters.post_officeTableAdapter post_officeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepostofficeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresspostofficeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem газетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типографииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem почтовыеОтделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поступленияГазетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьТипографииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьГазетыВМеньшемКоличествеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьПочтовоеОтделениеToolStripMenuItem;
    }
}

