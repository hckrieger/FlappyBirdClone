using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SquawkyCock
{
    class Pipes : GameObject
    {
        TopPipe topPipe = new TopPipe();
        BottomPipe bottomPipe = new BottomPipe();
        float pipeSpeed = -25;
        public bool offScreen = false;

        public Pipes()
        {
            LocalPosition = new Vector2(400, ExtendedGame.Random.Next(-350, -50));

            topPipe.Parent = this;
            bottomPipe.Parent = this;
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            velocity.X = -100;
            base.Update(gameTime, inputHelper);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            topPipe.Draw(gameTime, spriteBatch);
            bottomPipe.Draw(gameTime, spriteBatch);
            base.Draw(gameTime, spriteBatch);
        }
    }
}
