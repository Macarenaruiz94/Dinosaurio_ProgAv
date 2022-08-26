using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string scene;
    public void Resetear()
    {
        SceneManager.LoadScene(scene);
    }
}
