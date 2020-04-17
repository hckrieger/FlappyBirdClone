using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SquawkyCock
{
    class Bird : SpriteGameObject
    {
        const float jumpSpeed = -400;
        float gravity;
        const float maxFallSpeed = 500;
        const float minFallSpeed = 100;
        bool startGravity = false;

        public Bird() : base("bird")
        {
            SetOriginToCenter();
            LocalPosition = new Vector2(192, 325);      
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            if (startGravity)
            {
                velocity.Y += gravity;

                if (velocity.Y > maxFallSpeed)
                {
                    gravity = 0;

                } else if (velocity.Y < minFallSpeed)
                {
                    gravity = 25f;
                }
                else
                {
                    gravity = 15f;
                }
            }
                
            
            if (inputHelper.KeyPressed(Keys.Space))
            {
                velocity.Y = jumpSpeed;
                startGravity = true;
            }

            base.Update(gameTime, inputHelper);
        }
    }
}
