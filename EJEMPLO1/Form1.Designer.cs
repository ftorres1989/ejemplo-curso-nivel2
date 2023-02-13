namespace EJEMPLO1
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
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.lwELEMENTOS = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.fechadenacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbchocolate = new System.Windows.Forms.CheckBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.rbwizard = new System.Windows.Forms.RadioButton();
            this.rbmuggle = new System.Windows.Forms.RadioButton();
            this.rbsquibs = new System.Windows.Forms.RadioButton();
            this.gbtipo = new System.Windows.Forms.GroupBox();
            this.lbcolorfavorito = new System.Windows.Forms.Label();
            this.cbocolorfavorito = new System.Windows.Forms.ComboBox();
            this.numnumerofavorito = new System.Windows.Forms.NumericUpDown();
            this.lbnumerofavorito = new System.Windows.Forms.Label();
            this.btverperfil = new System.Windows.Forms.Button();
            this.gbtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numnumerofavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(262, 84);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(272, 22);
            this.TXTNOMBRE.TabIndex = 1;
            // 
            // AGREGAR
            // 
            this.AGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AGREGAR.Location = new System.Drawing.Point(84, 625);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(81, 32);
            this.AGREGAR.TabIndex = 8;
            this.AGREGAR.Text = "Agregar";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // lwELEMENTOS
            // 
            this.lwELEMENTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwELEMENTOS.HideSelection = false;
            this.lwELEMENTOS.Location = new System.Drawing.Point(84, 484);
            this.lwELEMENTOS.Name = "lwELEMENTOS";
            this.lwELEMENTOS.Size = new System.Drawing.Size(450, 113);
            this.lwELEMENTOS.TabIndex = 7;
            this.lwELEMENTOS.UseCompatibleStateImageBehavior = false;
            this.lwELEMENTOS.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(110, 136);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(135, 16);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha de Nacimiento";
            // 
            // fechadenacimiento
            // 
            this.fechadenacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechadenacimiento.Location = new System.Drawing.Point(262, 131);
            this.fechadenacimiento.Name = "fechadenacimiento";
            this.fechadenacimiento.Size = new System.Drawing.Size(272, 22);
            this.fechadenacimiento.TabIndex = 2;
            // 
            // ckbchocolate
            // 
            this.ckbchocolate.AutoSize = true;
            this.ckbchocolate.Location = new System.Drawing.Point(262, 181);
            this.ckbchocolate.Name = "ckbchocolate";
            this.ckbchocolate.Size = new System.Drawing.Size(165, 20);
            this.ckbchocolate.TabIndex = 3;
            this.ckbchocolate.Text = "Te gusta el chocolate?";
            this.ckbchocolate.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(93, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(321, 38);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "Perfil de la Persona";
            this.Titulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbwizard
            // 
            this.rbwizard.AutoSize = true;
            this.rbwizard.Checked = true;
            this.rbwizard.Location = new System.Drawing.Point(23, 21);
            this.rbwizard.Name = "rbwizard";
            this.rbwizard.Size = new System.Drawing.Size(70, 20);
            this.rbwizard.TabIndex = 8;
            this.rbwizard.TabStop = true;
            this.rbwizard.Text = "Wizard";
            this.rbwizard.UseVisualStyleBackColor = true;
            // 
            // rbmuggle
            // 
            this.rbmuggle.AutoSize = true;
            this.rbmuggle.Location = new System.Drawing.Point(155, 21);
            this.rbmuggle.Name = "rbmuggle";
            this.rbmuggle.Size = new System.Drawing.Size(73, 20);
            this.rbmuggle.TabIndex = 9;
            this.rbmuggle.Text = "Muggle";
            this.rbmuggle.UseVisualStyleBackColor = true;
            // 
            // rbsquibs
            // 
            this.rbsquibs.AutoSize = true;
            this.rbsquibs.Location = new System.Drawing.Point(306, 21);
            this.rbsquibs.Name = "rbsquibs";
            this.rbsquibs.Size = new System.Drawing.Size(70, 20);
            this.rbsquibs.TabIndex = 10;
            this.rbsquibs.Text = "Squibs";
            this.rbsquibs.UseVisualStyleBackColor = true;
            // 
            // gbtipo
            // 
            this.gbtipo.Controls.Add(this.rbwizard);
            this.gbtipo.Controls.Add(this.rbsquibs);
            this.gbtipo.Controls.Add(this.rbmuggle);
            this.gbtipo.Location = new System.Drawing.Point(113, 207);
            this.gbtipo.Name = "gbtipo";
            this.gbtipo.Size = new System.Drawing.Size(426, 77);
            this.gbtipo.TabIndex = 4;
            this.gbtipo.TabStop = false;
            this.gbtipo.Text = "Tipo";
            this.gbtipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbcolorfavorito
            // 
            this.lbcolorfavorito.AutoSize = true;
            this.lbcolorfavorito.Location = new System.Drawing.Point(154, 338);
            this.lbcolorfavorito.Name = "lbcolorfavorito";
            this.lbcolorfavorito.Size = new System.Drawing.Size(91, 16);
            this.lbcolorfavorito.TabIndex = 12;
            this.lbcolorfavorito.Text = "Color Favorito";
            // 
            // cbocolorfavorito
            // 
            this.cbocolorfavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbocolorfavorito.FormattingEnabled = true;
            this.cbocolorfavorito.Location = new System.Drawing.Point(268, 330);
            this.cbocolorfavorito.Name = "cbocolorfavorito";
            this.cbocolorfavorito.Size = new System.Drawing.Size(266, 24);
            this.cbocolorfavorito.TabIndex = 5;
            this.cbocolorfavorito.SelectedIndexChanged += new System.EventHandler(this.cbocolorfavorito_SelectedIndexChanged);
            // 
            // numnumerofavorito
            // 
            this.numnumerofavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numnumerofavorito.Location = new System.Drawing.Point(268, 369);
            this.numnumerofavorito.Name = "numnumerofavorito";
            this.numnumerofavorito.Size = new System.Drawing.Size(266, 22);
            this.numnumerofavorito.TabIndex = 6;
            // 
            // lbnumerofavorito
            // 
            this.lbnumerofavorito.AutoSize = true;
            this.lbnumerofavorito.Location = new System.Drawing.Point(154, 371);
            this.lbnumerofavorito.Name = "lbnumerofavorito";
            this.lbnumerofavorito.Size = new System.Drawing.Size(107, 16);
            this.lbnumerofavorito.TabIndex = 15;
            this.lbnumerofavorito.Text = "Numero Favorito";
            // 
            // btverperfil
            // 
            this.btverperfil.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btverperfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btverperfil.Location = new System.Drawing.Point(84, 418);
            this.btverperfil.Name = "btverperfil";
            this.btverperfil.Size = new System.Drawing.Size(81, 31);
            this.btverperfil.TabIndex = 16;
            this.btverperfil.Text = "Ver Perfil";
            this.btverperfil.UseVisualStyleBackColor = true;
            this.btverperfil.Click += new System.EventHandler(this.btverperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 669);
            this.Controls.Add(this.btverperfil);
            this.Controls.Add(this.lbnumerofavorito);
            this.Controls.Add(this.numnumerofavorito);
            this.Controls.Add(this.cbocolorfavorito);
            this.Controls.Add(this.lbcolorfavorito);
            this.Controls.Add(this.gbtipo);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.ckbchocolate);
            this.Controls.Add(this.fechadenacimiento);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwELEMENTOS);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.TXTNOMBRE);
            this.MaximumSize = new System.Drawing.Size(889, 794);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(663, 716);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbtipo.ResumeLayout(false);
            this.gbtipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numnumerofavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.ListView lwELEMENTOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker fechadenacimiento;
        private System.Windows.Forms.CheckBox ckbchocolate;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.RadioButton rbwizard;
        private System.Windows.Forms.RadioButton rbmuggle;
        private System.Windows.Forms.RadioButton rbsquibs;
        private System.Windows.Forms.GroupBox gbtipo;
        private System.Windows.Forms.Label lbcolorfavorito;
        private System.Windows.Forms.ComboBox cbocolorfavorito;
        private System.Windows.Forms.NumericUpDown numnumerofavorito;
        private System.Windows.Forms.Label lbnumerofavorito;
        private System.Windows.Forms.Button btverperfil;
    }
}

