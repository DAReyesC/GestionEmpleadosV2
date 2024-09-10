namespace GestionEmpleadosV2
{
    partial class frmEmpleados
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
            picFoto = new PictureBox();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPApellido = new TextBox();
            txtSApellido = new TextBox();
            txtCorreo = new TextBox();
            dgvEmpleados = new DataGridView();
            btnExaminar = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            BtnDelete = new Button();
            btnCancel = new Button();
            cbxDepartamento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // picFoto
            // 
            picFoto.Location = new Point(60, 47);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(193, 198);
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 24);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(312, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(121, 27);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 80);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 4;
            label3.Text = "Primer Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(604, 80);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 5;
            label4.Text = "Segundo Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 144);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 6;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 197);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 7;
            label6.Text = "Departamento:";
            // 
            // txtName
            // 
            txtName.Location = new Point(472, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 27);
            txtName.TabIndex = 8;
            // 
            // txtPApellido
            // 
            txtPApellido.Location = new Point(312, 103);
            txtPApellido.Name = "txtPApellido";
            txtPApellido.Size = new Size(265, 27);
            txtPApellido.TabIndex = 9;
            // 
            // txtSApellido
            // 
            txtSApellido.Location = new Point(604, 103);
            txtSApellido.Name = "txtSApellido";
            txtSApellido.Size = new Size(268, 27);
            txtSApellido.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(312, 167);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(560, 27);
            txtCorreo.TabIndex = 11;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(60, 312);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(812, 169);
            dgvEmpleados.TabIndex = 13;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(113, 251);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(94, 29);
            btnExaminar.TabIndex = 14;
            btnExaminar.Text = "Examinar..";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Agregar..";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(439, 253);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Editar..";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(569, 253);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 17;
            BtnDelete.Text = "Borrar...";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(697, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar...";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxDepartamento
            // 
            cbxDepartamento.FormattingEnabled = true;
            cbxDepartamento.Location = new Point(315, 220);
            cbxDepartamento.Name = "cbxDepartamento";
            cbxDepartamento.Size = new Size(557, 28);
            cbxDepartamento.TabIndex = 19;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 493);
            Controls.Add(cbxDepartamento);
            Controls.Add(btnCancel);
            Controls.Add(BtnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnExaminar);
            Controls.Add(dgvEmpleados);
            Controls.Add(txtCorreo);
            Controls.Add(txtSApellido);
            Controls.Add(txtPApellido);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(picFoto);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFoto;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPApellido;
        private TextBox txtSApellido;
        private TextBox txtCorreo;
        private DataGridView dgvEmpleados;
        private Button btnExaminar;
        private Button btnAdd;
        private Button btnEdit;
        private Button BtnDelete;
        private Button btnCancel;
        private ComboBox cbxDepartamento;
    }
}