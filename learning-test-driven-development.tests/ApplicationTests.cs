using System;
using System.Net.Mime;
using Xunit;
using learning_test_driven_development.console;

namespace learning_test_driven_development.tests
{
	public class ApplicationTests
	{


		public ApplicationTests()
		{

		}


		private Application CreateApplication()
		{
			return new Application();
		}

		[Fact]
		public void TestMethod1()
		{
			// Arrange
			var unitUnderTest = this.CreateApplication();

			// Act

			// Assert
			Assert.True(false);
		}
	}
}
