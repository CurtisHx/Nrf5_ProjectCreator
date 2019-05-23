namespace NRF52ProjectCreator
{
  partial class NRF52ProjectCreator
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
      this.tbxExamplePath = new System.Windows.Forms.TextBox();
      this.btnSeggerBrowse = new System.Windows.Forms.Button();
      this.tbxDestitnationFolder = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.rtbOutput = new System.Windows.Forms.RichTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbxProjectName = new System.Windows.Forms.TextBox();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbxExamplePath
      // 
      this.tbxExamplePath.Location = new System.Drawing.Point(148, 49);
      this.tbxExamplePath.Name = "tbxExamplePath";
      this.tbxExamplePath.Size = new System.Drawing.Size(329, 20);
      this.tbxExamplePath.TabIndex = 2;
      this.tbxExamplePath.TextChanged += new System.EventHandler(this.tbxExamplePath_TextChanged);
      // 
      // btnSeggerBrowse
      // 
      this.btnSeggerBrowse.Location = new System.Drawing.Point(484, 49);
      this.btnSeggerBrowse.Name = "btnSeggerBrowse";
      this.btnSeggerBrowse.Size = new System.Drawing.Size(75, 23);
      this.btnSeggerBrowse.TabIndex = 3;
      this.btnSeggerBrowse.Text = "Browse";
      this.btnSeggerBrowse.UseVisualStyleBackColor = true;
      this.btnSeggerBrowse.Click += new System.EventHandler(this.btnExampleBrowse_Click);
      // 
      // tbxDestitnationFolder
      // 
      this.tbxDestitnationFolder.Location = new System.Drawing.Point(148, 78);
      this.tbxDestitnationFolder.Name = "tbxDestitnationFolder";
      this.tbxDestitnationFolder.Size = new System.Drawing.Size(329, 20);
      this.tbxDestitnationFolder.TabIndex = 4;
      this.tbxDestitnationFolder.TextChanged += new System.EventHandler(this.tbxDestitnationFolder_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Sample Segger Project:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(47, 81);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(95, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Destination Folder:";
      // 
      // rtbOutput
      // 
      this.rtbOutput.Location = new System.Drawing.Point(13, 184);
      this.rtbOutput.Name = "rtbOutput";
      this.rtbOutput.Size = new System.Drawing.Size(775, 254);
      this.rtbOutput.TabIndex = 4;
      this.rtbOutput.Text = "";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(68, 26);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Project Name:";
      // 
      // tbxProjectName
      // 
      this.tbxProjectName.Location = new System.Drawing.Point(148, 23);
      this.tbxProjectName.Name = "tbxProjectName";
      this.tbxProjectName.Size = new System.Drawing.Size(329, 20);
      this.tbxProjectName.TabIndex = 1;
      this.tbxProjectName.TextChanged += new System.EventHandler(this.tbxProjectName_TextChanged);
      // 
      // btnGenerate
      // 
      this.btnGenerate.Location = new System.Drawing.Point(148, 121);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(329, 45);
      this.btnGenerate.TabIndex = 6;
      this.btnGenerate.Text = "Generate";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // NRF52ProjectCreator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnGenerate);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbxProjectName);
      this.Controls.Add(this.rtbOutput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbxDestitnationFolder);
      this.Controls.Add(this.btnSeggerBrowse);
      this.Controls.Add(this.tbxExamplePath);
      this.Name = "NRF52ProjectCreator";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbxExamplePath;
    private System.Windows.Forms.Button btnSeggerBrowse;
    private System.Windows.Forms.TextBox tbxDestitnationFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox rtbOutput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbxProjectName;
    private System.Windows.Forms.Button btnGenerate;
  }
}

