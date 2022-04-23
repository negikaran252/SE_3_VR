using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text game_score;
    public Database my_db;
    void Start()
    {
        game_score.text=my_db.prev.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
