using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;


namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes.";
      newItem.Description = updatedDescription;
      string result = newItem.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_RetursEmptyList_ItemList()
    {
      //Arrange
      List<Item> newList = new List<Item>{};
      
      //Act
      List<Item> result = Item.GetAll();
      foreach(Item thisItem in result)
      Console.WriteLine("output from empty list GetAll test: " + thisItem.Description);

      //Assert
      CollectionAssert.AreEqual(newList, result);
   }

   [TestMethod]
   public void GetAll_ReturnsItems_ItemList()
   {
   //Arrange
   string description1 = "Walk the dog.";
   string description2 = "Wash the dishes.";
   Item newItem1 = new Item(description1);
   Item newItem2 = new Item(description2);
   List<Item> newList = new List<Item>{newItem1, newItem2};

   //Act
   List<Item> result = Item.GetAll();
   foreach(Item thisItem in result)
   {
     Console.WriteLine("output from second GetAll test: " + thisItem.Description);
   }

   //Assert
   CollectionAssert.AreEqual(newList, result);

   }

   [TestMethod]
   public void GetId_ItemsInstantiateWithAndIdAndGetterReturns_Int()
   {
     //Arrange
     string description = "Walk the dog.";
     Item newItem = new Item(description);


     //Act
     int result = newItem.Id;

     //Assert
     Assert.AreEqual(1, result);
   }

   [TestMethod]
   public void Find_ReturnsCorrectItem_Item()
   {
     //Arrange
     string description1 = "Walk the dog.";
     string description2 = "Wash the dishes";
     Item newItem1 = new Item(description1);
     Item newItem2 = new Item(description2);

     //Act
     Item result = new Item("Incorrect test item");

     //Assert
     Assert.AreEqual(result, newItem2);
   }
  }
}
