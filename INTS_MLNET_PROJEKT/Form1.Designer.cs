namespace INTS_MLNET_PROJEKT
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblhotelName = new System.Windows.Forms.Label();
            this.comboBHotel = new System.Windows.Forms.ComboBox();
            this.comboBUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvTopFive = new System.Windows.Forms.DataGridView();
            this.lblTopFive = new System.Windows.Forms.Label();
            this.txtPrediction = new System.Windows.Forms.TextBox();
            this.lblPrediction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopFive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(17, 250);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(726, 64);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhotelName
            // 
            this.lblhotelName.AutoSize = true;
            this.lblhotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotelName.Location = new System.Drawing.Point(12, 23);
            this.lblhotelName.Name = "lblhotelName";
            this.lblhotelName.Size = new System.Drawing.Size(141, 29);
            this.lblhotelName.TabIndex = 3;
            this.lblhotelName.Text = "Hotel Name";
            // 
            // comboBHotel
            // 
            this.comboBHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBHotel.FormattingEnabled = true;
            this.comboBHotel.Location = new System.Drawing.Point(17, 77);
            this.comboBHotel.Name = "comboBHotel";
            this.comboBHotel.Size = new System.Drawing.Size(726, 39);
            this.comboBHotel.TabIndex = 4;
            // 
            // comboBUser
            // 
            this.comboBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBUser.FormattingEnabled = true;
            this.comboBUser.Location = new System.Drawing.Point(17, 172);
            this.comboBUser.Name = "comboBUser";
            this.comboBUser.Size = new System.Drawing.Size(726, 39);
            this.comboBUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 140);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 29);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // dgvTopFive
            // 
            this.dgvTopFive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopFive.Location = new System.Drawing.Point(17, 588);
            this.dgvTopFive.Name = "dgvTopFive";
            this.dgvTopFive.RowHeadersWidth = 51;
            this.dgvTopFive.Size = new System.Drawing.Size(726, 351);
            this.dgvTopFive.TabIndex = 7;
            // 
            // lblTopFive
            // 
            this.lblTopFive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTopFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopFive.Location = new System.Drawing.Point(8, 473);
            this.lblTopFive.Name = "lblTopFive";
            this.lblTopFive.Size = new System.Drawing.Size(735, 87);
            this.lblTopFive.TabIndex = 8;
            this.lblTopFive.Text = "Top 5 Hotels for you";
            this.lblTopFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrediction
            // 
            this.txtPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrediction.Location = new System.Drawing.Point(12, 396);
            this.txtPrediction.Name = "txtPrediction";
            this.txtPrediction.Size = new System.Drawing.Size(268, 45);
            this.txtPrediction.TabIndex = 9;
            // 
            // lblPrediction
            // 
            this.lblPrediction.AutoSize = true;
            this.lblPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrediction.Location = new System.Drawing.Point(10, 335);
            this.lblPrediction.Name = "lblPrediction";
            this.lblPrediction.Size = new System.Drawing.Size(269, 39);
            this.lblPrediction.TabIndex = 10;
            this.lblPrediction.Text = "Predicted Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 951);
            this.Controls.Add(this.lblPrediction);
            this.Controls.Add(this.txtPrediction);
            this.Controls.Add(this.lblTopFive);
            this.Controls.Add(this.dgvTopFive);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.comboBUser);
            this.Controls.Add(this.comboBHotel);
            this.Controls.Add(this.lblhotelName);
            this.Controls.Add(this.btnPredict);
            this.Name = "Form1";
            this.Text = "Hotel Recommendation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopFive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblhotelName;
        private System.Windows.Forms.ComboBox comboBHotel;
        private System.Windows.Forms.ComboBox comboBUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgvTopFive;
        private System.Windows.Forms.Label lblTopFive;
        private System.Windows.Forms.TextBox txtPrediction;
        private System.Windows.Forms.Label lblPrediction;
    }
}

