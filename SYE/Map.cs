public class Map
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Token[,] Tiles { get; set; }

    public Map(int width, int height)
    {
        Width = width;
        Height = height;
        Tiles = new Token[width, height];
    }

    public void AddToken(Token token, int x, int y) 
    {
        Tiles[x, y] = token;
    }

    public void MoveToken(Token token, int newX, int newY) 
    {
        // Find the token's current position and move it to the new position
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                if (Tiles[x, y] == token)
                {
                    Tiles[x, y] = null; // Remove from old position
                    Tiles[newX, newY] = token; // Add to new position
                    return;
                }
            }
        }
    }

    public void RemoveToken(int x, int y) 
    {
        Tiles[x, y] = null;
    }

    public bool IsEmpty(int x, int y) 
    {
        return Tiles[x, y] == null;
    }
}
