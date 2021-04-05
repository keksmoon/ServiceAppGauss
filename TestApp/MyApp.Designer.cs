
namespace TestApp {
    partial class MyApp {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApp));
            this.matrixGaussMenu = new System.Windows.Forms.MenuStrip();
            this.enlargeTheMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduseTheMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixGaussMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixGaussMenu
            // 
            this.matrixGaussMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enlargeTheMatrixToolStripMenuItem,
            this.reduseTheMatrixToolStripMenuItem,
            this.gaussMethodToolStripMenuItem,
            this.generateMatrixToolStripMenuItem,
            this.testToolStripMenuItem});
            this.matrixGaussMenu.Location = new System.Drawing.Point(0, 0);
            this.matrixGaussMenu.Name = "matrixGaussMenu";
            this.matrixGaussMenu.Size = new System.Drawing.Size(607, 24);
            this.matrixGaussMenu.TabIndex = 0;
            this.matrixGaussMenu.Text = "menuStrip1";
            // 
            // enlargeTheMatrixToolStripMenuItem
            // 
            this.enlargeTheMatrixToolStripMenuItem.Name = "enlargeTheMatrixToolStripMenuItem";
            this.enlargeTheMatrixToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.enlargeTheMatrixToolStripMenuItem.Text = "Enlarge the matrix";
            this.enlargeTheMatrixToolStripMenuItem.Click += new System.EventHandler(this.enlargeTheMatrixToolStripMenuItem_Click);
            // 
            // reduseTheMatrixToolStripMenuItem
            // 
            this.reduseTheMatrixToolStripMenuItem.Name = "reduseTheMatrixToolStripMenuItem";
            this.reduseTheMatrixToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.reduseTheMatrixToolStripMenuItem.Text = "Reduse the matrix";
            this.reduseTheMatrixToolStripMenuItem.Click += new System.EventHandler(this.reduseTheMatrixToolStripMenuItem_Click);
            // 
            // gaussMethodToolStripMenuItem
            // 
            this.gaussMethodToolStripMenuItem.Name = "gaussMethodToolStripMenuItem";
            this.gaussMethodToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.gaussMethodToolStripMenuItem.Text = "Gauss method";
            this.gaussMethodToolStripMenuItem.Click += new System.EventHandler(this.gaussMethodToolStripMenuItem_Click);
            // 
            // generateMatrixToolStripMenuItem
            // 
            this.generateMatrixToolStripMenuItem.Name = "generateMatrixToolStripMenuItem";
            this.generateMatrixToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.generateMatrixToolStripMenuItem.Text = "Generate matrix";
            this.generateMatrixToolStripMenuItem.Click += new System.EventHandler(this.generateMatrixToolStripMenuItem_Click);
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AllowUserToResizeColumns = false;
            this.matrix.AllowUserToResizeRows = false;
            this.matrix.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.matrix.ColumnHeadersHeight = 40;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrix.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix.GridColor = System.Drawing.Color.Coral;
            this.matrix.Location = new System.Drawing.Point(0, 24);
            this.matrix.MultiSelect = false;
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersVisible = false;
            this.matrix.RowHeadersWidth = 40;
            this.matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrix.Size = new System.Drawing.Size(607, 426);
            this.matrix.TabIndex = 30;
            this.matrix.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrix_CellEndEdit);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // MyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.matrixGaussMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.matrixGaussMenu;
            this.Name = "MyApp";
            this.Text = "Matrix Gauss";
            this.matrixGaussMenu.ResumeLayout(false);
            this.matrixGaussMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip matrixGaussMenu;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.ToolStripMenuItem enlargeTheMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduseTheMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

