using ClassLibrary1;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        { 
            _scenarioContext.Add("firstNumber", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _scenarioContext.Add("secondNumber", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            Calculator c = new();
            int result = c.AddTwoIntegers(_scenarioContext.Get<int>("firstNumber"), _scenarioContext.Get<int>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Calculator c = new();
            int result = c.SubtractTwoIntegers(_scenarioContext.Get<int>("firstNumber"), _scenarioContext.Get<int>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Calculator c = new();
            int result = c.MultiplyTwoIntegers(_scenarioContext.Get<int>("firstNumber"), _scenarioContext.Get<int>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Calculator c = new();
            int result = c.DivideTwoIntegers(_scenarioContext.Get<int>("firstNumber"), _scenarioContext.Get<int>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _scenarioContext.Get<int>("answer").Should().Be(result);
        }


    }
}