namespace LAB11_03_01_2023
{
    partial class TripleTester
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
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ToStringButton = new System.Windows.Forms.Button();
            this.MethodsTestTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.IntegerInputPanel = new System.Windows.Forms.Panel();
            this.Int2TextBox = new System.Windows.Forms.TextBox();
            this.Int1TextBox = new System.Windows.Forms.TextBox();
            this.Int0TextBox = new System.Windows.Forms.TextBox();
            this.Int2Label = new System.Windows.Forms.Label();
            this.Int1Label = new System.Windows.Forms.Label();
            this.Int0Label = new System.Windows.Forms.Label();
            this.DoubleInputPanel = new System.Windows.Forms.Panel();
            this.Double2TextBox = new System.Windows.Forms.TextBox();
            this.Double1TextBox = new System.Windows.Forms.TextBox();
            this.Double0TextBox = new System.Windows.Forms.TextBox();
            this.Double2Label = new System.Windows.Forms.Label();
            this.Double1Label = new System.Windows.Forms.Label();
            this.Double0Label = new System.Windows.Forms.Label();
            this.PeopleInputPanel = new System.Windows.Forms.Panel();
            this.PeopleComboBox = new System.Windows.Forms.ComboBox();
            this.EditPersonButton = new System.Windows.Forms.Button();
            this.ClearPeopleButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Indexer0Button = new System.Windows.Forms.Button();
            this.Indexer1Button = new System.Windows.Forms.Button();
            this.Indexer2Button = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ButtonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.IntegerInputPanel.SuspendLayout();
            this.DoubleInputPanel.SuspendLayout();
            this.PeopleInputPanel.SuspendLayout();
            this.ButtonsFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTypeComboBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(167, 28);
            this.DataTypeComboBox.TabIndex = 0;
            this.DataTypeComboBox.SelectedValueChanged += new System.EventHandler(this.InputTypeComboBox_SelectedValueChanged);
            // 
            // ToStringButton
            // 
            this.ToStringButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToStringButton.Location = new System.Drawing.Point(3, 3);
            this.ToStringButton.Name = "ToStringButton";
            this.ToStringButton.Size = new System.Drawing.Size(140, 35);
            this.ToStringButton.TabIndex = 1;
            this.ToStringButton.Text = "To String";
            this.ToStringButton.UseVisualStyleBackColor = true;
            this.ToStringButton.Click += new System.EventHandler(this.ToStringButton_Click);
            // 
            // MethodsTestTextBox
            // 
            this.MethodsTestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MethodsTestTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MethodsTestTextBox.Location = new System.Drawing.Point(12, 348);
            this.MethodsTestTextBox.Name = "MethodsTestTextBox";
            this.MethodsTestTextBox.Size = new System.Drawing.Size(776, 27);
            this.MethodsTestTextBox.TabIndex = 2;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortButton.Location = new System.Drawing.Point(149, 3);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(140, 35);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // IntegerInputPanel
            // 
            this.IntegerInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntegerInputPanel.Controls.Add(this.Int2TextBox);
            this.IntegerInputPanel.Controls.Add(this.Int1TextBox);
            this.IntegerInputPanel.Controls.Add(this.Int0TextBox);
            this.IntegerInputPanel.Controls.Add(this.Int2Label);
            this.IntegerInputPanel.Controls.Add(this.Int1Label);
            this.IntegerInputPanel.Controls.Add(this.Int0Label);
            this.IntegerInputPanel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntegerInputPanel.Location = new System.Drawing.Point(12, 46);
            this.IntegerInputPanel.Name = "IntegerInputPanel";
            this.IntegerInputPanel.Size = new System.Drawing.Size(776, 190);
            this.IntegerInputPanel.TabIndex = 4;
            this.IntegerInputPanel.Visible = false;
            // 
            // Int2TextBox
            // 
            this.Int2TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int2TextBox.Location = new System.Drawing.Point(204, 78);
            this.Int2TextBox.Name = "Int2TextBox";
            this.Int2TextBox.Size = new System.Drawing.Size(100, 27);
            this.Int2TextBox.TabIndex = 5;
            // 
            // Int1TextBox
            // 
            this.Int1TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int1TextBox.Location = new System.Drawing.Point(204, 45);
            this.Int1TextBox.Name = "Int1TextBox";
            this.Int1TextBox.Size = new System.Drawing.Size(100, 27);
            this.Int1TextBox.TabIndex = 4;
            // 
            // Int0TextBox
            // 
            this.Int0TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int0TextBox.Location = new System.Drawing.Point(204, 12);
            this.Int0TextBox.Name = "Int0TextBox";
            this.Int0TextBox.Size = new System.Drawing.Size(100, 27);
            this.Int0TextBox.TabIndex = 3;
            // 
            // Int2Label
            // 
            this.Int2Label.AutoSize = true;
            this.Int2Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int2Label.Location = new System.Drawing.Point(20, 80);
            this.Int2Label.Name = "Int2Label";
            this.Int2Label.Size = new System.Drawing.Size(117, 20);
            this.Int2Label.TabIndex = 2;
            this.Int2Label.Text = "Integer nr 2";
            // 
            // Int1Label
            // 
            this.Int1Label.AutoSize = true;
            this.Int1Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int1Label.Location = new System.Drawing.Point(20, 47);
            this.Int1Label.Name = "Int1Label";
            this.Int1Label.Size = new System.Drawing.Size(117, 20);
            this.Int1Label.TabIndex = 1;
            this.Int1Label.Text = "Integer nr 1";
            // 
            // Int0Label
            // 
            this.Int0Label.AutoSize = true;
            this.Int0Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Int0Label.Location = new System.Drawing.Point(20, 17);
            this.Int0Label.Name = "Int0Label";
            this.Int0Label.Size = new System.Drawing.Size(117, 20);
            this.Int0Label.TabIndex = 0;
            this.Int0Label.Text = "Integer nr 0";
            // 
            // DoubleInputPanel
            // 
            this.DoubleInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoubleInputPanel.Controls.Add(this.Double2TextBox);
            this.DoubleInputPanel.Controls.Add(this.Double1TextBox);
            this.DoubleInputPanel.Controls.Add(this.Double0TextBox);
            this.DoubleInputPanel.Controls.Add(this.Double2Label);
            this.DoubleInputPanel.Controls.Add(this.Double1Label);
            this.DoubleInputPanel.Controls.Add(this.Double0Label);
            this.DoubleInputPanel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DoubleInputPanel.Location = new System.Drawing.Point(13, 46);
            this.DoubleInputPanel.Name = "DoubleInputPanel";
            this.DoubleInputPanel.Size = new System.Drawing.Size(775, 190);
            this.DoubleInputPanel.TabIndex = 5;
            this.DoubleInputPanel.Visible = false;
            // 
            // Double2TextBox
            // 
            this.Double2TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double2TextBox.Location = new System.Drawing.Point(203, 77);
            this.Double2TextBox.Name = "Double2TextBox";
            this.Double2TextBox.Size = new System.Drawing.Size(100, 27);
            this.Double2TextBox.TabIndex = 11;
            // 
            // Double1TextBox
            // 
            this.Double1TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double1TextBox.Location = new System.Drawing.Point(203, 44);
            this.Double1TextBox.Name = "Double1TextBox";
            this.Double1TextBox.Size = new System.Drawing.Size(100, 27);
            this.Double1TextBox.TabIndex = 10;
            // 
            // Double0TextBox
            // 
            this.Double0TextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double0TextBox.Location = new System.Drawing.Point(203, 11);
            this.Double0TextBox.Name = "Double0TextBox";
            this.Double0TextBox.Size = new System.Drawing.Size(100, 27);
            this.Double0TextBox.TabIndex = 9;
            // 
            // Double2Label
            // 
            this.Double2Label.AutoSize = true;
            this.Double2Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double2Label.Location = new System.Drawing.Point(13, 80);
            this.Double2Label.Name = "Double2Label";
            this.Double2Label.Size = new System.Drawing.Size(153, 20);
            this.Double2Label.TabIndex = 8;
            this.Double2Label.Text = "Real Number nr 2";
            // 
            // Double1Label
            // 
            this.Double1Label.AutoSize = true;
            this.Double1Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double1Label.Location = new System.Drawing.Point(13, 47);
            this.Double1Label.Name = "Double1Label";
            this.Double1Label.Size = new System.Drawing.Size(153, 20);
            this.Double1Label.TabIndex = 7;
            this.Double1Label.Text = "Real Number nr 1";
            // 
            // Double0Label
            // 
            this.Double0Label.AutoSize = true;
            this.Double0Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Double0Label.Location = new System.Drawing.Point(13, 17);
            this.Double0Label.Name = "Double0Label";
            this.Double0Label.Size = new System.Drawing.Size(153, 20);
            this.Double0Label.TabIndex = 6;
            this.Double0Label.Text = "Real Number nr 0";
            // 
            // PeopleInputPanel
            // 
            this.PeopleInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeopleInputPanel.Controls.Add(this.PeopleComboBox);
            this.PeopleInputPanel.Controls.Add(this.EditPersonButton);
            this.PeopleInputPanel.Controls.Add(this.ClearPeopleButton);
            this.PeopleInputPanel.Controls.Add(this.AddPersonButton);
            this.PeopleInputPanel.Controls.Add(this.BirthDateLabel);
            this.PeopleInputPanel.Controls.Add(this.SurnameLabel);
            this.PeopleInputPanel.Controls.Add(this.NameLabel);
            this.PeopleInputPanel.Controls.Add(this.BirthDateTimePicker);
            this.PeopleInputPanel.Controls.Add(this.SurnameTextBox);
            this.PeopleInputPanel.Controls.Add(this.NameTextBox);
            this.PeopleInputPanel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PeopleInputPanel.Location = new System.Drawing.Point(13, 46);
            this.PeopleInputPanel.Name = "PeopleInputPanel";
            this.PeopleInputPanel.Size = new System.Drawing.Size(778, 190);
            this.PeopleInputPanel.TabIndex = 6;
            this.PeopleInputPanel.Visible = false;
            // 
            // PeopleComboBox
            // 
            this.PeopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeopleComboBox.FormattingEnabled = true;
            this.PeopleComboBox.Location = new System.Drawing.Point(17, 155);
            this.PeopleComboBox.Name = "PeopleComboBox";
            this.PeopleComboBox.Size = new System.Drawing.Size(357, 28);
            this.PeopleComboBox.TabIndex = 11;
            this.PeopleComboBox.SelectedIndexChanged += new System.EventHandler(this.PeopleComboBox_SelectedItemChanged);
            // 
            // EditPersonButton
            // 
            this.EditPersonButton.Location = new System.Drawing.Point(98, 114);
            this.EditPersonButton.Name = "EditPersonButton";
            this.EditPersonButton.Size = new System.Drawing.Size(75, 35);
            this.EditPersonButton.TabIndex = 10;
            this.EditPersonButton.Text = "Edit";
            this.EditPersonButton.UseVisualStyleBackColor = true;
            this.EditPersonButton.Click += new System.EventHandler(this.EditPersonButton_Click);
            // 
            // ClearPeopleButton
            // 
            this.ClearPeopleButton.Location = new System.Drawing.Point(179, 114);
            this.ClearPeopleButton.Name = "ClearPeopleButton";
            this.ClearPeopleButton.Size = new System.Drawing.Size(75, 35);
            this.ClearPeopleButton.TabIndex = 9;
            this.ClearPeopleButton.Text = "Clear";
            this.ClearPeopleButton.UseVisualStyleBackColor = true;
            this.ClearPeopleButton.Click += new System.EventHandler(this.ClearPeopleButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(17, 114);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 35);
            this.AddPersonButton.TabIndex = 8;
            this.AddPersonButton.Text = "Add";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BirthDateLabel.Location = new System.Drawing.Point(16, 85);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(126, 20);
            this.BirthDateLabel.TabIndex = 7;
            this.BirthDateLabel.Text = "Date of Birth";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameLabel.Location = new System.Drawing.Point(16, 52);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(72, 20);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(16, 18);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(201, 80);
            this.BirthDateTimePicker.MaxDate = new System.DateTime(2023, 1, 8, 0, 12, 15, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(173, 27);
            this.BirthDateTimePicker.TabIndex = 2;
            this.BirthDateTimePicker.Value = new System.DateTime(2023, 1, 8, 0, 0, 0, 0);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.Location = new System.Drawing.Point(201, 47);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 27);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(201, 14);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 27);
            this.NameTextBox.TabIndex = 0;
            // 
            // Indexer0Button
            // 
            this.Indexer0Button.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Indexer0Button.Location = new System.Drawing.Point(295, 3);
            this.Indexer0Button.Name = "Indexer0Button";
            this.Indexer0Button.Size = new System.Drawing.Size(140, 35);
            this.Indexer0Button.TabIndex = 7;
            this.Indexer0Button.Text = "Display [0]";
            this.Indexer0Button.UseVisualStyleBackColor = true;
            this.Indexer0Button.Click += new System.EventHandler(this.Indexer0Button_Click);
            // 
            // Indexer1Button
            // 
            this.Indexer1Button.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Indexer1Button.Location = new System.Drawing.Point(441, 3);
            this.Indexer1Button.Name = "Indexer1Button";
            this.Indexer1Button.Size = new System.Drawing.Size(140, 35);
            this.Indexer1Button.TabIndex = 8;
            this.Indexer1Button.Text = "Display [1]";
            this.Indexer1Button.UseVisualStyleBackColor = true;
            this.Indexer1Button.Click += new System.EventHandler(this.Indexer1Button_Click);
            // 
            // Indexer2Button
            // 
            this.Indexer2Button.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Indexer2Button.Location = new System.Drawing.Point(587, 3);
            this.Indexer2Button.Name = "Indexer2Button";
            this.Indexer2Button.Size = new System.Drawing.Size(140, 35);
            this.Indexer2Button.TabIndex = 9;
            this.Indexer2Button.Text = "Display [2]";
            this.Indexer2Button.UseVisualStyleBackColor = true;
            this.Indexer2Button.Click += new System.EventHandler(this.Indexer2Button_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(13, 242);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 35);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ButtonsFlowPanel
            // 
            this.ButtonsFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsFlowPanel.Controls.Add(this.ToStringButton);
            this.ButtonsFlowPanel.Controls.Add(this.SortButton);
            this.ButtonsFlowPanel.Controls.Add(this.Indexer0Button);
            this.ButtonsFlowPanel.Controls.Add(this.Indexer1Button);
            this.ButtonsFlowPanel.Controls.Add(this.Indexer2Button);
            this.ButtonsFlowPanel.Location = new System.Drawing.Point(12, 299);
            this.ButtonsFlowPanel.Name = "ButtonsFlowPanel";
            this.ButtonsFlowPanel.Size = new System.Drawing.Size(776, 43);
            this.ButtonsFlowPanel.TabIndex = 10;
            // 
            // TripleTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 393);
            this.Controls.Add(this.ButtonsFlowPanel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PeopleInputPanel);
            this.Controls.Add(this.IntegerInputPanel);
            this.Controls.Add(this.MethodsTestTextBox);
            this.Controls.Add(this.DoubleInputPanel);
            this.Controls.Add(this.DataTypeComboBox);
            this.MinimumSize = new System.Drawing.Size(820, 440);
            this.Name = "TripleTester";
            this.Text = "Triple Tester";
            this.IntegerInputPanel.ResumeLayout(false);
            this.IntegerInputPanel.PerformLayout();
            this.DoubleInputPanel.ResumeLayout(false);
            this.DoubleInputPanel.PerformLayout();
            this.PeopleInputPanel.ResumeLayout(false);
            this.PeopleInputPanel.PerformLayout();
            this.ButtonsFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.Button ToStringButton;
        private System.Windows.Forms.TextBox MethodsTestTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Panel IntegerInputPanel;
        private System.Windows.Forms.TextBox Int2TextBox;
        private System.Windows.Forms.TextBox Int1TextBox;
        private System.Windows.Forms.TextBox Int0TextBox;
        private System.Windows.Forms.Label Int2Label;
        private System.Windows.Forms.Label Int1Label;
        private System.Windows.Forms.Label Int0Label;
        private System.Windows.Forms.Panel DoubleInputPanel;
        private System.Windows.Forms.Panel PeopleInputPanel;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button Indexer0Button;
        private System.Windows.Forms.Button Indexer1Button;
        private System.Windows.Forms.Button Indexer2Button;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox Double2TextBox;
        private System.Windows.Forms.TextBox Double1TextBox;
        private System.Windows.Forms.TextBox Double0TextBox;
        private System.Windows.Forms.Label Double2Label;
        private System.Windows.Forms.Label Double1Label;
        private System.Windows.Forms.Label Double0Label;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowPanel;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Button ClearPeopleButton;
        private System.Windows.Forms.Button EditPersonButton;
        private System.Windows.Forms.ComboBox PeopleComboBox;
    }
}