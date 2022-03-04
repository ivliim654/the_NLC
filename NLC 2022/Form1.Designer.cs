namespace NLC_2022
{
    partial class Form1
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
            System.Windows.Forms.Label attractionLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label availabilityLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label ratingsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.S_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LOC_comboBox = new System.Windows.Forms.ComboBox();
            this.ava_comboBox = new System.Windows.Forms.ComboBox();
            this.att_comboBox = new System.Windows.Forms.ComboBox();
            this.Rating_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cost_comboBox = new System.Windows.Forms.ComboBox();
            this.tourist_AttractionsDataSet = new NLC_2022.Tourist_AttractionsDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new NLC_2022.Tourist_AttractionsDataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new NLC_2022.Tourist_AttractionsDataSetTableAdapters.TableAdapterManager();
            this.table1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.table1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attractionTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.availabilityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.ratingsTextBox = new System.Windows.Forms.TextBox();
            this.table1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.go_back_button = new System.Windows.Forms.Button();
            this.number_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label0 = new System.Windows.Forms.Label();
            this.lol_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            attractionLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            availabilityLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ratingsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_AttractionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).BeginInit();
            this.table1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // attractionLabel
            // 
            attractionLabel.AutoSize = true;
            attractionLabel.Location = new System.Drawing.Point(794, 230);
            attractionLabel.Name = "attractionLabel";
            attractionLabel.Size = new System.Drawing.Size(54, 13);
            attractionLabel.TabIndex = 28;
            attractionLabel.Text = "attraction:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(801, 267);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 29;
            locationLabel.Text = "location:";
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Location = new System.Drawing.Point(790, 299);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new System.Drawing.Size(58, 13);
            availabilityLabel.TabIndex = 30;
            availabilityLabel.Text = "availability:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(818, 337);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(30, 13);
            costLabel.TabIndex = 31;
            costLabel.Text = "cost:";
            // 
            // ratingsLabel
            // 
            ratingsLabel.AutoSize = true;
            ratingsLabel.Location = new System.Drawing.Point(807, 371);
            ratingsLabel.Name = "ratingsLabel";
            ratingsLabel.Size = new System.Drawing.Size(41, 13);
            ratingsLabel.TabIndex = 32;
            ratingsLabel.Text = "ratings:";
            // 
            // S_button
            // 
            this.S_button.Location = new System.Drawing.Point(82, 220);
            this.S_button.Name = "S_button";
            this.S_button.Size = new System.Drawing.Size(146, 27);
            this.S_button.TabIndex = 0;
            this.S_button.Text = "Search";
            this.S_button.UseVisualStyleBackColor = true;
            this.S_button.Visible = false;
            this.S_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tourist Attractions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NLC_2022.Properties.Resources.arizona_counties_map;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "availability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = " attraction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ratings";
            // 
            // LOC_comboBox
            // 
            this.LOC_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LOC_comboBox.FormattingEnabled = true;
            this.LOC_comboBox.Items.AddRange(new object[] {
            "near me",
            "In state",
            "out of state "});
            this.LOC_comboBox.Location = new System.Drawing.Point(63, 41);
            this.LOC_comboBox.Name = "LOC_comboBox";
            this.LOC_comboBox.Size = new System.Drawing.Size(121, 21);
            this.LOC_comboBox.TabIndex = 15;
            this.LOC_comboBox.Visible = false;
            this.LOC_comboBox.SelectedIndexChanged += new System.EventHandler(this.LOC_comboBox_SelectedIndexChanged);
            // 
            // ava_comboBox
            // 
            this.ava_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ava_comboBox.FormattingEnabled = true;
            this.ava_comboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.ava_comboBox.Location = new System.Drawing.Point(63, 77);
            this.ava_comboBox.Name = "ava_comboBox";
            this.ava_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ava_comboBox.TabIndex = 16;
            this.ava_comboBox.Visible = false;
            this.ava_comboBox.SelectedIndexChanged += new System.EventHandler(this.ava_comboBox_SelectedIndexChanged);
            // 
            // att_comboBox
            // 
            this.att_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.att_comboBox.FormattingEnabled = true;
            this.att_comboBox.Items.AddRange(new object[] {
            "restaurant",
            "zoo",
            "water park"});
            this.att_comboBox.Location = new System.Drawing.Point(63, 10);
            this.att_comboBox.Name = "att_comboBox";
            this.att_comboBox.Size = new System.Drawing.Size(121, 21);
            this.att_comboBox.TabIndex = 17;
            this.att_comboBox.SelectedIndexChanged += new System.EventHandler(this.att_comboBox_SelectedIndexChanged);
            // 
            // Rating_comboBox
            // 
            this.Rating_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rating_comboBox.FormattingEnabled = true;
            this.Rating_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Rating_comboBox.Location = new System.Drawing.Point(61, 145);
            this.Rating_comboBox.Name = "Rating_comboBox";
            this.Rating_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Rating_comboBox.TabIndex = 19;
            this.Rating_comboBox.Visible = false;
            this.Rating_comboBox.SelectedIndexChanged += new System.EventHandler(this.Rating_comboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 27);
            this.button3.TabIndex = 23;
            this.button3.Text = "-->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "meets your requirements";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "cost";
            // 
            // Cost_comboBox
            // 
            this.Cost_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cost_comboBox.FormattingEnabled = true;
            this.Cost_comboBox.Items.AddRange(new object[] {
            "$",
            "$$",
            "$$$$$$$"});
            this.Cost_comboBox.Location = new System.Drawing.Point(63, 111);
            this.Cost_comboBox.Name = "Cost_comboBox";
            this.Cost_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Cost_comboBox.TabIndex = 26;
            this.Cost_comboBox.Visible = false;
            this.Cost_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cost_comboBox_SelectedIndexChanged);
            // 
            // tourist_AttractionsDataSet
            // 
            this.tourist_AttractionsDataSet.DataSetName = "Tourist_AttractionsDataSet";
            this.tourist_AttractionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.tourist_AttractionsDataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.UpdateOrder = NLC_2022.Tourist_AttractionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table1BindingNavigator
            // 
            this.table1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table1BindingNavigator.BindingSource = this.table1BindingSource;
            this.table1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.table1BindingNavigatorSaveItem});
            this.table1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table1BindingNavigator.Name = "table1BindingNavigator";
            this.table1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table1BindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.table1BindingNavigator.TabIndex = 27;
            this.table1BindingNavigator.Text = "bindingNavigator1";
            this.table1BindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table1BindingNavigatorSaveItem
            // 
            this.table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table1BindingNavigatorSaveItem.Image")));
            this.table1BindingNavigatorSaveItem.Name = "table1BindingNavigatorSaveItem";
            this.table1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table1BindingNavigatorSaveItem.Text = "Save Data";
            this.table1BindingNavigatorSaveItem.Click += new System.EventHandler(this.table1BindingNavigatorSaveItem_Click);
            // 
            // attractionTextBox
            // 
            this.attractionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "attraction", true));
            this.attractionTextBox.Location = new System.Drawing.Point(854, 227);
            this.attractionTextBox.Name = "attractionTextBox";
            this.attractionTextBox.Size = new System.Drawing.Size(100, 20);
            this.attractionTextBox.TabIndex = 29;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(854, 264);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 30;
            // 
            // availabilityTextBox
            // 
            this.availabilityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "availability", true));
            this.availabilityTextBox.Location = new System.Drawing.Point(854, 296);
            this.availabilityTextBox.Name = "availabilityTextBox";
            this.availabilityTextBox.Size = new System.Drawing.Size(100, 20);
            this.availabilityTextBox.TabIndex = 31;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "cost", true));
            this.costTextBox.Location = new System.Drawing.Point(854, 334);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 32;
            // 
            // ratingsTextBox
            // 
            this.ratingsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "ratings", true));
            this.ratingsTextBox.Location = new System.Drawing.Point(854, 368);
            this.ratingsTextBox.Name = "ratingsTextBox";
            this.ratingsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingsTextBox.TabIndex = 33;
            // 
            // table1DataGridView
            // 
            this.table1DataGridView.AutoGenerateColumns = false;
            this.table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.table1DataGridView.DataSource = this.table1BindingSource;
            this.table1DataGridView.Location = new System.Drawing.Point(378, 57);
            this.table1DataGridView.Name = "table1DataGridView";
            this.table1DataGridView.Size = new System.Drawing.Size(473, 157);
            this.table1DataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "attraction";
            this.dataGridViewTextBoxColumn3.HeaderText = "attraction";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "location";
            this.dataGridViewTextBoxColumn4.HeaderText = "location";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "availability";
            this.dataGridViewTextBoxColumn5.HeaderText = "availability";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn6.HeaderText = "cost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ratings";
            this.dataGridViewTextBoxColumn7.HeaderText = "ratings";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(16, 32);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(172, 80);
            this.name_textBox.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.go_back_button);
            this.groupBox1.Controls.Add(this.name_textBox);
            this.groupBox1.Controls.Add(this.number_label);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(56, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 247);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "we found!";
            this.groupBox1.Visible = false;
            // 
            // go_back_button
            // 
            this.go_back_button.Location = new System.Drawing.Point(15, 152);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(172, 77);
            this.go_back_button.TabIndex = 36;
            this.go_back_button.Text = "go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(32, 16);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(13, 13);
            this.number_label.TabIndex = 37;
            this.number_label.Text = "_";
            this.number_label.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.att_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.LOC_comboBox);
            this.groupBox2.Controls.Add(this.ava_comboBox);
            this.groupBox2.Controls.Add(this.Rating_comboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cost_comboBox);
            this.groupBox2.Location = new System.Drawing.Point(56, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 176);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(54, 188);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(200, 29);
            this.label0.TabIndex = 38;
            this.label0.Text = "Lets Find A Place";
            // 
            // lol_button
            // 
            this.lol_button.Location = new System.Drawing.Point(-2, -2);
            this.lol_button.Name = "lol_button";
            this.lol_button.Size = new System.Drawing.Size(339, 510);
            this.lol_button.TabIndex = 40;
            this.lol_button.Text = "LOL";
            this.lol_button.UseVisualStyleBackColor = true;
            this.lol_button.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(334, 504);
            this.Controls.Add(this.lol_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.S_button);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.table1DataGridView);
            this.Controls.Add(ratingsLabel);
            this.Controls.Add(this.ratingsTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(availabilityLabel);
            this.Controls.Add(this.availabilityTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(attractionLabel);
            this.Controls.Add(this.attractionTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table1BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "_";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_AttractionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).EndInit();
            this.table1BindingNavigator.ResumeLayout(false);
            this.table1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox LOC_comboBox;
        private System.Windows.Forms.ComboBox ava_comboBox;
        private System.Windows.Forms.ComboBox att_comboBox;
        private System.Windows.Forms.ComboBox Rating_comboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cost_comboBox;
        private Tourist_AttractionsDataSet tourist_AttractionsDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Tourist_AttractionsDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private Tourist_AttractionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton table1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox attractionTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox availabilityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox ratingsTextBox;
        private System.Windows.Forms.DataGridView table1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button go_back_button;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lol_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}

