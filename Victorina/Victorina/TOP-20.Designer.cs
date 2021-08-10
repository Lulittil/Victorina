namespace Victorina
{
    partial class TOP_20
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new Victorina.QuizDataSet();
            this.resultsTableAdapter = new Victorina.QuizDataSetTableAdapters.ResultsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizDataSet2 = new Victorina.QuizDataSet2();
            this.resultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter1 = new Victorina.QuizDataSet2TableAdapters.ResultsTableAdapter();
            this.quizDataSet3 = new Victorina.QuizDataSet3();
            this.resultsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter2 = new Victorina.QuizDataSet3TableAdapters.ResultsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.thingDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // thingDataGridViewTextBoxColumn
            // 
            this.thingDataGridViewTextBoxColumn.DataPropertyName = "Thing";
            this.thingDataGridViewTextBoxColumn.HeaderText = "Thing";
            this.thingDataGridViewTextBoxColumn.Name = "thingDataGridViewTextBoxColumn";
            this.thingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.quizDataSet;
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.resultsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(14, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(494, 137);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn1.HeaderText = "login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Thing";
            this.dataGridViewTextBoxColumn2.HeaderText = "Thing";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn3.HeaderText = "Result";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.DataSource = this.resultsBindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(14, 300);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(494, 137);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn4.HeaderText = "login";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Thing";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thing";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn6.HeaderText = "Result";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // quizDataSet2
            // 
            this.quizDataSet2.DataSetName = "QuizDataSet2";
            this.quizDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource1
            // 
            this.resultsBindingSource1.DataMember = "Results";
            this.resultsBindingSource1.DataSource = this.quizDataSet2;
            // 
            // resultsTableAdapter1
            // 
            this.resultsTableAdapter1.ClearBeforeFill = true;
            // 
            // quizDataSet3
            // 
            this.quizDataSet3.DataSetName = "QuizDataSet3";
            this.quizDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsBindingSource2
            // 
            this.resultsBindingSource2.DataMember = "Results";
            this.resultsBindingSource2.DataSource = this.quizDataSet3;
            // 
            // resultsTableAdapter2
            // 
            this.resultsTableAdapter2.ClearBeforeFill = true;
            // 
            // TOP_20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TOP_20";
            this.Text = "TOP_20";
            this.Load += new System.EventHandler(this.TOP_20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private QuizDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn thingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private QuizDataSet2 quizDataSet2;
        private System.Windows.Forms.BindingSource resultsBindingSource1;
        private QuizDataSet2TableAdapters.ResultsTableAdapter resultsTableAdapter1;
        private QuizDataSet3 quizDataSet3;
        private System.Windows.Forms.BindingSource resultsBindingSource2;
        private QuizDataSet3TableAdapters.ResultsTableAdapter resultsTableAdapter2;
    }
}