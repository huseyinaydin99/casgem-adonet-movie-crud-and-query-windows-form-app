namespace Casgem.AdoNet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.radioDisable = new System.Windows.Forms.RadioButton();
            this.radioEnable = new System.Windows.Forms.RadioButton();
            this.txtBoxCategoryName = new System.Windows.Forms.TextBox();
            this.txtBoxCategoryID = new System.Windows.Forms.TextBox();
            this.lblStatu = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.lblMovieDuration = new System.Windows.Forms.Label();
            this.txtBoxImdbPoint = new System.Windows.Forms.TextBox();
            this.lblImdbPoint = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtBoxMovieName = new System.Windows.Forms.TextBox();
            this.txtBoxMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.dataGridMovie = new System.Windows.Forms.DataGridView();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCategoryNumber = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMovieNumber = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblBestMovie = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblScienceFictionNumber = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblAveragePoint = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblMovieDurationNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovie)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnCategoryUpdate);
            this.groupBox1.Controls.Add(this.btnCategoryDelete);
            this.groupBox1.Controls.Add(this.btnCategoryAdd);
            this.groupBox1.Controls.Add(this.btnCategoryList);
            this.groupBox1.Controls.Add(this.radioDisable);
            this.groupBox1.Controls.Add(this.radioEnable);
            this.groupBox1.Controls.Add(this.txtBoxCategoryName);
            this.groupBox1.Controls.Add(this.txtBoxCategoryID);
            this.groupBox1.Controls.Add(this.lblStatu);
            this.groupBox1.Controls.Add(this.lblCategoryName);
            this.groupBox1.Controls.Add(this.dataGridCategory);
            this.groupBox1.Controls.Add(this.lblCategoryID);
            this.groupBox1.Location = new System.Drawing.Point(7, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(263, 305);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(126, 42);
            this.btnCategoryUpdate.TabIndex = 11;
            this.btnCategoryUpdate.Text = "Kategori Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(145, 306);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(112, 42);
            this.btnCategoryDelete.TabIndex = 10;
            this.btnCategoryDelete.Text = "Kategori Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(263, 260);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(126, 39);
            this.btnCategoryAdd.TabIndex = 9;
            this.btnCategoryAdd.Text = "Kategori Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(145, 260);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(112, 42);
            this.btnCategoryList.TabIndex = 8;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // radioDisable
            // 
            this.radioDisable.AutoSize = true;
            this.radioDisable.Location = new System.Drawing.Point(152, 232);
            this.radioDisable.Name = "radioDisable";
            this.radioDisable.Size = new System.Drawing.Size(58, 20);
            this.radioDisable.TabIndex = 7;
            this.radioDisable.TabStop = true;
            this.radioDisable.Text = "Pasif";
            this.radioDisable.UseVisualStyleBackColor = true;
            // 
            // radioEnable
            // 
            this.radioEnable.AutoSize = true;
            this.radioEnable.Location = new System.Drawing.Point(84, 232);
            this.radioEnable.Name = "radioEnable";
            this.radioEnable.Size = new System.Drawing.Size(53, 20);
            this.radioEnable.TabIndex = 4;
            this.radioEnable.TabStop = true;
            this.radioEnable.Text = "Aktif";
            this.radioEnable.UseVisualStyleBackColor = true;
            // 
            // txtBoxCategoryName
            // 
            this.txtBoxCategoryName.Location = new System.Drawing.Point(85, 204);
            this.txtBoxCategoryName.Name = "txtBoxCategoryName";
            this.txtBoxCategoryName.Size = new System.Drawing.Size(304, 22);
            this.txtBoxCategoryName.TabIndex = 6;
            // 
            // txtBoxCategoryID
            // 
            this.txtBoxCategoryID.Location = new System.Drawing.Point(85, 179);
            this.txtBoxCategoryID.Name = "txtBoxCategoryID";
            this.txtBoxCategoryID.Size = new System.Drawing.Size(304, 22);
            this.txtBoxCategoryID.TabIndex = 3;
            // 
            // lblStatu
            // 
            this.lblStatu.AutoSize = true;
            this.lblStatu.Location = new System.Drawing.Point(3, 234);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(52, 16);
            this.lblStatu.TabIndex = 5;
            this.lblStatu.Text = "Durum: ";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(3, 207);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(83, 16);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Kategori Adı:";
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategory.Location = new System.Drawing.Point(6, 19);
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.RowHeadersWidth = 51;
            this.dataGridCategory.RowTemplate.Height = 24;
            this.dataGridCategory.Size = new System.Drawing.Size(383, 150);
            this.dataGridCategory.TabIndex = 1;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(3, 182);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(76, 16);
            this.lblCategoryID.TabIndex = 2;
            this.lblCategoryID.Text = "Kategori ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtBoxCategory);
            this.groupBox2.Controls.Add(this.lblCategory);
            this.groupBox2.Controls.Add(this.txtBoxMovieDuration);
            this.groupBox2.Controls.Add(this.lblMovieDuration);
            this.groupBox2.Controls.Add(this.txtBoxImdbPoint);
            this.groupBox2.Controls.Add(this.lblImdbPoint);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.txtBoxMovieName);
            this.groupBox2.Controls.Add(this.txtBoxMovieID);
            this.groupBox2.Controls.Add(this.lblMovieName);
            this.groupBox2.Controls.Add(this.dataGridMovie);
            this.groupBox2.Controls.Add(this.lblMovieID);
            this.groupBox2.Location = new System.Drawing.Point(408, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 427);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film İşlemleri";
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Location = new System.Drawing.Point(85, 288);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(308, 22);
            this.txtBoxCategory.TabIndex = 17;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 291);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 16);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Kategori";
            // 
            // txtBoxMovieDuration
            // 
            this.txtBoxMovieDuration.Location = new System.Drawing.Point(85, 260);
            this.txtBoxMovieDuration.Name = "txtBoxMovieDuration";
            this.txtBoxMovieDuration.Size = new System.Drawing.Size(308, 22);
            this.txtBoxMovieDuration.TabIndex = 15;
            // 
            // lblMovieDuration
            // 
            this.lblMovieDuration.AutoSize = true;
            this.lblMovieDuration.Location = new System.Drawing.Point(3, 263);
            this.lblMovieDuration.Name = "lblMovieDuration";
            this.lblMovieDuration.Size = new System.Drawing.Size(73, 16);
            this.lblMovieDuration.TabIndex = 14;
            this.lblMovieDuration.Text = "Film Süresi";
            // 
            // txtBoxImdbPoint
            // 
            this.txtBoxImdbPoint.Location = new System.Drawing.Point(85, 232);
            this.txtBoxImdbPoint.Name = "txtBoxImdbPoint";
            this.txtBoxImdbPoint.Size = new System.Drawing.Size(308, 22);
            this.txtBoxImdbPoint.TabIndex = 13;
            // 
            // lblImdbPoint
            // 
            this.lblImdbPoint.AutoSize = true;
            this.lblImdbPoint.Location = new System.Drawing.Point(3, 235);
            this.lblImdbPoint.Name = "lblImdbPoint";
            this.lblImdbPoint.Size = new System.Drawing.Size(80, 16);
            this.lblImdbPoint.TabIndex = 12;
            this.lblImdbPoint.Text = "IMDB Puanı:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 42);
            this.button5.TabIndex = 11;
            this.button5.Text = "Film Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 364);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 42);
            this.button6.TabIndex = 10;
            this.button6.Text = "Film Sil";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(294, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 42);
            this.button7.TabIndex = 9;
            this.button7.Text = "Film Ekle";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(187, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "Film Listesi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtBoxMovieName
            // 
            this.txtBoxMovieName.Location = new System.Drawing.Point(85, 204);
            this.txtBoxMovieName.Name = "txtBoxMovieName";
            this.txtBoxMovieName.Size = new System.Drawing.Size(308, 22);
            this.txtBoxMovieName.TabIndex = 6;
            // 
            // txtBoxMovieID
            // 
            this.txtBoxMovieID.Location = new System.Drawing.Point(85, 179);
            this.txtBoxMovieID.Name = "txtBoxMovieID";
            this.txtBoxMovieID.Size = new System.Drawing.Size(308, 22);
            this.txtBoxMovieID.TabIndex = 3;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(3, 207);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(58, 16);
            this.lblMovieName.TabIndex = 3;
            this.lblMovieName.Text = "Film Adı:";
            // 
            // dataGridMovie
            // 
            this.dataGridMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovie.Location = new System.Drawing.Point(6, 19);
            this.dataGridMovie.Name = "dataGridMovie";
            this.dataGridMovie.RowHeadersWidth = 51;
            this.dataGridMovie.RowTemplate.Height = 24;
            this.dataGridMovie.Size = new System.Drawing.Size(387, 150);
            this.dataGridMovie.TabIndex = 1;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(3, 182);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(51, 16);
            this.lblMovieID.TabIndex = 2;
            this.lblMovieID.Text = "Film ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.lblCategoryNumber);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kategori Sayısı";
            // 
            // lblCategoryNumber
            // 
            this.lblCategoryNumber.AutoSize = true;
            this.lblCategoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryNumber.Location = new System.Drawing.Point(46, 30);
            this.lblCategoryNumber.Name = "lblCategoryNumber";
            this.lblCategoryNumber.Size = new System.Drawing.Size(26, 29);
            this.lblCategoryNumber.TabIndex = 19;
            this.lblCategoryNumber.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.lblMovieNumber);
            this.groupBox4.Location = new System.Drawing.Point(140, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 77);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Film Sayısı";
            // 
            // lblMovieNumber
            // 
            this.lblMovieNumber.AutoSize = true;
            this.lblMovieNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMovieNumber.Location = new System.Drawing.Point(51, 30);
            this.lblMovieNumber.Name = "lblMovieNumber";
            this.lblMovieNumber.Size = new System.Drawing.Size(26, 29);
            this.lblMovieNumber.TabIndex = 20;
            this.lblMovieNumber.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.lblBestMovie);
            this.groupBox5.Location = new System.Drawing.Point(274, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 77);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "En Başarılı Film";
            // 
            // lblBestMovie
            // 
            this.lblBestMovie.AutoSize = true;
            this.lblBestMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBestMovie.Location = new System.Drawing.Point(48, 30);
            this.lblBestMovie.Name = "lblBestMovie";
            this.lblBestMovie.Size = new System.Drawing.Size(26, 29);
            this.lblBestMovie.TabIndex = 21;
            this.lblBestMovie.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.lblScienceFictionNumber);
            this.groupBox6.Location = new System.Drawing.Point(408, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 77);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bilim Kurgu Filmleri";
            // 
            // lblScienceFictionNumber
            // 
            this.lblScienceFictionNumber.AutoSize = true;
            this.lblScienceFictionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScienceFictionNumber.Location = new System.Drawing.Point(50, 30);
            this.lblScienceFictionNumber.Name = "lblScienceFictionNumber";
            this.lblScienceFictionNumber.Size = new System.Drawing.Size(26, 29);
            this.lblScienceFictionNumber.TabIndex = 22;
            this.lblScienceFictionNumber.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.lblAveragePoint);
            this.groupBox7.Location = new System.Drawing.Point(557, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 77);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ortalama Puan";
            // 
            // lblAveragePoint
            // 
            this.lblAveragePoint.AutoSize = true;
            this.lblAveragePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAveragePoint.Location = new System.Drawing.Point(53, 30);
            this.lblAveragePoint.Name = "lblAveragePoint";
            this.lblAveragePoint.Size = new System.Drawing.Size(26, 29);
            this.lblAveragePoint.TabIndex = 23;
            this.lblAveragePoint.Text = "0";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.lblMovieDurationNumber);
            this.groupBox8.Location = new System.Drawing.Point(691, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(110, 77);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ortalama Süre";
            // 
            // lblMovieDurationNumber
            // 
            this.lblMovieDurationNumber.AutoSize = true;
            this.lblMovieDurationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMovieDurationNumber.Location = new System.Drawing.Point(51, 30);
            this.lblMovieDurationNumber.Name = "lblMovieDurationNumber";
            this.lblMovieDurationNumber.Size = new System.Drawing.Size(26, 29);
            this.lblMovieDurationNumber.TabIndex = 24;
            this.lblMovieDurationNumber.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 524);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film ve Kategori İşlemleri Formu!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovie)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioEnable;
        private System.Windows.Forms.TextBox txtBoxCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.DataGridView dataGridCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.RadioButton radioDisable;
        private System.Windows.Forms.TextBox txtBoxCategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtBoxMovieDuration;
        private System.Windows.Forms.Label lblMovieDuration;
        private System.Windows.Forms.TextBox txtBoxImdbPoint;
        private System.Windows.Forms.Label lblImdbPoint;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtBoxMovieName;
        private System.Windows.Forms.TextBox txtBoxMovieID;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.DataGridView dataGridMovie;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCategoryNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMovieNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblBestMovie;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblScienceFictionNumber;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblAveragePoint;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblMovieDurationNumber;
    }
}

