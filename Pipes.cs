using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SquawkyCock
{
    class Pipes : GameObject
    {
        //Get instance of the top pipe
        TopPipe topPipe = new TopPipe();

        //Get instance of bottom pipe
        BottomPipe bottomPipe = new BottomPipe();

        public bool offScreen = false;

        public Pipes()
        {
            LocalPosition = new Vector2(500, ExtendedGame.Random.Next(-400, -50));

            //Make this object the Parent of the top and bottom pipes so they can move together as a unit
            topPipe.Parent = this;
            bottomPipe.Parent = this;
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            // move to the left side of the screen 100 units per second
            velocity.X = -100;
            base.Update(gameTime, inputHelper);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // draw the top and bottom pipes so it connects to this game object when added to the heirarchy
            topPipe.Draw(gameTime, spriteBatch);
            bottomPipe.Draw(gameTime, spriteBatch);
            base.Draw(gameTime, spriteBatch);
        }
    }
}
