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
        Rectangle hero_pos = new Rectangle(0,450,30,30);
        Vector2 blok_1_pose = new Vector2(180,450);
        Vector2 blok_2_pose = new Vector2(210,420);
        float timeForJump = 0.3f;
        float time_jump = 0;
        bool jump = false;
        List<Box> boxs;
        
 
      
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
           graphics.PreferredBackBufferHeight =  480;

            graphics.PreferredBackBufferWidth = 600; 
            
        }

      
        protected override void Initialize()
        {
           

            base.Initialize();
        }
        
      
        protected override void LoadContent()
        {
            Greatemap();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            hero = Content.Load<Texture2D>("hero.tif");
            blok_1= Content.Load<Texture2D>("blok_1.jpg");
           blok_2 = Content.Load<Texture2D>("blok_2.png");
           Greatemap();

        }

       
        protected override void UnloadContent()
        {
            
        }


        void Greatemap()
        {
            int[,] map;

            boxs = new List<Box>();

            map = new int[16,20] 
  {{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, 
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
  {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};
            int x = 0;
            int y = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Rectangle rect = new Rectangle(x, y, 30, 30);
                    int a = map[i, j];

                    if (a == 1)
                    {
                        Box box = new Box(blok_1,rect);
                        boxs.Add(box);
                       

                    }
                 
                    x += 30;
                }
                x = 0;
                y += 30;
            }

        }
       

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                hero_pos.X += 2;

                
            }

            Greatemap();
            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();
            foreach (Box box in boxs)
            {
                box.Draw(spriteBatch);
            } 
            spriteBatch.Draw(hero, hero_pos, Color.White);
            spriteBatch.Draw(blok_1, blok_1_pose, Color.White);
            spriteBatch.Draw(blok_2, blok_2_pose, Color.White);
            spriteBatch.End();
          

            base.Draw(gameTime);
        }
    }
}
