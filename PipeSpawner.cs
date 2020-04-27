using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace SquawkyCock
{
    class PipeSpawner : GameObject
    {
        //Make a list of the pipes 
        public List<Pipes> Pipes { get; set; }
        public Pipes PipeServer { get; set; }
        public bool Playing { get; set; }

        float timer = 1f;

        public PipeSpawner()
        {
            Pipes = new List<Pipes>();
            Playing = true;
        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            if (Playing && SquawkyCock.GameWorld.Bird.Gravity)
            {
                timer -= dt;
                if (timer <= 0)
                {
                    //Instansiate a pipe every two seconds and reset the timer
                    var pipe = new Pipes();
                    Pipes.Add(pipe);
                    PipeServer = pipe;
                    timer = 2f;
                }
            }


            base.Update(gameTime, inputHelper);
        }

        public override void Reset()
        {
            Playing = true;
            timer = 1;
        }


    }
}
