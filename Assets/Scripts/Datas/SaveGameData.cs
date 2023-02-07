using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGameData
{
    public static void Save_GameData(MainMenuController mainMenu)
    {
        GameData gameData = new GameData(mainMenu);
        string gameDataPath = Application.persistentDataPath + "/gameData.svdt";
        FileStream fileStream = new FileStream(gameDataPath, FileMode.Create);
        BinaryFormatter binaryFormatter= new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, gameData);
        fileStream.Close();

        Debug.Log("Datos guardados");
    }

    public static GameData Load_GameData()
    {
        string gameDataPath = Application.persistentDataPath + "/gameData.svdt";

        if(File.Exists(gameDataPath)) 
        {
            FileStream fileStream = new FileStream(gameDataPath, FileMode.Open);
            BinaryFormatter binaryFormatter= new BinaryFormatter();
            GameData gameData = (GameData) binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return gameData;

            Debug.Log("Datos cargados");
        }
        else
        {
            Debug.Log("No se encontró un archivo de guardado");
            return null;
        }
    }
}
