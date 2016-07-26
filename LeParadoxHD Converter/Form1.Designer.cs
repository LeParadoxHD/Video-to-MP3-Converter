namespace LeParadoxHD_Converter
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.getVideo = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroLabel();
            this.linkYouTube = new MetroFramework.Controls.MetroLink();
            this.progreso = new MetroFramework.Controls.MetroProgressBar();
            this.customName = new MetroFramework.Controls.MetroTextBox();
            this.mismoNombre = new MetroFramework.Controls.MetroCheckBox();
            this.comenzarButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.quality = new MetroFramework.Controls.MetroLabel();
            this.calidad = new MetroFramework.Controls.MetroComboBox();
            this.CPUCores = new MetroFramework.Controls.MetroLabel();
            this.cores = new MetroFramework.Controls.MetroComboBox();
            this.fotos = new MetroFramework.Controls.MetroLabel();
            this.frameRate = new MetroFramework.Controls.MetroComboBox();
            this.resolucion = new MetroFramework.Controls.MetroLabel();
            this.resolution = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.changeTheme = new MetroFramework.Controls.MetroToggle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getVideo
            // 
            this.getVideo.AllowDrop = true;
            this.getVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getVideo.ForeColor = System.Drawing.Color.White;
            this.getVideo.Location = new System.Drawing.Point(0, 25);
            this.getVideo.Name = "getVideo";
            this.getVideo.Size = new System.Drawing.Size(516, 133);
            this.getVideo.Style = MetroFramework.MetroColorStyle.Blue;
            this.getVideo.TabIndex = 0;
            this.getVideo.Text = "Arrastre o haga clic para seleccionar vídeo.";
            this.getVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getVideo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.getVideo.Click += new System.EventHandler(this.getVideo_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(5, 158);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(220, 23);
            this.status.Style = MetroFramework.MetroColorStyle.Blue;
            this.status.TabIndex = 14;
            this.status.Text = "Iniciado";
            this.status.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // linkYouTube
            // 
            this.linkYouTube.AutoSize = true;
            this.linkYouTube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkYouTube.Location = new System.Drawing.Point(349, 157);
            this.linkYouTube.Name = "linkYouTube";
            this.linkYouTube.Size = new System.Drawing.Size(166, 23);
            this.linkYouTube.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkYouTube.TabIndex = 15;
            this.linkYouTube.Text = "Visita mi canal de YouTube";
            this.linkYouTube.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkYouTube.UseSelectable = true;
            this.linkYouTube.Click += new System.EventHandler(this.linkYouTube_Click);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(201, 162);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(150, 13);
            this.progreso.Style = MetroFramework.MetroColorStyle.Green;
            this.progreso.TabIndex = 16;
            this.progreso.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progreso.Visible = false;
            // 
            // customName
            // 
            // 
            // 
            // 
            this.customName.CustomButton.Image = null;
            this.customName.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.customName.CustomButton.Name = "";
            this.customName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.customName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customName.CustomButton.TabIndex = 1;
            this.customName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customName.CustomButton.UseSelectable = true;
            this.customName.CustomButton.Visible = false;
            this.customName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.customName.Lines = new string[0];
            this.customName.Location = new System.Drawing.Point(700, 39);
            this.customName.MaxLength = 32767;
            this.customName.Name = "customName";
            this.customName.PasswordChar = '\0';
            this.customName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customName.SelectedText = "";
            this.customName.SelectionLength = 0;
            this.customName.SelectionStart = 0;
            this.customName.ShortcutsEnabled = true;
            this.customName.Size = new System.Drawing.Size(226, 25);
            this.customName.Style = MetroFramework.MetroColorStyle.Blue;
            this.customName.TabIndex = 17;
            this.customName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.customName.UseSelectable = true;
            this.customName.Visible = false;
            this.customName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mismoNombre
            // 
            this.mismoNombre.AutoSize = true;
            this.mismoNombre.Checked = true;
            this.mismoNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mismoNombre.Location = new System.Drawing.Point(700, 44);
            this.mismoNombre.Name = "mismoNombre";
            this.mismoNombre.Size = new System.Drawing.Size(105, 15);
            this.mismoNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.mismoNombre.TabIndex = 7;
            this.mismoNombre.Text = "Mismo nombre";
            this.mismoNombre.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mismoNombre.UseSelectable = true;
            this.mismoNombre.Visible = false;
            this.mismoNombre.CheckStateChanged += new System.EventHandler(this.mismoNombre_CheckStateChanged);
            // 
            // comenzarButton
            // 
            this.comenzarButton.Highlight = true;
            this.comenzarButton.Location = new System.Drawing.Point(-500, 33);
            this.comenzarButton.Name = "comenzarButton";
            this.comenzarButton.Size = new System.Drawing.Size(119, 35);
            this.comenzarButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.comenzarButton.TabIndex = 18;
            this.comenzarButton.Text = "Procesar";
            this.comenzarButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comenzarButton.UseSelectable = true;
            this.comenzarButton.Visible = false;
            this.comenzarButton.Click += new System.EventHandler(this.comenzarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LeParadoxHD_Converter.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(207, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "LeParadoxHD Video Compressing";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quality
            // 
            this.quality.AutoSize = true;
            this.quality.Location = new System.Drawing.Point(-500, 83);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(57, 19);
            this.quality.Style = MetroFramework.MetroColorStyle.Blue;
            this.quality.TabIndex = 21;
            this.quality.Text = "Calidad:";
            this.quality.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quality.Visible = false;
            // 
            // calidad
            // 
            this.calidad.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.calidad.FormattingEnabled = true;
            this.calidad.ItemHeight = 19;
            this.calidad.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta",
            "Ultra",
            "Sin pérdida"});
            this.calidad.Location = new System.Drawing.Point(-500, 82);
            this.calidad.Name = "calidad";
            this.calidad.Size = new System.Drawing.Size(96, 25);
            this.calidad.Style = MetroFramework.MetroColorStyle.Blue;
            this.calidad.TabIndex = 22;
            this.calidad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.calidad.UseSelectable = true;
            this.calidad.Visible = false;
            // 
            // CPUCores
            // 
            this.CPUCores.AutoSize = true;
            this.CPUCores.Location = new System.Drawing.Point(-500, 83);
            this.CPUCores.Name = "CPUCores";
            this.CPUCores.Size = new System.Drawing.Size(149, 19);
            this.CPUCores.Style = MetroFramework.MetroColorStyle.Blue;
            this.CPUCores.TabIndex = 23;
            this.CPUCores.Text = "Núcleos de procesador:";
            this.CPUCores.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CPUCores.Visible = false;
            // 
            // cores
            // 
            this.cores.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cores.FormattingEnabled = true;
            this.cores.ItemHeight = 19;
            this.cores.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cores.Location = new System.Drawing.Point(700, 82);
            this.cores.Name = "cores";
            this.cores.Size = new System.Drawing.Size(42, 25);
            this.cores.Style = MetroFramework.MetroColorStyle.Blue;
            this.cores.TabIndex = 24;
            this.cores.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cores.UseSelectable = true;
            this.cores.Visible = false;
            // 
            // fotos
            // 
            this.fotos.AutoSize = true;
            this.fotos.Location = new System.Drawing.Point(700, 85);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(34, 19);
            this.fotos.Style = MetroFramework.MetroColorStyle.Blue;
            this.fotos.TabIndex = 25;
            this.fotos.Text = "FPS:";
            this.fotos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fotos.Visible = false;
            // 
            // frameRate
            // 
            this.frameRate.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.frameRate.FormattingEnabled = true;
            this.frameRate.ItemHeight = 19;
            this.frameRate.Items.AddRange(new object[] {
            "Igual",
            "5",
            "10",
            "12",
            "15",
            "23",
            "24",
            "29",
            "30",
            "50",
            "59",
            "60",
            "70",
            "75",
            "90",
            "120"});
            this.frameRate.Location = new System.Drawing.Point(700, 82);
            this.frameRate.Name = "frameRate";
            this.frameRate.Size = new System.Drawing.Size(74, 25);
            this.frameRate.Style = MetroFramework.MetroColorStyle.Blue;
            this.frameRate.TabIndex = 26;
            this.frameRate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.frameRate.UseSelectable = true;
            this.frameRate.Visible = false;
            // 
            // resolucion
            // 
            this.resolucion.AutoSize = true;
            this.resolucion.Location = new System.Drawing.Point(-500, 125);
            this.resolucion.Name = "resolucion";
            this.resolucion.Size = new System.Drawing.Size(74, 19);
            this.resolucion.Style = MetroFramework.MetroColorStyle.Blue;
            this.resolucion.TabIndex = 27;
            this.resolucion.Text = "Resolución:";
            this.resolucion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resolucion.Visible = false;
            // 
            // resolution
            // 
            this.resolution.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.resolution.FormattingEnabled = true;
            this.resolution.ItemHeight = 19;
            this.resolution.Items.AddRange(new object[] {
            "Igual",
            "256 x 144",
            "640 x 360",
            "852 x 480",
            "1024 x 576",
            "1280 x 720",
            "1600 x 900",
            "1920 x 1080",
            "2560 x 1440",
            "3840 x 2160"});
            this.resolution.Location = new System.Drawing.Point(-500, 124);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(96, 25);
            this.resolution.Style = MetroFramework.MetroColorStyle.Blue;
            this.resolution.TabIndex = 22;
            this.resolution.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resolution.UseSelectable = true;
            this.resolution.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(284, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Tema Oscuro:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // changeTheme
            // 
            this.changeTheme.AutoSize = true;
            this.changeTheme.Checked = true;
            this.changeTheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.changeTheme.DisplayStatus = false;
            this.changeTheme.Location = new System.Drawing.Point(375, 11);
            this.changeTheme.Name = "changeTheme";
            this.changeTheme.Size = new System.Drawing.Size(50, 17);
            this.changeTheme.Style = MetroFramework.MetroColorStyle.Blue;
            this.changeTheme.TabIndex = 29;
            this.changeTheme.Text = "On";
            this.changeTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.changeTheme.UseSelectable = true;
            this.changeTheme.CheckStateChanged += new System.EventHandler(this.changeTheme_CheckedStateChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 181);
            this.Controls.Add(this.changeTheme);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.resolucion);
            this.Controls.Add(this.frameRate);
            this.Controls.Add(this.fotos);
            this.Controls.Add(this.cores);
            this.Controls.Add(this.CPUCores);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.calidad);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comenzarButton);
            this.Controls.Add(this.mismoNombre);
            this.Controls.Add(this.customName);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.linkYouTube);
            this.Controls.Add(this.status);
            this.Controls.Add(this.getVideo);
            this.DisplayHeader = false;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 181);
            this.MinimumSize = new System.Drawing.Size(514, 181);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "LeParadoxHD Video Compressing";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Controls.MetroLabel getVideo;
        private MetroFramework.Controls.MetroLabel status;
        private MetroFramework.Controls.MetroLink linkYouTube;
        private MetroFramework.Controls.MetroProgressBar progreso;
        private MetroFramework.Controls.MetroTextBox customName;
        private MetroFramework.Controls.MetroCheckBox mismoNombre;
        private MetroFramework.Controls.MetroButton comenzarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel quality;
        private MetroFramework.Controls.MetroComboBox calidad;
        private MetroFramework.Controls.MetroLabel CPUCores;
        private MetroFramework.Controls.MetroComboBox cores;
        private MetroFramework.Controls.MetroLabel fotos;
        private MetroFramework.Controls.MetroComboBox frameRate;
        private MetroFramework.Controls.MetroLabel resolucion;
        private MetroFramework.Controls.MetroComboBox resolution;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle changeTheme;
    }
}

