namespace GestionEmpleadosV2
{
    partial class frmDepartamentos
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
            label1 = new Label();
            txtDep = new TextBox();
            dgvDepartamentos = new DataGridView();
            label2 = new Label();
            txtID = new TextBox();
            btnCancel = new Button();
            BtnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 43);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtDep
            // 
            txtDep.Location = new Point(281, 79);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(463, 27);
            txtDep.TabIndex = 1;
            // 
            // dgvDepartamentos
            // 
            dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartamentos.Location = new Point(69, 219);
            dgvDepartamentos.Name = "dgvDepartamentos";
            dgvDepartamentos.RowHeadersWidth = 51;
            dgvDepartamentos.Size = new Size(675, 188);
            dgvDepartamentos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 43);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre Departamento:";
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 79);
            txtID.Name = "txtID";
            txtID.Size = new Size(194, 27);
            txtID.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(517, 146);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancelar...";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(389, 146);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 21;
            BtnDelete.Text = "Borrar...";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(259, 146);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Editar..";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(135, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Agregar..";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(BtnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(dgvDepartamentos);
            Controls.Add(txtDep);
            Controls.Add(label1);
            Name = "frmDepartamentos";
            Text = "frmDepartamentos";
            ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDep;
        private DataGridView dgvDepartamentos;
        private Label label2;
        private TextBox txtID;
        private Button btnCancel;
        private Button BtnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}