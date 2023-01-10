
using UnityEngine;

public class SelectionArrow : MonoBehaviour
{
    private RectTransform rect; 
    [SerializeField]private RectTransform[] options;
    
    [SerializeField]private AudioClip changeSound;
    [SerializeField]private AudioClip interactound;
    private int currentPosition;
    private void Awake(){
        rect = GetComponent<RectTransform>();
    }
    
    private void Updete(){
        if(Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
            ChangePosition(-1);
        else if(Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.DownArrow))
            ChangePosition(1);
    }
    private void ChangePosition(int _change){
        currentPosition +=_change;
    if(_change != 0)
    //SoundManager.instance.PlaySound(changeSound);

        if(currentPosition < 0)
            currentPosition = options.Length - 1;
            else if (currentPosition > options.Length - 1)
                currentPosition= 0;
        // Assign the Y position of the current option to the arrow(basically moving it up/down)
        rect.position = new Vector3(rect.position.x,options[currentPosition].position.y, 0);
    }
}
