using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
    
    
    {
        public Slider slider;
        public Health playerHp;
        public PlayerHealth player;

        public void setMaxHealth(int health)
        {
            
            slider.maxValue = player.getMaxHealth();
            slider.value = player.getMaxHealth();
        }

        public void setHealth(int health)
        {
            slider.value = health;
        }

        public void updateHp(int hp){
            slider.value = Mathf.Max(hp,0,1f);
            print(slider.value);
        }
    }

  

