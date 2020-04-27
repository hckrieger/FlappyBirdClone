using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace SquawkyCock
{
    class Pipes : GameObject
    {

        //Get instance of the top pipe
        public TopPipe TopPipe { get; private set; }

        //Get instance of bottom pipe
        public BottomPipe BottomPipe { get; private set; }

        public bool OffScreen { get; set; }

        public float Speed { get; set; }

        public Pipes()
        {
            LocalPosition = new Vector2(500, ExtendedGame.Random.Next(-380, -25));

            TopPipe = new TopPipe();
            BottomPipe = new BottomPipe();
            Speed = -150;
            OffScreen = false;

            //Make this object the Parent of the top and bottom pipes so they can move together as a unit
            TopPipe.Parent = this;
            BottomPipe.Parent = this; 
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            // move to the left side of the screen 100 units per second
            velocity.X = Speed;




            base.Update(gameTime, inputHelper);
        }

        public override void Reset()
        {
            velocity.X = Speed;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // draw the top and bottom pipes so it connects to this game object when added to the heirarchy
            TopPipe.Draw(gameTime, spriteBatch);
            BottomPipe.Draw(gameTime, spriteBatch);
            base.Draw(gameTime, spriteBatch);
        }


    }
}
