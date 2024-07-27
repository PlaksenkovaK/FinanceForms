namespace FinanceForms
{
    partial class MainPage
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
            components = new System.ComponentModel.Container();
            ColumnHeader name;
            ColumnHeader type;
            ColumnHeader balance;
            ColumnHeader id;
            ColumnHeader trId;
            ColumnHeader trName;
            ColumnHeader trType;
            ColumnHeader Desc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "Имя", "ААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА", "100000", "12.12.2020", "Доход" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "Имя", "USD", "1000" }, -1);
            tabs = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            dateChart = new LiveCharts.WinForms.CartesianChart();
            categoriesChart = new LiveCharts.WinForms.CartesianChart();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            dateLabel = new MaterialSkin.Controls.MaterialLabel();
            currentDate = new DateTimePicker();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            savedMoney = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            accsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            addCategory = new MaterialSkin.Controls.MaterialButton();
            addAcc = new MaterialSkin.Controls.MaterialButton();
            addTrantaction = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            moneyLabelProgText = new MaterialSkin.Controls.MaterialLabel();
            MoneyLabelProg = new MaterialSkin.Controls.MaterialProgressBar();
            moneyLabel = new MaterialSkin.Controls.MaterialLabel();
            mlabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            leftMoneyProgLabel = new MaterialSkin.Controls.MaterialLabel();
            leftMoneyProgress = new MaterialSkin.Controls.MaterialProgressBar();
            leftmoney = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            transactionList = new MaterialSkin.Controls.MaterialListView();
            acc = new ColumnHeader();
            amount = new ColumnHeader();
            date = new ColumnHeader();
            category = new ColumnHeader();
            transactionMenu = new ContextMenuStrip(components);
            deleteTrMenuItem = new ToolStripMenuItem();
            addTrMenuItem = new ToolStripMenuItem();
            showMenuItem = new ToolStripMenuItem();
            accsCollection = new TabPage();
            accsListView = new MaterialSkin.Controls.MaterialListView();
            accMenuStrip = new ContextMenuStrip(components);
            deleteMenuItem = new ToolStripMenuItem();
            addMenuItem = new ToolStripMenuItem();
            logout = new TabPage();
            name = new ColumnHeader();
            type = new ColumnHeader();
            balance = new ColumnHeader();
            id = new ColumnHeader();
            trId = new ColumnHeader();
            trName = new ColumnHeader();
            trType = new ColumnHeader();
            Desc = new ColumnHeader();
            tabs.SuspendLayout();
            tabPage1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard1.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard4.SuspendLayout();
            transactionMenu.SuspendLayout();
            accsCollection.SuspendLayout();
            accMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // name
            // 
            name.Text = "Наименование";
            name.TextAlign = HorizontalAlignment.Center;
            name.Width = 400;
            // 
            // type
            // 
            type.Text = "Тип";
            type.TextAlign = HorizontalAlignment.Center;
            type.Width = 300;
            // 
            // balance
            // 
            balance.Text = "Баланс";
            balance.TextAlign = HorizontalAlignment.Center;
            balance.Width = 270;
            // 
            // id
            // 
            id.Text = "Номер";
            id.Width = 100;
            // 
            // trId
            // 
            trId.Text = "Номер";
            trId.Width = 80;
            // 
            // trName
            // 
            trName.Text = "Имя";
            trName.TextAlign = HorizontalAlignment.Center;
            trName.Width = 300;
            // 
            // trType
            // 
            trType.Text = "Тип";
            trType.TextAlign = HorizontalAlignment.Center;
            trType.Width = 100;
            // 
            // Desc
            // 
            Desc.Text = "Примечание";
            Desc.TextAlign = HorizontalAlignment.Center;
            Desc.Width = 300;
            // 
            // tabs
            // 
            tabs.Controls.Add(tabPage1);
            tabs.Controls.Add(tabPage2);
            tabs.Controls.Add(accsCollection);
            tabs.Controls.Add(logout);
            tabs.Depth = 0;
            tabs.Dock = DockStyle.Fill;
            tabs.ImageList = imageList1;
            tabs.Location = new Point(0, 64);
            tabs.MinimumSize = new Size(915, 482);
            tabs.MouseState = MaterialSkin.MouseState.HOVER;
            tabs.Multiline = true;
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1093, 497);
            tabs.TabIndex = 0;
            tabs.SelectedIndexChanged += selectedTabChange;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(dateChart);
            tabPage1.Controls.Add(categoriesChart);
            tabPage1.Controls.Add(materialCard2);
            tabPage1.Controls.Add(materialCard3);
            tabPage1.Controls.Add(materialCard1);
            tabPage1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage1.ImageKey = "dashboard_40dp.png";
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1085, 460);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Аналитика";
            tabPage1.ToolTipText = "Аналитика";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateChart
            // 
            dateChart.Location = new Point(326, 304);
            dateChart.Name = "dateChart";
            dateChart.Size = new Size(685, 124);
            dateChart.TabIndex = 2;
            // 
            // categoriesChart
            // 
            categoriesChart.ForeColor = SystemColors.Window;
            categoriesChart.Location = new Point(326, 159);
            categoriesChart.Name = "categoriesChart";
            categoriesChart.Size = new Size(685, 124);
            categoriesChart.TabIndex = 1;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dateLabel);
            materialCard2.Controls.Add(currentDate);
            materialCard2.Controls.Add(materialCard5);
            materialCard2.Controls.Add(accsComboBox);
            materialCard2.Controls.Add(addCategory);
            materialCard2.Controls.Add(addAcc);
            materialCard2.Controls.Add(addTrantaction);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(10, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(288, 414);
            materialCard2.TabIndex = 0;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Depth = 0;
            dateLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            dateLabel.Location = new Point(17, 244);
            dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(177, 17);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Выберите месяц рассчета";
            // 
            // currentDate
            // 
            currentDate.Location = new Point(17, 266);
            currentDate.MaxDate = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            currentDate.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            currentDate.Name = "currentDate";
            currentDate.Size = new Size(252, 26);
            currentDate.TabIndex = 2;
            currentDate.Value = new DateTime(2024, 5, 27, 0, 0, 0, 0);
            currentDate.ValueChanged += DateChange;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(savedMoney);
            materialCard5.Controls.Add(materialLabel4);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(17, 309);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(252, 95);
            materialCard5.TabIndex = 2;
            // 
            // savedMoney
            // 
            savedMoney.AutoEllipsis = true;
            savedMoney.Depth = 0;
            savedMoney.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            savedMoney.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            savedMoney.ImageAlign = ContentAlignment.MiddleLeft;
            savedMoney.Location = new Point(17, 43);
            savedMoney.MouseState = MaterialSkin.MouseState.HOVER;
            savedMoney.Name = "savedMoney";
            savedMoney.Size = new Size(218, 40);
            savedMoney.TabIndex = 1;
            savedMoney.Text = "Какойто текст";
            savedMoney.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel4.Location = new Point(17, 14);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(204, 19);
            materialLabel4.TabIndex = 0;
            materialLabel4.Text = "Остаток в текущем месяце";
            // 
            // accsComboBox
            // 
            accsComboBox.AutoResize = false;
            accsComboBox.BackColor = SystemColors.ActiveCaption;
            accsComboBox.Depth = 0;
            accsComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            accsComboBox.DropDownHeight = 174;
            accsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accsComboBox.DropDownWidth = 121;
            accsComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accsComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            accsComboBox.FormattingEnabled = true;
            accsComboBox.Hint = "Счет";
            accsComboBox.IntegralHeight = false;
            accsComboBox.ItemHeight = 43;
            accsComboBox.Location = new Point(17, 177);
            accsComboBox.MaxDropDownItems = 4;
            accsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            accsComboBox.Name = "accsComboBox";
            accsComboBox.Size = new Size(252, 49);
            accsComboBox.StartIndex = 0;
            accsComboBox.TabIndex = 1;
            accsComboBox.SelectedIndexChanged += accsComboBox_SelectedIndexChanged;
            // 
            // addCategory
            // 
            addCategory.AutoSize = false;
            addCategory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addCategory.Depth = 0;
            addCategory.HighEmphasis = true;
            addCategory.Icon = Properties.Resources.add_white;
            addCategory.ImageAlign = ContentAlignment.MiddleLeft;
            addCategory.ImageKey = "add_white.png";
            addCategory.Location = new Point(17, 116);
            addCategory.Margin = new Padding(4, 6, 4, 6);
            addCategory.MouseState = MaterialSkin.MouseState.HOVER;
            addCategory.Name = "addCategory";
            addCategory.NoAccentTextColor = Color.Empty;
            addCategory.Size = new Size(252, 36);
            addCategory.TabIndex = 0;
            addCategory.Text = "Добавить категорию";
            addCategory.TextImageRelation = TextImageRelation.TextAboveImage;
            addCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addCategory.UseAccentColor = true;
            addCategory.UseVisualStyleBackColor = true;
            addCategory.Click += addCategory_Click;
            // 
            // addAcc
            // 
            addAcc.AutoSize = false;
            addAcc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addAcc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addAcc.Depth = 0;
            addAcc.HighEmphasis = true;
            addAcc.Icon = Properties.Resources.add_white;
            addAcc.ImageAlign = ContentAlignment.MiddleLeft;
            addAcc.ImageKey = "add_white.png";
            addAcc.Location = new Point(17, 68);
            addAcc.Margin = new Padding(4, 6, 4, 6);
            addAcc.MouseState = MaterialSkin.MouseState.HOVER;
            addAcc.Name = "addAcc";
            addAcc.NoAccentTextColor = Color.Empty;
            addAcc.Size = new Size(252, 36);
            addAcc.TabIndex = 0;
            addAcc.Text = "Добавить счет";
            addAcc.TextImageRelation = TextImageRelation.TextAboveImage;
            addAcc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addAcc.UseAccentColor = true;
            addAcc.UseVisualStyleBackColor = true;
            addAcc.Click += addAcc_Click;
            // 
            // addTrantaction
            // 
            addTrantaction.AutoSize = false;
            addTrantaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addTrantaction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addTrantaction.Depth = 0;
            addTrantaction.HighEmphasis = true;
            addTrantaction.Icon = Properties.Resources.add_white;
            addTrantaction.ImageAlign = ContentAlignment.MiddleLeft;
            addTrantaction.ImageKey = "add_white.png";
            addTrantaction.ImageList = imageList1;
            addTrantaction.Location = new Point(18, 20);
            addTrantaction.Margin = new Padding(4, 6, 4, 6);
            addTrantaction.MouseState = MaterialSkin.MouseState.HOVER;
            addTrantaction.Name = "addTrantaction";
            addTrantaction.NoAccentTextColor = Color.Empty;
            addTrantaction.Size = new Size(252, 36);
            addTrantaction.TabIndex = 0;
            addTrantaction.Text = "Добавить транзакцию";
            addTrantaction.TextImageRelation = TextImageRelation.TextAboveImage;
            addTrantaction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addTrantaction.UseAccentColor = true;
            addTrantaction.UseVisualStyleBackColor = true;
            addTrantaction.Click += addTrantaction_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "account_circle_40dp.png");
            imageList1.Images.SetKeyName(1, "add_brown.png");
            imageList1.Images.SetKeyName(2, "add_white.png");
            imageList1.Images.SetKeyName(3, "analytics_40dp.png");
            imageList1.Images.SetKeyName(4, "article_40dp.png");
            imageList1.Images.SetKeyName(5, "close_brown.png");
            imageList1.Images.SetKeyName(6, "close_white.png");
            imageList1.Images.SetKeyName(7, "dashboard_40dp.png");
            imageList1.Images.SetKeyName(8, "delete_40dp.png");
            imageList1.Images.SetKeyName(9, "delete_brown.png");
            imageList1.Images.SetKeyName(10, "delete_forever_40dp.png");
            imageList1.Images.SetKeyName(11, "description_40dp.png");
            imageList1.Images.SetKeyName(12, "help_40dp.png");
            imageList1.Images.SetKeyName(13, "home_40dp.png");
            imageList1.Images.SetKeyName(14, "home_brown.png");
            imageList1.Images.SetKeyName(15, "info_40dp.png");
            imageList1.Images.SetKeyName(16, "logout_40dp.png");
            imageList1.Images.SetKeyName(17, "menu_brown.png");
            imageList1.Images.SetKeyName(18, "page_control_brown.png");
            imageList1.Images.SetKeyName(19, "search_brown.png");
            imageList1.Images.SetKeyName(20, "settings_40dp.png");
            imageList1.Images.SetKeyName(21, "settings_brown.png");
            imageList1.Images.SetKeyName(22, "settings_White.png");
            imageList1.Images.SetKeyName(23, "view_list_40dp.png");
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(moneyLabelProgText);
            materialCard3.Controls.Add(MoneyLabelProg);
            materialCard3.Controls.Add(moneyLabel);
            materialCard3.Controls.Add(mlabel);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(717, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(294, 128);
            materialCard3.TabIndex = 0;
            // 
            // moneyLabelProgText
            // 
            moneyLabelProgText.AutoSize = true;
            moneyLabelProgText.Depth = 0;
            moneyLabelProgText.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            moneyLabelProgText.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            moneyLabelProgText.Location = new Point(17, 95);
            moneyLabelProgText.MouseState = MaterialSkin.MouseState.HOVER;
            moneyLabelProgText.Name = "moneyLabelProgText";
            moneyLabelProgText.Size = new Size(170, 14);
            moneyLabelProgText.TabIndex = 3;
            moneyLabelProgText.Text = "50% бюджета израсходовано";
            moneyLabelProgText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MoneyLabelProg
            // 
            MoneyLabelProg.Depth = 0;
            MoneyLabelProg.Location = new Point(17, 86);
            MoneyLabelProg.MouseState = MaterialSkin.MouseState.HOVER;
            MoneyLabelProg.Name = "MoneyLabelProg";
            MoneyLabelProg.Size = new Size(262, 5);
            MoneyLabelProg.TabIndex = 2;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoEllipsis = true;
            moneyLabel.Depth = 0;
            moneyLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            moneyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            moneyLabel.ImageAlign = ContentAlignment.MiddleLeft;
            moneyLabel.Location = new Point(17, 43);
            moneyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(260, 40);
            moneyLabel.TabIndex = 1;
            moneyLabel.Text = "Какойто текст";
            moneyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mlabel
            // 
            mlabel.AutoSize = true;
            mlabel.Depth = 0;
            mlabel.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mlabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            mlabel.Location = new Point(17, 14);
            mlabel.MouseState = MaterialSkin.MouseState.HOVER;
            mlabel.Name = "mlabel";
            mlabel.Size = new Size(190, 19);
            mlabel.TabIndex = 0;
            mlabel.Text = "Доход в текущем месяце";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(leftMoneyProgLabel);
            materialCard1.Controls.Add(leftMoneyProgress);
            materialCard1.Controls.Add(leftmoney);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(326, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(294, 128);
            materialCard1.TabIndex = 0;
            // 
            // leftMoneyProgLabel
            // 
            leftMoneyProgLabel.AutoSize = true;
            leftMoneyProgLabel.Depth = 0;
            leftMoneyProgLabel.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Pixel);
            leftMoneyProgLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            leftMoneyProgLabel.Location = new Point(17, 95);
            leftMoneyProgLabel.MouseState = MaterialSkin.MouseState.HOVER;
            leftMoneyProgLabel.Name = "leftMoneyProgLabel";
            leftMoneyProgLabel.Size = new Size(170, 14);
            leftMoneyProgLabel.TabIndex = 3;
            leftMoneyProgLabel.Text = "50% бюджета израсходовано";
            leftMoneyProgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftMoneyProgress
            // 
            leftMoneyProgress.Depth = 0;
            leftMoneyProgress.Location = new Point(17, 86);
            leftMoneyProgress.MouseState = MaterialSkin.MouseState.HOVER;
            leftMoneyProgress.Name = "leftMoneyProgress";
            leftMoneyProgress.Size = new Size(262, 5);
            leftMoneyProgress.TabIndex = 2;
            // 
            // leftmoney
            // 
            leftmoney.AutoEllipsis = true;
            leftmoney.Depth = 0;
            leftmoney.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            leftmoney.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            leftmoney.ImageAlign = ContentAlignment.MiddleLeft;
            leftmoney.Location = new Point(17, 43);
            leftmoney.MouseState = MaterialSkin.MouseState.HOVER;
            leftmoney.Name = "leftmoney";
            leftmoney.Size = new Size(260, 40);
            leftmoney.TabIndex = 1;
            leftmoney.Text = "Какойто текст";
            leftmoney.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(17, 14);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(196, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Расход в текущем месяце";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialCard4);
            tabPage2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage2.ImageKey = "view_list_40dp.png";
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1085, 460);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Транзакции";
            tabPage2.ToolTipText = "Транзакции";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(transactionList);
            materialCard4.Depth = 0;
            materialCard4.Dock = DockStyle.Fill;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(3, 3);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(1079, 454);
            materialCard4.TabIndex = 1;
            // 
            // transactionList
            // 
            transactionList.AutoSizeTable = false;
            transactionList.BackColor = Color.FromArgb(255, 255, 255);
            transactionList.BorderStyle = BorderStyle.None;
            transactionList.Columns.AddRange(new ColumnHeader[] { trId, trName, Desc, acc, amount, date, trType, category });
            transactionList.ContextMenuStrip = transactionMenu;
            transactionList.Depth = 0;
            transactionList.Dock = DockStyle.Fill;
            transactionList.FullRowSelect = true;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            transactionList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            transactionList.Location = new Point(14, 14);
            transactionList.MinimumSize = new Size(200, 100);
            transactionList.MouseLocation = new Point(-1, -1);
            transactionList.MouseState = MaterialSkin.MouseState.OUT;
            transactionList.Name = "transactionList";
            transactionList.OwnerDraw = true;
            transactionList.Size = new Size(1051, 426);
            transactionList.TabIndex = 2;
            transactionList.UseCompatibleStateImageBehavior = false;
            transactionList.View = View.Details;
            transactionList.SelectedIndexChanged += TransactionList_SelectedIndexChanged;
            // 
            // acc
            // 
            acc.Text = "Счет";
            acc.Width = 150;
            // 
            // amount
            // 
            amount.Text = "Сумма";
            amount.Width = 150;
            // 
            // date
            // 
            date.Text = "Дата";
            date.Width = 130;
            // 
            // category
            // 
            category.Text = "Категория";
            category.Width = 100;
            // 
            // transactionMenu
            // 
            transactionMenu.Items.AddRange(new ToolStripItem[] { deleteTrMenuItem, addTrMenuItem, showMenuItem });
            transactionMenu.Name = "transactionMenu";
            transactionMenu.Size = new Size(132, 70);
            // 
            // deleteTrMenuItem
            // 
            deleteTrMenuItem.Image = Properties.Resources.delete_40dp;
            deleteTrMenuItem.Name = "deleteTrMenuItem";
            deleteTrMenuItem.Size = new Size(131, 22);
            deleteTrMenuItem.Text = "Удалить";
            deleteTrMenuItem.Click += DeleteTRMenuItem_Click;
            // 
            // addTrMenuItem
            // 
            addTrMenuItem.Image = Properties.Resources.add_brown;
            addTrMenuItem.Name = "addTrMenuItem";
            addTrMenuItem.Size = new Size(131, 22);
            addTrMenuItem.Text = "Добавить";
            addTrMenuItem.Click += addTrantaction_Click;
            // 
            // showMenuItem
            // 
            showMenuItem.Image = Properties.Resources.description_40dp;
            showMenuItem.Name = "showMenuItem";
            showMenuItem.Size = new Size(131, 22);
            showMenuItem.Text = "Просмотр";
            showMenuItem.Click += ShowTRMenuItem_Click;
            // 
            // accsCollection
            // 
            accsCollection.Controls.Add(accsListView);
            accsCollection.ImageKey = "account_circle_40dp.png";
            accsCollection.Location = new Point(4, 33);
            accsCollection.Name = "accsCollection";
            accsCollection.Padding = new Padding(3);
            accsCollection.Size = new Size(1085, 460);
            accsCollection.TabIndex = 2;
            accsCollection.Text = "Мои счета";
            accsCollection.UseVisualStyleBackColor = true;
            // 
            // accsListView
            // 
            accsListView.AutoSizeTable = false;
            accsListView.BackColor = Color.FromArgb(255, 255, 255);
            accsListView.BorderStyle = BorderStyle.None;
            accsListView.Columns.AddRange(new ColumnHeader[] { id, name, type, balance });
            accsListView.ContextMenuStrip = accMenuStrip;
            accsListView.Depth = 0;
            accsListView.Dock = DockStyle.Fill;
            accsListView.FullRowSelect = true;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            accsListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            accsListView.Location = new Point(3, 3);
            accsListView.MinimumSize = new Size(200, 100);
            accsListView.MouseLocation = new Point(-1, -1);
            accsListView.MouseState = MaterialSkin.MouseState.OUT;
            accsListView.Name = "accsListView";
            accsListView.OwnerDraw = true;
            accsListView.Size = new Size(1079, 454);
            accsListView.TabIndex = 1;
            accsListView.UseCompatibleStateImageBehavior = false;
            accsListView.View = View.Details;
            accsListView.SelectedIndexChanged += AccsListView_SelectedIndexChanged;
            // 
            // accMenuStrip
            // 
            accMenuStrip.Items.AddRange(new ToolStripItem[] { deleteMenuItem, addMenuItem });
            accMenuStrip.Name = "contextMenuStrip1";
            accMenuStrip.Size = new Size(127, 48);
            // 
            // deleteMenuItem
            // 
            deleteMenuItem.Image = Properties.Resources.delete_40dp;
            deleteMenuItem.Name = "deleteMenuItem";
            deleteMenuItem.Size = new Size(126, 22);
            deleteMenuItem.Text = "Удалить";
            deleteMenuItem.Click += DeleteMenuItem_Click;
            // 
            // addMenuItem
            // 
            addMenuItem.Image = Properties.Resources.add_brown;
            addMenuItem.ImageTransparentColor = Color.Black;
            addMenuItem.Name = "addMenuItem";
            addMenuItem.Size = new Size(126, 22);
            addMenuItem.Text = "Добавить";
            addMenuItem.Click += addAcc_Click;
            // 
            // logout
            // 
            logout.ImageKey = "logout_40dp.png";
            logout.Location = new Point(4, 33);
            logout.Name = "logout";
            logout.Padding = new Padding(3);
            logout.Size = new Size(1085, 460);
            logout.TabIndex = 3;
            logout.Text = "Выход";
            logout.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1096, 564);
            Controls.Add(tabs);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabs;
            DrawerUseColors = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(1041, 549);
            Name = "MainPage";
            Padding = new Padding(0, 64, 3, 3);
            Sizable = false;
            Text = "Мониторинг личных финансов";
            WindowState = FormWindowState.Minimized;
            tabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabPage2.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            transactionMenu.ResumeLayout(false);
            accsCollection.ResumeLayout(false);
            accMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel leftmoney;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel leftMoneyProgLabel;
        private MaterialSkin.Controls.MaterialProgressBar leftMoneyProgress;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel moneyLabelProgText;
        private MaterialSkin.Controls.MaterialLabel moneyLabel;
        private MaterialSkin.Controls.MaterialLabel mlabel;
        private LiveCharts.WinForms.CartesianChart categoriesChart;
        private LiveCharts.WinForms.CartesianChart dateChart;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton addTrantaction;
        private MaterialSkin.Controls.MaterialComboBox accsComboBox;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel savedMoney;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialProgressBar MoneyLabelProg;
        private MaterialSkin.Controls.MaterialButton addCategory;
        private MaterialSkin.Controls.MaterialButton addAcc;
        private TabPage accsCollection;
        private ColumnHeader name;
        private ColumnHeader type;
        private ColumnHeader balance;
        private TabPage logout;
        internal MaterialSkin.Controls.MaterialListView accsListView;
        private ContextMenuStrip accMenuStrip;
        private ToolStripMenuItem deleteMenuItem;
        private ToolStripMenuItem addMenuItem;
        internal MaterialSkin.Controls.MaterialListView transactionList;
        private ColumnHeader amount;
        private ColumnHeader date;
        private ContextMenuStrip transactionMenu;
        private ToolStripMenuItem deleteTrMenuItem;
        private ToolStripMenuItem addTrMenuItem;
        private ToolStripMenuItem showMenuItem;
        private ColumnHeader category;
        private ColumnHeader acc;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private DateTimePicker currentDate;
        private MaterialSkin.Controls.MaterialLabel dateLabel;
    }
}