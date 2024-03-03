namespace ChallengeApp2024.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrenge
            var user = new User("Adam", "sdsaf234");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResult()
        {
            // arrenge
            var user = new User("Adam", "sdsaf234");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(7);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(18, result);
        }

        [Test]
        public void WhenUserCollectMinusPoint_ShouldCorrectResult()
        {
            // arrenge
            var user = new User("Adam", "sdsaf234");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}