namespace Final_Project
{
    partial class TaskForm
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
			this.cmdUpdate = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.lblTaskName = new System.Windows.Forms.Label();
			this.lblTask = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lblError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdUpdate
			// 
			this.cmdUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdUpdate.Location = new System.Drawing.Point(110, 415);
			this.cmdUpdate.Name = "cmdUpdate";
			this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
			this.cmdUpdate.TabIndex = 0;
			this.cmdUpdate.Text = "Update";
			this.cmdUpdate.UseVisualStyleBackColor = true;
			this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(262, 415);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(75, 23);
			this.cmdCancel.TabIndex = 1;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// lblTaskName
			// 
			this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaskName.Location = new System.Drawing.Point(8, 9);
			this.lblTaskName.Name = "lblTaskName";
			this.lblTaskName.Size = new System.Drawing.Size(329, 16);
			this.lblTaskName.TabIndex = 2;
			this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTask
			// 
			this.lblTask.AutoSize = true;
			this.lblTask.Location = new System.Drawing.Point(30, 32);
			this.lblTask.Name = "lblTask";
			this.lblTask.Size = new System.Drawing.Size(68, 13);
			this.lblTask.TabIndex = 3;
			this.lblTask.Text = "Task Name: ";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(110, 32);
			this.txtName.MaxLength = 30;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(227, 20);
			this.txtName.TabIndex = 4;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(5, 60);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(93, 13);
			this.lblDescription.TabIndex = 5;
			this.lblDescription.Text = "Task Description: ";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(110, 57);
			this.txtDescription.MaxLength = 300;
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(227, 119);
			this.txtDescription.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Due Date:";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(110, 196);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 8;
			// 
			// lblError
			// 
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(8, 367);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(329, 45);
			this.lblError.TabIndex = 9;
			this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 450);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblTask);
			this.Controls.Add(this.lblTaskName);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdUpdate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskForm";
			this.Text = "TaskForm";
			this.Load += new System.EventHandler(this.TaskForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblTaskName;
		private System.Windows.Forms.Label lblTask;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label lblError;
    }
}