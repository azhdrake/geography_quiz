﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographyQuiz
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      string answer = txtAnswer.Text;

      //makes thte answer lowercase so that it doesn't matter how the user entered it. 
      answer = answer.ToLower();
      if (answer.Contains("pacific"))
      {
        MessageBox.Show("Correct", "Results");
      }
      else
      {
        MessageBox.Show("Incorrect, the right answer is \"The Pacific Ocean\".");
      }

    }
  }
}
