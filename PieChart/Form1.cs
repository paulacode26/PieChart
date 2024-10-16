using System.Drawing;
using System;
using System.Windows.Forms;

namespace PieChart
{
    public partial class Form1 : Form
    {
        private double bills;
        private double gas;
        private double entertainment;
        private double groceries;
        private bool showLegend; // v/ble for showing the legend
        private bool showChart;  // V/be for showing the chart
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }

        private void btnPieChart_Click(object sender, EventArgs e)
        {
            // Validate if anyfields is empty:
            if (string.IsNullOrWhiteSpace(txtBills.Text) ||
                string.IsNullOrWhiteSpace(txtGas.Text) ||
                string.IsNullOrWhiteSpace(txtEntertainment.Text) ||
                string.IsNullOrWhiteSpace(txtGroceries.Text))
            {
                MessageBox.Show("All fields must be filled to display the chart.",
                                "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showLegend = false; //Do not show the legend until the fields are corrects 
                showChart = false; // Do not show the chart until the fields are corrects
                this.Invalidate();  // Redraw to hide any existing chart
                return;
            }
            AddPieChart(); // Call AddPieChart only if all fields are filled
            showLegend = true; // Enable the legend
            showChart = true;  // Enable the chart
            this.Invalidate(); // Force the form to redraw
        }
        private void AddPieChart()
        {
            // Get validated values for expenses
            bills = GetValidatedValue(txtBills.Text);
            gas = GetValidatedValue(txtGas.Text);
            entertainment = GetValidatedValue(txtEntertainment.Text);
            groceries = GetValidatedValue(txtGroceries.Text);

            // Check if total expenses are zero
            if (bills + gas + entertainment + groceries == 0)
            {
                // Show a warning message if the total is zero
                MessageBox.Show("Total expenses cannot be zero. Please enter valid values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showChart = false; // Do not show the chart if total is zero
                showLegend = false; // Do not show the legend if total is zero
                return;
            }
        }
        private double GetValidatedValue(string input)
        {
            // Attempt to parse the input value, return 0 if it fails
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0; // Return the parsed value
            }
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            // Draw the chart if it is enabled
            if (showChart)
            {
                DrawPieChart(e.Graphics);
            }

            // Draw the legend if it is enabled
            if (showLegend)
            {
                DrawLegend(e.Graphics);
            }
        }
        private void DrawPieChart(Graphics g)
        {

            double total = bills + gas + entertainment + groceries; // Calculate total expenses
            if (total == 0) return; // Return if total is zero

            // Define colors for the pie segments
            Color[] colors = { Color.MistyRose, Color.Wheat, Color.CadetBlue, Color.LightCyan };
            double[] values = { bills, gas, entertainment, groceries };
            float startAngle = 0; // Starting angle for pie segments

            // Move the chart further to the right
            int chartX = 900; // X coordinate where the chart starts
            int chartY = 200;  // Y coordinate where the chart starts
            int chartWidth = 500; // Width of the chart
            int chartHeight = 500;// Height of the chart

            Font boldFont = new Font(this.Font, FontStyle.Bold); // Define bold font for labels

            // Draw each segment of the pie chart
            for (int i = 0; i < values.Length; i++)
            {
                float sweepAngle = (float)(values[i] / total * 360); // Calculate sweep angle for each segment

                // Draw the segment of the pie chart
                g.FillPie(new SolidBrush(colors[i]), chartX, chartY, chartWidth, chartHeight, startAngle, sweepAngle);

                // Draw the border of the segment
                g.DrawArc(new Pen(Color.Black, 2), chartX, chartY, chartWidth, chartHeight, startAngle, sweepAngle);

                // Calculate the angle for positioning the label
                float labelAngle = startAngle + (sweepAngle / 2);

                // Calculate the radius for the text (you can adjust this value if necessary)
                float textRadius = (chartWidth / 2) * 0.5f; // Radius where text is placed

                // Calculate the coordinates for the percentage text
                float textX = chartX + (float)(textRadius * Math.Cos(labelAngle * Math.PI / 180)) + (chartWidth / 2);
                float textY = chartY + (float)(textRadius * Math.Sin(labelAngle * Math.PI / 180)) + (chartHeight / 2);

                // Round the percentage to an integer
                int percentage = (int)Math.Round((values[i] / total) * 100);

                // Measure the size of the text
                SizeF textSize = g.MeasureString($"{percentage}%", boldFont);

                // Draw the percentage in white and bold, centering it on the segment
                g.DrawString($"{percentage}%", boldFont, Brushes.Black, textX - textSize.Width / 2, textY - textSize.Height / 2); // Centrar el texto

                startAngle += sweepAngle; // Update the start angle for the next segment
            }
        }
        private void DrawLegend(Graphics g)
        {
            string[] labels = { lblBills.Text, lblGas.Text, lblEntertainment.Text, lblGroceries.Text };
            Color[] colors = { Color.MistyRose, Color.Wheat, Color.CadetBlue, Color.LightCyan };

            int legendX = 850;  // X-coordinate where the legend starts
            int legendY = 750;  // Y-coordinate where the legend starts
            int boxSize = 30;  // Size of the color boxes
            int spacing = 10;  // Space between the color box and the label
            int groupSpacing = 30; // Space between each color-description group

            Font legendFont = new Font(this.Font, FontStyle.Regular); // Define font for the legend text

            // Draw the legend horizontally
            for (int i = 0; i < labels.Length; i++)
            {
                // Draw the color box for each category
                using (Brush brush = new SolidBrush(colors[i]))
                {
                    g.FillRectangle(brush, legendX, legendY, boxSize, boxSize); // Fill the rectangle with color
                }

                // Calculate the Y-position of the label to vertically center it next to the color box
                float textY = legendY + (boxSize - g.MeasureString(labels[i], legendFont).Height) / 2; // Center vertically

                // Draw the label next to the color box, with space between the box and the description
                g.DrawString(labels[i], legendFont, Brushes.Black, legendX + boxSize + spacing, textY);

                // Move the X-coordinate for the next element, adding space between each group
                legendX += boxSize + spacing + (int)Math.Round(g.MeasureString(labels[i], legendFont).Width) + groupSpacing;
            }
        }
    }
}
