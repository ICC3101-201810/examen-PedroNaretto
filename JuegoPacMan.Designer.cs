namespace WindowsFormsApp4
{
    partial class JuegoPacMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoPacMan));
            this.Pacman = new System.Windows.Forms.PictureBox();
            this.FantasmaRosado = new System.Windows.Forms.PictureBox();
            this.FantasmaRojo = new System.Windows.Forms.PictureBox();
            this.Cherry = new System.Windows.Forms.PictureBox();
            this.Uva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacman
            // 
            this.Pacman.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pacman.Image = global::WindowsFormsApp4.Properties.Resources.pacman_up;
            this.Pacman.InitialImage = null;
            this.Pacman.Location = new System.Drawing.Point(367, 210);
            this.Pacman.Name = "Pacman";
            this.Pacman.Size = new System.Drawing.Size(30, 30);
            this.Pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pacman.TabIndex = 0;
            this.Pacman.TabStop = false;
            this.Pacman.WaitOnLoad = true;
            // 
            // FantasmaRosado
            // 
            this.FantasmaRosado.ErrorImage = ((System.Drawing.Image)(resources.GetObject("FantasmaRosado.ErrorImage")));
            this.FantasmaRosado.Image = ((System.Drawing.Image)(resources.GetObject("FantasmaRosado.Image")));
            this.FantasmaRosado.InitialImage = ((System.Drawing.Image)(resources.GetObject("FantasmaRosado.InitialImage")));
            this.FantasmaRosado.Location = new System.Drawing.Point(568, 210);
            this.FantasmaRosado.Name = "FantasmaRosado";
            this.FantasmaRosado.Size = new System.Drawing.Size(30, 30);
            this.FantasmaRosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FantasmaRosado.TabIndex = 1;
            this.FantasmaRosado.TabStop = false;
            this.FantasmaRosado.WaitOnLoad = true;
            // 
            // FantasmaRojo
            // 
            this.FantasmaRojo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("FantasmaRojo.ErrorImage")));
            this.FantasmaRojo.Image = ((System.Drawing.Image)(resources.GetObject("FantasmaRojo.Image")));
            this.FantasmaRojo.InitialImage = ((System.Drawing.Image)(resources.GetObject("FantasmaRojo.InitialImage")));
            this.FantasmaRojo.Location = new System.Drawing.Point(161, 210);
            this.FantasmaRojo.Name = "FantasmaRojo";
            this.FantasmaRojo.Size = new System.Drawing.Size(30, 30);
            this.FantasmaRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FantasmaRojo.TabIndex = 2;
            this.FantasmaRojo.TabStop = false;
            // 
            // Cherry
            // 
            this.Cherry.Image = ((System.Drawing.Image)(resources.GetObject("Cherry.Image")));
            this.Cherry.InitialImage = ((System.Drawing.Image)(resources.GetObject("Cherry.InitialImage")));
            this.Cherry.Location = new System.Drawing.Point(629, 12);
            this.Cherry.Name = "Cherry";
            this.Cherry.Size = new System.Drawing.Size(30, 30);
            this.Cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cherry.TabIndex = 3;
            this.Cherry.TabStop = false;
            // 
            // Uva
            // 
            this.Uva.Image = ((System.Drawing.Image)(resources.GetObject("Uva.Image")));
            this.Uva.InitialImage = ((System.Drawing.Image)(resources.GetObject("Uva.InitialImage")));
            this.Uva.Location = new System.Drawing.Point(678, 12);
            this.Uva.Name = "Uva";
            this.Uva.Size = new System.Drawing.Size(30, 30);
            this.Uva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Uva.TabIndex = 4;
            this.Uva.TabStop = false;
            // 
            // JuegoPacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uva);
            this.Controls.Add(this.Cherry);
            this.Controls.Add(this.FantasmaRojo);
            this.Controls.Add(this.FantasmaRosado);
            this.Controls.Add(this.Pacman);
            this.Name = "JuegoPacMan";
            this.Text = "JuegoPacMan";
            this.Load += new System.EventHandler(this.JuegoPacMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantasmaRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Pacman;
        public System.Windows.Forms.PictureBox FantasmaRosado;
        private System.Windows.Forms.PictureBox FantasmaRojo;
        private System.Windows.Forms.PictureBox Cherry;
        private System.Windows.Forms.PictureBox Uva;
    }
}