using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SquawkyCock
{
    class TopPipe : SpriteGameObject
    {
    
        public TopPipe() : base("TopPipe")
        {
            //SetOriginToCenter();
            LocalPosition = new Vector2(0, -300);

            
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
        
            base.Update(gameTime, inputHelper);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // draw the correct sprite part at the jewel's position
            spriteBatch.Draw(sprite, GlobalPosition, Color.White);
        }
    }
}
