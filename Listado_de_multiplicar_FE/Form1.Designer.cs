namespace Listado_de_multiplicar_FE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_borrar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.ListaResultados = new System.Windows.Forms.ListView();
            this.txtpr1 = new System.Windows.Forms.TextBox();
            this.txtpr2 = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // bt_borrar
            // 
            this.bt_borrar.Location = new System.Drawing.Point(443, 281);
            this.bt_borrar.Name = "bt_borrar";
            this.bt_borrar.Size = new System.Drawing.Size(107, 41);
            this.bt_borrar.TabIndex = 3;
            this.bt_borrar.Text = "BORRAR";
            this.bt_borrar.UseVisualStyleBackColor = true;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(440, 171);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(110, 36);
            this.bt_agregar.TabIndex = 4;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            // 
            // ListaResultados
            // 
            this.ListaResultados.HideSelection = false;
            this.ListaResultados.Location = new System.Drawing.Point(66, 171);
            this.ListaResultados.Name = "ListaResultados";
            this.ListaResultados.Size = new System.Drawing.Size(318, 248);
            this.ListaResultados.TabIndex = 5;
            this.ListaResultados.UseCompatibleStateImageBehavior = false;
            // 
            // txtpr1
            // 
            this.txtpr1.Location = new System.Drawing.Point(44, 76);
            this.txtpr1.Multiline = true;
            this.txtpr1.Name = "txtpr1";
            this.txtpr1.Size = new System.Drawing.Size(122, 22);
            this.txtpr1.TabIndex = 6;
            // 
            // txtpr2
            // 
            this.txtpr2.Location = new System.Drawing.Point(246, 76);
            this.txtpr2.Name = "txtpr2";
            this.txtpr2.Size = new System.Drawing.Size(100, 22);
            this.txtpr2.TabIndex = 7;
            this.txtpr2.TextChanged += new System.EventHandler(this.txtpr2_TextChanged);
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(440, 76);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(100, 22);
            this.txtres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtpr2);
            this.Controls.Add(this.txtpr1);
            this.Controls.Add(this.ListaResultados);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_borrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_borrar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.ListView ListaResultados;
        private System.Windows.Forms.TextBox txtpr1;
        private System.Windows.Forms.TextBox txtpr2;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

