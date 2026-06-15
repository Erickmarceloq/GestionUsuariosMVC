namespace GestionUsuariosMVC.Views
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            cmbRoles = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(262, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(262, 112);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 1;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(262, 161);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(151, 28);
            cmbRoles.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(470, 112);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(589, 112);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(41, 244);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(731, 194);
            dgvUsuarios.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 52);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 112);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 7;
            label2.Text = "Correo Electrónico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 169);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 8;
            label3.Text = "Rol de Usuario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbRoles);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "p";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCorreo;
        private ComboBox cmbRoles;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
