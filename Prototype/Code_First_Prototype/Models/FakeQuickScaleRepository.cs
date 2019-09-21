using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    public class FakeQuickScaleRepository : IQuickScaleRepository
    {
        public IQueryable<User> Users => new List<User>
        {
            new User
            {
                Username = "guitardood1",
                Email ="guitardood1@fakeemail.com",
                Password = "qwert1"
            },

        }.AsQueryable<User>();

        public IQueryable<SavedFretBoard> SavedFretBoards = new List<SavedFretBoard>
        {
            new SavedFretBoard
            {
                NumberOfFrets = 12,
                NumberOfStrings = 6,
                FirstStringNote = "E",
                SecondStringNote = "B",
                ThirdStringNote = "G",
                FourthStringNote = "D",
                FifthStringNote = "A",
                SixthStringNote = "E",
                SeventhStringNote = null,
                EigthStringNote = null,
            },
        }.AsQueryable<SavedFretBoard>();

        public IQueryable<Scale> Scales = new List<Scale>
        {
            new Scale
            {
                Key = "A",
                Mode = "Blues"
            },

        }.AsQueryable<Scale>();

    }
}
