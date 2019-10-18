using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleAndIdentity.Models
{
    public static class SavedFretBoardViewModel
    {
        private static List<SavedFretBoard> savedFretBoards = new List<SavedFretBoard>();
        public static IEnumerable<SavedFretBoard> SavedFretBoards
        {
            get 
            {
                return savedFretBoards;
            }
        }
        public static void AddSettings(SavedFretBoard savedFretBoard)
        {
            savedFretBoards.Add(savedFretBoard);
        }
    }
}
