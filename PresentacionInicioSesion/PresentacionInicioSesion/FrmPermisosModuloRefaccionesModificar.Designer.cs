
namespace PresentacionInicioSesion
{
    partial class FrmPermisosModuloRefaccionesModificar
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
            this.cmbEliminacion = new System.Windows.Forms.ComboBox();
            this.cmbActualizacion = new System.Windows.Forms.ComboBox();
            this.cmbEscritura = new System.Windows.Forms.ComboBox();
            this.cmbLectura = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEliminacion
            // 
            this.cmbEliminacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminacion.FormattingEnabled = true;
            this.cmbEliminacion.Items.AddRange(new object[] {
            "Admitir",
            "Denegar"});
            this.cmbEliminacion.Location = new System.Drawing.Point(480, 216);
            this.cmbEliminacion.Name = "cmbEliminacion";
            this.cmbEliminacion.Size = new System.Drawing.Size(249, 28);
            this.cmbEliminacion.TabIndex = 45;
            // 
            // cmbActualizacion
            // 
            this.cmbActualizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizacion.FormattingEnabled = true;
            this.cmbActualizacion.Items.AddRange(new object[] {
            "Admitir",
            "Denegar"});
            this.cmbActualizacion.Location = new System.Drawing.Point(220, 216);
            this.cmbActualizacion.Name = "cmbActualizacion";
            this.cmbActualizacion.Size = new System.Drawing.Size(249, 28);
            this.cmbActualizacion.TabIndex = 44;
            // 
            // cmbEscritura
            // 
            this.cmbEscritura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscritura.FormattingEnabled = true;
            this.cmbEscritura.Items.AddRange(new object[] {
            "Admitir",
            "Denegar"});
            this.cmbEscritura.Location = new System.Drawing.Point(480, 145);
            this.cmbEscritura.Name = "cmbEscritura";
            this.cmbEscritura.Size = new System.Drawing.Size(249, 28);
            this.cmbEscritura.TabIndex = 43;
            // 
            // cmbLectura
            // 
            this.cmbLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLectura.FormattingEnabled = true;
            this.cmbLectura.Items.AddRange(new object[] {
            "Admitir",
            "Denegar"});
            this.cmbLectura.Location = new System.Drawing.Point(220, 145);
            this.cmbLectura.Name = "cmbLectura";
            this.cmbLectura.Size = new System.Drawing.Size(249, 28);
            this.cmbLectura.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Actualizacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Escritura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Eliminacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Lectura";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 82);
            this.panel1.TabIndex = 37;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(704, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(31, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Permisos Modulo Refaccion Modificar";
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.Location = new System.Drawing.Point(562, 275);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(173, 53);
            this.btnGuardarModificar.TabIndex = 46;
            this.btnGuardarModificar.Text = "Guardar Modificacion";
            this.btnGuardarModificar.UseVisualStyleBackColor = true;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(0, 145);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 26);
            this.txtID.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Id Permiso";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Items.AddRange(new object[] {
            "Admitir",
            "Denegar"});
            this.cmbUsuario.Location = new System.Drawing.Point(0, 216);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(210, 28);
            this.cmbUsuario.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Usuario";
            // 
            // FrmPermisosModuloRefaccionesModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 340);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarModificar);
            this.Controls.Add(this.cmbEliminacion);
            this.Controls.Add(this.cmbActualizacion);
            this.Controls.Add(this.cmbEscritura);
            this.Controls.Add(this.cmbLectura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosModuloRefaccionesModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisosModuloRefaccionesModificar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEliminacion;
        private System.Windows.Forms.ComboBox cmbActualizacion;
        private System.Windows.Forms.ComboBox cmbEscritura;
        private System.Windows.Forms.ComboBox cmbLectura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarModificar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
    }
}