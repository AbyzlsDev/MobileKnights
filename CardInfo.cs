
using UnityEngine;
using UnityEngine.UI;

public class CardInfo : MonoBehaviour
{

    public Characters characters;

    public Text Speed;
    public Text Attack;
    public Text Name;
    public Text Description;
    //public Image Image;

    

    // Start is called before the first frame update
    

    void Start()
    {

        Speed.text = characters.speed.ToString();
        Attack.text = characters.damage.ToString();
        Name.text = characters.Name.ToString();
        Description.text = characters.description.ToString();
        




    }

   
    
}
