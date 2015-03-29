namespace MeditationHelper
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerProgressChimer = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPlayIntervalChime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownIntervalTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntervalTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxIntervalChime = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meditationSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meditationHelperDataSet = new MeditationHelper.MeditationHelperDataSet();
            this.meditationSessionTableAdapter = new MeditationHelper.MeditationHelperDataSetTableAdapters.MeditationSessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTimeMinutes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxIntervalChime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meditationSessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meditationHelperDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 5;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeElapsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(12, 210);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(333, 44);
            this.labelTimeElapsed.TabIndex = 0;
            this.labelTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.duration});
            this.dataGridView1.DataSource = this.meditationSessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(333, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(12, 164);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(333, 43);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinutes.Location = new System.Drawing.Point(102, 16);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(49, 30);
            this.numericUpDownMinutes.TabIndex = 3;
            this.numericUpDownMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSeconds.Location = new System.Drawing.Point(264, 17);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(57, 30);
            this.numericUpDownSeconds.TabIndex = 4;
            this.numericUpDownSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMinutes
            // 
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelMinutes.Location = new System.Drawing.Point(6, 16);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(90, 30);
            this.labelMinutes.TabIndex = 5;
            this.labelMinutes.Text = "Minutes";
            this.labelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(157, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seconds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerProgressChimer
            // 
            this.timerProgressChimer.Tick += new System.EventHandler(this.timerProgressChimer_Tick);
            // 
            // checkBoxPlayIntervalChime
            // 
            this.checkBoxPlayIntervalChime.AutoSize = true;
            this.checkBoxPlayIntervalChime.Checked = true;
            this.checkBoxPlayIntervalChime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayIntervalChime.Location = new System.Drawing.Point(12, 78);
            this.checkBoxPlayIntervalChime.Name = "checkBoxPlayIntervalChime";
            this.checkBoxPlayIntervalChime.Size = new System.Drawing.Size(116, 17);
            this.checkBoxPlayIntervalChime.TabIndex = 7;
            this.checkBoxPlayIntervalChime.Text = "Play Interval Chime";
            this.checkBoxPlayIntervalChime.UseVisualStyleBackColor = true;
            this.checkBoxPlayIntervalChime.CheckedChanged += new System.EventHandler(this.checkBoxPlayIntervalChime_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(157, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seconds";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Minutes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownIntervalTimeSeconds
            // 
            this.numericUpDownIntervalTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIntervalTimeSeconds.Location = new System.Drawing.Point(264, 17);
            this.numericUpDownIntervalTimeSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownIntervalTimeSeconds.Name = "numericUpDownIntervalTimeSeconds";
            this.numericUpDownIntervalTimeSeconds.Size = new System.Drawing.Size(57, 30);
            this.numericUpDownIntervalTimeSeconds.TabIndex = 9;
            this.numericUpDownIntervalTimeSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownIntervalTimeMinutes
            // 
            this.numericUpDownIntervalTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIntervalTimeMinutes.Location = new System.Drawing.Point(102, 16);
            this.numericUpDownIntervalTimeMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownIntervalTimeMinutes.Name = "numericUpDownIntervalTimeMinutes";
            this.numericUpDownIntervalTimeMinutes.Size = new System.Drawing.Size(49, 30);
            this.numericUpDownIntervalTimeMinutes.TabIndex = 8;
            this.numericUpDownIntervalTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalTimeMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelMinutes);
            this.groupBox1.Controls.Add(this.numericUpDownMinutes);
            this.groupBox1.Controls.Add(this.numericUpDownSeconds);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meditation Duration";
            // 
            // groupBoxIntervalChime
            // 
            this.groupBoxIntervalChime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIntervalChime.Controls.Add(this.label3);
            this.groupBoxIntervalChime.Controls.Add(this.label2);
            this.groupBoxIntervalChime.Controls.Add(this.numericUpDownIntervalTimeMinutes);
            this.groupBoxIntervalChime.Controls.Add(this.numericUpDownIntervalTimeSeconds);
            this.groupBoxIntervalChime.Location = new System.Drawing.Point(12, 101);
            this.groupBoxIntervalChime.Name = "groupBoxIntervalChime";
            this.groupBoxIntervalChime.Size = new System.Drawing.Size(333, 57);
            this.groupBoxIntervalChime.TabIndex = 13;
            this.groupBoxIntervalChime.TabStop = false;
            this.groupBoxIntervalChime.Text = "Interval Chime";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "Date";
            dataGridViewCellStyle1.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle1;
            this.date.FillWeight = 50F;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duration.DataPropertyName = "Duration";
            this.duration.FillWeight = 50F;
            this.duration.HeaderText = "Duration";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // meditationSessionBindingSource
            // 
            this.meditationSessionBindingSource.DataMember = "MeditationSession";
            this.meditationSessionBindingSource.DataSource = this.meditationHelperDataSet;
            // 
            // meditationHelperDataSet
            // 
            this.meditationHelperDataSet.DataSetName = "MeditationHelperDataSet";
            this.meditationHelperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meditationSessionTableAdapter
            // 
            this.meditationSessionTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 460);
            this.Controls.Add(this.checkBoxPlayIntervalChime);
            this.Controls.Add(this.groupBoxIntervalChime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTimeElapsed);
            this.MaximumSize = new System.Drawing.Size(373, 1080);
            this.MinimumSize = new System.Drawing.Size(373, 498);
            this.Name = "FormMain";
            this.Text = "Meditation Helper";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTimeMinutes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxIntervalChime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meditationSessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meditationHelperDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MeditationHelperDataSet meditationHelperDataSet;
        private System.Windows.Forms.BindingSource meditationSessionBindingSource;
        private MeditationHelperDataSetTableAdapters.MeditationSessionTableAdapter meditationSessionTableAdapter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerProgressChimer;
        private System.Windows.Forms.CheckBox checkBoxPlayIntervalChime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalTimeSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalTimeMinutes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxIntervalChime;
    }
}