using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;

public static class SaveSystem
{
    public static void SavePlayer(PlayerControler playerControler, PlayerInventory playerInventory) {
       

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.dat";
        FileStream fileStream = new FileStream(path, FileMode.Create);
    
       AllData allData = new AllData(playerControler, playerInventory);
        
        binaryFormatter.Serialize(fileStream, allData);
        
        fileStream.Close();


    }


    public static AllData LoadPlayer() {

       string path = Application.persistentDataPath + "/player.dat";

        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);

            AllData data = binaryFormatter.Deserialize(fileStream) as AllData;

            fileStream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in: " + path);

            return null;

        }


    }
    
    



}



