
namespace DimLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttom_disk = new System.Windows.Forms.Button();
            this.disk = new System.Windows.Forms.Label();
            this.services = new System.Windows.Forms.CheckBox();
            this.clean = new System.Windows.Forms.CheckBox();
            this.view_dns = new System.Windows.Forms.Button();
            this.clean_dns = new System.Windows.Forms.Button();
            this.groupBox_services = new System.Windows.Forms.GroupBox();
            this.kill_services = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.CheckBox();
            this.fax = new System.Windows.Forms.CheckBox();
            this.smart_map = new System.Windows.Forms.CheckBox();
            this.bio = new System.Windows.Forms.CheckBox();
            this.wmi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cleanmgr = new System.Windows.Forms.Button();
            this.sxs_second = new System.Windows.Forms.Button();
            this.sxs_first = new System.Windows.Forms.Button();
            this.regedit = new System.Windows.Forms.Button();
            this.groupBox_services.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttom_disk
            // 
            this.buttom_disk.Location = new System.Drawing.Point(13, 13);
            this.buttom_disk.Name = "buttom_disk";
            this.buttom_disk.Size = new System.Drawing.Size(172, 23);
            this.buttom_disk.TabIndex = 0;
            this.buttom_disk.Text = "Обновить";
            this.buttom_disk.UseVisualStyleBackColor = true;
            this.buttom_disk.Click += new System.EventHandler(this.buttom_disk_Click);
            // 
            // disk
            // 
            this.disk.AutoSize = true;
            this.disk.Location = new System.Drawing.Point(13, 43);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(172, 13);
            this.disk.TabIndex = 1;
            this.disk.Text = "Обновите информацию о дисках";
            // 
            // services
            // 
            this.services.AutoSize = true;
            this.services.Location = new System.Drawing.Point(209, 18);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(164, 17);
            this.services.TabIndex = 2;
            this.services.Text = "Отключить лишние службы";
            this.services.UseVisualStyleBackColor = true;
            this.services.CheckedChanged += new System.EventHandler(this.services_CheckedChanged);
            // 
            // clean
            // 
            this.clean.AutoSize = true;
            this.clean.Location = new System.Drawing.Point(209, 43);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(127, 17);
            this.clean.TabIndex = 3;
            this.clean.Text = "Системные очистки";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.CheckedChanged += new System.EventHandler(this.clean_CheckedChanged);
            // 
            // view_dns
            // 
            this.view_dns.Location = new System.Drawing.Point(209, 67);
            this.view_dns.Name = "view_dns";
            this.view_dns.Size = new System.Drawing.Size(164, 23);
            this.view_dns.TabIndex = 4;
            this.view_dns.Text = "Просмотр DNS-кэша";
            this.view_dns.UseVisualStyleBackColor = true;
            this.view_dns.Click += new System.EventHandler(this.view_dns_Click);
            // 
            // clean_dns
            // 
            this.clean_dns.Location = new System.Drawing.Point(209, 97);
            this.clean_dns.Name = "clean_dns";
            this.clean_dns.Size = new System.Drawing.Size(164, 23);
            this.clean_dns.TabIndex = 5;
            this.clean_dns.Text = "Очистка DNS-кэша";
            this.clean_dns.UseVisualStyleBackColor = true;
            this.clean_dns.Click += new System.EventHandler(this.clean_dns_Click);
            // 
            // groupBox_services
            // 
            this.groupBox_services.Controls.Add(this.kill_services);
            this.groupBox_services.Controls.Add(this.update);
            this.groupBox_services.Controls.Add(this.fax);
            this.groupBox_services.Controls.Add(this.smart_map);
            this.groupBox_services.Controls.Add(this.bio);
            this.groupBox_services.Controls.Add(this.wmi);
            this.groupBox_services.Location = new System.Drawing.Point(390, 18);
            this.groupBox_services.Name = "groupBox_services";
            this.groupBox_services.Size = new System.Drawing.Size(258, 163);
            this.groupBox_services.TabIndex = 6;
            this.groupBox_services.TabStop = false;
            this.groupBox_services.Text = "Выберите службы, которые хотите отключить";
            this.groupBox_services.Visible = false;
            // 
            // kill_services
            // 
            this.kill_services.Location = new System.Drawing.Point(0, 140);
            this.kill_services.Name = "kill_services";
            this.kill_services.Size = new System.Drawing.Size(258, 23);
            this.kill_services.TabIndex = 5;
            this.kill_services.Text = "Отключить";
            this.kill_services.UseVisualStyleBackColor = true;
            this.kill_services.Click += new System.EventHandler(this.kill_services_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Location = new System.Drawing.Point(7, 116);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(167, 17);
            this.update.TabIndex = 4;
            this.update.Text = "Центр обновления Windows";
            this.update.UseVisualStyleBackColor = true;
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Location = new System.Drawing.Point(7, 92);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(55, 17);
            this.fax.TabIndex = 3;
            this.fax.Text = "Факс";
            this.fax.UseVisualStyleBackColor = true;
            // 
            // smart_map
            // 
            this.smart_map.AutoSize = true;
            this.smart_map.Location = new System.Drawing.Point(7, 68);
            this.smart_map.Name = "smart_map";
            this.smart_map.Size = new System.Drawing.Size(90, 17);
            this.smart_map.TabIndex = 2;
            this.smart_map.Text = "Смарт-карта";
            this.smart_map.UseVisualStyleBackColor = true;
            // 
            // bio
            // 
            this.bio.AutoSize = true;
            this.bio.Location = new System.Drawing.Point(7, 44);
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(198, 17);
            this.bio.TabIndex = 1;
            this.bio.Text = "Биометрическая служба Windows";
            this.bio.UseVisualStyleBackColor = true;
            // 
            // wmi
            // 
            this.wmi.AutoSize = true;
            this.wmi.Location = new System.Drawing.Point(7, 20);
            this.wmi.Name = "wmi";
            this.wmi.Size = new System.Drawing.Size(203, 17);
            this.wmi.TabIndex = 0;
            this.wmi.Text = "Адаптер производительности WMI";
            this.wmi.ThreeState = true;
            this.wmi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cleanmgr);
            this.groupBox1.Controls.Add(this.sxs_second);
            this.groupBox1.Controls.Add(this.sxs_first);
            this.groupBox1.Location = new System.Drawing.Point(390, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор очистки";
            this.groupBox1.Visible = false;
            // 
            // cleanmgr
            // 
            this.cleanmgr.Location = new System.Drawing.Point(6, 77);
            this.cleanmgr.Name = "cleanmgr";
            this.cleanmgr.Size = new System.Drawing.Size(91, 23);
            this.cleanmgr.TabIndex = 4;
            this.cleanmgr.Text = "Cleanmgr";
            this.cleanmgr.UseVisualStyleBackColor = true;
            this.cleanmgr.Click += new System.EventHandler(this.cleanmgr_Click);
            // 
            // sxs_second
            // 
            this.sxs_second.Location = new System.Drawing.Point(6, 48);
            this.sxs_second.Name = "sxs_second";
            this.sxs_second.Size = new System.Drawing.Size(91, 23);
            this.sxs_second.TabIndex = 3;
            this.sxs_second.Text = "WinSxs шаг 2";
            this.sxs_second.UseVisualStyleBackColor = true;
            this.sxs_second.Click += new System.EventHandler(this.sxs_second_Click);
            // 
            // sxs_first
            // 
            this.sxs_first.Location = new System.Drawing.Point(6, 19);
            this.sxs_first.Name = "sxs_first";
            this.sxs_first.Size = new System.Drawing.Size(91, 23);
            this.sxs_first.TabIndex = 2;
            this.sxs_first.Text = "WinSxS шаг 1";
            this.sxs_first.UseVisualStyleBackColor = true;
            this.sxs_first.Click += new System.EventHandler(this.sxs_first_Click);
            // 
            // regedit
            // 
            this.regedit.Location = new System.Drawing.Point(209, 127);
            this.regedit.Name = "regedit";
            this.regedit.Size = new System.Drawing.Size(164, 23);
            this.regedit.TabIndex = 8;
            this.regedit.Text = "Редактор реестра";
            this.regedit.UseVisualStyleBackColor = true;
            this.regedit.Click += new System.EventHandler(this.regedit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.regedit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_services);
            this.Controls.Add(this.clean_dns);
            this.Controls.Add(this.view_dns);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.services);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.buttom_disk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DimLab";
            this.groupBox_services.ResumeLayout(false);
            this.groupBox_services.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttom_disk;
        private System.Windows.Forms.Label disk;
        private System.Windows.Forms.CheckBox services;
        private System.Windows.Forms.CheckBox clean;
        private System.Windows.Forms.Button view_dns;
        private System.Windows.Forms.Button clean_dns;
        private System.Windows.Forms.GroupBox groupBox_services;
        private System.Windows.Forms.Button kill_services;
        private System.Windows.Forms.CheckBox update;
        private System.Windows.Forms.CheckBox fax;
        private System.Windows.Forms.CheckBox smart_map;
        private System.Windows.Forms.CheckBox bio;
        private System.Windows.Forms.CheckBox wmi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sxs_second;
        private System.Windows.Forms.Button sxs_first;
        private System.Windows.Forms.Button cleanmgr;
        private System.Windows.Forms.Button regedit;
    }
}

