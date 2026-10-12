using DAO;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class JugadorBll
    {
        private JugadorDao jugadorDao = new JugadorDao();

        private const int numeroMinimo = 1;
        private const int numeroMaximo = 99;
        private const int longitudMaxima = 50;

        // ---------- VALIDACIONES ----------

        public void validarTextoObligatorio(string valor, string campo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(valor))
                    throw new Exception("El " + campo + " es obligatorio.");

                if (valor.Trim().Length > longitudMaxima)
                    throw new Exception("El " + campo + " no puede superar los " + longitudMaxima + " caracteres.");
            }
            catch
            {
                throw;
            }
        }

        public void validarNumero(int numero)
        {
            try
            {
                if (numero < numeroMinimo || numero > numeroMaximo)
                    throw new Exception("El número de camiseta debe estar entre " + numeroMinimo + " y " + numeroMaximo + ".");
            }
            catch
            {
                throw;
            }
        }

        // idExcluido: id del jugador que se está modificando (0 en el alta),
        // así un jugador puede conservar su propio número
        public void validarNumeroNoRepetido(int numero, int idExcluido)
        {
            try
            {
                bool repetido = jugadorDao.getAll().Any(j => j.numero == numero && j.idJugador != idExcluido);
                if (repetido)
                    throw new Exception("Ya existe un jugador con el número " + numero + ".");
            }
            catch
            {
                throw;
            }
        }

        public void validarId(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("El identificador del jugador no es válido.");
            }
            catch
            {
                throw;
            }
        }

        public void validarJugadorExiste(int id)
        {
            try
            {
                bool existe = jugadorDao.getAll().Any(j => j.idJugador == id);
                if (!existe)
                    throw new Exception("El jugador no existe. Puede haber sido eliminado.");
            }
            catch
            {
                throw;
            }
        }

        // Agrupan las validaciones de cada operación
        public void validarAlta(Jugador jugador)
        {
            try
            {
                if (jugador == null)
                    throw new Exception("El jugador no puede ser nulo.");

                validarTextoObligatorio(jugador.nombre, "nombre");
                validarTextoObligatorio(jugador.apellido, "apellido");
                validarNumero(jugador.numero);
                validarNumeroNoRepetido(jugador.numero, 0);
            }
            catch
            {
                throw;
            }
        }

        public void validarModificacion(int id, int nuevoNumero)
        {
            try
            {
                validarId(id);
                validarJugadorExiste(id);
                validarNumero(nuevoNumero);
                validarNumeroNoRepetido(nuevoNumero, id);
            }
            catch
            {
                throw;
            }
        }

        public void validarBaja(int id)
        {
            try
            {
                validarId(id);
                validarJugadorExiste(id);
            }
            catch
            {
                throw;
            }
        }

        // ---------- OPERACIONES ----------

        public List<Jugador> getAll()
        {
            try
            {
                return jugadorDao.getAll();
            }
            catch
            {
                throw;
            }
        }

        public void altaJugador(Jugador jugador)
        {
            try
            {
                validarAlta(jugador);

                jugador.nombre = jugador.nombre.Trim();
                jugador.apellido = jugador.apellido.Trim();

                jugadorDao.altaJugador(jugador);
            }
            catch
            {
                throw;
            }
        }

        public void modificarJugador(int id, int nuevoNumero, bool habilitado)
        {
            try
            {
                validarModificacion(id, nuevoNumero);
                jugadorDao.modificarJugador(id, nuevoNumero, habilitado);
            }
            catch
            {
                throw;
            }
        }

        public void eliminarJugador(int id)
        {
            try
            {
                validarBaja(id);
                jugadorDao.eliminarJugador(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
