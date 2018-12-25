using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

[assembly: LightBddScope]

namespace Kalkulator.Tests.BDD
{
    [FeatureFixture]
    public partial class SampleTest : FeatureFixture
    {
        public SampleTest(ITestOutputHelper output) : base(output)
        {
        }

        private Stack<int> stack;
        private int result;

        // Empty

        private void given_an_empty_stack()
        {
            stack = new Stack<int>();
        }

        private void then_it_has_no_elements()
        {
            Assert.Empty(stack);
        }

        private void then_throws_an_exception_when_calling_pop()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        private void then_it_throws_an_exception_when_calling_peek()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }


        // Not empty

        private void given_a_non_empty_stack()
        {
            stack = new Stack<int>(new[] { 1, 2, 3 });
        }

        private void when_calling_peek()
        {
            result = stack.Peek();
        }

        private void then_it_returns_the_top_element()
        {
            Assert.Equal(result, 3);
        }

        private void then_it_does_not_remove_the_top_element()
        {
            Assert.True(stack.Contains(3));
        }

        private void when_calling_pop()
        {
            result = stack.Pop();
        }

        private void then_it_removes_the_top_element()
        {
            Assert.False(stack.Contains(result));
        }
    }
}
