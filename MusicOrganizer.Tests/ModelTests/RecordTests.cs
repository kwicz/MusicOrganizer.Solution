using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTest : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Record newRecord = new Record("Don't Push to Master", "Brooke Travis");
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetRecordTitle_ReturnRecordTitle_String()
    {
      //Arrange
      string title = "Don't Push to Master";
      string artist = "Brooke Travis";

      //Act
      Record newRecord = new Record(title, artist);

      //Assert
      Assert.AreEqual(title, newRecord.Title);
    }
  }
}