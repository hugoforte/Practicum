using System;
using System.Linq;
using System.Runtime.Remoting;
using GrosvenorDevQuiz.BusinessObjects;
using NUnit.Framework;
using Rhino.Mocks;


namespace GrosVenorDevQuizTests.UnitTests
{
    [TestFixture]
    public class ServerTests
    {
        private IMealProcessor _processor;
        private Server _sut;

        [SetUp]
        public void Setup()
        {
            _processor = MockRepository.Mock<IMealProcessor>();
            _sut = new Server(_processor);
        }

        [Test]
        public void DoesNotThrowErrorWithEmptyOrderd()
        {
            var orderInput = "";
            Assert.DoesNotThrow(() => _sut.TakeOrder(orderInput));
        }}
}