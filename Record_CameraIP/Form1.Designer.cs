namespace Record_CameraIP
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
               this.components = new System.ComponentModel.Container();
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.Camera_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.connect = new System.Windows.Forms.DataGridViewImageColumn();
               this.Status = new System.Windows.Forms.DataGridViewImageColumn();
               this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
               this.cAMERABindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.cameraTrackingSystemDataSet = new Record_CameraIP.CameraTrackingSystemDataSet();
               this.cAMERATableAdapter = new Record_CameraIP.CameraTrackingSystemDataSetTableAdapters.CAMERATableAdapter();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.label6 = new System.Windows.Forms.Label();
               this.panel2 = new System.Windows.Forms.Panel();
               this.nUP_time_Save = new System.Windows.Forms.NumericUpDown();
               this.label5 = new System.Windows.Forms.Label();
               this.btnRecord_Single = new System.Windows.Forms.Button();
               this.btnStop = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.cAMERABindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.cameraTrackingSystemDataSet)).BeginInit();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.nUP_time_Save)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
               dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
               dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
               dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Camera_ID,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.connect,
            this.Status,
            this.Check});
               this.dataGridView1.DataSource = this.cAMERABindingSource;
               this.dataGridView1.Location = new System.Drawing.Point(12, 36);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(816, 440);
               this.dataGridView1.TabIndex = 14;
               // 
               // Camera_ID
               // 
               this.Camera_ID.DataPropertyName = "Camera_ID";
               this.Camera_ID.FillWeight = 68.01397F;
               this.Camera_ID.HeaderText = "Mã Camera";
               this.Camera_ID.Name = "Camera_ID";
               this.Camera_ID.ReadOnly = true;
               // 
               // nameDataGridViewTextBoxColumn
               // 
               this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
               this.nameDataGridViewTextBoxColumn.FillWeight = 63.12585F;
               this.nameDataGridViewTextBoxColumn.HeaderText = "Tên Camera";
               this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
               // 
               // locationDataGridViewTextBoxColumn
               // 
               this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
               this.locationDataGridViewTextBoxColumn.FillWeight = 224.0568F;
               this.locationDataGridViewTextBoxColumn.HeaderText = "Vị Trí";
               this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
               // 
               // connect
               // 
               this.connect.FillWeight = 68.58801F;
               this.connect.HeaderText = "Kết Nối";
               this.connect.Name = "connect";
               // 
               // Status
               // 
               this.Status.FillWeight = 59.88396F;
               this.Status.HeaderText = "Lưu Trữ";
               this.Status.Name = "Status";
               // 
               // Check
               // 
               this.Check.FalseValue = "";
               this.Check.FillWeight = 56.80499F;
               this.Check.HeaderText = "Lựa Chọn";
               this.Check.Name = "Check";
               // 
               // cAMERABindingSource
               // 
               this.cAMERABindingSource.DataMember = "CAMERA";
               this.cAMERABindingSource.DataSource = this.cameraTrackingSystemDataSet;
               // 
               // cameraTrackingSystemDataSet
               // 
               this.cameraTrackingSystemDataSet.DataSetName = "CameraTrackingSystemDataSet";
               this.cameraTrackingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // cAMERATableAdapter
               // 
               this.cAMERATableAdapter.ClearBeforeFill = true;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(368, 12);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(125, 16);
               this.label2.TabIndex = 15;
               this.label2.Text = "Danh Sách Camera";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.label6);
               this.groupBox1.Controls.Add(this.panel2);
               this.groupBox1.Controls.Add(this.nUP_time_Save);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.btnRecord_Single);
               this.groupBox1.Controls.Add(this.btnStop);
               this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(12, 499);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(816, 77);
               this.groupBox1.TabIndex = 16;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Điều Khiển";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(325, 30);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(31, 15);
               this.label6.TabIndex = 14;
               this.label6.Text = "phút";
               // 
               // panel2
               // 
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel2.Location = new System.Drawing.Point(276, 47);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(24, 1);
               this.panel2.TabIndex = 0;
               // 
               // nUP_time_Save
               // 
               this.nUP_time_Save.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.nUP_time_Save.Location = new System.Drawing.Point(276, 32);
               this.nUP_time_Save.Name = "nUP_time_Save";
               this.nUP_time_Save.Size = new System.Drawing.Size(43, 17);
               this.nUP_time_Save.TabIndex = 0;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(170, 30);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(100, 15);
               this.label5.TabIndex = 13;
               this.label5.Text = "Thời lượng video:";
               // 
               // btnRecord_Single
               // 
               this.btnRecord_Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnRecord_Single.Location = new System.Drawing.Point(452, 26);
               this.btnRecord_Single.Name = "btnRecord_Single";
               this.btnRecord_Single.Size = new System.Drawing.Size(87, 23);
               this.btnRecord_Single.TabIndex = 9;
               this.btnRecord_Single.Text = "Bắt Đầu Lưu";
               this.btnRecord_Single.UseVisualStyleBackColor = true;
               this.btnRecord_Single.Click += new System.EventHandler(this.btnRecord_Single_Click);
               // 
               // btnStop
               // 
               this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnStop.Location = new System.Drawing.Point(599, 26);
               this.btnStop.Name = "btnStop";
               this.btnStop.Size = new System.Drawing.Size(87, 23);
               this.btnStop.TabIndex = 8;
               this.btnStop.Text = "Dừng Lưu";
               this.btnStop.UseVisualStyleBackColor = true;
               this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(835, 589);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.dataGridView1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "Form1";
               this.Text = "Lưu Video";
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.cAMERABindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.cameraTrackingSystemDataSet)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.nUP_time_Save)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private CameraTrackingSystemDataSet cameraTrackingSystemDataSet;
        private System.Windows.Forms.BindingSource cAMERABindingSource;
        private CameraTrackingSystemDataSetTableAdapters.CAMERATableAdapter cAMERATableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nUP_time_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecord_Single;
        private System.Windows.Forms.Button btnStop;
          private System.Windows.Forms.DataGridViewTextBoxColumn Camera_ID;
          private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewImageColumn connect;
          private System.Windows.Forms.DataGridViewImageColumn Status;
          private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
     }
}

