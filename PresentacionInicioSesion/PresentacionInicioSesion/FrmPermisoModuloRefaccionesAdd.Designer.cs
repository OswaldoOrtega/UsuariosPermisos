
namespace PresentacionInicioSesion
{
    partial class FrmPermisoModuloRefaccionesAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtEliminacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdPermisos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 82);
            this.panel1.TabIndex = 17;
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
            this.label2.Location = new System.Drawing.Point(151, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Permisos Modulo Refaccion Añadir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(0, 193);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(210, 28);
            this.cmbUsuario.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lectura";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(220, 113);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(231, 26);
            this.txtL.TabIndex = 23;
            // 
            // txtEliminacion
            // 
            this.txtEliminacion.Location = new System.Drawing.Point(480, 193);
            this.txtEliminacion.Name = "txtEliminacion";
            this.txtEliminacion.Size = new System.Drawing.Size(231, 26);
            this.txtEliminacion.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Eliminacion";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(480, 113);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(231, 26);
            this.txtE.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Escritura";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(220, 193);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(231, 26);
            this.txtA.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Actualizacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(612, 238);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 38);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdPermisos
            // 
            this.txtIdPermisos.Location = new System.Drawing.Point(4, 113);
            this.txtIdPermisos.Name = "txtIdPermisos";
            this.txtIdPermisos.Size = new System.Drawing.Size(210, 26);
            this.txtIdPermisos.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Id Permiso";
            // 
            // FrmPermisoModuloRefaccionesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 282);
            this.Controls.Add(this.txtIdPermisos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEliminacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisoModuloRefaccionesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisoModuloRefaccionesAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtEliminacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdPermisos;
        private System.Windows.Forms.Label label3;
    }
}