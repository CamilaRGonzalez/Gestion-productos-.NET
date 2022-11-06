
namespace Gestión_de_artículos_app
{
    partial class AgregarArticulo
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
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lbCodigoArt = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescrp = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbUrlImg = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.brnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warningDesc = new System.Windows.Forms.Label();
            this.warningImagen = new System.Windows.Forms.Label();
            this.warningPrecio = new System.Windows.Forms.Label();
            this.warningNombre = new System.Windows.Forms.Label();
            this.warningCodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(6, 19);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(257, 249);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // lbCodigoArt
            // 
            this.lbCodigoArt.AutoSize = true;
            this.lbCodigoArt.Location = new System.Drawing.Point(23, 29);
            this.lbCodigoArt.Name = "lbCodigoArt";
            this.lbCodigoArt.Size = new System.Drawing.Size(43, 13);
            this.lbCodigoArt.TabIndex = 1;
            this.lbCodigoArt.Text = "Código ";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(20, 66);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDescrp
            // 
            this.lbDescrp.AutoSize = true;
            this.lbDescrp.Location = new System.Drawing.Point(7, 258);
            this.lbDescrp.Name = "lbDescrp";
            this.lbDescrp.Size = new System.Drawing.Size(63, 13);
            this.lbDescrp.TabIndex = 3;
            this.lbDescrp.Text = "Descripción";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(27, 103);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 4;
            this.lbPrecio.Text = "Precio";
            // 
            // lbUrlImg
            // 
            this.lbUrlImg.AutoSize = true;
            this.lbUrlImg.Location = new System.Drawing.Point(0, 140);
            this.lbUrlImg.Name = "lbUrlImg";
            this.lbUrlImg.Size = new System.Drawing.Size(66, 13);
            this.lbUrlImg.TabIndex = 5;
            this.lbUrlImg.Text = "URL imagen";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(29, 182);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(16, 222);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(54, 13);
            this.lbCategoria.TabIndex = 7;
            this.lbCategoria.Text = "Categoría";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 22);
            this.txtCodigo.MaxLength = 3;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(135, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(76, 96);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(135, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(76, 133);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(135, 20);
            this.txtUrlImg.TabIndex = 5;
            this.txtUrlImg.Leave += new System.EventHandler(this.txtUrlImg_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(75, 255);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(214, 92);
            this.txtDescripcion.TabIndex = 6;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(76, 174);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(135, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(76, 214);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(135, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // brnAgregar
            // 
            this.brnAgregar.Location = new System.Drawing.Point(419, 314);
            this.brnAgregar.Name = "brnAgregar";
            this.brnAgregar.Size = new System.Drawing.Size(97, 29);
            this.brnAgregar.TabIndex = 7;
            this.brnAgregar.Text = "Aceptar";
            this.brnAgregar.UseVisualStyleBackColor = true;
            this.brnAgregar.Click += new System.EventHandler(this.brnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warningDesc);
            this.groupBox1.Controls.Add(this.warningImagen);
            this.groupBox1.Controls.Add(this.warningPrecio);
            this.groupBox1.Controls.Add(this.warningNombre);
            this.groupBox1.Controls.Add(this.warningCodigo);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtUrlImg);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.lbMarca);
            this.groupBox1.Controls.Add(this.lbUrlImg);
            this.groupBox1.Controls.Add(this.lbPrecio);
            this.groupBox1.Controls.Add(this.lbDescrp);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.lbCodigoArt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 362);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del artículo";
            // 
            // warningDesc
            // 
            this.warningDesc.AutoSize = true;
            this.warningDesc.ForeColor = System.Drawing.Color.Red;
            this.warningDesc.Location = new System.Drawing.Point(298, 258);
            this.warningDesc.Name = "warningDesc";
            this.warningDesc.Size = new System.Drawing.Size(0, 13);
            this.warningDesc.TabIndex = 12;
            // 
            // warningImagen
            // 
            this.warningImagen.AutoSize = true;
            this.warningImagen.ForeColor = System.Drawing.Color.Red;
            this.warningImagen.Location = new System.Drawing.Point(227, 136);
            this.warningImagen.Name = "warningImagen";
            this.warningImagen.Size = new System.Drawing.Size(0, 13);
            this.warningImagen.TabIndex = 11;
            // 
            // warningPrecio
            // 
            this.warningPrecio.AutoSize = true;
            this.warningPrecio.ForeColor = System.Drawing.Color.Red;
            this.warningPrecio.Location = new System.Drawing.Point(219, 99);
            this.warningPrecio.Name = "warningPrecio";
            this.warningPrecio.Size = new System.Drawing.Size(7, 13);
            this.warningPrecio.TabIndex = 10;
            this.warningPrecio.Text = "\r\n";
            // 
            // warningNombre
            // 
            this.warningNombre.AutoSize = true;
            this.warningNombre.ForeColor = System.Drawing.Color.Red;
            this.warningNombre.Location = new System.Drawing.Point(217, 64);
            this.warningNombre.Name = "warningNombre";
            this.warningNombre.Size = new System.Drawing.Size(0, 13);
            this.warningNombre.TabIndex = 9;
            // 
            // warningCodigo
            // 
            this.warningCodigo.AutoSize = true;
            this.warningCodigo.ForeColor = System.Drawing.Color.Red;
            this.warningCodigo.Location = new System.Drawing.Point(217, 19);
            this.warningCodigo.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.warningCodigo.Name = "warningCodigo";
            this.warningCodigo.Size = new System.Drawing.Size(7, 13);
            this.warningCodigo.TabIndex = 8;
            this.warningCodigo.Text = "\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbxImagen);
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 280);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.brnAgregar);
            this.Name = "AgregarArticulo";
            this.Text = "Agregar artículo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lbCodigoArt;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescrp;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbUrlImg;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button brnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label warningCodigo;
        private System.Windows.Forms.Label warningDesc;
        private System.Windows.Forms.Label warningImagen;
        private System.Windows.Forms.Label warningPrecio;
        private System.Windows.Forms.Label warningNombre;
        private System.Windows.Forms.Button button1;
    }
}