
namespace MySQL_conector
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.scripter = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(86, 373);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(130, 45);
      this.button1.TabIndex = 0;
      this.button1.Text = "DB CONNECTING";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(323, 373);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(130, 45);
      this.button2.TabIndex = 1;
      this.button2.Text = "REQUEST";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(558, 373);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(130, 45);
      this.button3.TabIndex = 2;
      this.button3.Text = "CLEANER";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // dgv
      // 
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Location = new System.Drawing.Point(24, 12);
      this.dgv.Name = "dgv";
      this.dgv.Size = new System.Drawing.Size(748, 188);
      this.dgv.TabIndex = 3;
      // 
      // scripter
      // 
      this.scripter.Location = new System.Drawing.Point(24, 242);
      this.scripter.Name = "scripter";
      this.scripter.Size = new System.Drawing.Size(748, 96);
      this.scripter.TabIndex = 4;
      this.scripter.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.scripter);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.RichTextBox scripter;
  }
}

