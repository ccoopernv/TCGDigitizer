﻿namespace OCS_FOR_CSHARP
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cam_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Start_Video__Button = new System.Windows.Forms.Button();
            this.Display_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Preview_Label = new System.Windows.Forms.Label();
            this.Card_Boarder = new System.Windows.Forms.PictureBox();
            this.Name_Header_Pic_Box = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Card_Table_Panel = new System.Windows.Forms.TableLayoutPanel();
            this.Date_Button = new System.Windows.Forms.Button();
            this.Mana_Button = new System.Windows.Forms.Button();
            this.Number_Button = new System.Windows.Forms.Button();
            this.Expansion_Button = new System.Windows.Forms.Button();
            this.Type_Button = new System.Windows.Forms.Button();
            this.Name_Button = new System.Windows.Forms.Button();
            this.Inventory_Checkbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardPTLTextbox = new System.Windows.Forms.TextBox();
            this.cardLoyaltyLabel = new System.Windows.Forms.Label();
            this.cardPTLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card_Name_Label = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.ComboBox();
            this.cardSetLabel = new System.Windows.Forms.Label();
            this.Card_Set_Combobox = new System.Windows.Forms.ComboBox();
            this.cardTypeLabel = new System.Windows.Forms.Label();
            this.Card_Type_TextBox = new System.Windows.Forms.TextBox();
            this.cardTextLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cardFlavorLabel = new System.Windows.Forms.Label();
            this.cardFlavorTextbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cam_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Boarder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_Header_Pic_Box)).BeginInit();
            this.Card_Table_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(-3, 751);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(486, 272);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = ".";
            this.textBox1.TextChanged += new System.EventHandler(this.Tess_TextBox);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(-3, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 152);
            this.button1.TabIndex = 2;
            this.button1.Text = "Scan Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Take_Picture_Button_Click);
            // 
            // Cam_Picture_Box
            // 
            this.Cam_Picture_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.Cam_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cam_Picture_Box.Location = new System.Drawing.Point(2, 155);
            this.Cam_Picture_Box.Name = "Cam_Picture_Box";
            this.Cam_Picture_Box.Size = new System.Drawing.Size(473, 285);
            this.Cam_Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cam_Picture_Box.TabIndex = 3;
            this.Cam_Picture_Box.TabStop = false;
            this.Cam_Picture_Box.Click += new System.EventHandler(this.Webcam_Feed_Box);
            // 
            // Start_Video__Button
            // 
            this.Start_Video__Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Video__Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Video__Button.ForeColor = System.Drawing.Color.Silver;
            this.Start_Video__Button.Location = new System.Drawing.Point(-3, -3);
            this.Start_Video__Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start_Video__Button.Name = "Start_Video__Button";
            this.Start_Video__Button.Size = new System.Drawing.Size(488, 152);
            this.Start_Video__Button.TabIndex = 5;
            this.Start_Video__Button.Text = "Start Scanner";
            this.Start_Video__Button.UseVisualStyleBackColor = true;
            this.Start_Video__Button.Click += new System.EventHandler(this.Start_Video_Button_Click);
            // 
            // Display_Picture_Box
            // 
            this.Display_Picture_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.Display_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display_Picture_Box.Location = new System.Drawing.Point(14, 74);
            this.Display_Picture_Box.Name = "Display_Picture_Box";
            this.Display_Picture_Box.Size = new System.Drawing.Size(335, 479);
            this.Display_Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Display_Picture_Box.TabIndex = 6;
            this.Display_Picture_Box.TabStop = false;
            this.Display_Picture_Box.Click += new System.EventHandler(this.Display_Picture_Box_Click);
            // 
            // Preview_Label
            // 
            this.Preview_Label.AutoSize = true;
            this.Preview_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview_Label.ForeColor = System.Drawing.Color.Silver;
            this.Preview_Label.Location = new System.Drawing.Point(16, 11);
            this.Preview_Label.Name = "Preview_Label";
            this.Preview_Label.Size = new System.Drawing.Size(325, 58);
            this.Preview_Label.TabIndex = 7;
            this.Preview_Label.Text = "Card Preview";
            // 
            // Card_Boarder
            // 
            this.Card_Boarder.BackColor = System.Drawing.Color.Transparent;
            this.Card_Boarder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card_Boarder.Location = new System.Drawing.Point(45, 155);
            this.Card_Boarder.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Card_Boarder.Name = "Card_Boarder";
            this.Card_Boarder.Size = new System.Drawing.Size(383, 285);
            this.Card_Boarder.TabIndex = 8;
            this.Card_Boarder.TabStop = false;
            this.Card_Boarder.Click += new System.EventHandler(this.Card_Boarder_Click);
            // 
            // Name_Header_Pic_Box
            // 
            this.Name_Header_Pic_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.Name_Header_Pic_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Header_Pic_Box.Location = new System.Drawing.Point(-3, 595);
            this.Name_Header_Pic_Box.Name = "Name_Header_Pic_Box";
            this.Name_Header_Pic_Box.Size = new System.Drawing.Size(486, 147);
            this.Name_Header_Pic_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Name_Header_Pic_Box.TabIndex = 9;
            this.Name_Header_Pic_Box.TabStop = false;
            this.Name_Header_Pic_Box.Click += new System.EventHandler(this.Name_Header_Pic_Box_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(-3, 1034);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(488, 152);
            this.button2.TabIndex = 10;
            this.button2.Text = "Finish Scanning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Card_Table_Panel
            // 
            this.Card_Table_Panel.AutoSize = true;
            this.Card_Table_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card_Table_Panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Card_Table_Panel.ColumnCount = 7;
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.Card_Table_Panel.Controls.Add(this.Date_Button, 6, 0);
            this.Card_Table_Panel.Controls.Add(this.Mana_Button, 5, 0);
            this.Card_Table_Panel.Controls.Add(this.Number_Button, 4, 0);
            this.Card_Table_Panel.Controls.Add(this.Expansion_Button, 3, 0);
            this.Card_Table_Panel.Controls.Add(this.Type_Button, 2, 0);
            this.Card_Table_Panel.Controls.Add(this.Name_Button, 1, 0);
            this.Card_Table_Panel.Controls.Add(this.Inventory_Checkbox, 0, 0);
            this.Card_Table_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Card_Table_Panel.Location = new System.Drawing.Point(0, 0);
            this.Card_Table_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Card_Table_Panel.Name = "Card_Table_Panel";
            this.Card_Table_Panel.RowCount = 1;
            this.Card_Table_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.Card_Table_Panel.Size = new System.Drawing.Size(1131, 94);
            this.Card_Table_Panel.TabIndex = 18;
            // 
            // Date_Button
            // 
            this.Date_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_Button.FlatAppearance.BorderSize = 0;
            this.Date_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date_Button.ForeColor = System.Drawing.Color.Silver;
            this.Date_Button.Location = new System.Drawing.Point(956, 6);
            this.Date_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Date_Button.Name = "Date_Button";
            this.Date_Button.Size = new System.Drawing.Size(170, 82);
            this.Date_Button.TabIndex = 12;
            this.Date_Button.Text = "Date";
            this.Date_Button.UseVisualStyleBackColor = true;
            // 
            // Mana_Button
            // 
            this.Mana_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mana_Button.FlatAppearance.BorderSize = 0;
            this.Mana_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mana_Button.ForeColor = System.Drawing.Color.Silver;
            this.Mana_Button.Location = new System.Drawing.Point(778, 6);
            this.Mana_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mana_Button.Name = "Mana_Button";
            this.Mana_Button.Size = new System.Drawing.Size(169, 82);
            this.Mana_Button.TabIndex = 11;
            this.Mana_Button.Text = "Mana";
            this.Mana_Button.UseVisualStyleBackColor = true;
            // 
            // Number_Button
            // 
            this.Number_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Number_Button.FlatAppearance.BorderSize = 0;
            this.Number_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_Button.ForeColor = System.Drawing.Color.Silver;
            this.Number_Button.Location = new System.Drawing.Point(600, 6);
            this.Number_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Number_Button.Name = "Number_Button";
            this.Number_Button.Size = new System.Drawing.Size(169, 82);
            this.Number_Button.TabIndex = 10;
            this.Number_Button.Text = "Number";
            this.Number_Button.UseVisualStyleBackColor = true;
            // 
            // Expansion_Button
            // 
            this.Expansion_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Expansion_Button.FlatAppearance.BorderSize = 0;
            this.Expansion_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Expansion_Button.ForeColor = System.Drawing.Color.Silver;
            this.Expansion_Button.Location = new System.Drawing.Point(422, 6);
            this.Expansion_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Expansion_Button.Name = "Expansion_Button";
            this.Expansion_Button.Size = new System.Drawing.Size(169, 82);
            this.Expansion_Button.TabIndex = 9;
            this.Expansion_Button.Text = "Expansion";
            this.Expansion_Button.UseVisualStyleBackColor = true;
            // 
            // Type_Button
            // 
            this.Type_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type_Button.FlatAppearance.BorderSize = 0;
            this.Type_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_Button.ForeColor = System.Drawing.Color.Silver;
            this.Type_Button.Location = new System.Drawing.Point(244, 6);
            this.Type_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Type_Button.Name = "Type_Button";
            this.Type_Button.Size = new System.Drawing.Size(169, 82);
            this.Type_Button.TabIndex = 8;
            this.Type_Button.Text = "Type";
            this.Type_Button.UseVisualStyleBackColor = true;
            // 
            // Name_Button
            // 
            this.Name_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_Button.FlatAppearance.BorderSize = 0;
            this.Name_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_Button.ForeColor = System.Drawing.Color.Silver;
            this.Name_Button.Location = new System.Drawing.Point(66, 6);
            this.Name_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name_Button.Name = "Name_Button";
            this.Name_Button.Size = new System.Drawing.Size(169, 82);
            this.Name_Button.TabIndex = 7;
            this.Name_Button.Text = "Name";
            this.Name_Button.UseVisualStyleBackColor = true;
            // 
            // Inventory_Checkbox
            // 
            this.Inventory_Checkbox.AutoSize = true;
            this.Inventory_Checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Inventory_Checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inventory_Checkbox.FlatAppearance.BorderSize = 0;
            this.Inventory_Checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_Checkbox.ForeColor = System.Drawing.Color.Silver;
            this.Inventory_Checkbox.Location = new System.Drawing.Point(5, 6);
            this.Inventory_Checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inventory_Checkbox.Name = "Inventory_Checkbox";
            this.Inventory_Checkbox.Size = new System.Drawing.Size(52, 82);
            this.Inventory_Checkbox.TabIndex = 1;
            this.Inventory_Checkbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Card_Boarder);
            this.panel1.Controls.Add(this.Cam_Picture_Box);
            this.panel1.Controls.Add(this.Cancel_Button);
            this.panel1.Controls.Add(this.Name_Header_Pic_Box);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Start_Video__Button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1503, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 1462);
            this.panel1.TabIndex = 19;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.Silver;
            this.Cancel_Button.Location = new System.Drawing.Point(-3, 1186);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(488, 152);
            this.Cancel_Button.TabIndex = 17;
            this.Cancel_Button.Text = "Quit";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(756, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 58);
            this.label3.TabIndex = 20;
            this.label3.Text = "Scanned Cards";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.Preview_Label);
            this.panel2.Controls.Add(this.Display_Picture_Box);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 1462);
            this.panel2.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cardPTLTextbox);
            this.flowLayoutPanel2.Controls.Add(this.cardLoyaltyLabel);
            this.flowLayoutPanel2.Controls.Add(this.cardPTLabel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 1237);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(336, 95);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // cardPTLTextbox
            // 
            this.cardPTLTextbox.BackColor = System.Drawing.Color.SlateGray;
            this.cardPTLTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPTLTextbox.Location = new System.Drawing.Point(232, 5);
            this.cardPTLTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardPTLTextbox.Name = "cardPTLTextbox";
            this.cardPTLTextbox.ReadOnly = true;
            this.cardPTLTextbox.Size = new System.Drawing.Size(100, 35);
            this.cardPTLTextbox.TabIndex = 28;
            // 
            // cardLoyaltyLabel
            // 
            this.cardLoyaltyLabel.AutoSize = true;
            this.cardLoyaltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLoyaltyLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardLoyaltyLabel.Location = new System.Drawing.Point(128, 0);
            this.cardLoyaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardLoyaltyLabel.Name = "cardLoyaltyLabel";
            this.cardLoyaltyLabel.Padding = new System.Windows.Forms.Padding(0, 8, 3, 3);
            this.cardLoyaltyLabel.Size = new System.Drawing.Size(96, 40);
            this.cardLoyaltyLabel.TabIndex = 29;
            this.cardLoyaltyLabel.Text = "Loyalty:";
            // 
            // cardPTLabel
            // 
            this.cardPTLabel.AutoSize = true;
            this.cardPTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPTLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardPTLabel.Location = new System.Drawing.Point(112, 45);
            this.cardPTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardPTLabel.Name = "cardPTLabel";
            this.cardPTLabel.Padding = new System.Windows.Forms.Padding(0, 8, 3, 3);
            this.cardPTLabel.Size = new System.Drawing.Size(220, 40);
            this.cardPTLabel.TabIndex = 27;
            this.cardPTLabel.Text = "Power/Toughness:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Card_Name_Label);
            this.flowLayoutPanel1.Controls.Add(this.CardName);
            this.flowLayoutPanel1.Controls.Add(this.cardSetLabel);
            this.flowLayoutPanel1.Controls.Add(this.Card_Set_Combobox);
            this.flowLayoutPanel1.Controls.Add(this.cardTypeLabel);
            this.flowLayoutPanel1.Controls.Add(this.Card_Type_TextBox);
            this.flowLayoutPanel1.Controls.Add(this.cardTextLabel);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.cardFlavorLabel);
            this.flowLayoutPanel1.Controls.Add(this.cardFlavorTextbox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 562);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(336, 666);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // Card_Name_Label
            // 
            this.Card_Name_Label.AutoSize = true;
            this.Card_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Name_Label.ForeColor = System.Drawing.Color.Silver;
            this.Card_Name_Label.Location = new System.Drawing.Point(4, 0);
            this.Card_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Card_Name_Label.Name = "Card_Name_Label";
            this.Card_Name_Label.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Card_Name_Label.Size = new System.Drawing.Size(87, 35);
            this.Card_Name_Label.TabIndex = 22;
            this.Card_Name_Label.Text = "Name:";
            // 
            // CardName
            // 
            this.CardName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CardName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CardName.BackColor = System.Drawing.Color.SlateGray;
            this.CardName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.FormattingEnabled = true;
            this.CardName.Items.AddRange(new object[] {
            "Cancel AKH",
            "Cancel XLN"});
            this.CardName.Location = new System.Drawing.Point(4, 40);
            this.CardName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(330, 37);
            this.CardName.TabIndex = 19;
            this.CardName.TabStop = false;
            // 
            // cardSetLabel
            // 
            this.cardSetLabel.AutoSize = true;
            this.cardSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardSetLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardSetLabel.Location = new System.Drawing.Point(4, 82);
            this.cardSetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardSetLabel.Name = "cardSetLabel";
            this.cardSetLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cardSetLabel.Size = new System.Drawing.Size(112, 35);
            this.cardSetLabel.TabIndex = 23;
            this.cardSetLabel.Text = "Setcode:";
            // 
            // Card_Set_Combobox
            // 
            this.Card_Set_Combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Card_Set_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Card_Set_Combobox.BackColor = System.Drawing.Color.SlateGray;
            this.Card_Set_Combobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card_Set_Combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Set_Combobox.FormattingEnabled = true;
            this.Card_Set_Combobox.Location = new System.Drawing.Point(4, 122);
            this.Card_Set_Combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Card_Set_Combobox.Name = "Card_Set_Combobox";
            this.Card_Set_Combobox.Size = new System.Drawing.Size(112, 37);
            this.Card_Set_Combobox.TabIndex = 20;
            this.Card_Set_Combobox.SelectedIndexChanged += new System.EventHandler(this.Card_Set_Combobox_SelectedIndexChanged);
            // 
            // cardTypeLabel
            // 
            this.cardTypeLabel.AutoSize = true;
            this.cardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTypeLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardTypeLabel.Location = new System.Drawing.Point(4, 164);
            this.cardTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardTypeLabel.Name = "cardTypeLabel";
            this.cardTypeLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cardTypeLabel.Size = new System.Drawing.Size(77, 35);
            this.cardTypeLabel.TabIndex = 24;
            this.cardTypeLabel.Text = "Type:";
            // 
            // Card_Type_TextBox
            // 
            this.Card_Type_TextBox.BackColor = System.Drawing.Color.SlateGray;
            this.Card_Type_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Type_TextBox.Location = new System.Drawing.Point(4, 204);
            this.Card_Type_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Card_Type_TextBox.Name = "Card_Type_TextBox";
            this.Card_Type_TextBox.ReadOnly = true;
            this.Card_Type_TextBox.Size = new System.Drawing.Size(330, 35);
            this.Card_Type_TextBox.TabIndex = 21;
            // 
            // cardTextLabel
            // 
            this.cardTextLabel.AutoSize = true;
            this.cardTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTextLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardTextLabel.Location = new System.Drawing.Point(4, 244);
            this.cardTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardTextLabel.Name = "cardTextLabel";
            this.cardTextLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cardTextLabel.Size = new System.Drawing.Size(69, 35);
            this.cardTextLabel.TabIndex = 26;
            this.cardTextLabel.Text = "Text:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateGray;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(4, 284);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(330, 155);
            this.textBox2.TabIndex = 25;
            // 
            // cardFlavorLabel
            // 
            this.cardFlavorLabel.AutoSize = true;
            this.cardFlavorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardFlavorLabel.ForeColor = System.Drawing.Color.Silver;
            this.cardFlavorLabel.Location = new System.Drawing.Point(4, 444);
            this.cardFlavorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cardFlavorLabel.Name = "cardFlavorLabel";
            this.cardFlavorLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cardFlavorLabel.Size = new System.Drawing.Size(142, 35);
            this.cardFlavorLabel.TabIndex = 27;
            this.cardFlavorLabel.Text = "Flavor Text:";
            this.cardFlavorLabel.Click += new System.EventHandler(this.cardFlavorLabel_Click);
            // 
            // cardFlavorTextbox
            // 
            this.cardFlavorTextbox.BackColor = System.Drawing.Color.SlateGray;
            this.cardFlavorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardFlavorTextbox.Location = new System.Drawing.Point(4, 484);
            this.cardFlavorTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardFlavorTextbox.Multiline = true;
            this.cardFlavorTextbox.Name = "cardFlavorTextbox";
            this.cardFlavorTextbox.ReadOnly = true;
            this.cardFlavorTextbox.Size = new System.Drawing.Size(330, 150);
            this.cardFlavorTextbox.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1128, 70);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add to Inventory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Card_Table_Panel);
            this.panel3.Location = new System.Drawing.Point(368, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 1235);
            this.panel3.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(0, 70);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1128, 70);
            this.button4.TabIndex = 24;
            this.button4.Text = "Delete Selected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(368, 1311);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 152);
            this.panel4.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1988, 1465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "TCG Digitizer - Get Image";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterCardWithCondition);
            ((System.ComponentModel.ISupportInitialize)(this.Cam_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Boarder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_Header_Pic_Box)).EndInit();
            this.Card_Table_Panel.ResumeLayout(false);
            this.Card_Table_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Cam_Picture_Box;
        private System.Windows.Forms.Button Start_Video__Button;
        public System.Windows.Forms.PictureBox Display_Picture_Box;
        private System.Windows.Forms.Label Preview_Label;
        private System.Windows.Forms.PictureBox Card_Boarder;
        private System.Windows.Forms.PictureBox Name_Header_Pic_Box;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel Card_Table_Panel;
        private System.Windows.Forms.Button Date_Button;
        private System.Windows.Forms.Button Mana_Button;
        private System.Windows.Forms.Button Number_Button;
        private System.Windows.Forms.Button Expansion_Button;
        private System.Windows.Forms.Button Type_Button;
        private System.Windows.Forms.Button Name_Button;
        private System.Windows.Forms.CheckBox Inventory_Checkbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CardName;
        private System.Windows.Forms.ComboBox Card_Set_Combobox;
        private System.Windows.Forms.TextBox Card_Type_TextBox;
        private System.Windows.Forms.Label cardTypeLabel;
        private System.Windows.Forms.Label cardSetLabel;
        private System.Windows.Forms.Label Card_Name_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label cardTextLabel;
        private System.Windows.Forms.Label cardFlavorLabel;
        private System.Windows.Forms.TextBox cardFlavorTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox cardPTLTextbox;
        private System.Windows.Forms.Label cardPTLabel;
        private System.Windows.Forms.Label cardLoyaltyLabel;
    }
}

