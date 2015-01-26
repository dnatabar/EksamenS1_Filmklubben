using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filmklubben;

namespace Filmklubben_Test
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestCategory("MYSQL"), TestMethod]
        public void GetMember()
        {
            DAO db = new DAO();

            Member mRonnie = new Member(1, "Ronnie Awesome", "Henriksen", "Stenstrup Byvej 22", 9500, 51761109, "ronn2743@aspit.dk");

            Member mAssert = db.GetMember(1);

            Assert.AreEqual(mRonnie.Id, mAssert.Id, "ID Mismatch");
            Assert.AreEqual(mRonnie.FName, mAssert.FName, "FName Mismatch");
            Assert.AreEqual(mRonnie.LName, mAssert.LName, "LName Mismatch");
            Assert.AreEqual(mRonnie.Steet, mAssert.Steet, "Street Mismatch");
            Assert.AreEqual(mRonnie.Postal, mAssert.Postal, "Postal Mismatch");
            Assert.AreEqual(mRonnie.Phone, mAssert.Phone, "Phone Mismatch");
            Assert.AreEqual(mRonnie.Email, mAssert.Email, "Email Mismatch");
            Assert.AreEqual(mRonnie.ToString(), mAssert.ToString(), "ToString() Mismatch");

        }

        [TestCategory("MYSQL"), TestMethod]
        public void AddMember()
        {
            DAO db = new DAO();
            Member mRonnie = new Member("Ronnie Awesome", "Henriksen", "Stenstrup Byvej 22", 9500, 51761109, "ronn2743@aspit.dk");

            Assert.IsTrue(db.AddMember(mRonnie), "DAO.AddMember(Member) failed");
        }

        [TestCategory("MYSQL"), TestMethod]
        public void GetMovie()
        {
            DAO db = new DAO();
            Movie movTaken3 = new Movie(1, "Taken 3", new DateTime(2015, 1, 9), "This is Taken 3", "http://ia.media-imdb.com/images/M/MV5BNjM5MDU3NTY0M15BMl5BanBnXkFtZTgwOTk2ODU2MzE@._V1_SX214_AL_.jpg");

            Movie movAssert = db.GetMovie(1);

            Assert.AreEqual(movTaken3.Id, movAssert.Id, "ID Mismatch");
            Assert.AreEqual(movTaken3.ReleaseDate, movAssert.ReleaseDate, "ReleaseDate Mismatch");
            Assert.AreEqual(movTaken3.Title, movAssert.Title, "Title Mismatch");
            Assert.AreEqual(movTaken3.Description, movAssert.Description, "Description Mismatch");
            Assert.AreEqual(movTaken3.CoverURL, movAssert.CoverURL, "CoverURL Mismatch");
        }

        
    }
}
