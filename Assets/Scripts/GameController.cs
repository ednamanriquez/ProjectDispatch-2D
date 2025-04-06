using System.IO;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private string saveLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData");
    }

    // Update is called once per frame
    public void SaveGame()
    {
        SaveData saveData = new SaveData
        {
            playerPos = GameObject.Find("Player").transform.position,
            mapBoundary = GameObject.Find()
        }
    }
}
