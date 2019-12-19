namespace RegexMastery {
	partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.RegexString = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.InputString = new System.Windows.Forms.TextBox();
			this.ReplaceString = new System.Windows.Forms.TextBox();
			this.OutputString = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Exit = new System.Windows.Forms.Button();
			this.IgnoreCase = new System.Windows.Forms.CheckBox();
			this.SingleLine = new System.Windows.Forms.CheckBox();
			this.MultiLine = new System.Windows.Forms.CheckBox();
			this.Replace = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Regular Expression:";
			// 
			// RegexString
			// 
			this.RegexString.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.RegexString.Location = new System.Drawing.Point(121, 10);
			this.RegexString.Name = "RegexString";
			this.RegexString.Size = new System.Drawing.Size(495, 20);
			this.RegexString.TabIndex = 1;
			this.RegexString.TextChanged += new System.EventHandler(this.FormControl_Change);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Input Text:";
			// 
			// InputString
			// 
			this.InputString.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.InputString.Location = new System.Drawing.Point(121, 60);
			this.InputString.Multiline = true;
			this.InputString.Name = "InputString";
			this.InputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InputString.Size = new System.Drawing.Size(495, 78);
			this.InputString.TabIndex = 5;
			this.InputString.TextChanged += new System.EventHandler(this.FormControl_Change);
			// 
			// ReplaceString
			// 
			this.ReplaceString.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.ReplaceString.Location = new System.Drawing.Point(121, 150);
			this.ReplaceString.Name = "ReplaceString";
			this.ReplaceString.Size = new System.Drawing.Size(495, 20);
			this.ReplaceString.TabIndex = 7;
			this.ReplaceString.TextChanged += new System.EventHandler(this.FormControl_Change);
			// 
			// OutputString
			// 
			this.OutputString.BackColor = System.Drawing.SystemColors.Window;
			this.OutputString.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputString.Location = new System.Drawing.Point(121, 180);
			this.OutputString.Multiline = true;
			this.OutputString.Name = "OutputString";
			this.OutputString.ReadOnly = true;
			this.OutputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.OutputString.Size = new System.Drawing.Size(495, 426);
			this.OutputString.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Output Text:";
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(12, 583);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(95, 23);
			this.Exit.TabIndex = 9;
			this.Exit.Text = "Close";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// IgnoreCase
			// 
			this.IgnoreCase.AutoSize = true;
			this.IgnoreCase.Location = new System.Drawing.Point(121, 37);
			this.IgnoreCase.Name = "IgnoreCase";
			this.IgnoreCase.Size = new System.Drawing.Size(89, 17);
			this.IgnoreCase.TabIndex = 2;
			this.IgnoreCase.Text = "Ignore Case?";
			this.IgnoreCase.UseVisualStyleBackColor = true;
			this.IgnoreCase.Click += new System.EventHandler(this.FormControl_Change);
			// 
			// SingleLine
			// 
			this.SingleLine.AutoSize = true;
			this.SingleLine.Location = new System.Drawing.Point(235, 37);
			this.SingleLine.Name = "SingleLine";
			this.SingleLine.Size = new System.Drawing.Size(84, 17);
			this.SingleLine.TabIndex = 3;
			this.SingleLine.Text = "Single Line?";
			this.SingleLine.UseVisualStyleBackColor = true;
			this.SingleLine.Click += new System.EventHandler(this.FormControl_Change);
			// 
			// MultiLine
			// 
			this.MultiLine.AutoSize = true;
			this.MultiLine.Location = new System.Drawing.Point(346, 37);
			this.MultiLine.Name = "MultiLine";
			this.MultiLine.Size = new System.Drawing.Size(77, 17);
			this.MultiLine.TabIndex = 4;
			this.MultiLine.Text = "Multi Line?";
			this.MultiLine.UseVisualStyleBackColor = true;
			this.MultiLine.Click += new System.EventHandler(this.FormControl_Change);
			// 
			// Replace
			// 
			this.Replace.AutoSize = true;
			this.Replace.Location = new System.Drawing.Point(24, 152);
			this.Replace.Name = "Replace";
			this.Replace.Size = new System.Drawing.Size(93, 17);
			this.Replace.TabIndex = 6;
			this.Replace.Text = "Replace Text:";
			this.Replace.UseVisualStyleBackColor = true;
			this.Replace.Click += new System.EventHandler(this.FormControl_Change);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 618);
			this.Controls.Add(this.Replace);
			this.Controls.Add(this.MultiLine);
			this.Controls.Add(this.SingleLine);
			this.Controls.Add(this.IgnoreCase);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OutputString);
			this.Controls.Add(this.ReplaceString);
			this.Controls.Add(this.InputString);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RegexString);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 650);
			this.MinimumSize = new System.Drawing.Size(640, 650);
			this.Name = "MainForm";
			this.Text = "RegexMastery v1.0";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
			this.Shown += new System.EventHandler(this.Form_Show);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RegexString;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox InputString;
		private System.Windows.Forms.TextBox ReplaceString;
		private System.Windows.Forms.TextBox OutputString;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.CheckBox IgnoreCase;
		private System.Windows.Forms.CheckBox SingleLine;
		private System.Windows.Forms.CheckBox MultiLine;
		private System.Windows.Forms.CheckBox Replace;
	}
}

