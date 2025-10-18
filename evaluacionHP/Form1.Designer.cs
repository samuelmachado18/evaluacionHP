namespace evaluacionHP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrear = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lblposX2 = new Label();
            lblposY2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboTipo = new ComboBox();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            txtAncho = new TextBox();
            txtLargo = new TextBox();
            txtContador = new TextBox();
            txtPosX_2 = new TextBox();
            txtPosY_2 = new TextBox();
            pbDiseño = new PictureBox();
            label2 = new Label();
            pbColor = new PictureBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pbDiseño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(429, 330);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(117, 54);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(610, 330);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 54);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 83);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Figura:";
            // 
            // lblposX2
            // 
            lblposX2.AutoSize = true;
            lblposX2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblposX2.Location = new Point(66, 274);
            lblposX2.Name = "lblposX2";
            lblposX2.Size = new Size(100, 19);
            lblposX2.TabIndex = 3;
            lblposX2.Text = "Posicion Y(2):";
            // 
            // lblposY2
            // 
            lblposY2.AutoSize = true;
            lblposY2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblposY2.Location = new Point(66, 244);
            lblposY2.Name = "lblposY2";
            lblposY2.Size = new Size(102, 19);
            lblposY2.TabIndex = 4;
            lblposY2.Text = "Posicion X(2):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 216);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 5;
            label4.Text = "Largo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 185);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 6;
            label5.Text = "Ancho/Radio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 151);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 7;
            label6.Text = "Posicion Y:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 116);
            label7.Name = "label7";
            label7.Size = new Size(84, 19);
            label7.TabIndex = 8;
            label7.Text = "Posicion X:";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(201, 83);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(143, 23);
            cboTipo.TabIndex = 9;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(201, 116);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(143, 23);
            txtPosX.TabIndex = 10;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(201, 151);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(143, 23);
            txtPosY.TabIndex = 11;
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(201, 181);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(143, 23);
            txtAncho.TabIndex = 12;
            // 
            // txtLargo
            // 
            txtLargo.Location = new Point(201, 212);
            txtLargo.Name = "txtLargo";
            txtLargo.Size = new Size(143, 23);
            txtLargo.TabIndex = 13;
            // 
            // txtContador
            // 
            txtContador.Location = new Point(523, 406);
            txtContador.Name = "txtContador";
            txtContador.Size = new Size(100, 23);
            txtContador.TabIndex = 14;
            // 
            // txtPosX_2
            // 
            txtPosX_2.Location = new Point(201, 244);
            txtPosX_2.Name = "txtPosX_2";
            txtPosX_2.Size = new Size(143, 23);
            txtPosX_2.TabIndex = 14;
            // 
            // txtPosY_2
            // 
            txtPosY_2.Location = new Point(201, 274);
            txtPosY_2.Name = "txtPosY_2";
            txtPosY_2.Size = new Size(143, 23);
            txtPosY_2.TabIndex = 15;
            // 
            // pbDiseño
            // 
            pbDiseño.Location = new Point(431, 83);
            pbDiseño.Name = "pbDiseño";
            pbDiseño.Size = new Size(296, 195);
            pbDiseño.TabIndex = 16;
            pbDiseño.TabStop = false;
            pbDiseño.Paint += pbDiseño_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 29);
            label2.Name = "label2";
            label2.Size = new Size(328, 24);
            label2.TabIndex = 17;
            label2.Text = "Generador de Figuras Geometricas ";
            // 
            // pbColor
            // 
            pbColor.BorderStyle = BorderStyle.FixedSingle;
            pbColor.Location = new Point(201, 316);
            pbColor.Name = "pbColor";
            pbColor.Size = new Size(143, 28);
            pbColor.TabIndex = 18;
            pbColor.TabStop = false;
            pbColor.Click += pbColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 316);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 19;
            label3.Text = "Color:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pbColor);
            Controls.Add(label2);
            Controls.Add(pbDiseño);
            Controls.Add(txtPosY_2);
            Controls.Add(txtPosX_2);
            Controls.Add(txtContador);
            Controls.Add(txtLargo);
            Controls.Add(txtAncho);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(cboTipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblposY2);
            Controls.Add(lblposX2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbDiseño).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrear;
        private Button btnEliminar;
        private Label label1;
        private Label lblposX2;
        private Label lblposY2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboTipo;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private TextBox txtAncho;
        private TextBox txtLargo;
        private TextBox txtContador;
        private TextBox txtPosX_2;
        private TextBox txtPosY_2;
        private PictureBox pbDiseño;
        private Label label2;
        private PictureBox pbColor;
        private Label label3;
        private ColorDialog colorDialog1;
    }
}
