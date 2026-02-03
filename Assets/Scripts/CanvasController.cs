using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    [SerializeField] GameObject gameOverText;
    [SerializeField] GameObject scoreObject;

    void Start()
    {
        gameOverText.SetActive(false);
        Locator.Instance.Player.GameOver += HandleGameOver;
        Locator.Instance.Player.PointEarned += HandlePointEarned;
    }

    // Update is called once per frame
    void HandleGameOver()
    {
        gameOverText.SetActive(true);
    }

    void HandlePointEarned(int x)
    {
        TMP_Text scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = x.ToString();
    }
}
