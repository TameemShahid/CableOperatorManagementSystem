namespace CableMangementSystem
{
    partial class EditConnCharges
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
            this.cONNECTIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONNECTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cableMDBDataSet = new CableMangementSystem.CableMDBDataSet();
            this.Expired = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cONNECTIONTableAdapter = new CableMangementSystem.CableMDBDataSetTableAdapters.CONNECTIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONNECTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cableMDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cONNECTIONIDDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.sTARTDATEDataGridViewTextBoxColumn,
            this.eNDDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONNECTIONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cONNECTIONIDDataGridViewTextBoxColumn
            // 
            this.cONNECTIONIDDataGridViewTextBoxColumn.DataPropertyName = "CONNECTION_ID";
            this.cONNECTIONIDDataGridViewTextBoxColumn.HeaderText = "CONNECTION_ID";
            this.cONNECTIONIDDataGridViewTextBoxColumn.Name = "cONNECTIONIDDataGridViewTextBoxColumn";
            this.cONNECTIONIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTARTDATEDataGridViewTextBoxColumn
            // 
            this.sTARTDATEDataGridViewTextBoxColumn.DataPropertyName = "START_DATE";
            this.sTARTDATEDataGridViewTextBoxColumn.HeaderText = "START_DATE";
            this.sTARTDATEDataGridViewTextBoxColumn.Name = "sTARTDATEDataGridViewTextBoxColumn";
            this.sTARTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDDATEDataGridViewTextBoxColumn
            // 
            this.eNDDATEDataGridViewTextBoxColumn.DataPropertyName = "END_DATE";
            this.eNDDATEDataGridViewTextBoxColumn.HeaderText = "END_DATE";
            this.eNDDATEDataGridViewTextBoxColumn.Name = "eNDDATEDataGridViewTextBoxColumn";
            this.eNDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONNECTIONBindingSource
            // 
            this.cONNECTIONBindingSource.DataMember = "CONNECTION";
            this.cONNECTIONBindingSource.DataSource = this.cableMDBDataSet;
            // 
            // cableMDBDataSet
            // 
            this.cableMDBDataSet.DataSetName = "CableMDBDataSet";
            this.cableMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Expired
            // 
            this.Expired.AutoSize = true;
            this.Expired.Location = new System.Drawing.Point(12, 156);
            this.Expired.Name = "Expired";
            this.Expired.Size = new System.Drawing.Size(61, 17);
            this.Expired.TabIndex = 1;
            this.Expired.Text = "Expired";
            this.Expired.UseVisualStyleBackColor = true;
            this.Expired.CheckedChanged += new System.EventHandler(this.Expired_CheckedChanged);
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button1.Location = new System.Drawing.Point(0, 238);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(544, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Back";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(544, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cONNECTIONTableAdapter
            // 
            this.cONNECTIONTableAdapter.ClearBeforeFill = true;
            // 
            // EditConnCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Expired);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditConnCharges";
            this.Text = "Show Connection Charges";
            this.Load += new System.EventHandler(this.EditConnCharges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONNECTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cableMDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Expired;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private CableMDBDataSet cableMDBDataSet;
        private System.Windows.Forms.BindingSource cONNECTIONBindingSource;
        private CableMDBDataSetTableAdapters.CONNECTIONTableAdapter cONNECTIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONNECTIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDDATEDataGridViewTextBoxColumn;
    }
}