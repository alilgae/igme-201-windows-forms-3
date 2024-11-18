namespace MathQuiz
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.lblPlusEquals = new System.Windows.Forms.Label();
            this.numSum = new System.Windows.Forms.NumericUpDown();
            this.numDiff = new System.Windows.Forms.NumericUpDown();
            this.lblMinusEquals = new System.Windows.Forms.Label();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.numProd = new System.Windows.Forms.NumericUpDown();
            this.lblTimesEquals = new System.Windows.Forms.Label();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.numQuotient = new System.Windows.Forms.NumericUpDown();
            this.lblDivEquals = new System.Windows.Forms.Label();
            this.lblDivRight = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblDivLeft = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuotient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(266, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 30);
            this.lblTime.TabIndex = 0;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(104, 9);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(150, 30);
            this.lblTimeLeft.TabIndex = 1;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(48, 70);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 2;
            this.lblPlusLeft.Text = "?";
            this.lblPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlus
            // 
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(114, 70);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(60, 50);
            this.lblPlus.TabIndex = 3;
            this.lblPlus.Text = "+";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(180, 70);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 4;
            this.lblPlusRight.Text = "?";
            this.lblPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusEquals
            // 
            this.lblPlusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusEquals.Location = new System.Drawing.Point(246, 70);
            this.lblPlusEquals.Name = "lblPlusEquals";
            this.lblPlusEquals.Size = new System.Drawing.Size(60, 50);
            this.lblPlusEquals.TabIndex = 5;
            this.lblPlusEquals.Text = "=";
            this.lblPlusEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSum
            // 
            this.numSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSum.Location = new System.Drawing.Point(312, 70);
            this.numSum.MaximumSize = new System.Drawing.Size(100, 0);
            this.numSum.Name = "numSum";
            this.numSum.Size = new System.Drawing.Size(100, 48);
            this.numSum.TabIndex = 1;
            // 
            // numDiff
            // 
            this.numDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiff.Location = new System.Drawing.Point(312, 120);
            this.numDiff.MaximumSize = new System.Drawing.Size(100, 0);
            this.numDiff.Name = "numDiff";
            this.numDiff.Size = new System.Drawing.Size(100, 48);
            this.numDiff.TabIndex = 2;
            this.numDiff.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblMinusEquals
            // 
            this.lblMinusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusEquals.Location = new System.Drawing.Point(246, 120);
            this.lblMinusEquals.Name = "lblMinusEquals";
            this.lblMinusEquals.Size = new System.Drawing.Size(60, 50);
            this.lblMinusEquals.TabIndex = 10;
            this.lblMinusEquals.Text = "=";
            this.lblMinusEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinusEquals.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(180, 120);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 9;
            this.lblMinusRight.Text = "?";
            this.lblMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinusRight.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(114, 120);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(60, 50);
            this.lblMinus.TabIndex = 8;
            this.lblMinus.Text = "-";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinus.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(48, 120);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 7;
            this.lblMinusLeft.Text = "?";
            this.lblMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinusLeft.Click += new System.EventHandler(this.label4_Click);
            // 
            // numProd
            // 
            this.numProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProd.Location = new System.Drawing.Point(312, 170);
            this.numProd.MaximumSize = new System.Drawing.Size(100, 0);
            this.numProd.Name = "numProd";
            this.numProd.Size = new System.Drawing.Size(100, 48);
            this.numProd.TabIndex = 3;
            // 
            // lblTimesEquals
            // 
            this.lblTimesEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesEquals.Location = new System.Drawing.Point(246, 170);
            this.lblTimesEquals.Name = "lblTimesEquals";
            this.lblTimesEquals.Size = new System.Drawing.Size(60, 50);
            this.lblTimesEquals.TabIndex = 15;
            this.lblTimesEquals.Text = "=";
            this.lblTimesEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(180, 170);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 14;
            this.lblTimesRight.Text = "?";
            this.lblTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimes
            // 
            this.lblTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(114, 170);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(60, 50);
            this.lblTimes.TabIndex = 13;
            this.lblTimes.Text = "×";
            this.lblTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(48, 170);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 12;
            this.lblTimesLeft.Text = "?";
            this.lblTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numQuotient
            // 
            this.numQuotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuotient.Location = new System.Drawing.Point(312, 224);
            this.numQuotient.MaximumSize = new System.Drawing.Size(100, 0);
            this.numQuotient.Name = "numQuotient";
            this.numQuotient.Size = new System.Drawing.Size(100, 48);
            this.numQuotient.TabIndex = 4;
            // 
            // lblDivEquals
            // 
            this.lblDivEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivEquals.Location = new System.Drawing.Point(246, 224);
            this.lblDivEquals.Name = "lblDivEquals";
            this.lblDivEquals.Size = new System.Drawing.Size(60, 50);
            this.lblDivEquals.TabIndex = 20;
            this.lblDivEquals.Text = "=";
            this.lblDivEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivRight
            // 
            this.lblDivRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivRight.Location = new System.Drawing.Point(180, 224);
            this.lblDivRight.Name = "lblDivRight";
            this.lblDivRight.Size = new System.Drawing.Size(60, 50);
            this.lblDivRight.TabIndex = 19;
            this.lblDivRight.Text = "?";
            this.lblDivRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiv
            // 
            this.lblDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiv.Location = new System.Drawing.Point(114, 224);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(60, 50);
            this.lblDiv.TabIndex = 18;
            this.lblDiv.Text = "÷";
            this.lblDiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivLeft
            // 
            this.lblDivLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivLeft.Location = new System.Drawing.Point(48, 224);
            this.lblDivLeft.Name = "lblDivLeft";
            this.lblDivLeft.Size = new System.Drawing.Size(60, 50);
            this.lblDivLeft.TabIndex = 17;
            this.lblDivLeft.Text = "?";
            this.lblDivLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(121, 290);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 42);
            this.btnStart.TabIndex = 22;
            this.btnStart.Text = "Start the quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numQuotient);
            this.Controls.Add(this.lblDivEquals);
            this.Controls.Add(this.lblDivRight);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblDivLeft);
            this.Controls.Add(this.numProd);
            this.Controls.Add(this.lblTimesEquals);
            this.Controls.Add(this.lblTimesRight);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblTimesLeft);
            this.Controls.Add(this.numDiff);
            this.Controls.Add(this.lblMinusEquals);
            this.Controls.Add(this.lblMinusRight);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblMinusLeft);
            this.Controls.Add(this.numSum);
            this.Controls.Add(this.lblPlusEquals);
            this.Controls.Add(this.lblPlusRight);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblPlusLeft);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.Label lblPlusEquals;
        private System.Windows.Forms.NumericUpDown numSum;
        private System.Windows.Forms.NumericUpDown numDiff;
        private System.Windows.Forms.Label lblMinusEquals;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.NumericUpDown numProd;
        private System.Windows.Forms.Label lblTimesEquals;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.NumericUpDown numQuotient;
        private System.Windows.Forms.Label lblDivEquals;
        private System.Windows.Forms.Label lblDivRight;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblDivLeft;
        private System.Windows.Forms.Button btnStart;
    }
}

