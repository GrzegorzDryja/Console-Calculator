using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.XUnit2;

namespace Kalkulator.Tests.BDD
{
    [FeatureDescription("Description")]
    [Label("LIFO")]
    public partial class SampleTest
    {
        [Scenario]
        [Label("Empty")]
        [ScenarioCategory("Category")]
        public void Empty_stack()
        {
            Runner.RunScenario(
                given_an_empty_stack,
                then_it_has_no_elements,
                then_throws_an_exception_when_calling_pop,
                then_it_throws_an_exception_when_calling_peek
                );
        }

        [Scenario]
        [Label("Not empty")]
        public void Non_empty_stack()
        {
            Runner.RunScenario(
                given_a_non_empty_stack,
                when_calling_peek,
                then_it_returns_the_top_element,
                then_it_does_not_remove_the_top_element,
                when_calling_pop,
                then_it_returns_the_top_element,
                then_it_removes_the_top_element
                );
        }
    }
}
