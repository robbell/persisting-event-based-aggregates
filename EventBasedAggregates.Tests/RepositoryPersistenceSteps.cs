using EventBasedAggregates.Core;
using TechTalk.SpecFlow;

namespace EventBasedAggregates.Tests
{
    [Binding]
    public class RepositoryPersistenceSteps
    {
        private SqlServerRepository repository;

        [Given(@"I have a repository")]
        public void GivenIHaveARepository()
        {
            repository = new SqlServerRepository();
        }
        
        [When(@"I save an aggregate")]
        public void WhenISaveAnAggregate()
        {
            repository.Save
        }
        
        [Then(@"the aggregate should be saved to the database")]
        public void ThenTheAggregateShouldBeSavedToTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }

    public class SqlServerRepository : IRepository
    {
        public void Save(Aggregrate aggregrate)
        {
        }
    }
}
