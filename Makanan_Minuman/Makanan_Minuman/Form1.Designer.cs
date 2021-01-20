
namespace Makanan_Minuman
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
            this.labelNamaItem = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.groupBoxRadioBox = new System.Windows.Forms.GroupBox();
            this.radioButtonMinuman = new System.Windows.Forms.RadioButton();
            this.radioButtonMakanan = new System.Windows.Forms.RadioButton();
            this.buttonInput = new System.Windows.Forms.Button();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.labelKategori = new System.Windows.Forms.Label();
            this.buttonSalin = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.checkBoxMinuman = new System.Windows.Forms.CheckBox();
            this.checkBoxMakanan = new System.Windows.Forms.CheckBox();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.groupBoxRadioBox.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaItem
            // 
            this.labelNamaItem.AutoSize = true;
            this.labelNamaItem.Location = new System.Drawing.Point(13, 23);
            this.labelNamaItem.Name = "labelNamaItem";
            this.labelNamaItem.Size = new System.Drawing.Size(58, 13);
            this.labelNamaItem.TabIndex = 0;
            this.labelNamaItem.Text = "Nama Item";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(102, 20);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(308, 20);
            this.textBoxItem.TabIndex = 1;
            this.textBoxItem.TextChanged += new System.EventHandler(this.textBoxItem_TextChanged);
            // 
            // groupBoxRadioBox
            // 
            this.groupBoxRadioBox.Controls.Add(this.radioButtonMinuman);
            this.groupBoxRadioBox.Controls.Add(this.radioButtonMakanan);
            this.groupBoxRadioBox.Location = new System.Drawing.Point(102, 62);
            this.groupBoxRadioBox.Name = "groupBoxRadioBox";
            this.groupBoxRadioBox.Size = new System.Drawing.Size(247, 79);
            this.groupBoxRadioBox.TabIndex = 2;
            this.groupBoxRadioBox.TabStop = false;
            // 
            // radioButtonMinuman
            // 
            this.radioButtonMinuman.AutoSize = true;
            this.radioButtonMinuman.Location = new System.Drawing.Point(146, 33);
            this.radioButtonMinuman.Name = "radioButtonMinuman";
            this.radioButtonMinuman.Size = new System.Drawing.Size(68, 17);
            this.radioButtonMinuman.TabIndex = 1;
            this.radioButtonMinuman.TabStop = true;
            this.radioButtonMinuman.Text = "Minuman";
            this.radioButtonMinuman.UseVisualStyleBackColor = true;
            this.radioButtonMinuman.CheckedChanged += new System.EventHandler(this.radioButtonMinuman_CheckedChanged);
            // 
            // radioButtonMakanan
            // 
            this.radioButtonMakanan.AutoSize = true;
            this.radioButtonMakanan.Location = new System.Drawing.Point(26, 33);
            this.radioButtonMakanan.Name = "radioButtonMakanan";
            this.radioButtonMakanan.Size = new System.Drawing.Size(70, 17);
            this.radioButtonMakanan.TabIndex = 0;
            this.radioButtonMakanan.TabStop = true;
            this.radioButtonMakanan.Text = "Makanan";
            this.radioButtonMakanan.UseVisualStyleBackColor = true;
            this.radioButtonMakanan.CheckedChanged += new System.EventHandler(this.radioButtonMakanan_CheckedChanged);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(102, 148);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 3;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Location = new System.Drawing.Point(16, 216);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(161, 212);
            this.listBoxInput.TabIndex = 4;
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.listBoxInput_SelectedIndexChanged);
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(13, 76);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(46, 13);
            this.labelKategori.TabIndex = 5;
            this.labelKategori.Text = "Kategori";
            // 
            // buttonSalin
            // 
            this.buttonSalin.Location = new System.Drawing.Point(210, 216);
            this.buttonSalin.Name = "buttonSalin";
            this.buttonSalin.Size = new System.Drawing.Size(106, 23);
            this.buttonSalin.TabIndex = 6;
            this.buttonSalin.Text = ">";
            this.buttonSalin.UseVisualStyleBackColor = true;
            this.buttonSalin.Click += new System.EventHandler(this.buttonSalin_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(210, 255);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.checkBoxMinuman);
            this.groupBoxFilter.Controls.Add(this.checkBoxMakanan);
            this.groupBoxFilter.Location = new System.Drawing.Point(210, 300);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(106, 93);
            this.groupBoxFilter.TabIndex = 8;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // checkBoxMinuman
            // 
            this.checkBoxMinuman.AutoSize = true;
            this.checkBoxMinuman.Location = new System.Drawing.Point(18, 59);
            this.checkBoxMinuman.Name = "checkBoxMinuman";
            this.checkBoxMinuman.Size = new System.Drawing.Size(69, 17);
            this.checkBoxMinuman.TabIndex = 1;
            this.checkBoxMinuman.Text = "Minuman";
            this.checkBoxMinuman.UseVisualStyleBackColor = true;
            this.checkBoxMinuman.CheckedChanged += new System.EventHandler(this.checkBoxMinuman_CheckedChanged);
            // 
            // checkBoxMakanan
            // 
            this.checkBoxMakanan.AutoSize = true;
            this.checkBoxMakanan.Location = new System.Drawing.Point(18, 24);
            this.checkBoxMakanan.Name = "checkBoxMakanan";
            this.checkBoxMakanan.Size = new System.Drawing.Size(71, 17);
            this.checkBoxMakanan.TabIndex = 0;
            this.checkBoxMakanan.Text = "Makanan";
            this.checkBoxMakanan.UseVisualStyleBackColor = true;
            this.checkBoxMakanan.CheckedChanged += new System.EventHandler(this.checkBoxMakanan_CheckedChanged);
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.Location = new System.Drawing.Point(349, 216);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(163, 212);
            this.listBoxList.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.groupBoxFilter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSalin);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.groupBoxRadioBox);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.labelNamaItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRadioBox.ResumeLayout(false);
            this.groupBoxRadioBox.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamaItem;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.GroupBox groupBoxRadioBox;
        private System.Windows.Forms.RadioButton radioButtonMinuman;
        private System.Windows.Forms.RadioButton radioButtonMakanan;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Button buttonSalin;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxMinuman;
        private System.Windows.Forms.CheckBox checkBoxMakanan;
        private System.Windows.Forms.ListBox listBoxList;
    }
}

