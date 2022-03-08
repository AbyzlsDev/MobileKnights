using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;

public class LevelDataSaveSystem
{
    public static void SaveLevelData(GetEnemiesInScene getEnemiesInScene, Target target)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/levelData.save";

        FileStream fs = new FileStream(path, FileMode.Create);

        AllEnemyData enemyData = new AllEnemyData(getEnemiesInScene, target);

        binaryFormatter.Serialize(fs, enemyData);

        fs.Close();

    }

    public static AllEnemyData LoadLevelData()
    {
        string path = Application.persistentDataPath + "/levelData.save";

        if (File.Exists(path))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileStream fs = new FileStream(path, FileMode.Open);

            AllEnemyData data = binaryFormatter.Deserialize(fs) as AllEnemyData;

            fs.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in: " + path);
            
            return null;
        }

    }


}
