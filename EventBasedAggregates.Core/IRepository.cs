namespace EventBasedAggregates.Core
{
    public interface IRepository
    {
        void Save(Aggregrate aggregrate);
    }
}