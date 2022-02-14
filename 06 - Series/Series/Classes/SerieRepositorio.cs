using System.Collections.Generic; 
using Series.Interfaces; 

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>(); 
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto; 
        }

        public void Exclui(int id)
        {
            if( id > listaSerie.Count() -1 )
            {
                System.Console.WriteLine("{0} Id não existe na lista", id);
            }
            else 
                listaSerie[id].Excluir(); 
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto); 
        }

        public List<Serie> Lista()
        {
            return listaSerie; 
        }

        public int ProximoId()
        {
            return listaSerie.Count; 
        }

        public Serie RetornaPorID(int id)
        {
            return listaSerie[id]; 
        }
    }
}