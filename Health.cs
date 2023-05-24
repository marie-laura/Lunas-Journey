using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource damageSoundEffect;
    [SerializeField] private AudioSource powerSoundEffect;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }
   
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            damageSoundEffect.Play();
            anim.SetTrigger("hurt");
            //iframes
        }
        else
        {
            if (!dead)
            {
                dead = true;
                Die();
            }
        }
    }

    public void AddHealth(float _value)
    {
        powerSoundEffect.Play();
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    private void Die()
    {
        deathSoundEffect.Play();
        anim.SetTrigger("die");
        GetComponent<PlayerMovement>().enabled = false;

    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }



}
