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
                jugadorDao.eliminarJugador(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
