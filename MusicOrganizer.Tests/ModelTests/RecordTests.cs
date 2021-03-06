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
    
    [TestMethod]
    public void GetAll_ReturnsRecords_RecordList()
    {
      //Arrange
      string title = "Don't Push to Master";
      string artist = "Brooke Travis";
      Record newRecord1 = new Record(title, artist);
      Record newRecord2 = new Record(title, artist);
      List<Record> newList = new List<Record> { newRecord1, newRecord2 };

      //Act
      List<Record> result = Record.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void Find_ReturnsCorrectRecord_Record()
    {
      //Arrange
      string title = "Don't Push to Master";
      string artist = "Brooke Travis";
      Record newRecord1 = new Record(title, artist);
      Record newRecord2 = new Record("Push to Branch", "Travis Brooke");

      //Act
      Record result = Record.Find(2);

      //Assert
      Assert.AreEqual(newRecord2, result);
    }
  }
}