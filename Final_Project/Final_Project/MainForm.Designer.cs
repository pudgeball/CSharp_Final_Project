namespace Final_Project
{
	partial class MainForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.completionBar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdViewTaskDetails = new System.Windows.Forms.Button();
            this.cmdDeleteTask = new System.Windows.Forms.Button();
            this.cmdAddListItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdAddTask = new System.Windows.Forms.Button();
            this.cmdCompleteTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 264);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // taskBox
            // 
            this.taskBox.FormattingEnabled = true;
            this.taskBox.Location = new System.Drawing.Point(216, 167);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(501, 160);
            this.taskBox.TabIndex = 2;
            this.taskBox.SelectedIndexChanged += new System.EventHandler(this.taskBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.Location = new System.Drawing.Point(346, 37);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(60, 24);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Tasks";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.completionBar);
            this.panel1.Location = new System.Drawing.Point(217, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 24);
            this.panel1.TabIndex = 7;
            // 
            // completionBar
            // 
            this.completionBar.Location = new System.Drawing.Point(-1, 0);
            this.completionBar.Name = "completionBar";
            this.completionBar.Size = new System.Drawing.Size(500, 22);
            this.completionBar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "100%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Completion";
            // 
            // cmdViewTaskDetails
            // 
            this.cmdViewTaskDetails.Enabled = false;
            this.cmdViewTaskDetails.Location = new System.Drawing.Point(503, 341);
            this.cmdViewTaskDetails.Name = "cmdViewTaskDetails";
            this.cmdViewTaskDetails.Size = new System.Drawing.Size(107, 23);
            this.cmdViewTaskDetails.TabIndex = 11;
            this.cmdViewTaskDetails.Text = "View Task Details";
            this.cmdViewTaskDetails.UseVisualStyleBackColor = true;
            this.cmdViewTaskDetails.Click += new System.EventHandler(this.cmdViewTaskDetails_Click);
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Enabled = false;
            this.cmdDeleteTask.Location = new System.Drawing.Point(422, 341);
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteTask.TabIndex = 12;
            this.cmdDeleteTask.Text = "Delete Task";
            this.cmdDeleteTask.UseVisualStyleBackColor = true;
            this.cmdDeleteTask.Click += new System.EventHandler(this.cmdDeleteTask_Click);
            // 
            // cmdAddListItem
            // 
            this.cmdAddListItem.Location = new System.Drawing.Point(12, 341);
            this.cmdAddListItem.Name = "cmdAddListItem";
            this.cmdAddListItem.Size = new System.Drawing.Size(187, 23);
            this.cmdAddListItem.TabIndex = 13;
            this.cmdAddListItem.Text = "Add List Item";
            this.cmdAddListItem.UseVisualStyleBackColor = true;
            this.cmdAddListItem.Click += new System.EventHandler(this.cmdAddListItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Project List";
            // 
            // cmdAddTask
            // 
            this.cmdAddTask.Location = new System.Drawing.Point(341, 341);
            this.cmdAddTask.Name = "cmdAddTask";
            this.cmdAddTask.Size = new System.Drawing.Size(75, 23);
            this.cmdAddTask.TabIndex = 15;
            this.cmdAddTask.Text = "Add Task";
            this.cmdAddTask.UseVisualStyleBackColor = true;
            this.cmdAddTask.Click += new System.EventHandler(this.cmdAddTask_Click);
            // 
            // cmdCompleteTask
            // 
            this.cmdCompleteTask.Enabled = false;
            this.cmdCompleteTask.Location = new System.Drawing.Point(617, 341);
            this.cmdCompleteTask.Name = "cmdCompleteTask";
            this.cmdCompleteTask.Size = new System.Drawing.Size(100, 23);
            this.cmdCompleteTask.TabIndex = 16;
            this.cmdCompleteTask.Text = "Complete Task";
            this.cmdCompleteTask.UseVisualStyleBackColor = true;
            this.cmdCompleteTask.Click += new System.EventHandler(this.cmdCompleteTask_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 376);
            this.Controls.Add(this.cmdCompleteTask);
            this.Controls.Add(this.cmdAddTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdAddListItem);
            this.Controls.Add(this.cmdDeleteTask);
            this.Controls.Add(this.cmdViewTaskDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TaskMaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ListBox taskBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel completionBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdViewTaskDetails;
        private System.Windows.Forms.Button cmdDeleteTask;
        private System.Windows.Forms.Button cmdAddListItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdAddTask;
        private System.Windows.Forms.Button cmdCompleteTask;
	}
}

