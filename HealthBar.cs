
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Characters characters;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = characters.maxHP;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = characters.HP;
        
    }
}
