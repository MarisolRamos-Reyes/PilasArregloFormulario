
namespace PilasArregloFormulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPush = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbarreglo = new System.Windows.Forms.GroupBox();
            this.lblinfoarreglo = new System.Windows.Forms.Label();
            this.btnarreglo = new System.Windows.Forms.Button();
            this.txtarreglo = new System.Windows.Forms.TextBox();
            this.grbLista = new System.Windows.Forms.GroupBox();
            this.lstbPila = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbarreglo.SuspendLayout();
            this.grbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(286, 33);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 0;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(108, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(63, 21);
            this.txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(108, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(18, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 16);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // grbarreglo
            // 
            this.grbarreglo.Controls.Add(this.lblinfoarreglo);
            this.grbarreglo.Controls.Add(this.btnarreglo);
            this.grbarreglo.Controls.Add(this.txtarreglo);
            this.grbarreglo.Location = new System.Drawing.Point(39, 6);
            this.grbarreglo.Name = "grbarreglo";
            this.grbarreglo.Size = new System.Drawing.Size(340, 100);
            this.grbarreglo.TabIndex = 6;
            this.grbarreglo.TabStop = false;
            this.grbarreglo.Text = "Arreglo";
            // 
            // lblinfoarreglo
            // 
            this.lblinfoarreglo.AutoSize = true;
            this.lblinfoarreglo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoarreglo.Location = new System.Drawing.Point(37, 27);
            this.lblinfoarreglo.Name = "lblinfoarreglo";
            this.lblinfoarreglo.Size = new System.Drawing.Size(232, 15);
            this.lblinfoarreglo.TabIndex = 2;
            this.lblinfoarreglo.Text = "Introducir el número total de libros";
            // 
            // btnarreglo
            // 
            this.btnarreglo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnarreglo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnarreglo.Location = new System.Drawing.Point(175, 58);
            this.btnarreglo.Name = "btnarreglo";
            this.btnarreglo.Size = new System.Drawing.Size(134, 27);
            this.btnarreglo.TabIndex = 1;
            this.btnarreglo.Text = "Agregar";
            this.btnarreglo.UseVisualStyleBackColor = false;
            this.btnarreglo.Click += new System.EventHandler(this.btnarreglo_Click);
            // 
            // txtarreglo
            // 
            this.txtarreglo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarreglo.Location = new System.Drawing.Point(6, 58);
            this.txtarreglo.Name = "txtarreglo";
            this.txtarreglo.Size = new System.Drawing.Size(163, 27);
            this.txtarreglo.TabIndex = 0;
            // 
            // grbLista
            // 
            this.grbLista.Controls.Add(this.btnModificar);
            this.grbLista.Controls.Add(this.btnPop);
            this.grbLista.Controls.Add(this.lstbPila);
            this.grbLista.Controls.Add(this.lblNumero);
            this.grbLista.Controls.Add(this.lblNombre);
            this.grbLista.Controls.Add(this.btnPush);
            this.grbLista.Controls.Add(this.txtNumero);
            this.grbLista.Controls.Add(this.txtNombre);
            this.grbLista.Location = new System.Drawing.Point(22, 112);
            this.grbLista.Name = "grbLista";
            this.grbLista.Size = new System.Drawing.Size(371, 428);
            this.grbLista.TabIndex = 7;
            this.grbLista.TabStop = false;
            this.grbLista.Text = "Pila";
            this.grbLista.Visible = false;
            // 
            // lstbPila
            // 
            this.lstbPila.FormattingEnabled = true;
            this.lstbPila.Location = new System.Drawing.Point(6, 138);
            this.lstbPila.Name = "lstbPila";
            this.lstbPila.Size = new System.Drawing.Size(355, 186);
            this.lstbPila.TabIndex = 8;
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(286, 62);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 9;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(286, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 572);
            this.Controls.Add(this.grbLista);
            this.Controls.Add(this.grbarreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbarreglo.ResumeLayout(false);
            this.grbarreglo.PerformLayout();
            this.grbLista.ResumeLayout(false);
            this.grbLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbarreglo;
        private System.Windows.Forms.Label lblinfoarreglo;
        private System.Windows.Forms.Button btnarreglo;
        private System.Windows.Forms.TextBox txtarreglo;
        private System.Windows.Forms.GroupBox grbLista;
        private System.Windows.Forms.ListBox lstbPila;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnModificar;
    }
}

