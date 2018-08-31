namespace CG_ThucHanh1
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
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnCircleMove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(138, 12);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(615, 359);
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 31);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(87, 37);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Vong Tron";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnCircleMove
            // 
            this.btnCircleMove.Location = new System.Drawing.Point(12, 116);
            this.btnCircleMove.Name = "btnCircleMove";
            this.btnCircleMove.Size = new System.Drawing.Size(87, 37);
            this.btnCircleMove.TabIndex = 1;
            this.btnCircleMove.Text = "Vong tron di duyen";
            this.btnCircleMove.UseVisualStyleBackColor = true;
            this.btnCircleMove.Click += new System.EventHandler(this.btnCircleMove_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(238, 398);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(403, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(560, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCircleMove);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.pbxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnCircleMove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer1;
    }
}

