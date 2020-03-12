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
    
    [TestMethod]
    public void GetRecordArtist_ReturnRecordArtist_String()
    {
      //Arrange
      string title = "Don't Push to Master";
      string artist = "Brooke Travis";

      //Act
      Record newRecord = new Record(title, artist);

      //Assert
      Assert.AreEqual(artist, newRecord.Artist);
    }
    
    [TestMethod]
    public void SetRecordTitle_ReturnSetRecordArtist_String()
    {
      //Arrange
      string title = "Don't Push to Master";
      string artist = "Brooke Travis";
      Record newRecord = new Record(title, artist);

      //Act
      string updatedTitle = "Push to Branch";
      newRecord.Title = updatedTitle;
      string result = newRecord.Title;

      //Assert
      Assert.AreEqual(updatedTitle, newRecord.Title);
    }

  }
}