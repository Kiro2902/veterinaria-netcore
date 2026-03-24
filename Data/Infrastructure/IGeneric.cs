namespace VeterinariaWeb.Data.Infrastructure
{
    public interface IGeneric<Entity> where Entity : class /*Suele llamarse "<T>"*/
    {
        List<Entity> Listar();
        Entity ObtenerPorId(int id);
        bool Registrar(Entity entity);
        bool Modificar(Entity entity);
        bool Eliminar(int id);
    }
}
