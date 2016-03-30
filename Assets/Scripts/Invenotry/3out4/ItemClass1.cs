using UnityEngine;
using System.Collections;

public class ItemClass1 : MonoBehaviour
{

    //Icons
    /*static public Texture2D Cog16;
    static public Texture2D Cog26;
    static public Texture2D Cog36;
    static public Texture2D Cog46;
    static public Texture2D Cog56;
    static public Texture2D Cog66;*/

    // Items
    public ItemCreatorClass1 cog16 = new ItemCreatorClass1(0, "Part 1/6", null, "Cogwheel fraction 1/6");
    public ItemCreatorClass1 cog26 = new ItemCreatorClass1(1, "Part 2/6", null, "Cogwheel fraction 2/6");
    public ItemCreatorClass1 cog36 = new ItemCreatorClass1(2, "Part 3/6", null, "Cogwheel fraction 3/6");
    public ItemCreatorClass1 cog46 = new ItemCreatorClass1(3, "Part 4/6", null, "Cogwheel fraction 4/6");
    public ItemCreatorClass1 cog56 = new ItemCreatorClass1(4, "Part 5/6", null, "Cogwheel fraction 5/6");
    public ItemCreatorClass1 cog66 = new ItemCreatorClass1(5, "Whole 6/6", null, "Cogwheel fraction 6/6");


    void Start()
    {
    }
    void Update()
    {
    }

    public class ItemCreatorClass1
    {
        public int id;
        public string name;
        public Texture2D icon;
        public string description;

        public ItemCreatorClass1(int id1, string name1, Texture2D icon1, string description1)
        {
            id = id1;
            name = name1;
            icon = icon1;
            description = description1;
        }
        public void SetIcon(Texture2D icon1)
        {
            icon = icon1;
        }
    }
}
