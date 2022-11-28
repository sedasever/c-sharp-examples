namespace zombie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tier = new System.Windows.Forms.PictureBox();
            this.Hunter = new System.Windows.Forms.PictureBox();
            this.Chimera = new System.Windows.Forms.PictureBox();
            this.Robokill = new System.Windows.Forms.PictureBox();
            this.pcTier = new System.Windows.Forms.PictureBox();
            this.pcRobokill = new System.Windows.Forms.PictureBox();
            this.pcHunter = new System.Windows.Forms.PictureBox();
            this.pcChimera = new System.Windows.Forms.PictureBox();
            this.HitButton = new System.Windows.Forms.Button();
            this.radioButtonRobkill = new System.Windows.Forms.RadioButton();
            this.radioButtonChimera = new System.Windows.Forms.RadioButton();
            this.radioButtonTier = new System.Windows.Forms.RadioButton();
            this.radioButtonHunter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.pcTextBox = new System.Windows.Forms.TextBox();
            this.pcHealthTextBox = new System.Windows.Forms.TextBox();
            this.yourHealthTextBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hunter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chimera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robokill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRobokill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHunter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChimera)).BeginInit();
            this.SuspendLayout();
            // 
            // Tier
            // 
            this.Tier.Image = ((System.Drawing.Image)(resources.GetObject("Tier.Image")));
            this.Tier.Location = new System.Drawing.Point(248, 54);
            this.Tier.Name = "Tier";
            this.Tier.Size = new System.Drawing.Size(192, 248);
            this.Tier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tier.TabIndex = 0;
            this.Tier.TabStop = false;
            // 
            // Hunter
            // 
            this.Hunter.Image = ((System.Drawing.Image)(resources.GetObject("Hunter.Image")));
            this.Hunter.Location = new System.Drawing.Point(248, 54);
            this.Hunter.Name = "Hunter";
            this.Hunter.Size = new System.Drawing.Size(192, 248);
            this.Hunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hunter.TabIndex = 1;
            this.Hunter.TabStop = false;
            // 
            // Chimera
            // 
            this.Chimera.BackColor = System.Drawing.Color.Transparent;
            this.Chimera.Image = ((System.Drawing.Image)(resources.GetObject("Chimera.Image")));
            this.Chimera.Location = new System.Drawing.Point(248, 54);
            this.Chimera.Name = "Chimera";
            this.Chimera.Size = new System.Drawing.Size(192, 248);
            this.Chimera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chimera.TabIndex = 2;
            this.Chimera.TabStop = false;
            // 
            // Robokill
            // 
            this.Robokill.Image = ((System.Drawing.Image)(resources.GetObject("Robokill.Image")));
            this.Robokill.Location = new System.Drawing.Point(248, 54);
            this.Robokill.Name = "Robokill";
            this.Robokill.Size = new System.Drawing.Size(192, 248);
            this.Robokill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Robokill.TabIndex = 3;
            this.Robokill.TabStop = false;
            // 
            // pcTier
            // 
            this.pcTier.Image = ((System.Drawing.Image)(resources.GetObject("pcTier.Image")));
            this.pcTier.Location = new System.Drawing.Point(1028, 54);
            this.pcTier.Name = "pcTier";
            this.pcTier.Size = new System.Drawing.Size(192, 248);
            this.pcTier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTier.TabIndex = 4;
            this.pcTier.TabStop = false;
            // 
            // pcRobokill
            // 
            this.pcRobokill.Image = ((System.Drawing.Image)(resources.GetObject("pcRobokill.Image")));
            this.pcRobokill.Location = new System.Drawing.Point(1028, 54);
            this.pcRobokill.Name = "pcRobokill";
            this.pcRobokill.Size = new System.Drawing.Size(192, 248);
            this.pcRobokill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcRobokill.TabIndex = 5;
            this.pcRobokill.TabStop = false;
            // 
            // pcHunter
            // 
            this.pcHunter.Image = ((System.Drawing.Image)(resources.GetObject("pcHunter.Image")));
            this.pcHunter.Location = new System.Drawing.Point(1028, 54);
            this.pcHunter.Name = "pcHunter";
            this.pcHunter.Size = new System.Drawing.Size(192, 248);
            this.pcHunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHunter.TabIndex = 6;
            this.pcHunter.TabStop = false;
            // 
            // pcChimera
            // 
            this.pcChimera.BackColor = System.Drawing.Color.Transparent;
            this.pcChimera.Image = ((System.Drawing.Image)(resources.GetObject("pcChimera.Image")));
            this.pcChimera.Location = new System.Drawing.Point(1028, 54);
            this.pcChimera.Name = "pcChimera";
            this.pcChimera.Size = new System.Drawing.Size(192, 248);
            this.pcChimera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcChimera.TabIndex = 7;
            this.pcChimera.TabStop = false;
            // 
            // HitButton
            // 
            this.HitButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.HitButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HitButton.Location = new System.Drawing.Point(613, 178);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(230, 95);
            this.HitButton.TabIndex = 8;
            this.HitButton.Text = "HIT";
            this.HitButton.UseVisualStyleBackColor = false;
            this.HitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonRobkill
            // 
            this.radioButtonRobkill.AutoSize = true;
            this.radioButtonRobkill.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonRobkill.Location = new System.Drawing.Point(23, 75);
            this.radioButtonRobkill.Name = "radioButtonRobkill";
            this.radioButtonRobkill.Size = new System.Drawing.Size(173, 40);
            this.radioButtonRobkill.TabIndex = 9;
            this.radioButtonRobkill.TabStop = true;
            this.radioButtonRobkill.Text = "Robkill";
            this.radioButtonRobkill.UseVisualStyleBackColor = true;
            this.radioButtonRobkill.CheckedChanged += new System.EventHandler(this.radioButtonRobkill_CheckedChanged);
            // 
            // radioButtonChimera
            // 
            this.radioButtonChimera.AutoSize = true;
            this.radioButtonChimera.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonChimera.Location = new System.Drawing.Point(23, 129);
            this.radioButtonChimera.Name = "radioButtonChimera";
            this.radioButtonChimera.Size = new System.Drawing.Size(173, 40);
            this.radioButtonChimera.TabIndex = 10;
            this.radioButtonChimera.TabStop = true;
            this.radioButtonChimera.Text = "Chimera";
            this.radioButtonChimera.UseVisualStyleBackColor = true;
            this.radioButtonChimera.CheckedChanged += new System.EventHandler(this.radioButtonChimera_CheckedChanged);
            // 
            // radioButtonTier
            // 
            this.radioButtonTier.AutoSize = true;
            this.radioButtonTier.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonTier.Location = new System.Drawing.Point(23, 178);
            this.radioButtonTier.Name = "radioButtonTier";
            this.radioButtonTier.Size = new System.Drawing.Size(116, 40);
            this.radioButtonTier.TabIndex = 11;
            this.radioButtonTier.TabStop = true;
            this.radioButtonTier.Text = "Tier";
            this.radioButtonTier.UseVisualStyleBackColor = true;
            this.radioButtonTier.CheckedChanged += new System.EventHandler(this.radioButtonTier_CheckedChanged);
            // 
            // radioButtonHunter
            // 
            this.radioButtonHunter.AutoSize = true;
            this.radioButtonHunter.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonHunter.Location = new System.Drawing.Point(23, 229);
            this.radioButtonHunter.Name = "radioButtonHunter";
            this.radioButtonHunter.Size = new System.Drawing.Size(154, 40);
            this.radioButtonHunter.TabIndex = 12;
            this.radioButtonHunter.TabStop = true;
            this.radioButtonHunter.Text = "Hunter";
            this.radioButtonHunter.UseVisualStyleBackColor = true;
            this.radioButtonHunter.CheckedChanged += new System.EventHandler(this.radioButtonHunter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(487, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 89);
            this.label1.TabIndex = 13;
            this.label1.Text = "ZOMBIE WAR";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.CadetBlue;
            this.StartButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(559, 340);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(334, 95);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pcTextBox
            // 
            this.pcTextBox.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pcTextBox.Location = new System.Drawing.Point(1028, 12);
            this.pcTextBox.Name = "pcTextBox";
            this.pcTextBox.Size = new System.Drawing.Size(438, 44);
            this.pcTextBox.TabIndex = 15;
            this.pcTextBox.Text = "Computer Choose";
            // 
            // pcHealthTextBox
            // 
            this.pcHealthTextBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pcHealthTextBox.Location = new System.Drawing.Point(1028, 324);
            this.pcHealthTextBox.Name = "pcHealthTextBox";
            this.pcHealthTextBox.Size = new System.Drawing.Size(269, 35);
            this.pcHealthTextBox.TabIndex = 16;
            this.pcHealthTextBox.Text = "Health:";
            // 
            // yourHealthTextBox
            // 
            this.yourHealthTextBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourHealthTextBox.Location = new System.Drawing.Point(171, 324);
            this.yourHealthTextBox.Name = "yourHealthTextBox";
            this.yourHealthTextBox.Size = new System.Drawing.Size(269, 35);
            this.yourHealthTextBox.TabIndex = 17;
            this.yourHealthTextBox.Text = "Health:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 495);
            this.Controls.Add(this.yourHealthTextBox);
            this.Controls.Add(this.pcHealthTextBox);
            this.Controls.Add(this.pcTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonHunter);
            this.Controls.Add(this.radioButtonTier);
            this.Controls.Add(this.radioButtonChimera);
            this.Controls.Add(this.radioButtonRobkill);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.pcChimera);
            this.Controls.Add(this.pcHunter);
            this.Controls.Add(this.pcRobokill);
            this.Controls.Add(this.pcTier);
            this.Controls.Add(this.Hunter);
            this.Controls.Add(this.Chimera);
            this.Controls.Add(this.Robokill);
            this.Controls.Add(this.Tier);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hunter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chimera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robokill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRobokill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHunter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChimera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Tier;
        private PictureBox Hunter;
        private PictureBox Chimera;
        private PictureBox Robokill;
        private PictureBox pcTier;
        private PictureBox pcRobokill;
        private PictureBox pcHunter;
        private PictureBox pcChimera;
        private Button HitButton;
        private RadioButton radioButtonRobkill;
        private RadioButton radioButtonChimera;
        private RadioButton radioButtonTier;
        private RadioButton radioButtonHunter;
        private Label label1;
        private Button StartButton;
        private TextBox pcTextBox;
        private TextBox pcHealthTextBox;
        private TextBox yourHealthTextBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}