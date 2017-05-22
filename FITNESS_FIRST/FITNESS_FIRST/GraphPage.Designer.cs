namespace FitnessFirst
{
    partial class GraphPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.fitnessfirstDataSet = new FitnessFirst.FitnessfirstDataSet();
            this.exerciseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exerciseTableAdapter = new FitnessFirst.FitnessfirstDataSetTableAdapters.ExerciseTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessfirstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // fitnessfirstDataSet
            // 
            this.fitnessfirstDataSet.DataSetName = "FitnessfirstDataSet";
            this.fitnessfirstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exerciseBindingSource
            // 
            this.exerciseBindingSource.DataMember = "Exercise";
            this.exerciseBindingSource.DataSource = this.fitnessfirstDataSet;
            // 
            // exerciseTableAdapter
            // 
            this.exerciseTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.MajorGrid.LineWidth = 5;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.Title = "Exercise Count";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.exerciseBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(67, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.XValueMember = "Date";
            series1.YValueMembers = "Count";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(343, 257);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Exercises Count by Date";
            this.chart1.Titles.Add(title1);
            // 
            // GraphPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Name = "GraphPage";
            this.Size = new System.Drawing.Size(491, 295);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            ((System.ComponentModel.ISupportInitialize)(this.fitnessfirstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource exerciseBindingSource;
        private FitnessfirstDataSet fitnessfirstDataSet;
        private FitnessfirstDataSetTableAdapters.ExerciseTableAdapter exerciseTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}
