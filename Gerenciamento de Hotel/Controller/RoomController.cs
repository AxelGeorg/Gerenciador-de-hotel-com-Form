using Gerenciamento_de_Hotel.Model.DAO;
using Gerenciamento_de_Hotel.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Hotel.Controller
{
    public class RoomController
    {
        RoomDAO roomDAO = new RoomDAO();

        public List<Room> retornaRoom(int tipoOrdenacao)
        {
            return roomDAO.BuscarQuartos(tipoOrdenacao);
        }
        public bool cadastrarRoom(Room room)
        {
            //Daniel 09/07/2020 Chama o método para cadastrar os quartos.
            return roomDAO.cadastrarRoom(room.room_numeroQuarto, room.room_quantPessoa, room.room_quantCasal, room.room_quantSolteiro, room.room_disponibilidade, room.room_limpeza, room.room_precoDiaria, room.room_precoTotal);
        }
        public bool alteraRoom(Room room)
        {
            //Daniel 09/07/2020 Chama o método para cadastrar os quartos.
            return roomDAO.alteraRoom(room.room_id, room.room_numeroQuarto, room.room_quantPessoa, room.room_quantCasal, room.room_quantSolteiro, room.room_disponibilidade, room.room_limpeza, room.room_precoDiaria, room.room_precoTotal);
        }
        public bool deletaRoom(int id)
        {
            return roomDAO.deletaRoom(id);
        }
    }
}
