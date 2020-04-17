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

            //Add player instance to gameobject heirarchy
            AddChild(bird);

            //Add the pipe spawner instance to game object heirarchy
            AddChild(spawner);

        }

        /* The problem is that the pipes move way to fast at 100 units persecond when I add a list object 
           as a child to the game object heirarchy in the update method.   Would you know why that is?  
           It doesn't clone the pipes when I put this logic in the constructor so I don't know what other
           choice I have */

        public override void Update(GameTime gameTime, InputHelper inputHelper)
        {
            // iterate through the list of pipes located in the PipeSpawner object
            for (int i = 0; i < spawner.pipes.Count; i++)
            {
                //Add each pipe clone to the game object heirarchy 
                AddChild(spawner.pipes[i]);


                // Set offscreen bool to true when pipes are off the screen coordinates 
                if (spawner.pipes[i].LocalPosition.X < 200)
                {
                    spawner.pipes[i].offScreen = true;
                }
            }

            // Remove all pipes when offscreen bool is set to true. (This sadly doesn't work like it should right now.)
            spawner.pipes.RemoveAll(a => a.offScreen == true);

          
                
           
            base.Update(gameTime, inputHelper);
        }


    }
}
