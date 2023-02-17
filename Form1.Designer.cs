namespace mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонтактеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBSStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appleIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробнееОРегистрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поддержкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задонатитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boostyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ютубКаналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телегаАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиВВКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(321, 264);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрация во ВКонтакте";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "@mail.ru",
            "@gmail.com",
            "@yandex.ru",
            "@rambler.ru"});
            this.comboBox1.Location = new System.Drawing.Point(557, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "@mail.ru";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(863, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "С помощью данного приложения от нашей команды Вы можете создать учетную запись со" +
    "ц.сети ВКонтакте и не только!\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(854, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(193, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адрес эл.почты:\r\n";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Регистрация";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(250, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(407, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 8;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(321, 300);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(557, 308);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Показать пароль";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(667, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Или, по номеру телефона";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияToolStripMenuItem,
            this.поддержкаToolStripMenuItem,
            this.материалыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.подробнееОРегистрацииToolStripMenuItem});
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вКонтактеToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.twichToolStripMenuItem,
            this.oBSStudioToolStripMenuItem,
            this.appleIDToolStripMenuItem});
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.типToolStripMenuItem.Text = "Тип";
            // 
            // вКонтактеToolStripMenuItem
            // 
            this.вКонтактеToolStripMenuItem.Checked = true;
            this.вКонтактеToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.вКонтактеToolStripMenuItem.Name = "вКонтактеToolStripMenuItem";
            this.вКонтактеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.вКонтактеToolStripMenuItem.Text = "ВКонтакте";
            this.вКонтактеToolStripMenuItem.Click += new System.EventHandler(this.вКонтактеToolStripMenuItem_Click);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Image = global::mail.Properties.Resources._123_1235246_youtube_ndash_logos_brands_and_logotypes_youtube_logo;
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
            // 
            // twichToolStripMenuItem
            // 
            this.twichToolStripMenuItem.Image = global::mail.Properties.Resources.twitch;
            this.twichToolStripMenuItem.Name = "twichToolStripMenuItem";
            this.twichToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.twichToolStripMenuItem.Text = "Twitch";
            this.twichToolStripMenuItem.Click += new System.EventHandler(this.twichToolStripMenuItem_Click);
            // 
            // oBSStudioToolStripMenuItem
            // 
            this.oBSStudioToolStripMenuItem.Image = global::mail.Properties.Resources.Microsoft_Store_Fluent_Design_icon;
            this.oBSStudioToolStripMenuItem.Name = "oBSStudioToolStripMenuItem";
            this.oBSStudioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.oBSStudioToolStripMenuItem.Text = "Microsoft Store";
            this.oBSStudioToolStripMenuItem.Click += new System.EventHandler(this.oBSStudioToolStripMenuItem_Click);
            // 
            // appleIDToolStripMenuItem
            // 
            this.appleIDToolStripMenuItem.Image = global::mail.Properties.Resources.apple_event_8875243;
            this.appleIDToolStripMenuItem.Name = "appleIDToolStripMenuItem";
            this.appleIDToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.appleIDToolStripMenuItem.Text = "Apple ID";
            this.appleIDToolStripMenuItem.Click += new System.EventHandler(this.appleIDToolStripMenuItem_Click);
            // 
            // подробнееОРегистрацииToolStripMenuItem
            // 
            this.подробнееОРегистрацииToolStripMenuItem.Name = "подробнееОРегистрацииToolStripMenuItem";
            this.подробнееОРегистрацииToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.подробнееОРегистрацииToolStripMenuItem.Text = "Подробнее о регистрации";
            this.подробнееОРегистрацииToolStripMenuItem.Click += new System.EventHandler(this.подробнееОРегистрацииToolStripMenuItem_Click);
            // 
            // поддержкаToolStripMenuItem
            // 
            this.поддержкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задонатитьToolStripMenuItem,
            this.перейтиВВКToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            this.поддержкаToolStripMenuItem.ShowShortcutKeys = false;
            this.поддержкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.поддержкаToolStripMenuItem.Text = "Поддержка";
            this.поддержкаToolStripMenuItem.Click += new System.EventHandler(this.поддержкаToolStripMenuItem_Click);
            // 
            // задонатитьToolStripMenuItem
            // 
            this.задонатитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boostyToolStripMenuItem,
            this.ютубКаналToolStripMenuItem,
            this.телегаАвтораToolStripMenuItem});
            this.задонатитьToolStripMenuItem.Name = "задонатитьToolStripMenuItem";
            this.задонатитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.задонатитьToolStripMenuItem.Text = "Поддержать автора";
            this.задонатитьToolStripMenuItem.Click += new System.EventHandler(this.задонатитьToolStripMenuItem_Click);
            // 
            // boostyToolStripMenuItem
            // 
            this.boostyToolStripMenuItem.Image = global::mail.Properties.Resources._171388249_2dd82009_e065_4435_af0b_5b198478cedb;
            this.boostyToolStripMenuItem.Name = "boostyToolStripMenuItem";
            this.boostyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.boostyToolStripMenuItem.Text = "Boosty";
            this.boostyToolStripMenuItem.Click += new System.EventHandler(this.boostyToolStripMenuItem_Click);
            // 
            // ютубКаналToolStripMenuItem
            // 
            this.ютубКаналToolStripMenuItem.Image = global::mail.Properties.Resources._123_1235246_youtube_ndash_logos_brands_and_logotypes_youtube_logo;
            this.ютубКаналToolStripMenuItem.Name = "ютубКаналToolStripMenuItem";
            this.ютубКаналToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ютубКаналToolStripMenuItem.Text = "Ютуб канал";
            this.ютубКаналToolStripMenuItem.Click += new System.EventHandler(this.ютубКаналToolStripMenuItem_Click);
            // 
            // телегаАвтораToolStripMenuItem
            // 
            this.телегаАвтораToolStripMenuItem.Image = global::mail.Properties.Resources.telegram_logo_06;
            this.телегаАвтораToolStripMenuItem.Name = "телегаАвтораToolStripMenuItem";
            this.телегаАвтораToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.телегаАвтораToolStripMenuItem.Text = "Телега автора";
            this.телегаАвтораToolStripMenuItem.Click += new System.EventHandler(this.телегаАвтораToolStripMenuItem_Click);
            // 
            // перейтиВВКToolStripMenuItem
            // 
            this.перейтиВВКToolStripMenuItem.Name = "перейтиВВКToolStripMenuItem";
            this.перейтиВВКToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.перейтиВВКToolStripMenuItem.Text = "Перейти в ВК";
            this.перейтиВВКToolStripMenuItem.Click += new System.EventHandler(this.перейтиВВКToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = global::mail.Properties.Resources._768px_Gtk_dialog_question_svg;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::mail.Properties.Resources.xoD6_VxaDMc;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.оПрограммеToolStripMenuItem.Text = "&О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mail.Properties.Resources.xoD6_VxaDMc;
            this.pictureBox1.Location = new System.Drawing.Point(382, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Copyright © ArtOSik Corp. 2023. Все права защищены";
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скачатьToolStripMenuItem});
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.материалыToolStripMenuItem.Text = "Материалы";
            // 
            // скачатьToolStripMenuItem
            // 
            this.скачатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходникиToolStripMenuItem});
            this.скачатьToolStripMenuItem.Name = "скачатьToolStripMenuItem";
            this.скачатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.скачатьToolStripMenuItem.Text = "Скачать";
            // 
            // исходникиToolStripMenuItem
            // 
            this.исходникиToolStripMenuItem.Name = "исходникиToolStripMenuItem";
            this.исходникиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.исходникиToolStripMenuItem.Text = "Исходники";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(937, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задонатитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boostyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонтактеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBSStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ютубКаналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appleIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телегаАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиВВКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подробнееОРегистрацииToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скачатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходникиToolStripMenuItem;
    }
}

