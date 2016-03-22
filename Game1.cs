using System;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media; 


namespace Game2
{
 
    public class Game1 : Game
    {
       
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D hero;
        Texture2D blok_1, blok_2;
        Texture2D floor;
        Rectangle hero_pos = new Rectangle();
        Vector2 blok_1_pose = new Vector2();
        Vector2 blok_2_pose = new Vector2();
        float timeForJump = 0.3f;
        float time_jump = 0;
 
      
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

      
        protected override void Initialize()
        {
           

            base.Initialize();
        }

        void Greatemap()
        {
            int[,] map;

            
            
   map = new int[,] 
  {{2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,2,2,2,2,2,2,2,0,0,2}, 
  {2,0,0,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,2,2,2,2,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2}, 
  {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,2}, 
  {2,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,2}, 
  {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}};
   int x = 0;
   int y = 0;
   for (int i = 0; i < map.GetLength(1); i++)
   {
       for (int j = 0; j < map.GetLength(2); j++)
       {
           Rectangle rect = new Rectangle(x,y,30,30);
           int a = map[i, j];



       }

   }


            

        }
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

       
        protected override void UnloadContent()
        {
            
        }

       

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

           

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            spriteBatch.Begin();

            spriteBatch.End();
          

            base.Draw(gameTime);
        }
    }
}
