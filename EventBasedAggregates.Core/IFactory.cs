namespace EventBasedAggregates.Core
{
    public interface IFactory
    {
        Aggregrate Create();
    }
}