using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] AudioSource explode;
    [SerializeField] AudioSource jump;
    [SerializeField] AudioSource coin;
    void Start()
    {
        Locator.Instance.Player.GameOver += HandleGameOver;
        Locator.Instance.Player.PlayerFlapped += HandleFlap;
        Locator.Instance.Player.PointEarned += HandleGetPoint;
    }

    void HandleGameOver()
    {
        explode.Play();
    }

    void HandleGetPoint(int x)
    {
        coin.Play();
    }

    void HandleFlap()
    {
        jump.Play();
    }
}
