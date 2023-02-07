[System.Serializable]
public class GameData
{
    public bool mode5points;

    public GameData(MainMenuController menuController)
    {
        mode5points = menuController.mode5points;
    }
}
