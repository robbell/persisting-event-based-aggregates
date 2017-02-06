namespace EventBasedAggregates.Core
{
    public class CommandHandler
    {
        private readonly IFactory factory;
        private readonly IRepository repository;

        public CommandHandler(IFactory factory, IRepository repository)
        {
            this.factory = factory;
            this.repository = repository;
        }

        public void Handle(MyCommand myCommand)
        {
            var aggregate = factory.Create();

            repository.Save(aggregate);
        }
    }
}