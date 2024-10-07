public class Token
{
    public int HP { get; set; }
    public int AC { get; set; }
    public int Speed { get; set; }
    public int Initiative { get; set; }
    public bool Alive { get; set; }
    public int ImId { get; set; }
    public (int x, int y) Position { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public Token(int hp, int ac, int speed, int initiative, bool alive, int imId, 
                 (int x, int y) position, int strength, int dexterity, 
                 int constitution, int intelligence, int wisdom, int charisma)
    {
        HP = hp;
        AC = ac;
        Speed = speed;
        Initiative = initiative;
        Alive = alive;
        ImId = imId;
        Position = position;
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }

    public void Attack() 
    {
        // Implementation for attack
    }

    public void Move(int x, int y) 
    {
        Position = (x, y);
    }

    public (int, int) GetPosition() 
    {
        return Position;
    }
}
