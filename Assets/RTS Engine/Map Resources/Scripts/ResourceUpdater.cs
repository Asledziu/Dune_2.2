using UnityEngine;
//using RTSEngine;

public class ResourceUpdater : MonoBehaviour{
    public RTSEngine.Resource resource;
    public float resourceRegenerationSpeed = 0.5f;
    public int MaxAmount = 10050;
    public int LargeModelChange = 9999;
    public int MediumModelChange = 5000;
    public int SmallModelChange = 2000;
    public int regres = 0;


    private float timer = 0f;
        [SerializeField]
        public GameObject almostFullModel =null;
        [SerializeField]
        public GameObject halfFullModel =null;
        [SerializeField]
        public GameObject almoustEmptyModel =null;



    void Update(){
       
        timer += Time.deltaTime;
        if (resource.amount < MaxAmount)
        {
            if(timer >= resourceRegenerationSpeed)
            {
                timer -= resourceRegenerationSpeed;
                
                resource.amount += regres;
            }   
        }
                    if (resource.amount < LargeModelChange) 
                    {
                        almostFullModel.SetActive(true);
                        halfFullModel.SetActive(false);
                        almoustEmptyModel.SetActive(false);
                    }
                    if (resource.amount < MediumModelChange) 
                    {
                        almostFullModel.SetActive(false);
                        halfFullModel.SetActive(true);
                        almoustEmptyModel.SetActive(true);
                    }
                    if (resource.amount < SmallModelChange)
                    {
                        almostFullModel.SetActive(false);
                        halfFullModel.SetActive(false);
                        almoustEmptyModel.SetActive(true);
                    }
    }

}