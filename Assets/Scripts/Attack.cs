using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    public int hp = 4;
    public int killScore = 10;
    public AudioClip attackSound1;
    public AudioClip attackSound2;

    public void DamageEnemy (int loss)
    {
        SoundManager.instance.RandomizeSfx(attackSound1, attackSound2);
        hp -= loss;
        if (hp <= 0)
        {
            GameCounter.score += killScore;
            gameObject.SetActive(false);
        }
    }
}
