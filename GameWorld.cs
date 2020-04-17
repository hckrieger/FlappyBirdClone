using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SquawkyCock
{
    class GameWorld : GameObjectList
    {
        PipeSpawner spawner = new PipeSpawner();
        SquawkyCock game;


        Bird bird = new Bird();

        public GameWorld(SquawkyCock game)
        {
            this.game = game;

            AddChild(bird);
            AddChild(spawner);

        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            for (int i = 0; i < spawner.pipes.Count; i++)
            {
                AddChild(spawner.pipes[i]);

                if (spawner.pipes[i].LocalPosition.X < 200)
                {
                    spawner.pipes[i].offScreen = true;
                }
            }

            spawner.pipes.RemoveAll(a => a.offScreen == true);
            //spawner.Update(gameTime, inputHelper);

          
                
           
            base.Update(gameTime, inputHelper);
        }


    }
}
