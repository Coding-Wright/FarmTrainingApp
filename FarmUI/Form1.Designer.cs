namespace FarmProject.FarmUI
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
            AnimalDetailsList = new ListBox();
            AddDogBtn = new Button();
            TalkBtn = new Button();
            AddCatBtn = new Button();
            AddHorseButton = new Button();
            FarmVersionLbl = new Label();
            farmSelector = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)farmSelector).BeginInit();
            SuspendLayout();
            // 
            // AnimalDetailsList
            // 
            AnimalDetailsList.FormattingEnabled = true;
            AnimalDetailsList.ItemHeight = 15;
            AnimalDetailsList.Location = new Point(12, 99);
            AnimalDetailsList.Name = "AnimalDetailsList";
            AnimalDetailsList.Size = new Size(583, 184);
            AnimalDetailsList.TabIndex = 0;
            // 
            // AddDogBtn
            // 
            AddDogBtn.Location = new Point(217, 301);
            AddDogBtn.Name = "AddDogBtn";
            AddDogBtn.Size = new Size(75, 23);
            AddDogBtn.TabIndex = 1;
            AddDogBtn.Text = "Add Dog";
            AddDogBtn.UseVisualStyleBackColor = true;
            AddDogBtn.Click += AddDogBtn_Click;
            // 
            // TalkBtn
            // 
            TalkBtn.Location = new Point(12, 301);
            TalkBtn.Name = "TalkBtn";
            TalkBtn.Size = new Size(75, 23);
            TalkBtn.TabIndex = 2;
            TalkBtn.Text = "TALK";
            TalkBtn.UseVisualStyleBackColor = true;
            TalkBtn.Click += TalkBtn_Click;
            // 
            // AddCatBtn
            // 
            AddCatBtn.Location = new Point(298, 301);
            AddCatBtn.Name = "AddCatBtn";
            AddCatBtn.Size = new Size(75, 23);
            AddCatBtn.TabIndex = 3;
            AddCatBtn.Text = "Add Cat";
            AddCatBtn.UseVisualStyleBackColor = true;
            AddCatBtn.Click += AddCatBtn_Click;
            // 
            // AddHorseButton
            // 
            AddHorseButton.Location = new Point(379, 301);
            AddHorseButton.Name = "AddHorseButton";
            AddHorseButton.Size = new Size(75, 23);
            AddHorseButton.TabIndex = 4;
            AddHorseButton.Text = "Add Horse";
            AddHorseButton.UseVisualStyleBackColor = true;
            AddHorseButton.Click += AddHorseButton_Click;
            // 
            // FarmVersionLbl
            // 
            FarmVersionLbl.AutoSize = true;
            FarmVersionLbl.Location = new Point(12, 54);
            FarmVersionLbl.Name = "FarmVersionLbl";
            FarmVersionLbl.Size = new Size(70, 15);
            FarmVersionLbl.TabIndex = 5;
            FarmVersionLbl.Text = "Using Farm:";
            // 
            // farmSelector
            // 
            farmSelector.Location = new Point(12, 28);
            farmSelector.Name = "farmSelector";
            farmSelector.Size = new Size(70, 23);
            farmSelector.TabIndex = 6;
            farmSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            farmSelector.ValueChanged += farmSelector_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(farmSelector);
            Controls.Add(FarmVersionLbl);
            Controls.Add(AddHorseButton);
            Controls.Add(AddCatBtn);
            Controls.Add(TalkBtn);
            Controls.Add(AddDogBtn);
            Controls.Add(AnimalDetailsList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)farmSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox AnimalDetailsList;
        private Button AddDogBtn;
        private Button TalkBtn;
        private Button AddCatBtn;
        private Button AddHorseButton;
        private Label FarmVersionLbl;
        private NumericUpDown farmSelector;
    }
}