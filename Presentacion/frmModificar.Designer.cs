﻿
namespace Presentacion
{
    partial class frmModificar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificar));
            this.ModificarURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelarM = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.ModificarPrecio = new System.Windows.Forms.TextBox();
            this.ModificarDescripción = new System.Windows.Forms.TextBox();
            this.ModificarNombre = new System.Windows.Forms.TextBox();
            this.ModificarCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ModificarCategoria = new System.Windows.Forms.ComboBox();
            this.ModificarMarca = new System.Windows.Forms.ComboBox();
            this.errorProviderM = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderM)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificarURL
            // 
            this.ModificarURL.Location = new System.Drawing.Point(177, 251);
            this.ModificarURL.Name = "ModificarURL";
            this.ModificarURL.Size = new System.Drawing.Size(221, 20);
            this.ModificarURL.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Imagen URL";
            // 
            // btnCancelarM
            // 
            this.btnCancelarM.Location = new System.Drawing.Point(269, 306);
            this.btnCancelarM.Name = "btnCancelarM";
            this.btnCancelarM.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarM.TabIndex = 29;
            this.btnCancelarM.Text = "CANCELAR";
            this.btnCancelarM.UseVisualStyleBackColor = true;
            this.btnCancelarM.Click += new System.EventHandler(this.btnCancelarM_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(156, 306);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ModificarPrecio
            // 
            this.ModificarPrecio.Location = new System.Drawing.Point(177, 152);
            this.ModificarPrecio.MaxLength = 10;
            this.ModificarPrecio.Name = "ModificarPrecio";
            this.ModificarPrecio.Size = new System.Drawing.Size(100, 20);
            this.ModificarPrecio.TabIndex = 27;
            this.ModificarPrecio.TextChanged += new System.EventHandler(this.ModificarPrecio_TextChanged);
            this.ModificarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModificarPrecio_KeyPress);
            // 
            // ModificarDescripción
            // 
            this.ModificarDescripción.Location = new System.Drawing.Point(177, 111);
            this.ModificarDescripción.Name = "ModificarDescripción";
            this.ModificarDescripción.Size = new System.Drawing.Size(221, 20);
            this.ModificarDescripción.TabIndex = 26;
            this.ModificarDescripción.TextChanged += new System.EventHandler(this.ModificarDescripción_TextChanged);
            // 
            // ModificarNombre
            // 
            this.ModificarNombre.Location = new System.Drawing.Point(177, 73);
            this.ModificarNombre.Name = "ModificarNombre";
            this.ModificarNombre.Size = new System.Drawing.Size(100, 20);
            this.ModificarNombre.TabIndex = 25;
            this.ModificarNombre.TextChanged += new System.EventHandler(this.ModificarNombre_TextChanged);
            // 
            // ModificarCodigo
            // 
            this.ModificarCodigo.Location = new System.Drawing.Point(177, 34);
            this.ModificarCodigo.Name = "ModificarCodigo";
            this.ModificarCodigo.Size = new System.Drawing.Size(100, 20);
            this.ModificarCodigo.TabIndex = 24;
            this.ModificarCodigo.TextChanged += new System.EventHandler(this.ModificarCodigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // ModificarCategoria
            // 
            this.ModificarCategoria.FormattingEnabled = true;
            this.ModificarCategoria.Location = new System.Drawing.Point(177, 219);
            this.ModificarCategoria.Name = "ModificarCategoria";
            this.ModificarCategoria.Size = new System.Drawing.Size(121, 21);
            this.ModificarCategoria.TabIndex = 17;
            // 
            // ModificarMarca
            // 
            this.ModificarMarca.FormattingEnabled = true;
            this.ModificarMarca.Location = new System.Drawing.Point(177, 186);
            this.ModificarMarca.Name = "ModificarMarca";
            this.ModificarMarca.Size = new System.Drawing.Size(121, 21);
            this.ModificarMarca.TabIndex = 16;
            // 
            // errorProviderM
            // 
            this.errorProviderM.ContainerControl = this;
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(507, 382);
            this.Controls.Add(this.ModificarURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelarM);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.ModificarPrecio);
            this.Controls.Add(this.ModificarDescripción);
            this.Controls.Add(this.ModificarNombre);
            this.Controls.Add(this.ModificarCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModificarCategoria);
            this.Controls.Add(this.ModificarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModificarURL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelarM;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox ModificarPrecio;
        private System.Windows.Forms.TextBox ModificarDescripción;
        private System.Windows.Forms.TextBox ModificarNombre;
        private System.Windows.Forms.TextBox ModificarCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModificarCategoria;
        private System.Windows.Forms.ComboBox ModificarMarca;
        private System.Windows.Forms.ErrorProvider errorProviderM;
    }
}