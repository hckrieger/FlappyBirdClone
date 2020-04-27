using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SquawkyCock
{
    class Bird : SpriteGameObject
    {
        
        public bool HitPipe { get; set; }
        public bool Gravity { get; set; }

        float jumpSpeed = -400;
        float fallSpeed;
        const float maxFallSpeed = 500;
        const float minFallSpeed = 100;
        
        

        public Bird() : base("bird")
        {
            SetOriginToCenter();
            LocalPosition = new Vector2(192, 325);
            HitPipe = false;
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            //set gravity physics
            if (Gravity)
            {
                velocity.Y += fallSpeed;

                if (velocity.Y > maxFallSpeed)
                {
                    fallSpeed = 0;

                }
                else if (velocity.Y < minFallSpeed)
                {
                    fallSpeed = 25f;
                }
                else
                {
                    fallSpeed = 15f;
                }
            } 


            //Press the spacebar to jump up
            if (!HitPipe)
            { 
                if (inputHelper.KeyPressed(Keys.Space))
                {
                    velocity.Y = jumpSpeed;
                    Gravity = true;
                    
                }
            }

            


            base.Update(gameTime, inputHelper);

        }

        public override void Reset()
        {
            Gravity = false;
            HitPipe = false;
            velocity.Y = 0;
            jumpSpeed = -400;
            LocalPosition = new Vector2(192, 325);
            
        }
  


    }
}
