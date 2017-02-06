using EventBasedAggregates.Core;
using Moq;
using TechTalk.SpecFlow;

namespace EventBasedAggregates.Tests
{
    [Binding]
    public class HandlerSavesAggregateToRepositorySteps
    {
        private CommandHandler handler;
        private IRepository repository;
        private IFactory factory;
        private Aggregrate expectedAggregrate;

        [Given(@"I have a command handler")]
        public void GivenIHaveACommandHandler()
        {
            expectedAggregrate = new Aggregrate();
            factory = Mock.Of<IFactory>(f => f.Create() == expectedAggregrate);
            repository = Mock.Of<IRepository>();

            handler = new CommandHandler(factory, repository);
        }

        [When(@"I press pass it a command")]
        public void WhenIPressPassItACommand()
        {
            handler.Handle(new MyCommand {Text = "Hello"});
        }
        
        [Then(@"the resulting event should be persisted to the database")]
        public void ThenTheResultingEventShouldBePersistedToTheDatabase()
        {
            Mock.Get(repository).Verify(r => r.Save(expectedAggregrate));
        }
    }
}
