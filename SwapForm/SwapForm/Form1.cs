using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapForm
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button swapButton;
        public Form1()
        {
            InitializeComponent();
            InitializeTableLayoutPanels();
            InitializeButton();
        }

        private void InitializeTableLayoutPanels()
        {
            // Create and configure tableLayoutPanel1
            tableLayoutPanel1 = new TableLayoutPanel();
            // ... Configure properties and add controls to tableLayoutPanel1 ...
            tableLayoutPanel1.Visible = true;
            tableLayoutPanel1.ColumnCount = 2;
            // Create and configure tableLayoutPanel2
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.ColumnCount = 3;
            // ... Configure properties and add controls to tableLayoutPanel2 ...

            tableLayoutPanel1.Location = new System.Drawing.Point(10, 10); // Example: Set the location
            tableLayoutPanel1.Size = new System.Drawing.Size(400, 200);

            // Add the first table layout panel to the form
            this.Controls.Add(tableLayoutPanel1);

            tableLayoutPanel2.Location = new System.Drawing.Point(10, 10); // Example: Set the location
            tableLayoutPanel2.Size = new System.Drawing.Size(400, 200); //
        }

        private void InitializeButton()
        {
            swapButton = new Button();
            swapButton.Text = "Swap Panels";
            swapButton.Location = new System.Drawing.Point(10, 220);
            swapButton.Click += SwapButton_Click;

            // Add the button to the form
            this.Controls.Add(swapButton);
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = !tableLayoutPanel1.Visible;
            tableLayoutPanel2.Visible = !tableLayoutPanel2.Visible;
        }
    }
}