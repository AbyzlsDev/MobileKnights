using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Characters characters) {

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.dat";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        PlayerData playerData = new PlayerData(characters);

        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();


    }

    public static void SaveItems(PlayerInventory playerInventory)
    {

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerInv.dat";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        ItemData itemData = new ItemData(playerInventory);

        binaryFormatter.Serialize(fileStream, itemData);
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

    public static ItemData LoadItems()
    {

        string path = Application.persistentDataPath + "/playerInv.dat";
        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);

           ItemData itemData = binaryFormatter.Deserialize(fileStream) as ItemData;

            fileStream.Close();

            return itemData;

        }
        else
        {
            Debug.LogError("Save file not found in: " + path);
            return null;
        }

    }




}
