namespace jogo_sortear
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgPokemon1 = new System.Windows.Forms.PictureBox();
            this.imgPokemon2 = new System.Windows.Forms.PictureBox();
            this.imgPokemon3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPokemon1
            // 
            this.imgPokemon1.Image = ((System.Drawing.Image)(resources.GetObject("imgPokemon1.Image")));
            this.imgPokemon1.Location = new System.Drawing.Point(47, 50);
            this.imgPokemon1.Name = "imgPokemon1";
            this.imgPokemon1.Size = new System.Drawing.Size(162, 223);
            this.imgPokemon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon1.TabIndex = 0;
            this.imgPokemon1.TabStop = false;
            // 
            // imgPokemon2
            // 
            this.imgPokemon2.Image = ((System.Drawing.Image)(resources.GetObject("imgPokemon2.Image")));
            this.imgPokemon2.Location = new System.Drawing.Point(215, 50);
            this.imgPokemon2.Name = "imgPokemon2";
            this.imgPokemon2.Size = new System.Drawing.Size(173, 223);
            this.imgPokemon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon2.TabIndex = 1;
            this.imgPokemon2.TabStop = false;
            // 
            // imgPokemon3
            // 
            this.imgPokemon3.Image = ((System.Drawing.Image)(resources.GetObject("imgPokemon3.Image")));
            this.imgPokemon3.Location = new System.Drawing.Point(405, 50);
            this.imgPokemon3.Name = "imgPokemon3";
            this.imgPokemon3.Size = new System.Drawing.Size(171, 223);
            this.imgPokemon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPokemon3.TabIndex = 2;
            this.imgPokemon3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "SORTEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgPokemon3);
            this.Controls.Add(this.imgPokemon2);
            this.Controls.Add(this.imgPokemon1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPokemon1;
        private System.Windows.Forms.PictureBox imgPokemon2;
        private System.Windows.Forms.PictureBox imgPokemon3;
        private System.Windows.Forms.Button button1;
    }
}

