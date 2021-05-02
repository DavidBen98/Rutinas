
namespace Rutinas
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
            this.pInterprete = new System.Windows.Forms.Panel();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.bGuardarI = new System.Windows.Forms.Button();
            this.rbGrupo = new System.Windows.Forms.RadioButton();
            this.rbSolista = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pInterpretes = new System.Windows.Forms.Panel();
            this.bEliminarI = new System.Windows.Forms.Button();
            this.lCantidadI = new System.Windows.Forms.Label();
            this.lbInterpretes = new System.Windows.Forms.ListBox();
            this.checkGrupo = new System.Windows.Forms.CheckBox();
            this.checkSolista = new System.Windows.Forms.CheckBox();
            this.pCancion = new System.Windows.Forms.Panel();
            this.tTitulo = new System.Windows.Forms.TextBox();
            this.bGuardarC = new System.Windows.Forms.Button();
            this.cbGeneroInterprete = new System.Windows.Forms.ComboBox();
            this.cbInterprete = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pCanciones = new System.Windows.Forms.Panel();
            this.bEliminarC = new System.Windows.Forms.Button();
            this.lCantidadC = new System.Windows.Forms.Label();
            this.lbCanciones = new System.Windows.Forms.ListBox();
            this.cbGeneroInterpretes = new System.Windows.Forms.ComboBox();
            this.cbInterpretes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lTotalInterprete = new System.Windows.Forms.Label();
            this.lTotalCanciones = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.pInterprete.SuspendLayout();
            this.pInterpretes.SuspendLayout();
            this.pCancion.SuspendLayout();
            this.pCanciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pInterprete
            // 
            this.pInterprete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pInterprete.Controls.Add(this.tNombre);
            this.pInterprete.Controls.Add(this.bGuardarI);
            this.pInterprete.Controls.Add(this.rbGrupo);
            this.pInterprete.Controls.Add(this.rbSolista);
            this.pInterprete.Controls.Add(this.label1);
            this.pInterprete.Location = new System.Drawing.Point(14, 13);
            this.pInterprete.Name = "pInterprete";
            this.pInterprete.Size = new System.Drawing.Size(211, 114);
            this.pInterprete.TabIndex = 0;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(65, 24);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(108, 20);
            this.tNombre.TabIndex = 4;
            // 
            // bGuardarI
            // 
            this.bGuardarI.Location = new System.Drawing.Point(65, 85);
            this.bGuardarI.Name = "bGuardarI";
            this.bGuardarI.Size = new System.Drawing.Size(108, 23);
            this.bGuardarI.TabIndex = 3;
            this.bGuardarI.Text = "Guardar";
            this.bGuardarI.UseVisualStyleBackColor = true;
            this.bGuardarI.Click += new System.EventHandler(this.bGuardarI_Click);
            // 
            // rbGrupo
            // 
            this.rbGrupo.AutoSize = true;
            this.rbGrupo.Location = new System.Drawing.Point(119, 58);
            this.rbGrupo.Name = "rbGrupo";
            this.rbGrupo.Size = new System.Drawing.Size(54, 17);
            this.rbGrupo.TabIndex = 2;
            this.rbGrupo.Text = "Grupo";
            this.rbGrupo.UseVisualStyleBackColor = true;
            // 
            // rbSolista
            // 
            this.rbSolista.AutoSize = true;
            this.rbSolista.Checked = true;
            this.rbSolista.Location = new System.Drawing.Point(65, 59);
            this.rbSolista.Name = "rbSolista";
            this.rbSolista.Size = new System.Drawing.Size(56, 17);
            this.rbSolista.TabIndex = 1;
            this.rbSolista.TabStop = true;
            this.rbSolista.Text = "Solista";
            this.rbSolista.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // pInterpretes
            // 
            this.pInterpretes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pInterpretes.Controls.Add(this.bEliminarI);
            this.pInterpretes.Controls.Add(this.lCantidadI);
            this.pInterpretes.Controls.Add(this.lbInterpretes);
            this.pInterpretes.Controls.Add(this.checkGrupo);
            this.pInterpretes.Controls.Add(this.checkSolista);
            this.pInterpretes.Location = new System.Drawing.Point(14, 133);
            this.pInterpretes.Name = "pInterpretes";
            this.pInterpretes.Size = new System.Drawing.Size(211, 223);
            this.pInterpretes.TabIndex = 1;
            // 
            // bEliminarI
            // 
            this.bEliminarI.Location = new System.Drawing.Point(119, 186);
            this.bEliminarI.Name = "bEliminarI";
            this.bEliminarI.Size = new System.Drawing.Size(75, 23);
            this.bEliminarI.TabIndex = 4;
            this.bEliminarI.Text = "Eliminar";
            this.bEliminarI.UseVisualStyleBackColor = true;
            this.bEliminarI.Click += new System.EventHandler(this.bEliminarI_Click);
            // 
            // lCantidadI
            // 
            this.lCantidadI.AutoSize = true;
            this.lCantidadI.Location = new System.Drawing.Point(12, 191);
            this.lCantidadI.Name = "lCantidadI";
            this.lCantidadI.Size = new System.Drawing.Size(61, 13);
            this.lCantidadI.TabIndex = 3;
            this.lCantidadI.Text = "Cantidad: 0";
            // 
            // lbInterpretes
            // 
            this.lbInterpretes.FormattingEnabled = true;
            this.lbInterpretes.Location = new System.Drawing.Point(15, 35);
            this.lbInterpretes.Name = "lbInterpretes";
            this.lbInterpretes.Size = new System.Drawing.Size(179, 121);
            this.lbInterpretes.TabIndex = 2;
            // 
            // checkGrupo
            // 
            this.checkGrupo.AutoSize = true;
            this.checkGrupo.Location = new System.Drawing.Point(129, 16);
            this.checkGrupo.Name = "checkGrupo";
            this.checkGrupo.Size = new System.Drawing.Size(55, 17);
            this.checkGrupo.TabIndex = 1;
            this.checkGrupo.Text = "Grupo";
            this.checkGrupo.UseVisualStyleBackColor = true;
            this.checkGrupo.CheckedChanged += new System.EventHandler(this.checkGrupo_CheckedChanged);
            // 
            // checkSolista
            // 
            this.checkSolista.AutoSize = true;
            this.checkSolista.Location = new System.Drawing.Point(65, 16);
            this.checkSolista.Name = "checkSolista";
            this.checkSolista.Size = new System.Drawing.Size(57, 17);
            this.checkSolista.TabIndex = 0;
            this.checkSolista.Text = "Solista";
            this.checkSolista.UseVisualStyleBackColor = true;
            this.checkSolista.CheckedChanged += new System.EventHandler(this.checkSolista_CheckedChanged);
            // 
            // pCancion
            // 
            this.pCancion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pCancion.Controls.Add(this.tTitulo);
            this.pCancion.Controls.Add(this.bGuardarC);
            this.pCancion.Controls.Add(this.cbGeneroInterprete);
            this.pCancion.Controls.Add(this.cbInterprete);
            this.pCancion.Controls.Add(this.label5);
            this.pCancion.Controls.Add(this.label4);
            this.pCancion.Controls.Add(this.label3);
            this.pCancion.Location = new System.Drawing.Point(240, 13);
            this.pCancion.Name = "pCancion";
            this.pCancion.Size = new System.Drawing.Size(211, 114);
            this.pCancion.TabIndex = 2;
            // 
            // tTitulo
            // 
            this.tTitulo.Location = new System.Drawing.Point(75, 7);
            this.tTitulo.Name = "tTitulo";
            this.tTitulo.Size = new System.Drawing.Size(120, 20);
            this.tTitulo.TabIndex = 5;
            // 
            // bGuardarC
            // 
            this.bGuardarC.Location = new System.Drawing.Point(74, 85);
            this.bGuardarC.Name = "bGuardarC";
            this.bGuardarC.Size = new System.Drawing.Size(121, 23);
            this.bGuardarC.TabIndex = 6;
            this.bGuardarC.Text = "Guardar";
            this.bGuardarC.UseVisualStyleBackColor = true;
            this.bGuardarC.Click += new System.EventHandler(this.bGuardarC_Click);
            // 
            // cbGeneroInterprete
            // 
            this.cbGeneroInterprete.FormattingEnabled = true;
            this.cbGeneroInterprete.Items.AddRange(new object[] {
            "Cumbia",
            "Pop",
            "Rock",
            "Trap"});
            this.cbGeneroInterprete.Location = new System.Drawing.Point(74, 58);
            this.cbGeneroInterprete.Name = "cbGeneroInterprete";
            this.cbGeneroInterprete.Size = new System.Drawing.Size(121, 21);
            this.cbGeneroInterprete.TabIndex = 5;
            this.cbGeneroInterprete.Text = "Seleccione..";
            // 
            // cbInterprete
            // 
            this.cbInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterprete.FormattingEnabled = true;
            this.cbInterprete.Location = new System.Drawing.Point(74, 33);
            this.cbInterprete.Name = "cbInterprete";
            this.cbInterprete.Size = new System.Drawing.Size(121, 21);
            this.cbInterprete.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Interprete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Titulo:";
            // 
            // pCanciones
            // 
            this.pCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pCanciones.Controls.Add(this.bEliminarC);
            this.pCanciones.Controls.Add(this.lCantidadC);
            this.pCanciones.Controls.Add(this.lbCanciones);
            this.pCanciones.Controls.Add(this.cbGeneroInterpretes);
            this.pCanciones.Controls.Add(this.cbInterpretes);
            this.pCanciones.Controls.Add(this.label7);
            this.pCanciones.Controls.Add(this.label6);
            this.pCanciones.Location = new System.Drawing.Point(240, 133);
            this.pCanciones.Name = "pCanciones";
            this.pCanciones.Size = new System.Drawing.Size(211, 223);
            this.pCanciones.TabIndex = 3;
            // 
            // bEliminarC
            // 
            this.bEliminarC.Location = new System.Drawing.Point(120, 186);
            this.bEliminarC.Name = "bEliminarC";
            this.bEliminarC.Size = new System.Drawing.Size(75, 23);
            this.bEliminarC.TabIndex = 5;
            this.bEliminarC.Text = "Eliminar";
            this.bEliminarC.UseVisualStyleBackColor = true;
            this.bEliminarC.Click += new System.EventHandler(this.bEliminarC_Click);
            // 
            // lCantidadC
            // 
            this.lCantidadC.AutoSize = true;
            this.lCantidadC.Location = new System.Drawing.Point(13, 191);
            this.lCantidadC.Name = "lCantidadC";
            this.lCantidadC.Size = new System.Drawing.Size(52, 13);
            this.lCantidadC.TabIndex = 5;
            this.lCantidadC.Text = "Cantidad:";
            // 
            // lbCanciones
            // 
            this.lbCanciones.FormattingEnabled = true;
            this.lbCanciones.Location = new System.Drawing.Point(16, 76);
            this.lbCanciones.Name = "lbCanciones";
            this.lbCanciones.Size = new System.Drawing.Size(180, 95);
            this.lbCanciones.TabIndex = 6;
            // 
            // cbGeneroInterpretes
            // 
            this.cbGeneroInterpretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGeneroInterpretes.FormattingEnabled = true;
            this.cbGeneroInterpretes.Items.AddRange(new object[] {
            "TODOS",
            "Cumbia",
            "Pop",
            "Rock",
            "Trap"});
            this.cbGeneroInterpretes.Location = new System.Drawing.Point(75, 44);
            this.cbGeneroInterpretes.Name = "cbGeneroInterpretes";
            this.cbGeneroInterpretes.Size = new System.Drawing.Size(121, 21);
            this.cbGeneroInterpretes.TabIndex = 5;
            this.cbGeneroInterpretes.SelectedIndexChanged += new System.EventHandler(this.cbGeneroInterpretes_SelectedIndexChanged);
            // 
            // cbInterpretes
            // 
            this.cbInterpretes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterpretes.FormattingEnabled = true;
            this.cbInterpretes.Items.AddRange(new object[] {
            "TODOS"});
            this.cbInterpretes.Location = new System.Drawing.Point(74, 14);
            this.cbInterpretes.Name = "cbInterpretes";
            this.cbInterpretes.Size = new System.Drawing.Size(121, 21);
            this.cbInterpretes.TabIndex = 4;
            this.cbInterpretes.SelectedIndexChanged += new System.EventHandler(this.cbInterpretes_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Interprete:";
            // 
            // lTotalInterprete
            // 
            this.lTotalInterprete.AutoSize = true;
            this.lTotalInterprete.Location = new System.Drawing.Point(13, 379);
            this.lTotalInterprete.Name = "lTotalInterprete";
            this.lTotalInterprete.Size = new System.Drawing.Size(142, 13);
            this.lTotalInterprete.TabIndex = 4;
            this.lTotalInterprete.Text = "Cantidad total de interpretes:";
            // 
            // lTotalCanciones
            // 
            this.lTotalCanciones.AutoSize = true;
            this.lTotalCanciones.Location = new System.Drawing.Point(12, 406);
            this.lTotalCanciones.Name = "lTotalCanciones";
            this.lTotalCanciones.Size = new System.Drawing.Size(142, 13);
            this.lTotalCanciones.TabIndex = 5;
            this.lTotalCanciones.Text = "Cantidad total de canciones:";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(360, 379);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 426);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lTotalCanciones);
            this.Controls.Add(this.lTotalInterprete);
            this.Controls.Add(this.pCanciones);
            this.Controls.Add(this.pCancion);
            this.Controls.Add(this.pInterpretes);
            this.Controls.Add(this.pInterprete);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Canciones";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pInterprete.ResumeLayout(false);
            this.pInterprete.PerformLayout();
            this.pInterpretes.ResumeLayout(false);
            this.pInterpretes.PerformLayout();
            this.pCancion.ResumeLayout(false);
            this.pCancion.PerformLayout();
            this.pCanciones.ResumeLayout(false);
            this.pCanciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pInterprete;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Button bGuardarI;
        private System.Windows.Forms.RadioButton rbGrupo;
        private System.Windows.Forms.RadioButton rbSolista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInterpretes;
        private System.Windows.Forms.Panel pCancion;
        private System.Windows.Forms.Panel pCanciones;
        private System.Windows.Forms.Button bEliminarI;
        private System.Windows.Forms.Label lCantidadI;
        private System.Windows.Forms.ListBox lbInterpretes;
        private System.Windows.Forms.CheckBox checkGrupo;
        private System.Windows.Forms.CheckBox checkSolista;
        private System.Windows.Forms.Button bGuardarC;
        private System.Windows.Forms.ComboBox cbGeneroInterprete;
        private System.Windows.Forms.ComboBox cbInterprete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCanciones;
        private System.Windows.Forms.ComboBox cbGeneroInterpretes;
        private System.Windows.Forms.ComboBox cbInterpretes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bEliminarC;
        private System.Windows.Forms.Label lCantidadC;
        private System.Windows.Forms.Label lTotalInterprete;
        private System.Windows.Forms.Label lTotalCanciones;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.TextBox tTitulo;
    }
}

