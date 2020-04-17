using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace SquawkyCock
{
    class PipeSpawner : GameObject
    {
        public List<Pipes> pipes = new List<Pipes>();
        float timer = 2f;

        public PipeSpawner()
        {
            
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            timer -= dt;
            if (timer <= 0)
            {
                pipes.Add(new Pipes());
                timer = 2f;
            }

            base.Update(gameTime, inputHelper);
        }
    }
}
