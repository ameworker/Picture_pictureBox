namespace Picture_pictureBox
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
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAnswerAnimal = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnRandomPicture = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAnswerNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(10, 415);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(117, 23);
            this.btnAddPicture.TabIndex = 0;
            this.btnAddPicture.Text = "Dodaj/zmień zdjęcie";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Location = new System.Drawing.Point(256, 415);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(127, 23);
            this.btnRemovePicture.TabIndex = 0;
            this.btnRemovePicture.Text = "Usuń zdjęcie";
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jakie to zwierzę/zwierzęta?";
            // 
            // txbAnswerAnimal
            // 
            this.txbAnswerAnimal.Location = new System.Drawing.Point(241, 16);
            this.txbAnswerAnimal.Name = "txbAnswerAnimal";
            this.txbAnswerAnimal.Size = new System.Drawing.Size(332, 20);
            this.txbAnswerAnimal.TabIndex = 4;
            this.txbAnswerAnimal.TextChanged += new System.EventHandler(this.txbAnswerAnimal_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(511, 569);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(12, 441);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(588, 57);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = " ";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRandomPicture
            // 
            this.btnRandomPicture.Location = new System.Drawing.Point(133, 415);
            this.btnRandomPicture.Name = "btnRandomPicture";
            this.btnRandomPicture.Size = new System.Drawing.Size(117, 23);
            this.btnRandomPicture.TabIndex = 0;
            this.btnRandomPicture.Text = "LOSUJ zdjęcie";
            this.btnRandomPicture.UseVisualStyleBackColor = true;
            this.btnRandomPicture.Click += new System.EventHandler(this.btnRandomPicture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ile widzisz zwierząt?";
            // 
            // txbAnswerNumber
            // 
            this.txbAnswerNumber.Location = new System.Drawing.Point(241, 42);
            this.txbAnswerNumber.Name = "txbAnswerNumber";
            this.txbAnswerNumber.Size = new System.Drawing.Size(332, 20);
            this.txbAnswerNumber.TabIndex = 4;
            this.txbAnswerNumber.TextChanged += new System.EventHandler(this.txbAnswerNumber_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbAnswerNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbAnswerAnimal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zgadnij!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 641);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRandomPicture);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAnswerAnimal;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnRandomPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAnswerNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

