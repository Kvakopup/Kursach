namespace SanyaNewHopev2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChooseUniver = new System.Windows.Forms.ComboBox();
            this.ChooseFac = new System.Windows.Forms.ComboBox();
            this.ChooseSpec = new System.Windows.Forms.ComboBox();
            this.ZNO1Name = new System.Windows.Forms.TextBox();
            this.AtestatInput = new System.Windows.Forms.TextBox();
            this.ZNO3Name = new System.Windows.Forms.TextBox();
            this.koef1 = new System.Windows.Forms.NumericUpDown();
            this.AtestatKoef = new System.Windows.Forms.NumericUpDown();
            this.koef3 = new System.Windows.Forms.NumericUpDown();
            this.koef2 = new System.Windows.Forms.NumericUpDown();
            this.ZNO1Mark = new System.Windows.Forms.NumericUpDown();
            this.ZNO2Mark = new System.Windows.Forms.NumericUpDown();
            this.ZNO3Mark = new System.Windows.Forms.NumericUpDown();
            this.ZNO4Mark = new System.Windows.Forms.NumericUpDown();
            this.getRezult = new System.Windows.Forms.Button();
            this.rezultbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZNO2Name = new System.Windows.Forms.ListBox();
            this.Verdict = new System.Windows.Forms.Label();
            this.MainDisplay = new System.Windows.Forms.RichTextBox();
            this.VNZ = new System.Windows.Forms.Label();
            this.Facult = new System.Windows.Forms.Label();
            this.Spec = new System.Windows.Forms.Label();
            this.SPECforsearch = new System.Windows.Forms.ComboBox();
            this.FACforsearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalVUZ = new System.Windows.Forms.TextBox();
            this.SpecSearchResult = new System.Windows.Forms.RichTextBox();
            this.FacSearchResult = new System.Windows.Forms.RichTextBox();
            this.BalSearch = new System.Windows.Forms.Button();
            this.BalSearchResult = new System.Windows.Forms.RichTextBox();
            this.ContractPriceSearch = new System.Windows.Forms.Button();
            this.ContractPriceSearchResult = new System.Windows.Forms.RichTextBox();
            this.ContractPriceInput = new System.Windows.Forms.NumericUpDown();
            this.BalInput = new System.Windows.Forms.NumericUpDown();
            this.VedictBal = new System.Windows.Forms.Label();
            this.VerdictPay = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ResetPay = new System.Windows.Forms.Button();
            this.Resetmark = new System.Windows.Forms.Button();
            this.ResetFac = new System.Windows.Forms.Button();
            this.ResetSpec = new System.Windows.Forms.Button();
            this.ShowPanel = new System.Windows.Forms.RichTextBox();
            this.SaveRichtextBox = new System.Windows.Forms.Button();
            this.ClearShowPanel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.koef1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtestatKoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koef3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koef2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO1Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO2Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO3Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO4Mark)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractPriceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalInput)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseUniver
            // 
            this.ChooseUniver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseUniver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseUniver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseUniver.FormattingEnabled = true;
            this.ChooseUniver.Location = new System.Drawing.Point(20, 102);
            this.ChooseUniver.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseUniver.Name = "ChooseUniver";
            this.ChooseUniver.Size = new System.Drawing.Size(267, 31);
            this.ChooseUniver.TabIndex = 0;
            this.ChooseUniver.SelectedIndexChanged += new System.EventHandler(this.ChooseUniver_SelectedIndexChanged);
            // 
            // ChooseFac
            // 
            this.ChooseFac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseFac.DropDownWidth = 350;
            this.ChooseFac.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFac.FormattingEnabled = true;
            this.ChooseFac.Location = new System.Drawing.Point(320, 102);
            this.ChooseFac.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseFac.MaxDropDownItems = 10;
            this.ChooseFac.Name = "ChooseFac";
            this.ChooseFac.Size = new System.Drawing.Size(267, 31);
            this.ChooseFac.TabIndex = 1;
            this.ChooseFac.SelectedIndexChanged += new System.EventHandler(this.ChooseFac_SelectedIndexChanged);
            // 
            // ChooseSpec
            // 
            this.ChooseSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseSpec.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseSpec.FormattingEnabled = true;
            this.ChooseSpec.Location = new System.Drawing.Point(613, 102);
            this.ChooseSpec.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseSpec.Name = "ChooseSpec";
            this.ChooseSpec.Size = new System.Drawing.Size(289, 31);
            this.ChooseSpec.TabIndex = 2;
            this.ChooseSpec.SelectedIndexChanged += new System.EventHandler(this.ChooseSpec_SelectedIndexChanged);
            // 
            // ZNO1Name
            // 
            this.ZNO1Name.Location = new System.Drawing.Point(19, 16);
            this.ZNO1Name.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO1Name.Name = "ZNO1Name";
            this.ZNO1Name.ReadOnly = true;
            this.ZNO1Name.Size = new System.Drawing.Size(120, 22);
            this.ZNO1Name.TabIndex = 3;
            this.ZNO1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AtestatInput
            // 
            this.AtestatInput.Location = new System.Drawing.Point(521, 16);
            this.AtestatInput.Margin = new System.Windows.Forms.Padding(4);
            this.AtestatInput.Name = "AtestatInput";
            this.AtestatInput.ReadOnly = true;
            this.AtestatInput.Size = new System.Drawing.Size(120, 22);
            this.AtestatInput.TabIndex = 4;
            this.AtestatInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ZNO3Name
            // 
            this.ZNO3Name.Location = new System.Drawing.Point(177, 16);
            this.ZNO3Name.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO3Name.Name = "ZNO3Name";
            this.ZNO3Name.ReadOnly = true;
            this.ZNO3Name.Size = new System.Drawing.Size(120, 22);
            this.ZNO3Name.TabIndex = 5;
            this.ZNO3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // koef1
            // 
            this.koef1.DecimalPlaces = 2;
            this.koef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koef1.InterceptArrowKeys = false;
            this.koef1.Location = new System.Drawing.Point(19, 139);
            this.koef1.Margin = new System.Windows.Forms.Padding(4);
            this.koef1.Name = "koef1";
            this.koef1.ReadOnly = true;
            this.koef1.Size = new System.Drawing.Size(119, 29);
            this.koef1.TabIndex = 11;
            this.koef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AtestatKoef
            // 
            this.AtestatKoef.DecimalPlaces = 2;
            this.AtestatKoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AtestatKoef.Location = new System.Drawing.Point(521, 139);
            this.AtestatKoef.Margin = new System.Windows.Forms.Padding(4);
            this.AtestatKoef.Name = "AtestatKoef";
            this.AtestatKoef.ReadOnly = true;
            this.AtestatKoef.Size = new System.Drawing.Size(121, 29);
            this.AtestatKoef.TabIndex = 12;
            this.AtestatKoef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // koef3
            // 
            this.koef3.DecimalPlaces = 2;
            this.koef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koef3.Location = new System.Drawing.Point(344, 139);
            this.koef3.Margin = new System.Windows.Forms.Padding(4);
            this.koef3.Name = "koef3";
            this.koef3.ReadOnly = true;
            this.koef3.Size = new System.Drawing.Size(121, 29);
            this.koef3.TabIndex = 13;
            this.koef3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // koef2
            // 
            this.koef2.DecimalPlaces = 2;
            this.koef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koef2.Location = new System.Drawing.Point(177, 139);
            this.koef2.Margin = new System.Windows.Forms.Padding(4);
            this.koef2.Name = "koef2";
            this.koef2.ReadOnly = true;
            this.koef2.Size = new System.Drawing.Size(121, 29);
            this.koef2.TabIndex = 14;
            this.koef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ZNO1Mark
            // 
            this.ZNO1Mark.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZNO1Mark.Location = new System.Drawing.Point(19, 75);
            this.ZNO1Mark.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO1Mark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ZNO1Mark.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZNO1Mark.Name = "ZNO1Mark";
            this.ZNO1Mark.Size = new System.Drawing.Size(119, 31);
            this.ZNO1Mark.TabIndex = 15;
            this.ZNO1Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZNO1Mark.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ZNO2Mark
            // 
            this.ZNO2Mark.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZNO2Mark.Location = new System.Drawing.Point(177, 75);
            this.ZNO2Mark.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO2Mark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ZNO2Mark.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZNO2Mark.Name = "ZNO2Mark";
            this.ZNO2Mark.Size = new System.Drawing.Size(121, 31);
            this.ZNO2Mark.TabIndex = 16;
            this.ZNO2Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZNO2Mark.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ZNO3Mark
            // 
            this.ZNO3Mark.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZNO3Mark.Location = new System.Drawing.Point(344, 75);
            this.ZNO3Mark.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO3Mark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ZNO3Mark.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZNO3Mark.Name = "ZNO3Mark";
            this.ZNO3Mark.Size = new System.Drawing.Size(121, 31);
            this.ZNO3Mark.TabIndex = 17;
            this.ZNO3Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZNO3Mark.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ZNO4Mark
            // 
            this.ZNO4Mark.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZNO4Mark.Location = new System.Drawing.Point(521, 75);
            this.ZNO4Mark.Margin = new System.Windows.Forms.Padding(4);
            this.ZNO4Mark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ZNO4Mark.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZNO4Mark.Name = "ZNO4Mark";
            this.ZNO4Mark.Size = new System.Drawing.Size(121, 31);
            this.ZNO4Mark.TabIndex = 18;
            this.ZNO4Mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZNO4Mark.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // getRezult
            // 
            this.getRezult.Location = new System.Drawing.Point(51, 215);
            this.getRezult.Margin = new System.Windows.Forms.Padding(4);
            this.getRezult.Name = "getRezult";
            this.getRezult.Size = new System.Drawing.Size(129, 43);
            this.getRezult.TabIndex = 19;
            this.getRezult.Text = "Розрахувати";
            this.getRezult.UseVisualStyleBackColor = true;
            this.getRezult.Click += new System.EventHandler(this.getRezult_Click);
            // 
            // rezultbox
            // 
            this.rezultbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rezultbox.Location = new System.Drawing.Point(275, 220);
            this.rezultbox.Margin = new System.Windows.Forms.Padding(4);
            this.rezultbox.Name = "rezultbox";
            this.rezultbox.ReadOnly = true;
            this.rezultbox.Size = new System.Drawing.Size(85, 34);
            this.rezultbox.TabIndex = 20;
            this.rezultbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.ZNO2Name);
            this.panel1.Controls.Add(this.Verdict);
            this.panel1.Controls.Add(this.rezultbox);
            this.panel1.Controls.Add(this.getRezult);
            this.panel1.Controls.Add(this.ZNO4Mark);
            this.panel1.Controls.Add(this.ZNO3Mark);
            this.panel1.Controls.Add(this.ZNO2Mark);
            this.panel1.Controls.Add(this.ZNO1Mark);
            this.panel1.Controls.Add(this.koef2);
            this.panel1.Controls.Add(this.koef3);
            this.panel1.Controls.Add(this.AtestatKoef);
            this.panel1.Controls.Add(this.koef1);
            this.panel1.Controls.Add(this.ZNO3Name);
            this.panel1.Controls.Add(this.AtestatInput);
            this.panel1.Controls.Add(this.ZNO1Name);
            this.panel1.Location = new System.Drawing.Point(45, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 278);
            this.panel1.TabIndex = 21;
            // 
            // ZNO2Name
            // 
            this.ZNO2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZNO2Name.FormattingEnabled = true;
            this.ZNO2Name.ItemHeight = 18;
            this.ZNO2Name.Location = new System.Drawing.Point(349, 18);
            this.ZNO2Name.Name = "ZNO2Name";
            this.ZNO2Name.Size = new System.Drawing.Size(133, 40);
            this.ZNO2Name.TabIndex = 94;
            // 
            // Verdict
            // 
            this.Verdict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verdict.Location = new System.Drawing.Point(408, 191);
            this.Verdict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Verdict.Name = "Verdict";
            this.Verdict.Size = new System.Drawing.Size(235, 66);
            this.Verdict.TabIndex = 21;
            this.Verdict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainDisplay
            // 
            this.MainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDisplay.Location = new System.Drawing.Point(795, 169);
            this.MainDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.ReadOnly = true;
            this.MainDisplay.Size = new System.Drawing.Size(437, 287);
            this.MainDisplay.TabIndex = 30;
            this.MainDisplay.Text = "";
            // 
            // VNZ
            // 
            this.VNZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VNZ.BackColor = System.Drawing.Color.OliveDrab;
            this.VNZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VNZ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VNZ.Location = new System.Drawing.Point(74, 42);
            this.VNZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VNZ.Name = "VNZ";
            this.VNZ.Size = new System.Drawing.Size(127, 36);
            this.VNZ.TabIndex = 36;
            this.VNZ.Text = "ВНЗ";
            this.VNZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facult
            // 
            this.Facult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Facult.BackColor = System.Drawing.Color.OliveDrab;
            this.Facult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Facult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Facult.Location = new System.Drawing.Point(384, 42);
            this.Facult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Facult.Name = "Facult";
            this.Facult.Size = new System.Drawing.Size(127, 36);
            this.Facult.TabIndex = 37;
            this.Facult.Text = "Факультет";
            this.Facult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spec
            // 
            this.Spec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Spec.BackColor = System.Drawing.Color.OliveDrab;
            this.Spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spec.Location = new System.Drawing.Point(674, 42);
            this.Spec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Spec.Name = "Spec";
            this.Spec.Size = new System.Drawing.Size(172, 36);
            this.Spec.TabIndex = 38;
            this.Spec.Text = "Спеціальність";
            this.Spec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPECforsearch
            // 
            this.SPECforsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SPECforsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPECforsearch.DropDownWidth = 450;
            this.SPECforsearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SPECforsearch.FormattingEnabled = true;
            this.SPECforsearch.Location = new System.Drawing.Point(1081, 529);
            this.SPECforsearch.Margin = new System.Windows.Forms.Padding(4);
            this.SPECforsearch.Name = "SPECforsearch";
            this.SPECforsearch.Size = new System.Drawing.Size(196, 31);
            this.SPECforsearch.TabIndex = 42;
            this.SPECforsearch.SelectedIndexChanged += new System.EventHandler(this.SPECforsearch_SelectedIndexChanged);
            // 
            // FACforsearch
            // 
            this.FACforsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FACforsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FACforsearch.DropDownWidth = 450;
            this.FACforsearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FACforsearch.FormattingEnabled = true;
            this.FACforsearch.Location = new System.Drawing.Point(738, 531);
            this.FACforsearch.Margin = new System.Windows.Forms.Padding(4);
            this.FACforsearch.Name = "FACforsearch";
            this.FACforsearch.Size = new System.Drawing.Size(196, 31);
            this.FACforsearch.TabIndex = 43;
            this.FACforsearch.SelectedIndexChanged += new System.EventHandler(this.FACforsearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1093, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Спеціальність";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.OliveDrab;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(744, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 45;
            this.label2.Text = "Факультет\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalVUZ
            // 
            this.FinalVUZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalVUZ.Location = new System.Drawing.Point(952, 137);
            this.FinalVUZ.Margin = new System.Windows.Forms.Padding(4);
            this.FinalVUZ.Name = "FinalVUZ";
            this.FinalVUZ.ReadOnly = true;
            this.FinalVUZ.Size = new System.Drawing.Size(97, 22);
            this.FinalVUZ.TabIndex = 46;
            this.FinalVUZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpecSearchResult
            // 
            this.SpecSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecSearchResult.Location = new System.Drawing.Point(1022, 572);
            this.SpecSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.SpecSearchResult.Name = "SpecSearchResult";
            this.SpecSearchResult.ReadOnly = true;
            this.SpecSearchResult.Size = new System.Drawing.Size(328, 221);
            this.SpecSearchResult.TabIndex = 47;
            this.SpecSearchResult.Text = "";
            // 
            // FacSearchResult
            // 
            this.FacSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FacSearchResult.Location = new System.Drawing.Point(665, 572);
            this.FacSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.FacSearchResult.Name = "FacSearchResult";
            this.FacSearchResult.ReadOnly = true;
            this.FacSearchResult.Size = new System.Drawing.Size(328, 221);
            this.FacSearchResult.TabIndex = 48;
            this.FacSearchResult.Text = "";
            // 
            // BalSearch
            // 
            this.BalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalSearch.Location = new System.Drawing.Point(379, 574);
            this.BalSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BalSearch.Name = "BalSearch";
            this.BalSearch.Size = new System.Drawing.Size(148, 23);
            this.BalSearch.TabIndex = 50;
            this.BalSearch.Text = "Знайти";
            this.BalSearch.UseVisualStyleBackColor = true;
            this.BalSearch.Click += new System.EventHandler(this.BalSearch_Click);
            // 
            // BalSearchResult
            // 
            this.BalSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalSearchResult.Location = new System.Drawing.Point(338, 610);
            this.BalSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.BalSearchResult.Name = "BalSearchResult";
            this.BalSearchResult.ReadOnly = true;
            this.BalSearchResult.Size = new System.Drawing.Size(249, 184);
            this.BalSearchResult.TabIndex = 51;
            this.BalSearchResult.Text = "";
            // 
            // ContractPriceSearch
            // 
            this.ContractPriceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractPriceSearch.Location = new System.Drawing.Point(93, 570);
            this.ContractPriceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ContractPriceSearch.Name = "ContractPriceSearch";
            this.ContractPriceSearch.Size = new System.Drawing.Size(132, 27);
            this.ContractPriceSearch.TabIndex = 53;
            this.ContractPriceSearch.Text = "Знайти";
            this.ContractPriceSearch.UseVisualStyleBackColor = true;
            this.ContractPriceSearch.Click += new System.EventHandler(this.ContractPriceSearch_Click);
            // 
            // ContractPriceSearchResult
            // 
            this.ContractPriceSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractPriceSearchResult.Location = new System.Drawing.Point(30, 610);
            this.ContractPriceSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.ContractPriceSearchResult.Name = "ContractPriceSearchResult";
            this.ContractPriceSearchResult.ReadOnly = true;
            this.ContractPriceSearchResult.Size = new System.Drawing.Size(249, 184);
            this.ContractPriceSearchResult.TabIndex = 54;
            this.ContractPriceSearchResult.Text = "";
            // 
            // ContractPriceInput
            // 
            this.ContractPriceInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContractPriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContractPriceInput.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ContractPriceInput.Location = new System.Drawing.Point(93, 532);
            this.ContractPriceInput.Margin = new System.Windows.Forms.Padding(4);
            this.ContractPriceInput.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ContractPriceInput.Name = "ContractPriceInput";
            this.ContractPriceInput.Size = new System.Drawing.Size(132, 30);
            this.ContractPriceInput.TabIndex = 55;
            this.ContractPriceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BalInput
            // 
            this.BalInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalInput.Location = new System.Drawing.Point(383, 540);
            this.BalInput.Margin = new System.Windows.Forms.Padding(4);
            this.BalInput.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BalInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BalInput.Name = "BalInput";
            this.BalInput.Size = new System.Drawing.Size(143, 29);
            this.BalInput.TabIndex = 56;
            this.BalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BalInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // VedictBal
            // 
            this.VedictBal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VedictBal.Location = new System.Drawing.Point(338, 798);
            this.VedictBal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VedictBal.Name = "VedictBal";
            this.VedictBal.Size = new System.Drawing.Size(249, 39);
            this.VedictBal.TabIndex = 57;
            this.VedictBal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerdictPay
            // 
            this.VerdictPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerdictPay.Location = new System.Drawing.Point(30, 798);
            this.VerdictPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerdictPay.Name = "VerdictPay";
            this.VerdictPay.Size = new System.Drawing.Size(249, 39);
            this.VerdictPay.TabIndex = 58;
            this.VerdictPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.OliveDrab;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(37, 489);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 36);
            this.label15.TabIndex = 94;
            this.label15.Text = " За контрактом";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.OliveDrab;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(374, 489);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 36);
            this.label16.TabIndex = 95;
            this.label16.Text = "Конкурсний бал";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetPay
            // 
            this.ResetPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetPay.Location = new System.Drawing.Point(96, 849);
            this.ResetPay.Name = "ResetPay";
            this.ResetPay.Size = new System.Drawing.Size(93, 36);
            this.ResetPay.TabIndex = 101;
            this.ResetPay.Text = "Видалити";
            this.ResetPay.UseVisualStyleBackColor = true;
            this.ResetPay.Click += new System.EventHandler(this.ResetPay_Click);
            // 
            // Resetmark
            // 
            this.Resetmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resetmark.Location = new System.Drawing.Point(404, 849);
            this.Resetmark.Name = "Resetmark";
            this.Resetmark.Size = new System.Drawing.Size(106, 36);
            this.Resetmark.TabIndex = 102;
            this.Resetmark.Text = "Видалити";
            this.Resetmark.UseVisualStyleBackColor = true;
            this.Resetmark.Click += new System.EventHandler(this.Resetmark_Click);
            // 
            // ResetFac
            // 
            this.ResetFac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetFac.Location = new System.Drawing.Point(771, 844);
            this.ResetFac.Name = "ResetFac";
            this.ResetFac.Size = new System.Drawing.Size(107, 41);
            this.ResetFac.TabIndex = 103;
            this.ResetFac.Text = "Видалити";
            this.ResetFac.UseVisualStyleBackColor = true;
            this.ResetFac.Click += new System.EventHandler(this.ResetFac_Click);
            // 
            // ResetSpec
            // 
            this.ResetSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetSpec.Location = new System.Drawing.Point(1125, 844);
            this.ResetSpec.Name = "ResetSpec";
            this.ResetSpec.Size = new System.Drawing.Size(107, 41);
            this.ResetSpec.TabIndex = 104;
            this.ResetSpec.Text = "Видалити";
            this.ResetSpec.UseVisualStyleBackColor = true;
            this.ResetSpec.Click += new System.EventHandler(this.ResetSpec_Click);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.ShowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPanel.Location = new System.Drawing.Point(16, 13);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.ReadOnly = true;
            this.ShowPanel.Size = new System.Drawing.Size(329, 285);
            this.ShowPanel.TabIndex = 106;
            this.ShowPanel.Text = "";
            this.ShowPanel.Visible = false;
            // 
            // SaveRichtextBox
            // 
            this.SaveRichtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveRichtextBox.Location = new System.Drawing.Point(183, 316);
            this.SaveRichtextBox.Name = "SaveRichtextBox";
            this.SaveRichtextBox.Size = new System.Drawing.Size(143, 32);
            this.SaveRichtextBox.TabIndex = 108;
            this.SaveRichtextBox.Text = "Зберегти у файл";
            this.SaveRichtextBox.UseVisualStyleBackColor = true;
            this.SaveRichtextBox.Visible = false;
            this.SaveRichtextBox.Click += new System.EventHandler(this.SaveRichtextBox_Click);
            // 
            // ClearShowPanel
            // 
            this.ClearShowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearShowPanel.Location = new System.Drawing.Point(50, 316);
            this.ClearShowPanel.Name = "ClearShowPanel";
            this.ClearShowPanel.Size = new System.Drawing.Size(97, 32);
            this.ClearShowPanel.TabIndex = 109;
            this.ClearShowPanel.Text = "Очистити";
            this.ClearShowPanel.UseVisualStyleBackColor = true;
            this.ClearShowPanel.Visible = false;
            this.ClearShowPanel.Click += new System.EventHandler(this.ClearShowPanel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1817, 27);
            this.toolStrip1.TabIndex = 110;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(137, 24);
            this.toolStripButton1.Text = "Куди мене взяли?";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(113, 24);
            this.toolStripButton2.Text = "Адміністратор";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.ShowPanel);
            this.panel2.Controls.Add(this.ClearShowPanel);
            this.panel2.Controls.Add(this.SaveRichtextBox);
            this.panel2.Location = new System.Drawing.Point(1328, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 367);
            this.panel2.TabIndex = 111;
            this.panel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1817, 855);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ResetSpec);
            this.Controls.Add(this.ResetFac);
            this.Controls.Add(this.Resetmark);
            this.Controls.Add(this.ResetPay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.VerdictPay);
            this.Controls.Add(this.VedictBal);
            this.Controls.Add(this.BalInput);
            this.Controls.Add(this.ContractPriceInput);
            this.Controls.Add(this.ContractPriceSearchResult);
            this.Controls.Add(this.ContractPriceSearch);
            this.Controls.Add(this.BalSearchResult);
            this.Controls.Add(this.BalSearch);
            this.Controls.Add(this.FacSearchResult);
            this.Controls.Add(this.SpecSearchResult);
            this.Controls.Add(this.FinalVUZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FACforsearch);
            this.Controls.Add(this.SPECforsearch);
            this.Controls.Add(this.Spec);
            this.Controls.Add(this.Facult);
            this.Controls.Add(this.VNZ);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChooseSpec);
            this.Controls.Add(this.ChooseFac);
            this.Controls.Add(this.ChooseUniver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1835, 902);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абітпомагайко";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koef1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtestatKoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koef3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koef2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO1Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO2Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO3Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNO4Mark)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractPriceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalInput)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseUniver;
        private System.Windows.Forms.ComboBox ChooseFac;
        private System.Windows.Forms.ComboBox ChooseSpec;
        private System.Windows.Forms.TextBox ZNO1Name;
        private System.Windows.Forms.TextBox AtestatInput;
        private System.Windows.Forms.TextBox ZNO3Name;
        private System.Windows.Forms.NumericUpDown koef1;
        private System.Windows.Forms.NumericUpDown AtestatKoef;
        private System.Windows.Forms.NumericUpDown koef3;
        private System.Windows.Forms.NumericUpDown koef2;
        private System.Windows.Forms.NumericUpDown ZNO1Mark;
        private System.Windows.Forms.NumericUpDown ZNO2Mark;
        private System.Windows.Forms.NumericUpDown ZNO3Mark;
        private System.Windows.Forms.NumericUpDown ZNO4Mark;
        private System.Windows.Forms.Button getRezult;
        private System.Windows.Forms.TextBox rezultbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Verdict;
        private System.Windows.Forms.RichTextBox MainDisplay;
        private System.Windows.Forms.Label VNZ;
        private System.Windows.Forms.Label Facult;
        private System.Windows.Forms.Label Spec;
        private System.Windows.Forms.ComboBox SPECforsearch;
        private System.Windows.Forms.ComboBox FACforsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FinalVUZ;
        private System.Windows.Forms.RichTextBox SpecSearchResult;
        private System.Windows.Forms.RichTextBox FacSearchResult;
        private System.Windows.Forms.Button BalSearch;
        private System.Windows.Forms.RichTextBox BalSearchResult;
        private System.Windows.Forms.Button ContractPriceSearch;
        private System.Windows.Forms.RichTextBox ContractPriceSearchResult;
        private System.Windows.Forms.NumericUpDown ContractPriceInput;
        private System.Windows.Forms.NumericUpDown BalInput;
        private System.Windows.Forms.Label VedictBal;
        private System.Windows.Forms.Label VerdictPay;
        private System.Windows.Forms.ListBox ZNO2Name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ResetPay;
        private System.Windows.Forms.Button Resetmark;
        private System.Windows.Forms.Button ResetFac;
        private System.Windows.Forms.Button ResetSpec;
        private System.Windows.Forms.RichTextBox ShowPanel;
        private System.Windows.Forms.Button SaveRichtextBox;
        private System.Windows.Forms.Button ClearShowPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panel2;
    }
}

