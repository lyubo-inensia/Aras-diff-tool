using Aras.IOM;
using InnoTool.Models;
using System;
using System.Collections.Generic;

namespace InnoTool.Services
{
    public interface IDiffService
    {
        IEnumerable<DiffItem> CompareItems(IEnumerable<Item> items1, IEnumerable<Item> items2);
        IEnumerable<SingleItem> ListItems(IEnumerable<Item> items1);
    }
}