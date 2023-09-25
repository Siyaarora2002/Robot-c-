
namespace WinRobot
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
            this.arrowPanel = new System.Windows.Forms.Panel();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.distanceLbl = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnGoOne = new System.Windows.Forms.Button();
            this.btnGoTen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.arrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrowPanel
            // 
            this.arrowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrowPanel.Controls.Add(this.arrowLabel);
            this.arrowPanel.Location = new System.Drawing.Point(34, 47);
            this.arrowPanel.Name = "arrowPanel";
            this.arrowPanel.Size = new System.Drawing.Size(329, 197);
            this.arrowPanel.TabIndex = 0;
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.Font = new System.Drawing.Font("Wingdings 3", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.arrowLabel.Location = new System.Drawing.Point(102, 74);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(36, 39);
            this.arrowLabel.TabIndex = 0;
            this.arrowLabel.Text = "5";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(33, 12);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(18, 17);
            this.pointLabel.TabIndex = 1;
            this.pointLabel.Text = "{}";
            // 
            // distanceLbl
            // 
            this.distanceLbl.AutoSize = true;
            this.distanceLbl.Location = new System.Drawing.Point(281, 12);
            this.distanceLbl.Name = "distanceLbl";
            this.distanceLbl.Size = new System.Drawing.Size(127, 17);
            this.distanceLbl.TabIndex = 2;
            this.distanceLbl.Text = "Total Distance= 70";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(143, 255);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(30, 31);
            this.btnNorth.TabIndex = 3;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.northButton_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(142, 313);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(30, 31);
            this.btnSouth.TabIndex = 4;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.southButton_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(113, 284);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(30, 31);
            this.btnWest.TabIndex = 5;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.westButton_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(172, 284);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(30, 31);
            this.btnEast.TabIndex = 6;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.eastButton_Click);
            // 
            // btnGoOne
            // 
            this.btnGoOne.Location = new System.Drawing.Point(34, 284);
            this.btnGoOne.Name = "btnGoOne";
            this.btnGoOne.Size = new System.Drawing.Size(57, 31);
            this.btnGoOne.TabIndex = 7;
            this.btnGoOne.Text = "Go 1";
            this.btnGoOne.UseVisualStyleBackColor = true;
            this.btnGoOne.Click += new System.EventHandler(this.goOneButton_Click);
            // 
            // btnGoTen
            // 
            this.btnGoTen.Location = new System.Drawing.Point(224, 283);
            this.btnGoTen.Name = "btnGoTen";
            this.btnGoTen.Size = new System.Drawing.Size(57, 31);
            this.btnGoTen.TabIndex = 8;
            this.btnGoTen.Text = "Go 10";
            this.btnGoTen.UseVisualStyleBackColor = true;
            this.btnGoTen.Click += new System.EventHandler(this.goTenButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(158, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 420);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoTen);
            this.Controls.Add(this.btnGoOne);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.distanceLbl);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.arrowPanel);
            this.Name = "Form1";
            this.Text = "Robot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.arrowPanel.ResumeLayout(false);
            this.arrowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel arrowPanel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label distanceLbl;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnGoOne;
        private System.Windows.Forms.Button btnGoTen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label arrowLabel;
    }
}

