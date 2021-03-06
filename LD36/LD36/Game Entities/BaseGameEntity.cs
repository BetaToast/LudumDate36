using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LD36.Game_Entities
{
    public abstract class BaseGameEntity
    {
        public virtual Vector2 Position { get; set; }
        public virtual Texture2D Texture { get; set; }
        public virtual Vector2 Size { get; set; }
        public virtual Color Tint { get; set; }

	    public virtual Rectangle Bounds => new Rectangle(Position.ToPoint(), Size.ToPoint());

	    public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(GameTime gameTime)
        {
            ArchaicGame.SpriteBatch.Draw(Texture, Bounds, Tint);
        }

    }
}