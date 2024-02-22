namespace Project_C_
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
			statusLabel = new Label();
			fileSystemWatcher1 = new FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			SuspendLayout();
			// 
			// statusLabel
			// 
			statusLabel.AutoSize = true;
			statusLabel.BackColor = SystemColors.Control;
			statusLabel.Location = new Point(12, 468);
			statusLabel.Name = "statusLabel";
			statusLabel.Size = new Size(50, 20);
			statusLabel.TabIndex = 0;
			statusLabel.Text = "label1";
			statusLabel.Click += statusLabel_Click;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(827, 497);
			Controls.Add(statusLabel);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label statusLabel;
		private FileSystemWatcher fileSystemWatcher1;
	}
}