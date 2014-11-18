namespace Ksu.Cis300.Baseball
{
    partial class UserInterface
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
            this.uxAddFile = new System.Windows.Forms.Button();
            this.uxList = new System.Windows.Forms.ComboBox();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxGetResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxAddFile
            // 
            this.uxAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddFile.Location = new System.Drawing.Point(12, 11);
            this.uxAddFile.Name = "uxAddFile";
            this.uxAddFile.Size = new System.Drawing.Size(415, 52);
            this.uxAddFile.TabIndex = 0;
            this.uxAddFile.Text = "Add Data File";
            this.uxAddFile.UseVisualStyleBackColor = true;
            // 
            // uxList
            // 
            this.uxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxList.FormattingEnabled = true;
            this.uxList.Location = new System.Drawing.Point(12, 70);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(415, 24);
            this.uxList.TabIndex = 1;
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.CalendarForeColor = System.Drawing.Color.Gray;
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxDateTimePicker.Location = new System.Drawing.Point(12, 101);
            this.uxDateTimePicker.MinimumSize = new System.Drawing.Size(50, 40);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(98, 40);
            this.uxDateTimePicker.TabIndex = 2;
            // 
            // uxGetResults
            // 
            this.uxGetResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.uxGetResults.Location = new System.Drawing.Point(116, 102);
            this.uxGetResults.Name = "uxGetResults";
            this.uxGetResults.Size = new System.Drawing.Size(311, 41);
            this.uxGetResults.TabIndex = 3;
            this.uxGetResults.Text = "Get Game Results";
            this.uxGetResults.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 165);
            this.Controls.Add(this.uxGetResults);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxAddFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Baseball Scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxAddFile;
        private System.Windows.Forms.ComboBox uxList;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.Button uxGetResults;
    }
}

