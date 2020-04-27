using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
namespace SquawkyCock
{
    class GameWorld : GameObjectList
    {
        public Bird Bird { get; private set; }
        PipeSpawner spawner = new PipeSpawner();

        SquawkyCock game;

        public GameWorld(SquawkyCock game)
        {
            this.game = game;

            
            

            //Add the pipe spawner instance to game object heirarchy
            AddChild(spawner);

            //Add player instance to gameobject heirarchy
            AddChild(Bird = new Bird());

        }

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {

            if (spawner.PipeServer != null)
            {

                AddChild(spawner.PipeServer);
                spawner.PipeServer = null;
            }


            // Set offscreen bool to true when pipes are off the screen coordinates 
            int count = spawner.Pipes.Count;

            for (int i = 0; i < count; i++)
            {
                //If the bird collides with the top or bottom pipes......
                if (Bird.BoundingBox.Intersects(spawner.Pipes[i].TopPipe.BoundingBox) ||
                    Bird.BoundingBox.Intersects(spawner.Pipes[i].BottomPipe.BoundingBox))
                {
                    spawner.Playing = false;
                    spawner.Pipes[i].Speed = 0f;
                    spawner.Pipes[count - 1].Speed = 0f;
                    Bird.HitPipe = true;

                }

                if (Bird.LocalPosition.Y > 675)
                {
                    RemoveChild(spawner.Pipes[i]);
                    RemoveChild(spawner.Pipes[count - 1]);

                }


                if (spawner.Pipes[i].LocalPosition.X < -100)
                {
                    spawner.Pipes[i].OffScreen = true;
                    RemoveChild(spawner.Pipes[i]);
                }

            }

            if (Bird.LocalPosition.Y > 675)
            {
                spawner.Pipes.Clear();
                spawner.Reset();
                Bird.Reset();
            }

            spawner.Pipes.RemoveAll(a => a.OffScreen == true);




            base.Update(gameTime, inputHelper);
        }




    }
}
