namespace GeographyQuiz
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
      this.txtAnswer = new System.Windows.Forms.TextBox();
      this.btnSubmit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtAnswer
      // 
      this.txtAnswer.Location = new System.Drawing.Point(118, 146);
      this.txtAnswer.Name = "txtAnswer";
      this.txtAnswer.Size = new System.Drawing.Size(156, 31);
      this.txtAnswer.TabIndex = 0;
      // 
      // btnSubmit
      // 
      this.btnSubmit.Location = new System.Drawing.Point(303, 140);
      this.btnSubmit.Name = "btnSubmit";
      this.btnSubmit.Size = new System.Drawing.Size(100, 42);
      this.btnSubmit.TabIndex = 1;
      this.btnSubmit.Text = "Submit";
      this.btnSubmit.UseVisualStyleBackColor = true;
      this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(113, 81);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(268, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "What is the largest ocean?";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(539, 282);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSubmit);
      this.Controls.Add(this.txtAnswer);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtAnswer;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.Label label1;
  }
}

