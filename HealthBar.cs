
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public PlayerControler PlayerControler;

    public Characters Characters;

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = Characters.maxHP;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = PlayerControler.HP;
        
    }
}
