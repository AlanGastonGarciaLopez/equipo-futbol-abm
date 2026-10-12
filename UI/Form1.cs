using ENTITIES;
using BLL;
namespace UI
{
    public partial class Form1 : Form
    {
        private JugadorBll jugadorBusiness = new JugadorBll();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cargarGrilla()
        {
            try
            {
                dgvJugadores.DataSource = null;
                dgvJugadores.DataSource = jugadorBusiness.getAll();
                dgvJugadores.CurrentCell = null; // sin fila seleccionada hasta que el usuario haga clic
            }
            catch
            {
                throw;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador jugador = new Jugador
                {
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    numero = Convert.ToInt32(txtNumero.Text),
                    habilitado = chkHabilitado.Checked
                };

                jugadorBusiness.altaJugador(jugador);
                cargarGrilla();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador seleccionado = getJugadorSeleccionado();
                if (seleccionado == null)
                {
                    MessageBox.Show("Seleccioná un jugador de la grilla.");
                    return;
                }

                jugadorBusiness.modificarJugador(seleccionado.idJugador, Convert.ToInt32(txtNumero.Text), chkHabilitado.Checked);
                cargarGrilla();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador seleccionado = getJugadorSeleccionado();
                if (seleccionado == null)
                {
                    MessageBox.Show("Seleccioná un jugador de la grilla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Eliminar a " + seleccionado.apellido + "?", "Confirmar baja", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    jugadorBusiness.eliminarJugador(seleccionado.idJugador);
                    cargarGrilla();
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Jugador getJugadorSeleccionado()
        {
            try
            {
                if (dgvJugadores.CurrentRow == null)
                    return null;

                return (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
            }
            catch
            {
                throw;
            }
        }

        private void limpiarCampos()
        {
            try
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtNumero.Clear();
                chkHabilitado.Checked = true;
            }
            catch
            {
                throw;
            }
        }

        private void dgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                Jugador seleccionado = getJugadorSeleccionado();
                if (seleccionado != null)
                {
                    txtNombre.Text = seleccionado.nombre;
                    txtApellido.Text = seleccionado.apellido;
                    txtNumero.Text = seleccionado.numero.ToString();
                    chkHabilitado.Checked = seleccionado.habilitado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
