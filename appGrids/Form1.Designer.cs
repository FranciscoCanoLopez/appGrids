namespace appGrids
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
            lstvData = new ListView();
            btnOpen = new Button();
            CBArtist = new ComboBox();
            LBArtist = new Label();
            BTNSearch = new Button();
            dTP1 = new DateTimePicker();
            dTP2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            BTNSearch_Album = new Button();
            SuspendLayout();
            // 
            // lstvData
            // 
            lstvData.Location = new Point(25, 73);
            lstvData.Margin = new Padding(3, 4, 3, 4);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(921, 449);
            lstvData.TabIndex = 0;
            lstvData.UseCompatibleStateImageBehavior = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(25, 16);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(133, 52);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += BtnOpen_Click;
            // 
            // CBArtist
            // 
            CBArtist.FormattingEnabled = true;
            CBArtist.Location = new Point(182, 36);
            CBArtist.Name = "CBArtist";
            CBArtist.Size = new Size(151, 28);
            CBArtist.TabIndex = 2;
            // 
            // LBArtist
            // 
            LBArtist.AutoSize = true;
            LBArtist.Location = new Point(240, 13);
            LBArtist.Name = "LBArtist";
            LBArtist.Size = new Size(44, 20);
            LBArtist.TabIndex = 3;
            LBArtist.Text = "Artist";
            // 
            // BTNSearch
            // 
            BTNSearch.Location = new Point(351, 37);
            BTNSearch.Name = "BTNSearch";
            BTNSearch.Size = new Size(94, 29);
            BTNSearch.TabIndex = 4;
            BTNSearch.Text = "Search";
            BTNSearch.UseVisualStyleBackColor = true;
            BTNSearch.Click += BTNSearch_Click;
            // 
            // dTP1
            // 
            dTP1.Format = DateTimePickerFormat.Short;
            dTP1.Location = new Point(653, 3);
            dTP1.Name = "dTP1";
            dTP1.Size = new Size(123, 27);
            dTP1.TabIndex = 5;
            // 
            // dTP2
            // 
            dTP2.Format = DateTimePickerFormat.Short;
            dTP2.Location = new Point(653, 41);
            dTP2.Name = "dTP2";
            dTP2.Size = new Size(123, 27);
            dTP2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "First date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 44);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 8;
            label2.Text = "Second date";
            // 
            // BTNSearch_Album
            // 
            BTNSearch_Album.Location = new Point(782, 12);
            BTNSearch_Album.Name = "BTNSearch_Album";
            BTNSearch_Album.Size = new Size(94, 50);
            BTNSearch_Album.TabIndex = 9;
            BTNSearch_Album.Text = "Search Album";
            BTNSearch_Album.UseVisualStyleBackColor = true;
            BTNSearch_Album.Click += BTNSearch_Album_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 600);
            Controls.Add(BTNSearch_Album);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dTP2);
            Controls.Add(dTP1);
            Controls.Add(BTNSearch);
            Controls.Add(LBArtist);
            Controls.Add(CBArtist);
            Controls.Add(btnOpen);
            Controls.Add(lstvData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvData;
    private Button btnOpen;
        private ComboBox CBArtist;
        private Label LBArtist;
        private Button BTNSearch;
        private DateTimePicker dTP1;
        private DateTimePicker dTP2;
        private Label label1;
        private Label label2;
        private Button BTNSearch_Album;
    }
}
