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
        

	    int x  = Random.Range(1,3);//This generate random numbers for choosing animation for Input.GetKey(KeyCode.S)
             
        foreach (Touch touch in Input.touches)  
        {  
          if (touch.phase == TouchPhase.Began)  // Hold start position of input
          {  
            fp = touch.position;  
            lp = touch.position;  
          }  
   
          if (touch.phase == TouchPhase.Moved)  // Update touch position
          {  
            lp = touch.position;  
          }  
   
          if (touch.phase == TouchPhase.Ended) // Check input finishing 
          {            
            if (Mathf.Abs(lp.x - fp.x) > DragDistance || Mathf.Abs(lp.y - fp.y) > DragDistance)//  input happened ?   
            {           
             if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))  // input direction on x coordinates ?
             {         
              if (lp.x > fp.x)  // input to left
              {  
                   isD = true;
                   Animator.SetTrigger("isA");                     
              }  
              else  // input to right
              {  
                    isA = true;
                    Animator.SetTrigger("isD");  
              }  
             }  
             else // input direction on y coordinates 
             {                     
                if (lp.y > fp.y) // input to up 
                {  
                                     
                  isW = true;
                  Animator.SetTrigger("isW");  
                }  
                else // input to down 
                {  
                                     
                 isS = true;
            	 if(x == 1)
            	 {
                   Animator.SetTrigger("isS");
           		 }
            	 else
          		 {
               		Animator.SetTrigger("isS");
           		 } 
                }  
              }  
            }  
                     
          }  
        }  
    }  
} 