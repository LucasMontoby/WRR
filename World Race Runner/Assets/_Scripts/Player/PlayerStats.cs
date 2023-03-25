using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    [SerializeField] public int currentHealth;

    [Header("GameManager")]
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.instance;
    }


    private void Update()
    {
        if (currentHealth <= 0)
        {
            //Time.timeScale = 0;
            SceneLoseGame();
        }
    }

    public void RemoveLife(int p_damage)
    {
        currentHealth -= p_damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void SceneLoseGame()
    {
        SceneManager.LoadScene("GameOver");
    }


}