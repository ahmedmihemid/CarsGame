namespace CarsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GamePanal = new System.Windows.Forms.Panel();
            this.BlueCarPIC = new System.Windows.Forms.PictureBox();
            this.MainCarPIC = new System.Windows.Forms.PictureBox();
            this.WhiteCarPIC = new System.Windows.Forms.PictureBox();
            this.LinePIC3 = new System.Windows.Forms.PictureBox();
            this.LinePIC4 = new System.Windows.Forms.PictureBox();
            this.LinePIC1 = new System.Windows.Forms.PictureBox();
            this.LinePIC5 = new System.Windows.Forms.PictureBox();
            this.LinePIC2 = new System.Windows.Forms.PictureBox();
            this.LinePIC7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.sidewalkPIC1 = new System.Windows.Forms.PictureBox();
            this.sidewalkPIC2 = new System.Windows.Forms.PictureBox();
            this.LinePIC6 = new System.Windows.Forms.PictureBox();
            this.LeabScore = new System.Windows.Forms.Label();
            this.GamePanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueCarPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCarPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCarPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidewalkPIC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidewalkPIC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GamePanal
            // 
            this.GamePanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GamePanal.Controls.Add(this.BlueCarPIC);
            this.GamePanal.Controls.Add(this.MainCarPIC);
            this.GamePanal.Controls.Add(this.WhiteCarPIC);
            this.GamePanal.Controls.Add(this.LinePIC3);
            this.GamePanal.Controls.Add(this.LinePIC4);
            this.GamePanal.Controls.Add(this.LinePIC1);
            this.GamePanal.Controls.Add(this.LinePIC5);
            this.GamePanal.Controls.Add(this.LinePIC2);
            this.GamePanal.Controls.Add(this.LinePIC7);
            this.GamePanal.Location = new System.Drawing.Point(169, 81);
            this.GamePanal.Name = "GamePanal";
            this.GamePanal.Size = new System.Drawing.Size(302, 613);
            this.GamePanal.TabIndex = 26;
            // 
            // BlueCarPIC
            // 
            this.BlueCarPIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlueCarPIC.Image = global::CarsGame.Properties.Resources.BlueCar;
            this.BlueCarPIC.Location = new System.Drawing.Point(225, 21);
            this.BlueCarPIC.Name = "BlueCarPIC";
            this.BlueCarPIC.Size = new System.Drawing.Size(52, 104);
            this.BlueCarPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BlueCarPIC.TabIndex = 17;
            this.BlueCarPIC.TabStop = false;
            // 
            // MainCarPIC
            // 
            this.MainCarPIC.Image = global::CarsGame.Properties.Resources.RedCar;
            this.MainCarPIC.Location = new System.Drawing.Point(118, 428);
            this.MainCarPIC.Name = "MainCarPIC";
            this.MainCarPIC.Size = new System.Drawing.Size(52, 109);
            this.MainCarPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainCarPIC.TabIndex = 27;
            this.MainCarPIC.TabStop = false;
            // 
            // WhiteCarPIC
            // 
            this.WhiteCarPIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WhiteCarPIC.Image = global::CarsGame.Properties.Resources.whitecar;
            this.WhiteCarPIC.Location = new System.Drawing.Point(24, 442);
            this.WhiteCarPIC.Name = "WhiteCarPIC";
            this.WhiteCarPIC.Size = new System.Drawing.Size(52, 104);
            this.WhiteCarPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WhiteCarPIC.TabIndex = 18;
            this.WhiteCarPIC.TabStop = false;
            // 
            // LinePIC3
            // 
            this.LinePIC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC3.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC3.Image")));
            this.LinePIC3.Location = new System.Drawing.Point(138, 224);
            this.LinePIC3.Name = "LinePIC3";
            this.LinePIC3.Size = new System.Drawing.Size(139, 129);
            this.LinePIC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC3.TabIndex = 21;
            this.LinePIC3.TabStop = false;
            // 
            // LinePIC4
            // 
            this.LinePIC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC4.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC4.Image")));
            this.LinePIC4.Location = new System.Drawing.Point(24, 224);
            this.LinePIC4.Name = "LinePIC4";
            this.LinePIC4.Size = new System.Drawing.Size(139, 129);
            this.LinePIC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC4.TabIndex = 22;
            this.LinePIC4.TabStop = false;
            // 
            // LinePIC1
            // 
            this.LinePIC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC1.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC1.Image")));
            this.LinePIC1.Location = new System.Drawing.Point(138, 487);
            this.LinePIC1.Name = "LinePIC1";
            this.LinePIC1.Size = new System.Drawing.Size(139, 129);
            this.LinePIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC1.TabIndex = 12;
            this.LinePIC1.TabStop = false;
            // 
            // LinePIC5
            // 
            this.LinePIC5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC5.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC5.Image")));
            this.LinePIC5.Location = new System.Drawing.Point(144, -10);
            this.LinePIC5.Name = "LinePIC5";
            this.LinePIC5.Size = new System.Drawing.Size(139, 129);
            this.LinePIC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC5.TabIndex = 14;
            this.LinePIC5.TabStop = false;
            // 
            // LinePIC2
            // 
            this.LinePIC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC2.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC2.Image")));
            this.LinePIC2.Location = new System.Drawing.Point(24, 487);
            this.LinePIC2.Name = "LinePIC2";
            this.LinePIC2.Size = new System.Drawing.Size(139, 129);
            this.LinePIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC2.TabIndex = 13;
            this.LinePIC2.TabStop = false;
            // 
            // LinePIC7
            // 
            this.LinePIC7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC7.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC7.Image")));
            this.LinePIC7.Location = new System.Drawing.Point(24, -10);
            this.LinePIC7.Name = "LinePIC7";
            this.LinePIC7.Size = new System.Drawing.Size(139, 129);
            this.LinePIC7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC7.TabIndex = 28;
            this.LinePIC7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox6.Location = new System.Drawing.Point(-3, -11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(624, 98);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // sidewalkPIC1
            // 
            this.sidewalkPIC1.BackColor = System.Drawing.Color.Transparent;
            this.sidewalkPIC1.Image = global::CarsGame.Properties.Resources.sidewalk;
            this.sidewalkPIC1.Location = new System.Drawing.Point(157, 81);
            this.sidewalkPIC1.Name = "sidewalkPIC1";
            this.sidewalkPIC1.Size = new System.Drawing.Size(15, 613);
            this.sidewalkPIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sidewalkPIC1.TabIndex = 25;
            this.sidewalkPIC1.TabStop = false;
            // 
            // sidewalkPIC2
            // 
            this.sidewalkPIC2.BackColor = System.Drawing.Color.Transparent;
            this.sidewalkPIC2.Image = global::CarsGame.Properties.Resources.sidewalk;
            this.sidewalkPIC2.Location = new System.Drawing.Point(467, 84);
            this.sidewalkPIC2.Name = "sidewalkPIC2";
            this.sidewalkPIC2.Size = new System.Drawing.Size(15, 613);
            this.sidewalkPIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sidewalkPIC2.TabIndex = 24;
            this.sidewalkPIC2.TabStop = false;
            // 
            // LinePIC6
            // 
            this.LinePIC6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LinePIC6.Image = ((System.Drawing.Image)(resources.GetObject("LinePIC6.Image")));
            this.LinePIC6.Location = new System.Drawing.Point(193, 93);
            this.LinePIC6.Name = "LinePIC6";
            this.LinePIC6.Size = new System.Drawing.Size(139, 129);
            this.LinePIC6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LinePIC6.TabIndex = 15;
            this.LinePIC6.TabStop = false;
            // 
            // LeabScore
            // 
            this.LeabScore.AutoSize = true;
            this.LeabScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LeabScore.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeabScore.Location = new System.Drawing.Point(299, 23);
            this.LeabScore.Name = "LeabScore";
            this.LeabScore.Size = new System.Drawing.Size(40, 45);
            this.LeabScore.TabIndex = 27;
            this.LeabScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(619, 695);
            this.Controls.Add(this.GamePanal);
            this.Controls.Add(this.LeabScore);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sidewalkPIC1);
            this.Controls.Add(this.sidewalkPIC2);
            this.Controls.Add(this.LinePIC6);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GamePanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BlueCarPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainCarPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCarPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidewalkPIC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidewalkPIC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinePIC6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox WhiteCarPIC;
        private System.Windows.Forms.PictureBox BlueCarPIC;
        private System.Windows.Forms.PictureBox LinePIC6;
        private System.Windows.Forms.PictureBox LinePIC5;
        private System.Windows.Forms.PictureBox LinePIC2;
        private System.Windows.Forms.PictureBox LinePIC1;
        private System.Windows.Forms.PictureBox LinePIC4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox sidewalkPIC2;
        private System.Windows.Forms.PictureBox sidewalkPIC1;
        private System.Windows.Forms.Panel GamePanal;
        private System.Windows.Forms.PictureBox LinePIC3;
        private System.Windows.Forms.PictureBox MainCarPIC;
        private System.Windows.Forms.Label LeabScore;
        private System.Windows.Forms.PictureBox LinePIC7;
    }
}

