using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Play : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("PlayScene");
    }
}
