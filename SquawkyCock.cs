using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SquawkyCock
{
    class SquawkyCock : ExtendedGame
    {
        
        public SquawkyCock()
        {

        }

        protected override void LoadContent()
        {
            base.LoadContent();
            gameWorld = new GameWorld(this);

        }

        public static GameWorld GameWorld
        {
            get { return (GameWorld)gameWorld; }
        }
    }
}
