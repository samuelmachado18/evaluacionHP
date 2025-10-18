using System.Windows.Forms;

namespace evaluacionHP
{
    public partial class Form1 : Form
    {
        private List<figura> figuras = new List<figura>();
        private Color colorSeleccionado = Color.Beige;
        public Form1()
        {
            InitializeComponent();
            pbDiseño.Paint += pbDiseño_Paint_1;
            pbDiseño.BackColor = Color.White;
            pbDiseño.BorderStyle = BorderStyle.FixedSingle;
            pbDiseño.Invalidate();
            

            cboTipo.Items.Add("Rectangulo");
            cboTipo.Items.Add("Circulo");
            cboTipo.Items.Add("Triangulo");
            cboTipo.Items.Add("Linea");
        }

        private void ActualizarContador()
        {
            txtContador.Text = figuras.Count.ToString();
        }

        private void pbDiseño_Paint_1(object sender, PaintEventArgs e)
        {
            foreach (var f in figuras)
            {
                f.Dibujar(e.Graphics);
            }
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
                return;

            try
            {
                string tipo = cboTipo.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Seleccione un tipo de figura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




                int x = int.Parse(txtPosX.Text);
                int y = int.Parse(txtPosY.Text);
                int x2 = int.Parse(txtPosX_2.Text);
                int y2 = int.Parse(txtPosY_2.Text);
                int ancho = int.Parse(txtAncho.Text);
                int largo = int.Parse(txtLargo.Text);


                Color color = colorSeleccionado;

                figura nueva = figuraFactory.CrearFigura(tipo, x, y, x2, y2, ancho, largo, color);


                Rectangle diseño = new Rectangle(0, 0, pbDiseño.Width, pbDiseño.Height);
                if (!nueva.EstaDentro(diseño))
                {
                    MessageBox.Show("La figura no cabe completamente dentro del lienzo. Ajuste posición o tamaño.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                figuras.Add(nueva);
                ActualizarContador();


                pbDiseño.Invalidate();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la figura:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            figuras.Clear();
            pbDiseño.Invalidate();
            ActualizarContador();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cboTipo.SelectedItem?.ToString() ?? "";

            if (tipo == "Rectangulo" || tipo == "Circulo")
            {
                txtPosX_2.Visible = false;
                txtPosY_2.Visible = false;
                txtPosY_2.Text = "0";
                txtPosX_2.Text = "0";
                lblposY2.Visible = false;
                lblposX2.Visible = false;
            }
            else
            {
                txtPosX_2.Visible = true;
                txtPosY_2.Visible = true;
                lblposY2.Visible = true;
                lblposX2.Visible = true;
            }
        }

        private bool ValidarEntrada()
        {
            TextBox[] campos = { txtPosX, txtPosY, txtPosX_2, txtPosY_2, txtAncho, txtLargo };

            foreach (var campo in campos)
            {
                if (campo.Visible)
                {
                    if (string.IsNullOrWhiteSpace(campo.Text))
                    {
                        MessageBox.Show($"El campo {campo.Name} no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (!int.TryParse(campo.Text, out int valor))
                    {
                        MessageBox.Show($"El campo {campo.Name} solo puede contener números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (valor < 0)
                    {
                        MessageBox.Show($"El campo {campo.Name} no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void LimpiarCampos()
        {

            txtPosX.Clear();
            txtPosY.Clear();
            txtPosX_2.Clear();
            txtPosY_2.Clear();
            txtAncho.Clear();
            txtLargo.Clear();


            cboTipo.SelectedIndex = -1;


            txtPosX_2.Visible = true;
            txtPosY_2.Visible = true;
            lblposX2.Visible = true;
            lblposY2.Visible = true;



        }

        private void pbColor_Click(object sender, EventArgs e)
        {
           if (colorDialog1.ShowDialog() == DialogResult.OK)
              {
                colorSeleccionado = colorDialog1.Color; 
                pbColor.BackColor = colorDialog1.Color;
            }
            
        }
    }
}
