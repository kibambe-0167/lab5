using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
  public partial class Form1 : Form
  {
    Business businessObj = new Business();
    public Form1()
    {
      InitializeComponent();
      dataGridView.DataSource = businessObj.Getlist();
    }

    private void Form1_Load(object sender, EventArgs e)
    { 

    }
    // extract values from expression and find results.
    private void button13_Click(object sender, EventArgs e)
    {
      businessObj.Cal( ValuesText.Text );
      ValuesText.Text = businessObj.Equation;
      dataGridView.DataSource = businessObj.Getlist();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    // add one to values
    private void button1_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "1";
    }
    // add two to values
    private void button2_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "2";
    }
    // add three to values
    private void button3_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "3";
    }
    // add 4 to vlaues
    private void button6_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "4";
    }
    // add 5 to values
    private void button5_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "5";
    }
    // add 6 to values
    private void button4_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "6";
    }
    // add 7 to values
    private void button12_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "7";
    }
    // add 8 to values
    private void button11_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "8";
    }
    // add 9 to values
    private void button10_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "9";
    }
    // add 0 to values
    private void button9_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "0";
    }
    // add + to values
    private void button8_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "+";
    }
    // add - to expression
    private void button7_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "-";
    }
    // add x to expression
    private void button16_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "*";
    }
    // add / to expression
    private void button15_Click(object sender, EventArgs e)
    {
      ValuesText.Text += "/";
    }
    // clear textbox input
    private void button14_Click(object sender, EventArgs e)
    {
      ValuesText.Text = null;
    }
  }
}
