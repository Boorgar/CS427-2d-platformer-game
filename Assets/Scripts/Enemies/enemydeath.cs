using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydeath : MonoBehaviour
{
    // Start is called before the first frame update
    private enemyPatrol enemy_patrol;
    private Animator anim;
    [SerializeField] private int score;
    [SerializeField] public int health;
    public GameManager gameManager;

    public bool isDead = false;

    [SerializeField]
    private Behaviour[] components;

    void Start()
    {
        gameManager = GameManager.instance;
        if (gameManager == null)
            Debug.Log("no game manager");
        anim = GetComponent<Animator>();
        enemy_patrol = GetComponentInParent<enemyPatrol>();   
    }
    public void takeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            death();
        }
    }

    private void death()
    {
        if (!isDead)
            isDead = true;
        else
            return;
        anim.SetTrigger("death");
        Debug.Log("enemy died");
        gameManager.addScore(score);
        foreach (Behaviour component in components)
        {
            component.enabled = false;
        }
    }

    private void gone()
    {
        
        if (enemy_patrol != null)
            Destroy(enemy_patrol.gameObject);
        Destroy(gameObject);
    }
}
