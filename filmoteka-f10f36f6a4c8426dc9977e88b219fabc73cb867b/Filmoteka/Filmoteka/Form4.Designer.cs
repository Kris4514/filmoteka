
namespace Filmoteka
{
    partial class Form4
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
            this.dataSet1 = new Filmoteka.DataSet1();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsTableAdapter = new Filmoteka.DataSet1TableAdapters.FilmsTableAdapter();
            this.tableAdapterManager = new Filmoteka.DataSet1TableAdapters.TableAdapterManager();
            this.directorTableAdapter = new Filmoteka.DataSet1TableAdapters.DirectorTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nm1 = new System.Windows.Forms.Label();
            this.filmsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.dataSet1;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DirectorTableAdapter = this.directorTableAdapter;
            this.tableAdapterManager.FilmsTableAdapter = this.filmsTableAdapter;
            this.tableAdapterManager.MarksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Filmoteka.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(849, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "Director";
            this.directorBindingSource.DataSource = this.dataSet1;
            // 
            // nm1
            // 
            this.nm1.AutoSize = true;
            this.nm1.Location = new System.Drawing.Point(69, 415);
            this.nm1.Name = "nm1";
            this.nm1.Size = new System.Drawing.Size(46, 17);
            this.nm1.TabIndex = 16;
            this.nm1.Text = "label1";
            // 
            // filmsDataGridView
            // 
            this.filmsDataGridView.AllowUserToAddRows = false;
            this.filmsDataGridView.AllowUserToDeleteRows = false;
            this.filmsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.filmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsDataGridView.ColumnHeadersVisible = false;
            this.filmsDataGridView.Location = new System.Drawing.Point(12, 92);
            this.filmsDataGridView.Name = "filmsDataGridView";
            this.filmsDataGridView.ReadOnly = true;
            this.filmsDataGridView.RowHeadersWidth = 51;
            this.filmsDataGridView.RowTemplate.Height = 24;
            this.filmsDataGridView.Size = new System.Drawing.Size(1053, 283);
            this.filmsDataGridView.TabIndex = 19;
            this.filmsDataGridView.DoubleClick += new System.EventHandler(this.filmsDataGridView_DoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Режиссеры:";
           
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmsDataGridView);
            this.Controls.Add(this.nm1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private DataSet1TableAdapters.FilmsTableAdapter filmsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1TableAdapters.DirectorTableAdapter directorTableAdapter;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.Label nm1;
        private System.Windows.Forms.DataGridView filmsDataGridView;
        private System.Windows.Forms.Label label1;
    }
}