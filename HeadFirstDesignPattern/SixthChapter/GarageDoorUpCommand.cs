using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstDesignPattern.SixthChapter
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _door;

        public GarageDoorUpCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Up(); 
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
