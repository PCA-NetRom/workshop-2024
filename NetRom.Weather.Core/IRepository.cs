namespace NetRom.Weather.Core
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        //GetById
        //GetAll
        //Delete
        //Update
        //Find
    }

    class City : IEntity
    { }
    public interface IEntity
    {
    }
}
