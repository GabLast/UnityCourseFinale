public static class GameManager
{
    public static int hp = 10;
    public static int totalStones = 0;
    public static int totalStonesDestroyed = 0;

    public static void ResetGame()
    {
        hp = 10;
        totalStones = 0;
        totalStonesDestroyed = 0;
    }
}
