using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class ToDoItemData
    {
        // HACK: Using static collections here
        // to work around not having a database.
        private static List<ToDoItem> Items = new List<ToDoItem>();
        private static List<string> Categories = new List<string>();

        /// <summary>
        /// Returns a list of to-do items.
        /// </summary>
        /// <returns></returns>
        public static List<ToDoItem> GetToDoItems()
        {
            return Items;
        }

        public static List<string> GetCategories()
        {
            if (Categories.Count == 0)
            {
                Categories.Add("Personal");
                Categories.Add("Work");
                Categories.Add("Chores");
            }

            return Categories;
        }

        /// <summary>
        /// Adds a to-do item.
        /// </summary>
        /// <param name="description">The to-do description.</param>
        /// <param name="category">The to-do category.</param>
        public static void AddItem(string description, string category)
        {
            ToDoItem item = new ToDoItem();
            item.Description = description;
            item.Category = category;
            item.Done = false;

            Items.Add(item);
        }
    }
}