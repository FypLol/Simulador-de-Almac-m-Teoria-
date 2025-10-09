namespace InventarioAppTeoria
{
    partial class frmGestion_de_Inventario
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_tipodemerca = new System.Windows.Forms.Label();
            this.dgv_registro = new System.Windows.Forms.DataGridView();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.tbox_nombre = new System.Windows.Forms.TextBox();
            this.tbox_origen = new System.Windows.Forms.TextBox();
            this.tbox_peso = new System.Windows.Forms.TextBox();
            this.tbox_tipodemercaderia = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.tbox_dni = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.tbox_celular = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbox_agregar = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).BeginInit();
            this.gbox_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(54, 92);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_tipodemerca
            // 
            this.lbl_tipodemerca.AutoSize = true;
            this.lbl_tipodemerca.Location = new System.Drawing.Point(22, 131);
            this.lbl_tipodemerca.Name = "lbl_tipodemerca";
            this.lbl_tipodemerca.Size = new System.Drawing.Size(100, 13);
            this.lbl_tipodemerca.TabIndex = 3;
            this.lbl_tipodemerca.Text = "Tipo de mercadería";
            // 
            // dgv_registro
            // 
            this.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registro.Location = new System.Drawing.Point(25, 261);
            this.dgv_registro.Name = "dgv_registro";
            this.dgv_registro.Size = new System.Drawing.Size(1097, 376);
            this.dgv_registro.TabIndex = 4;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Location = new System.Drawing.Point(44, 173);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(41, 13);
            this.lbl_origen.TabIndex = 5;
            this.lbl_origen.Text = "Origen:";
            // 
            // tbox_nombre
            // 
            this.tbox_nombre.Location = new System.Drawing.Point(663, 89);
            this.tbox_nombre.Name = "tbox_nombre";
            this.tbox_nombre.Size = new System.Drawing.Size(344, 20);
            this.tbox_nombre.TabIndex = 6;
            // 
            // tbox_origen
            // 
            this.tbox_origen.Location = new System.Drawing.Point(144, 170);
            this.tbox_origen.Name = "tbox_origen";
            this.tbox_origen.Size = new System.Drawing.Size(307, 20);
            this.tbox_origen.TabIndex = 7;
            // 
            // tbox_peso
            // 
            this.tbox_peso.Location = new System.Drawing.Point(144, 89);
            this.tbox_peso.Name = "tbox_peso";
            this.tbox_peso.Size = new System.Drawing.Size(307, 20);
            this.tbox_peso.TabIndex = 7;
            // 
            // tbox_tipodemercaderia
            // 
            this.tbox_tipodemercaderia.Location = new System.Drawing.Point(144, 128);
            this.tbox_tipodemercaderia.Name = "tbox_tipodemercaderia";
            this.tbox_tipodemercaderia.Size = new System.Drawing.Size(307, 20);
            this.tbox_tipodemercaderia.TabIndex = 8;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(541, 131);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 9;
            this.lbl_dni.Text = "DNI";
            // 
            // tbox_dni
            // 
            this.tbox_dni.Location = new System.Drawing.Point(663, 124);
            this.tbox_dni.Name = "tbox_dni";
            this.tbox_dni.Size = new System.Drawing.Size(344, 20);
            this.tbox_dni.TabIndex = 10;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(541, 176);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(56, 13);
            this.lbl_celular.TabIndex = 11;
            this.lbl_celular.Text = "CELULAR";
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(663, 173);
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.Size = new System.Drawing.Size(344, 20);
            this.tbox_celular.TabIndex = 12;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(506, 92);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(100, 13);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre/Raz.Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Datos del Envio";
            // 
            // gbox_agregar
            // 
            this.gbox_agregar.Controls.Add(this.button3);
            this.gbox_agregar.Controls.Add(this.button2);
            this.gbox_agregar.Controls.Add(this.label7);
            this.gbox_agregar.Controls.Add(this.lbl_nombre);
            this.gbox_agregar.Controls.Add(this.button1);
            this.gbox_agregar.Controls.Add(this.tbox_celular);
            this.gbox_agregar.Controls.Add(this.lbl_peso);
            this.gbox_agregar.Controls.Add(this.lbl_celular);
            this.gbox_agregar.Controls.Add(this.lbl_tipodemerca);
            this.gbox_agregar.Controls.Add(this.tbox_dni);
            this.gbox_agregar.Controls.Add(this.lbl_origen);
            this.gbox_agregar.Controls.Add(this.lbl_dni);
            this.gbox_agregar.Controls.Add(this.tbox_nombre);
            this.gbox_agregar.Controls.Add(this.tbox_tipodemercaderia);
            this.gbox_agregar.Controls.Add(this.tbox_origen);
            this.gbox_agregar.Controls.Add(this.tbox_peso);
            this.gbox_agregar.Location = new System.Drawing.Point(25, 22);
            this.gbox_agregar.Name = "gbox_agregar";
            this.gbox_agregar.Size = new System.Drawing.Size(1097, 233);
            this.gbox_agregar.TabIndex = 15;
            this.gbox_agregar.TabStop = false;
            this.gbox_agregar.Text = "gobox_Datos del envio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(754, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmGestion_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 649);
            this.Controls.Add(this.dgv_registro);
            this.Controls.Add(this.gbox_agregar);
            this.Name = "frmGestion_de_Inventario";
            this.Text = "Gestion de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).EndInit();
            this.gbox_agregar.ResumeLayout(false);
            this.gbox_agregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_tipodemerca;
        private System.Windows.Forms.DataGridView dgv_registro;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.TextBox tbox_nombre;
        private System.Windows.Forms.TextBox tbox_origen;
        private System.Windows.Forms.TextBox tbox_peso;
        private System.Windows.Forms.TextBox tbox_tipodemercaderia;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox tbox_dni;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox tbox_celular;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbox_agregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}