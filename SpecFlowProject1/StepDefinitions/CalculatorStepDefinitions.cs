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
        public void GivenTheFirstNumberIs(float number)
        { 
            _scenarioContext.Add("firstNumber", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(float number)
        {
            _scenarioContext.Add("secondNumber", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Calculator c = new();
            try
            {
                float result = c.AddTwoIntegers(_scenarioContext.Get<float>("firstNumber"), _scenarioContext.Get<float>("secondNumber"));
                _scenarioContext.Add("answer", result);
            }
            catch (Exception ex) 
            {
                _scenarioContext.Add("error", ex.Message);
            }
           
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            Calculator c = new();
            float result = c.SubtractTwoIntegers(_scenarioContext.Get<float>("firstNumber"), _scenarioContext.Get<float>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            Calculator c = new();
            float result = c.MultiplyTwoIntegers(_scenarioContext.Get<float>("firstNumber"), _scenarioContext.Get<float>("secondNumber"));
            _scenarioContext.Add("answer", result);
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            Calculator c = new();
            try
            {
                float result = c.DivideTwoIntegers(_scenarioContext.Get<float>("firstNumber"), _scenarioContext.Get<float>("secondNumber"));
                _scenarioContext.Add("answer", result);
            }
            catch (Exception ee) 
            {
                _scenarioContext.Add("error", ee.Message);
                
            }
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(float result)
        {
            _scenarioContext.Get<float>("answer").Should().Be(result);
        }


        [Then("the real result should be (.*)")]
        public void ThenTheRealResultShouldBe(float result)
        {
            _scenarioContext.Get<float>("answer").Should().BeApproximately(result, 0.1f);
        }

        [Then(@"the '([^']*)' error should occur")]
        public void ThenTheErrorShouldOccur(string p0)
        {
            _scenarioContext.Get<string>("error").Should().Be(p0);
        }

      


    }
}