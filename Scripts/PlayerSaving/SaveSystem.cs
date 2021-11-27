using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Characters characters, PlayerInventory playerInventory) {

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.dat";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        PlayerData playerData = new PlayerData(characters, playerInventory);

        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();


    }
   
    public static PlayerData LoadPlayer() {

        string path = Application.persistentDataPath + "/player.dat";
        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);

           PlayerData data = binaryFormatter.Deserialize(fileStream) as PlayerData;

            fileStream.Close();

            return data;

        }
        else {
            Debug.LogError("Save file not found in: " + path);
            return null;
        }

    }

   
    

}
