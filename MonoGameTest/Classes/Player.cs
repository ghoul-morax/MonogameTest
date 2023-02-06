using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameSpaceWar.classes
{
    internal class Player
    {
        private Vector2 position;
        private Texture2D texture;
        
        public Player()
        {
            position = new Vector2(50, 50);
            texture = null;
        }

        public void LoadContent(ContentManager manager)
        {
           texture =  manager.Load<Texture2D>("player");
        }
        public void Update()
        {
            position.Y -= 1;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
