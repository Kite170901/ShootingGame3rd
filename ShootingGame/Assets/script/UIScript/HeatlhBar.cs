using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeatlhBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    [SerializeField]
    private Enemy enemyScript;


    private void Awake()
    {
        enemyScript = GetComponentInParent<Enemy>();
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void setHeatlh(float health)
    {
        slider.value = health;
    }
     
}
