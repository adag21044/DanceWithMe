 using UnityEngine;  
 using UnityEngine.UI;  
 using System.Collections;  
   
 public class Dance : MonoBehaviour 
 {  
    
      Vector3 fp,lp;  
   
       
      [SerializeField] private float DragDistance;
      public Animator Animator;
      public bool isS;
      public bool isW;
      public bool isD;
      public bool isA;  

      void Start()
      {

      }

     
   
    void Update()  
    {  
        


             
      foreach (Touch touch in Input.touches)  
      {  
        OnTouchBegan(touch);
   
        OnTouchMove(touch);
   
        OnTouchFinish(touch);
      }  
    }  

    private void ChangeAnimation(ref bool direction, string animationId)
    {
    
        direction = true;
        Animator.SetTrigger(animationId);   
    }

    private void ChangeAnimationRandom(ref bool direction, string animationId)
    {
    
        direction = true;
        Animator.SetTrigger(animationId);   
    }

    private void OnTouchBegan(Touch touch)
    {
        if (touch.phase == TouchPhase.Began)  // Hold start position of input
          {  
            fp = touch.position;  
            lp = touch.position; 

            isA = false;
             isW = false;
              isD = false;
               isS = false;
          }  
    }

    private void OnTouchMove(Touch touch)
    {
      if (touch.phase == TouchPhase.Moved)  // Update touch position
          {  
            lp = touch.position;  
          }  
    }

    private void OnTouchFinish(Touch touch)
    {
      if (touch.phase == TouchPhase.Ended) // Check input finishing 
          {            
            if (Mathf.Abs(lp.x - fp.x) > DragDistance || Mathf.Abs(lp.y - fp.y) > DragDistance)//  input happened ?   
            {           
             if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))  // input direction on x coordinates ?
             {         
              if (lp.x > fp.x)  // input to left
              {  
                  ChangeAnimation(ref isD, "isD");                   
              }  
              else  // input to right
              {  
                  ChangeAnimation(ref isA, "isA");  
              }  
             }  
             else // input direction on y coordinates 
             {                     
                if (lp.y > fp.y) // input to up 
                {  
                  ChangeAnimation(ref isW, "isW");                  
                }  
                else // input to down 
                {  
                 int x  = Random.Range(0,3);//This generate random numbers for choosing animation for Input.GetKey(KeyCode.S)
            	   Animator.SetFloat("WhichAnimation",(float)x);

                 ChangeAnimationRandom(ref isS, "isS"); 
                }  
              }  
            }  
                     
          } 
    }
} 