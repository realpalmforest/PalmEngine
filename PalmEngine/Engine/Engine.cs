using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PalmEngine.Components;

namespace PalmEngine.Engine;

public class Engine
{
    // Essentials
    public SpriteBatch SpriteBatch;

    // Engine
    public List<GameObject> GameObjects = new();

    public Engine(SpriteBatch spriteBatch)
    {
        SpriteBatch = spriteBatch;
    }

    public void Update()
    {

    }

    public void Draw()
    {
        foreach (GameObject obj in GameObjects)
        {
            if (obj is IDrawableSprite)
            {
                (obj as IDrawableSprite).Draw(SpriteBatch);
            }
        }
    }
}